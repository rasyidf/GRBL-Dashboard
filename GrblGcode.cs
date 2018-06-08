using System;
using System.IO;

namespace GrblPanel
{
    public class GrblGcode
    {
        private GrblGui _gui;
        private StreamReader _inputfh;

        public string GcodeFile { get; private set; }

        private int _inputcount;
        private Elapsed _elapsed;

        public bool runMode { get; set; }

        public bool wtgForAck { get; set; }

        public bool stepMode { get; set; }

        public bool sendAnotherLine { get; set; }

        public int linesDone { get; set; }
        public int lineCount { get; set; }

        public bool m30Flag { get; set; }
        public string TotalLines { get; private set; }
        public string CurrentLine { get; private set; }
        public string GCodeMessage { get; private set; }

        public GrblGcode()
        {
            this.wtgForAck = false;
            this.runMode = true;
            this.stepMode = false;
            this.sendAnotherLine = false;
            this.lineCount = 0;
            this.linesDone = 0;
            this.m30Flag = false;
        }

        public void enableGCode(bool action)
        {
            this._gui.gbGcode.Enabled = action;
            if (action)
            {
                this._gui.grblPort.AddRcvDelegate(new GrblIF.grblDataReceived(this._gui.processLineEvent));
                this._gui.btnFileSelect.Enabled = true;
                return;
            }
            this._gui.grblPort.DeleteRcvDelegate(new GrblIF.grblDataReceived(this._gui.processLineEvent));
        }

        public bool loadGCodeFile(string file)
        {
            this.ResetGcode(true);
            this._inputfh = MyProject.Computer.FileSystem.OpenTextFileReader(file);
            this._inputcount = 0;
            checked
            {
                while (!this._inputfh.EndOfStream)
                {
                    string data = this._inputfh.ReadLine();
                    if (String.Compare(data, "%", false) != 0)
                    {
                        Insert(data, "File", (this._inputcount + 1).ToString());
                        this._inputcount++;
                    }
                }
                this.lineCount = this._inputcount;
                this._gui.lblTotalLines.Text = this._inputcount.ToString();
                RefreshView(this.lineCount);
                if (!Information.IsNothing(this._inputfh))
                {
                    this._inputfh.Close();
                }
                return true;
            }
        }

        public void closeGCodeFile()
        {
            if (this._inputfh != null)
            {
                this._inputfh.Close();
            }
            GcodeFile = "";
            this._inputcount = 0;
        }

        public void sendGcodeFile()
        {
            this._elapsed.BeginTimer();
            this.lineCount = this._inputcount;
            this.linesDone = 0;
            this.wtgForAck = false;
            this.runMode = true;
            this.sendAnotherLine = true;
            FileMode = true;
        }

        public void sendGCodeLine(string data)
        {
            this.runMode = false;
            FileMode = false;
            if (data.StartsWith("$J") || (!data.StartsWith("$") && !data.StartsWith("?")))
            {
                GrblGcodeView expr_3E = new GrblGcodeView();
                expr_3E.Insert(data, "MDI", Convert.ToString(0));
                GrblGcode.lineCount = checked(gcode.lineCount + 1);
                expr_3E.UpdateGcodeSent(-1);
                this.wtgForAck = true;
            }
            this._gui.state.ProcessGCode(data);
            this._gui.grblPort.SendData(data);
        }

        public void sendGCodeFilePause()
        {
            this._elapsed.StopTimer();
            this.sendAnotherLine = false;
            this.runMode = false;
        }

        public void sendGCodeFileResume()
        {
            this._elapsed.ResumeTimer();
            this.sendAnotherLine = true;
            this.runMode = true;
            this.stepMode = false;
            fileMode = true;
            this._gui.processLineEvent("");
        }

        public void sendGCodeFileStep()
        {
            this.sendAnotherLine = true;
            this.runMode = false;
            this.stepMode = true;
            FileMode = true;
            this._gui.processLineEvent("");
        }

        public void sendGCodeFileStop()
        {
            this._elapsed.StopTimer();
            if (this.runMode)
            {
                this.wtgForAck = false;
                this.runMode = false;
                this.sendAnotherLine = false;
                fileMode = false;
                this._gui.btnFileGroup_Click(this._gui.btnFileStop, null);
            }
        }

        public void sendGCodeFileRewind()
        {
            this._elapsed.StopTimer();
            if (this.runMode)
            {
                this.wtgForAck = false;
                this.runMode = false;
                this.sendAnotherLine = false;
                fileMode = false;
                gcode.sendGCodeFilePause();
                GrblGui expr_46 = this._gui;
                expr_46.setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Idle);
                expr_46.btnFileSelect.Enabled = true;
                expr_46.btnFileSend.Tag = "Send";
                expr_46.btnFileSend.Enabled = true;
                expr_46.btnFilePause.Enabled = false;
                expr_46.btnFileStop.Enabled = false;
                expr_46.btnFileReload.Enabled = true;
                expr_46.lblCurrentLine.Text = "0";
            }
            Rewind();
        }

        public void shutdown()
        {
            this.ResetGcode(true);
        }

        public void ResetGcode(bool fullstop)
        {
            this.lineCount = 0;
            this.linesDone = 0;
            TotalLines = "";
            CurrentLine = "0";
            GCodeMessage = "";
            this._elapsed.ResetTimer();
            this.wtgForAck = false;
            this.runMode = false;
            this.sendAnotherLine = false;
            if (fullstop)
            {
                this.closeGCodeFile();
                Clear();
            }
        }
    }
}