namespace GrblPanel
{
    public class GrblPosition
    {
        private GrblGui _gui;
        private decimal _wcoX;
        private decimal _wcoY;
        private decimal _wcoZ;

        public decimal WcoX
        {
            get
            {
                return this._wcoX;
            }
            set
            {
                this._wcoX = value;
            }
        }

        public decimal WcoY
        {
            get
            {
                return this._wcoY;
            }
            set
            {
                this._wcoY = value;
            }
        }

        public decimal WcoZ
        {
            get
            {
                return this._wcoZ;
            }
            set
            {
                this._wcoZ = value;
            }
        }

        public GrblPosition(ref GrblGui gui)
        {
            this._gui = gui;
            MyProject.Forms.Connected += new ConnectedEventHandler(this.GrblConnected);
            this._gui.settings.GrblSettingsRetrievedEvent += new GrblSettings.GrblSettingsRetrievedEventEventHandler(this.GrblSettingsRetrieved);
        }

        public void enablePosition(bool action)
        {
            this._gui.gbPosition.Enabled = action;
            if (action)
            {
                this._gui.grblPort.AddRcvDelegate(new GrblIF.grblDataReceived(this._gui.showGrblPositions));
                return;
            }
            this._gui.grblPort.DeleteRcvDelegate(new GrblIF.grblDataReceived(this._gui.showGrblPositions));
        }

        public void shutdown()
        {
            this.enablePosition(false);
        }

        private void GrblConnected(string msg)
        {
            if (String.Compare(msg, "Connected", false) == 0)
            {
                this._gui.btnHome.BackColor = Color.Crimson;
            }
        }

        private void GrblSettingsRetrieved()
        {
            if (this._gui.settings.IsHomingEnabled == 1)
            {
                this._gui.btnHome.Visible = true;
            }
            this._gui.cbUnits.Checked = this._gui.settings.IsGrblMetric;
        }
    }
}