using GrblPanel.My.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace GrblPanel
{
    public class GrblGcodeView
    {
        private DataGridView _dgview;
        private List<GcodeItem> _gcodeTable;
        private bool _filemode;
        private readonly BindingSource _source;
        private GrblErrorsSingleton GrblErrors;
        private Dictionary<string, string> _errors;

        public bool fileMode
        {
            get
            {
                return this._filemode;
            }
            set
            {
                this._filemode = value;
            }
        }

        public GrblGcodeView(ref DataGridView view)
        {
            this._filemode = false;
            this._source = new BindingSource();
            this.GrblErrors = GrblErrorsSingleton.GetInstance();
            this._errors = this.GrblErrors.GetErrorsDct();
            this._gcodeTable = new List<GcodeItem>();
            this._dgview = view;
            DataGridView dgv = this._dgview;
            this.DoubleBuffered(ref this._dgview, true);
            dgv.DefaultCellStyle.Font = new Font("microsoft san serif", 10f);
            dgv.RowTemplate.Height = 17;
            dgv.RowCount = 17;
            dgv.Columns["stat"].Width = 46;
            dgv.Columns["stat"].HeaderText = "Sts";
            dgv.Columns["lineNum"].Width = 46;
            dgv.Columns["lineNum"].HeaderText = Resources.GrblGcodeView_New_Line;
            dgv.Columns["data"].Width = 459;
            dgv.Columns["data"].HeaderText = "Gcode";
        }

        private void DoubleBuffered(ref DataGridView dgv, bool setting)
        {
            dgv.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgv, setting);
        }

        public void Clear()
        {
            this._gcodeTable.Clear();
            this._filemode = false;
            this._dgview.RowCount = 0;
            this._dgview.Refresh();
        }

        public void Insert(string data, string source, string lineNumber)
        {
            GcodeItem newGcode = new GcodeItem
            {
                Gcode = data,
                LineNum = Convert.ToInt32(lineNumber)
            };
            if (String.Compare(source, "File", false) == 0)
            {
                newGcode.File = true;
                this._gcodeTable.Add(newGcode);
                return;
            }
            if (String.Compare(source, "MDI", false) != 0)
            {
                return;
            }
            newGcode.File = false;
            this._gcodeTable.Add(newGcode);
            this.RefreshView(this._gcodeTable.Count);
        }

        public string readGcode(int lineCount, int linesDone)
        {
            string readGcode;
            if (lineCount > 0)
            {
                readGcode = this._gcodeTable[linesDone].Gcode;
            }
            else
            {
                readGcode = "EOF";
            }
            return readGcode;
        }

        public GcodeItem GetGcodeItem(int index)
        {
            GcodeItem GetGcodeItem;
            if (this._gcodeTable.Count > 0)
            {
                GetGcodeItem = this._gcodeTable[index];
            }
            else
            {
                GetGcodeItem = null;
            }
            return GetGcodeItem;
        }

        public string readGcodePrevious(int lineCount, int linesDone)
        {
            string readGcodePrevious;
            if (lineCount >= 0)
            {
                readGcodePrevious = this._gcodeTable[checked(linesDone - 1)].Gcode;
            }
            else
            {
                readGcodePrevious = "EOF";
            }
            return readGcodePrevious;
        }

        public void UpdateGCodeStatus(string stat, int index)
        {
            int firstDisplayed = this._dgview.FirstDisplayedScrollingRowIndex;
            int displayCount = this._dgview.DisplayedRowCount(false);
            checked
            {
                if (stat.StartsWith("error:") && char.IsDigit(stat["error:".Length + 1]))
                {
                    int errorCode = (int)Convert.ToInt16(stat.Substring(6, stat.Length - 6 - 2));
                    stat = stat + ": " + this._errors[Convert.ToString(errorCode)];
                }
                if (this._filemode)
                {
                    this._gcodeTable[index].Status = stat;
                    if (index < firstDisplayed)
                    {
                        this._dgview.FirstDisplayedScrollingRowIndex = 0;
                    }
                    else
                    {
                        if (firstDisplayed + displayCount <= index)
                        {
                            this._dgview.FirstDisplayedScrollingRowIndex = index - displayCount;
                        }
                    }
                }
                else
                {
                    this._gcodeTable[this._gcodeTable.Count - 1].Status = stat;
                    index = this._dgview.RowCount - 1;
                    if (index < firstDisplayed)
                    {
                        this._dgview.FirstDisplayedScrollingRowIndex = 0;
                    }
                    else
                    {
                        if (firstDisplayed + displayCount <= index && index != 0)
                        {
                            this._dgview.FirstDisplayedScrollingRowIndex = index - displayCount + 2;
                        }
                    }
                }
                if (firstDisplayed <= displayCount)
                {
                    this._dgview.Refresh();
                }
            }
        }

        public void UpdateGcodeSent(int index)
        {
            if (this._filemode)
            {
                this._gcodeTable[index].Status = "Sent";
                return;
            }
            this._gcodeTable[checked(this._gcodeTable.Count + index)].Status = "Sent";
            this._dgview.Refresh();
        }

        public void RefreshView(int lineCount)
        {
            this._dgview.RowCount = lineCount;
            this._dgview.Refresh();
        }

        public void Rewind()
        {
            using (var enumerator = this._gcodeTable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.Status = null;
                }
            }
            this._dgview.FirstDisplayedScrollingRowIndex = 0;
            this._dgview.Refresh();
        }

        public void DisplayTop()
        {
            this._dgview.FirstDisplayedScrollingRowIndex = 0;
        }
    }
}