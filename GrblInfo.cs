using System;

namespace GrblPanel
{
    public class GrblInfo
    {
        private GrblGui _gui;
        private bool _single;

        public bool once
        {
            get
            {
                return this._single;
            }
            set
            {
                this._single = value;
            }
        }

        public GrblInfo(ref GrblGui gui)
        {
            this._gui = gui;
            MyProject.Forms.Connected += new ConnectedEventHandler(this.GrblConnected);
        }

        private void GrblConnected(string msg)
        {
            if (String.Compare(msg, "Connected", false) == 0)
            {
                this._gui.grblPort.AddRcvDelegate(new GrblIF.grblDataReceived(this._gui.processVerOptMessages));
                gcode.sendGCodeLine("$I");
                this.once = true;
            }
        }
    }
}