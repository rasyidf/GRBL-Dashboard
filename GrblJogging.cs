using System.Windows.Forms;

namespace GrblPanel
{
    public class GrblJogging
    {
        private GrblGui _gui;

        public GrblJogging(ref GrblGui gui)
        {
            this._gui = gui;
            this._gui.settings.GrblSettingsRetrievedEvent += new GrblSettings.GrblSettingsRetrievedEventEventHandler(this.GrblSettingsRetrieved);
            MySettings settings = MySettingsProperty.Settings;
            this._gui.tbSettingsFIImperial.Text = settings.JoggingFIImperial;
            this._gui.tbSettingsFRImperial.Text = settings.JoggingFRImperial;
            this._gui.tbSettingsFIMetric.Text = settings.JoggingFIMEtric;
            this._gui.tbSettingsFRMetric.Text = settings.JoggingFRMetric;
            this._gui.cbSettingsMetric.Checked = settings.JoggingUnitsMetric;
            this._gui.setDistanceMetric(this._gui.cbSettingsMetric.Checked);
            checked
            {
                this._gui.btnXPlus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(settings.JoggingXRepeat));
                this._gui.btnXMinus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(settings.JoggingXRepeat));
                this._gui.btnYPlus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(settings.JoggingYRepeat));
                this._gui.btnYMinus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(settings.JoggingYRepeat));
                this._gui.btnZPlus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(settings.JoggingZRepeat));
                this._gui.btnZMinus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(settings.JoggingZRepeat));
                try
                {
                    IEnumerator enumerator = this._gui.gbDistance.Controls.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        RadioButton rb = (RadioButton)enumerator.Current;
                        if (String.Compare((string)rb.Tag, MySettingsProperty.Settings.JoggingFIDefault, false) == 0)
                        {
                            rb.Checked = true;
                        }
                    }
                }
                finally
                {
                    IEnumerator enumerator;
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                try
                {
                    IEnumerator enumerator2 = this._gui.gbFeedRate.Controls.GetEnumerator();
                    while (enumerator2.MoveNext())
                    {
                        RadioButton rb2 = (RadioButton)enumerator2.Current;
                        if (String.Compare((string)rb2.Tag, MySettingsProperty.Settings.JoggingFRDefault, false) == 0)
                        {
                            rb2.Checked = true;
                        }
                    }
                }
                finally
                {
                    IEnumerator enumerator2;
                    if (enumerator2 is IDisposable)
                    {
                        (enumerator2 as IDisposable).Dispose();
                    }
                }
            }
        }

        public bool enableJogging(bool action)
        {
            this._gui.gbJogging.Enabled = action;
            return true;
        }

        public void shutdown()
        {
            this.enableJogging(false);
        }

        private void GrblSettingsRetrieved()
        {
            this._gui.cbUnits.Checked = this._gui.settings.IsGrblMetric;
        }
    }
}