namespace GrblPanel
{
    public class GrblPins
    {
        private GrblGui _gui;
        private bool _limits;
        private bool _pins;

        public bool LimitsSeen
        {
            get
            {
                return this._limits;
            }
            set
            {
                this._limits = value;
                this._gui.gbPinStatus.Visible = value;
                if (value)
                {
                    GrblGui expr_21 = this._gui;
                    expr_21.cbLimitX.Visible = true;
                    expr_21.cbLimitY.Visible = true;
                    expr_21.cbLimitZ.Visible = true;
                }
            }
        }

        public bool PinsSeen
        {
            get
            {
                return this._pins;
            }
            set
            {
                this._pins = value;
                this._gui.gbPinStatus.Visible = value;
                if (value)
                {
                    GrblGui expr_21 = this._gui;
                    expr_21.cbLimitX.Visible = true;
                    expr_21.cbLimitY.Visible = true;
                    expr_21.cbLimitZ.Visible = true;
                    expr_21.cbProbePin.Visible = true;
                    expr_21.cbResetAbort.Visible = true;
                    expr_21.cbFeedHold.Visible = true;
                    expr_21.cbStartResume.Visible = true;
                }
            }
        }

        public GrblPins(ref GrblGui gui)
        {
            this._gui = gui;
            this._gui.grblPort.AddRcvDelegate(new GrblIF.grblDataReceived(this._gui.showGrblPins));
        }

        private bool enablePinStatus(bool action)
        {
            this._gui.gbPinStatus.Visible = action;
            if (!action)
            {
                this._gui.grblPort.DeleteRcvDelegate(new GrblIF.grblDataReceived(this._gui.showGrblPins));
            }
            return true;
        }

        public void shutdown()
        {
            this.enablePinStatus(false);
        }
    }
}