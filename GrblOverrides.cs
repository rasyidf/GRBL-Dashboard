namespace GrblPanel
{
    public enum overrideChars
    {
        CMD_SAFETY_DOOR = 132,
        CMD_JOG_CANCEL,
        CMD_DEBUG_REPORT = 133,
        CMD_FEED_OVR_RESET = 144,
        CMD_FEED_OVR_COARSE_PLUS,
        CMD_FEED_OVR_COARSE_MINUS,
        CMD_FEED_OVR_FINE_PLUS,
        CMD_FEED_OVR_FINE_MINUS,
        CMD_RAPID_OVR_FULL,
        CMD_RAPID_OVR_MEDIUM,
        CMD_RAPID_OVR_LOW,
        CMD_SPINDLE_OVR_RESET = 153,
        CMD_SPINDLE_OVR_COARSE_PLUS,
        CMD_SPINDLE_OVR_COARSE_MINUS,
        CMD_SPINDLE_OVR_FINE_PLUS,
        CMD_SPINDLE_OVR_FINE_MINUS,
        CMD_SPINDLE_OVR_STOP,
        CMD_TOGGLE_FLOOD = 160,
        CMD_TOGGLE_MIST
    }

    public class GrblOverrides
    {
        private GrblGui _gui;

        public GrblOverrides(ref GrblGui gui)
        {
            this._gui = gui;
            this._gui.settings.GrblSettingsRetrievedEvent += new GrblSettings.GrblSettingsRetrievedEventEventHandler(this.GrblSettingsRetrieved);
            MyProject.Forms.Connected += new ConnectedEventHandler(this.GrblConnected);
        }

        private void GrblSettingsRetrieved()
        {
            if (this._gui.settings.IsOverrideCapable)
            {
                this._gui.gbOverrides.Visible = true;
            }
        }

        private void GrblConnected(string msg)
        {
            if (String.Compare(msg, "Connected", false) == 0)
            {
                this._gui.grblPort.AddRcvDelegate(new GrblIF.grblDataReceived(this._gui.showOverrides));
                return;
            }
            this._gui.grblPort.DeleteRcvDelegate(new GrblIF.grblDataReceived(this._gui.showOverrides));
        }
    }
}