using System.Collections.Generic;
using System.Windows.Forms;

namespace GrblPanel
{
    public class GrblSettings
    {
        public delegate void GrblSettingsRetrievedEventEventHandler();

        private GrblGui _gui;
        private DataTable _paramTable;
        private int _nextParam;
        private Dictionary<string, string> _settings;

        [CompilerGenerated]
        private GrblSettings.GrblSettingsRetrievedEventEventHandler GrblSettingsRetrievedEventEvent;

        public event GrblSettings.GrblSettingsRetrievedEventEventHandler GrblSettingsRetrievedEvent
        {
            [CompilerGenerated]
            add
            {
                GrblSettings.GrblSettingsRetrievedEventEventHandler grblSettingsRetrievedEventEventHandler = this.GrblSettingsRetrievedEventEvent;
                GrblSettings.GrblSettingsRetrievedEventEventHandler grblSettingsRetrievedEventEventHandler2;
                do
                {
                    grblSettingsRetrievedEventEventHandler2 = grblSettingsRetrievedEventEventHandler;
                    GrblSettings.GrblSettingsRetrievedEventEventHandler value2 = (GrblSettings.GrblSettingsRetrievedEventEventHandler)Delegate.Combine(grblSettingsRetrievedEventEventHandler2, value);
                    grblSettingsRetrievedEventEventHandler = Interlocked.CompareExchange<GrblSettings.GrblSettingsRetrievedEventEventHandler>(ref this.GrblSettingsRetrievedEventEvent, value2, grblSettingsRetrievedEventEventHandler2);
                }
                while (grblSettingsRetrievedEventEventHandler != grblSettingsRetrievedEventEventHandler2);
            }
            [CompilerGenerated]
            remove
            {
                GrblSettings.GrblSettingsRetrievedEventEventHandler grblSettingsRetrievedEventEventHandler = this.GrblSettingsRetrievedEventEvent;
                GrblSettings.GrblSettingsRetrievedEventEventHandler grblSettingsRetrievedEventEventHandler2;
                do
                {
                    grblSettingsRetrievedEventEventHandler2 = grblSettingsRetrievedEventEventHandler;
                    GrblSettings.GrblSettingsRetrievedEventEventHandler value2 = (GrblSettings.GrblSettingsRetrievedEventEventHandler)Delegate.Remove(grblSettingsRetrievedEventEventHandler2, value);
                    grblSettingsRetrievedEventEventHandler = Interlocked.CompareExchange<GrblSettings.GrblSettingsRetrievedEventEventHandler>(ref this.GrblSettingsRetrievedEventEvent, value2, grblSettingsRetrievedEventEventHandler2);
                }
                while (grblSettingsRetrievedEventEventHandler != grblSettingsRetrievedEventEventHandler2);
            }
        }

        public int IsHomingEnabled
        {
            get
            {
                DataRow row = this._paramTable.Rows.Find("$22");
                int IsHomingEnabled;
                if (!Information.IsNothing(row))
                {
                    IsHomingEnabled = Convert.ToInt32(row[Resources.GrblSettings_FillSettings_Value]);
                }
                else
                {
                    IsHomingEnabled = 0;
                }
                return IsHomingEnabled;
            }
        }

        public bool IsOverrideCapable
        {
            get
            {
                return !Information.IsNothing(this._paramTable.Rows.Find("$31"));
            }
        }

        public bool IsGrblMetric
        {
            get
            {
                DataRow row = this._paramTable.Rows.Find("$13");
                return !Information.IsNothing(row) && String.Compare(Convert.ToString(row[1].ToString()[0]), "0", false) == 0;
            }
        }

        public GrblSettings(ref GrblGui gui)
        {
            this._settings = new Dictionary<string, string>
                {
                    {
                        "0",
                        Resources.GrblSettings_StepPulseUsec
                    },

                    {
                        "1",
                        Resources.GrblSettings_StepIdleDelayMsec
                    },

                    {
                        "2",
                        Resources.GrblSettings_StepPortInvertMask
                    },

                    {
                        "3",
                        Resources.GrblSettings_DirPortInvertMask
                    },

                    {
                        "4",
                        Resources.GrblSettings_StepEnableInvertBool
                    },

                    {
                        "5",
                        Resources.GrblSettings_LimitPinsInvertBool
                    },

                    {
                        "6",
                        Resources.GrblSettings_ProbePinInvertBool
                    },

                    {
                        "10",
                        Resources.GrblSettings_StatusReportMask
                    },

                    {
                        "11",
                        Resources.GrblSettings_JunctionDeviationMm
                    },

                    {
                        "12",
                        Resources.GrblSettings_ArcToleranceMm
                    },

                    {
                        "13",
                        Resources.GrblSettings_ReportInchesBool
                    },

                    {
                        "20",
                        Resources.GrblSettings_SoftLimitsBool
                    },

                    {
                        "21",
                        Resources.GrblSettings_HardLimitsBool
                    },

                    {
                        "22",
                        Resources.GrblSettings_HomingCycleBool
                    },

                    {
                        "23",
                        Resources.GrblSettings_HomingDirInvertMask
                    },

                    {
                        "24",
                        Resources.GrblSettings_HomingFeedMmMin
                    },

                    {
                        "25",
                        Resources.GrblSettings_HomingSeekMmMin
                    },

                    {
                        "26",
                        Resources.GrblSettings_HomingDebounceMsec
                    },

                    {
                        "27",
                        Resources.GrblSettings_HomingPullOffMm
                    },

                    {
                        "30",
                        Resources.GrblSettings_RpmMax
                    },

                    {
                        "31",
                        Resources.GrblSettings_RpmMin
                    },

                    {
                        "32",
                        Resources.GrblSettings_LaserMode
                    },

                    {
                        "100",
                        Resources.GrblSettings_XStepMm
                    },

                    {
                        "101",
                        Resources.GrblSettings_YStepMm
                    },

                    {
                        "102",
                        Resources.GrblSettings_ZStepMm
                    },

                    {
                        "103",
                        Resources.GrblSettings_AStepMm
                    },

                    {
                        "110",
                        Resources.GrblSettings_XMaxRateMmMin
                    },

                    {
                        "111",
                        Resources.GrblSettings_YMaxRateMmMin
                    },

                    {
                        "112",
                        Resources.GrblSettings_ZMaxRateMmMin
                    },

                    {
                        "113",
                        Resources.GrblSettings_AMaxRateMmMin
                    },

                    {
                        "120",
                        Resources.GrblSettings_XAccelMmSec2
                    },

                    {
                        "121",
                        Resources.GrblSettings_YAccelMmSec2
                    },

                    {
                        "122",
                        Resources.GrblSettings_ZAccelMmSec2
                    },

                    {
                        "123",
                        Resources.GrblSettings_AAccelMmSec2
                    },

                    {
                        "130",
                        Resources.GrblSettings_XMaxTravelMm
                    },

                    {
                        "131",
                        Resources.GrblSettings_YMaxTravelMm
                    },

                    {
                        "132",
                        Resources.GrblSettings_ZMaxTravelMm
                    },

                    {
                        "133",
                        Resources.GrblSettings_AMaxTravelMm
                    }
                };
            this._gui = gui;
            this._gui.Connected += new ConnectedEventHandler(this.GrblConnected);
        }

        public void EnableState(bool yes)
        {
            if (yes)
            {
                this._gui.gbGrblSettings.Enabled = true;
                return;
            }
            this._gui.gbGrblSettings.Enabled = false;
        }

        private void GrblConnected(string msg)
        {
            if (String.Compare(msg, "Connected", false) == 0)
            {
                this._nextParam = 0;
                gcode.sendGCodeLine("$$");
            }
        }

        public void FillSettings(string data)
        {
            if (this._nextParam == 0)
            {
                this._paramTable = new DataTable();
                DataTable paramTable = this._paramTable;
                paramTable.Columns.Add("ID");
                paramTable.Columns.Add(Resources.GrblSettings_FillSettings_Value);
                paramTable.Columns.Add("Description");
                paramTable.PrimaryKey = new DataColumn[]
                {
                        paramTable.Columns["ID"]
                };
            }
            string[] @params = data.Split(new char[]
            {
                    '=',
                    '(',
                    ')'
            });
            @params[1] = @params[1].Replace(" ", "");
            if (@params.Count<string>() == 4)
            {
                this._paramTable.Rows.Add(new object[]
                {
                        @params[0],
                        @params[1],
                        @params[2]
                });
            }
            else
            {
                int index = Convert.ToInt32(@params[0].Remove(0, 1));
                if (this._settings.ContainsKey(Convert.ToString(index)))
                {
                    this._paramTable.Rows.Add(new object[]
                    {
                            @params[0],
                            @params[1],
                            this._settings[Convert.ToString(index)]
                    });
                }
                else
                {
                    this._paramTable.Rows.Add(new object[]
                    {
                            @params[0],
                            @params[1],
                            ""
                    });
                }
            }
            checked
            {
                this._nextParam++;
                if (String.Compare(@params[0], this._gui.tbSettingsGrblLastParam.Text, false) == 0)
                {
                    this._nextParam = 0;
                    DataGridView expr_196 = this._gui.dgGrblSettings;
                    expr_196.DataSource = this._paramTable;
                    expr_196.Columns["ID"].Width = 40;
                    expr_196.Columns["ID"].ReadOnly = true;
                    expr_196.Columns["ID"].DefaultCellStyle.BackColor = SystemColors.Control;
                    expr_196.Columns[Resources.GrblSettings_FillSettings_Value].Width = 60;
                    expr_196.Columns["Description"].Width = 200;
                    expr_196.Columns["Description"].ReadOnly = true;
                    expr_196.Columns["Description"].DefaultCellStyle.BackColor = SystemColors.Control;
                    expr_196.Refresh();
                    GrblSettings.GrblSettingsRetrievedEventEventHandler grblSettingsRetrievedEventEvent = this.GrblSettingsRetrievedEventEvent;
                    if (grblSettingsRetrievedEventEvent != null)
                    {
                        grblSettingsRetrievedEventEvent();
                    }
                }
            }
        }

        public void RefreshSettings()
        {
            this._nextParam = 0;
            gcode.sendGCodeLine("$$");
        }
    }
}