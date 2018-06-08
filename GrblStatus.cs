namespace GrblPanel
{
    public class GrblStatus
    {
        public class TimerInfo
        {
            public int count;
        }

        private GrblGui _gui;
        public GrblStatus.TimerInfo timerState;

        public GrblStatus(ref GrblGui gui)
        {
            this._gui = gui;
            this._gui.prgBarQ.Maximum = (int)Convert.ToInt16(MySettingsProperty.Settings.QBuffMaxSize);
            this._gui.prgbRxBuf.Maximum = (int)Convert.ToInt16(MySettingsProperty.Settings.RBuffMaxSize);
            this.timerState = new GrblStatus.TimerInfo
            {
                count = 0
            };
        }

        public bool enableStatus(bool action)
        {
            this._gui.gbStatus.Enabled = action;
            if (action)
            {
                this._gui.grblPort.AddRcvDelegate(new GrblIF.grblDataReceived(this._gui.showGrblStatus));
            }
            else
            {
                this._gui.grblPort.DeleteRcvDelegate(new GrblIF.grblDataReceived(this._gui.showGrblStatus));
            }
            return true;
        }

        public void shutdown()
        {
            this._gui.statusPrompt(Resources.GrblGui_btnConnDisconnect_Click_End);
            this.enableStatus(false);
        }
    }
}