using GrblPanel.My;
using GrblPanel.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RepeatButton;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace GrblPanel
{
    [DesignerGenerated]
    public class GrblGui : Form
    {
        private bool bDataChanged;
        private string[] _macroNames;
        public int GrblVersion;

        [AccessedThroughProperty("grblPort"), CompilerGenerated]
        private GrblIF _grblPort;

        //private GrblStatus status;
        //private GrblJogging jogging;
        //private GrblPosition position;
        //public static GrblGcode gcode;
        //public static GrblGcodeView gcodeview;
        //public GrblOffsets offsets;
        //public GrblState state;
        //public GrblSettings settings;
        //public GrblOverrides ovrrides;
        //public GrblPins pins;
        //public GrblInfo info;
        private bool _exitClicked; private IContainer components;

        public delegate void ConnectedEventHandler(string msg);

        public delegate void GrblSettingsRetrievedEventHandler();

        private System.Threading.Timer _statusTimer;
        private GrblErrorsSingleton GrblErrors;
        internal TabPage tabPgSettings;
        internal GroupBox gbMiscInfo;
        internal Label Label49;
        internal TextBox tbGrblOptions;
        internal Label Label48;
        internal TextBox tbGrblVersion;
        internal GroupBox gbGrblSettings;
        internal Label Label4;
        internal TextBox tbSettingsGrblLastParam;
        internal ToolTip ToolTip1;
        internal DataGridView dgGrblSettings;
        internal Button btnSettingsGrbl;
        internal GroupBox gbSettingsOffsets;
        internal Button btnOffsetsG28Set;
        internal Button btnSettingsRetrieveLocations;
        internal Label Label7;
        internal Label Label18;
        internal TextBox tbOffsetsG30Y;
        internal TextBox tbOffsetsG30X;
        internal TextBox tbOffsetsG30Z;
        internal TextBox tbOffsetsG28X;
        internal Button btnOffsetsG30Set;
        internal TextBox tbOffsetsG28Y;
        internal Label Label68;
        internal TextBox tbOffsetsG28Z;
        internal Label Label69;
        internal Label Label42;
        internal GroupBox gbSettingsMisc;
        internal Label Label52;
        internal TextBox tbTruncationDigits;
        internal TextBox tbSettingsDefaultExt;
        internal Label Label5;
        internal Label Label6;
        internal TextBox tbSettingsStartupDelay;
        internal CheckBox cbSettingsLeftHanded;
        internal CheckBox cbSettingsConnectOnLoad;
        internal CheckBox cbSettingsPauseOnError;
        internal CheckBox cbStatusPollEnable;
        internal Button btnSettingsRefreshMisc;
        internal Label Label37;
        internal Label Label36;
        internal TextBox tbSettingsRBuffSize;
        internal TextBox tbSettingsQSize;
        internal Label Label26;
        internal TextBox tbSettingsPollRate;
        internal GroupBox gbSettingsPosition;
        internal Label Label8;
        internal TextBox tbSettingsSpclPosition2;
        internal Button btnSettingsRefreshPosition;
        internal Label Label29;
        internal TextBox tbWorkZ0Cmd;
        internal Label Label28;
        internal TextBox tbWorkY0Cmd;
        internal Label Label13;
        internal Label Label12;
        internal TextBox tbWorkX0Cmd;
        internal TextBox tbSettingsZeroXYZCmd;
        internal Label Label11;
        internal TextBox tbSettingsSpclPosition1;
        internal GroupBox gbSettingsJogging;
        internal CheckBox cbSettingsKeyboardJogging;
        internal Button btnSettingsRefreshJogging;
        internal Label Label41;
        internal Label Label40;
        internal Label Label39;
        internal Label Label38;
        internal TextBox tbSettingsZRepeat;
        internal TextBox tbSettingsYRepeat;
        internal TextBox tbSettingsXRepeat;
        internal Label Label35;
        internal Label Label34;
        internal Label Label32;
        internal TextBox tbSettingsFRMetric;
        internal Label Label33;
        internal TextBox tbSettingsFIMetric;
        internal Label Label31;
        internal TextBox tbSettingsFRImperial;
        internal Label Label30;
        internal CheckBox cbSettingsMetric;
        internal TextBox tbSettingsFIImperial;
        internal Button btnSetOffsetG59;
        internal Button btnSetOffsetG56;
        internal Button btnSetOffsetG57;
        internal Button btnSetOffsetG58;
        internal Button btnSetOffsetG55;
        internal Button btnSetOffsetG54;
        internal Label Label10;
        internal Label Label71;
        internal TextBox tbOffSetsMachZ;
        internal Label Label19;
        internal TextBox tbOffsetsG56Y;
        internal TextBox tbOffSetsMachY;
        internal TextBox tbOffsetsG56X;
        internal TextBox tbOffsetsG56Z;
        internal TextBox tbOffSetsMachX;
        internal Button btnOffsetsG57Zero;
        internal TextBox tbOffsetsG54X;
        internal Button btnOffsetsRetrieve;
        internal TextBox tbOffsetsG55Y;
        internal Button btnOffsetsG54Zero;
        internal Button btnOffsetsLoad;
        internal Button btnOffsetsG56Zero;
        internal TextBox tbOffsetsG54Y;
        internal TextBox tbOffsetsG57Z;
        internal Button btnOffsetsSave;
        internal TextBox tbOffsetsG55X;
        internal TextBox tbOffsetsG54Z;
        internal TextBox tbOffsetsG57Y;
        internal TextBox tbOffsetsG57X;
        internal TextBox tbOffsetsG55Z;
        internal TabPage tpOffsets;
        internal TextBox tbOffsetsG59X;
        internal Button btnOffsetsG58Zero;
        internal Button btnOffsetsG43Zero;
        internal TextBox tbOffsetsG59Y;
        internal TextBox tbOffsetsG43Z;
        internal Button btnOffsetsG55Zero;
        internal TextBox tbOffsetsG59Z;
        internal TextBox tbOffsetsG58Z;
        internal Label Label60;
        internal TextBox tbOffsetsG58Y;
        internal Label Label20;
        internal Label Label43;
        internal Button btnOffsetsG59Zero;
        internal TextBox tbOffsetsG58X;
        internal Label Label21;
        internal Panel Panel5;
        internal TextBox tbWorkZ;
        internal TextBox tbMachZ;
        internal Panel Panel4;
        internal TextBox tbWorkY;
        internal TextBox tbMachY;
        internal Panel Panel3;
        internal TextBox tbMachX;
        internal TextBox tbWorkX;
        internal GroupBox GroupBox1;
        internal Label lblPositionCurrentOffset;
        private Button btnWorkSoftHome;
        internal Button btnHome;
        internal Button btnWorkSpclPosition;
        internal Label Label3;
        internal TabPage TabPage1;
        public GroupBox gbEditor;
        private Button btnAdd;
        private Label lblGCode;
        public TextBox tbGCode;
        private Label lblName;
        public TextBox tbName;
        private Button btnCancel;
        private Button btnOK;
        private DataGridView dgMacros;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        private Label lblStatusLabel;
        private Button btnDeleteMacro;
        private OpenFileDialog ofdGcodeFile;
        internal SaveFileDialog sfdOffsets;
        internal Button btnWork0;
        internal CheckBox cbFeedHold;
        internal GroupBox gbMDI;
        internal Label Label9;
        internal Button btnSend;
        internal TextBox tbSendData;
        internal Panel Panel2;
        internal TextBox tbStateFeedRate;
        internal Label Label14;
        internal TextBox tbStateTool;
        internal Label Label53;
        internal Label Label50;
        internal TextBox tbStateSpindleRPM;
        internal Panel Panel1;
        internal ComboBox cbxStateFeedMode;
        internal ComboBox cbxStateDistance;
        internal Label Label16;
        internal ComboBox cbxStateUnits;
        internal Label Label123;
        internal Label Lalbel49;
        internal ComboBox cbxStatePlane;
        internal Label Label47;
        internal Label Label15;
        internal ComboBox cbxStateOffset;
        internal ComboBox cbxStateCoolant;
        internal Label Label45;
        internal Label Label17;
        internal ComboBox cbxStateSpindle;
        internal GroupBox gbControl;
        public Button btnCheckMode;
        public Button btnReset;
        public Button btnHold;
        public Button btnStartResume;
        public Button btnUnlock;
        internal CheckBox cbStartResume;
        internal CheckBox cbResetAbort;
        internal GroupBox gbPinStatus;
        internal Button btnStatusClearPins;
        internal CheckBox cbLimitX;
        internal CheckBox cbDoorOpen;
        internal CheckBox cbProbePin;
        internal CheckBox cbLimitZ;
        internal CheckBox cbLimitY;
        internal Button btnMistOverride;
        internal Button btnFloodOverride;
        internal Button btnSpindleOverride;
        internal CheckBox cbSpindleCoarse;
        internal Button btnSpindleOverrideReset;
        internal Button btnRapidOverride25;
        internal GroupBox gbOverrides;
        internal Button btnFeedOverrideReset;
        internal CheckBox cbFeedCoarse;
        internal Label Label44;
        internal Button btnSpindleMinus;
        internal Button btnSpindlePlus;
        internal Label Label22;
        internal Button btnRapidOverride50;
        internal Button btnRapidOverrideReset;
        internal TextBox tbSpindleOvr;
        internal TextBox tbRapidOvr;
        internal TextBox tbFeedOvr;
        internal Label Label46;
        internal Button btnFeedMinus;
        internal Button btnFeedPlus;
        internal TabPage tabPgInterface;
        internal GroupBox gbState;
        internal GroupBox gbJogging;
        internal RepeatButton.RepeatButton btnZMinus;
        internal RepeatButton.RepeatButton btnZPlus;
        internal RepeatButton.RepeatButton btnXPlus;
        internal RepeatButton.RepeatButton btnYMinus;
        internal RepeatButton.RepeatButton btnXMinus;
        internal RepeatButton.RepeatButton btnYPlus;
        internal GroupBox gbFeedRate;
        internal RadioButton rbFeedRate1;
        internal RadioButton rbFeedRate2;
        internal RadioButton rbFeedRate3;
        internal RadioButton rbFeedRate4;
        internal GroupBox gbDistance;
        internal RadioButton rbDistance1;
        internal RadioButton rbDistance2;
        internal RadioButton rbDistance3;
        internal RadioButton rbDistance4;
        internal CheckBox cbUnits;
        internal GroupBox gbStatus;
        internal Label Label25;
        internal TextBox tbCurrentStatus;
        internal Label Label24;
        internal ProgressBar prgbRxBuf;
        internal ProgressBar prgBarQ;
        internal CheckBox cbVerbose;
        internal ListBox lbResponses;
        internal GroupBox gbGcode;
        internal Button btnFileStep;
        internal CheckBox cbMonitorEnable;
        internal Label lblElapsedTime;
        internal Label Label23;
        internal Label Label51;
        internal Label lblCurrentLine;
        internal DataGridView dgvGcode;
        internal DataGridViewTextBoxColumn stat;
        internal DataGridViewTextBoxColumn lineNum;
        internal DataGridViewTextBoxColumn data;
        internal Button btnFileReload;
        internal TextBox tbGCodeMessage;
        internal Label Label27;
        internal Label lblTotalLines;
        internal Button btnFilePause;
        internal TextBox tbGcodeFile;
        internal Button btnFileSelect;
        internal Button btnFileSend;
        internal Button btnFileStop;
        internal GroupBox gbGrbl;
        internal TabControl tcConnection;
        internal TabPage tbGrblCOM;
        internal Button btnRescanPorts;
        internal ComboBox cbPorts;
        internal Button btnConnect;
        internal ComboBox cbBaud;
        internal TabPage tbGrblIP;
        internal Button btnIPConnect;
        internal TextBox tbIPAddress;
        internal GroupBox gbPosition;
        internal TabControl tabCtlPosition;
        internal TabPage tpWork;
        internal Label Label2;
        internal Button btnWorkX0;
        internal Label Label1;
        internal Button btnWorkZ0;
        internal Button btnWorkY0;
        internal ToolStripMenuItem AboutToolStripMenuItem;
        internal ToolStripMenuItem HelpToolStripMenuItem;
        internal ToolStripMenuItem OptionsToolStripMenuItem;
        internal ToolStripMenuItem ToolsToolStripMenuItem;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal ToolStripMenuItem SaveToolStripMenuItem;
        internal ToolStripMenuItem ToolStripMenuItem1;
        internal TabControl TabControl1;
        internal MenuStrip MenuStrip1;
        internal OpenFileDialog ofdOffsets;
        internal BindingSource GrblSettingsBindingSource;
        private Dictionary<string, string> _errors;

        public event ConnectedEventHandler Connected;

        public event GrblSettingsRetrievedEventHandler GrblSettingsRetrieved;

        public GrblIF grblPort
        {
            get;

            set;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrblGui));
            this.tabPgSettings = new System.Windows.Forms.TabPage();
            this.gbMiscInfo = new System.Windows.Forms.GroupBox();
            this.Label49 = new System.Windows.Forms.Label();
            this.tbGrblOptions = new System.Windows.Forms.TextBox();
            this.Label48 = new System.Windows.Forms.Label();
            this.tbGrblVersion = new System.Windows.Forms.TextBox();
            this.gbGrblSettings = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbSettingsGrblLastParam = new System.Windows.Forms.TextBox();
            this.dgGrblSettings = new System.Windows.Forms.DataGridView();
            this.btnSettingsGrbl = new System.Windows.Forms.Button();
            this.gbSettingsOffsets = new System.Windows.Forms.GroupBox();
            this.btnOffsetsG28Set = new System.Windows.Forms.Button();
            this.btnSettingsRetrieveLocations = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.tbOffsetsG30Y = new System.Windows.Forms.TextBox();
            this.tbOffsetsG30X = new System.Windows.Forms.TextBox();
            this.tbOffsetsG30Z = new System.Windows.Forms.TextBox();
            this.tbOffsetsG28X = new System.Windows.Forms.TextBox();
            this.btnOffsetsG30Set = new System.Windows.Forms.Button();
            this.tbOffsetsG28Y = new System.Windows.Forms.TextBox();
            this.Label68 = new System.Windows.Forms.Label();
            this.tbOffsetsG28Z = new System.Windows.Forms.TextBox();
            this.Label69 = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.gbSettingsMisc = new System.Windows.Forms.GroupBox();
            this.Label52 = new System.Windows.Forms.Label();
            this.tbTruncationDigits = new System.Windows.Forms.TextBox();
            this.tbSettingsDefaultExt = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tbSettingsStartupDelay = new System.Windows.Forms.TextBox();
            this.cbSettingsLeftHanded = new System.Windows.Forms.CheckBox();
            this.cbSettingsConnectOnLoad = new System.Windows.Forms.CheckBox();
            this.cbSettingsPauseOnError = new System.Windows.Forms.CheckBox();
            this.cbStatusPollEnable = new System.Windows.Forms.CheckBox();
            this.btnSettingsRefreshMisc = new System.Windows.Forms.Button();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.tbSettingsRBuffSize = new System.Windows.Forms.TextBox();
            this.tbSettingsQSize = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.tbSettingsPollRate = new System.Windows.Forms.TextBox();
            this.gbSettingsPosition = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.tbSettingsSpclPosition2 = new System.Windows.Forms.TextBox();
            this.btnSettingsRefreshPosition = new System.Windows.Forms.Button();
            this.Label29 = new System.Windows.Forms.Label();
            this.tbWorkZ0Cmd = new System.Windows.Forms.TextBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.tbWorkY0Cmd = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.tbWorkX0Cmd = new System.Windows.Forms.TextBox();
            this.tbSettingsZeroXYZCmd = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.tbSettingsSpclPosition1 = new System.Windows.Forms.TextBox();
            this.gbSettingsJogging = new System.Windows.Forms.GroupBox();
            this.cbSettingsKeyboardJogging = new System.Windows.Forms.CheckBox();
            this.btnSettingsRefreshJogging = new System.Windows.Forms.Button();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.tbSettingsZRepeat = new System.Windows.Forms.TextBox();
            this.tbSettingsYRepeat = new System.Windows.Forms.TextBox();
            this.tbSettingsXRepeat = new System.Windows.Forms.TextBox();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.tbSettingsFRMetric = new System.Windows.Forms.TextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.tbSettingsFIMetric = new System.Windows.Forms.TextBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.tbSettingsFRImperial = new System.Windows.Forms.TextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.cbSettingsMetric = new System.Windows.Forms.CheckBox();
            this.tbSettingsFIImperial = new System.Windows.Forms.TextBox();
            this.btnSetOffsetG59 = new System.Windows.Forms.Button();
            this.btnSetOffsetG56 = new System.Windows.Forms.Button();
            this.btnSetOffsetG57 = new System.Windows.Forms.Button();
            this.btnSetOffsetG58 = new System.Windows.Forms.Button();
            this.btnSetOffsetG55 = new System.Windows.Forms.Button();
            this.btnSetOffsetG54 = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label71 = new System.Windows.Forms.Label();
            this.tbOffSetsMachZ = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.tbOffsetsG56Y = new System.Windows.Forms.TextBox();
            this.tbOffSetsMachY = new System.Windows.Forms.TextBox();
            this.tbOffsetsG56X = new System.Windows.Forms.TextBox();
            this.tbOffsetsG56Z = new System.Windows.Forms.TextBox();
            this.tbOffSetsMachX = new System.Windows.Forms.TextBox();
            this.btnOffsetsG57Zero = new System.Windows.Forms.Button();
            this.tbOffsetsG54X = new System.Windows.Forms.TextBox();
            this.btnOffsetsRetrieve = new System.Windows.Forms.Button();
            this.tbOffsetsG55Y = new System.Windows.Forms.TextBox();
            this.btnOffsetsG54Zero = new System.Windows.Forms.Button();
            this.btnOffsetsLoad = new System.Windows.Forms.Button();
            this.btnOffsetsG56Zero = new System.Windows.Forms.Button();
            this.tbOffsetsG54Y = new System.Windows.Forms.TextBox();
            this.tbOffsetsG57Z = new System.Windows.Forms.TextBox();
            this.btnOffsetsSave = new System.Windows.Forms.Button();
            this.tbOffsetsG55X = new System.Windows.Forms.TextBox();
            this.tbOffsetsG54Z = new System.Windows.Forms.TextBox();
            this.tbOffsetsG57Y = new System.Windows.Forms.TextBox();
            this.tbOffsetsG57X = new System.Windows.Forms.TextBox();
            this.tbOffsetsG55Z = new System.Windows.Forms.TextBox();
            this.tpOffsets = new System.Windows.Forms.TabPage();
            this.tbOffsetsG59X = new System.Windows.Forms.TextBox();
            this.btnOffsetsG58Zero = new System.Windows.Forms.Button();
            this.btnOffsetsG43Zero = new System.Windows.Forms.Button();
            this.tbOffsetsG59Y = new System.Windows.Forms.TextBox();
            this.tbOffsetsG43Z = new System.Windows.Forms.TextBox();
            this.btnOffsetsG55Zero = new System.Windows.Forms.Button();
            this.tbOffsetsG59Z = new System.Windows.Forms.TextBox();
            this.tbOffsetsG58Z = new System.Windows.Forms.TextBox();
            this.Label60 = new System.Windows.Forms.Label();
            this.tbOffsetsG58Y = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.btnOffsetsG59Zero = new System.Windows.Forms.Button();
            this.tbOffsetsG58X = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.tbWorkZ = new System.Windows.Forms.TextBox();
            this.tbMachZ = new System.Windows.Forms.TextBox();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.tbWorkY = new System.Windows.Forms.TextBox();
            this.tbMachY = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.tbMachX = new System.Windows.Forms.TextBox();
            this.tbWorkX = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPositionCurrentOffset = new System.Windows.Forms.Label();
            this.btnWorkSoftHome = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnWorkSpclPosition = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.gbEditor = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblGCode = new System.Windows.Forms.Label();
            this.tbGCode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgMacros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.btnDeleteMacro = new System.Windows.Forms.Button();
            this.ofdGcodeFile = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sfdOffsets = new System.Windows.Forms.SaveFileDialog();
            this.btnWork0 = new System.Windows.Forms.Button();
            this.cbFeedHold = new System.Windows.Forms.CheckBox();
            this.gbMDI = new System.Windows.Forms.GroupBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbSendData = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.tbStateFeedRate = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.tbStateTool = new System.Windows.Forms.TextBox();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.tbStateSpindleRPM = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cbxStateFeedMode = new System.Windows.Forms.ComboBox();
            this.cbxStateDistance = new System.Windows.Forms.ComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.cbxStateUnits = new System.Windows.Forms.ComboBox();
            this.Label123 = new System.Windows.Forms.Label();
            this.Lalbel49 = new System.Windows.Forms.Label();
            this.cbxStatePlane = new System.Windows.Forms.ComboBox();
            this.Label47 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.cbxStateOffset = new System.Windows.Forms.ComboBox();
            this.cbxStateCoolant = new System.Windows.Forms.ComboBox();
            this.Label45 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.cbxStateSpindle = new System.Windows.Forms.ComboBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnCheckMode = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnStartResume = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.cbStartResume = new System.Windows.Forms.CheckBox();
            this.cbResetAbort = new System.Windows.Forms.CheckBox();
            this.gbPinStatus = new System.Windows.Forms.GroupBox();
            this.btnStatusClearPins = new System.Windows.Forms.Button();
            this.cbLimitX = new System.Windows.Forms.CheckBox();
            this.cbDoorOpen = new System.Windows.Forms.CheckBox();
            this.cbProbePin = new System.Windows.Forms.CheckBox();
            this.cbLimitZ = new System.Windows.Forms.CheckBox();
            this.cbLimitY = new System.Windows.Forms.CheckBox();
            this.btnMistOverride = new System.Windows.Forms.Button();
            this.btnFloodOverride = new System.Windows.Forms.Button();
            this.btnSpindleOverride = new System.Windows.Forms.Button();
            this.cbSpindleCoarse = new System.Windows.Forms.CheckBox();
            this.btnSpindleOverrideReset = new System.Windows.Forms.Button();
            this.btnRapidOverride25 = new System.Windows.Forms.Button();
            this.gbOverrides = new System.Windows.Forms.GroupBox();
            this.btnFeedOverrideReset = new System.Windows.Forms.Button();
            this.cbFeedCoarse = new System.Windows.Forms.CheckBox();
            this.Label44 = new System.Windows.Forms.Label();
            this.btnSpindleMinus = new System.Windows.Forms.Button();
            this.btnSpindlePlus = new System.Windows.Forms.Button();
            this.Label22 = new System.Windows.Forms.Label();
            this.btnRapidOverride50 = new System.Windows.Forms.Button();
            this.btnRapidOverrideReset = new System.Windows.Forms.Button();
            this.tbSpindleOvr = new System.Windows.Forms.TextBox();
            this.tbRapidOvr = new System.Windows.Forms.TextBox();
            this.tbFeedOvr = new System.Windows.Forms.TextBox();
            this.Label46 = new System.Windows.Forms.Label();
            this.btnFeedMinus = new System.Windows.Forms.Button();
            this.btnFeedPlus = new System.Windows.Forms.Button();
            this.tabPgInterface = new System.Windows.Forms.TabPage();
            this.gbState = new System.Windows.Forms.GroupBox();
            this.gbJogging = new System.Windows.Forms.GroupBox();
            this.btnZMinus = new RepeatButton.RepeatButton();
            this.btnZPlus = new RepeatButton.RepeatButton();
            this.btnXPlus = new RepeatButton.RepeatButton();
            this.btnYMinus = new RepeatButton.RepeatButton();
            this.btnXMinus = new RepeatButton.RepeatButton();
            this.btnYPlus = new RepeatButton.RepeatButton();
            this.gbFeedRate = new System.Windows.Forms.GroupBox();
            this.rbFeedRate1 = new System.Windows.Forms.RadioButton();
            this.rbFeedRate2 = new System.Windows.Forms.RadioButton();
            this.rbFeedRate3 = new System.Windows.Forms.RadioButton();
            this.rbFeedRate4 = new System.Windows.Forms.RadioButton();
            this.gbDistance = new System.Windows.Forms.GroupBox();
            this.rbDistance1 = new System.Windows.Forms.RadioButton();
            this.rbDistance2 = new System.Windows.Forms.RadioButton();
            this.rbDistance3 = new System.Windows.Forms.RadioButton();
            this.rbDistance4 = new System.Windows.Forms.RadioButton();
            this.cbUnits = new System.Windows.Forms.CheckBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.tbCurrentStatus = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.prgbRxBuf = new System.Windows.Forms.ProgressBar();
            this.prgBarQ = new System.Windows.Forms.ProgressBar();
            this.cbVerbose = new System.Windows.Forms.CheckBox();
            this.lbResponses = new System.Windows.Forms.ListBox();
            this.gbGcode = new System.Windows.Forms.GroupBox();
            this.btnFileStep = new System.Windows.Forms.Button();
            this.cbMonitorEnable = new System.Windows.Forms.CheckBox();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.lblCurrentLine = new System.Windows.Forms.Label();
            this.dgvGcode = new System.Windows.Forms.DataGridView();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFileReload = new System.Windows.Forms.Button();
            this.tbGCodeMessage = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.lblTotalLines = new System.Windows.Forms.Label();
            this.btnFilePause = new System.Windows.Forms.Button();
            this.tbGcodeFile = new System.Windows.Forms.TextBox();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnFileSend = new System.Windows.Forms.Button();
            this.btnFileStop = new System.Windows.Forms.Button();
            this.gbGrbl = new System.Windows.Forms.GroupBox();
            this.tcConnection = new System.Windows.Forms.TabControl();
            this.tbGrblCOM = new System.Windows.Forms.TabPage();
            this.btnRescanPorts = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.tbGrblIP = new System.Windows.Forms.TabPage();
            this.btnIPConnect = new System.Windows.Forms.Button();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.tabCtlPosition = new System.Windows.Forms.TabControl();
            this.tpWork = new System.Windows.Forms.TabPage();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnWorkX0 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnWorkZ0 = new System.Windows.Forms.Button();
            this.btnWorkY0 = new System.Windows.Forms.Button();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ofdOffsets = new System.Windows.Forms.OpenFileDialog();
            this.GrblSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPgSettings.SuspendLayout();
            this.gbMiscInfo.SuspendLayout();
            this.gbGrblSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrblSettings)).BeginInit();
            this.gbSettingsOffsets.SuspendLayout();
            this.gbSettingsMisc.SuspendLayout();
            this.gbSettingsPosition.SuspendLayout();
            this.gbSettingsJogging.SuspendLayout();
            this.tpOffsets.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.gbEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMacros)).BeginInit();
            this.gbMDI.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbPinStatus.SuspendLayout();
            this.gbOverrides.SuspendLayout();
            this.tabPgInterface.SuspendLayout();
            this.gbState.SuspendLayout();
            this.gbJogging.SuspendLayout();
            this.gbFeedRate.SuspendLayout();
            this.gbDistance.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbGcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGcode)).BeginInit();
            this.gbGrbl.SuspendLayout();
            this.tcConnection.SuspendLayout();
            this.tbGrblCOM.SuspendLayout();
            this.tbGrblIP.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.tabCtlPosition.SuspendLayout();
            this.tpWork.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrblSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPgSettings
            // 
            this.tabPgSettings.Controls.Add(this.gbMiscInfo);
            this.tabPgSettings.Controls.Add(this.gbGrblSettings);
            this.tabPgSettings.Controls.Add(this.gbSettingsOffsets);
            this.tabPgSettings.Controls.Add(this.Label42);
            this.tabPgSettings.Controls.Add(this.gbSettingsMisc);
            this.tabPgSettings.Controls.Add(this.gbSettingsPosition);
            this.tabPgSettings.Controls.Add(this.gbSettingsJogging);
            this.tabPgSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPgSettings.Name = "tabPgSettings";
            this.tabPgSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgSettings.Size = new System.Drawing.Size(1134, 677);
            this.tabPgSettings.TabIndex = 1;
            this.tabPgSettings.Text = "Settings";
            this.tabPgSettings.UseVisualStyleBackColor = true;
            // 
            // gbMiscInfo
            // 
            this.gbMiscInfo.Controls.Add(this.Label49);
            this.gbMiscInfo.Controls.Add(this.tbGrblOptions);
            this.gbMiscInfo.Controls.Add(this.Label48);
            this.gbMiscInfo.Controls.Add(this.tbGrblVersion);
            this.gbMiscInfo.Location = new System.Drawing.Point(833, 19);
            this.gbMiscInfo.Name = "gbMiscInfo";
            this.gbMiscInfo.Size = new System.Drawing.Size(222, 100);
            this.gbMiscInfo.TabIndex = 112;
            this.gbMiscInfo.TabStop = false;
            this.gbMiscInfo.Text = "Misc Information";
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label49.Location = new System.Drawing.Point(112, 47);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(89, 13);
            this.Label49.TabIndex = 4;
            this.Label49.Text = "Compiled Options";
            // 
            // tbGrblOptions
            // 
            this.tbGrblOptions.Enabled = false;
            this.tbGrblOptions.Location = new System.Drawing.Point(6, 44);
            this.tbGrblOptions.Name = "tbGrblOptions";
            this.tbGrblOptions.Size = new System.Drawing.Size(100, 20);
            this.tbGrblOptions.TabIndex = 3;
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label48.Location = new System.Drawing.Point(112, 21);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(64, 13);
            this.Label48.TabIndex = 2;
            this.Label48.Text = "Grbl Version";
            // 
            // tbGrblVersion
            // 
            this.tbGrblVersion.Enabled = false;
            this.tbGrblVersion.Location = new System.Drawing.Point(6, 18);
            this.tbGrblVersion.Name = "tbGrblVersion";
            this.tbGrblVersion.Size = new System.Drawing.Size(100, 20);
            this.tbGrblVersion.TabIndex = 1;
            // 
            // gbGrblSettings
            // 
            this.gbGrblSettings.Controls.Add(this.Label4);
            this.gbGrblSettings.Controls.Add(this.tbSettingsGrblLastParam);
            this.gbGrblSettings.Controls.Add(this.dgGrblSettings);
            this.gbGrblSettings.Controls.Add(this.btnSettingsGrbl);
            this.gbGrblSettings.Location = new System.Drawing.Point(10, 19);
            this.gbGrblSettings.Name = "gbGrblSettings";
            this.gbGrblSettings.Size = new System.Drawing.Size(346, 590);
            this.gbGrblSettings.TabIndex = 111;
            this.gbGrblSettings.TabStop = false;
            this.gbGrblSettings.Text = "Grbl Settings";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label4.Location = new System.Drawing.Point(57, 555);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(82, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Last Grbl Param";
            // 
            // tbSettingsGrblLastParam
            // 
            this.tbSettingsGrblLastParam.Location = new System.Drawing.Point(6, 552);
            this.tbSettingsGrblLastParam.Name = "tbSettingsGrblLastParam";
            this.tbSettingsGrblLastParam.Size = new System.Drawing.Size(45, 20);
            this.tbSettingsGrblLastParam.TabIndex = 6;
            this.ToolTip1.SetToolTip(this.tbSettingsGrblLastParam, "Change this to reflect the highest Grbl Parameter number");
            // 
            // dgGrblSettings
            // 
            this.dgGrblSettings.AllowUserToAddRows = false;
            this.dgGrblSettings.AllowUserToDeleteRows = false;
            this.dgGrblSettings.AllowUserToResizeColumns = false;
            this.dgGrblSettings.AllowUserToResizeRows = false;
            this.dgGrblSettings.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgGrblSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrblSettings.Location = new System.Drawing.Point(3, 13);
            this.dgGrblSettings.MultiSelect = false;
            this.dgGrblSettings.Name = "dgGrblSettings";
            this.dgGrblSettings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgGrblSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgGrblSettings.Size = new System.Drawing.Size(337, 530);
            this.dgGrblSettings.TabIndex = 4;
            this.ToolTip1.SetToolTip(this.dgGrblSettings, "To send modified value to Grbl, dbleclick on it.\r\n");
            // 
            // btnSettingsGrbl
            // 
            this.btnSettingsGrbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettingsGrbl.Location = new System.Drawing.Point(265, 549);
            this.btnSettingsGrbl.Name = "btnSettingsGrbl";
            this.btnSettingsGrbl.Size = new System.Drawing.Size(75, 41);
            this.btnSettingsGrbl.TabIndex = 5;
            this.btnSettingsGrbl.Text = "Get Grbl Settings";
            this.btnSettingsGrbl.UseVisualStyleBackColor = true;
            // 
            // gbSettingsOffsets
            // 
            this.gbSettingsOffsets.Controls.Add(this.btnOffsetsG28Set);
            this.gbSettingsOffsets.Controls.Add(this.btnSettingsRetrieveLocations);
            this.gbSettingsOffsets.Controls.Add(this.Label7);
            this.gbSettingsOffsets.Controls.Add(this.Label18);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30Y);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30X);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30Z);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28X);
            this.gbSettingsOffsets.Controls.Add(this.btnOffsetsG30Set);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28Y);
            this.gbSettingsOffsets.Controls.Add(this.Label68);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28Z);
            this.gbSettingsOffsets.Controls.Add(this.Label69);
            this.gbSettingsOffsets.Location = new System.Drawing.Point(362, 498);
            this.gbSettingsOffsets.Name = "gbSettingsOffsets";
            this.gbSettingsOffsets.Size = new System.Drawing.Size(351, 111);
            this.gbSettingsOffsets.TabIndex = 110;
            this.gbSettingsOffsets.TabStop = false;
            this.gbSettingsOffsets.Text = "Offsets (2)";
            // 
            // btnOffsetsG28Set
            // 
            this.btnOffsetsG28Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG28Set.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG28Set.Location = new System.Drawing.Point(311, 29);
            this.btnOffsetsG28Set.Name = "btnOffsetsG28Set";
            this.btnOffsetsG28Set.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG28Set.TabIndex = 112;
            this.btnOffsetsG28Set.Tag = "G28Set";
            this.btnOffsetsG28Set.Text = "Set";
            this.ToolTip1.SetToolTip(this.btnOffsetsG28Set, "Set Special Position 1 to current Machine position");
            this.btnOffsetsG28Set.UseVisualStyleBackColor = true;
            // 
            // btnSettingsRetrieveLocations
            // 
            this.btnSettingsRetrieveLocations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettingsRetrieveLocations.Location = new System.Drawing.Point(276, 88);
            this.btnSettingsRetrieveLocations.Name = "btnSettingsRetrieveLocations";
            this.btnSettingsRetrieveLocations.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsRetrieveLocations.TabIndex = 111;
            this.btnSettingsRetrieveLocations.Text = "Retrieve";
            this.ToolTip1.SetToolTip(this.btnSettingsRetrieveLocations, "Get current settings from Grbl");
            this.btnSettingsRetrieveLocations.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(5, 95);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(185, 13);
            this.Label7.TabIndex = 110;
            this.Label7.Text = "(Work Offsets are set from main page)";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label18.Location = new System.Drawing.Point(8, 16);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(114, 13);
            this.Label18.TabIndex = 101;
            this.Label18.Text = "Machine Locations";
            // 
            // tbOffsetsG30Y
            // 
            this.tbOffsetsG30Y.Enabled = false;
            this.tbOffsetsG30Y.Location = new System.Drawing.Point(141, 59);
            this.tbOffsetsG30Y.Name = "tbOffsetsG30Y";
            this.tbOffsetsG30Y.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG30Y.TabIndex = 95;
            this.tbOffsetsG30Y.Tag = "G30Y";
            // 
            // tbOffsetsG30X
            // 
            this.tbOffsetsG30X.Enabled = false;
            this.tbOffsetsG30X.Location = new System.Drawing.Point(56, 59);
            this.tbOffsetsG30X.Name = "tbOffsetsG30X";
            this.tbOffsetsG30X.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG30X.TabIndex = 94;
            this.tbOffsetsG30X.Tag = "G30X";
            // 
            // tbOffsetsG30Z
            // 
            this.tbOffsetsG30Z.Enabled = false;
            this.tbOffsetsG30Z.Location = new System.Drawing.Point(226, 59);
            this.tbOffsetsG30Z.Name = "tbOffsetsG30Z";
            this.tbOffsetsG30Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG30Z.TabIndex = 96;
            this.tbOffsetsG30Z.Tag = "G30Z";
            // 
            // tbOffsetsG28X
            // 
            this.tbOffsetsG28X.Enabled = false;
            this.tbOffsetsG28X.Location = new System.Drawing.Point(56, 31);
            this.tbOffsetsG28X.Name = "tbOffsetsG28X";
            this.tbOffsetsG28X.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG28X.TabIndex = 89;
            this.tbOffsetsG28X.Tag = "G28X";
            // 
            // btnOffsetsG30Set
            // 
            this.btnOffsetsG30Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG30Set.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG30Set.Location = new System.Drawing.Point(311, 58);
            this.btnOffsetsG30Set.Name = "btnOffsetsG30Set";
            this.btnOffsetsG30Set.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG30Set.TabIndex = 97;
            this.btnOffsetsG30Set.Tag = "G30Set";
            this.btnOffsetsG30Set.Text = "Set";
            this.ToolTip1.SetToolTip(this.btnOffsetsG30Set, "Set Special Position 2 to current Machine position");
            this.btnOffsetsG30Set.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG28Y
            // 
            this.tbOffsetsG28Y.Enabled = false;
            this.tbOffsetsG28Y.Location = new System.Drawing.Point(141, 31);
            this.tbOffsetsG28Y.Name = "tbOffsetsG28Y";
            this.tbOffsetsG28Y.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG28Y.TabIndex = 90;
            this.tbOffsetsG28Y.Tag = "G28Y";
            // 
            // Label68
            // 
            this.Label68.AutoSize = true;
            this.Label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label68.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label68.Location = new System.Drawing.Point(4, 35);
            this.Label68.Name = "Label68";
            this.Label68.Size = new System.Drawing.Size(30, 13);
            this.Label68.TabIndex = 108;
            this.Label68.Text = "G28";
            // 
            // tbOffsetsG28Z
            // 
            this.tbOffsetsG28Z.Enabled = false;
            this.tbOffsetsG28Z.Location = new System.Drawing.Point(226, 31);
            this.tbOffsetsG28Z.Name = "tbOffsetsG28Z";
            this.tbOffsetsG28Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG28Z.TabIndex = 91;
            this.tbOffsetsG28Z.Tag = "G28Z";
            // 
            // Label69
            // 
            this.Label69.AutoSize = true;
            this.Label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label69.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label69.Location = new System.Drawing.Point(4, 63);
            this.Label69.Name = "Label69";
            this.Label69.Size = new System.Drawing.Size(30, 13);
            this.Label69.TabIndex = 109;
            this.Label69.Text = "G30";
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label42.Location = new System.Drawing.Point(359, 3);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(283, 13);
            this.Label42.TabIndex = 3;
            this.Label42.Text = "These settings always save on exit of Grbl-Panel";
            // 
            // gbSettingsMisc
            // 
            this.gbSettingsMisc.Controls.Add(this.Label52);
            this.gbSettingsMisc.Controls.Add(this.tbTruncationDigits);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsDefaultExt);
            this.gbSettingsMisc.Controls.Add(this.Label5);
            this.gbSettingsMisc.Controls.Add(this.Label6);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsStartupDelay);
            this.gbSettingsMisc.Controls.Add(this.cbSettingsLeftHanded);
            this.gbSettingsMisc.Controls.Add(this.cbSettingsConnectOnLoad);
            this.gbSettingsMisc.Controls.Add(this.cbSettingsPauseOnError);
            this.gbSettingsMisc.Controls.Add(this.cbStatusPollEnable);
            this.gbSettingsMisc.Controls.Add(this.btnSettingsRefreshMisc);
            this.gbSettingsMisc.Controls.Add(this.Label37);
            this.gbSettingsMisc.Controls.Add(this.Label36);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsRBuffSize);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsQSize);
            this.gbSettingsMisc.Controls.Add(this.Label26);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsPollRate);
            this.gbSettingsMisc.Location = new System.Drawing.Point(362, 234);
            this.gbSettingsMisc.Name = "gbSettingsMisc";
            this.gbSettingsMisc.Size = new System.Drawing.Size(239, 258);
            this.gbSettingsMisc.TabIndex = 2;
            this.gbSettingsMisc.TabStop = false;
            this.gbSettingsMisc.Text = "Misc";
            // 
            // Label52
            // 
            this.Label52.AutoSize = true;
            this.Label52.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label52.Location = new System.Drawing.Point(39, 211);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(80, 13);
            this.Label52.TabIndex = 26;
            this.Label52.Text = "Round to Digits";
            // 
            // tbTruncationDigits
            // 
            this.tbTruncationDigits.Location = new System.Drawing.Point(8, 208);
            this.tbTruncationDigits.Name = "tbTruncationDigits";
            this.tbTruncationDigits.Size = new System.Drawing.Size(26, 20);
            this.tbTruncationDigits.TabIndex = 24;
            // 
            // tbSettingsDefaultExt
            // 
            this.tbSettingsDefaultExt.Location = new System.Drawing.Point(12, 120);
            this.tbSettingsDefaultExt.Name = "tbSettingsDefaultExt";
            this.tbSettingsDefaultExt.Size = new System.Drawing.Size(43, 20);
            this.tbSettingsDefaultExt.TabIndex = 22;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label5.Location = new System.Drawing.Point(70, 96);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 13);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Startup delay";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label6.Location = new System.Drawing.Point(70, 123);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(77, 13);
            this.Label6.TabIndex = 21;
            this.Label6.Text = "Default File ext";
            // 
            // tbSettingsStartupDelay
            // 
            this.tbSettingsStartupDelay.Location = new System.Drawing.Point(12, 94);
            this.tbSettingsStartupDelay.Name = "tbSettingsStartupDelay";
            this.tbSettingsStartupDelay.Size = new System.Drawing.Size(44, 20);
            this.tbSettingsStartupDelay.TabIndex = 19;
            // 
            // cbSettingsLeftHanded
            // 
            this.cbSettingsLeftHanded.AutoSize = true;
            this.cbSettingsLeftHanded.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSettingsLeftHanded.Location = new System.Drawing.Point(124, 187);
            this.cbSettingsLeftHanded.Name = "cbSettingsLeftHanded";
            this.cbSettingsLeftHanded.Size = new System.Drawing.Size(107, 17);
            this.cbSettingsLeftHanded.TabIndex = 18;
            this.cbSettingsLeftHanded.Text = "Left Handed GUI";
            this.cbSettingsLeftHanded.UseVisualStyleBackColor = true;
            // 
            // cbSettingsConnectOnLoad
            // 
            this.cbSettingsConnectOnLoad.AutoSize = true;
            this.cbSettingsConnectOnLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSettingsConnectOnLoad.Location = new System.Drawing.Point(11, 169);
            this.cbSettingsConnectOnLoad.Name = "cbSettingsConnectOnLoad";
            this.cbSettingsConnectOnLoad.Size = new System.Drawing.Size(108, 17);
            this.cbSettingsConnectOnLoad.TabIndex = 12;
            this.cbSettingsConnectOnLoad.Text = "Connect on Load";
            this.ToolTip1.SetToolTip(this.cbSettingsConnectOnLoad, "Connect automatically to last port");
            this.cbSettingsConnectOnLoad.UseVisualStyleBackColor = true;
            // 
            // cbSettingsPauseOnError
            // 
            this.cbSettingsPauseOnError.AutoSize = true;
            this.cbSettingsPauseOnError.Checked = true;
            this.cbSettingsPauseOnError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSettingsPauseOnError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSettingsPauseOnError.Location = new System.Drawing.Point(11, 152);
            this.cbSettingsPauseOnError.Name = "cbSettingsPauseOnError";
            this.cbSettingsPauseOnError.Size = new System.Drawing.Size(96, 17);
            this.cbSettingsPauseOnError.TabIndex = 7;
            this.cbSettingsPauseOnError.Text = "Pause on Error";
            this.cbSettingsPauseOnError.UseVisualStyleBackColor = true;
            // 
            // cbStatusPollEnable
            // 
            this.cbStatusPollEnable.AutoSize = true;
            this.cbStatusPollEnable.Checked = true;
            this.cbStatusPollEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatusPollEnable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbStatusPollEnable.Location = new System.Drawing.Point(10, 187);
            this.cbStatusPollEnable.Name = "cbStatusPollEnable";
            this.cbStatusPollEnable.Size = new System.Drawing.Size(76, 17);
            this.cbStatusPollEnable.TabIndex = 17;
            this.cbStatusPollEnable.Text = "Status Poll";
            this.cbStatusPollEnable.UseVisualStyleBackColor = true;
            // 
            // btnSettingsRefreshMisc
            // 
            this.btnSettingsRefreshMisc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettingsRefreshMisc.Location = new System.Drawing.Point(0, 235);
            this.btnSettingsRefreshMisc.Name = "btnSettingsRefreshMisc";
            this.btnSettingsRefreshMisc.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsRefreshMisc.TabIndex = 6;
            this.btnSettingsRefreshMisc.Tag = "Misc";
            this.btnSettingsRefreshMisc.Text = "Refresh";
            this.btnSettingsRefreshMisc.UseVisualStyleBackColor = true;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label37.Location = new System.Drawing.Point(70, 70);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(77, 13);
            this.Label37.TabIndex = 5;
            this.Label37.Text = "RBuf Max Size";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label36.Location = new System.Drawing.Point(70, 44);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(61, 13);
            this.Label36.TabIndex = 4;
            this.Label36.Text = "Q Max Size";
            // 
            // tbSettingsRBuffSize
            // 
            this.tbSettingsRBuffSize.Location = new System.Drawing.Point(12, 68);
            this.tbSettingsRBuffSize.Name = "tbSettingsRBuffSize";
            this.tbSettingsRBuffSize.Size = new System.Drawing.Size(43, 20);
            this.tbSettingsRBuffSize.TabIndex = 3;
            // 
            // tbSettingsQSize
            // 
            this.tbSettingsQSize.Location = new System.Drawing.Point(12, 42);
            this.tbSettingsQSize.Name = "tbSettingsQSize";
            this.tbSettingsQSize.Size = new System.Drawing.Size(43, 20);
            this.tbSettingsQSize.TabIndex = 2;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label26.Location = new System.Drawing.Point(70, 22);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(84, 13);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "Poll Interval (ms)";
            // 
            // tbSettingsPollRate
            // 
            this.tbSettingsPollRate.Location = new System.Drawing.Point(12, 19);
            this.tbSettingsPollRate.Name = "tbSettingsPollRate";
            this.tbSettingsPollRate.Size = new System.Drawing.Size(43, 20);
            this.tbSettingsPollRate.TabIndex = 0;
            // 
            // gbSettingsPosition
            // 
            this.gbSettingsPosition.Controls.Add(this.Label8);
            this.gbSettingsPosition.Controls.Add(this.tbSettingsSpclPosition2);
            this.gbSettingsPosition.Controls.Add(this.btnSettingsRefreshPosition);
            this.gbSettingsPosition.Controls.Add(this.Label29);
            this.gbSettingsPosition.Controls.Add(this.tbWorkZ0Cmd);
            this.gbSettingsPosition.Controls.Add(this.Label28);
            this.gbSettingsPosition.Controls.Add(this.tbWorkY0Cmd);
            this.gbSettingsPosition.Controls.Add(this.Label13);
            this.gbSettingsPosition.Controls.Add(this.Label12);
            this.gbSettingsPosition.Controls.Add(this.tbWorkX0Cmd);
            this.gbSettingsPosition.Controls.Add(this.tbSettingsZeroXYZCmd);
            this.gbSettingsPosition.Controls.Add(this.Label11);
            this.gbSettingsPosition.Controls.Add(this.tbSettingsSpclPosition1);
            this.gbSettingsPosition.Location = new System.Drawing.Point(362, 19);
            this.gbSettingsPosition.Name = "gbSettingsPosition";
            this.gbSettingsPosition.Size = new System.Drawing.Size(239, 209);
            this.gbSettingsPosition.TabIndex = 1;
            this.gbSettingsPosition.TabStop = false;
            this.gbSettingsPosition.Text = "Position";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label8.Location = new System.Drawing.Point(135, 47);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(94, 13);
            this.Label8.TabIndex = 12;
            this.Label8.Text = "GoTo Spcl Posn 2";
            // 
            // tbSettingsSpclPosition2
            // 
            this.tbSettingsSpclPosition2.Location = new System.Drawing.Point(12, 44);
            this.tbSettingsSpclPosition2.Name = "tbSettingsSpclPosition2";
            this.tbSettingsSpclPosition2.Size = new System.Drawing.Size(117, 20);
            this.tbSettingsSpclPosition2.TabIndex = 11;
            // 
            // btnSettingsRefreshPosition
            // 
            this.btnSettingsRefreshPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettingsRefreshPosition.Location = new System.Drawing.Point(-2, 182);
            this.btnSettingsRefreshPosition.Name = "btnSettingsRefreshPosition";
            this.btnSettingsRefreshPosition.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsRefreshPosition.TabIndex = 10;
            this.btnSettingsRefreshPosition.Tag = "Position";
            this.btnSettingsRefreshPosition.Text = "Refresh";
            this.btnSettingsRefreshPosition.UseVisualStyleBackColor = true;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label29.Location = new System.Drawing.Point(135, 150);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(75, 13);
            this.Label29.TabIndex = 9;
            this.Label29.Text = "Work Z 0 cmd";
            // 
            // tbWorkZ0Cmd
            // 
            this.tbWorkZ0Cmd.Location = new System.Drawing.Point(12, 147);
            this.tbWorkZ0Cmd.Name = "tbWorkZ0Cmd";
            this.tbWorkZ0Cmd.Size = new System.Drawing.Size(117, 20);
            this.tbWorkZ0Cmd.TabIndex = 8;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label28.Location = new System.Drawing.Point(135, 124);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(75, 13);
            this.Label28.TabIndex = 7;
            this.Label28.Text = "Work Y 0 cmd";
            // 
            // tbWorkY0Cmd
            // 
            this.tbWorkY0Cmd.Location = new System.Drawing.Point(12, 121);
            this.tbWorkY0Cmd.Name = "tbWorkY0Cmd";
            this.tbWorkY0Cmd.Size = new System.Drawing.Size(117, 20);
            this.tbWorkY0Cmd.TabIndex = 6;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label13.Location = new System.Drawing.Point(135, 99);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(75, 13);
            this.Label13.TabIndex = 5;
            this.Label13.Text = "Work X 0 cmd";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label12.Location = new System.Drawing.Point(135, 73);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(67, 13);
            this.Label12.TabIndex = 4;
            this.Label12.Text = "Zero All Cmd";
            // 
            // tbWorkX0Cmd
            // 
            this.tbWorkX0Cmd.Location = new System.Drawing.Point(12, 96);
            this.tbWorkX0Cmd.Name = "tbWorkX0Cmd";
            this.tbWorkX0Cmd.Size = new System.Drawing.Size(117, 20);
            this.tbWorkX0Cmd.TabIndex = 3;
            // 
            // tbSettingsZeroXYZCmd
            // 
            this.tbSettingsZeroXYZCmd.Location = new System.Drawing.Point(12, 70);
            this.tbSettingsZeroXYZCmd.Name = "tbSettingsZeroXYZCmd";
            this.tbSettingsZeroXYZCmd.Size = new System.Drawing.Size(117, 20);
            this.tbSettingsZeroXYZCmd.TabIndex = 2;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label11.Location = new System.Drawing.Point(135, 21);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(94, 13);
            this.Label11.TabIndex = 1;
            this.Label11.Text = "Go To Spcl Posn1";
            this.ToolTip1.SetToolTip(this.Label11, "Also known as Soft Home");
            // 
            // tbSettingsSpclPosition1
            // 
            this.tbSettingsSpclPosition1.Location = new System.Drawing.Point(12, 18);
            this.tbSettingsSpclPosition1.Name = "tbSettingsSpclPosition1";
            this.tbSettingsSpclPosition1.Size = new System.Drawing.Size(117, 20);
            this.tbSettingsSpclPosition1.TabIndex = 0;
            // 
            // gbSettingsJogging
            // 
            this.gbSettingsJogging.Controls.Add(this.cbSettingsKeyboardJogging);
            this.gbSettingsJogging.Controls.Add(this.btnSettingsRefreshJogging);
            this.gbSettingsJogging.Controls.Add(this.Label41);
            this.gbSettingsJogging.Controls.Add(this.Label40);
            this.gbSettingsJogging.Controls.Add(this.Label39);
            this.gbSettingsJogging.Controls.Add(this.Label38);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsZRepeat);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsYRepeat);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsXRepeat);
            this.gbSettingsJogging.Controls.Add(this.Label35);
            this.gbSettingsJogging.Controls.Add(this.Label34);
            this.gbSettingsJogging.Controls.Add(this.Label32);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsFRMetric);
            this.gbSettingsJogging.Controls.Add(this.Label33);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsFIMetric);
            this.gbSettingsJogging.Controls.Add(this.Label31);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsFRImperial);
            this.gbSettingsJogging.Controls.Add(this.Label30);
            this.gbSettingsJogging.Controls.Add(this.cbSettingsMetric);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsFIImperial);
            this.gbSettingsJogging.Location = new System.Drawing.Point(607, 19);
            this.gbSettingsJogging.Name = "gbSettingsJogging";
            this.gbSettingsJogging.Size = new System.Drawing.Size(220, 324);
            this.gbSettingsJogging.TabIndex = 0;
            this.gbSettingsJogging.TabStop = false;
            this.gbSettingsJogging.Text = "Jogging";
            // 
            // cbSettingsKeyboardJogging
            // 
            this.cbSettingsKeyboardJogging.AutoSize = true;
            this.cbSettingsKeyboardJogging.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSettingsKeyboardJogging.Location = new System.Drawing.Point(6, 267);
            this.cbSettingsKeyboardJogging.Name = "cbSettingsKeyboardJogging";
            this.cbSettingsKeyboardJogging.Size = new System.Drawing.Size(140, 17);
            this.cbSettingsKeyboardJogging.TabIndex = 27;
            this.cbSettingsKeyboardJogging.Text = "Enable keyboard arrows";
            this.ToolTip1.SetToolTip(this.cbSettingsKeyboardJogging, "Allow arrows, pg up, pg dn to do jogging");
            this.cbSettingsKeyboardJogging.UseVisualStyleBackColor = true;
            // 
            // btnSettingsRefreshJogging
            // 
            this.btnSettingsRefreshJogging.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettingsRefreshJogging.Location = new System.Drawing.Point(0, 301);
            this.btnSettingsRefreshJogging.Name = "btnSettingsRefreshJogging";
            this.btnSettingsRefreshJogging.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsRefreshJogging.TabIndex = 11;
            this.btnSettingsRefreshJogging.Tag = "Jogging";
            this.btnSettingsRefreshJogging.Text = "Refresh";
            this.btnSettingsRefreshJogging.UseVisualStyleBackColor = true;
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label41.Location = new System.Drawing.Point(48, 167);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(158, 13);
            this.Label41.TabIndex = 26;
            this.Label41.Text = "Button Repeat Rate, r/sec";
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label40.Location = new System.Drawing.Point(129, 244);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(78, 13);
            this.Label40.TabIndex = 25;
            this.Label40.Text = "Z Repeat Rate";
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label39.Location = new System.Drawing.Point(129, 218);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(78, 13);
            this.Label39.TabIndex = 24;
            this.Label39.Text = "Y Repeat Rate";
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label38.Location = new System.Drawing.Point(129, 192);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(78, 13);
            this.Label38.TabIndex = 23;
            this.Label38.Text = "X Repeat Rate";
            // 
            // tbSettingsZRepeat
            // 
            this.tbSettingsZRepeat.Location = new System.Drawing.Point(6, 241);
            this.tbSettingsZRepeat.Name = "tbSettingsZRepeat";
            this.tbSettingsZRepeat.Size = new System.Drawing.Size(45, 20);
            this.tbSettingsZRepeat.TabIndex = 22;
            // 
            // tbSettingsYRepeat
            // 
            this.tbSettingsYRepeat.Location = new System.Drawing.Point(6, 215);
            this.tbSettingsYRepeat.Name = "tbSettingsYRepeat";
            this.tbSettingsYRepeat.Size = new System.Drawing.Size(45, 20);
            this.tbSettingsYRepeat.TabIndex = 21;
            // 
            // tbSettingsXRepeat
            // 
            this.tbSettingsXRepeat.Location = new System.Drawing.Point(6, 189);
            this.tbSettingsXRepeat.Name = "tbSettingsXRepeat";
            this.tbSettingsXRepeat.Size = new System.Drawing.Size(45, 20);
            this.tbSettingsXRepeat.TabIndex = 20;
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label35.Location = new System.Drawing.Point(136, 104);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(42, 13);
            this.Label35.TabIndex = 19;
            this.Label35.Text = "Metric";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label34.Location = new System.Drawing.Point(136, 38);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(51, 13);
            this.Label34.TabIndex = 18;
            this.Label34.Text = "Imperial";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label32.Location = new System.Drawing.Point(129, 146);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(62, 13);
            this.Label32.TabIndex = 17;
            this.Label32.Text = "Feed Rates";
            // 
            // tbSettingsFRMetric
            // 
            this.tbSettingsFRMetric.Location = new System.Drawing.Point(6, 143);
            this.tbSettingsFRMetric.Name = "tbSettingsFRMetric";
            this.tbSettingsFRMetric.Size = new System.Drawing.Size(117, 20);
            this.tbSettingsFRMetric.TabIndex = 16;
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label33.Location = new System.Drawing.Point(129, 120);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(86, 13);
            this.Label33.TabIndex = 15;
            this.Label33.Text = "Feed Increments";
            // 
            // tbSettingsFIMetric
            // 
            this.tbSettingsFIMetric.Location = new System.Drawing.Point(6, 117);
            this.tbSettingsFIMetric.Name = "tbSettingsFIMetric";
            this.tbSettingsFIMetric.Size = new System.Drawing.Size(117, 20);
            this.tbSettingsFIMetric.TabIndex = 14;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label31.Location = new System.Drawing.Point(129, 85);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(62, 13);
            this.Label31.TabIndex = 13;
            this.Label31.Text = "Feed Rates";
            // 
            // tbSettingsFRImperial
            // 
            this.tbSettingsFRImperial.Location = new System.Drawing.Point(6, 82);
            this.tbSettingsFRImperial.Name = "tbSettingsFRImperial";
            this.tbSettingsFRImperial.Size = new System.Drawing.Size(117, 20);
            this.tbSettingsFRImperial.TabIndex = 12;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label30.Location = new System.Drawing.Point(129, 59);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(86, 13);
            this.Label30.TabIndex = 11;
            this.Label30.Text = "Feed Increments";
            // 
            // cbSettingsMetric
            // 
            this.cbSettingsMetric.AutoSize = true;
            this.cbSettingsMetric.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSettingsMetric.Location = new System.Drawing.Point(3, 21);
            this.cbSettingsMetric.Name = "cbSettingsMetric";
            this.cbSettingsMetric.Size = new System.Drawing.Size(55, 17);
            this.cbSettingsMetric.TabIndex = 0;
            this.cbSettingsMetric.Text = "Metric";
            this.cbSettingsMetric.UseVisualStyleBackColor = true;
            // 
            // tbSettingsFIImperial
            // 
            this.tbSettingsFIImperial.Location = new System.Drawing.Point(6, 56);
            this.tbSettingsFIImperial.Name = "tbSettingsFIImperial";
            this.tbSettingsFIImperial.Size = new System.Drawing.Size(117, 20);
            this.tbSettingsFIImperial.TabIndex = 10;
            // 
            // btnSetOffsetG59
            // 
            this.btnSetOffsetG59.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetOffsetG59.Location = new System.Drawing.Point(18, 274);
            this.btnSetOffsetG59.Name = "btnSetOffsetG59";
            this.btnSetOffsetG59.Size = new System.Drawing.Size(46, 23);
            this.btnSetOffsetG59.TabIndex = 122;
            this.btnSetOffsetG59.Tag = "G59";
            this.btnSetOffsetG59.Text = "G59";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG59, "Click to set to Current Machine Location");
            this.btnSetOffsetG59.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG56
            // 
            this.btnSetOffsetG56.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetOffsetG56.Location = new System.Drawing.Point(18, 195);
            this.btnSetOffsetG56.Name = "btnSetOffsetG56";
            this.btnSetOffsetG56.Size = new System.Drawing.Size(46, 23);
            this.btnSetOffsetG56.TabIndex = 119;
            this.btnSetOffsetG56.Tag = "G56";
            this.btnSetOffsetG56.Text = "G56";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG56, "Click to set to Current Machine Location");
            this.btnSetOffsetG56.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG57
            // 
            this.btnSetOffsetG57.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetOffsetG57.Location = new System.Drawing.Point(18, 222);
            this.btnSetOffsetG57.Name = "btnSetOffsetG57";
            this.btnSetOffsetG57.Size = new System.Drawing.Size(46, 23);
            this.btnSetOffsetG57.TabIndex = 120;
            this.btnSetOffsetG57.Tag = "G57";
            this.btnSetOffsetG57.Text = "G57";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG57, "Click to set to Current Machine Location");
            this.btnSetOffsetG57.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG58
            // 
            this.btnSetOffsetG58.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetOffsetG58.Location = new System.Drawing.Point(18, 248);
            this.btnSetOffsetG58.Name = "btnSetOffsetG58";
            this.btnSetOffsetG58.Size = new System.Drawing.Size(46, 23);
            this.btnSetOffsetG58.TabIndex = 121;
            this.btnSetOffsetG58.Tag = "G58";
            this.btnSetOffsetG58.Text = "G58";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG58, "Click to set to Current Machine Location");
            this.btnSetOffsetG58.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG55
            // 
            this.btnSetOffsetG55.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetOffsetG55.Location = new System.Drawing.Point(18, 169);
            this.btnSetOffsetG55.Name = "btnSetOffsetG55";
            this.btnSetOffsetG55.Size = new System.Drawing.Size(46, 23);
            this.btnSetOffsetG55.TabIndex = 118;
            this.btnSetOffsetG55.Tag = "G55";
            this.btnSetOffsetG55.Text = "G55";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG55, "Click to set to Current Machine Location");
            this.btnSetOffsetG55.UseVisualStyleBackColor = true;
            // 
            // btnSetOffsetG54
            // 
            this.btnSetOffsetG54.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetOffsetG54.Location = new System.Drawing.Point(18, 143);
            this.btnSetOffsetG54.Name = "btnSetOffsetG54";
            this.btnSetOffsetG54.Size = new System.Drawing.Size(46, 23);
            this.btnSetOffsetG54.TabIndex = 117;
            this.btnSetOffsetG54.Tag = "G54";
            this.btnSetOffsetG54.Text = "G54";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG54, "Click to set to Current Machine Location");
            this.btnSetOffsetG54.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label10.Location = new System.Drawing.Point(133, 25);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(125, 13);
            this.Label10.TabIndex = 116;
            this.Label10.Text = "Current Machine location";
            // 
            // Label71
            // 
            this.Label71.AutoSize = true;
            this.Label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label71.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label71.Location = new System.Drawing.Point(23, 108);
            this.Label71.Name = "Label71";
            this.Label71.Size = new System.Drawing.Size(41, 13);
            this.Label71.TabIndex = 115;
            this.Label71.Text = "G43.1";
            // 
            // tbOffSetsMachZ
            // 
            this.tbOffSetsMachZ.Enabled = false;
            this.tbOffSetsMachZ.Location = new System.Drawing.Point(245, 45);
            this.tbOffSetsMachZ.Name = "tbOffSetsMachZ";
            this.tbOffSetsMachZ.Size = new System.Drawing.Size(79, 20);
            this.tbOffSetsMachZ.TabIndex = 114;
            this.tbOffSetsMachZ.Tag = "G28Z";
            this.ToolTip1.SetToolTip(this.tbOffSetsMachZ, "Current Machine Z");
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label19.Location = new System.Drawing.Point(23, 90);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(113, 13);
            this.Label19.TabIndex = 100;
            this.Label19.Text = "Tool Length Offset";
            // 
            // tbOffsetsG56Y
            // 
            this.tbOffsetsG56Y.Location = new System.Drawing.Point(160, 197);
            this.tbOffsetsG56Y.Name = "tbOffsetsG56Y";
            this.tbOffsetsG56Y.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG56Y.TabIndex = 76;
            this.tbOffsetsG56Y.Tag = "G56Y";
            // 
            // tbOffSetsMachY
            // 
            this.tbOffSetsMachY.Enabled = false;
            this.tbOffSetsMachY.Location = new System.Drawing.Point(160, 45);
            this.tbOffSetsMachY.Name = "tbOffSetsMachY";
            this.tbOffSetsMachY.Size = new System.Drawing.Size(79, 20);
            this.tbOffSetsMachY.TabIndex = 113;
            this.tbOffSetsMachY.Tag = "G28Y";
            this.ToolTip1.SetToolTip(this.tbOffSetsMachY, "Current Machine Y");
            // 
            // tbOffsetsG56X
            // 
            this.tbOffsetsG56X.Location = new System.Drawing.Point(75, 197);
            this.tbOffsetsG56X.Name = "tbOffsetsG56X";
            this.tbOffsetsG56X.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG56X.TabIndex = 75;
            this.tbOffsetsG56X.Tag = "G56X";
            // 
            // tbOffsetsG56Z
            // 
            this.tbOffsetsG56Z.Location = new System.Drawing.Point(245, 197);
            this.tbOffsetsG56Z.Name = "tbOffsetsG56Z";
            this.tbOffsetsG56Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG56Z.TabIndex = 77;
            this.tbOffsetsG56Z.Tag = "G56Z";
            // 
            // tbOffSetsMachX
            // 
            this.tbOffSetsMachX.Enabled = false;
            this.tbOffSetsMachX.Location = new System.Drawing.Point(75, 45);
            this.tbOffSetsMachX.Name = "tbOffSetsMachX";
            this.tbOffSetsMachX.Size = new System.Drawing.Size(79, 20);
            this.tbOffSetsMachX.TabIndex = 112;
            this.tbOffSetsMachX.Tag = "G28X";
            this.ToolTip1.SetToolTip(this.tbOffSetsMachX, "Current Machine X");
            // 
            // btnOffsetsG57Zero
            // 
            this.btnOffsetsG57Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG57Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG57Zero.Location = new System.Drawing.Point(330, 222);
            this.btnOffsetsG57Zero.Name = "btnOffsetsG57Zero";
            this.btnOffsetsG57Zero.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG57Zero.TabIndex = 74;
            this.btnOffsetsG57Zero.Tag = "G57Zero";
            this.btnOffsetsG57Zero.Text = "0";
            this.btnOffsetsG57Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG54X
            // 
            this.tbOffsetsG54X.Location = new System.Drawing.Point(75, 145);
            this.tbOffsetsG54X.Name = "tbOffsetsG54X";
            this.tbOffsetsG54X.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG54X.TabIndex = 56;
            this.tbOffsetsG54X.Tag = "G54X";
            // 
            // btnOffsetsRetrieve
            // 
            this.btnOffsetsRetrieve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsRetrieve.Location = new System.Drawing.Point(245, 299);
            this.btnOffsetsRetrieve.Name = "btnOffsetsRetrieve";
            this.btnOffsetsRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnOffsetsRetrieve.TabIndex = 106;
            this.btnOffsetsRetrieve.Text = "Retrieve";
            this.ToolTip1.SetToolTip(this.btnOffsetsRetrieve, "Get from Grbl");
            this.btnOffsetsRetrieve.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG55Y
            // 
            this.tbOffsetsG55Y.Location = new System.Drawing.Point(160, 171);
            this.tbOffsetsG55Y.Name = "tbOffsetsG55Y";
            this.tbOffsetsG55Y.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG55Y.TabIndex = 81;
            this.tbOffsetsG55Y.Tag = "G55Y";
            // 
            // btnOffsetsG54Zero
            // 
            this.btnOffsetsG54Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG54Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG54Zero.Location = new System.Drawing.Point(330, 144);
            this.btnOffsetsG54Zero.Name = "btnOffsetsG54Zero";
            this.btnOffsetsG54Zero.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG54Zero.TabIndex = 59;
            this.btnOffsetsG54Zero.Tag = "G54Zero";
            this.btnOffsetsG54Zero.Text = "0";
            this.btnOffsetsG54Zero.UseVisualStyleBackColor = true;
            // 
            // btnOffsetsLoad
            // 
            this.btnOffsetsLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsLoad.Location = new System.Drawing.Point(75, 300);
            this.btnOffsetsLoad.Name = "btnOffsetsLoad";
            this.btnOffsetsLoad.Size = new System.Drawing.Size(75, 23);
            this.btnOffsetsLoad.TabIndex = 105;
            this.btnOffsetsLoad.Text = "Load";
            this.ToolTip1.SetToolTip(this.btnOffsetsLoad, "Load Work Offsets from File");
            this.btnOffsetsLoad.UseVisualStyleBackColor = true;
            // 
            // btnOffsetsG56Zero
            // 
            this.btnOffsetsG56Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG56Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG56Zero.Location = new System.Drawing.Point(330, 196);
            this.btnOffsetsG56Zero.Name = "btnOffsetsG56Zero";
            this.btnOffsetsG56Zero.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG56Zero.TabIndex = 79;
            this.btnOffsetsG56Zero.Tag = "G56Zero";
            this.btnOffsetsG56Zero.Text = "0";
            this.btnOffsetsG56Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG54Y
            // 
            this.tbOffsetsG54Y.Location = new System.Drawing.Point(160, 145);
            this.tbOffsetsG54Y.Name = "tbOffsetsG54Y";
            this.tbOffsetsG54Y.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG54Y.TabIndex = 57;
            this.tbOffsetsG54Y.Tag = "G54Y";
            // 
            // tbOffsetsG57Z
            // 
            this.tbOffsetsG57Z.Location = new System.Drawing.Point(245, 223);
            this.tbOffsetsG57Z.Name = "tbOffsetsG57Z";
            this.tbOffsetsG57Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG57Z.TabIndex = 72;
            this.tbOffsetsG57Z.Tag = "G57Z";
            // 
            // btnOffsetsSave
            // 
            this.btnOffsetsSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsSave.Location = new System.Drawing.Point(160, 299);
            this.btnOffsetsSave.Name = "btnOffsetsSave";
            this.btnOffsetsSave.Size = new System.Drawing.Size(75, 23);
            this.btnOffsetsSave.TabIndex = 107;
            this.btnOffsetsSave.Text = "Save";
            this.ToolTip1.SetToolTip(this.btnOffsetsSave, "Save Work Offsets to File");
            this.btnOffsetsSave.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG55X
            // 
            this.tbOffsetsG55X.Location = new System.Drawing.Point(75, 171);
            this.tbOffsetsG55X.Name = "tbOffsetsG55X";
            this.tbOffsetsG55X.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG55X.TabIndex = 80;
            this.tbOffsetsG55X.Tag = "G55X";
            // 
            // tbOffsetsG54Z
            // 
            this.tbOffsetsG54Z.Location = new System.Drawing.Point(245, 145);
            this.tbOffsetsG54Z.Name = "tbOffsetsG54Z";
            this.tbOffsetsG54Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG54Z.TabIndex = 58;
            this.tbOffsetsG54Z.Tag = "G54Z";
            // 
            // tbOffsetsG57Y
            // 
            this.tbOffsetsG57Y.Location = new System.Drawing.Point(160, 223);
            this.tbOffsetsG57Y.Name = "tbOffsetsG57Y";
            this.tbOffsetsG57Y.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG57Y.TabIndex = 71;
            this.tbOffsetsG57Y.Tag = "G57Y";
            // 
            // tbOffsetsG57X
            // 
            this.tbOffsetsG57X.Location = new System.Drawing.Point(75, 223);
            this.tbOffsetsG57X.Name = "tbOffsetsG57X";
            this.tbOffsetsG57X.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG57X.TabIndex = 70;
            this.tbOffsetsG57X.Tag = "G57X";
            // 
            // tbOffsetsG55Z
            // 
            this.tbOffsetsG55Z.Location = new System.Drawing.Point(245, 171);
            this.tbOffsetsG55Z.Name = "tbOffsetsG55Z";
            this.tbOffsetsG55Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG55Z.TabIndex = 82;
            this.tbOffsetsG55Z.Tag = "G55Z";
            // 
            // tpOffsets
            // 
            this.tpOffsets.Controls.Add(this.btnSetOffsetG59);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG58);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG57);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG56);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG55);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG54);
            this.tpOffsets.Controls.Add(this.Label10);
            this.tpOffsets.Controls.Add(this.Label71);
            this.tpOffsets.Controls.Add(this.tbOffSetsMachZ);
            this.tpOffsets.Controls.Add(this.Label19);
            this.tpOffsets.Controls.Add(this.tbOffsetsG56Y);
            this.tpOffsets.Controls.Add(this.tbOffSetsMachY);
            this.tpOffsets.Controls.Add(this.tbOffsetsG56X);
            this.tpOffsets.Controls.Add(this.tbOffsetsG56Z);
            this.tpOffsets.Controls.Add(this.tbOffSetsMachX);
            this.tpOffsets.Controls.Add(this.btnOffsetsG57Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG54X);
            this.tpOffsets.Controls.Add(this.btnOffsetsG56Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG54Y);
            this.tpOffsets.Controls.Add(this.tbOffsetsG57Z);
            this.tpOffsets.Controls.Add(this.btnOffsetsSave);
            this.tpOffsets.Controls.Add(this.tbOffsetsG55X);
            this.tpOffsets.Controls.Add(this.tbOffsetsG54Z);
            this.tpOffsets.Controls.Add(this.tbOffsetsG57Y);
            this.tpOffsets.Controls.Add(this.btnOffsetsRetrieve);
            this.tpOffsets.Controls.Add(this.tbOffsetsG55Y);
            this.tpOffsets.Controls.Add(this.btnOffsetsG54Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG57X);
            this.tpOffsets.Controls.Add(this.btnOffsetsLoad);
            this.tpOffsets.Controls.Add(this.tbOffsetsG55Z);
            this.tpOffsets.Controls.Add(this.tbOffsetsG59X);
            this.tpOffsets.Controls.Add(this.btnOffsetsG58Zero);
            this.tpOffsets.Controls.Add(this.btnOffsetsG43Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG59Y);
            this.tpOffsets.Controls.Add(this.tbOffsetsG43Z);
            this.tpOffsets.Controls.Add(this.btnOffsetsG55Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG59Z);
            this.tpOffsets.Controls.Add(this.tbOffsetsG58Z);
            this.tpOffsets.Controls.Add(this.Label60);
            this.tpOffsets.Controls.Add(this.tbOffsetsG58Y);
            this.tpOffsets.Controls.Add(this.Label20);
            this.tpOffsets.Controls.Add(this.Label43);
            this.tpOffsets.Controls.Add(this.btnOffsetsG59Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG58X);
            this.tpOffsets.Controls.Add(this.Label21);
            this.tpOffsets.Location = new System.Drawing.Point(4, 22);
            this.tpOffsets.Name = "tpOffsets";
            this.tpOffsets.Padding = new System.Windows.Forms.Padding(3);
            this.tpOffsets.Size = new System.Drawing.Size(380, 352);
            this.tpOffsets.TabIndex = 2;
            this.tpOffsets.Text = "Offsets";
            this.tpOffsets.ToolTipText = "Click to set to Current Machine Location";
            this.tpOffsets.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG59X
            // 
            this.tbOffsetsG59X.Location = new System.Drawing.Point(75, 275);
            this.tbOffsetsG59X.Name = "tbOffsetsG59X";
            this.tbOffsetsG59X.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG59X.TabIndex = 60;
            this.tbOffsetsG59X.Tag = "G59X";
            // 
            // btnOffsetsG58Zero
            // 
            this.btnOffsetsG58Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG58Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG58Zero.Location = new System.Drawing.Point(330, 248);
            this.btnOffsetsG58Zero.Name = "btnOffsetsG58Zero";
            this.btnOffsetsG58Zero.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG58Zero.TabIndex = 69;
            this.btnOffsetsG58Zero.Tag = "G58Zero";
            this.btnOffsetsG58Zero.Text = "0";
            this.btnOffsetsG58Zero.UseVisualStyleBackColor = true;
            // 
            // btnOffsetsG43Zero
            // 
            this.btnOffsetsG43Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG43Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG43Zero.Location = new System.Drawing.Point(330, 104);
            this.btnOffsetsG43Zero.Name = "btnOffsetsG43Zero";
            this.btnOffsetsG43Zero.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG43Zero.TabIndex = 103;
            this.btnOffsetsG43Zero.Tag = "G43Zero";
            this.btnOffsetsG43Zero.Text = "0";
            this.btnOffsetsG43Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG59Y
            // 
            this.tbOffsetsG59Y.Location = new System.Drawing.Point(160, 275);
            this.tbOffsetsG59Y.Name = "tbOffsetsG59Y";
            this.tbOffsetsG59Y.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG59Y.TabIndex = 61;
            this.tbOffsetsG59Y.Tag = "G59Y";
            // 
            // tbOffsetsG43Z
            // 
            this.tbOffsetsG43Z.Location = new System.Drawing.Point(245, 105);
            this.tbOffsetsG43Z.Name = "tbOffsetsG43Z";
            this.tbOffsetsG43Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG43Z.TabIndex = 102;
            this.tbOffsetsG43Z.Tag = "G43Z";
            // 
            // btnOffsetsG55Zero
            // 
            this.btnOffsetsG55Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG55Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG55Zero.Location = new System.Drawing.Point(330, 170);
            this.btnOffsetsG55Zero.Name = "btnOffsetsG55Zero";
            this.btnOffsetsG55Zero.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG55Zero.TabIndex = 84;
            this.btnOffsetsG55Zero.Tag = "G55Zero";
            this.btnOffsetsG55Zero.Text = "0";
            this.btnOffsetsG55Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG59Z
            // 
            this.tbOffsetsG59Z.Location = new System.Drawing.Point(245, 275);
            this.tbOffsetsG59Z.Name = "tbOffsetsG59Z";
            this.tbOffsetsG59Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG59Z.TabIndex = 62;
            this.tbOffsetsG59Z.Tag = "G59Z";
            // 
            // tbOffsetsG58Z
            // 
            this.tbOffsetsG58Z.Location = new System.Drawing.Point(245, 249);
            this.tbOffsetsG58Z.Name = "tbOffsetsG58Z";
            this.tbOffsetsG58Z.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG58Z.TabIndex = 67;
            this.tbOffsetsG58Z.Tag = "G58Z";
            // 
            // Label60
            // 
            this.Label60.AutoSize = true;
            this.Label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label60.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label60.Location = new System.Drawing.Point(116, 68);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(15, 13);
            this.Label60.TabIndex = 85;
            this.Label60.Text = "X";
            // 
            // tbOffsetsG58Y
            // 
            this.tbOffsetsG58Y.Location = new System.Drawing.Point(160, 249);
            this.tbOffsetsG58Y.Name = "tbOffsetsG58Y";
            this.tbOffsetsG58Y.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG58Y.TabIndex = 66;
            this.tbOffsetsG58Y.Tag = "G58Y";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label20.Location = new System.Drawing.Point(28, 129);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(81, 13);
            this.Label20.TabIndex = 99;
            this.Label20.Text = "Work Offsets";
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label43.Location = new System.Drawing.Point(189, 68);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(15, 13);
            this.Label43.TabIndex = 86;
            this.Label43.Text = "Y";
            // 
            // btnOffsetsG59Zero
            // 
            this.btnOffsetsG59Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOffsetsG59Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOffsetsG59Zero.Location = new System.Drawing.Point(330, 274);
            this.btnOffsetsG59Zero.Name = "btnOffsetsG59Zero";
            this.btnOffsetsG59Zero.Size = new System.Drawing.Size(35, 23);
            this.btnOffsetsG59Zero.TabIndex = 64;
            this.btnOffsetsG59Zero.Tag = "G59Zero";
            this.btnOffsetsG59Zero.Text = "0";
            this.btnOffsetsG59Zero.UseVisualStyleBackColor = true;
            // 
            // tbOffsetsG58X
            // 
            this.tbOffsetsG58X.Location = new System.Drawing.Point(75, 249);
            this.tbOffsetsG58X.Name = "tbOffsetsG58X";
            this.tbOffsetsG58X.Size = new System.Drawing.Size(79, 20);
            this.tbOffsetsG58X.TabIndex = 65;
            this.tbOffsetsG58X.Tag = "G58X";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label21.Location = new System.Drawing.Point(280, 68);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(15, 13);
            this.Label21.TabIndex = 87;
            this.Label21.Text = "Z";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.SystemColors.Control;
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.tbWorkZ);
            this.Panel5.Controls.Add(this.tbMachZ);
            this.Panel5.Location = new System.Drawing.Point(48, 179);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(287, 88);
            this.Panel5.TabIndex = 19;
            // 
            // tbWorkZ
            // 
            this.tbWorkZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWorkZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold);
            this.tbWorkZ.Location = new System.Drawing.Point(-1, 0);
            this.tbWorkZ.Name = "tbWorkZ";
            this.tbWorkZ.Size = new System.Drawing.Size(287, 68);
            this.tbWorkZ.TabIndex = 5;
            this.tbWorkZ.Tag = "Z";
            this.tbWorkZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.tbWorkZ, "Work Z position");
            this.tbWorkZ.WordWrap = false;
            // 
            // tbMachZ
            // 
            this.tbMachZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMachZ.Enabled = false;
            this.tbMachZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.tbMachZ.Location = new System.Drawing.Point(188, 63);
            this.tbMachZ.Name = "tbMachZ";
            this.tbMachZ.Size = new System.Drawing.Size(98, 23);
            this.tbMachZ.TabIndex = 8;
            this.tbMachZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.tbMachZ, "Machine Z position");
            this.tbMachZ.WordWrap = false;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.SystemColors.Control;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.tbWorkY);
            this.Panel4.Controls.Add(this.tbMachY);
            this.Panel4.Location = new System.Drawing.Point(48, 91);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(287, 88);
            this.Panel4.TabIndex = 18;
            // 
            // tbWorkY
            // 
            this.tbWorkY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWorkY.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold);
            this.tbWorkY.Location = new System.Drawing.Point(0, -3);
            this.tbWorkY.Name = "tbWorkY";
            this.tbWorkY.Size = new System.Drawing.Size(287, 68);
            this.tbWorkY.TabIndex = 4;
            this.tbWorkY.Tag = "Y";
            this.tbWorkY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.tbWorkY, "Work Y position");
            this.tbWorkY.WordWrap = false;
            // 
            // tbMachY
            // 
            this.tbMachY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMachY.Enabled = false;
            this.tbMachY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.tbMachY.Location = new System.Drawing.Point(188, 64);
            this.tbMachY.Name = "tbMachY";
            this.tbMachY.Size = new System.Drawing.Size(98, 23);
            this.tbMachY.TabIndex = 7;
            this.tbMachY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.tbMachY, "Machine Y position");
            this.tbMachY.WordWrap = false;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.SystemColors.Control;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.tbMachX);
            this.Panel3.Controls.Add(this.tbWorkX);
            this.Panel3.Location = new System.Drawing.Point(48, 3);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(287, 88);
            this.Panel3.TabIndex = 0;
            // 
            // tbMachX
            // 
            this.tbMachX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMachX.Enabled = false;
            this.tbMachX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.tbMachX.Location = new System.Drawing.Point(188, 64);
            this.tbMachX.Name = "tbMachX";
            this.tbMachX.Size = new System.Drawing.Size(98, 23);
            this.tbMachX.TabIndex = 6;
            this.tbMachX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.tbMachX, "Machine X position");
            this.tbMachX.WordWrap = false;
            // 
            // tbWorkX
            // 
            this.tbWorkX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWorkX.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold);
            this.tbWorkX.Location = new System.Drawing.Point(-1, -1);
            this.tbWorkX.Name = "tbWorkX";
            this.tbWorkX.Size = new System.Drawing.Size(287, 68);
            this.tbWorkX.TabIndex = 12;
            this.tbWorkX.Tag = "X";
            this.tbWorkX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.tbWorkX, "Work X position");
            this.tbWorkX.WordWrap = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblPositionCurrentOffset);
            this.GroupBox1.Location = new System.Drawing.Point(224, 282);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(82, 58);
            this.GroupBox1.TabIndex = 17;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Active Offset";
            // 
            // lblPositionCurrentOffset
            // 
            this.lblPositionCurrentOffset.AutoSize = true;
            this.lblPositionCurrentOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPositionCurrentOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPositionCurrentOffset.Location = new System.Drawing.Point(23, 21);
            this.lblPositionCurrentOffset.Name = "lblPositionCurrentOffset";
            this.lblPositionCurrentOffset.Size = new System.Drawing.Size(0, 20);
            this.lblPositionCurrentOffset.TabIndex = 0;
            // 
            // btnWorkSoftHome
            // 
            this.btnWorkSoftHome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWorkSoftHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnWorkSoftHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWorkSoftHome.Location = new System.Drawing.Point(75, 285);
            this.btnWorkSoftHome.Name = "btnWorkSoftHome";
            this.btnWorkSoftHome.Size = new System.Drawing.Size(66, 58);
            this.btnWorkSoftHome.TabIndex = 16;
            this.btnWorkSoftHome.Tag = "Spcl Posn1";
            this.btnWorkSoftHome.Text = "Go To Spcl Posn1";
            this.ToolTip1.SetToolTip(this.btnWorkSoftHome, "GoTo Position 1 using G28");
            this.btnWorkSoftHome.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(5, 285);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(66, 58);
            this.btnHome.TabIndex = 6;
            this.btnHome.Tag = "HomeCycle";
            this.btnHome.Text = "Home Cycle";
            this.ToolTip1.SetToolTip(this.btnHome, "Perform Homing Cycle");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Visible = false;
            // 
            // btnWorkSpclPosition
            // 
            this.btnWorkSpclPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWorkSpclPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnWorkSpclPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWorkSpclPosition.Location = new System.Drawing.Point(145, 285);
            this.btnWorkSpclPosition.Name = "btnWorkSpclPosition";
            this.btnWorkSpclPosition.Size = new System.Drawing.Size(75, 58);
            this.btnWorkSpclPosition.TabIndex = 16;
            this.btnWorkSpclPosition.Tag = "Spcl Posn2";
            this.btnWorkSpclPosition.Text = "Go To Spcl Posn2";
            this.ToolTip1.SetToolTip(this.btnWorkSpclPosition, "Go To Position 2 using G30");
            this.btnWorkSpclPosition.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(7, 203);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 37);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Z";
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.gbEditor);
            this.TabPage1.Controls.Add(this.btnCancel);
            this.TabPage1.Controls.Add(this.btnOK);
            this.TabPage1.Controls.Add(this.dgMacros);
            this.TabPage1.Controls.Add(this.lblStatusLabel);
            this.TabPage1.Controls.Add(this.btnDeleteMacro);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(1134, 677);
            this.TabPage1.TabIndex = 2;
            this.TabPage1.Text = "Macros";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // gbEditor
            // 
            this.gbEditor.Controls.Add(this.btnAdd);
            this.gbEditor.Controls.Add(this.lblGCode);
            this.gbEditor.Controls.Add(this.tbGCode);
            this.gbEditor.Controls.Add(this.lblName);
            this.gbEditor.Controls.Add(this.tbName);
            this.gbEditor.Location = new System.Drawing.Point(6, 147);
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.Size = new System.Drawing.Size(352, 182);
            this.gbEditor.TabIndex = 8;
            this.gbEditor.TabStop = false;
            this.gbEditor.Text = "Editor";
            // 
            // btnAdd
            // 
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(166, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblGCode
            // 
            this.lblGCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGCode.Location = new System.Drawing.Point(9, 51);
            this.lblGCode.Name = "lblGCode";
            this.lblGCode.Size = new System.Drawing.Size(50, 15);
            this.lblGCode.TabIndex = 3;
            this.lblGCode.Text = "G Code:";
            this.lblGCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbGCode
            // 
            this.tbGCode.AcceptsReturn = true;
            this.tbGCode.Location = new System.Drawing.Point(62, 48);
            this.tbGCode.Multiline = true;
            this.tbGCode.Name = "tbGCode";
            this.tbGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGCode.Size = new System.Drawing.Size(284, 128);
            this.tbGCode.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(9, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(61, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(99, 20);
            this.tbName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(371, 33);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(371, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // dgMacros
            // 
            this.dgMacros.AllowUserToAddRows = false;
            this.dgMacros.AllowUserToDeleteRows = false;
            this.dgMacros.AllowUserToResizeColumns = false;
            this.dgMacros.AllowUserToResizeRows = false;
            this.dgMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMacros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgMacros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMacros.Location = new System.Drawing.Point(18, 3);
            this.dgMacros.Name = "dgMacros";
            this.dgMacros.ReadOnly = true;
            this.dgMacros.RowHeadersVisible = false;
            this.dgMacros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMacros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgMacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMacros.Size = new System.Drawing.Size(148, 134);
            this.dgMacros.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "GCode";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatusLabel.Location = new System.Drawing.Point(9, 263);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(242, 23);
            this.lblStatusLabel.TabIndex = 13;
            // 
            // btnDeleteMacro
            // 
            this.btnDeleteMacro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteMacro.Location = new System.Drawing.Point(371, 103);
            this.btnDeleteMacro.Name = "btnDeleteMacro";
            this.btnDeleteMacro.Size = new System.Drawing.Size(74, 34);
            this.btnDeleteMacro.TabIndex = 12;
            this.btnDeleteMacro.Text = "Delete Selected";
            this.btnDeleteMacro.UseVisualStyleBackColor = true;
            // 
            // ofdGcodeFile
            // 
            this.ofdGcodeFile.DefaultExt = "ngc";
            this.ofdGcodeFile.FileName = "*.*";
            this.ofdGcodeFile.Filter = "All files (*.*)|*.*";
            // 
            // sfdOffsets
            // 
            this.sfdOffsets.DefaultExt = "xml";
            this.sfdOffsets.Filter = "WorkOffset Files|*.xml";
            // 
            // btnWork0
            // 
            this.btnWork0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWork0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnWork0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWork0.Location = new System.Drawing.Point(310, 285);
            this.btnWork0.Name = "btnWork0";
            this.btnWork0.Size = new System.Drawing.Size(66, 58);
            this.btnWork0.TabIndex = 5;
            this.btnWork0.Tag = "ZeroXYZ";
            this.btnWork0.Text = "Zero XYZ";
            this.ToolTip1.SetToolTip(this.btnWork0, "Set all axes to 0 on Active Offset");
            this.btnWork0.UseVisualStyleBackColor = true;
            // 
            // cbFeedHold
            // 
            this.cbFeedHold.AutoCheck = false;
            this.cbFeedHold.AutoSize = true;
            this.cbFeedHold.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbFeedHold.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFeedHold.Location = new System.Drawing.Point(124, 16);
            this.cbFeedHold.Name = "cbFeedHold";
            this.cbFeedHold.Size = new System.Drawing.Size(25, 31);
            this.cbFeedHold.TabIndex = 44;
            this.cbFeedHold.Text = "FH";
            this.ToolTip1.SetToolTip(this.cbFeedHold, "Feed Hold");
            this.cbFeedHold.UseVisualStyleBackColor = true;
            this.cbFeedHold.Visible = false;
            // 
            // gbMDI
            // 
            this.gbMDI.Controls.Add(this.Label9);
            this.gbMDI.Controls.Add(this.btnSend);
            this.gbMDI.Controls.Add(this.tbSendData);
            this.gbMDI.Enabled = false;
            this.gbMDI.Location = new System.Drawing.Point(187, 3);
            this.gbMDI.Name = "gbMDI";
            this.gbMDI.Size = new System.Drawing.Size(336, 89);
            this.gbMDI.TabIndex = 15;
            this.gbMDI.TabStop = false;
            this.gbMDI.Text = "MDI";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label9.Location = new System.Drawing.Point(6, 19);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(106, 13);
            this.Label9.TabIndex = 12;
            this.Label9.Text = "Manual Command";
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.Location = new System.Drawing.Point(281, 32);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(44, 25);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbSendData
            // 
            this.tbSendData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSendData.Location = new System.Drawing.Point(6, 35);
            this.tbSendData.Name = "tbSendData";
            this.tbSendData.Size = new System.Drawing.Size(269, 20);
            this.tbSendData.TabIndex = 4;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.tbStateFeedRate);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.tbStateTool);
            this.Panel2.Controls.Add(this.Label53);
            this.Panel2.Controls.Add(this.Label50);
            this.Panel2.Controls.Add(this.tbStateSpindleRPM);
            this.Panel2.Location = new System.Drawing.Point(12, 225);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(169, 100);
            this.Panel2.TabIndex = 38;
            // 
            // tbStateFeedRate
            // 
            this.tbStateFeedRate.Location = new System.Drawing.Point(3, 17);
            this.tbStateFeedRate.Name = "tbStateFeedRate";
            this.tbStateFeedRate.Size = new System.Drawing.Size(74, 20);
            this.tbStateFeedRate.TabIndex = 22;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label14.Location = new System.Drawing.Point(84, 17);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(54, 13);
            this.Label14.TabIndex = 17;
            this.Label14.Text = "FeedRate";
            // 
            // tbStateTool
            // 
            this.tbStateTool.Location = new System.Drawing.Point(3, 61);
            this.tbStateTool.Name = "tbStateTool";
            this.tbStateTool.Size = new System.Drawing.Size(74, 20);
            this.tbStateTool.TabIndex = 28;
            // 
            // Label53
            // 
            this.Label53.AutoSize = true;
            this.Label53.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label53.Location = new System.Drawing.Point(83, 63);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(28, 13);
            this.Label53.TabIndex = 14;
            this.Label53.Text = "Tool";
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label50.Location = new System.Drawing.Point(83, 40);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(69, 13);
            this.Label50.TabIndex = 12;
            this.Label50.Text = "Spindle RPM";
            // 
            // tbStateSpindleRPM
            // 
            this.tbStateSpindleRPM.Location = new System.Drawing.Point(3, 39);
            this.tbStateSpindleRPM.Name = "tbStateSpindleRPM";
            this.tbStateSpindleRPM.Size = new System.Drawing.Size(74, 20);
            this.tbStateSpindleRPM.TabIndex = 27;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.cbxStateFeedMode);
            this.Panel1.Controls.Add(this.cbxStateDistance);
            this.Panel1.Controls.Add(this.Label16);
            this.Panel1.Controls.Add(this.cbxStateUnits);
            this.Panel1.Controls.Add(this.Label123);
            this.Panel1.Controls.Add(this.Lalbel49);
            this.Panel1.Controls.Add(this.cbxStatePlane);
            this.Panel1.Controls.Add(this.Label47);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.cbxStateOffset);
            this.Panel1.Controls.Add(this.cbxStateCoolant);
            this.Panel1.Controls.Add(this.Label45);
            this.Panel1.Controls.Add(this.Label17);
            this.Panel1.Controls.Add(this.cbxStateSpindle);
            this.Panel1.Location = new System.Drawing.Point(12, 19);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(169, 196);
            this.Panel1.TabIndex = 37;
            // 
            // cbxStateFeedMode
            // 
            this.cbxStateFeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStateFeedMode.FormattingEnabled = true;
            this.cbxStateFeedMode.Items.AddRange(new object[] {
            "",
            "Unit/Min                  G94",
            "Inverse Time            G93"});
            this.cbxStateFeedMode.Location = new System.Drawing.Point(3, 39);
            this.cbxStateFeedMode.Name = "cbxStateFeedMode";
            this.cbxStateFeedMode.Size = new System.Drawing.Size(74, 21);
            this.cbxStateFeedMode.TabIndex = 29;
            // 
            // cbxStateDistance
            // 
            this.cbxStateDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStateDistance.FormattingEnabled = true;
            this.cbxStateDistance.Items.AddRange(new object[] {
            "",
            "Absolute                                                    G90",
            "Incremental                                               G91"});
            this.cbxStateDistance.Location = new System.Drawing.Point(3, 16);
            this.cbxStateDistance.Name = "cbxStateDistance";
            this.cbxStateDistance.Size = new System.Drawing.Size(74, 21);
            this.cbxStateDistance.TabIndex = 20;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label16.Location = new System.Drawing.Point(83, 65);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(31, 13);
            this.Label16.TabIndex = 19;
            this.Label16.Text = "Units";
            // 
            // cbxStateUnits
            // 
            this.cbxStateUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStateUnits.FormattingEnabled = true;
            this.cbxStateUnits.Items.AddRange(new object[] {
            "",
            "Metric                                    G21",
            "Inch                                        G20"});
            this.cbxStateUnits.Location = new System.Drawing.Point(3, 62);
            this.cbxStateUnits.Name = "cbxStateUnits";
            this.cbxStateUnits.Size = new System.Drawing.Size(74, 21);
            this.cbxStateUnits.TabIndex = 21;
            // 
            // Label123
            // 
            this.Label123.AutoSize = true;
            this.Label123.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label123.Location = new System.Drawing.Point(83, 19);
            this.Label123.Name = "Label123";
            this.Label123.Size = new System.Drawing.Size(79, 13);
            this.Label123.TabIndex = 0;
            this.Label123.Text = "Distance Mode";
            // 
            // Lalbel49
            // 
            this.Lalbel49.AutoSize = true;
            this.Lalbel49.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lalbel49.Location = new System.Drawing.Point(83, 157);
            this.Lalbel49.Name = "Lalbel49";
            this.Lalbel49.Size = new System.Drawing.Size(67, 13);
            this.Lalbel49.TabIndex = 10;
            this.Lalbel49.Text = "Active Plane";
            // 
            // cbxStatePlane
            // 
            this.cbxStatePlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatePlane.FormattingEnabled = true;
            this.cbxStatePlane.Items.AddRange(new object[] {
            "",
            "XY                                G17",
            "YZ                                G18",
            "XZ                                G19"});
            this.cbxStatePlane.Location = new System.Drawing.Point(3, 154);
            this.cbxStatePlane.Name = "cbxStatePlane";
            this.cbxStatePlane.Size = new System.Drawing.Size(74, 21);
            this.cbxStatePlane.TabIndex = 26;
            // 
            // Label47
            // 
            this.Label47.AutoSize = true;
            this.Label47.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label47.Location = new System.Drawing.Point(83, 134);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(43, 13);
            this.Label47.TabIndex = 8;
            this.Label47.Text = "Coolant";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label15.Location = new System.Drawing.Point(83, 88);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(64, 13);
            this.Label15.TabIndex = 2;
            this.Label15.Text = "Work Offset";
            // 
            // cbxStateOffset
            // 
            this.cbxStateOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStateOffset.FormattingEnabled = true;
            this.cbxStateOffset.Items.AddRange(new object[] {
            "",
            "G54                                   G54",
            "G55                                   G55",
            "G56                                   G56",
            "G57                                   G57",
            "G58                                   G58",
            "G59                                   G59"});
            this.cbxStateOffset.Location = new System.Drawing.Point(3, 85);
            this.cbxStateOffset.Name = "cbxStateOffset";
            this.cbxStateOffset.Size = new System.Drawing.Size(74, 21);
            this.cbxStateOffset.TabIndex = 23;
            // 
            // cbxStateCoolant
            // 
            this.cbxStateCoolant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStateCoolant.FormattingEnabled = true;
            this.cbxStateCoolant.Items.AddRange(new object[] {
            "",
            "On                                       M8",
            "Off                                       M9"});
            this.cbxStateCoolant.Location = new System.Drawing.Point(3, 131);
            this.cbxStateCoolant.Name = "cbxStateCoolant";
            this.cbxStateCoolant.Size = new System.Drawing.Size(74, 21);
            this.cbxStateCoolant.TabIndex = 25;
            // 
            // Label45
            // 
            this.Label45.AutoSize = true;
            this.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label45.Location = new System.Drawing.Point(84, 111);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(42, 13);
            this.Label45.TabIndex = 6;
            this.Label45.Text = "Spindle";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label17.Location = new System.Drawing.Point(83, 42);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(84, 13);
            this.Label17.TabIndex = 4;
            this.Label17.Text = "FeedRate Mode";
            // 
            // cbxStateSpindle
            // 
            this.cbxStateSpindle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStateSpindle.FormattingEnabled = true;
            this.cbxStateSpindle.Items.AddRange(new object[] {
            "",
            "CW                                       M3",
            "CCW                                    M4",
            "Off                                       M5"});
            this.cbxStateSpindle.Location = new System.Drawing.Point(3, 108);
            this.cbxStateSpindle.Name = "cbxStateSpindle";
            this.cbxStateSpindle.Size = new System.Drawing.Size(74, 21);
            this.cbxStateSpindle.TabIndex = 24;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnCheckMode);
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.btnHold);
            this.gbControl.Controls.Add(this.btnStartResume);
            this.gbControl.Controls.Add(this.btnUnlock);
            this.gbControl.Location = new System.Drawing.Point(532, 409);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(400, 59);
            this.gbControl.TabIndex = 35;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnCheckMode
            // 
            this.btnCheckMode.AutoSize = true;
            this.btnCheckMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCheckMode.Location = new System.Drawing.Point(322, 19);
            this.btnCheckMode.Name = "btnCheckMode";
            this.btnCheckMode.Size = new System.Drawing.Size(72, 31);
            this.btnCheckMode.TabIndex = 17;
            this.btnCheckMode.Text = "Check";
            this.btnCheckMode.UseCompatibleTextRendering = true;
            this.btnCheckMode.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(85, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 31);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseCompatibleTextRendering = true;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHold
            // 
            this.btnHold.AutoSize = true;
            this.btnHold.BackColor = System.Drawing.Color.Transparent;
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHold.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHold.Location = new System.Drawing.Point(164, 19);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(72, 31);
            this.btnHold.TabIndex = 3;
            this.btnHold.Text = "Hold";
            this.btnHold.UseCompatibleTextRendering = true;
            this.btnHold.UseVisualStyleBackColor = false;
            // 
            // btnStartResume
            // 
            this.btnStartResume.AutoSize = true;
            this.btnStartResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartResume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStartResume.Location = new System.Drawing.Point(243, 19);
            this.btnStartResume.Name = "btnStartResume";
            this.btnStartResume.Size = new System.Drawing.Size(72, 31);
            this.btnStartResume.TabIndex = 2;
            this.btnStartResume.Text = "Start";
            this.btnStartResume.UseCompatibleTextRendering = true;
            this.btnStartResume.UseVisualStyleBackColor = true;
            // 
            // btnUnlock
            // 
            this.btnUnlock.AutoSize = true;
            this.btnUnlock.BackColor = System.Drawing.Color.Transparent;
            this.btnUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUnlock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUnlock.Location = new System.Drawing.Point(6, 19);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(72, 31);
            this.btnUnlock.TabIndex = 16;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnlock.UseCompatibleTextRendering = true;
            this.btnUnlock.UseVisualStyleBackColor = false;
            // 
            // cbStartResume
            // 
            this.cbStartResume.AutoCheck = false;
            this.cbStartResume.AutoSize = true;
            this.cbStartResume.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbStartResume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbStartResume.Location = new System.Drawing.Point(147, 16);
            this.cbStartResume.Name = "cbStartResume";
            this.cbStartResume.Size = new System.Drawing.Size(25, 31);
            this.cbStartResume.TabIndex = 45;
            this.cbStartResume.Text = "CS";
            this.ToolTip1.SetToolTip(this.cbStartResume, "Cycle Start");
            this.cbStartResume.UseVisualStyleBackColor = true;
            this.cbStartResume.Visible = false;
            // 
            // cbResetAbort
            // 
            this.cbResetAbort.AutoCheck = false;
            this.cbResetAbort.AutoSize = true;
            this.cbResetAbort.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbResetAbort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbResetAbort.Location = new System.Drawing.Point(106, 16);
            this.cbResetAbort.Name = "cbResetAbort";
            this.cbResetAbort.Size = new System.Drawing.Size(19, 31);
            this.cbResetAbort.TabIndex = 43;
            this.cbResetAbort.Text = "R";
            this.ToolTip1.SetToolTip(this.cbResetAbort, "Reset");
            this.cbResetAbort.UseVisualStyleBackColor = true;
            this.cbResetAbort.Visible = false;
            // 
            // gbPinStatus
            // 
            this.gbPinStatus.Controls.Add(this.cbFeedHold);
            this.gbPinStatus.Controls.Add(this.cbStartResume);
            this.gbPinStatus.Controls.Add(this.cbResetAbort);
            this.gbPinStatus.Controls.Add(this.btnStatusClearPins);
            this.gbPinStatus.Controls.Add(this.cbLimitX);
            this.gbPinStatus.Controls.Add(this.cbDoorOpen);
            this.gbPinStatus.Controls.Add(this.cbProbePin);
            this.gbPinStatus.Controls.Add(this.cbLimitZ);
            this.gbPinStatus.Controls.Add(this.cbLimitY);
            this.gbPinStatus.Location = new System.Drawing.Point(12, 328);
            this.gbPinStatus.Name = "gbPinStatus";
            this.gbPinStatus.Size = new System.Drawing.Size(169, 69);
            this.gbPinStatus.TabIndex = 46;
            this.gbPinStatus.TabStop = false;
            this.gbPinStatus.Text = "Pins";
            this.gbPinStatus.Visible = false;
            // 
            // btnStatusClearPins
            // 
            this.btnStatusClearPins.AutoSize = true;
            this.btnStatusClearPins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStatusClearPins.Location = new System.Drawing.Point(7, 46);
            this.btnStatusClearPins.Name = "btnStatusClearPins";
            this.btnStatusClearPins.Size = new System.Drawing.Size(64, 23);
            this.btnStatusClearPins.TabIndex = 36;
            this.btnStatusClearPins.Text = "Clear Pins";
            this.btnStatusClearPins.UseVisualStyleBackColor = true;
            // 
            // cbLimitX
            // 
            this.cbLimitX.AutoCheck = false;
            this.cbLimitX.AutoSize = true;
            this.cbLimitX.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLimitX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbLimitX.Location = new System.Drawing.Point(6, 16);
            this.cbLimitX.Name = "cbLimitX";
            this.cbLimitX.Size = new System.Drawing.Size(18, 31);
            this.cbLimitX.TabIndex = 39;
            this.cbLimitX.Text = "X";
            this.ToolTip1.SetToolTip(this.cbLimitX, "X Limit");
            this.cbLimitX.UseVisualStyleBackColor = true;
            this.cbLimitX.Visible = false;
            // 
            // cbDoorOpen
            // 
            this.cbDoorOpen.AutoCheck = false;
            this.cbDoorOpen.AutoSize = true;
            this.cbDoorOpen.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbDoorOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDoorOpen.Location = new System.Drawing.Point(86, 16);
            this.cbDoorOpen.Name = "cbDoorOpen";
            this.cbDoorOpen.Size = new System.Drawing.Size(19, 31);
            this.cbDoorOpen.TabIndex = 42;
            this.cbDoorOpen.Text = "D";
            this.ToolTip1.SetToolTip(this.cbDoorOpen, "Door Open");
            this.cbDoorOpen.UseVisualStyleBackColor = true;
            this.cbDoorOpen.Visible = false;
            // 
            // cbProbePin
            // 
            this.cbProbePin.AutoCheck = false;
            this.cbProbePin.AutoSize = true;
            this.cbProbePin.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbProbePin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbProbePin.Location = new System.Drawing.Point(68, 16);
            this.cbProbePin.Name = "cbProbePin";
            this.cbProbePin.Size = new System.Drawing.Size(18, 31);
            this.cbProbePin.TabIndex = 42;
            this.cbProbePin.Text = "P";
            this.ToolTip1.SetToolTip(this.cbProbePin, "Probe Pin");
            this.cbProbePin.UseVisualStyleBackColor = true;
            this.cbProbePin.Visible = false;
            // 
            // cbLimitZ
            // 
            this.cbLimitZ.AutoCheck = false;
            this.cbLimitZ.AutoSize = true;
            this.cbLimitZ.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLimitZ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbLimitZ.Location = new System.Drawing.Point(39, 16);
            this.cbLimitZ.Name = "cbLimitZ";
            this.cbLimitZ.Size = new System.Drawing.Size(18, 31);
            this.cbLimitZ.TabIndex = 41;
            this.cbLimitZ.Text = "Z";
            this.ToolTip1.SetToolTip(this.cbLimitZ, "Z Limit");
            this.cbLimitZ.UseVisualStyleBackColor = true;
            this.cbLimitZ.Visible = false;
            // 
            // cbLimitY
            // 
            this.cbLimitY.AutoCheck = false;
            this.cbLimitY.AutoSize = true;
            this.cbLimitY.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLimitY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbLimitY.Location = new System.Drawing.Point(22, 16);
            this.cbLimitY.Name = "cbLimitY";
            this.cbLimitY.Size = new System.Drawing.Size(18, 31);
            this.cbLimitY.TabIndex = 40;
            this.cbLimitY.Text = "Y";
            this.ToolTip1.SetToolTip(this.cbLimitY, "Y Limit");
            this.cbLimitY.UseVisualStyleBackColor = true;
            this.cbLimitY.Visible = false;
            // 
            // btnMistOverride
            // 
            this.btnMistOverride.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMistOverride.Location = new System.Drawing.Point(123, 20);
            this.btnMistOverride.Name = "btnMistOverride";
            this.btnMistOverride.Size = new System.Drawing.Size(51, 23);
            this.btnMistOverride.TabIndex = 29;
            this.btnMistOverride.TabStop = false;
            this.btnMistOverride.Tag = "MistOverride";
            this.btnMistOverride.Text = "Mist";
            this.btnMistOverride.UseVisualStyleBackColor = true;
            // 
            // btnFloodOverride
            // 
            this.btnFloodOverride.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFloodOverride.Location = new System.Drawing.Point(70, 20);
            this.btnFloodOverride.Name = "btnFloodOverride";
            this.btnFloodOverride.Size = new System.Drawing.Size(51, 23);
            this.btnFloodOverride.TabIndex = 28;
            this.btnFloodOverride.Tag = "FloodOverride";
            this.btnFloodOverride.Text = "Flood";
            this.btnFloodOverride.UseVisualStyleBackColor = true;
            // 
            // btnSpindleOverride
            // 
            this.btnSpindleOverride.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpindleOverride.Location = new System.Drawing.Point(17, 20);
            this.btnSpindleOverride.Name = "btnSpindleOverride";
            this.btnSpindleOverride.Size = new System.Drawing.Size(51, 23);
            this.btnSpindleOverride.TabIndex = 27;
            this.btnSpindleOverride.Tag = "SpindleOverride";
            this.btnSpindleOverride.Text = "Spindle";
            this.btnSpindleOverride.UseVisualStyleBackColor = true;
            // 
            // cbSpindleCoarse
            // 
            this.cbSpindleCoarse.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSpindleCoarse.AutoSize = true;
            this.cbSpindleCoarse.Checked = true;
            this.cbSpindleCoarse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpindleCoarse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSpindleCoarse.Location = new System.Drawing.Point(130, 198);
            this.cbSpindleCoarse.Name = "cbSpindleCoarse";
            this.cbSpindleCoarse.Size = new System.Drawing.Size(50, 23);
            this.cbSpindleCoarse.TabIndex = 26;
            this.cbSpindleCoarse.Text = "Coarse";
            this.cbSpindleCoarse.UseVisualStyleBackColor = true;
            // 
            // btnSpindleOverrideReset
            // 
            this.btnSpindleOverrideReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpindleOverrideReset.Location = new System.Drawing.Point(130, 222);
            this.btnSpindleOverrideReset.Name = "btnSpindleOverrideReset";
            this.btnSpindleOverrideReset.Size = new System.Drawing.Size(49, 23);
            this.btnSpindleOverrideReset.TabIndex = 25;
            this.btnSpindleOverrideReset.Tag = "Spindle";
            this.btnSpindleOverrideReset.Text = "Reset";
            this.btnSpindleOverrideReset.UseVisualStyleBackColor = true;
            // 
            // btnRapidOverride25
            // 
            this.btnRapidOverride25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRapidOverride25.Location = new System.Drawing.Point(87, 151);
            this.btnRapidOverride25.Name = "btnRapidOverride25";
            this.btnRapidOverride25.Size = new System.Drawing.Size(35, 35);
            this.btnRapidOverride25.TabIndex = 24;
            this.btnRapidOverride25.Tag = "25";
            this.btnRapidOverride25.Text = "25%";
            this.btnRapidOverride25.UseVisualStyleBackColor = true;
            // 
            // gbOverrides
            // 
            this.gbOverrides.Controls.Add(this.btnMistOverride);
            this.gbOverrides.Controls.Add(this.btnFloodOverride);
            this.gbOverrides.Controls.Add(this.btnSpindleOverride);
            this.gbOverrides.Controls.Add(this.cbSpindleCoarse);
            this.gbOverrides.Controls.Add(this.btnSpindleOverrideReset);
            this.gbOverrides.Controls.Add(this.btnRapidOverride25);
            this.gbOverrides.Controls.Add(this.btnFeedOverrideReset);
            this.gbOverrides.Controls.Add(this.cbFeedCoarse);
            this.gbOverrides.Controls.Add(this.Label44);
            this.gbOverrides.Controls.Add(this.btnSpindleMinus);
            this.gbOverrides.Controls.Add(this.btnSpindlePlus);
            this.gbOverrides.Controls.Add(this.Label22);
            this.gbOverrides.Controls.Add(this.btnRapidOverride50);
            this.gbOverrides.Controls.Add(this.btnRapidOverrideReset);
            this.gbOverrides.Controls.Add(this.tbSpindleOvr);
            this.gbOverrides.Controls.Add(this.tbRapidOvr);
            this.gbOverrides.Controls.Add(this.tbFeedOvr);
            this.gbOverrides.Controls.Add(this.Label46);
            this.gbOverrides.Controls.Add(this.btnFeedMinus);
            this.gbOverrides.Controls.Add(this.btnFeedPlus);
            this.gbOverrides.Location = new System.Drawing.Point(939, 412);
            this.gbOverrides.Name = "gbOverrides";
            this.gbOverrides.Size = new System.Drawing.Size(190, 262);
            this.gbOverrides.TabIndex = 37;
            this.gbOverrides.TabStop = false;
            this.gbOverrides.Text = "Overrides";
            this.gbOverrides.Visible = false;
            // 
            // btnFeedOverrideReset
            // 
            this.btnFeedOverrideReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFeedOverrideReset.Location = new System.Drawing.Point(127, 82);
            this.btnFeedOverrideReset.Name = "btnFeedOverrideReset";
            this.btnFeedOverrideReset.Size = new System.Drawing.Size(49, 23);
            this.btnFeedOverrideReset.TabIndex = 23;
            this.btnFeedOverrideReset.Tag = "Feed";
            this.btnFeedOverrideReset.Text = "Reset";
            this.btnFeedOverrideReset.UseVisualStyleBackColor = true;
            // 
            // cbFeedCoarse
            // 
            this.cbFeedCoarse.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFeedCoarse.AutoSize = true;
            this.cbFeedCoarse.Checked = true;
            this.cbFeedCoarse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFeedCoarse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFeedCoarse.Location = new System.Drawing.Point(128, 59);
            this.cbFeedCoarse.Name = "cbFeedCoarse";
            this.cbFeedCoarse.Size = new System.Drawing.Size(50, 23);
            this.cbFeedCoarse.TabIndex = 22;
            this.cbFeedCoarse.Text = "Coarse";
            this.cbFeedCoarse.UseVisualStyleBackColor = true;
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label44.Location = new System.Drawing.Point(6, 213);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(42, 13);
            this.Label44.TabIndex = 21;
            this.Label44.Text = "Spindle";
            // 
            // btnSpindleMinus
            // 
            this.btnSpindleMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnSpindleMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpindleMinus.Location = new System.Drawing.Point(87, 222);
            this.btnSpindleMinus.Name = "btnSpindleMinus";
            this.btnSpindleMinus.Size = new System.Drawing.Size(35, 35);
            this.btnSpindleMinus.TabIndex = 20;
            this.btnSpindleMinus.Tag = "minus";
            this.btnSpindleMinus.Text = "-";
            this.btnSpindleMinus.UseVisualStyleBackColor = true;
            // 
            // btnSpindlePlus
            // 
            this.btnSpindlePlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnSpindlePlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSpindlePlus.Location = new System.Drawing.Point(87, 184);
            this.btnSpindlePlus.Name = "btnSpindlePlus";
            this.btnSpindlePlus.Size = new System.Drawing.Size(35, 42);
            this.btnSpindlePlus.TabIndex = 19;
            this.btnSpindlePlus.Tag = "plus";
            this.btnSpindlePlus.Text = "+";
            this.btnSpindlePlus.UseVisualStyleBackColor = true;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label22.Location = new System.Drawing.Point(5, 144);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(35, 13);
            this.Label22.TabIndex = 15;
            this.Label22.Text = "Rapid";
            // 
            // btnRapidOverride50
            // 
            this.btnRapidOverride50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRapidOverride50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRapidOverride50.Location = new System.Drawing.Point(87, 118);
            this.btnRapidOverride50.Name = "btnRapidOverride50";
            this.btnRapidOverride50.Size = new System.Drawing.Size(35, 35);
            this.btnRapidOverride50.TabIndex = 14;
            this.btnRapidOverride50.Tag = "50";
            this.btnRapidOverride50.Text = "50%";
            this.btnRapidOverride50.UseVisualStyleBackColor = true;
            // 
            // btnRapidOverrideReset
            // 
            this.btnRapidOverrideReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRapidOverrideReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRapidOverrideReset.Location = new System.Drawing.Point(129, 144);
            this.btnRapidOverrideReset.Name = "btnRapidOverrideReset";
            this.btnRapidOverrideReset.Size = new System.Drawing.Size(49, 23);
            this.btnRapidOverrideReset.TabIndex = 13;
            this.btnRapidOverrideReset.Tag = "Rapid";
            this.btnRapidOverrideReset.Text = "Reset";
            this.btnRapidOverrideReset.UseVisualStyleBackColor = true;
            // 
            // tbSpindleOvr
            // 
            this.tbSpindleOvr.Enabled = false;
            this.tbSpindleOvr.Location = new System.Drawing.Point(51, 210);
            this.tbSpindleOvr.Name = "tbSpindleOvr";
            this.tbSpindleOvr.Size = new System.Drawing.Size(30, 20);
            this.tbSpindleOvr.TabIndex = 10;
            this.tbSpindleOvr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRapidOvr
            // 
            this.tbRapidOvr.Enabled = false;
            this.tbRapidOvr.Location = new System.Drawing.Point(52, 144);
            this.tbRapidOvr.Name = "tbRapidOvr";
            this.tbRapidOvr.Size = new System.Drawing.Size(30, 20);
            this.tbRapidOvr.TabIndex = 9;
            this.tbRapidOvr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFeedOvr
            // 
            this.tbFeedOvr.Enabled = false;
            this.tbFeedOvr.Location = new System.Drawing.Point(51, 70);
            this.tbFeedOvr.Name = "tbFeedOvr";
            this.tbFeedOvr.Size = new System.Drawing.Size(30, 20);
            this.tbFeedOvr.TabIndex = 8;
            this.tbFeedOvr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label46.Location = new System.Drawing.Point(5, 73);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(31, 13);
            this.Label46.TabIndex = 6;
            this.Label46.Text = "Feed";
            // 
            // btnFeedMinus
            // 
            this.btnFeedMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnFeedMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFeedMinus.Location = new System.Drawing.Point(87, 82);
            this.btnFeedMinus.Name = "btnFeedMinus";
            this.btnFeedMinus.Size = new System.Drawing.Size(35, 35);
            this.btnFeedMinus.TabIndex = 1;
            this.btnFeedMinus.Tag = "minus";
            this.btnFeedMinus.Text = "-";
            this.btnFeedMinus.UseVisualStyleBackColor = true;
            // 
            // btnFeedPlus
            // 
            this.btnFeedPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnFeedPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFeedPlus.Location = new System.Drawing.Point(87, 48);
            this.btnFeedPlus.Name = "btnFeedPlus";
            this.btnFeedPlus.Size = new System.Drawing.Size(35, 35);
            this.btnFeedPlus.TabIndex = 0;
            this.btnFeedPlus.Tag = "plus";
            this.btnFeedPlus.Text = "+";
            this.btnFeedPlus.UseVisualStyleBackColor = true;
            // 
            // tabPgInterface
            // 
            this.tabPgInterface.Controls.Add(this.gbOverrides);
            this.tabPgInterface.Controls.Add(this.gbState);
            this.tabPgInterface.Controls.Add(this.gbControl);
            this.tabPgInterface.Controls.Add(this.gbMDI);
            this.tabPgInterface.Controls.Add(this.gbJogging);
            this.tabPgInterface.Controls.Add(this.gbStatus);
            this.tabPgInterface.Controls.Add(this.gbGcode);
            this.tabPgInterface.Controls.Add(this.gbGrbl);
            this.tabPgInterface.Controls.Add(this.gbPosition);
            this.tabPgInterface.Location = new System.Drawing.Point(4, 22);
            this.tabPgInterface.Name = "tabPgInterface";
            this.tabPgInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgInterface.Size = new System.Drawing.Size(997, 746);
            this.tabPgInterface.TabIndex = 0;
            this.tabPgInterface.Text = "Interface";
            this.tabPgInterface.UseVisualStyleBackColor = true;
            // 
            // gbState
            // 
            this.gbState.Controls.Add(this.gbPinStatus);
            this.gbState.Controls.Add(this.Panel2);
            this.gbState.Controls.Add(this.Panel1);
            this.gbState.Location = new System.Drawing.Point(938, 3);
            this.gbState.Name = "gbState";
            this.gbState.Size = new System.Drawing.Size(191, 403);
            this.gbState.TabIndex = 36;
            this.gbState.TabStop = false;
            this.gbState.Text = "State";
            // 
            // gbJogging
            // 
            this.gbJogging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbJogging.Controls.Add(this.btnZMinus);
            this.gbJogging.Controls.Add(this.btnZPlus);
            this.gbJogging.Controls.Add(this.btnXPlus);
            this.gbJogging.Controls.Add(this.btnYMinus);
            this.gbJogging.Controls.Add(this.btnXMinus);
            this.gbJogging.Controls.Add(this.btnYPlus);
            this.gbJogging.Controls.Add(this.gbFeedRate);
            this.gbJogging.Controls.Add(this.gbDistance);
            this.gbJogging.Controls.Add(this.cbUnits);
            this.gbJogging.Enabled = false;
            this.gbJogging.Location = new System.Drawing.Point(3, 95);
            this.gbJogging.Name = "gbJogging";
            this.gbJogging.Size = new System.Drawing.Size(377, 216);
            this.gbJogging.TabIndex = 0;
            this.gbJogging.TabStop = false;
            this.gbJogging.Text = "Jogging";
            // 
            // btnZMinus
            // 
            this.btnZMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnZMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZMinus.Interval = 100;
            this.btnZMinus.Location = new System.Drawing.Point(399, 145);
            this.btnZMinus.Name = "btnZMinus";
            this.btnZMinus.Size = new System.Drawing.Size(80, 58);
            this.btnZMinus.TabIndex = 23;
            this.btnZMinus.Tag = "Z-";
            this.btnZMinus.Text = "Z-";
            this.btnZMinus.UseVisualStyleBackColor = true;
            // 
            // btnZPlus
            // 
            this.btnZPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnZPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZPlus.Interval = 100;
            this.btnZPlus.Location = new System.Drawing.Point(399, 18);
            this.btnZPlus.Name = "btnZPlus";
            this.btnZPlus.Size = new System.Drawing.Size(80, 58);
            this.btnZPlus.TabIndex = 22;
            this.btnZPlus.Tag = "Z+";
            this.btnZPlus.Text = "Z+";
            this.btnZPlus.UseVisualStyleBackColor = true;
            // 
            // btnXPlus
            // 
            this.btnXPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnXPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXPlus.Interval = 100;
            this.btnXPlus.Location = new System.Drawing.Point(299, 81);
            this.btnXPlus.Name = "btnXPlus";
            this.btnXPlus.Size = new System.Drawing.Size(80, 58);
            this.btnXPlus.TabIndex = 21;
            this.btnXPlus.Tag = "X+";
            this.btnXPlus.Text = "X+";
            this.btnXPlus.UseVisualStyleBackColor = true;
            // 
            // btnYMinus
            // 
            this.btnYMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnYMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnYMinus.Interval = 100;
            this.btnYMinus.Location = new System.Drawing.Point(233, 144);
            this.btnYMinus.Name = "btnYMinus";
            this.btnYMinus.Size = new System.Drawing.Size(80, 58);
            this.btnYMinus.TabIndex = 20;
            this.btnYMinus.Tag = "Y-";
            this.btnYMinus.Text = "Y-";
            this.btnYMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYMinus.UseVisualStyleBackColor = true;
            // 
            // btnXMinus
            // 
            this.btnXMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnXMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXMinus.Interval = 100;
            this.btnXMinus.Location = new System.Drawing.Point(185, 81);
            this.btnXMinus.Name = "btnXMinus";
            this.btnXMinus.Size = new System.Drawing.Size(80, 58);
            this.btnXMinus.TabIndex = 19;
            this.btnXMinus.Tag = "X-";
            this.btnXMinus.Text = "X-";
            this.btnXMinus.UseVisualStyleBackColor = true;
            // 
            // btnYPlus
            // 
            this.btnYPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnYPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnYPlus.Interval = 100;
            this.btnYPlus.Location = new System.Drawing.Point(233, 18);
            this.btnYPlus.Name = "btnYPlus";
            this.btnYPlus.Size = new System.Drawing.Size(80, 58);
            this.btnYPlus.TabIndex = 18;
            this.btnYPlus.Tag = "Y+";
            this.btnYPlus.Text = "Y+";
            this.btnYPlus.UseVisualStyleBackColor = true;
            // 
            // gbFeedRate
            // 
            this.gbFeedRate.Controls.Add(this.rbFeedRate1);
            this.gbFeedRate.Controls.Add(this.rbFeedRate2);
            this.gbFeedRate.Controls.Add(this.rbFeedRate3);
            this.gbFeedRate.Controls.Add(this.rbFeedRate4);
            this.gbFeedRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbFeedRate.Location = new System.Drawing.Point(12, 117);
            this.gbFeedRate.Name = "gbFeedRate";
            this.gbFeedRate.Size = new System.Drawing.Size(105, 92);
            this.gbFeedRate.TabIndex = 16;
            this.gbFeedRate.TabStop = false;
            this.gbFeedRate.Text = "Feed Rate";
            // 
            // rbFeedRate1
            // 
            this.rbFeedRate1.AutoSize = true;
            this.rbFeedRate1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbFeedRate1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbFeedRate1.Location = new System.Drawing.Point(6, 19);
            this.rbFeedRate1.Name = "rbFeedRate1";
            this.rbFeedRate1.Size = new System.Drawing.Size(14, 13);
            this.rbFeedRate1.TabIndex = 11;
            this.rbFeedRate1.TabStop = true;
            this.rbFeedRate1.Tag = "F1";
            this.rbFeedRate1.UseVisualStyleBackColor = true;
            // 
            // rbFeedRate2
            // 
            this.rbFeedRate2.AutoSize = true;
            this.rbFeedRate2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbFeedRate2.Location = new System.Drawing.Point(6, 35);
            this.rbFeedRate2.Name = "rbFeedRate2";
            this.rbFeedRate2.Size = new System.Drawing.Size(14, 13);
            this.rbFeedRate2.TabIndex = 10;
            this.rbFeedRate2.TabStop = true;
            this.rbFeedRate2.Tag = "F2";
            this.rbFeedRate2.UseVisualStyleBackColor = true;
            // 
            // rbFeedRate3
            // 
            this.rbFeedRate3.AutoSize = true;
            this.rbFeedRate3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbFeedRate3.Location = new System.Drawing.Point(6, 53);
            this.rbFeedRate3.Name = "rbFeedRate3";
            this.rbFeedRate3.Size = new System.Drawing.Size(14, 13);
            this.rbFeedRate3.TabIndex = 12;
            this.rbFeedRate3.TabStop = true;
            this.rbFeedRate3.Tag = "F3";
            this.rbFeedRate3.UseVisualStyleBackColor = true;
            // 
            // rbFeedRate4
            // 
            this.rbFeedRate4.AutoSize = true;
            this.rbFeedRate4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbFeedRate4.Location = new System.Drawing.Point(6, 72);
            this.rbFeedRate4.Name = "rbFeedRate4";
            this.rbFeedRate4.Size = new System.Drawing.Size(14, 13);
            this.rbFeedRate4.TabIndex = 13;
            this.rbFeedRate4.TabStop = true;
            this.rbFeedRate4.Tag = "F4";
            this.rbFeedRate4.UseVisualStyleBackColor = true;
            // 
            // gbDistance
            // 
            this.gbDistance.Controls.Add(this.rbDistance1);
            this.gbDistance.Controls.Add(this.rbDistance2);
            this.gbDistance.Controls.Add(this.rbDistance3);
            this.gbDistance.Controls.Add(this.rbDistance4);
            this.gbDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbDistance.Location = new System.Drawing.Point(10, 19);
            this.gbDistance.Name = "gbDistance";
            this.gbDistance.Size = new System.Drawing.Size(107, 92);
            this.gbDistance.TabIndex = 17;
            this.gbDistance.TabStop = false;
            this.gbDistance.Text = "Distance";
            // 
            // rbDistance1
            // 
            this.rbDistance1.AutoSize = true;
            this.rbDistance1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDistance1.Location = new System.Drawing.Point(6, 16);
            this.rbDistance1.Name = "rbDistance1";
            this.rbDistance1.Size = new System.Drawing.Size(14, 13);
            this.rbDistance1.TabIndex = 6;
            this.rbDistance1.TabStop = true;
            this.rbDistance1.Tag = "I1";
            this.rbDistance1.UseVisualStyleBackColor = true;
            // 
            // rbDistance2
            // 
            this.rbDistance2.AutoSize = true;
            this.rbDistance2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDistance2.Location = new System.Drawing.Point(6, 35);
            this.rbDistance2.Name = "rbDistance2";
            this.rbDistance2.Size = new System.Drawing.Size(14, 13);
            this.rbDistance2.TabIndex = 7;
            this.rbDistance2.TabStop = true;
            this.rbDistance2.Tag = "I2";
            this.rbDistance2.UseVisualStyleBackColor = true;
            // 
            // rbDistance3
            // 
            this.rbDistance3.AutoSize = true;
            this.rbDistance3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDistance3.Location = new System.Drawing.Point(6, 54);
            this.rbDistance3.Name = "rbDistance3";
            this.rbDistance3.Size = new System.Drawing.Size(14, 13);
            this.rbDistance3.TabIndex = 8;
            this.rbDistance3.TabStop = true;
            this.rbDistance3.Tag = "I3";
            this.rbDistance3.UseVisualStyleBackColor = true;
            // 
            // rbDistance4
            // 
            this.rbDistance4.AutoSize = true;
            this.rbDistance4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDistance4.Location = new System.Drawing.Point(6, 73);
            this.rbDistance4.Name = "rbDistance4";
            this.rbDistance4.Size = new System.Drawing.Size(14, 13);
            this.rbDistance4.TabIndex = 9;
            this.rbDistance4.TabStop = true;
            this.rbDistance4.Tag = "I4";
            this.rbDistance4.UseVisualStyleBackColor = true;
            // 
            // cbUnits
            // 
            this.cbUnits.AutoSize = true;
            this.cbUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbUnits.Location = new System.Drawing.Point(133, 192);
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.Size = new System.Drawing.Size(73, 17);
            this.cbUnits.TabIndex = 16;
            this.cbUnits.Text = "Metric      ";
            this.cbUnits.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbStatus.Controls.Add(this.Label25);
            this.gbStatus.Controls.Add(this.tbCurrentStatus);
            this.gbStatus.Controls.Add(this.Label24);
            this.gbStatus.Controls.Add(this.prgbRxBuf);
            this.gbStatus.Controls.Add(this.prgBarQ);
            this.gbStatus.Controls.Add(this.cbVerbose);
            this.gbStatus.Controls.Add(this.lbResponses);
            this.gbStatus.Enabled = false;
            this.gbStatus.Location = new System.Drawing.Point(532, 470);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(400, 273);
            this.gbStatus.TabIndex = 1;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label25.Location = new System.Drawing.Point(217, 21);
            this.Label25.Margin = new System.Windows.Forms.Padding(0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(18, 13);
            this.Label25.TabIndex = 23;
            this.Label25.Text = "Q:";
            // 
            // tbCurrentStatus
            // 
            this.tbCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbCurrentStatus.Location = new System.Drawing.Point(6, 15);
            this.tbCurrentStatus.Name = "tbCurrentStatus";
            this.tbCurrentStatus.Size = new System.Drawing.Size(113, 26);
            this.tbCurrentStatus.TabIndex = 34;
            this.tbCurrentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.tbCurrentStatus, "Shows status of Grbl");
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label24.Location = new System.Drawing.Point(304, 21);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(25, 13);
            this.Label24.TabIndex = 22;
            this.Label24.Text = "RX:";
            // 
            // prgbRxBuf
            // 
            this.prgbRxBuf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prgbRxBuf.Location = new System.Drawing.Point(334, 20);
            this.prgbRxBuf.Maximum = 127;
            this.prgbRxBuf.Name = "prgbRxBuf";
            this.prgbRxBuf.Size = new System.Drawing.Size(60, 15);
            this.prgbRxBuf.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbRxBuf.TabIndex = 21;
            // 
            // prgBarQ
            // 
            this.prgBarQ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prgBarQ.Location = new System.Drawing.Point(238, 20);
            this.prgBarQ.Maximum = 25;
            this.prgBarQ.Name = "prgBarQ";
            this.prgBarQ.Size = new System.Drawing.Size(60, 15);
            this.prgBarQ.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBarQ.TabIndex = 20;
            // 
            // cbVerbose
            // 
            this.cbVerbose.AutoSize = true;
            this.cbVerbose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVerbose.Location = new System.Drawing.Point(125, 20);
            this.cbVerbose.Name = "cbVerbose";
            this.cbVerbose.Size = new System.Drawing.Size(83, 17);
            this.cbVerbose.TabIndex = 15;
            this.cbVerbose.Text = "Verbose      ";
            this.cbVerbose.UseVisualStyleBackColor = true;
            // 
            // lbResponses
            // 
            this.lbResponses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResponses.FormattingEnabled = true;
            this.lbResponses.HorizontalScrollbar = true;
            this.lbResponses.Location = new System.Drawing.Point(6, 50);
            this.lbResponses.Name = "lbResponses";
            this.lbResponses.Size = new System.Drawing.Size(388, 212);
            this.lbResponses.TabIndex = 0;
            // 
            // gbGcode
            // 
            this.gbGcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGcode.Controls.Add(this.btnFileStep);
            this.gbGcode.Controls.Add(this.cbMonitorEnable);
            this.gbGcode.Controls.Add(this.lblElapsedTime);
            this.gbGcode.Controls.Add(this.Label23);
            this.gbGcode.Controls.Add(this.Label51);
            this.gbGcode.Controls.Add(this.lblCurrentLine);
            this.gbGcode.Controls.Add(this.dgvGcode);
            this.gbGcode.Controls.Add(this.btnFileReload);
            this.gbGcode.Controls.Add(this.tbGCodeMessage);
            this.gbGcode.Controls.Add(this.Label27);
            this.gbGcode.Controls.Add(this.lblTotalLines);
            this.gbGcode.Controls.Add(this.btnFilePause);
            this.gbGcode.Controls.Add(this.tbGcodeFile);
            this.gbGcode.Controls.Add(this.btnFileSelect);
            this.gbGcode.Controls.Add(this.btnFileSend);
            this.gbGcode.Controls.Add(this.btnFileStop);
            this.gbGcode.Enabled = false;
            this.gbGcode.Location = new System.Drawing.Point(3, 310);
            this.gbGcode.Name = "gbGcode";
            this.gbGcode.Size = new System.Drawing.Size(383, 445);
            this.gbGcode.TabIndex = 14;
            this.gbGcode.TabStop = false;
            this.gbGcode.Text = "GCode";
            // 
            // btnFileStep
            // 
            this.btnFileStep.Image = ((System.Drawing.Image)(resources.GetObject("btnFileStep.Image")));
            this.btnFileStep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFileStep.Location = new System.Drawing.Point(92, 41);
            this.btnFileStep.Name = "btnFileStep";
            this.btnFileStep.Size = new System.Drawing.Size(40, 40);
            this.btnFileStep.TabIndex = 29;
            this.btnFileStep.Tag = "Step";
            this.ToolTip1.SetToolTip(this.btnFileStep, "Single Step");
            this.btnFileStep.UseVisualStyleBackColor = true;
            // 
            // cbMonitorEnable
            // 
            this.cbMonitorEnable.AutoSize = true;
            this.cbMonitorEnable.Checked = true;
            this.cbMonitorEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMonitorEnable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbMonitorEnable.Location = new System.Drawing.Point(10, 92);
            this.cbMonitorEnable.Name = "cbMonitorEnable";
            this.cbMonitorEnable.Size = new System.Drawing.Size(61, 17);
            this.cbMonitorEnable.TabIndex = 28;
            this.cbMonitorEnable.Text = "Monitor";
            this.cbMonitorEnable.UseVisualStyleBackColor = true;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblElapsedTime.Location = new System.Drawing.Point(441, 49);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(13, 13);
            this.lblElapsedTime.TabIndex = 27;
            this.lblElapsedTime.Text = "  ";
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label23.Location = new System.Drawing.Point(441, 22);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(52, 13);
            this.Label23.TabIndex = 26;
            this.Label23.Text = "Elapsed";
            // 
            // Label51
            // 
            this.Label51.AutoSize = true;
            this.Label51.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label51.Location = new System.Drawing.Point(122, 93);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(16, 13);
            this.Label51.TabIndex = 25;
            this.Label51.Text = "of";
            // 
            // lblCurrentLine
            // 
            this.lblCurrentLine.AutoSize = true;
            this.lblCurrentLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCurrentLine.Location = new System.Drawing.Point(84, 93);
            this.lblCurrentLine.Name = "lblCurrentLine";
            this.lblCurrentLine.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentLine.TabIndex = 24;
            this.lblCurrentLine.Text = "0";
            this.lblCurrentLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvGcode
            // 
            this.dgvGcode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvGcode.AllowUserToAddRows = false;
            this.dgvGcode.AllowUserToDeleteRows = false;
            this.dgvGcode.AllowUserToResizeRows = false;
            this.dgvGcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGcode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stat,
            this.lineNum,
            this.data});
            this.dgvGcode.Location = new System.Drawing.Point(6, 115);
            this.dgvGcode.MultiSelect = false;
            this.dgvGcode.Name = "dgvGcode";
            this.dgvGcode.ReadOnly = true;
            this.dgvGcode.RowHeadersVisible = false;
            this.dgvGcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGcode.Size = new System.Drawing.Size(503, 324);
            this.dgvGcode.StandardTab = true;
            this.dgvGcode.TabIndex = 22;
            this.dgvGcode.VirtualMode = true;
            // 
            // stat
            // 
            this.stat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stat.Frozen = true;
            this.stat.HeaderText = "Sts";
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            this.stat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lineNum
            // 
            this.lineNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lineNum.HeaderText = "Line";
            this.lineNum.Name = "lineNum";
            this.lineNum.ReadOnly = true;
            this.lineNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.data.HeaderText = "GCode";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnFileReload
            // 
            this.btnFileReload.Enabled = false;
            this.btnFileReload.Image = ((System.Drawing.Image)(resources.GetObject("btnFileReload.Image")));
            this.btnFileReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFileReload.Location = new System.Drawing.Point(221, 41);
            this.btnFileReload.Name = "btnFileReload";
            this.btnFileReload.Size = new System.Drawing.Size(40, 40);
            this.btnFileReload.TabIndex = 21;
            this.btnFileReload.Tag = "Reload";
            this.ToolTip1.SetToolTip(this.btnFileReload, "Reload File");
            this.btnFileReload.UseVisualStyleBackColor = true;
            // 
            // tbGCodeMessage
            // 
            this.tbGCodeMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGCodeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbGCodeMessage.Location = new System.Drawing.Point(267, 61);
            this.tbGCodeMessage.Name = "tbGCodeMessage";
            this.tbGCodeMessage.Size = new System.Drawing.Size(223, 16);
            this.tbGCodeMessage.TabIndex = 20;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label27.Location = new System.Drawing.Point(267, 45);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(57, 13);
            this.Label27.TabIndex = 19;
            this.Label27.Text = "Message";
            // 
            // lblTotalLines
            // 
            this.lblTotalLines.AutoSize = true;
            this.lblTotalLines.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalLines.Location = new System.Drawing.Point(144, 93);
            this.lblTotalLines.Name = "lblTotalLines";
            this.lblTotalLines.Size = new System.Drawing.Size(13, 13);
            this.lblTotalLines.TabIndex = 17;
            this.lblTotalLines.Text = "0";
            this.lblTotalLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFilePause
            // 
            this.btnFilePause.Enabled = false;
            this.btnFilePause.Image = ((System.Drawing.Image)(resources.GetObject("btnFilePause.Image")));
            this.btnFilePause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFilePause.Location = new System.Drawing.Point(135, 41);
            this.btnFilePause.Name = "btnFilePause";
            this.btnFilePause.Padding = new System.Windows.Forms.Padding(3);
            this.btnFilePause.Size = new System.Drawing.Size(40, 40);
            this.btnFilePause.TabIndex = 6;
            this.btnFilePause.Tag = "Pause";
            this.ToolTip1.SetToolTip(this.btnFilePause, "Pause sending");
            this.btnFilePause.UseVisualStyleBackColor = true;
            // 
            // tbGcodeFile
            // 
            this.tbGcodeFile.Enabled = false;
            this.tbGcodeFile.Location = new System.Drawing.Point(6, 19);
            this.tbGcodeFile.Name = "tbGcodeFile";
            this.tbGcodeFile.Size = new System.Drawing.Size(424, 20);
            this.tbGcodeFile.TabIndex = 10;
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnFileSelect.Image")));
            this.btnFileSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFileSelect.Location = new System.Drawing.Point(6, 41);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(40, 40);
            this.btnFileSelect.TabIndex = 7;
            this.btnFileSelect.Tag = "File";
            this.ToolTip1.SetToolTip(this.btnFileSelect, "Load a file");
            this.btnFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnFileSend
            // 
            this.btnFileSend.Enabled = false;
            this.btnFileSend.Image = ((System.Drawing.Image)(resources.GetObject("btnFileSend.Image")));
            this.btnFileSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFileSend.Location = new System.Drawing.Point(49, 41);
            this.btnFileSend.Name = "btnFileSend";
            this.btnFileSend.Size = new System.Drawing.Size(40, 40);
            this.btnFileSend.TabIndex = 8;
            this.btnFileSend.Tag = "Send";
            this.ToolTip1.SetToolTip(this.btnFileSend, "Start/Resume sending");
            this.btnFileSend.UseVisualStyleBackColor = true;
            // 
            // btnFileStop
            // 
            this.btnFileStop.Enabled = false;
            this.btnFileStop.Image = ((System.Drawing.Image)(resources.GetObject("btnFileStop.Image")));
            this.btnFileStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFileStop.Location = new System.Drawing.Point(178, 41);
            this.btnFileStop.Name = "btnFileStop";
            this.btnFileStop.Size = new System.Drawing.Size(40, 40);
            this.btnFileStop.TabIndex = 9;
            this.btnFileStop.Tag = "Stop";
            this.ToolTip1.SetToolTip(this.btnFileStop, "Stop sending");
            this.btnFileStop.UseVisualStyleBackColor = true;
            // 
            // gbGrbl
            // 
            this.gbGrbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGrbl.Controls.Add(this.tcConnection);
            this.gbGrbl.Location = new System.Drawing.Point(3, 3);
            this.gbGrbl.Name = "gbGrbl";
            this.gbGrbl.Size = new System.Drawing.Size(178, 89);
            this.gbGrbl.TabIndex = 3;
            this.gbGrbl.TabStop = false;
            this.gbGrbl.Text = "Grbl";
            // 
            // tcConnection
            // 
            this.tcConnection.Controls.Add(this.tbGrblCOM);
            this.tcConnection.Controls.Add(this.tbGrblIP);
            this.tcConnection.Location = new System.Drawing.Point(6, 16);
            this.tcConnection.Name = "tcConnection";
            this.tcConnection.SelectedIndex = 0;
            this.tcConnection.Size = new System.Drawing.Size(162, 71);
            this.tcConnection.TabIndex = 0;
            // 
            // tbGrblCOM
            // 
            this.tbGrblCOM.Controls.Add(this.btnRescanPorts);
            this.tbGrblCOM.Controls.Add(this.cbPorts);
            this.tbGrblCOM.Controls.Add(this.btnConnect);
            this.tbGrblCOM.Controls.Add(this.cbBaud);
            this.tbGrblCOM.Location = new System.Drawing.Point(4, 22);
            this.tbGrblCOM.Name = "tbGrblCOM";
            this.tbGrblCOM.Padding = new System.Windows.Forms.Padding(3);
            this.tbGrblCOM.Size = new System.Drawing.Size(154, 45);
            this.tbGrblCOM.TabIndex = 0;
            this.tbGrblCOM.Text = "COM";
            this.tbGrblCOM.UseVisualStyleBackColor = true;
            // 
            // btnRescanPorts
            // 
            this.btnRescanPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRescanPorts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRescanPorts.Location = new System.Drawing.Point(77, 22);
            this.btnRescanPorts.Name = "btnRescanPorts";
            this.btnRescanPorts.Size = new System.Drawing.Size(75, 23);
            this.btnRescanPorts.TabIndex = 5;
            this.btnRescanPorts.Text = "ReScan";
            this.btnRescanPorts.UseVisualStyleBackColor = true;
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(2, 2);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(72, 21);
            this.cbPorts.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConnect.Location = new System.Drawing.Point(77, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Tag = "COM";
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(2, 22);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(72, 21);
            this.cbBaud.TabIndex = 4;
            // 
            // tbGrblIP
            // 
            this.tbGrblIP.Controls.Add(this.btnIPConnect);
            this.tbGrblIP.Controls.Add(this.tbIPAddress);
            this.tbGrblIP.Location = new System.Drawing.Point(4, 22);
            this.tbGrblIP.Name = "tbGrblIP";
            this.tbGrblIP.Padding = new System.Windows.Forms.Padding(3);
            this.tbGrblIP.Size = new System.Drawing.Size(154, 45);
            this.tbGrblIP.TabIndex = 1;
            this.tbGrblIP.Text = "IP";
            this.tbGrblIP.UseVisualStyleBackColor = true;
            // 
            // btnIPConnect
            // 
            this.btnIPConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIPConnect.Location = new System.Drawing.Point(12, 20);
            this.btnIPConnect.Name = "btnIPConnect";
            this.btnIPConnect.Size = new System.Drawing.Size(131, 23);
            this.btnIPConnect.TabIndex = 1;
            this.btnIPConnect.Tag = "IP";
            this.btnIPConnect.Text = "Connect";
            this.btnIPConnect.UseVisualStyleBackColor = true;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(12, 0);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(131, 20);
            this.tbIPAddress.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.tbIPAddress, "Enter IP Address and port as \"<IP>:<port>\"");
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.tabCtlPosition);
            this.gbPosition.Enabled = false;
            this.gbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPosition.Location = new System.Drawing.Point(532, 3);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(400, 403);
            this.gbPosition.TabIndex = 2;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Position";
            // 
            // tabCtlPosition
            // 
            this.tabCtlPosition.Controls.Add(this.tpWork);
            this.tabCtlPosition.Controls.Add(this.tpOffsets);
            this.tabCtlPosition.Location = new System.Drawing.Point(6, 19);
            this.tabCtlPosition.Name = "tabCtlPosition";
            this.tabCtlPosition.SelectedIndex = 0;
            this.tabCtlPosition.Size = new System.Drawing.Size(388, 378);
            this.tabCtlPosition.TabIndex = 0;
            // 
            // tpWork
            // 
            this.tpWork.Controls.Add(this.Panel5);
            this.tpWork.Controls.Add(this.Panel4);
            this.tpWork.Controls.Add(this.Panel3);
            this.tpWork.Controls.Add(this.GroupBox1);
            this.tpWork.Controls.Add(this.btnWorkSoftHome);
            this.tpWork.Controls.Add(this.btnHome);
            this.tpWork.Controls.Add(this.btnWorkSpclPosition);
            this.tpWork.Controls.Add(this.Label3);
            this.tpWork.Controls.Add(this.btnWork0);
            this.tpWork.Controls.Add(this.Label2);
            this.tpWork.Controls.Add(this.btnWorkX0);
            this.tpWork.Controls.Add(this.Label1);
            this.tpWork.Controls.Add(this.btnWorkZ0);
            this.tpWork.Controls.Add(this.btnWorkY0);
            this.tpWork.Location = new System.Drawing.Point(4, 22);
            this.tpWork.Name = "tpWork";
            this.tpWork.Padding = new System.Windows.Forms.Padding(3);
            this.tpWork.Size = new System.Drawing.Size(380, 352);
            this.tpWork.TabIndex = 0;
            this.tpWork.Text = "Work";
            this.tpWork.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(7, 116);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 37);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Y";
            // 
            // btnWorkX0
            // 
            this.btnWorkX0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWorkX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnWorkX0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWorkX0.Location = new System.Drawing.Point(340, 33);
            this.btnWorkX0.Name = "btnWorkX0";
            this.btnWorkX0.Size = new System.Drawing.Size(34, 34);
            this.btnWorkX0.TabIndex = 6;
            this.btnWorkX0.Tag = "X";
            this.btnWorkX0.Text = "0";
            this.ToolTip1.SetToolTip(this.btnWorkX0, "Set X axis to 0 on Active Offset");
            this.btnWorkX0.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(7, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 37);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "X";
            // 
            // btnWorkZ0
            // 
            this.btnWorkZ0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWorkZ0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnWorkZ0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWorkZ0.Location = new System.Drawing.Point(340, 207);
            this.btnWorkZ0.Name = "btnWorkZ0";
            this.btnWorkZ0.Size = new System.Drawing.Size(34, 34);
            this.btnWorkZ0.TabIndex = 8;
            this.btnWorkZ0.Tag = "Z";
            this.btnWorkZ0.Text = "0";
            this.ToolTip1.SetToolTip(this.btnWorkZ0, "Set Z axis to 0 on Active Offset");
            this.btnWorkZ0.UseVisualStyleBackColor = true;
            // 
            // btnWorkY0
            // 
            this.btnWorkY0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWorkY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnWorkY0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWorkY0.Location = new System.Drawing.Point(340, 120);
            this.btnWorkY0.Name = "btnWorkY0";
            this.btnWorkY0.Size = new System.Drawing.Size(34, 34);
            this.btnWorkY0.TabIndex = 7;
            this.btnWorkY0.Tag = "Y";
            this.btnWorkY0.Text = "0";
            this.ToolTip1.SetToolTip(this.btnWorkY0, "Set Y axis to 0 on Active Offset");
            this.btnWorkY0.UseVisualStyleBackColor = true;
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.OptionsToolStripMenuItem.Text = "Options";
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Visible = false;
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuItem1.Text = "File";
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabControl1.Controls.Add(this.tabPgInterface);
            this.TabControl1.Controls.Add(this.tabPgSettings);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Location = new System.Drawing.Point(21, 27);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1005, 772);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 3;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ofdOffsets
            // 
            this.ofdOffsets.DefaultExt = "xml";
            this.ofdOffsets.FileName = "OpenFileDialog1";
            this.ofdOffsets.Filter = "WorkOffset Files|*.xml";
            // 
            // GrblGui
            // 
            this.ClientSize = new System.Drawing.Size(1143, 749);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.MenuStrip1);
            this.MinimumSize = new System.Drawing.Size(1159, 736);
            this.Name = "GrblGui";
            this.tabPgSettings.ResumeLayout(false);
            this.tabPgSettings.PerformLayout();
            this.gbMiscInfo.ResumeLayout(false);
            this.gbMiscInfo.PerformLayout();
            this.gbGrblSettings.ResumeLayout(false);
            this.gbGrblSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrblSettings)).EndInit();
            this.gbSettingsOffsets.ResumeLayout(false);
            this.gbSettingsOffsets.PerformLayout();
            this.gbSettingsMisc.ResumeLayout(false);
            this.gbSettingsMisc.PerformLayout();
            this.gbSettingsPosition.ResumeLayout(false);
            this.gbSettingsPosition.PerformLayout();
            this.gbSettingsJogging.ResumeLayout(false);
            this.gbSettingsJogging.PerformLayout();
            this.tpOffsets.ResumeLayout(false);
            this.tpOffsets.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.gbEditor.ResumeLayout(false);
            this.gbEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMacros)).EndInit();
            this.gbMDI.ResumeLayout(false);
            this.gbMDI.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbPinStatus.ResumeLayout(false);
            this.gbPinStatus.PerformLayout();
            this.gbOverrides.ResumeLayout(false);
            this.gbOverrides.PerformLayout();
            this.tabPgInterface.ResumeLayout(false);
            this.gbState.ResumeLayout(false);
            this.gbJogging.ResumeLayout(false);
            this.gbJogging.PerformLayout();
            this.gbFeedRate.ResumeLayout(false);
            this.gbFeedRate.PerformLayout();
            this.gbDistance.ResumeLayout(false);
            this.gbDistance.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbGcode.ResumeLayout(false);
            this.gbGcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGcode)).EndInit();
            this.gbGrbl.ResumeLayout(false);
            this.tcConnection.ResumeLayout(false);
            this.tbGrblCOM.ResumeLayout(false);
            this.tbGrblIP.ResumeLayout(false);
            this.tbGrblIP.PerformLayout();
            this.gbPosition.ResumeLayout(false);
            this.tabCtlPosition.ResumeLayout(false);
            this.tpWork.ResumeLayout(false);
            this.tpWork.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrblSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*
        private void dgvGcode_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (this.cbMonitorEnable.Checked && !Information.IsNothing(gcodeview))
            {
                gcodeItem item = GetGcodeItem(e.RowIndex);
                if (!Information.IsNothing(item))
                {
                    string name = this.dgvGcode.Columns[e.ColumnIndex].Name;
                    if (String.Compare(name, "stat", false) == 0)
                    {
                        e.Value = item.status;
                        return;
                    }
                    if (String.Compare(name, "lineNum", false) == 0)
                    {
                        e.Value = item.lineNum;
                        return;
                    }
                    if (String.Compare(name, "data", false) != 0)
                    {
                        return;
                    }
                    e.Value = item.gcode;
                }
            }
        }

        public void processVerOptMessages(string data)
        {
            checked
            {
                if (this.info.once)
                {
                    if (data.StartsWith("[VER:"))
                    {
                        string str = data.Remove(data.Length - 3);
                        this.tbGrblVersion.Text = str.Remove(0, 5);
                    }
                    if (data.StartsWith("[OPT"))
                    {
                        string str2 = data.Remove(data.Length - 3);
                        this.tbGrblOptions.Text = str2.Remove(0, 5);
                        this.info.once = false;
                    }
                }
            }
        }

        private void GrblMacroButtons_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bDataChanged)
            {
                if (Interaction.MsgBox(Resources.GrblGui_GrblMacroButtons_FormClosing_AreYouSureYouWantToExitWithoutSavingYourMacroChanges, MsgBoxStyle.YesNo | MsgBoxStyle.Critical, Resources.GrblGui_GrblMacroButtons_FormClosing_ConfirmExitWithoutSaving) == MsgBoxResult.Yes)
                {
                    e.Cancel = false;
                    return;
                }
                e.Cancel = true;
            }
        }

        private void GrblMacroButtons_Load(object sender, EventArgs e)
        {
            this.FillListFromSettings();
            DataGridView dgMacros = this.dgMacros;
            dgMacros.Columns[0].Width = dgMacros.Width;
            this.btnAdd.Text = Resources.GrblGui_GrblMacroButtons_Load_Add;
            this.tbName.Text = "";
            this.tbGCode.Text = "";
        }

        private void FillListFromSettings()
        {
            DataGridView dgMacros = this.dgMacros;
            dgMacros.RowCount = 0;
            string[] macroNames = this._macroNames;
            checked
            {
                for (int i = 0; i < macroNames.Length; i++)
                {
                    string KeyName = macroNames[i];
                    string[] sTemp = Strings.Split(Convert.ToString(MySettingsProperty.Settings[KeyName]), ":", -1, CompareMethod.Binary);
                    if (sTemp.Count<string>() == 2)
                    {
                        dgMacros.Rows.Add(new object[]
                        {
                            sTemp[0],
                            sTemp[1]
                        });
                    }
                }
                this.bDataChanged = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.SaveMacros();
            base.DialogResult = DialogResult.OK;
        }

        private void SaveMacros()
        {
            int index = 0;
            string[] macroNames = this._macroNames;
            checked
            {
                for (int i = 0; i < macroNames.Length; i++)
                {
                    string macro = macroNames[i];
                    MySettingsProperty.Settings[macro] = "";
                }
                try
                {
                    IEnumerator enumerator = ((IEnumerable)this.dgMacros.Rows).GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataGridViewRow row = (DataGridViewRow)enumerator.Current;
                        MySettingsProperty.Settings[this._macroNames[index]] = row.Cells[0].Value.ToString() + ":" + row.Cells[1].Value.ToString();
                        index++;
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
                MySettingsProperty.Settings.Save();
                this.bDataChanged = false;
                this.EnableMacroButtons();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void dgMacros_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bDataChanged = true;
        }

        private void dgMacros_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgMacros = this.dgMacros;
            if (dgMacros.CurrentRow.Index >= 0)
            {
                this.tbName.Text = Convert.ToString(dgMacros[0, dgMacros.CurrentRow.Index].Value);
                this.tbGCode.Text = Convert.ToString(dgMacros[1, dgMacros.CurrentRow.Index].Value);
                this.btnAdd.Text = Resources.GrblGui_dgMacros_DoubleClick_Update;
            }
        }

        private void btnDeleteMacro_Click(object sender, EventArgs e)
        {
            DataGridView dgMacros = this.dgMacros;
            if (dgMacros.CurrentRow.Index >= 0 && Interaction.MsgBox(Resources.GrblGui_btnDeleteMacro_Click_AreYouSureYouWantToDeleteThe + dgMacros[0, dgMacros.CurrentRow.Index].Value.ToString() + " macro?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical, Resources.GrblGui_btnDeleteMacro_Click_ConfirmDelete) == MsgBoxResult.Yes)
            {
                dgMacros.Rows.Remove(dgMacros.CurrentRow);
                this.bDataChanged = true;
            }
        }

        private void UpdateToolTip(object sender, EventArgs e)
        {
            string sTemp;
            if (sender == this.tbName)
            {
                sTemp = Resources.GrblGui_UpdateToolTip_NameAppearsOnTheButtonSoKeepItSmall;
            }
            else
            {
                if (sender == this.btnDeleteMacro)
                {
                    sTemp = Resources.GrblGui_UpdateToolTip_DeleteTheSelectedMacro;
                }
                else
                {
                    if (sender == this.dgMacros)
                    {
                        sTemp = Resources.GrblGui_UpdateToolTip_DblClickNameToEditMacro;
                    }
                    else
                    {
                        if (sender == this.btnCancel)
                        {
                            sTemp = Resources.GrblGui_UpdateToolTip_GetMeOuttaHereCancelAllChanges;
                        }
                        else
                        {
                            if (sender == this.tbGCode)
                            {
                                sTemp = Resources.GrblGui_UpdateToolTip_GCodeToSendWhenTheButtonIsClicked;
                            }
                            else
                            {
                                if (sender == this.btnOK)
                                {
                                    sTemp = Resources.GrblGui_UpdateToolTip_CommitAllChangesToSettingsAndClose;
                                }
                                else
                                {
                                    sTemp = Resources.GrblGui_UpdateToolTip_LimitIs5Macros;
                                }
                            }
                        }
                    }
                }
            }
            this.lblStatusLabel.Text = sTemp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.tbName.Text, "", false) == 0)
            {
                Interaction.MsgBox(Resources.GrblGui_btnAdd_Click_YouCannotCreateAMacroWithoutAName, MsgBoxStyle.Information, Resources.GrblGui_btnAdd_Click_DataValidationError);
                return;
            }
            if (String.Compare(this.tbGCode.Text, "", false) != 0)
            {
                if (String.Compare(this.btnAdd.Text, Resources.GrblGui_dgMacros_DoubleClick_Update, false) == 0)
                {
                    bool bMatchFound;
                    try
                    {
                        IEnumerator enumerator = ((IEnumerable)this.dgMacros.Rows).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            DataGridViewRow row = (DataGridViewRow)enumerator.Current;
                            if (!bMatchFound && String.Compare(row.Cells[0].Value.ToString(), this.tbName.Text, false) == 0)
                            {
                                row.Cells[1].Value = this.tbGCode.Text.ToUpper();
                                bMatchFound = true;
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
                    if (!bMatchFound)
                    {
                        this.dgMacros.Rows.Add(new object[]
                        {
                            this.tbName.Text,
                            this.tbGCode.Text
                        });
                    }
                }
                else
                {
                    this.dgMacros.Rows.Add(new object[]
                    {
                        this.tbName.Text,
                        this.tbGCode.Text.ToUpper()
                    });
                }
                this.bDataChanged = true;
                this.btnAdd.Text = Resources.GrblGui_GrblMacroButtons_Load_Add;
                this.tbGCode.Text = "";
                this.tbName.Text = "";
                return;
            }
            Interaction.MsgBox(Resources.GrblGui_btnAdd_Click_YouNeedToAddSomeGCodeToSaveAMacro, MsgBoxStyle.Information, Resources.GrblGui_btnAdd_Click_DataValidationError);
        }

        public Button IsMacroBtn(int num)
        {
            checked
            {
                Button IsMacroBtn;
                for (int iLoopCounter = this.gbMDI.Controls.Count - 1; iLoopCounter >= 0; iLoopCounter += -1)
                {
                    Control mButton = this.gbMDI.Controls[iLoopCounter];
                    string i = "btnMacro" + Convert.ToString(num - 1);
                    if (String.Compare(mButton.Name, i, false) == 0)
                    {
                        IsMacroBtn = (Button)mButton;
                        return IsMacroBtn;
                    }
                }
                IsMacroBtn = null;
                return IsMacroBtn;
            }
        }

        public string[] GetmacroNames()
        {
            return this._macroNames;
        }

        private void btnOffsetsZero_Click(object sender, EventArgs e)
        {
            Control arg_0C_0 = (Button)sender;
            string index = "";
            string tag = (string)arg_0C_0.Tag;
            tag = tag.Substring(0, 3);
            if (tag.StartsWith("G5"))
            {
                if (String.Compare(tag, "G54", false) != 0)
                {
                    if (String.Compare(tag, "G55", false) != 0)
                    {
                        if (String.Compare(tag, "G56", false) != 0)
                        {
                            if (String.Compare(tag, "G57", false) != 0)
                            {
                                if (String.Compare(tag, "G58", false) != 0)
                                {
                                    if (String.Compare(tag, "G59", false) == 0)
                                    {
                                        index = "P6";
                                    }
                                }
                                else
                                {
                                    index = "P5";
                                }
                            }
                            else
                            {
                                index = "P4";
                            }
                        }
                        else
                        {
                            index = "P3";
                        }
                    }
                    else
                    {
                        index = "P2";
                    }
                }
                else
                {
                    index = "P1";
                }
                gcode.sendGCodeLine("G10 L2 " + index + " X0 Y0 Z0");
            }
            else
            {
                if (tag.StartsWith("G28") || tag.StartsWith("G30"))
                {
                    gcode.sendGCodeLine(tag.Substring(0, 3) + ".1");
                }
                else
                {
                    if (tag.StartsWith("G43"))
                    {
                        gcode.sendGCodeLine("G43.1 Z0");
                    }
                }
            }
            this.btnOffsetsRetrieve_Click(null, null);
        }

        private void tbOffsets_DoubleClick(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string tag = (string)tb.Tag;
            this.SendOffsets(tag, tb.Text);
        }

        public void SendOffsets(string tag, string value)
        {
            string index = "";
            string axis = Convert.ToString(tag[3]);
            if (tag.Contains("G5"))
            {
                string left = tag.Substring(0, 3);
                if (String.Compare(left, "G54", false) != 0)
                {
                    if (String.Compare(left, "G55", false) != 0)
                    {
                        if (String.Compare(left, "G56", false) != 0)
                        {
                            if (String.Compare(left, "G57", false) != 0)
                            {
                                if (String.Compare(left, "G58", false) != 0)
                                {
                                    if (String.Compare(left, "G59", false) == 0)
                                    {
                                        index = "P6";
                                    }
                                }
                                else
                                {
                                    index = "P5";
                                }
                            }
                            else
                            {
                                index = "P4";
                            }
                        }
                        else
                        {
                            index = "P3";
                        }
                    }
                    else
                    {
                        index = "P2";
                    }
                }
                else
                {
                    index = "P1";
                }
                gcode.sendGCodeLine(string.Concat(new string[]
                {
                    "G10 L2 ",
                    index,
                    " ",
                    axis,
                    value
                }));
                Thread.Sleep(400);
                this.btnOffsetsRetrieve_Click(null, null);
            }
            if (tag.Contains("G43"))
            {
                gcode.sendGCodeLine("G43.1" + axis + value);
                Thread.Sleep(400);
                this.btnOffsetsRetrieve_Click(null, null);
            }
        }

        private void btnSetOffset_Click(object sender, EventArgs e)
        {
            Control arg_0C_0 = (Button)sender;
            string index = "";
            string arg_4B_0 = (string)arg_0C_0.Tag;
            string XValue = this.tbOffSetsMachX.Text.ToString();
            string YValue = this.tbOffSetsMachY.Text.ToString();
            string ZValue = this.tbOffSetsMachZ.Text.ToString();
            string left = arg_4B_0.Substring(0, 3);
            if (String.Compare(left, "G54", false) != 0)
            {
                if (String.Compare(left, "G55", false) != 0)
                {
                    if (String.Compare(left, "G56", false) != 0)
                    {
                        if (String.Compare(left, "G57", false) != 0)
                        {
                            if (String.Compare(left, "G58", false) != 0)
                            {
                                if (String.Compare(left, "G59", false) == 0)
                                {
                                    index = "P6";
                                }
                            }
                            else
                            {
                                index = "P5";
                            }
                        }
                        else
                        {
                            index = "P4";
                        }
                    }
                    else
                    {
                        index = "P3";
                    }
                }
                else
                {
                    index = "P2";
                }
            }
            else
            {
                index = "P1";
            }
            gcode.sendGCodeLine(string.Concat(new string[]
            {
                "G10 L2 ",
                index,
                " X",
                XValue,
                "Y",
                YValue,
                "Z",
                ZValue
            }));
            this.btnOffsetsRetrieve_Click(null, null);
        }

        private void btnOffsetsRetrieve_Click(object sender, EventArgs e)
        {
            this.offsets.OffsetsWtgForGrbl = true;
            this.offsets.ClearParams();
            gcode.sendGCodeLine("$#");
        }

        public void showGrblOffsets(string data)
        {
            if (data.Length >= 3 && this.offsets.OffsetsWtgForGrbl)
            {
                if (String.Compare(Convert.ToString(data[0]), "[", false) == 0 && (String.Compare(Convert.ToString(data[1]), "G", false) == 0 || String.Compare(Convert.ToString(data[1]), "T", false) == 0))
                {
                    this.offsets.AddOffset(data);
                    this.offsets.CollectingOffsets = true;
                    return;
                }
                if (this.offsets.CollectingOffsets && String.Compare(Convert.ToString(data[0]), "[", false) != 0)
                {
                    this.offsets.OffsetsWtgForGrbl = false;
                    this.offsets.CollectingOffsets = false;
                    this.ShowOffsets();
                }
            }
        }

        public void ShowOffsets()
        {
            checked
            {
                try
                {
                    List<string>.Enumerator enumerator = this.offsets.Offsets.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        string expr_24 = enumerator.Current.Remove(0, 1);
                        string expr_32 = expr_24.Remove(expr_24.Length - 3, 3);
                        string label = expr_32.Substring(0, 3);
                        string[] axes = expr_32.Remove(0, 4).Split(new char[]
                        {
                            ','
                        });
                        uint num = < PrivateImplementationDetails >.ComputeStringHash(label);
                        if (num <= 3928018819u)
                        {
                            if (num <= 2116433325u)
                            {
                                if (num != 5505686u)
                                {
                                    if (num != 2116433325u)
                                    {
                                        continue;
                                    }
                                    if (String.Compare(label, "G30", false) != 0)
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    if (String.Compare(label, "TLO", false) != 0)
                                    {
                                        continue;
                                    }
                                    this.tpOffsets.Controls.Find("tbOffsetsG43Z", true)[0].Text = axes[0];
                                    continue;
                                }
                            }
                            else
                            {
                                if (num != 3911241200u)
                                {
                                    if (num != 3928018819u)
                                    {
                                        continue;
                                    }
                                    if (String.Compare(label, "G58", false) != 0)
                                    {
                                        continue;
                                    }
                                    goto IL_20E;
                                }
                                else
                                {
                                    if (String.Compare(label, "G59", false) != 0)
                                    {
                                        continue;
                                    }
                                    goto IL_20E;
                                }
                            }
                        }
                        else
                        {
                            if (num <= 4112572628u)
                            {
                                if (num != 4028831628u)
                                {
                                    if (num != 4112572628u)
                                    {
                                        continue;
                                    }
                                    if (String.Compare(label, "G55", false) != 0)
                                    {
                                        continue;
                                    }
                                    goto IL_20E;
                                }
                                else
                                {
                                    if (String.Compare(label, "G28", false) != 0)
                                    {
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                if (num != 4129350247u)
                                {
                                    if (num != 4146127866u)
                                    {
                                        if (num != 4162905485u)
                                        {
                                            continue;
                                        }
                                        if (String.Compare(label, "G56", false) != 0)
                                        {
                                            continue;
                                        }
                                        goto IL_20E;
                                    }
                                    else
                                    {
                                        if (String.Compare(label, "G57", false) != 0)
                                        {
                                            continue;
                                        }
                                        goto IL_20E;
                                    }
                                }
                                else
                                {
                                    if (String.Compare(label, "G54", false) != 0)
                                    {
                                        continue;
                                    }
                                    goto IL_20E;
                                }
                            }
                        }
                        int i = 0;
                        string[] array = new string[]
                        {
                            "X",
                            "Y",
                            "Z"
                        };
                        for (int k = 0; k < array.Length; k++)
                        {
                            string axi = array[k];
                            this.tabPgSettings.Controls.Find("tbOffsets" + label + axi, true)[0].Text = axes[i];
                            i++;
                        }
                        continue;
                        IL_20E:
                        int j = 0;
                        string[] array2 = new string[]
                        {
                            "X",
                            "Y",
                            "Z"
                        };
                        for (int l = 0; l < array2.Length; l++)
                        {
                            string axi2 = array2[l];
                            this.tpOffsets.Controls.Find("tbOffsets" + label + axi2, true)[0].Text = axes[j];
                            j++;
                        }
                    }
                }
                finally
                {
                    List<string>.Enumerator enumerator;
                    ((IDisposable)enumerator).Dispose();
                }
            }
        }

        private void btnOffsetsSave_Click(object sender, EventArgs e)
        {
            this.offsets.SaveOffsets();
        }

        private void btnOffsetsLoad_Click(object sender, EventArgs e)
        {
            this.offsets.LoadOffsets();
        }

        public void processLineEvent(string data)
        {
            checked
            {
                if (gcode.wtgForAck && (data.StartsWith("ok") || data.StartsWith("error")))
                {
                    UpdateGCodeStatus(data, gcode.linesDone - 1);
                    gcode.wtgForAck = false;
                    if (gcode.m30Flag)
                    {
                        gcode.m30Flag = false;
                        gcode.sendGCodeFileRewind();
                    }
                    if (gcode.runMode)
                    {
                        gcode.sendAnotherLine = true;
                    }
                }
                if ((gcode.runMode || gcode.stepMode) && gcode.sendAnotherLine)
                {
                    gcode.sendAnotherLine = false;
                    if (gcode.lineCount > 0)
                    {
                        string line = readGcode(gcode.lineCount, gcode.linesDone);
                        if (!line.StartsWith("EOF"))
                        {
                            GrblGcode grblGcode;
                            (grblGcode = gcode).lineCount = grblGcode.lineCount - 1;
                            UpdateGcodeSent(gcode.linesDone);
                            (grblGcode = gcode).linesDone = grblGcode.linesDone + 1;
                            this.lblCurrentLine.Text = gcode.linesDone.ToString();
                            this.state.ProcessGCode(line);
                            if (line.StartsWith("("))
                            {
                                string templine = line;
                                templine = templine.Remove(0, 1);
                                templine = templine.Remove(templine.Length - 1, 1);
                                this.tbGCodeMessage.Text = templine;
                            }
                            if (line.StartsWith("m30") || line.StartsWith("M30"))
                            {
                                gcode.m30Flag = true;
                            }
                            line = line.Replace(" ", "");
                            gcode.wtgForAck = true;
                            this.grblPort.SendData(line);
                        }
                    }
                    else
                    {
                        gcode.sendGCodeFileStop();
                    }
                }
                string[] status = Strings.Split(data, ",", -1, CompareMethod.Binary);
                if (String.Compare(status[0], "<Alarm", false) == 0 || status[0].StartsWith("ALARM"))
                {
                    gcode.sendGCodeFileStop();
                }
                if (status[0].StartsWith("error") && this.cbSettingsPauseOnError.Checked)
                {
                    this.btnFilePause.PerformClick();
                }
            }
        }

        private void btnCheckMode_Click(object sender, EventArgs e)
        {
            this.grblPort.SendData("$C");
        }

        private void btnFileGroup_Click(object sender, EventArgs e)
        {
            string text = (string)((Button)sender).Tag;
            uint num = < PrivateImplementationDetails >.ComputeStringHash(text);
            if (num <= 1157218093u)
            {
                if (num != 440640172u)
                {
                    if (num != 723007075u)
                    {
                        if (num != 1157218093u)
                        {
                            return;
                        }
                        if (String.Compare(text, "Pause", false) != 0)
                        {
                            return;
                        }
                        gcode.sendGCodeFilePause();
                        this.btnFileSelect.Enabled = false;
                        this.btnFileSend.Tag = "Resume";
                        this.btnFileSend.Enabled = true;
                        this.btnFilePause.Enabled = false;
                        this.btnFileStop.Enabled = true;
                        this.btnFileReload.Enabled = false;
                        return;
                    }
                    else
                    {
                        if (String.Compare(text, "File", false) != 0)
                        {
                            return;
                        }
                        string str = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                        this.ofdGcodeFile.InitialDirectory = Path.Combine(Path.GetFullPath(str), "*");
                        if (String.Compare(this.tbSettingsDefaultExt.Text, "", false) != 0)
                        {
                            this.ofdGcodeFile.Filter = string.Format("Gcode |*.{0}|All Files |*.*", this.tbSettingsDefaultExt.Text);
                            this.ofdGcodeFile.DefaultExt = string.Format(".{0}", this.tbSettingsDefaultExt.Text);
                        }
                        this.ofdGcodeFile.FileName = "File";
                        if (this.ofdGcodeFile.ShowDialog() == DialogResult.OK)
                        {
                            gcode.loadGCodeFile(this.ofdGcodeFile.FileName);
                            this.tbGcodeFile.Text = this.ofdGcodeFile.FileName;
                            this.lblTotalLines.Text = gcode.lineCount.ToString();
                            this.btnFileSelect.Enabled = true;
                            this.btnFileSend.Enabled = true;
                            this.btnFileStep.Enabled = true;
                            this.btnFilePause.Enabled = false;
                            this.btnFileStop.Enabled = false;
                            this.btnFileReload.Enabled = false;
                            this.ofdGcodeFile.Filter = "";
                            this.ofdGcodeFile.DefaultExt = "";
                            return;
                        }
                    }
                }
                else
                {
                    if (String.Compare(text, "Reload", false) != 0)
                    {
                        return;
                    }
                    gcode.loadGCodeFile(this.ofdGcodeFile.FileName);
                    this.tbGcodeFile.Text = this.ofdGcodeFile.FileName;
                    this.lblTotalLines.Text = gcode.lineCount.ToString();
                    this.btnFileSelect.Enabled = true;
                    this.btnFileSend.Enabled = true;
                    this.btnFilePause.Enabled = false;
                    this.btnFileStop.Enabled = false;
                    this.btnFileReload.Enabled = false;
                    DisplayTop();
                }
                return;
            }
            if (num <= 1198651695u)
            {
                if (num != 1162681738u)
                {
                    if (num != 1198651695u)
                    {
                        return;
                    }
                    if (String.Compare(text, "Step", false) != 0)
                    {
                        return;
                    }
                    gcode.sendGCodeFileStep();
                    this.btnFileSend.Tag = "Resume";
                    this.btnFileSend.Enabled = true;
                    this.btnFileSelect.Enabled = false;
                    this.btnFilePause.Enabled = true;
                    this.btnFileStop.Enabled = true;
                    this.btnFileReload.Enabled = false;
                    return;
                }
                else
                {
                    if (String.Compare(text, "Resume", false) != 0)
                    {
                        return;
                    }
                    gcode.sendGCodeFileResume();
                    this.btnFileSelect.Enabled = false;
                    this.btnFileSend.Tag = "Send";
                    this.btnFileSend.Enabled = false;
                    this.btnFilePause.Enabled = true;
                    this.btnFileStop.Enabled = true;
                    this.btnFileReload.Enabled = false;
                    return;
                }
            }
            else
            {
                if (num != 1266644741u)
                {
                    if (num != 4069397711u)
                    {
                        return;
                    }
                    if (String.Compare(text, "Send", false) != 0)
                    {
                        return;
                    }
                    gcode.sendGcodeFile();
                    this.btnFileSelect.Enabled = false;
                    this.btnFileSend.Enabled = false;
                    this.btnFilePause.Enabled = true;
                    this.btnFileStop.Enabled = true;
                    this.btnFileReload.Enabled = false;
                    return;
                }
                else
                {
                    if (String.Compare(text, "Stop", false) != 0)
                    {
                        return;
                    }
                    gcode.sendGCodeFilePause();
                    gcode.closeGCodeFile();
                    this.setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Idle);
                    this.btnFileSelect.Enabled = true;
                    this.btnFileSend.Tag = "Send";
                    this.btnFileSend.Enabled = false;
                    this.btnFilePause.Enabled = false;
                    this.btnFileStop.Enabled = false;
                    this.btnFileReload.Enabled = true;
                    return;
                }
            }
        }

        public void myhandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            MessageBox.Show(string.Concat(new string[]
            {
                "Exception: ",
                e.Message,
                "\n",
                e.InnerException.Message,
                "\n",
                e.StackTrace
            }));
        }

        private void grblgui_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(this.myhandler);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA");
            Application.EnableVisualStyles();
            if (MySettingsProperty.Settings.UpgradeSettings)
            {
                MySettingsProperty.Settings.Upgrade();
                MySettingsProperty.Settings.UpgradeSettings = false;
                MySettingsProperty.Settings.Save();
            }
            this.tabPgSettings.Show();
            this.tabPgInterface.Show();
            this.SwitchSides(this.cbSettingsLeftHanded.Checked);
            this.grblPort = new GrblIF();
            GrblGui grblGui = this;
            this.settings = new GrblSettings(ref grblGui);
            grblGui = this;
            this.status = new GrblStatus(ref grblGui);
            grblGui = this;
            this.jogging = new GrblJogging(ref grblGui);
            grblGui = this;
            this.position = new GrblPosition(ref grblGui);
            grblGui = this;
            gcode = new GrblGcode(ref grblGui);
            DataGridView dgvGcode = this.dgvGcode;
            GrblGcodeView arg_EB_0 = new GrblGcodeView(ref dgvGcode);
            this.dgvGcode = dgvGcode;
            gcodeview = arg_EB_0;
            grblGui = this;
            this.offsets = new GrblOffsets(ref grblGui);
            grblGui = this;
            this.state = new GrblState(ref grblGui);
            grblGui = this;
            this.ovrrides = new GrblOverrides(ref grblGui);
            grblGui = this;
            this.pins = new GrblPins(ref grblGui);
            grblGui = this;
            this.info = new GrblInfo(ref grblGui);
            this.rescanPorts();
            if (String.Compare(MySettingsProperty.Settings.Port, "", false) != 0)
            {
                this.cbPorts.SelectedIndex = this.cbPorts.FindStringExact(MySettingsProperty.Settings.Port);
            }
            this.cbBaud.SelectedText = MySettingsProperty.Settings.Baud;
            this.grblPort.Baudrate = Convert.ToInt32(MySettingsProperty.Settings.Baud);
            this.tcConnection.SelectedIndex = Convert.ToInt32(MySettingsProperty.Settings.ConnectionType);
            this.tbIPAddress.Text = MySettingsProperty.Settings.IPAddress;
            if (this.cbSettingsConnectOnLoad.Checked)
            {
                this.btnConnDisconnect_Click(this.btnConnect, null);
            }
            this.EnableMacroButtons();
            grblGui = this;
            Application.AddMessageFilter(new MsgFilter(ref grblGui));
        }

        private void grblgui_unload(object sender, CancelEventArgs e)
        {
            if (this._exitClicked)
            {
                this.tidyClose();
                return;
            }
            if (Interaction.MsgBox(Resources.GrblGui_grblgui_unload_AreYouCertainThatYouWantToClose, MsgBoxStyle.OkCancel, null) == MsgBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._exitClicked = true;
            this.tidyClose();
        }

        private void tidyClose()
        {
            this.grblPort.Disconnect();
            gcode.shutdown();
            this.status.shutdown();
            this.jogging.shutdown();
            this.position.shutdown();
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool ProcessCmdKey;
            if (keyData == Keys.Return)
            {
                Control ctrl = base.ActiveControl;
                if (String.Compare(ctrl.Parent.Name, "tpOffsets", false) == 0)
                {
                    this.SendOffsets((string)ctrl.Tag, ctrl.Text);
                    ProcessCmdKey = true;
                    return ProcessCmdKey;
                }
                if (this.dgGrblSettings.IsCurrentCellDirty && !Information.IsNothing(this.dgGrblSettings.CurrentRow))
                {
                    string param = this.dgGrblSettings.CurrentRow.Cells[0].Value.ToString() + "=" + this.dgGrblSettings.CurrentCell.EditedFormattedValue.ToString();
                    gcode.sendGCodeLine(param);
                    Thread.Sleep(200);
                    gcode.sendGCodeLine("$$");
                    ProcessCmdKey = true;
                    return ProcessCmdKey;
                }
                if (this.tbWorkX.ContainsFocus)
                {
                    this.SendOffsets(this.lblPositionCurrentOffset.Text + "X", this.tbWorkX.Text);
                    this.tabCtlPosition.Focus();
                    ProcessCmdKey = true;
                    return ProcessCmdKey;
                }
                if (this.tbWorkY.ContainsFocus)
                {
                    this.SendOffsets(this.lblPositionCurrentOffset.Text + "Y", this.tbWorkY.Text);
                    this.tabCtlPosition.Focus();
                    ProcessCmdKey = true;
                    return ProcessCmdKey;
                }
                if (this.tbWorkZ.ContainsFocus)
                {
                    this.SendOffsets(this.lblPositionCurrentOffset.Text + "Z", this.tbWorkZ.Text);
                    this.tabCtlPosition.Focus();
                    ProcessCmdKey = true;
                    return ProcessCmdKey;
                }
            }
            ProcessCmdKey = base.ProcessCmdKey(ref msg, keyData);
            return ProcessCmdKey;
        }

        private void SwitchSides(bool side)
        {
            checked
            {
                int left_X = this.gbJogging.Width + 3;
                int right_X = this.gbPosition.Width + 3;
                if (side)
                {
                    GroupBox[] array = new GroupBox[]
                    {
                        this.gbGrbl,
                        this.gbJogging,
                        this.gbGcode
                    };
                    for (int i = 0; i < array.Length; i++)
                    {
                        Control ctl = array[i];
                        ctl.Location = new Point(3, ctl.Location.Y);
                    }
                    this.gbMDI.Location = new Point(3 + this.gbGrbl.Width + 3, this.gbMDI.Location.Y);
                    GroupBox[] array2 = new GroupBox[]
                    {
                        this.gbPosition,
                        this.gbStatus,
                        this.gbControl
                    };
                    for (int j = 0; j < array2.Length; j++)
                    {
                        Control ctl = array2[j];
                        ctl.Location = new Point(3 + left_X, ctl.Location.Y);
                    }
                    return;
                }
                GroupBox[] array3 = new GroupBox[]
                {
                    this.gbGrbl,
                    this.gbJogging,
                    this.gbGcode
                };
                for (int k = 0; k < array3.Length; k++)
                {
                    Control ctl = array3[k];
                    ctl.Location = new Point(3 + right_X, ctl.Location.Y);
                }
                this.gbMDI.Location = new Point(3 + right_X + this.gbGrbl.Width + 3, this.gbMDI.Location.Y);
                GroupBox[] array4 = new GroupBox[]
                {
                    this.gbPosition,
                    this.gbStatus,
                    this.gbControl
                };
                for (int l = 0; l < array4.Length; l++)
                {
                    Control ctl = array4[l];
                    ctl.Location = new Point(3, ctl.Location.Y);
                }
            }
        }

        private void cbSettingsLeftHanded_CheckedChanged(object sender, EventArgs e)
        {
            this.SwitchSides(this.cbSettingsLeftHanded.Checked);
        }

        private void lbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.grblPort.Comport = Convert.ToString(this.cbPorts.SelectedItem);
            MySettingsProperty.Settings.Port = Convert.ToString(this.cbPorts.SelectedItem);
            this.btnConnect.Enabled = true;
        }

        private void cbBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.grblPort.Baudrate = Convert.ToInt32(this.cbBaud.SelectedItem.ToString());
            MySettingsProperty.Settings.Baud = Convert.ToString(this.grblPort.Baudrate);
            MySettingsProperty.Settings.Save();
            this.btnConnect.Enabled = true;
        }

        private void btnConnDisconnect_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string text = btn.Text;
            if (String.Compare(text, Resources.Button_Connection_Text_Connect, false) == 0)
            {
                string left = (string)btn.Tag;
                bool connected;
                if (String.Compare(left, "COM", false) != 0)
                {
                    if (String.Compare(left, "IP", false) == 0)
                    {
                        if (this.tbIPAddress.TextLength <= 0)
                        {
                            MessageBox.Show(Resources.GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + "\r" + Resources.GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + "\r\"<ip address>:<port number>\"", Resources.GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK);
                            return;
                        }
                        string[] address = this.tbIPAddress.Text.Split(new string[]
                        {
                            ":"
                        }, StringSplitOptions.RemoveEmptyEntries);
                        this.grblPort.IpAddress = IPAddress.Parse(address[0]);
                        this.grblPort.PortNum = int.Parse(address[1]);
                        if (this.grblPort.PortNum == 0)
                        {
                            MessageBox.Show(Resources.GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + "\r" + Resources.GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + "\r\"<ip address>:<port number>\"", Resources.GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK);
                            return;
                        }
                        connected = this.grblPort.Connect(GrblIF.ConnectionType.IP);
                        if (!connected)
                        {
                            MessageBox.Show(Resources.GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + "\r" + Resources.GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + "\r\"<ip address>:<port number>\"", Resources.GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK);
                            return;
                        }
                        btn.Text = Resources.GrblGui_btnConnDisconnect_Click_Disconnect;
                        this.btnConnect.Enabled = false;
                    }
                }
                else
                {
                    connected = this.grblPort.Connect(GrblIF.ConnectionType.Serial);
                    if (!connected)
                    {
                        MessageBox.Show(Resources.GrblGui_btnConnDisconnect_Click_PleaseSelectAComPort + "\r" + Resources.GrblGui_btnConnDisconnect_Click_OrConnectTheCable, Resources.GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK);
                        this.grblPort.Rescan();
                        return;
                    }
                    btn.Text = Resources.GrblGui_btnConnDisconnect_Click_Disconnect;
                    this.btnIPConnect.Enabled = false;
                }
                if (connected)
                {
                    this.status.enableStatus(true);
                    Thread.Sleep(checked((int)Math.Round(unchecked(Conversions.ToDouble(this.tbSettingsStartupDelay.Text) * 1000.0))));
                    gcode.enableGCode(true);
                    this.jogging.enableJogging(true);
                    this.position.enablePosition(true);
                    this.offsets.enableOffsets(true);
                    this.state.EnableState(true);
                    this.settings.EnableState(true);
                    ConnectedEventHandler connectedEvent = this.ConnectedEvent;
                    if (connectedEvent != null)
                    {
                        connectedEvent("Connected");
                    }
                    this.setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Idle);
                    this.statusPrompt(Resources.MsgFilter_PreFilterMessage_Start);
                    return;
                }
            }
            else
            {
                if (String.Compare(text, Resources.GrblGui_btnConnDisconnect_Click_Disconnect, false) == 0)
                {
                    this.grblPort.Disconnect();
                    this.btnConnect.Text = Resources.Button_Connection_Text_Connect;
                    this.btnIPConnect.Text = Resources.Button_Connection_Text_Connect;
                    this.btnConnect.Enabled = true;
                    this.btnIPConnect.Enabled = true;
                    this.statusPrompt(Resources.GrblGui_btnConnDisconnect_Click_End);
                    this.status.enableStatus(false);
                    this.jogging.enableJogging(false);
                    this.position.enablePosition(false);
                    gcode.enableGCode(false);
                    this.offsets.enableOffsets(false);
                    this.state.EnableState(false);
                    this.settings.EnableState(false);
                    ConnectedEventHandler connectedEvent2 = this.ConnectedEvent;
                    if (connectedEvent2 != null)
                    {
                        connectedEvent2("Disconnected");
                    }
                    this.setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Disconnected);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            gcode.sendGCodeLine(this.tbSendData.Text);
        }

        private void tbSendData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                gcode.sendGCodeLine(this.tbSendData.Text);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.AboutBox.ShowDialog();
            MyProject.Forms.AboutBox.BringToFront();
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = this.tabPgSettings;
            this.TabControl1.SelectedTab.Show();
        }

        private void btnFileSend_MouseHover(object sender, EventArgs e)
        {
        }

        private void rescanPorts()
        {
            ComboBox expr_06 = this.cbPorts;
            expr_06.Items.Clear();
            expr_06.Items.AddRange(this.grblPort.Rescan());
        }

        private void btnRescanPorts_Click(object sender, EventArgs e)
        {
            this.rescanPorts();
        }

        public void enableGrbl(bool action)
        {
            this.gbGrbl.Enabled = action;
        }

        public void setSubPanels(string active)
        {
            if (String.Compare(active, "GCodeStream", false) == 0)
            {
                this.gbJogging.Enabled = false;
                this.gbPosition.Enabled = false;
                this.gbMDI.Enabled = false;
                this.gbGrbl.Enabled = false;
                this.gbState.Enabled = false;
                this.gbSettingsJogging.Enabled = false;
                this.gbSettingsMisc.Enabled = false;
                this.gbSettingsOffsets.Enabled = false;
                this.gbSettingsPosition.Enabled = false;
                this.gbGrblSettings.Enabled = false;
                this.btnStatusClearPins.Enabled = false;
                return;
            }
            if (String.Compare(active, Resources.GrblGui_btnConnDisconnect_Click_Disconnected, false) == 0)
            {
                this.gbJogging.Enabled = false;
                this.gbPosition.Enabled = false;
                this.gbMDI.Enabled = false;
                this.gbGrbl.Enabled = true;
                this.gbState.Enabled = false;
                this.gbSettingsJogging.Enabled = false;
                this.gbSettingsMisc.Enabled = false;
                this.gbSettingsOffsets.Enabled = false;
                this.gbSettingsPosition.Enabled = false;
                this.gbGrblSettings.Enabled = false;
                this.btnStatusClearPins.Enabled = false;
                return;
            }
            if (String.Compare(active, Resources.GrblGui_btnConnDisconnect_Click_Idle, false) == 0)
            {
                this.gbJogging.Enabled = true;
                this.gbPosition.Enabled = true;
                this.gbMDI.Enabled = true;
                this.gbGrbl.Enabled = true;
                this.gbState.Enabled = true;
                this.gbSettingsJogging.Enabled = true;
                this.gbSettingsMisc.Enabled = true;
                this.gbSettingsOffsets.Enabled = true;
                this.gbSettingsPosition.Enabled = true;
                this.gbGrblSettings.Enabled = true;
                this.btnStatusClearPins.Enabled = true;
            }
        }

        private void EnableMacroButtons()
        {
            int iButtonMargin = 7;
            int iButtonRowSum = 0;
            int iButtonRowTop = 62;
            Size DefaultDimension = new Size(58, 20);
            checked
            {
                for (int iLoopCounter = this.gbMDI.Controls.Count - 1; iLoopCounter >= 0; iLoopCounter += -1)
                {
                    Control mButton = this.gbMDI.Controls[iLoopCounter];
                    if (LikeOperator.LikeString(mButton.Name, "btnMacro*", CompareMethod.Binary))
                    {
                        this.gbMDI.Controls.Remove(mButton);
                        mButton.Dispose();
                    }
                }
                string[] array = this.GetmacroNames();
                for (int i = 0; i < array.Length; i++)
                {
                    string item = array[i];
                    string[] macro = Strings.Split(Convert.ToString(MySettingsProperty.Settings[item]), ":", -1, CompareMethod.Binary);
                    if (macro.Count<string>() == 2)
                    {
                        int iButtonCounter;
                        Button b = new Button
                        {
                            Size = DefaultDimension,
                            Location = new Point(iButtonRowSum + iButtonMargin, iButtonRowTop),
                            Name = "btnMacro" + Convert.ToString(iButtonCounter),
                            Text = macro[0].ToString(),
                            Tag = macro[1].ToString()
                        };
                        b.Click += new EventHandler(this.MacroButton_Click);
                        this.gbMDI.Controls.Add(b);
                        iButtonRowSum += iButtonMargin + b.Width;
                        iButtonCounter++;
                    }
                }
            }
        }

        private void MacroButton_Click(object sender, EventArgs e)
        {
            string[] aData = Strings.Split(Strings.Trim(Convert.ToString(((Button)sender).Tag)), "\r\n", -1, CompareMethod.Binary);
            checked
            {
                int num = aData.Count<string>() - 1;
                for (int iCounter = 0; iCounter <= num; iCounter++)
                {
                    gcode.sendGCodeLine(aData[iCounter]);
                }
            }
        }

        private void tbWorkX_TextChanged(object sender, EventArgs e)
        {
            string Index = "";
            TextBox sndr = (TextBox)sender;
            string left = this.lblPositionCurrentOffset.Text.Substring(0, 3);
            if (String.Compare(left, "G54", false) != 0)
            {
                if (String.Compare(left, "G55", false) != 0)
                {
                    if (String.Compare(left, "G56", false) != 0)
                    {
                        if (String.Compare(left, "G57", false) != 0)
                        {
                            if (String.Compare(left, "G58", false) != 0)
                            {
                                if (String.Compare(left, "G59", false) == 0)
                                {
                                    Index = "P6";
                                }
                            }
                            else
                            {
                                Index = "P5";
                            }
                        }
                        else
                        {
                            Index = "P4";
                        }
                    }
                    else
                    {
                        Index = "P3";
                    }
                }
                else
                {
                    Index = "P2";
                }
            }
            else
            {
                Index = "P1";
            }
            gcode.sendGCodeLine(string.Concat(new string[]
            {
                "G10 L2 ",
                Index,
                " ",
                sndr.Tag.ToString(),
                sndr.Text
            }));
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.components != null)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(GrblGui));
            MySettings MySettings4 = new MySettings();
            this.MenuStrip1 = new MenuStrip();
            this.ToolStripMenuItem1 = new ToolStripMenuItem();
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            this.ExitToolStripMenuItem = new ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new ToolStripMenuItem();
            this.HelpToolStripMenuItem = new ToolStripMenuItem();
            this.AboutToolStripMenuItem = new ToolStripMenuItem();
            this.TabControl1 = new TabControl();
            this.tabPgInterface = new TabPage();
            this.gbOverrides = new GroupBox();
            this.btnMistOverride = new Button();
            this.btnFloodOverride = new Button();
            this.btnSpindleOverride = new Button();
            this.cbSpindleCoarse = new CheckBox();
            this.btnSpindleOverrideReset = new Button();
            this.btnRapidOverride25 = new Button();
            this.btnFeedOverrideReset = new Button();
            this.cbFeedCoarse = new CheckBox();
            this.Label44 = new Label();
            this.btnSpindleMinus = new Button();
            this.btnSpindlePlus = new Button();
            this.Label22 = new Label();
            this.btnRapidOverride50 = new Button();
            this.btnRapidOverrideReset = new Button();
            this.tbSpindleOvr = new TextBox();
            this.tbRapidOvr = new TextBox();
            this.tbFeedOvr = new TextBox();
            this.Label46 = new Label();
            this.btnFeedMinus = new Button();
            this.btnFeedPlus = new Button();
            this.gbState = new GroupBox();
            this.gbPinStatus = new GroupBox();
            this.cbFeedHold = new CheckBox();
            this.cbStartResume = new CheckBox();
            this.cbResetAbort = new CheckBox();
            this.btnStatusClearPins = new Button();
            this.cbLimitX = new CheckBox();
            this.cbDoorOpen = new CheckBox();
            this.cbProbePin = new CheckBox();
            this.cbLimitZ = new CheckBox();
            this.cbLimitY = new CheckBox();
            this.Panel2 = new Panel();
            this.tbStateFeedRate = new TextBox();
            this.Label14 = new Label();
            this.tbStateTool = new TextBox();
            this.Label53 = new Label();
            this.Label50 = new Label();
            this.tbStateSpindleRPM = new TextBox();
            this.Panel1 = new Panel();
            this.cbxStateFeedMode = new ComboBox();
            this.cbxStateDistance = new ComboBox();
            this.Label16 = new Label();
            this.cbxStateUnits = new ComboBox();
            this.Label123 = new Label();
            this.Lalbel49 = new Label();
            this.cbxStatePlane = new ComboBox();
            this.Label47 = new Label();
            this.Label15 = new Label();
            this.cbxStateOffset = new ComboBox();
            this.cbxStateCoolant = new ComboBox();
            this.Label45 = new Label();
            this.Label17 = new Label();
            this.cbxStateSpindle = new ComboBox();
            this.gbControl = new GroupBox();
            this.btnCheckMode = new Button();
            this.btnReset = new Button();
            this.btnHold = new Button();
            this.btnStartResume = new Button();
            this.btnUnlock = new Button();
            this.gbMDI = new GroupBox();
            this.Label9 = new Label();
            this.btnSend = new Button();
            this.tbSendData = new TextBox();
            this.gbJogging = new GroupBox();
            this.btnZMinus = new RepeatButton();
            this.btnZPlus = new RepeatButton();
            this.btnXPlus = new RepeatButton();
            this.btnYMinus = new RepeatButton();
            this.btnXMinus = new RepeatButton();
            this.btnYPlus = new RepeatButton();
            this.gbFeedRate = new GroupBox();
            this.rbFeedRate1 = new RadioButton();
            this.rbFeedRate2 = new RadioButton();
            this.rbFeedRate3 = new RadioButton();
            this.rbFeedRate4 = new RadioButton();
            this.gbDistance = new GroupBox();
            this.rbDistance1 = new RadioButton();
            this.rbDistance2 = new RadioButton();
            this.rbDistance3 = new RadioButton();
            this.rbDistance4 = new RadioButton();
            this.cbUnits = new CheckBox();
            this.gbStatus = new GroupBox();
            this.Label25 = new Label();
            this.tbCurrentStatus = new TextBox();
            this.Label24 = new Label();
            this.prgbRxBuf = new ProgressBar();
            this.prgBarQ = new ProgressBar();
            this.cbVerbose = new CheckBox();
            this.lbResponses = new ListBox();
            this.gbGcode = new GroupBox();
            this.btnFileStep = new Button();
            this.cbMonitorEnable = new CheckBox();
            this.lblElapsedTime = new Label();
            this.Label23 = new Label();
            this.Label51 = new Label();
            this.lblCurrentLine = new Label();
            this.dgvGcode = new DataGridView();
            this.stat = new DataGridViewTextBoxColumn();
            this.lineNum = new DataGridViewTextBoxColumn();
            this.data = new DataGridViewTextBoxColumn();
            this.btnFileReload = new Button();
            this.tbGCodeMessage = new TextBox();
            this.Label27 = new Label();
            this.lblTotalLines = new Label();
            this.btnFilePause = new Button();
            this.tbGcodeFile = new TextBox();
            this.btnFileSelect = new Button();
            this.btnFileSend = new Button();
            this.btnFileStop = new Button();
            this.gbGrbl = new GroupBox();
            this.tcConnection = new TabControl();
            this.tbGrblCOM = new TabPage();
            this.btnRescanPorts = new Button();
            this.cbPorts = new ComboBox();
            this.btnConnect = new Button();
            this.cbBaud = new ComboBox();
            this.tbGrblIP = new TabPage();
            this.btnIPConnect = new Button();
            this.tbIPAddress = new TextBox();
            this.gbPosition = new GroupBox();
            this.tabCtlPosition = new TabControl();
            this.tpWork = new TabPage();
            this.Panel5 = new Panel();
            this.tbWorkZ = new TextBox();
            this.tbMachZ = new TextBox();
            this.Panel4 = new Panel();
            this.tbWorkY = new TextBox();
            this.tbMachY = new TextBox();
            this.Panel3 = new Panel();
            this.tbMachX = new TextBox();
            this.tbWorkX = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.lblPositionCurrentOffset = new Label();
            this.btnWorkSoftHome = new Button();
            this.btnHome = new Button();
            this.btnWorkSpclPosition = new Button();
            this.Label3 = new Label();
            this.btnWork0 = new Button();
            this.Label2 = new Label();
            this.btnWorkX0 = new Button();
            this.Label1 = new Label();
            this.btnWorkZ0 = new Button();
            this.btnWorkY0 = new Button();
            this.tpOffsets = new TabPage();
            this.btnSetOffsetG59 = new Button();
            this.btnSetOffsetG58 = new Button();
            this.btnSetOffsetG57 = new Button();
            this.btnSetOffsetG56 = new Button();
            this.btnSetOffsetG55 = new Button();
            this.btnSetOffsetG54 = new Button();
            this.Label10 = new Label();
            this.Label71 = new Label();
            this.tbOffSetsMachZ = new TextBox();
            this.Label19 = new Label();
            this.tbOffsetsG56Y = new TextBox();
            this.tbOffSetsMachY = new TextBox();
            this.tbOffsetsG56X = new TextBox();
            this.tbOffsetsG56Z = new TextBox();
            this.tbOffSetsMachX = new TextBox();
            this.btnOffsetsG57Zero = new Button();
            this.tbOffsetsG54X = new TextBox();
            this.btnOffsetsG56Zero = new Button();
            this.tbOffsetsG54Y = new TextBox();
            this.tbOffsetsG57Z = new TextBox();
            this.btnOffsetsSave = new Button();
            this.tbOffsetsG55X = new TextBox();
            this.tbOffsetsG54Z = new TextBox();
            this.tbOffsetsG57Y = new TextBox();
            this.btnOffsetsRetrieve = new Button();
            this.tbOffsetsG55Y = new TextBox();
            this.btnOffsetsG54Zero = new Button();
            this.tbOffsetsG57X = new TextBox();
            this.btnOffsetsLoad = new Button();
            this.tbOffsetsG55Z = new TextBox();
            this.tbOffsetsG59X = new TextBox();
            this.btnOffsetsG58Zero = new Button();
            this.btnOffsetsG43Zero = new Button();
            this.tbOffsetsG59Y = new TextBox();
            this.tbOffsetsG43Z = new TextBox();
            this.btnOffsetsG55Zero = new Button();
            this.tbOffsetsG59Z = new TextBox();
            this.tbOffsetsG58Z = new TextBox();
            this.Label60 = new Label();
            this.tbOffsetsG58Y = new TextBox();
            this.Label20 = new Label();
            this.Label43 = new Label();
            this.btnOffsetsG59Zero = new Button();
            this.tbOffsetsG58X = new TextBox();
            this.Label21 = new Label();
            this.tabPgSettings = new TabPage();
            this.gbMiscInfo = new GroupBox();
            this.Label49 = new Label();
            this.tbGrblOptions = new TextBox();
            this.Label48 = new Label();
            this.tbGrblVersion = new TextBox();
            this.gbGrblSettings = new GroupBox();
            this.Label4 = new Label();
            this.tbSettingsGrblLastParam = new TextBox();
            this.dgGrblSettings = new DataGridView();
            this.btnSettingsGrbl = new Button();
            this.gbSettingsOffsets = new GroupBox();
            this.btnOffsetsG28Set = new Button();
            this.btnSettingsRetrieveLocations = new Button();
            this.Label7 = new Label();
            this.Label18 = new Label();
            this.tbOffsetsG30Y = new TextBox();
            this.tbOffsetsG30X = new TextBox();
            this.tbOffsetsG30Z = new TextBox();
            this.tbOffsetsG28X = new TextBox();
            this.btnOffsetsG30Set = new Button();
            this.tbOffsetsG28Y = new TextBox();
            this.Label68 = new Label();
            this.tbOffsetsG28Z = new TextBox();
            this.Label69 = new Label();
            this.Label42 = new Label();
            this.gbSettingsMisc = new GroupBox();
            this.Label52 = new Label();
            this.tbTruncationDigits = new TextBox();
            this.tbSettingsDefaultExt = new TextBox();
            this.Label5 = new Label();
            this.Label6 = new Label();
            this.tbSettingsStartupDelay = new TextBox();
            this.cbSettingsLeftHanded = new CheckBox();
            this.cbSettingsConnectOnLoad = new CheckBox();
            this.cbSettingsPauseOnError = new CheckBox();
            this.cbStatusPollEnable = new CheckBox();
            this.btnSettingsRefreshMisc = new Button();
            this.Label37 = new Label();
            this.Label36 = new Label();
            this.tbSettingsRBuffSize = new TextBox();
            this.tbSettingsQSize = new TextBox();
            this.Label26 = new Label();
            this.tbSettingsPollRate = new TextBox();
            this.gbSettingsPosition = new GroupBox();
            this.Label8 = new Label();
            this.tbSettingsSpclPosition2 = new TextBox();
            this.btnSettingsRefreshPosition = new Button();
            this.Label29 = new Label();
            this.tbWorkZ0Cmd = new TextBox();
            this.Label28 = new Label();
            this.tbWorkY0Cmd = new TextBox();
            this.Label13 = new Label();
            this.Label12 = new Label();
            this.tbWorkX0Cmd = new TextBox();
            this.tbSettingsZeroXYZCmd = new TextBox();
            this.Label11 = new Label();
            this.tbSettingsSpclPosition1 = new TextBox();
            this.gbSettingsJogging = new GroupBox();
            this.cbSettingsKeyboardJogging = new CheckBox();
            this.btnSettingsRefreshJogging = new Button();
            this.Label41 = new Label();
            this.Label40 = new Label();
            this.Label39 = new Label();
            this.Label38 = new Label();
            this.tbSettingsZRepeat = new TextBox();
            this.tbSettingsYRepeat = new TextBox();
            this.tbSettingsXRepeat = new TextBox();
            this.Label35 = new Label();
            this.Label34 = new Label();
            this.Label32 = new Label();
            this.tbSettingsFRMetric = new TextBox();
            this.Label33 = new Label();
            this.tbSettingsFIMetric = new TextBox();
            this.Label31 = new Label();
            this.tbSettingsFRImperial = new TextBox();
            this.Label30 = new Label();
            this.cbSettingsMetric = new CheckBox();
            this.tbSettingsFIImperial = new TextBox();
            this.TabPage1 = new TabPage();
            this.gbEditor = new GroupBox();
            this.btnAdd = new Button();
            this.lblGCode = new Label();
            this.tbGCode = new TextBox();
            this.lblName = new Label();
            this.tbName = new TextBox();
            this.btnCancel = new Button();
            this.btnOK = new Button();
            this.dgMacros = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.lblStatusLabel = new Label();
            this.btnDeleteMacro = new Button();
            this.ofdGcodeFile = new OpenFileDialog();
            this.ToolTip1 = new ToolTip(this.components);
            this.sfdOffsets = new SaveFileDialog();
            this.ofdOffsets = new OpenFileDialog();
            this.GrblSettingsBindingSource = new BindingSource(this.components);
            this.MenuStrip1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabPgInterface.SuspendLayout();
            this.gbOverrides.SuspendLayout();
            this.gbState.SuspendLayout();
            this.gbPinStatus.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbMDI.SuspendLayout();
            this.gbJogging.SuspendLayout();
            this.gbFeedRate.SuspendLayout();
            this.gbDistance.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbGcode.SuspendLayout();
            ((ISupportInitialize)this.dgvGcode).BeginInit();
            this.gbGrbl.SuspendLayout();
            this.tcConnection.SuspendLayout();
            this.tbGrblCOM.SuspendLayout();
            this.tbGrblIP.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.tabCtlPosition.SuspendLayout();
            this.tpWork.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.tpOffsets.SuspendLayout();
            this.tabPgSettings.SuspendLayout();
            this.gbMiscInfo.SuspendLayout();
            this.gbGrblSettings.SuspendLayout();
            ((ISupportInitialize)this.dgGrblSettings).BeginInit();
            this.gbSettingsOffsets.SuspendLayout();
            this.gbSettingsMisc.SuspendLayout();
            this.gbSettingsPosition.SuspendLayout();
            this.gbSettingsJogging.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.gbEditor.SuspendLayout();
            ((ISupportInitialize)this.dgMacros).BeginInit();
            ((ISupportInitialize)this.GrblSettingsBindingSource).BeginInit();
            base.SuspendLayout();
            this.MenuStrip1.GripStyle = ToolStripGripStyle.Visible;
            this.MenuStrip1.Items.AddRange(new ToolStripItem[]
            {
                this.ToolStripMenuItem1,
                this.ToolsToolStripMenuItem,
                this.HelpToolStripMenuItem
            });
            resources.ApplyResources(this.MenuStrip1, "MenuStrip1");
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            this.ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.SaveToolStripMenuItem,
                this.ExitToolStripMenuItem
            });
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            resources.ApplyResources(this.ToolStripMenuItem1, "ToolStripMenuItem1");
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            resources.ApplyResources(this.SaveToolStripMenuItem, "SaveToolStripMenuItem");
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.OptionsToolStripMenuItem
            });
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            resources.ApplyResources(this.ToolsToolStripMenuItem, "ToolsToolStripMenuItem");
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            resources.ApplyResources(this.OptionsToolStripMenuItem, "OptionsToolStripMenuItem");
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.AboutToolStripMenuItem
            });
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            resources.ApplyResources(this.HelpToolStripMenuItem, "HelpToolStripMenuItem");
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            resources.ApplyResources(this.TabControl1, "TabControl1");
            this.TabControl1.Controls.Add(this.tabPgInterface);
            this.TabControl1.Controls.Add(this.tabPgSettings);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.tabPgInterface.Controls.Add(this.gbOverrides);
            this.tabPgInterface.Controls.Add(this.gbState);
            this.tabPgInterface.Controls.Add(this.gbControl);
            this.tabPgInterface.Controls.Add(this.gbMDI);
            this.tabPgInterface.Controls.Add(this.gbJogging);
            this.tabPgInterface.Controls.Add(this.gbStatus);
            this.tabPgInterface.Controls.Add(this.gbGcode);
            this.tabPgInterface.Controls.Add(this.gbGrbl);
            this.tabPgInterface.Controls.Add(this.gbPosition);
            resources.ApplyResources(this.tabPgInterface, "tabPgInterface");
            this.tabPgInterface.Name = "tabPgInterface";
            this.tabPgInterface.UseVisualStyleBackColor = true;
            this.gbOverrides.Controls.Add(this.btnMistOverride);
            this.gbOverrides.Controls.Add(this.btnFloodOverride);
            this.gbOverrides.Controls.Add(this.btnSpindleOverride);
            this.gbOverrides.Controls.Add(this.cbSpindleCoarse);
            this.gbOverrides.Controls.Add(this.btnSpindleOverrideReset);
            this.gbOverrides.Controls.Add(this.btnRapidOverride25);
            this.gbOverrides.Controls.Add(this.btnFeedOverrideReset);
            this.gbOverrides.Controls.Add(this.cbFeedCoarse);
            this.gbOverrides.Controls.Add(this.Label44);
            this.gbOverrides.Controls.Add(this.btnSpindleMinus);
            this.gbOverrides.Controls.Add(this.btnSpindlePlus);
            this.gbOverrides.Controls.Add(this.Label22);
            this.gbOverrides.Controls.Add(this.btnRapidOverride50);
            this.gbOverrides.Controls.Add(this.btnRapidOverrideReset);
            this.gbOverrides.Controls.Add(this.tbSpindleOvr);
            this.gbOverrides.Controls.Add(this.tbRapidOvr);
            this.gbOverrides.Controls.Add(this.tbFeedOvr);
            this.gbOverrides.Controls.Add(this.Label46);
            this.gbOverrides.Controls.Add(this.btnFeedMinus);
            this.gbOverrides.Controls.Add(this.btnFeedPlus);
            resources.ApplyResources(this.gbOverrides, "gbOverrides");
            this.gbOverrides.Name = "gbOverrides";
            this.gbOverrides.TabStop = false;
            resources.ApplyResources(this.btnMistOverride, "btnMistOverride");
            this.btnMistOverride.Name = "btnMistOverride";
            this.btnMistOverride.TabStop = false;
            this.btnMistOverride.Tag = "MistOverride";
            this.btnMistOverride.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnFloodOverride, "btnFloodOverride");
            this.btnFloodOverride.Name = "btnFloodOverride";
            this.btnFloodOverride.Tag = "FloodOverride";
            this.btnFloodOverride.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSpindleOverride, "btnSpindleOverride");
            this.btnSpindleOverride.Name = "btnSpindleOverride";
            this.btnSpindleOverride.Tag = "SpindleOverride";
            this.btnSpindleOverride.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.cbSpindleCoarse, "cbSpindleCoarse");
            this.cbSpindleCoarse.Checked = true;
            this.cbSpindleCoarse.CheckState = CheckState.Checked;
            this.cbSpindleCoarse.Name = "cbSpindleCoarse";
            this.cbSpindleCoarse.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSpindleOverrideReset, "btnSpindleOverrideReset");
            this.btnSpindleOverrideReset.Name = "btnSpindleOverrideReset";
            this.btnSpindleOverrideReset.Tag = "Spindle";
            this.btnSpindleOverrideReset.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnRapidOverride25, "btnRapidOverride25");
            this.btnRapidOverride25.Name = "btnRapidOverride25";
            this.btnRapidOverride25.Tag = "25";
            this.btnRapidOverride25.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnFeedOverrideReset, "btnFeedOverrideReset");
            this.btnFeedOverrideReset.Name = "btnFeedOverrideReset";
            this.btnFeedOverrideReset.Tag = "Feed";
            this.btnFeedOverrideReset.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.cbFeedCoarse, "cbFeedCoarse");
            this.cbFeedCoarse.Checked = true;
            this.cbFeedCoarse.CheckState = CheckState.Checked;
            this.cbFeedCoarse.Name = "cbFeedCoarse";
            this.cbFeedCoarse.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label44, "Label44");
            this.Label44.Name = "Label44";
            resources.ApplyResources(this.btnSpindleMinus, "btnSpindleMinus");
            this.btnSpindleMinus.Name = "btnSpindleMinus";
            this.btnSpindleMinus.Tag = "minus";
            this.btnSpindleMinus.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSpindlePlus, "btnSpindlePlus");
            this.btnSpindlePlus.Name = "btnSpindlePlus";
            this.btnSpindlePlus.Tag = "plus";
            this.btnSpindlePlus.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label22, "Label22");
            this.Label22.Name = "Label22";
            resources.ApplyResources(this.btnRapidOverride50, "btnRapidOverride50");
            this.btnRapidOverride50.Name = "btnRapidOverride50";
            this.btnRapidOverride50.Tag = "50";
            this.btnRapidOverride50.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnRapidOverrideReset, "btnRapidOverrideReset");
            this.btnRapidOverrideReset.Name = "btnRapidOverrideReset";
            this.btnRapidOverrideReset.Tag = "Rapid";
            this.btnRapidOverrideReset.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbSpindleOvr, "tbSpindleOvr");
            this.tbSpindleOvr.Name = "tbSpindleOvr";
            resources.ApplyResources(this.tbRapidOvr, "tbRapidOvr");
            this.tbRapidOvr.Name = "tbRapidOvr";
            resources.ApplyResources(this.tbFeedOvr, "tbFeedOvr");
            this.tbFeedOvr.Name = "tbFeedOvr";
            resources.ApplyResources(this.Label46, "Label46");
            this.Label46.Name = "Label46";
            resources.ApplyResources(this.btnFeedMinus, "btnFeedMinus");
            this.btnFeedMinus.Name = "btnFeedMinus";
            this.btnFeedMinus.Tag = "minus";
            this.btnFeedMinus.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnFeedPlus, "btnFeedPlus");
            this.btnFeedPlus.Name = "btnFeedPlus";
            this.btnFeedPlus.Tag = "plus";
            this.btnFeedPlus.UseVisualStyleBackColor = true;
            this.gbState.Controls.Add(this.gbPinStatus);
            this.gbState.Controls.Add(this.Panel2);
            this.gbState.Controls.Add(this.Panel1);
            resources.ApplyResources(this.gbState, "gbState");
            this.gbState.Name = "gbState";
            this.gbState.TabStop = false;
            this.gbPinStatus.Controls.Add(this.cbFeedHold);
            this.gbPinStatus.Controls.Add(this.cbStartResume);
            this.gbPinStatus.Controls.Add(this.cbResetAbort);
            this.gbPinStatus.Controls.Add(this.btnStatusClearPins);
            this.gbPinStatus.Controls.Add(this.cbLimitX);
            this.gbPinStatus.Controls.Add(this.cbDoorOpen);
            this.gbPinStatus.Controls.Add(this.cbProbePin);
            this.gbPinStatus.Controls.Add(this.cbLimitZ);
            this.gbPinStatus.Controls.Add(this.cbLimitY);
            resources.ApplyResources(this.gbPinStatus, "gbPinStatus");
            this.gbPinStatus.Name = "gbPinStatus";
            this.gbPinStatus.TabStop = false;
            this.cbFeedHold.AutoCheck = false;
            resources.ApplyResources(this.cbFeedHold, "cbFeedHold");
            this.cbFeedHold.Name = "cbFeedHold";
            this.ToolTip1.SetToolTip(this.cbFeedHold, resources.GetString("cbFeedHold.ToolTip"));
            this.cbFeedHold.UseVisualStyleBackColor = true;
            this.cbStartResume.AutoCheck = false;
            resources.ApplyResources(this.cbStartResume, "cbStartResume");
            this.cbStartResume.Name = "cbStartResume";
            this.ToolTip1.SetToolTip(this.cbStartResume, resources.GetString("cbStartResume.ToolTip"));
            this.cbStartResume.UseVisualStyleBackColor = true;
            this.cbResetAbort.AutoCheck = false;
            resources.ApplyResources(this.cbResetAbort, "cbResetAbort");
            this.cbResetAbort.Name = "cbResetAbort";
            this.ToolTip1.SetToolTip(this.cbResetAbort, resources.GetString("cbResetAbort.ToolTip"));
            this.cbResetAbort.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnStatusClearPins, "btnStatusClearPins");
            this.btnStatusClearPins.Name = "btnStatusClearPins";
            this.btnStatusClearPins.UseVisualStyleBackColor = true;
            this.cbLimitX.AutoCheck = false;
            resources.ApplyResources(this.cbLimitX, "cbLimitX");
            this.cbLimitX.Name = "cbLimitX";
            this.ToolTip1.SetToolTip(this.cbLimitX, resources.GetString("cbLimitX.ToolTip"));
            this.cbLimitX.UseVisualStyleBackColor = true;
            this.cbDoorOpen.AutoCheck = false;
            resources.ApplyResources(this.cbDoorOpen, "cbDoorOpen");
            this.cbDoorOpen.Name = "cbDoorOpen";
            this.ToolTip1.SetToolTip(this.cbDoorOpen, resources.GetString("cbDoorOpen.ToolTip"));
            this.cbDoorOpen.UseVisualStyleBackColor = true;
            this.cbProbePin.AutoCheck = false;
            resources.ApplyResources(this.cbProbePin, "cbProbePin");
            this.cbProbePin.Name = "cbProbePin";
            this.ToolTip1.SetToolTip(this.cbProbePin, resources.GetString("cbProbePin.ToolTip"));
            this.cbProbePin.UseVisualStyleBackColor = true;
            this.cbLimitZ.AutoCheck = false;
            resources.ApplyResources(this.cbLimitZ, "cbLimitZ");
            this.cbLimitZ.Name = "cbLimitZ";
            this.ToolTip1.SetToolTip(this.cbLimitZ, resources.GetString("cbLimitZ.ToolTip"));
            this.cbLimitZ.UseVisualStyleBackColor = true;
            this.cbLimitY.AutoCheck = false;
            resources.ApplyResources(this.cbLimitY, "cbLimitY");
            this.cbLimitY.Name = "cbLimitY";
            this.ToolTip1.SetToolTip(this.cbLimitY, resources.GetString("cbLimitY.ToolTip"));
            this.cbLimitY.UseVisualStyleBackColor = true;
            this.Panel2.BorderStyle = BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.tbStateFeedRate);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.tbStateTool);
            this.Panel2.Controls.Add(this.Label53);
            this.Panel2.Controls.Add(this.Label50);
            this.Panel2.Controls.Add(this.tbStateSpindleRPM);
            resources.ApplyResources(this.Panel2, "Panel2");
            this.Panel2.Name = "Panel2";
            resources.ApplyResources(this.tbStateFeedRate, "tbStateFeedRate");
            this.tbStateFeedRate.Name = "tbStateFeedRate";
            resources.ApplyResources(this.Label14, "Label14");
            this.Label14.Name = "Label14";
            resources.ApplyResources(this.tbStateTool, "tbStateTool");
            this.tbStateTool.Name = "tbStateTool";
            resources.ApplyResources(this.Label53, "Label53");
            this.Label53.Name = "Label53";
            resources.ApplyResources(this.Label50, "Label50");
            this.Label50.Name = "Label50";
            resources.ApplyResources(this.tbStateSpindleRPM, "tbStateSpindleRPM");
            this.tbStateSpindleRPM.Name = "tbStateSpindleRPM";
            this.Panel1.BorderStyle = BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.cbxStateFeedMode);
            this.Panel1.Controls.Add(this.cbxStateDistance);
            this.Panel1.Controls.Add(this.Label16);
            this.Panel1.Controls.Add(this.cbxStateUnits);
            this.Panel1.Controls.Add(this.Label123);
            this.Panel1.Controls.Add(this.Lalbel49);
            this.Panel1.Controls.Add(this.cbxStatePlane);
            this.Panel1.Controls.Add(this.Label47);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.cbxStateOffset);
            this.Panel1.Controls.Add(this.cbxStateCoolant);
            this.Panel1.Controls.Add(this.Label45);
            this.Panel1.Controls.Add(this.Label17);
            this.Panel1.Controls.Add(this.cbxStateSpindle);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            this.cbxStateFeedMode.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxStateFeedMode.FormattingEnabled = true;
            this.cbxStateFeedMode.Items.AddRange(new object[]
            {
                resources.GetString("cbxStateFeedMode.Items"),
                resources.GetString("cbxStateFeedMode.Items1"),
                resources.GetString("cbxStateFeedMode.Items2")
            });
            resources.ApplyResources(this.cbxStateFeedMode, "cbxStateFeedMode");
            this.cbxStateFeedMode.Name = "cbxStateFeedMode";
            this.cbxStateDistance.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxStateDistance.FormattingEnabled = true;
            this.cbxStateDistance.Items.AddRange(new object[]
            {
                resources.GetString("cbxStateDistance.Items"),
                resources.GetString("cbxStateDistance.Items1"),
                resources.GetString("cbxStateDistance.Items2")
            });
            resources.ApplyResources(this.cbxStateDistance, "cbxStateDistance");
            this.cbxStateDistance.Name = "cbxStateDistance";
            resources.ApplyResources(this.Label16, "Label16");
            this.Label16.Name = "Label16";
            this.cbxStateUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxStateUnits.FormattingEnabled = true;
            this.cbxStateUnits.Items.AddRange(new object[]
            {
                resources.GetString("cbxStateUnits.Items"),
                resources.GetString("cbxStateUnits.Items1"),
                resources.GetString("cbxStateUnits.Items2")
            });
            resources.ApplyResources(this.cbxStateUnits, "cbxStateUnits");
            this.cbxStateUnits.Name = "cbxStateUnits";
            resources.ApplyResources(this.Label123, "Label123");
            this.Label123.Name = "Label123";
            resources.ApplyResources(this.Lalbel49, "Lalbel49");
            this.Lalbel49.Name = "Lalbel49";
            this.cbxStatePlane.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxStatePlane.FormattingEnabled = true;
            this.cbxStatePlane.Items.AddRange(new object[]
            {
                resources.GetString("cbxStatePlane.Items"),
                resources.GetString("cbxStatePlane.Items1"),
                resources.GetString("cbxStatePlane.Items2"),
                resources.GetString("cbxStatePlane.Items3")
            });
            resources.ApplyResources(this.cbxStatePlane, "cbxStatePlane");
            this.cbxStatePlane.Name = "cbxStatePlane";
            resources.ApplyResources(this.Label47, "Label47");
            this.Label47.Name = "Label47";
            resources.ApplyResources(this.Label15, "Label15");
            this.Label15.Name = "Label15";
            this.cbxStateOffset.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxStateOffset.FormattingEnabled = true;
            this.cbxStateOffset.Items.AddRange(new object[]
            {
                resources.GetString("cbxStateOffset.Items"),
                resources.GetString("cbxStateOffset.Items1"),
                resources.GetString("cbxStateOffset.Items2"),
                resources.GetString("cbxStateOffset.Items3"),
                resources.GetString("cbxStateOffset.Items4"),
                resources.GetString("cbxStateOffset.Items5"),
                resources.GetString("cbxStateOffset.Items6")
            });
            resources.ApplyResources(this.cbxStateOffset, "cbxStateOffset");
            this.cbxStateOffset.Name = "cbxStateOffset";
            this.cbxStateCoolant.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxStateCoolant.FormattingEnabled = true;
            this.cbxStateCoolant.Items.AddRange(new object[]
            {
                resources.GetString("cbxStateCoolant.Items"),
                resources.GetString("cbxStateCoolant.Items1"),
                resources.GetString("cbxStateCoolant.Items2")
            });
            resources.ApplyResources(this.cbxStateCoolant, "cbxStateCoolant");
            this.cbxStateCoolant.Name = "cbxStateCoolant";
            resources.ApplyResources(this.Label45, "Label45");
            this.Label45.Name = "Label45";
            resources.ApplyResources(this.Label17, "Label17");
            this.Label17.Name = "Label17";
            this.cbxStateSpindle.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxStateSpindle.FormattingEnabled = true;
            this.cbxStateSpindle.Items.AddRange(new object[]
            {
                resources.GetString("cbxStateSpindle.Items"),
                resources.GetString("cbxStateSpindle.Items1"),
                resources.GetString("cbxStateSpindle.Items2"),
                resources.GetString("cbxStateSpindle.Items3")
            });
            resources.ApplyResources(this.cbxStateSpindle, "cbxStateSpindle");
            this.cbxStateSpindle.Name = "cbxStateSpindle";
            this.gbControl.Controls.Add(this.btnCheckMode);
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.btnHold);
            this.gbControl.Controls.Add(this.btnStartResume);
            this.gbControl.Controls.Add(this.btnUnlock);
            resources.ApplyResources(this.gbControl, "gbControl");
            this.gbControl.Name = "gbControl";
            this.gbControl.TabStop = false;
            resources.ApplyResources(this.btnCheckMode, "btnCheckMode");
            this.btnCheckMode.Name = "btnCheckMode";
            this.btnCheckMode.UseCompatibleTextRendering = true;
            this.btnCheckMode.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.BackColor = Color.Transparent;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseCompatibleTextRendering = true;
            this.btnReset.UseVisualStyleBackColor = false;
            resources.ApplyResources(this.btnHold, "btnHold");
            this.btnHold.BackColor = Color.Transparent;
            this.btnHold.Name = "btnHold";
            this.btnHold.UseCompatibleTextRendering = true;
            this.btnHold.UseVisualStyleBackColor = false;
            resources.ApplyResources(this.btnStartResume, "btnStartResume");
            this.btnStartResume.Name = "btnStartResume";
            this.btnStartResume.UseCompatibleTextRendering = true;
            this.btnStartResume.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnUnlock, "btnUnlock");
            this.btnUnlock.BackColor = Color.Transparent;
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.UseCompatibleTextRendering = true;
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.gbMDI.Controls.Add(this.Label9);
            this.gbMDI.Controls.Add(this.btnSend);
            this.gbMDI.Controls.Add(this.tbSendData);
            resources.ApplyResources(this.gbMDI, "gbMDI");
            this.gbMDI.Name = "gbMDI";
            this.gbMDI.TabStop = false;
            resources.ApplyResources(this.Label9, "Label9");
            this.Label9.Name = "Label9";
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.tbSendData.CharacterCasing = CharacterCasing.Upper;
            resources.ApplyResources(this.tbSendData, "tbSendData");
            this.tbSendData.Name = "tbSendData";
            resources.ApplyResources(this.gbJogging, "gbJogging");
            this.gbJogging.Controls.Add(this.btnZMinus);
            this.gbJogging.Controls.Add(this.btnZPlus);
            this.gbJogging.Controls.Add(this.btnXPlus);
            this.gbJogging.Controls.Add(this.btnYMinus);
            this.gbJogging.Controls.Add(this.btnXMinus);
            this.gbJogging.Controls.Add(this.btnYPlus);
            this.gbJogging.Controls.Add(this.gbFeedRate);
            this.gbJogging.Controls.Add(this.gbDistance);
            this.gbJogging.Controls.Add(this.cbUnits);
            this.gbJogging.Name = "gbJogging";
            this.gbJogging.TabStop = false;
            resources.ApplyResources(this.btnZMinus, "btnZMinus");
            this.btnZMinus.Interval = 100;
            this.btnZMinus.Name = "btnZMinus";
            this.btnZMinus.Tag = "Z-";
            this.btnZMinus.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnZPlus, "btnZPlus");
            this.btnZPlus.Interval = 100;
            this.btnZPlus.Name = "btnZPlus";
            this.btnZPlus.Tag = "Z+";
            this.btnZPlus.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnXPlus, "btnXPlus");
            this.btnXPlus.Interval = 100;
            this.btnXPlus.Name = "btnXPlus";
            this.btnXPlus.Tag = "X+";
            this.btnXPlus.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnYMinus, "btnYMinus");
            this.btnYMinus.Interval = 100;
            this.btnYMinus.Name = "btnYMinus";
            this.btnYMinus.Tag = "Y-";
            this.btnYMinus.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnXMinus, "btnXMinus");
            this.btnXMinus.Interval = 100;
            this.btnXMinus.Name = "btnXMinus";
            this.btnXMinus.Tag = "X-";
            this.btnXMinus.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnYPlus, "btnYPlus");
            this.btnYPlus.Interval = 100;
            this.btnYPlus.Name = "btnYPlus";
            this.btnYPlus.Tag = "Y+";
            this.btnYPlus.UseVisualStyleBackColor = true;
            this.gbFeedRate.Controls.Add(this.rbFeedRate1);
            this.gbFeedRate.Controls.Add(this.rbFeedRate2);
            this.gbFeedRate.Controls.Add(this.rbFeedRate3);
            this.gbFeedRate.Controls.Add(this.rbFeedRate4);
            resources.ApplyResources(this.gbFeedRate, "gbFeedRate");
            this.gbFeedRate.Name = "gbFeedRate";
            this.gbFeedRate.TabStop = false;
            resources.ApplyResources(this.rbFeedRate1, "rbFeedRate1");
            this.rbFeedRate1.Cursor = Cursors.Default;
            this.rbFeedRate1.Name = "rbFeedRate1";
            this.rbFeedRate1.TabStop = true;
            this.rbFeedRate1.Tag = "F1";
            this.rbFeedRate1.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.rbFeedRate2, "rbFeedRate2");
            this.rbFeedRate2.Name = "rbFeedRate2";
            this.rbFeedRate2.TabStop = true;
            this.rbFeedRate2.Tag = "F2";
            this.rbFeedRate2.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.rbFeedRate3, "rbFeedRate3");
            this.rbFeedRate3.Name = "rbFeedRate3";
            this.rbFeedRate3.TabStop = true;
            this.rbFeedRate3.Tag = "F3";
            this.rbFeedRate3.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.rbFeedRate4, "rbFeedRate4");
            this.rbFeedRate4.Name = "rbFeedRate4";
            this.rbFeedRate4.TabStop = true;
            this.rbFeedRate4.Tag = "F4";
            this.rbFeedRate4.UseVisualStyleBackColor = true;
            this.gbDistance.Controls.Add(this.rbDistance1);
            this.gbDistance.Controls.Add(this.rbDistance2);
            this.gbDistance.Controls.Add(this.rbDistance3);
            this.gbDistance.Controls.Add(this.rbDistance4);
            resources.ApplyResources(this.gbDistance, "gbDistance");
            this.gbDistance.Name = "gbDistance";
            this.gbDistance.TabStop = false;
            resources.ApplyResources(this.rbDistance1, "rbDistance1");
            this.rbDistance1.Name = "rbDistance1";
            this.rbDistance1.TabStop = true;
            this.rbDistance1.Tag = "I1";
            this.rbDistance1.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.rbDistance2, "rbDistance2");
            this.rbDistance2.Name = "rbDistance2";
            this.rbDistance2.TabStop = true;
            this.rbDistance2.Tag = "I2";
            this.rbDistance2.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.rbDistance3, "rbDistance3");
            this.rbDistance3.Name = "rbDistance3";
            this.rbDistance3.TabStop = true;
            this.rbDistance3.Tag = "I3";
            this.rbDistance3.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.rbDistance4, "rbDistance4");
            this.rbDistance4.Name = "rbDistance4";
            this.rbDistance4.TabStop = true;
            this.rbDistance4.Tag = "I4";
            this.rbDistance4.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.cbUnits, "cbUnits");
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.gbStatus, "gbStatus");
            this.gbStatus.Controls.Add(this.Label25);
            this.gbStatus.Controls.Add(this.tbCurrentStatus);
            this.gbStatus.Controls.Add(this.Label24);
            this.gbStatus.Controls.Add(this.prgbRxBuf);
            this.gbStatus.Controls.Add(this.prgBarQ);
            this.gbStatus.Controls.Add(this.cbVerbose);
            this.gbStatus.Controls.Add(this.lbResponses);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.TabStop = false;
            resources.ApplyResources(this.Label25, "Label25");
            this.Label25.Name = "Label25";
            resources.ApplyResources(this.tbCurrentStatus, "tbCurrentStatus");
            this.tbCurrentStatus.Name = "tbCurrentStatus";
            this.ToolTip1.SetToolTip(this.tbCurrentStatus, resources.GetString("tbCurrentStatus.ToolTip"));
            resources.ApplyResources(this.Label24, "Label24");
            this.Label24.Name = "Label24";
            resources.ApplyResources(this.prgbRxBuf, "prgbRxBuf");
            this.prgbRxBuf.Maximum = 127;
            this.prgbRxBuf.Name = "prgbRxBuf";
            this.prgbRxBuf.Style = ProgressBarStyle.Continuous;
            resources.ApplyResources(this.prgBarQ, "prgBarQ");
            this.prgBarQ.Maximum = 25;
            this.prgBarQ.Name = "prgBarQ";
            this.prgBarQ.Style = ProgressBarStyle.Continuous;
            resources.ApplyResources(this.cbVerbose, "cbVerbose");
            this.cbVerbose.Checked = MySettings.Default.StatusVerbose;
            this.cbVerbose.DataBindings.Add(new Binding("Checked", MySettings.Default, "statusVerbose", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cbVerbose.Name = "cbVerbose";
            this.cbVerbose.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.lbResponses, "lbResponses");
            this.lbResponses.FormattingEnabled = true;
            this.lbResponses.Name = "lbResponses";
            resources.ApplyResources(this.gbGcode, "gbGcode");
            this.gbGcode.Controls.Add(this.btnFileStep);
            this.gbGcode.Controls.Add(this.cbMonitorEnable);
            this.gbGcode.Controls.Add(this.lblElapsedTime);
            this.gbGcode.Controls.Add(this.Label23);
            this.gbGcode.Controls.Add(this.Label51);
            this.gbGcode.Controls.Add(this.lblCurrentLine);
            this.gbGcode.Controls.Add(this.dgvGcode);
            this.gbGcode.Controls.Add(this.btnFileReload);
            this.gbGcode.Controls.Add(this.tbGCodeMessage);
            this.gbGcode.Controls.Add(this.Label27);
            this.gbGcode.Controls.Add(this.lblTotalLines);
            this.gbGcode.Controls.Add(this.btnFilePause);
            this.gbGcode.Controls.Add(this.tbGcodeFile);
            this.gbGcode.Controls.Add(this.btnFileSelect);
            this.gbGcode.Controls.Add(this.btnFileSend);
            this.gbGcode.Controls.Add(this.btnFileStop);
            this.gbGcode.Name = "gbGcode";
            this.gbGcode.TabStop = false;
            resources.ApplyResources(this.btnFileStep, "btnFileStep");
            this.btnFileStep.Name = "btnFileStep";
            this.btnFileStep.Tag = "Step";
            this.ToolTip1.SetToolTip(this.btnFileStep, resources.GetString("btnFileStep.ToolTip"));
            this.btnFileStep.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.cbMonitorEnable, "cbMonitorEnable");
            this.cbMonitorEnable.Checked = true;
            this.cbMonitorEnable.CheckState = CheckState.Checked;
            this.cbMonitorEnable.Name = "cbMonitorEnable";
            this.cbMonitorEnable.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.lblElapsedTime, "lblElapsedTime");
            this.lblElapsedTime.Name = "lblElapsedTime";
            resources.ApplyResources(this.Label23, "Label23");
            this.Label23.Name = "Label23";
            resources.ApplyResources(this.Label51, "Label51");
            this.Label51.Name = "Label51";
            resources.ApplyResources(this.lblCurrentLine, "lblCurrentLine");
            this.lblCurrentLine.Name = "lblCurrentLine";
            this.dgvGcode.AccessibleRole = AccessibleRole.None;
            this.dgvGcode.AllowUserToAddRows = false;
            this.dgvGcode.AllowUserToDeleteRows = false;
            this.dgvGcode.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvGcode, "dgvGcode");
            this.dgvGcode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGcode.Columns.AddRange(new DataGridViewColumn[]
            {
                this.stat,
                this.lineNum,
                this.data
            });
            this.dgvGcode.MultiSelect = false;
            this.dgvGcode.Name = "dgvGcode";
            this.dgvGcode.ReadOnly = true;
            this.dgvGcode.RowHeadersVisible = false;
            this.dgvGcode.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvGcode.StandardTab = true;
            this.dgvGcode.VirtualMode = true;
            this.stat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.stat.Frozen = true;
            resources.ApplyResources(this.stat, "stat");
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            this.stat.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.lineNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.lineNum, "lineNum");
            this.lineNum.Name = "lineNum";
            this.lineNum.ReadOnly = true;
            this.lineNum.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.data.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.data, "data");
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Resizable = DataGridViewTriState.False;
            this.data.SortMode = DataGridViewColumnSortMode.NotSortable;
            resources.ApplyResources(this.btnFileReload, "btnFileReload");
            this.btnFileReload.Name = "btnFileReload";
            this.btnFileReload.Tag = "Reload";
            this.ToolTip1.SetToolTip(this.btnFileReload, resources.GetString("btnFileReload.ToolTip"));
            this.btnFileReload.UseVisualStyleBackColor = true;
            this.tbGCodeMessage.BorderStyle = BorderStyle.None;
            resources.ApplyResources(this.tbGCodeMessage, "tbGCodeMessage");
            this.tbGCodeMessage.Name = "tbGCodeMessage";
            resources.ApplyResources(this.Label27, "Label27");
            this.Label27.Name = "Label27";
            resources.ApplyResources(this.lblTotalLines, "lblTotalLines");
            this.lblTotalLines.Name = "lblTotalLines";
            resources.ApplyResources(this.btnFilePause, "btnFilePause");
            this.btnFilePause.Name = "btnFilePause";
            this.btnFilePause.Tag = "Pause";
            this.ToolTip1.SetToolTip(this.btnFilePause, resources.GetString("btnFilePause.ToolTip"));
            this.btnFilePause.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbGcodeFile, "tbGcodeFile");
            this.tbGcodeFile.Name = "tbGcodeFile";
            resources.ApplyResources(this.btnFileSelect, "btnFileSelect");
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Tag = "File";
            this.ToolTip1.SetToolTip(this.btnFileSelect, resources.GetString("btnFileSelect.ToolTip"));
            this.btnFileSelect.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnFileSend, "btnFileSend");
            this.btnFileSend.Name = "btnFileSend";
            this.btnFileSend.Tag = "Send";
            this.ToolTip1.SetToolTip(this.btnFileSend, resources.GetString("btnFileSend.ToolTip"));
            this.btnFileSend.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnFileStop, "btnFileStop");
            this.btnFileStop.Name = "btnFileStop";
            this.btnFileStop.Tag = "Stop";
            this.ToolTip1.SetToolTip(this.btnFileStop, resources.GetString("btnFileStop.ToolTip"));
            this.btnFileStop.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.gbGrbl, "gbGrbl");
            this.gbGrbl.Controls.Add(this.tcConnection);
            this.gbGrbl.Name = "gbGrbl";
            this.gbGrbl.TabStop = false;
            this.tcConnection.Controls.Add(this.tbGrblCOM);
            this.tcConnection.Controls.Add(this.tbGrblIP);
            resources.ApplyResources(this.tcConnection, "tcConnection");
            this.tcConnection.Name = "tcConnection";
            this.tcConnection.SelectedIndex = 0;
            this.tbGrblCOM.Controls.Add(this.btnRescanPorts);
            this.tbGrblCOM.Controls.Add(this.cbPorts);
            this.tbGrblCOM.Controls.Add(this.btnConnect);
            this.tbGrblCOM.Controls.Add(this.cbBaud);
            resources.ApplyResources(this.tbGrblCOM, "tbGrblCOM");
            this.tbGrblCOM.Name = "tbGrblCOM";
            this.tbGrblCOM.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnRescanPorts, "btnRescanPorts");
            this.btnRescanPorts.Name = "btnRescanPorts";
            this.btnRescanPorts.UseVisualStyleBackColor = true;
            this.cbPorts.FormattingEnabled = true;
            resources.ApplyResources(this.cbPorts, "cbPorts");
            this.cbPorts.Name = "cbPorts";
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Tag = "COM";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[]
            {
                resources.GetString("cbBaud.Items"),
                resources.GetString("cbBaud.Items1")
            });
            resources.ApplyResources(this.cbBaud, "cbBaud");
            this.cbBaud.Name = "cbBaud";
            this.tbGrblIP.Controls.Add(this.btnIPConnect);
            this.tbGrblIP.Controls.Add(this.tbIPAddress);
            resources.ApplyResources(this.tbGrblIP, "tbGrblIP");
            this.tbGrblIP.Name = "tbGrblIP";
            this.tbGrblIP.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnIPConnect, "btnIPConnect");
            this.btnIPConnect.Name = "btnIPConnect";
            this.btnIPConnect.Tag = "IP";
            this.btnIPConnect.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbIPAddress, "tbIPAddress");
            this.tbIPAddress.Name = "tbIPAddress";
            this.ToolTip1.SetToolTip(this.tbIPAddress, resources.GetString("tbIPAddress.ToolTip"));
            this.gbPosition.Controls.Add(this.tabCtlPosition);
            resources.ApplyResources(this.gbPosition, "gbPosition");
            this.gbPosition.FlatStyle = FlatStyle.Popup;
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.TabStop = false;
            this.tabCtlPosition.Controls.Add(this.tpWork);
            this.tabCtlPosition.Controls.Add(this.tpOffsets);
            resources.ApplyResources(this.tabCtlPosition, "tabCtlPosition");
            this.tabCtlPosition.Name = "tabCtlPosition";
            this.tabCtlPosition.SelectedIndex = 0;
            this.tpWork.Controls.Add(this.Panel5);
            this.tpWork.Controls.Add(this.Panel4);
            this.tpWork.Controls.Add(this.Panel3);
            this.tpWork.Controls.Add(this.GroupBox1);
            this.tpWork.Controls.Add(this.btnWorkSoftHome);
            this.tpWork.Controls.Add(this.btnHome);
            this.tpWork.Controls.Add(this.btnWorkSpclPosition);
            this.tpWork.Controls.Add(this.Label3);
            this.tpWork.Controls.Add(this.btnWork0);
            this.tpWork.Controls.Add(this.Label2);
            this.tpWork.Controls.Add(this.btnWorkX0);
            this.tpWork.Controls.Add(this.Label1);
            this.tpWork.Controls.Add(this.btnWorkZ0);
            this.tpWork.Controls.Add(this.btnWorkY0);
            resources.ApplyResources(this.tpWork, "tpWork");
            this.tpWork.Name = "tpWork";
            this.tpWork.UseVisualStyleBackColor = true;
            this.Panel5.BackColor = SystemColors.Control;
            this.Panel5.BorderStyle = BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.tbWorkZ);
            this.Panel5.Controls.Add(this.tbMachZ);
            resources.ApplyResources(this.Panel5, "Panel5");
            this.Panel5.Name = "Panel5";
            this.tbWorkZ.BorderStyle = BorderStyle.None;
            resources.ApplyResources(this.tbWorkZ, "tbWorkZ");
            this.tbWorkZ.Name = "tbWorkZ";
            this.tbWorkZ.Tag = "Z";
            this.ToolTip1.SetToolTip(this.tbWorkZ, resources.GetString("tbWorkZ.ToolTip"));
            this.tbMachZ.BorderStyle = BorderStyle.None;
            resources.ApplyResources(this.tbMachZ, "tbMachZ");
            this.tbMachZ.Name = "tbMachZ";
            this.ToolTip1.SetToolTip(this.tbMachZ, resources.GetString("tbMachZ.ToolTip"));
            this.Panel4.BackColor = SystemColors.Control;
            this.Panel4.BorderStyle = BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.tbWorkY);
            this.Panel4.Controls.Add(this.tbMachY);
            resources.ApplyResources(this.Panel4, "Panel4");
            this.Panel4.Name = "Panel4";
            this.tbWorkY.BorderStyle = BorderStyle.None;
            resources.ApplyResources(this.tbWorkY, "tbWorkY");
            this.tbWorkY.Name = "tbWorkY";
            this.tbWorkY.Tag = "Y";
            this.ToolTip1.SetToolTip(this.tbWorkY, resources.GetString("tbWorkY.ToolTip"));
            this.tbMachY.BorderStyle = BorderStyle.None;
            resources.ApplyResources(this.tbMachY, "tbMachY");
            this.tbMachY.Name = "tbMachY";
            this.ToolTip1.SetToolTip(this.tbMachY, resources.GetString("tbMachY.ToolTip"));
            this.Panel3.BackColor = SystemColors.Control;
            this.Panel3.BorderStyle = BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.tbMachX);
            this.Panel3.Controls.Add(this.tbWorkX);
            resources.ApplyResources(this.Panel3, "Panel3");
            this.Panel3.Name = "Panel3";
            this.tbMachX.BorderStyle = BorderStyle.None;
            resources.ApplyResources(this.tbMachX, "tbMachX");
            this.tbMachX.Name = "tbMachX";
            this.ToolTip1.SetToolTip(this.tbMachX, resources.GetString("tbMachX.ToolTip"));
            this.tbWorkX.BorderStyle = BorderStyle.None;
            resources.ApplyResources(this.tbWorkX, "tbWorkX");
            this.tbWorkX.Name = "tbWorkX";
            this.tbWorkX.Tag = "X";
            this.ToolTip1.SetToolTip(this.tbWorkX, resources.GetString("tbWorkX.ToolTip"));
            this.GroupBox1.Controls.Add(this.lblPositionCurrentOffset);
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            resources.ApplyResources(this.lblPositionCurrentOffset, "lblPositionCurrentOffset");
            this.lblPositionCurrentOffset.Name = "lblPositionCurrentOffset";
            resources.ApplyResources(this.btnWorkSoftHome, "btnWorkSoftHome");
            this.btnWorkSoftHome.Name = "btnWorkSoftHome";
            this.btnWorkSoftHome.Tag = "Spcl Posn1";
            this.ToolTip1.SetToolTip(this.btnWorkSoftHome, resources.GetString("btnWorkSoftHome.ToolTip"));
            this.btnWorkSoftHome.UseVisualStyleBackColor = true;
            this.btnHome.BackColor = Color.Transparent;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Name = "btnHome";
            this.btnHome.Tag = "HomeCycle";
            this.ToolTip1.SetToolTip(this.btnHome, resources.GetString("btnHome.ToolTip"));
            this.btnHome.UseVisualStyleBackColor = false;
            resources.ApplyResources(this.btnWorkSpclPosition, "btnWorkSpclPosition");
            this.btnWorkSpclPosition.Name = "btnWorkSpclPosition";
            this.btnWorkSpclPosition.Tag = "Spcl Posn2";
            this.ToolTip1.SetToolTip(this.btnWorkSpclPosition, resources.GetString("btnWorkSpclPosition.ToolTip"));
            this.btnWorkSpclPosition.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            resources.ApplyResources(this.btnWork0, "btnWork0");
            this.btnWork0.Name = "btnWork0";
            this.btnWork0.Tag = "ZeroXYZ";
            this.ToolTip1.SetToolTip(this.btnWork0, resources.GetString("btnWork0.ToolTip"));
            this.btnWork0.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            resources.ApplyResources(this.btnWorkX0, "btnWorkX0");
            this.btnWorkX0.Name = "btnWorkX0";
            this.btnWorkX0.Tag = "X";
            this.ToolTip1.SetToolTip(this.btnWorkX0, resources.GetString("btnWorkX0.ToolTip"));
            this.btnWorkX0.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            resources.ApplyResources(this.btnWorkZ0, "btnWorkZ0");
            this.btnWorkZ0.Name = "btnWorkZ0";
            this.btnWorkZ0.Tag = "Z";
            this.ToolTip1.SetToolTip(this.btnWorkZ0, resources.GetString("btnWorkZ0.ToolTip"));
            this.btnWorkZ0.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnWorkY0, "btnWorkY0");
            this.btnWorkY0.Name = "btnWorkY0";
            this.btnWorkY0.Tag = "Y";
            this.ToolTip1.SetToolTip(this.btnWorkY0, resources.GetString("btnWorkY0.ToolTip"));
            this.btnWorkY0.UseVisualStyleBackColor = true;
            this.tpOffsets.Controls.Add(this.btnSetOffsetG59);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG58);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG57);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG56);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG55);
            this.tpOffsets.Controls.Add(this.btnSetOffsetG54);
            this.tpOffsets.Controls.Add(this.Label10);
            this.tpOffsets.Controls.Add(this.Label71);
            this.tpOffsets.Controls.Add(this.tbOffSetsMachZ);
            this.tpOffsets.Controls.Add(this.Label19);
            this.tpOffsets.Controls.Add(this.tbOffsetsG56Y);
            this.tpOffsets.Controls.Add(this.tbOffSetsMachY);
            this.tpOffsets.Controls.Add(this.tbOffsetsG56X);
            this.tpOffsets.Controls.Add(this.tbOffsetsG56Z);
            this.tpOffsets.Controls.Add(this.tbOffSetsMachX);
            this.tpOffsets.Controls.Add(this.btnOffsetsG57Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG54X);
            this.tpOffsets.Controls.Add(this.btnOffsetsG56Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG54Y);
            this.tpOffsets.Controls.Add(this.tbOffsetsG57Z);
            this.tpOffsets.Controls.Add(this.btnOffsetsSave);
            this.tpOffsets.Controls.Add(this.tbOffsetsG55X);
            this.tpOffsets.Controls.Add(this.tbOffsetsG54Z);
            this.tpOffsets.Controls.Add(this.tbOffsetsG57Y);
            this.tpOffsets.Controls.Add(this.btnOffsetsRetrieve);
            this.tpOffsets.Controls.Add(this.tbOffsetsG55Y);
            this.tpOffsets.Controls.Add(this.btnOffsetsG54Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG57X);
            this.tpOffsets.Controls.Add(this.btnOffsetsLoad);
            this.tpOffsets.Controls.Add(this.tbOffsetsG55Z);
            this.tpOffsets.Controls.Add(this.tbOffsetsG59X);
            this.tpOffsets.Controls.Add(this.btnOffsetsG58Zero);
            this.tpOffsets.Controls.Add(this.btnOffsetsG43Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG59Y);
            this.tpOffsets.Controls.Add(this.tbOffsetsG43Z);
            this.tpOffsets.Controls.Add(this.btnOffsetsG55Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG59Z);
            this.tpOffsets.Controls.Add(this.tbOffsetsG58Z);
            this.tpOffsets.Controls.Add(this.Label60);
            this.tpOffsets.Controls.Add(this.tbOffsetsG58Y);
            this.tpOffsets.Controls.Add(this.Label20);
            this.tpOffsets.Controls.Add(this.Label43);
            this.tpOffsets.Controls.Add(this.btnOffsetsG59Zero);
            this.tpOffsets.Controls.Add(this.tbOffsetsG58X);
            this.tpOffsets.Controls.Add(this.Label21);
            resources.ApplyResources(this.tpOffsets, "tpOffsets");
            this.tpOffsets.Name = "tpOffsets";
            this.tpOffsets.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSetOffsetG59, "btnSetOffsetG59");
            this.btnSetOffsetG59.Name = "btnSetOffsetG59";
            this.btnSetOffsetG59.Tag = "G59";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG59, resources.GetString("btnSetOffsetG59.ToolTip"));
            this.btnSetOffsetG59.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSetOffsetG58, "btnSetOffsetG58");
            this.btnSetOffsetG58.Name = "btnSetOffsetG58";
            this.btnSetOffsetG58.Tag = "G58";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG58, resources.GetString("btnSetOffsetG58.ToolTip"));
            this.btnSetOffsetG58.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSetOffsetG57, "btnSetOffsetG57");
            this.btnSetOffsetG57.Name = "btnSetOffsetG57";
            this.btnSetOffsetG57.Tag = "G57";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG57, resources.GetString("btnSetOffsetG57.ToolTip"));
            this.btnSetOffsetG57.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSetOffsetG56, "btnSetOffsetG56");
            this.btnSetOffsetG56.Name = "btnSetOffsetG56";
            this.btnSetOffsetG56.Tag = "G56";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG56, resources.GetString("btnSetOffsetG56.ToolTip"));
            this.btnSetOffsetG56.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSetOffsetG55, "btnSetOffsetG55");
            this.btnSetOffsetG55.Name = "btnSetOffsetG55";
            this.btnSetOffsetG55.Tag = "G55";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG55, resources.GetString("btnSetOffsetG55.ToolTip"));
            this.btnSetOffsetG55.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSetOffsetG54, "btnSetOffsetG54");
            this.btnSetOffsetG54.Name = "btnSetOffsetG54";
            this.btnSetOffsetG54.Tag = "G54";
            this.ToolTip1.SetToolTip(this.btnSetOffsetG54, resources.GetString("btnSetOffsetG54.ToolTip"));
            this.btnSetOffsetG54.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label10, "Label10");
            this.Label10.Name = "Label10";
            resources.ApplyResources(this.Label71, "Label71");
            this.Label71.Name = "Label71";
            resources.ApplyResources(this.tbOffSetsMachZ, "tbOffSetsMachZ");
            this.tbOffSetsMachZ.Name = "tbOffSetsMachZ";
            this.tbOffSetsMachZ.Tag = "G28Z";
            this.ToolTip1.SetToolTip(this.tbOffSetsMachZ, resources.GetString("tbOffSetsMachZ.ToolTip"));
            resources.ApplyResources(this.Label19, "Label19");
            this.Label19.Name = "Label19";
            resources.ApplyResources(this.tbOffsetsG56Y, "tbOffsetsG56Y");
            this.tbOffsetsG56Y.Name = "tbOffsetsG56Y";
            this.tbOffsetsG56Y.Tag = "G56Y";
            resources.ApplyResources(this.tbOffSetsMachY, "tbOffSetsMachY");
            this.tbOffSetsMachY.Name = "tbOffSetsMachY";
            this.tbOffSetsMachY.Tag = "G28Y";
            this.ToolTip1.SetToolTip(this.tbOffSetsMachY, resources.GetString("tbOffSetsMachY.ToolTip"));
            resources.ApplyResources(this.tbOffsetsG56X, "tbOffsetsG56X");
            this.tbOffsetsG56X.Name = "tbOffsetsG56X";
            this.tbOffsetsG56X.Tag = "G56X";
            resources.ApplyResources(this.tbOffsetsG56Z, "tbOffsetsG56Z");
            this.tbOffsetsG56Z.Name = "tbOffsetsG56Z";
            this.tbOffsetsG56Z.Tag = "G56Z";
            resources.ApplyResources(this.tbOffSetsMachX, "tbOffSetsMachX");
            this.tbOffSetsMachX.Name = "tbOffSetsMachX";
            this.tbOffSetsMachX.Tag = "G28X";
            this.ToolTip1.SetToolTip(this.tbOffSetsMachX, resources.GetString("tbOffSetsMachX.ToolTip"));
            resources.ApplyResources(this.btnOffsetsG57Zero, "btnOffsetsG57Zero");
            this.btnOffsetsG57Zero.Name = "btnOffsetsG57Zero";
            this.btnOffsetsG57Zero.Tag = "G57Zero";
            this.btnOffsetsG57Zero.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG54X, "tbOffsetsG54X");
            this.tbOffsetsG54X.Name = "tbOffsetsG54X";
            this.tbOffsetsG54X.Tag = "G54X";
            resources.ApplyResources(this.btnOffsetsG56Zero, "btnOffsetsG56Zero");
            this.btnOffsetsG56Zero.Name = "btnOffsetsG56Zero";
            this.btnOffsetsG56Zero.Tag = "G56Zero";
            this.btnOffsetsG56Zero.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG54Y, "tbOffsetsG54Y");
            this.tbOffsetsG54Y.Name = "tbOffsetsG54Y";
            this.tbOffsetsG54Y.Tag = "G54Y";
            resources.ApplyResources(this.tbOffsetsG57Z, "tbOffsetsG57Z");
            this.tbOffsetsG57Z.Name = "tbOffsetsG57Z";
            this.tbOffsetsG57Z.Tag = "G57Z";
            resources.ApplyResources(this.btnOffsetsSave, "btnOffsetsSave");
            this.btnOffsetsSave.Name = "btnOffsetsSave";
            this.ToolTip1.SetToolTip(this.btnOffsetsSave, resources.GetString("btnOffsetsSave.ToolTip"));
            this.btnOffsetsSave.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG55X, "tbOffsetsG55X");
            this.tbOffsetsG55X.Name = "tbOffsetsG55X";
            this.tbOffsetsG55X.Tag = "G55X";
            resources.ApplyResources(this.tbOffsetsG54Z, "tbOffsetsG54Z");
            this.tbOffsetsG54Z.Name = "tbOffsetsG54Z";
            this.tbOffsetsG54Z.Tag = "G54Z";
            resources.ApplyResources(this.tbOffsetsG57Y, "tbOffsetsG57Y");
            this.tbOffsetsG57Y.Name = "tbOffsetsG57Y";
            this.tbOffsetsG57Y.Tag = "G57Y";
            resources.ApplyResources(this.btnOffsetsRetrieve, "btnOffsetsRetrieve");
            this.btnOffsetsRetrieve.Name = "btnOffsetsRetrieve";
            this.ToolTip1.SetToolTip(this.btnOffsetsRetrieve, resources.GetString("btnOffsetsRetrieve.ToolTip"));
            this.btnOffsetsRetrieve.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG55Y, "tbOffsetsG55Y");
            this.tbOffsetsG55Y.Name = "tbOffsetsG55Y";
            this.tbOffsetsG55Y.Tag = "G55Y";
            resources.ApplyResources(this.btnOffsetsG54Zero, "btnOffsetsG54Zero");
            this.btnOffsetsG54Zero.Name = "btnOffsetsG54Zero";
            this.btnOffsetsG54Zero.Tag = "G54Zero";
            this.btnOffsetsG54Zero.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG57X, "tbOffsetsG57X");
            this.tbOffsetsG57X.Name = "tbOffsetsG57X";
            this.tbOffsetsG57X.Tag = "G57X";
            resources.ApplyResources(this.btnOffsetsLoad, "btnOffsetsLoad");
            this.btnOffsetsLoad.Name = "btnOffsetsLoad";
            this.ToolTip1.SetToolTip(this.btnOffsetsLoad, resources.GetString("btnOffsetsLoad.ToolTip"));
            this.btnOffsetsLoad.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG55Z, "tbOffsetsG55Z");
            this.tbOffsetsG55Z.Name = "tbOffsetsG55Z";
            this.tbOffsetsG55Z.Tag = "G55Z";
            resources.ApplyResources(this.tbOffsetsG59X, "tbOffsetsG59X");
            this.tbOffsetsG59X.Name = "tbOffsetsG59X";
            this.tbOffsetsG59X.Tag = "G59X";
            resources.ApplyResources(this.btnOffsetsG58Zero, "btnOffsetsG58Zero");
            this.btnOffsetsG58Zero.Name = "btnOffsetsG58Zero";
            this.btnOffsetsG58Zero.Tag = "G58Zero";
            this.btnOffsetsG58Zero.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnOffsetsG43Zero, "btnOffsetsG43Zero");
            this.btnOffsetsG43Zero.Name = "btnOffsetsG43Zero";
            this.btnOffsetsG43Zero.Tag = "G43Zero";
            this.btnOffsetsG43Zero.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG59Y, "tbOffsetsG59Y");
            this.tbOffsetsG59Y.Name = "tbOffsetsG59Y";
            this.tbOffsetsG59Y.Tag = "G59Y";
            resources.ApplyResources(this.tbOffsetsG43Z, "tbOffsetsG43Z");
            this.tbOffsetsG43Z.Name = "tbOffsetsG43Z";
            this.tbOffsetsG43Z.Tag = "G43Z";
            resources.ApplyResources(this.btnOffsetsG55Zero, "btnOffsetsG55Zero");
            this.btnOffsetsG55Zero.Name = "btnOffsetsG55Zero";
            this.btnOffsetsG55Zero.Tag = "G55Zero";
            this.btnOffsetsG55Zero.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG59Z, "tbOffsetsG59Z");
            this.tbOffsetsG59Z.Name = "tbOffsetsG59Z";
            this.tbOffsetsG59Z.Tag = "G59Z";
            resources.ApplyResources(this.tbOffsetsG58Z, "tbOffsetsG58Z");
            this.tbOffsetsG58Z.Name = "tbOffsetsG58Z";
            this.tbOffsetsG58Z.Tag = "G58Z";
            resources.ApplyResources(this.Label60, "Label60");
            this.Label60.Name = "Label60";
            resources.ApplyResources(this.tbOffsetsG58Y, "tbOffsetsG58Y");
            this.tbOffsetsG58Y.Name = "tbOffsetsG58Y";
            this.tbOffsetsG58Y.Tag = "G58Y";
            resources.ApplyResources(this.Label20, "Label20");
            this.Label20.Name = "Label20";
            resources.ApplyResources(this.Label43, "Label43");
            this.Label43.Name = "Label43";
            resources.ApplyResources(this.btnOffsetsG59Zero, "btnOffsetsG59Zero");
            this.btnOffsetsG59Zero.Name = "btnOffsetsG59Zero";
            this.btnOffsetsG59Zero.Tag = "G59Zero";
            this.btnOffsetsG59Zero.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG58X, "tbOffsetsG58X");
            this.tbOffsetsG58X.Name = "tbOffsetsG58X";
            this.tbOffsetsG58X.Tag = "G58X";
            resources.ApplyResources(this.Label21, "Label21");
            this.Label21.Name = "Label21";
            this.tabPgSettings.Controls.Add(this.gbMiscInfo);
            this.tabPgSettings.Controls.Add(this.gbGrblSettings);
            this.tabPgSettings.Controls.Add(this.gbSettingsOffsets);
            this.tabPgSettings.Controls.Add(this.Label42);
            this.tabPgSettings.Controls.Add(this.gbSettingsMisc);
            this.tabPgSettings.Controls.Add(this.gbSettingsPosition);
            this.tabPgSettings.Controls.Add(this.gbSettingsJogging);
            resources.ApplyResources(this.tabPgSettings, "tabPgSettings");
            this.tabPgSettings.Name = "tabPgSettings";
            this.tabPgSettings.UseVisualStyleBackColor = true;
            this.gbMiscInfo.Controls.Add(this.Label49);
            this.gbMiscInfo.Controls.Add(this.tbGrblOptions);
            this.gbMiscInfo.Controls.Add(this.Label48);
            this.gbMiscInfo.Controls.Add(this.tbGrblVersion);
            resources.ApplyResources(this.gbMiscInfo, "gbMiscInfo");
            this.gbMiscInfo.Name = "gbMiscInfo";
            this.gbMiscInfo.TabStop = false;
            resources.ApplyResources(this.Label49, "Label49");
            this.Label49.Name = "Label49";
            resources.ApplyResources(this.tbGrblOptions, "tbGrblOptions");
            this.tbGrblOptions.Name = "tbGrblOptions";
            resources.ApplyResources(this.Label48, "Label48");
            this.Label48.Name = "Label48";
            resources.ApplyResources(this.tbGrblVersion, "tbGrblVersion");
            this.tbGrblVersion.Name = "tbGrblVersion";
            this.gbGrblSettings.Controls.Add(this.Label4);
            this.gbGrblSettings.Controls.Add(this.tbSettingsGrblLastParam);
            this.gbGrblSettings.Controls.Add(this.dgGrblSettings);
            this.gbGrblSettings.Controls.Add(this.btnSettingsGrbl);
            resources.ApplyResources(this.gbGrblSettings, "gbGrblSettings");
            this.gbGrblSettings.Name = "gbGrblSettings";
            this.gbGrblSettings.TabStop = false;
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            this.tbSettingsGrblLastParam.DataBindings.Add(new Binding("Text", MySettings.Default, "GrblLastParamID", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsGrblLastParam, "tbSettingsGrblLastParam");
            this.tbSettingsGrblLastParam.Name = "tbSettingsGrblLastParam";
            this.tbSettingsGrblLastParam.Text = MySettings.Default.GrblLastParamID;
            this.ToolTip1.SetToolTip(this.tbSettingsGrblLastParam, resources.GetString("tbSettingsGrblLastParam.ToolTip"));
            this.dgGrblSettings.AllowUserToAddRows = false;
            this.dgGrblSettings.AllowUserToDeleteRows = false;
            this.dgGrblSettings.AllowUserToResizeColumns = false;
            this.dgGrblSettings.AllowUserToResizeRows = false;
            this.dgGrblSettings.BackgroundColor = SystemColors.Window;
            this.dgGrblSettings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgGrblSettings, "dgGrblSettings");
            this.dgGrblSettings.MultiSelect = false;
            this.dgGrblSettings.Name = "dgGrblSettings";
            this.dgGrblSettings.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.ToolTip1.SetToolTip(this.dgGrblSettings, resources.GetString("dgGrblSettings.ToolTip"));
            resources.ApplyResources(this.btnSettingsGrbl, "btnSettingsGrbl");
            this.btnSettingsGrbl.Name = "btnSettingsGrbl";
            this.btnSettingsGrbl.UseVisualStyleBackColor = true;
            this.gbSettingsOffsets.Controls.Add(this.btnOffsetsG28Set);
            this.gbSettingsOffsets.Controls.Add(this.btnSettingsRetrieveLocations);
            this.gbSettingsOffsets.Controls.Add(this.Label7);
            this.gbSettingsOffsets.Controls.Add(this.Label18);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30Y);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30X);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30Z);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28X);
            this.gbSettingsOffsets.Controls.Add(this.btnOffsetsG30Set);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28Y);
            this.gbSettingsOffsets.Controls.Add(this.Label68);
            this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28Z);
            this.gbSettingsOffsets.Controls.Add(this.Label69);
            resources.ApplyResources(this.gbSettingsOffsets, "gbSettingsOffsets");
            this.gbSettingsOffsets.Name = "gbSettingsOffsets";
            this.gbSettingsOffsets.TabStop = false;
            resources.ApplyResources(this.btnOffsetsG28Set, "btnOffsetsG28Set");
            this.btnOffsetsG28Set.Name = "btnOffsetsG28Set";
            this.btnOffsetsG28Set.Tag = "G28Set";
            this.ToolTip1.SetToolTip(this.btnOffsetsG28Set, resources.GetString("btnOffsetsG28Set.ToolTip"));
            this.btnOffsetsG28Set.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSettingsRetrieveLocations, "btnSettingsRetrieveLocations");
            this.btnSettingsRetrieveLocations.Name = "btnSettingsRetrieveLocations";
            this.ToolTip1.SetToolTip(this.btnSettingsRetrieveLocations, resources.GetString("btnSettingsRetrieveLocations.ToolTip"));
            this.btnSettingsRetrieveLocations.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.Name = "Label7";
            resources.ApplyResources(this.Label18, "Label18");
            this.Label18.Name = "Label18";
            resources.ApplyResources(this.tbOffsetsG30Y, "tbOffsetsG30Y");
            this.tbOffsetsG30Y.Name = "tbOffsetsG30Y";
            this.tbOffsetsG30Y.Tag = "G30Y";
            resources.ApplyResources(this.tbOffsetsG30X, "tbOffsetsG30X");
            this.tbOffsetsG30X.Name = "tbOffsetsG30X";
            this.tbOffsetsG30X.Tag = "G30X";
            resources.ApplyResources(this.tbOffsetsG30Z, "tbOffsetsG30Z");
            this.tbOffsetsG30Z.Name = "tbOffsetsG30Z";
            this.tbOffsetsG30Z.Tag = "G30Z";
            resources.ApplyResources(this.tbOffsetsG28X, "tbOffsetsG28X");
            this.tbOffsetsG28X.Name = "tbOffsetsG28X";
            this.tbOffsetsG28X.Tag = "G28X";
            resources.ApplyResources(this.btnOffsetsG30Set, "btnOffsetsG30Set");
            this.btnOffsetsG30Set.Name = "btnOffsetsG30Set";
            this.btnOffsetsG30Set.Tag = "G30Set";
            this.ToolTip1.SetToolTip(this.btnOffsetsG30Set, resources.GetString("btnOffsetsG30Set.ToolTip"));
            this.btnOffsetsG30Set.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.tbOffsetsG28Y, "tbOffsetsG28Y");
            this.tbOffsetsG28Y.Name = "tbOffsetsG28Y";
            this.tbOffsetsG28Y.Tag = "G28Y";
            resources.ApplyResources(this.Label68, "Label68");
            this.Label68.Name = "Label68";
            resources.ApplyResources(this.tbOffsetsG28Z, "tbOffsetsG28Z");
            this.tbOffsetsG28Z.Name = "tbOffsetsG28Z";
            this.tbOffsetsG28Z.Tag = "G28Z";
            resources.ApplyResources(this.Label69, "Label69");
            this.Label69.Name = "Label69";
            resources.ApplyResources(this.Label42, "Label42");
            this.Label42.Name = "Label42";
            this.gbSettingsMisc.Controls.Add(this.Label52);
            this.gbSettingsMisc.Controls.Add(this.tbTruncationDigits);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsDefaultExt);
            this.gbSettingsMisc.Controls.Add(this.Label5);
            this.gbSettingsMisc.Controls.Add(this.Label6);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsStartupDelay);
            this.gbSettingsMisc.Controls.Add(this.cbSettingsLeftHanded);
            this.gbSettingsMisc.Controls.Add(this.cbSettingsConnectOnLoad);
            this.gbSettingsMisc.Controls.Add(this.cbSettingsPauseOnError);
            this.gbSettingsMisc.Controls.Add(this.cbStatusPollEnable);
            this.gbSettingsMisc.Controls.Add(this.btnSettingsRefreshMisc);
            this.gbSettingsMisc.Controls.Add(this.Label37);
            this.gbSettingsMisc.Controls.Add(this.Label36);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsRBuffSize);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsQSize);
            this.gbSettingsMisc.Controls.Add(this.Label26);
            this.gbSettingsMisc.Controls.Add(this.tbSettingsPollRate);
            resources.ApplyResources(this.gbSettingsMisc, "gbSettingsMisc");
            this.gbSettingsMisc.Name = "gbSettingsMisc";
            this.gbSettingsMisc.TabStop = false;
            resources.ApplyResources(this.Label52, "Label52");
            this.Label52.Name = "Label52";
            this.tbTruncationDigits.DataBindings.Add(new Binding("Text", MySettings.Default, "TruncationDigits", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbTruncationDigits, "tbTruncationDigits");
            this.tbTruncationDigits.Name = "tbTruncationDigits";
            this.tbTruncationDigits.Text = MySettings.Default.TruncationDigits;
            this.tbSettingsDefaultExt.DataBindings.Add(new Binding("Text", MySettings.Default, "DefaultFileExt", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsDefaultExt, "tbSettingsDefaultExt");
            this.tbSettingsDefaultExt.Name = "tbSettingsDefaultExt";
            this.tbSettingsDefaultExt.Text = MySettings.Default.DefaultFileExt;
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            MySettings4.Baud = "115200";
            MySettings4.ConnectionType = "0";
            MySettings4.DefaultFileExt = "txt";
            MySettings4.GCodePauseOnError = true;
            MySettings4.GrblConnectOnLoad = false;
            MySettings4.GrblLastParamID = "$132";
            MySettings4.IPAddress = "";
            MySettings4.JoggingFIDefault = "I2";
            MySettings4.JoggingFIImperial = "1,0.1,0.01,0.001";
            MySettings4.JoggingFIMEtric = "10,1,0.1,0.01 ";
            MySettings4.JoggingFRDefault = "F2";
            MySettings4.JoggingFRImperial = "100,50,10,5";
            MySettings4.JoggingFRMetric = "1000,500,100,5";
            MySettings4.JoggingUnitsMetric = false;
            MySettings4.JoggingUseKeyboard = false;
            MySettings4.JoggingXRepeat = "2.5";
            MySettings4.JoggingYRepeat = "2.5";
            MySettings4.JoggingZRepeat = "2.5";
            MySettings4.LeftHandedGUI = false;
            MySettings4.MachineSpclPosition1 = "G28";
            MySettings4.MachineSpclPosition2 = "G30";
            MySettings4.Macro1 = "";
            MySettings4.Macro2 = "";
            MySettings4.Macro3 = "";
            MySettings4.Macro4 = "";
            MySettings4.Macro5 = "";
            MySettings4.Port = "";
            MySettings4.QBuffMaxSize = "17";
            MySettings4.RBuffMaxSize = "127";
            MySettings4.SettingsKey = "";
            MySettings4.StartupDelay = "1.5";
            MySettings4.StatusPollEnabled = true;
            MySettings4.StatusPollInterval = "200";
            MySettings4.StatusVerbose = false;
            MySettings4.TruncationDigits = "0";
            MySettings4.UpgradeSettings = true;
            MySettings4.Work0Cmd = "G90 G10 L20 P0 X0 Y0 Z0";
            MySettings4.WorkX0Cmd = "G90 G10 L20 P0 X0";
            MySettings4.WorkY0Cmd = "G90 G10 L20 P0 Y0";
            MySettings4.WorkZ0Cmd = "G90 G10 L20 P0 Z0";
            this.tbSettingsStartupDelay.DataBindings.Add(new Binding("Text", MySettings4, "StartupDelay", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsStartupDelay, "tbSettingsStartupDelay");
            this.tbSettingsStartupDelay.Name = "tbSettingsStartupDelay";
            this.tbSettingsStartupDelay.Text = MySettings.Default.StartupDelay;
            resources.ApplyResources(this.cbSettingsLeftHanded, "cbSettingsLeftHanded");
            this.cbSettingsLeftHanded.Checked = MySettings.Default.LeftHandedGUI;
            this.cbSettingsLeftHanded.DataBindings.Add(new Binding("Checked", MySettings.Default, "LeftHandedGUI", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cbSettingsLeftHanded.Name = "cbSettingsLeftHanded";
            this.cbSettingsLeftHanded.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.cbSettingsConnectOnLoad, "cbSettingsConnectOnLoad");
            this.cbSettingsConnectOnLoad.Checked = MySettings.Default.GrblConnectOnLoad;
            this.cbSettingsConnectOnLoad.DataBindings.Add(new Binding("Checked", MySettings.Default, "GrblConnectOnLoad", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cbSettingsConnectOnLoad.Name = "cbSettingsConnectOnLoad";
            this.ToolTip1.SetToolTip(this.cbSettingsConnectOnLoad, resources.GetString("cbSettingsConnectOnLoad.ToolTip"));
            this.cbSettingsConnectOnLoad.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.cbSettingsPauseOnError, "cbSettingsPauseOnError");
            this.cbSettingsPauseOnError.Checked = MySettings.Default.GCodePauseOnError;
            this.cbSettingsPauseOnError.CheckState = CheckState.Checked;
            this.cbSettingsPauseOnError.DataBindings.Add(new Binding("Checked", MySettings.Default, "GCodePauseOnError", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cbSettingsPauseOnError.Name = "cbSettingsPauseOnError";
            this.cbSettingsPauseOnError.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.cbStatusPollEnable, "cbStatusPollEnable");
            this.cbStatusPollEnable.Checked = MySettings.Default.StatusPollEnabled;
            this.cbStatusPollEnable.CheckState = CheckState.Checked;
            this.cbStatusPollEnable.DataBindings.Add(new Binding("Checked", MySettings.Default, "StatusPollEnabled", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cbStatusPollEnable.Name = "cbStatusPollEnable";
            this.cbStatusPollEnable.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSettingsRefreshMisc, "btnSettingsRefreshMisc");
            this.btnSettingsRefreshMisc.Name = "btnSettingsRefreshMisc";
            this.btnSettingsRefreshMisc.Tag = "Misc";
            this.btnSettingsRefreshMisc.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label37, "Label37");
            this.Label37.Name = "Label37";
            resources.ApplyResources(this.Label36, "Label36");
            this.Label36.Name = "Label36";
            this.tbSettingsRBuffSize.DataBindings.Add(new Binding("Text", MySettings.Default, "RBuffMaxSize", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsRBuffSize, "tbSettingsRBuffSize");
            this.tbSettingsRBuffSize.Name = "tbSettingsRBuffSize";
            this.tbSettingsRBuffSize.Text = MySettings.Default.RBuffMaxSize;
            this.tbSettingsQSize.DataBindings.Add(new Binding("Text", MySettings.Default, "QBuffMaxSize", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsQSize, "tbSettingsQSize");
            this.tbSettingsQSize.Name = "tbSettingsQSize";
            this.tbSettingsQSize.Text = MySettings.Default.QBuffMaxSize;
            resources.ApplyResources(this.Label26, "Label26");
            this.Label26.Name = "Label26";
            this.tbSettingsPollRate.DataBindings.Add(new Binding("Text", MySettings.Default, "statusPollInterval", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsPollRate, "tbSettingsPollRate");
            this.tbSettingsPollRate.Name = "tbSettingsPollRate";
            this.tbSettingsPollRate.Text = MySettings.Default.StatusPollInterval;
            this.gbSettingsPosition.Controls.Add(this.Label8);
            this.gbSettingsPosition.Controls.Add(this.tbSettingsSpclPosition2);
            this.gbSettingsPosition.Controls.Add(this.btnSettingsRefreshPosition);
            this.gbSettingsPosition.Controls.Add(this.Label29);
            this.gbSettingsPosition.Controls.Add(this.tbWorkZ0Cmd);
            this.gbSettingsPosition.Controls.Add(this.Label28);
            this.gbSettingsPosition.Controls.Add(this.tbWorkY0Cmd);
            this.gbSettingsPosition.Controls.Add(this.Label13);
            this.gbSettingsPosition.Controls.Add(this.Label12);
            this.gbSettingsPosition.Controls.Add(this.tbWorkX0Cmd);
            this.gbSettingsPosition.Controls.Add(this.tbSettingsZeroXYZCmd);
            this.gbSettingsPosition.Controls.Add(this.Label11);
            this.gbSettingsPosition.Controls.Add(this.tbSettingsSpclPosition1);
            resources.ApplyResources(this.gbSettingsPosition, "gbSettingsPosition");
            this.gbSettingsPosition.Name = "gbSettingsPosition";
            this.gbSettingsPosition.TabStop = false;
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.Name = "Label8";
            this.tbSettingsSpclPosition2.DataBindings.Add(new Binding("Text", MySettings.Default, "MachineSpclPosition2", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsSpclPosition2, "tbSettingsSpclPosition2");
            this.tbSettingsSpclPosition2.Name = "tbSettingsSpclPosition2";
            this.tbSettingsSpclPosition2.Text = MySettings.Default.MachineSpclPosition2;
            resources.ApplyResources(this.btnSettingsRefreshPosition, "btnSettingsRefreshPosition");
            this.btnSettingsRefreshPosition.Name = "btnSettingsRefreshPosition";
            this.btnSettingsRefreshPosition.Tag = "Position";
            this.btnSettingsRefreshPosition.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label29, "Label29");
            this.Label29.Name = "Label29";
            this.tbWorkZ0Cmd.DataBindings.Add(new Binding("Text", MySettings.Default, "WorkZ0Cmd", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbWorkZ0Cmd, "tbWorkZ0Cmd");
            this.tbWorkZ0Cmd.Name = "tbWorkZ0Cmd";
            this.tbWorkZ0Cmd.Text = MySettings.Default.WorkZ0Cmd;
            resources.ApplyResources(this.Label28, "Label28");
            this.Label28.Name = "Label28";
            this.tbWorkY0Cmd.DataBindings.Add(new Binding("Text", MySettings.Default, "WorkY0Cmd", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbWorkY0Cmd, "tbWorkY0Cmd");
            this.tbWorkY0Cmd.Name = "tbWorkY0Cmd";
            this.tbWorkY0Cmd.Text = MySettings.Default.WorkY0Cmd;
            resources.ApplyResources(this.Label13, "Label13");
            this.Label13.Name = "Label13";
            resources.ApplyResources(this.Label12, "Label12");
            this.Label12.Name = "Label12";
            this.tbWorkX0Cmd.DataBindings.Add(new Binding("Text", MySettings.Default, "WorkX0Cmd", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbWorkX0Cmd, "tbWorkX0Cmd");
            this.tbWorkX0Cmd.Name = "tbWorkX0Cmd";
            this.tbWorkX0Cmd.Text = MySettings.Default.WorkX0Cmd;
            this.tbSettingsZeroXYZCmd.DataBindings.Add(new Binding("Text", MySettings.Default, "Work0Cmd", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsZeroXYZCmd, "tbSettingsZeroXYZCmd");
            this.tbSettingsZeroXYZCmd.Name = "tbSettingsZeroXYZCmd";
            this.tbSettingsZeroXYZCmd.Text = MySettings.Default.Work0Cmd;
            resources.ApplyResources(this.Label11, "Label11");
            this.Label11.Name = "Label11";
            this.ToolTip1.SetToolTip(this.Label11, resources.GetString("Label11.ToolTip"));
            this.tbSettingsSpclPosition1.DataBindings.Add(new Binding("Text", MySettings.Default, "MachineSpclPosition1", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsSpclPosition1, "tbSettingsSpclPosition1");
            this.tbSettingsSpclPosition1.Name = "tbSettingsSpclPosition1";
            this.tbSettingsSpclPosition1.Text = MySettings.Default.MachineSpclPosition1;
            this.gbSettingsJogging.Controls.Add(this.cbSettingsKeyboardJogging);
            this.gbSettingsJogging.Controls.Add(this.btnSettingsRefreshJogging);
            this.gbSettingsJogging.Controls.Add(this.Label41);
            this.gbSettingsJogging.Controls.Add(this.Label40);
            this.gbSettingsJogging.Controls.Add(this.Label39);
            this.gbSettingsJogging.Controls.Add(this.Label38);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsZRepeat);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsYRepeat);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsXRepeat);
            this.gbSettingsJogging.Controls.Add(this.Label35);
            this.gbSettingsJogging.Controls.Add(this.Label34);
            this.gbSettingsJogging.Controls.Add(this.Label32);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsFRMetric);
            this.gbSettingsJogging.Controls.Add(this.Label33);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsFIMetric);
            this.gbSettingsJogging.Controls.Add(this.Label31);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsFRImperial);
            this.gbSettingsJogging.Controls.Add(this.Label30);
            this.gbSettingsJogging.Controls.Add(this.cbSettingsMetric);
            this.gbSettingsJogging.Controls.Add(this.tbSettingsFIImperial);
            resources.ApplyResources(this.gbSettingsJogging, "gbSettingsJogging");
            this.gbSettingsJogging.Name = "gbSettingsJogging";
            this.gbSettingsJogging.TabStop = false;
            resources.ApplyResources(this.cbSettingsKeyboardJogging, "cbSettingsKeyboardJogging");
            this.cbSettingsKeyboardJogging.Checked = MySettings.Default.JoggingUseKeyboard;
            this.cbSettingsKeyboardJogging.DataBindings.Add(new Binding("Checked", MySettings.Default, "JoggingUseKeyboard", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cbSettingsKeyboardJogging.Name = "cbSettingsKeyboardJogging";
            this.ToolTip1.SetToolTip(this.cbSettingsKeyboardJogging, resources.GetString("cbSettingsKeyboardJogging.ToolTip"));
            this.cbSettingsKeyboardJogging.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnSettingsRefreshJogging, "btnSettingsRefreshJogging");
            this.btnSettingsRefreshJogging.Name = "btnSettingsRefreshJogging";
            this.btnSettingsRefreshJogging.Tag = "Jogging";
            this.btnSettingsRefreshJogging.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.Label41, "Label41");
            this.Label41.Name = "Label41";
            resources.ApplyResources(this.Label40, "Label40");
            this.Label40.Name = "Label40";
            resources.ApplyResources(this.Label39, "Label39");
            this.Label39.Name = "Label39";
            resources.ApplyResources(this.Label38, "Label38");
            this.Label38.Name = "Label38";
            this.tbSettingsZRepeat.DataBindings.Add(new Binding("Text", MySettings.Default, "JoggingZRepeat", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsZRepeat, "tbSettingsZRepeat");
            this.tbSettingsZRepeat.Name = "tbSettingsZRepeat";
            this.tbSettingsZRepeat.Text = MySettings.Default.JoggingZRepeat;
            this.tbSettingsYRepeat.DataBindings.Add(new Binding("Text", MySettings.Default, "JoggingYRepeat", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsYRepeat, "tbSettingsYRepeat");
            this.tbSettingsYRepeat.Name = "tbSettingsYRepeat";
            this.tbSettingsYRepeat.Text = MySettings.Default.JoggingYRepeat;
            this.tbSettingsXRepeat.DataBindings.Add(new Binding("Text", MySettings.Default, "JoggingXRepeat", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsXRepeat, "tbSettingsXRepeat");
            this.tbSettingsXRepeat.Name = "tbSettingsXRepeat";
            this.tbSettingsXRepeat.Text = MySettings.Default.JoggingXRepeat;
            resources.ApplyResources(this.Label35, "Label35");
            this.Label35.Name = "Label35";
            resources.ApplyResources(this.Label34, "Label34");
            this.Label34.Name = "Label34";
            resources.ApplyResources(this.Label32, "Label32");
            this.Label32.Name = "Label32";
            this.tbSettingsFRMetric.DataBindings.Add(new Binding("Text", MySettings.Default, "JoggingFRMetric", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsFRMetric, "tbSettingsFRMetric");
            this.tbSettingsFRMetric.Name = "tbSettingsFRMetric";
            this.tbSettingsFRMetric.Text = MySettings.Default.JoggingFRMetric;
            resources.ApplyResources(this.Label33, "Label33");
            this.Label33.Name = "Label33";
            this.tbSettingsFIMetric.DataBindings.Add(new Binding("Text", MySettings.Default, "JoggingFIMEtric", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsFIMetric, "tbSettingsFIMetric");
            this.tbSettingsFIMetric.Name = "tbSettingsFIMetric";
            this.tbSettingsFIMetric.Text = MySettings.Default.JoggingFIMEtric;
            resources.ApplyResources(this.Label31, "Label31");
            this.Label31.Name = "Label31";
            this.tbSettingsFRImperial.DataBindings.Add(new Binding("Text", MySettings.Default, "JoggingFRImperial", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsFRImperial, "tbSettingsFRImperial");
            this.tbSettingsFRImperial.Name = "tbSettingsFRImperial";
            this.tbSettingsFRImperial.Text = MySettings.Default.JoggingFRImperial;
            resources.ApplyResources(this.Label30, "Label30");
            this.Label30.Name = "Label30";
            resources.ApplyResources(this.cbSettingsMetric, "cbSettingsMetric");
            this.cbSettingsMetric.Checked = MySettings.Default.JoggingUnitsMetric;
            this.cbSettingsMetric.DataBindings.Add(new Binding("Checked", MySettings.Default, "joggingUnitsMetric", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cbSettingsMetric.Name = "cbSettingsMetric";
            this.cbSettingsMetric.UseVisualStyleBackColor = true;
            this.tbSettingsFIImperial.DataBindings.Add(new Binding("Text", MySettings.Default, "JoggingFIImperial", true, DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tbSettingsFIImperial, "tbSettingsFIImperial");
            this.tbSettingsFIImperial.Name = "tbSettingsFIImperial";
            this.tbSettingsFIImperial.Text = MySettings.Default.JoggingFIImperial;
            this.TabPage1.Controls.Add(this.gbEditor);
            this.TabPage1.Controls.Add(this.btnCancel);
            this.TabPage1.Controls.Add(this.btnOK);
            this.TabPage1.Controls.Add(this.dgMacros);
            this.TabPage1.Controls.Add(this.lblStatusLabel);
            this.TabPage1.Controls.Add(this.btnDeleteMacro);
            resources.ApplyResources(this.TabPage1, "TabPage1");
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.gbEditor.Controls.Add(this.btnAdd);
            this.gbEditor.Controls.Add(this.lblGCode);
            this.gbEditor.Controls.Add(this.tbGCode);
            this.gbEditor.Controls.Add(this.lblName);
            this.gbEditor.Controls.Add(this.tbName);
            resources.ApplyResources(this.gbEditor, "gbEditor");
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.TabStop = false;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.lblGCode, "lblGCode");
            this.lblGCode.Name = "lblGCode";
            this.tbGCode.AcceptsReturn = true;
            resources.ApplyResources(this.tbGCode, "tbGCode");
            this.tbGCode.Name = "tbGCode";
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            this.btnCancel.DialogResult = DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.dgMacros.AllowUserToAddRows = false;
            this.dgMacros.AllowUserToDeleteRows = false;
            this.dgMacros.AllowUserToResizeColumns = false;
            this.dgMacros.AllowUserToResizeRows = false;
            this.dgMacros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMacros.Columns.AddRange(new DataGridViewColumn[]
            {
                this.Column1,
                this.Column2
            });
            this.dgMacros.EditMode = DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.dgMacros, "dgMacros");
            this.dgMacros.Name = "dgMacros";
            this.dgMacros.ReadOnly = true;
            this.dgMacros.RowHeadersVisible = false;
            this.dgMacros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMacros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            resources.ApplyResources(this.lblStatusLabel, "lblStatusLabel");
            this.lblStatusLabel.Name = "lblStatusLabel";
            resources.ApplyResources(this.btnDeleteMacro, "btnDeleteMacro");
            this.btnDeleteMacro.Name = "btnDeleteMacro";
            this.btnDeleteMacro.UseVisualStyleBackColor = true;
            this.ofdGcodeFile.DefaultExt = "ngc";
            this.ofdGcodeFile.FileName = "*.*";
            resources.ApplyResources(this.ofdGcodeFile, "ofdGcodeFile");
            this.sfdOffsets.DefaultExt = "xml";
            resources.ApplyResources(this.sfdOffsets, "sfdOffsets");
            this.ofdOffsets.DefaultExt = "xml";
            this.ofdOffsets.FileName = "OpenFileDialog1";
            resources.ApplyResources(this.ofdOffsets, "ofdOffsets");
            resources.ApplyResources(this, "$this");
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.MenuStrip1);
            base.KeyPreview = true;
            base.MainMenuStrip = this.MenuStrip1;
            base.Name = "GrblGui";
            base.SizeGripStyle = SizeGripStyle.Hide;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.tabPgInterface.ResumeLayout(false);
            this.gbOverrides.ResumeLayout(false);
            this.gbOverrides.PerformLayout();
            this.gbState.ResumeLayout(false);
            this.gbPinStatus.ResumeLayout(false);
            this.gbPinStatus.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbMDI.ResumeLayout(false);
            this.gbMDI.PerformLayout();
            this.gbJogging.ResumeLayout(false);
            this.gbJogging.PerformLayout();
            this.gbFeedRate.ResumeLayout(false);
            this.gbFeedRate.PerformLayout();
            this.gbDistance.ResumeLayout(false);
            this.gbDistance.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbGcode.ResumeLayout(false);
            this.gbGcode.PerformLayout();
            ((ISupportInitialize)this.dgvGcode).EndInit();
            this.gbGrbl.ResumeLayout(false);
            this.tcConnection.ResumeLayout(false);
            this.tbGrblCOM.ResumeLayout(false);
            this.tbGrblIP.ResumeLayout(false);
            this.tbGrblIP.PerformLayout();
            this.gbPosition.ResumeLayout(false);
            this.tabCtlPosition.ResumeLayout(false);
            this.tpWork.ResumeLayout(false);
            this.tpWork.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tpOffsets.ResumeLayout(false);
            this.tpOffsets.PerformLayout();
            this.tabPgSettings.ResumeLayout(false);
            this.tabPgSettings.PerformLayout();
            this.gbMiscInfo.ResumeLayout(false);
            this.gbMiscInfo.PerformLayout();
            this.gbGrblSettings.ResumeLayout(false);
            this.gbGrblSettings.PerformLayout();
            ((ISupportInitialize)this.dgGrblSettings).EndInit();
            this.gbSettingsOffsets.ResumeLayout(false);
            this.gbSettingsOffsets.PerformLayout();
            this.gbSettingsMisc.ResumeLayout(false);
            this.gbSettingsMisc.PerformLayout();
            this.gbSettingsPosition.ResumeLayout(false);
            this.gbSettingsPosition.PerformLayout();
            this.gbSettingsJogging.ResumeLayout(false);
            this.gbSettingsJogging.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.gbEditor.ResumeLayout(false);
            this.gbEditor.PerformLayout();
            ((ISupportInitialize)this.dgMacros).EndInit();
            ((ISupportInitialize)this.GrblSettingsBindingSource).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void btnJogArray_Click(object sender, EventArgs e)
        {
            string left = (string)((RepeatButton)sender).Tag;
            if (String.Compare(left, "X+", false) != 0)
            {
                if (String.Compare(left, "X-", false) != 0)
                {
                    if (String.Compare(left, "Y+", false) != 0)
                    {
                        if (String.Compare(left, "Y-", false) != 0)
                        {
                            if (String.Compare(left, "Z+", false) != 0)
                            {
                                if (String.Compare(left, "Z-", false) == 0)
                                {
                                    gcode.sendGCodeLine(this.createJogCommand("Z-"));
                                }
                            }
                            else
                            {
                                gcode.sendGCodeLine(this.createJogCommand("Z"));
                            }
                        }
                        else
                        {
                            gcode.sendGCodeLine(this.createJogCommand("Y-"));
                        }
                    }
                    else
                    {
                        gcode.sendGCodeLine(this.createJogCommand("Y"));
                    }
                }
                else
                {
                    gcode.sendGCodeLine(this.createJogCommand("X-"));
                }
            }
            else
            {
                gcode.sendGCodeLine(this.createJogCommand("X"));
            }
            if (this.GrblVersion == 0)
            {
                gcode.sendGCodeLine("G90");
            }
        }

        private void cbSettingsMetric_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            this.cbUnits.Checked = cb.Checked;
        }

        public void setDistanceMetric(bool metric)
        {
            if (metric)
            {
                string[] info = Strings.Split(this.gbSettingsJogging.Controls["tbSettingsFIMetric"].Text, ",", -1, CompareMethod.Binary);
                if (info.Count<string>() == 4)
                {
                    this.rbDistance1.Text = info[0];
                    this.rbDistance2.Text = info[1];
                    this.rbDistance3.Text = info[2];
                    this.rbDistance4.Text = info[3];
                }
                info = Strings.Split(this.tbSettingsFRMetric.Text, ",", -1, CompareMethod.Binary);
                if (info.Count<string>() == 4)
                {
                    this.rbFeedRate1.Text = info[0];
                    this.rbFeedRate2.Text = info[1];
                    this.rbFeedRate3.Text = info[2];
                    this.rbFeedRate4.Text = info[3];
                    return;
                }
            }
            else
            {
                string[] info = Strings.Split(this.tbSettingsFIImperial.Text, ",", -1, CompareMethod.Binary);
                if (info.Count<string>() == 4)
                {
                    this.rbDistance1.Text = info[0];
                    this.rbDistance2.Text = info[1];
                    this.rbDistance3.Text = info[2];
                    this.rbDistance4.Text = info[3];
                }
                info = Strings.Split(this.tbSettingsFRImperial.Text, ",", -1, CompareMethod.Binary);
                if (info.Count<string>() == 4)
                {
                    this.rbFeedRate1.Text = info[0];
                    this.rbFeedRate2.Text = info[1];
                    this.rbFeedRate3.Text = info[2];
                    this.rbFeedRate4.Text = info[3];
                }
            }
        }

        private void cbUnits_CheckedChanged(CheckBox sender, EventArgs e)
        {
            this.setDistanceMetric(sender.Checked);
        }

        public string createJogCommand(string axis)
        {
            string createJogCommand;
            if (this.GrblVersion == 0)
            {
                createJogCommand = string.Concat(new string[]
                {
                    "G91 ",
                    this.whichUnits(),
                    " G01 ",
                    axis,
                    this.whichDistance(),
                    " F",
                    this.whichFeedRate()
                });
            }
            else
            {
                if (this.GrblVersion == 1)
                {
                    createJogCommand = string.Concat(new string[]
                    {
                        "$J=G91",
                        this.whichUnits(),
                        axis,
                        this.whichDistance(),
                        " F",
                        this.whichFeedRate()
                    });
                }
                else
                {
                    createJogCommand = "";
                }
            }
            return createJogCommand;
        }

        private string whichDistance()
        {
            string whichDistance;
            try
            {
                IEnumerator enumerator = this.gbDistance.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    RadioButton rb = (RadioButton)enumerator.Current;
                    if (rb.Checked)
                    {
                        whichDistance = rb.Text;
                        return whichDistance;
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
            whichDistance = "";
            return whichDistance;
        }

        private string whichFeedRate()
        {
            string whichFeedRate;
            try
            {
                IEnumerator enumerator = this.gbFeedRate.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    RadioButton rb = (RadioButton)enumerator.Current;
                    if (rb.Checked)
                    {
                        whichFeedRate = rb.Text;
                        return whichFeedRate;
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
            whichFeedRate = "";
            return whichFeedRate;
        }

        private string whichUnits()
        {
            string whichUnits;
            if (this.cbUnits.Checked)
            {
                whichUnits = "G21";
            }
            else
            {
                whichUnits = "G20";
            }
            return whichUnits;
        }

        private void rbDistancex_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            string text = (string)rbtn.Tag;
            uint num = < PrivateImplementationDetails >.ComputeStringHash(text);
            if (num <= 416465783u)
            {
                if (num <= 366132926u)
                {
                    if (num != 332577688u)
                    {
                        if (num != 366132926u)
                        {
                            return;
                        }
                        if (String.Compare(text, "F3", false) != 0)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (String.Compare(text, "F1", false) != 0)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    if (num != 382910545u)
                    {
                        if (num != 416465783u)
                        {
                            return;
                        }
                        if (String.Compare(text, "F4", false) != 0)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (String.Compare(text, "F2", false) != 0)
                        {
                            return;
                        }
                    }
                }
                MySettingsProperty.Settings.JoggingFRDefault = Convert.ToString(rbtn.Tag);
                return;
            }
            if (num <= 2347318991u)
            {
                if (num != 2263430896u)
                {
                    if (num != 2347318991u)
                    {
                        return;
                    }
                    if (String.Compare(text, "I1", false) != 0)
                    {
                        return;
                    }
                }
                else
                {
                    if (String.Compare(text, "I4", false) != 0)
                    {
                        return;
                    }
                }
            }
            else
            {
                if (num != 2364096610u)
                {
                    if (num != 2380874229u)
                    {
                        return;
                    }
                    if (String.Compare(text, "I3", false) != 0)
                    {
                        return;
                    }
                }
                else
                {
                    if (String.Compare(text, "I2", false) != 0)
                    {
                        return;
                    }
                }
            }
            MySettingsProperty.Settings.JoggingFIDefault = Convert.ToString(rbtn.Tag);
        }

        public void changeDistanceIncrement(bool up)
        {
            int index = 0;
            checked
            {
                try
                {
                    IEnumerator enumerator = this.gbDistance.Controls.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        if (((RadioButton)enumerator.Current).Checked)
                        {
                            break;
                        }
                        index++;
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
                if (!up)
                {
                    if (index < 3)
                    {
                        ((RadioButton)this.gbDistance.Controls[index + 1]).Checked = true;
                        return;
                    }
                }
                else
                {
                    if (index > 0)
                    {
                        ((RadioButton)this.gbDistance.Controls[index - 1]).Checked = true;
                    }
                }
            }
        }

        public void changeFeedRate(bool up)
        {
            int index = 0;
            checked
            {
                try
                {
                    IEnumerator enumerator = this.gbFeedRate.Controls.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        if (((RadioButton)enumerator.Current).Checked)
                        {
                            break;
                        }
                        index++;
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
                if (!up)
                {
                    if (index < 3)
                    {
                        ((RadioButton)this.gbFeedRate.Controls[index + 1]).Checked = true;
                        return;
                    }
                }
                else
                {
                    if (index > 0)
                    {
                        ((RadioButton)this.gbFeedRate.Controls[index - 1]).Checked = true;
                    }
                }
            }
        }

        public void showOverrides(string data)
        {
            checked
            {
                if (data.Contains("Ov:") || data.Contains("A:"))
                {
                    data = data.Remove(data.Length - 3, 3);
                    string[] array = Strings.Split(data, "|", -1, CompareMethod.Binary);
                    for (int i = 0; i < array.Length; i++)
                    {
                        string[] portion = Strings.Split(array[i], ":", -1, CompareMethod.Binary);
                        string left = portion[0];
                        if (String.Compare(left, "Ov", false) != 0)
                        {
                            if (String.Compare(left, "A", false) == 0)
                            {
                                if (portion[1].Contains("S"))
                                {
                                    this.btnSpindleOverride.BackColor = Color.Coral;
                                }
                                else
                                {
                                    this.btnSpindleOverride.BackColor = Color.Transparent;
                                }
                                if (portion[1].Contains("F"))
                                {
                                    this.btnFloodOverride.BackColor = Color.Coral;
                                }
                                else
                                {
                                    this.btnFloodOverride.BackColor = Color.Transparent;
                                }
                                if (portion[1].Contains("M"))
                                {
                                    this.btnMistOverride.BackColor = Color.Coral;
                                }
                                else
                                {
                                    this.btnMistOverride.BackColor = Color.Transparent;
                                }
                            }
                        }
                        else
                        {
                            string[] ovr = Strings.Split(portion[1], ",", -1, CompareMethod.Binary);
                            this.tbFeedOvr.Text = ovr[0] + "%";
                            if (String.Compare(ovr[0], "100", false) == 0)
                            {
                                this.tbFeedOvr.BackColor = Color.White;
                            }
                            else
                            {
                                this.tbFeedOvr.BackColor = Color.Coral;
                            }
                            this.tbRapidOvr.Text = ovr[1] + "%";
                            if (String.Compare(ovr[1], "100", false) == 0)
                            {
                                this.tbRapidOvr.BackColor = Color.White;
                            }
                            else
                            {
                                this.tbRapidOvr.BackColor = Color.Coral;
                            }
                            this.tbSpindleOvr.Text = ovr[2] + "%";
                            if (String.Compare(ovr[2], "100", false) == 0)
                            {
                                this.tbSpindleOvr.BackColor = Color.White;
                            }
                            else
                            {
                                this.tbSpindleOvr.BackColor = Color.Coral;
                            }
                            if (!data.Contains("A"))
                            {
                                this.btnSpindleOverride.BackColor = Color.Transparent;
                                this.btnFloodOverride.BackColor = Color.Transparent;
                                this.btnMistOverride.BackColor = Color.Transparent;
                            }
                        }
                    }
                }
            }
        }

        private void btnFeedOverride_Click(object sender, EventArgs e)
        {
            string left = (string)((Button)sender).Tag;
            if (String.Compare(left, "plus", false) != 0)
            {
                if (String.Compare(left, "minus", false) != 0)
                {
                    return;
                }
                if (this.cbFeedCoarse.Checked)
                {
                    this.grblPort.SendData(Convert.ToString(Strings.Chr(146)));
                    return;
                }
                this.grblPort.SendData(Convert.ToString(Strings.Chr(148)));
                return;
            }
            else
            {
                if (this.cbFeedCoarse.Checked)
                {
                    this.grblPort.SendData(Convert.ToString(Strings.Chr(145)));
                    return;
                }
                this.grblPort.SendData(Convert.ToString(Strings.Chr(147)));
                return;
            }
        }

        private void btnRapidOverride_Click(object sender, EventArgs e)
        {
            string left = (string)((Button)sender).Tag;
            if (String.Compare(left, "50", false) == 0)
            {
                this.grblPort.SendData(Convert.ToString(Strings.Chr(150)));
                return;
            }
            if (String.Compare(left, "25", false) != 0)
            {
                return;
            }
            this.grblPort.SendData(Convert.ToString(Strings.Chr(151)));
        }

        private void btnSpindleOverride_Click(object sender, EventArgs e)
        {
            string left = (string)((Button)sender).Tag;
            if (String.Compare(left, "plus", false) != 0)
            {
                if (String.Compare(left, "minus", false) != 0)
                {
                    return;
                }
                if (this.cbSpindleCoarse.Checked)
                {
                    this.grblPort.SendData(Convert.ToString(Strings.Chr(155)));
                    return;
                }
                this.grblPort.SendData(Convert.ToString(Strings.Chr(157)));
                return;
            }
            else
            {
                if (this.cbSpindleCoarse.Checked)
                {
                    this.grblPort.SendData(Convert.ToString(Strings.Chr(154)));
                    return;
                }
                this.grblPort.SendData(Convert.ToString(Strings.Chr(156)));
                return;
            }
        }

        private void btnFeedOverrideReset_Click(object sender, EventArgs e)
        {
            string left = (string)((Button)sender).Tag;
            if (String.Compare(left, "Rapid", false) == 0)
            {
                this.grblPort.SendData(Convert.ToString(Strings.Chr(149)));
                return;
            }
            if (String.Compare(left, "Feed", false) == 0)
            {
                this.grblPort.SendData(Convert.ToString(Strings.Chr(144)));
                return;
            }
            if (String.Compare(left, "Spindle", false) != 0)
            {
                return;
            }
            this.grblPort.SendData(Convert.ToString(Strings.Chr(153)));
        }

        private void btnToggleOverride_Click(object sender, EventArgs e)
        {
            string left = (string)((Button)sender).Tag;
            if (String.Compare(left, "SpindleOverride", false) == 0)
            {
                this.grblPort.SendData(Convert.ToString(Strings.Chr(158)));
                return;
            }
            if (String.Compare(left, "FloodOverride", false) == 0)
            {
                this.grblPort.SendData(Convert.ToString(Strings.Chr(160)));
                return;
            }
            if (String.Compare(left, "MistOverride", false) != 0)
            {
                return;
            }
            this.grblPort.SendData(Convert.ToString(Strings.Chr(161)));
        }

        public void showGrblPins(string data)
        {
            checked
            {
                if (String.Compare(data, "\r\n", false) != 0)
                {
                    if (this.GrblVersion == 0 && data.Contains("Lim:"))
                    {
                        if (!this.pins.LimitsSeen)
                        {
                            this.pins.LimitsSeen = true;
                        }
                        int pos = Strings.InStr(data, "Lim:", CompareMethod.Binary);
                        this.cbLimitZ.Checked = (String.Compare(Convert.ToString(data[pos + 3]), "1", false) == 0);
                        this.cbLimitY.Checked = (String.Compare(Convert.ToString(data[pos + 4]), "1", false) == 0);
                        this.cbLimitX.Checked = (String.Compare(Convert.ToString(data[pos + 5]), "1", false) == 0);
                    }
                    if (this.GrblVersion == 1 && String.Compare(Convert.ToString(data[0]), "<", false) == 0 && data.Contains("Pn:"))
                    {
                        if (!this.pins.PinsSeen)
                        {
                            this.pins.PinsSeen = true;
                        }
                        data = data.Remove(data.Length - 3, 3);
                        string[] array = Strings.Split(data, "|", -1, CompareMethod.Binary);
                        for (int i = 0; i < array.Length; i++)
                        {
                            string[] portion = Strings.Split(array[i], ":", -1, CompareMethod.Binary);
                            string left = portion[0];
                            if (String.Compare(left, "Pn", false) == 0)
                            {
                                string pinlist = portion[1];
                                this.cbProbePin.Checked = (Strings.InStr(pinlist, "P", CompareMethod.Binary) > 0);
                                this.cbDoorOpen.Checked = (Strings.InStr(pinlist, "D", CompareMethod.Binary) > 0);
                                this.cbFeedHold.Checked = (Strings.InStr(pinlist, "H", CompareMethod.Binary) > 0);
                                this.cbResetAbort.Checked = (Strings.InStr(pinlist, "R", CompareMethod.Binary) > 0);
                                this.cbStartResume.Checked = (Strings.InStr(pinlist, "S", CompareMethod.Binary) > 0);
                                this.cbLimitX.Checked = (Strings.InStr(pinlist, "X", CompareMethod.Binary) > 0);
                                this.cbLimitY.Checked = (Strings.InStr(pinlist, "Y", CompareMethod.Binary) > 0);
                                this.cbLimitZ.Checked = (Strings.InStr(pinlist, "Z", CompareMethod.Binary) > 0);
                            }
                        }
                    }
                }
            }
        }

        private void btnStatusClearPins_Click(object sender, EventArgs e)
        {
            this.cbProbePin.Checked = false;
            this.cbDoorOpen.Checked = false;
            this.cbFeedHold.Checked = false;
            this.cbResetAbort.Checked = false;
            this.cbStartResume.Checked = false;
            this.cbLimitX.Checked = false;
            this.cbLimitY.Checked = false;
            this.cbLimitZ.Checked = false;
        }

        public void showGrblPositions(string data)
        {
            checked
            {
                if (String.Compare(data, "\r\n", false) != 0)
                {
                    if (this.GrblVersion == 0)
                    {
                        data = data.Remove(data.Length - 3, 3);
                        if (data.Contains("MPos:"))
                        {
                            string[] positions = Strings.Split(data, ":", -1, CompareMethod.Binary);
                            string[] machPos = Strings.Split(positions[1], ",", -1, CompareMethod.Binary);
                            this.tbMachX.Text = machPos[0].ToString();
                            this.tbMachY.Text = machPos[1].ToString();
                            this.tbMachZ.Text = machPos[2].ToString();
                            this.tbOffSetsMachX.Text = machPos[0].ToString();
                            this.tbOffSetsMachY.Text = machPos[1].ToString();
                            this.tbOffSetsMachZ.Text = machPos[2].ToString();
                        }
                        if (data.Contains("WPos:"))
                        {
                            string[] positions = Strings.Split(data, ":", -1, CompareMethod.Binary);
                            string[] workPos;
                            if (positions.Count<string>() == 2)
                            {
                                workPos = Strings.Split(positions[1], ",", -1, CompareMethod.Binary);
                            }
                            else
                            {
                                workPos = Strings.Split(positions[2], ",", -1, CompareMethod.Binary);
                            }
                            this.tbWorkX.Text = workPos[0].ToString();
                            this.tbWorkY.Text = workPos[1].ToString();
                            this.tbWorkZ.Text = workPos[2].ToString();
                        }
                    }
                    if (this.GrblVersion == 1 && data.StartsWith("<"))
                    {
                        data = data.Remove(data.Length - 3, 3);
                        string[] array = Strings.Split(data, "|", -1, CompareMethod.Binary);
                        for (int i = 0; i < array.Length; i++)
                        {
                            string[] portion = Strings.Split(array[i], ":", -1, CompareMethod.Binary);
                            string left = portion[0];
                            if (String.Compare(left, "WCO", false) != 0)
                            {
                                if (String.Compare(left, "MPos", false) != 0)
                                {
                                    if (String.Compare(left, "WPos", false) == 0)
                                    {
                                        string[] workPos2 = Strings.Split(portion[1], ",", -1, CompareMethod.Binary);
                                        if (!this.tbWorkX.ContainsFocus)
                                        {
                                            this.tbWorkX.Text = this.TruncRound(Convert.ToDecimal(workPos2[0])).ToString();
                                        }
                                        if (!this.tbWorkY.ContainsFocus)
                                        {
                                            this.tbWorkY.Text = this.TruncRound(Convert.ToDecimal(workPos2[1])).ToString();
                                        }
                                        if (!this.tbWorkZ.ContainsFocus)
                                        {
                                            this.tbWorkZ.Text = this.TruncRound(Convert.ToDecimal(workPos2[2])).ToString();
                                        }
                                        this.tbMachX.Text = this.TruncRound(decimal.Add(Convert.ToDecimal(workPos2[0]), this.position.WcoX)).ToString();
                                        this.tbMachY.Text = this.TruncRound(decimal.Add(Convert.ToDecimal(workPos2[1]), this.position.WcoY)).ToString();
                                        this.tbMachZ.Text = this.TruncRound(decimal.Add(Convert.ToDecimal(workPos2[2]), this.position.WcoZ)).ToString();
                                    }
                                }
                                else
                                {
                                    string[] machPos2 = Strings.Split(portion[1], ",", -1, CompareMethod.Binary);
                                    this.tbMachX.Text = this.TruncRound(Convert.ToDecimal(machPos2[0])).ToString();
                                    this.tbMachY.Text = this.TruncRound(Convert.ToDecimal(machPos2[1])).ToString();
                                    this.tbMachZ.Text = this.TruncRound(Convert.ToDecimal(machPos2[2])).ToString();
                                    if (!this.tbWorkX.ContainsFocus)
                                    {
                                        this.tbWorkX.Text = this.TruncRound(decimal.Subtract(Convert.ToDecimal(machPos2[0]), this.position.WcoX)).ToString();
                                    }
                                    if (!this.tbWorkY.ContainsFocus)
                                    {
                                        this.tbWorkY.Text = this.TruncRound(decimal.Subtract(Convert.ToDecimal(machPos2[1]), this.position.WcoY)).ToString();
                                    }
                                    if (!this.tbWorkZ.ContainsFocus)
                                    {
                                        this.tbWorkZ.Text = this.TruncRound(decimal.Subtract(Convert.ToDecimal(machPos2[2]), this.position.WcoZ)).ToString();
                                    }
                                    this.tbOffSetsMachX.Text = this.tbMachX.Text;
                                    this.tbOffSetsMachY.Text = this.tbMachY.Text;
                                    this.tbOffSetsMachZ.Text = this.tbMachZ.Text;
                                }
                            }
                            else
                            {
                                string[] wco = Strings.Split(portion[1], ",", -1, CompareMethod.Binary);
                                this.position.WcoX = Conversions.ToDecimal(wco[0]);
                                this.position.WcoY = Conversions.ToDecimal(wco[1]);
                                this.position.WcoZ = Conversions.ToDecimal(wco[2]);
                            }
                        }
                    }
                }
            }
        }

        private decimal TruncRound(decimal value)
        {
            decimal TruncRound;
            if (String.Compare(this.tbTruncationDigits.Text, "0", false) == 0)
            {
                TruncRound = value;
            }
            else
            {
                if (char.IsDigit(this.tbTruncationDigits.Text))
                {
                    TruncRound = Math.Round(Convert.ToDecimal(value), (int)Convert.ToInt16(this.tbTruncationDigits.Text));
                }
                else
                {
                    TruncRound = value;
                }
            }
            return TruncRound;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            string left = (string)((Button)sender).Tag;
            if (String.Compare(left, "HomeCycle", false) == 0)
            {
                gcode.sendGCodeLine("$H");
                this.btnHome.BackColor = Color.Transparent;
                this.tabCtlPosition.SelectedTab = this.tpWork;
                return;
            }
            if (String.Compare(left, "Spcl Posn1", false) == 0)
            {
                gcode.sendGCodeLine(this.tbSettingsSpclPosition1.Text);
                return;
            }
            if (String.Compare(left, "Spcl Posn2", false) == 0)
            {
                gcode.sendGCodeLine(this.tbSettingsSpclPosition2.Text);
                return;
            }
            if (String.Compare(left, "ZeroXYZ", false) != 0)
            {
                return;
            }
            gcode.sendGCodeLine(this.tbSettingsZeroXYZCmd.Text);
        }

        private void btnWorkXYZ0_Click(object sender, EventArgs e)
        {
            string left = (string)((Button)sender).Tag;
            if (String.Compare(left, "X", false) == 0)
            {
                gcode.sendGCodeLine(MySettingsProperty.Settings.WorkX0Cmd);
                return;
            }
            if (String.Compare(left, "Y", false) == 0)
            {
                gcode.sendGCodeLine(MySettingsProperty.Settings.WorkY0Cmd);
                return;
            }
            if (String.Compare(left, "Z", false) != 0)
            {
                return;
            }
            gcode.sendGCodeLine(MySettingsProperty.Settings.WorkZ0Cmd);
        }

        private void tbWork_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void btnSettingsRefreshMisc_Click(object sender, EventArgs e)
        {
            string left = (string)((Button)sender).Tag;
            if (String.Compare(left, "Misc", false) == 0)
            {
                this.changeStatusRate(Convert.ToInt32(MySettingsProperty.Settings.StatusPollInterval));
                this.prgBarQ.Maximum = Convert.ToInt32(MySettingsProperty.Settings.QBuffMaxSize);
                this.prgbRxBuf.Maximum = Convert.ToInt32(MySettingsProperty.Settings.RBuffMaxSize);
                this.cbStatusPollEnable.Checked = MySettingsProperty.Settings.StatusPollEnabled;
                this.cbSettingsConnectOnLoad.Checked = MySettingsProperty.Settings.GrblConnectOnLoad;
                return;
            }
            if (String.Compare(left, "Position", false) == 0)
            {
                this.tbSettingsSpclPosition1.Text = MySettingsProperty.Settings.MachineSpclPosition1;
                this.tbSettingsSpclPosition2.Text = MySettingsProperty.Settings.MachineSpclPosition2;
                return;
            }
            if (String.Compare(left, "Jogging", false) != 0)
            {
                return;
            }
            this.tbSettingsFIImperial.Text = MySettingsProperty.Settings.JoggingFIImperial;
            this.tbSettingsFRImperial.Text = MySettingsProperty.Settings.JoggingFRImperial;
            this.tbSettingsFIMetric.Text = MySettingsProperty.Settings.JoggingFIMEtric;
            this.tbSettingsFRMetric.Text = MySettingsProperty.Settings.JoggingFRMetric;
            this.cbSettingsMetric.Checked = MySettingsProperty.Settings.JoggingUnitsMetric;
            this.setDistanceMetric(this.cbSettingsMetric.Checked);
            checked
            {
                this.btnXPlus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(MySettingsProperty.Settings.JoggingXRepeat));
                this.btnXMinus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(MySettingsProperty.Settings.JoggingXRepeat));
                this.btnYPlus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(MySettingsProperty.Settings.JoggingYRepeat));
                this.btnYMinus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(MySettingsProperty.Settings.JoggingYRepeat));
                this.btnZPlus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(MySettingsProperty.Settings.JoggingZRepeat));
                this.btnZMinus.Interval = (int)Math.Round(1000.0 / Conversions.ToDouble(MySettingsProperty.Settings.JoggingZRepeat));
            }
        }

        private void btnSettingsGrbl_Click(object sender, EventArgs e)
        {
            this.settings.RefreshSettings();
        }

        private void dgGrblSettings_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DataGridView gridView = (DataGridView)sender;
                if (!Information.IsNothing(gridView.EditingControl))
                {
                    string param = gridView.Rows[e.RowIndex].Cells[0].Value.ToString() + "=" + gridView.EditingControl.Text;
                    gcode.sendGCodeLine(param);
                    Thread.Sleep(200);
                    gcode.sendGCodeLine("$$");
                }
            }
        }

        private void cbxState_SelectionChangeCommittted(object sender, EventArgs e)
        {
            string code = Convert.ToString(((ComboBox)sender).SelectedItem);
            if (String.Compare(code, "", false) != 0)
            {
                code = code.Substring(checked(code.Length - 3), 3);
                gcode.sendGCodeLine(code);
            }
        }

        public void statusPrompt(string operation)
        {
            TimerCallback tcb = new TimerCallback(this._statusThreadProc);
            object arg_13_0 = 0;
            if (String.Compare(operation, Resources.MsgFilter_PreFilterMessage_Start, false) == 0)
            {
                this._statusTimer = new System.Threading.Timer(tcb, this.status.timerState, 0, (int)Convert.ToInt16(MySettingsProperty.Settings.StatusPollInterval));
            }
            if (String.Compare(operation, Resources.GrblGui_btnConnDisconnect_Click_End, false) == 0 && !Information.IsNothing(this._statusTimer))
            {
                this._statusTimer.Change(-1, -1);
            }
        }

        public void changeStatusRate(int newrate)
        {
            if (!Information.IsNothing(this._statusTimer))
            {
                this._statusTimer.Change(0, newrate);
            }
        }

        public void _statusThreadProc(object stateInfo)
        {
            GrblStatus.TimerInfo state = (GrblStatus.TimerInfo)stateInfo;
            checked
            {
                state.count++;
                if (state.count == 10)
                {
                    state.count = 0;
                }
                if (this.cbStatusPollEnable.CheckState > CheckState.Unchecked)
                {
                    this.grblPort.SendData("?");
                }
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            this.grblPort.SendData("$x");
            this.tabCtlPosition.SelectedTab = this.tpWork;
            this.btnHome.BackColor = Color.Transparent;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gcode.ResetGcode(false);
            this.grblPort.SendData("\u0018");
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            this.grblPort.SendData("!");
        }

        private void btnStartResume_Click(object sender, EventArgs e)
        {
            this.grblPort.SendData("~");
        }

        public void showGrblStatus(string data)
        {
            checked
            {
                if (String.Compare(Convert.ToString(data[0]), "\n", false) != 0 && String.Compare(Convert.ToString(data[0]), "\r", false) != 0)
                {
                    if (this.cbVerbose.Checked)
                    {
                        this.lbResponses.Items.Add(data);
                        if (this.lbResponses.Items.Count > 1)
                        {
                            this.lbResponses.TopIndex = this.lbResponses.Items.Count - 1;
                        }
                    }
                    else
                    {
                        if (data.Length > 0 && String.Compare(Convert.ToString(data.First<char>()), "<", false) != 0 && String.Compare(Convert.ToString(data.First<char>()), "o", false) != 0 && String.Compare(Convert.ToString(data.First<char>()), "$", false) != 0 && String.Compare(Convert.ToString(data.First<char>()), "G", false) != 0 && (String.Compare(Convert.ToString(data.First<char>()), "[", false) != 0 || !data.Contains("F")) && !data.StartsWith("error:"))
                        {
                            this.lbResponses.Items.Add(data);
                            this.lbResponses.TopIndex = this.lbResponses.Items.Count - 1;
                        }
                    }
                    if (this.lbResponses.Items.Count > 100)
                    {
                        this.lbResponses.Items.RemoveAt(0);
                        this.lbResponses.TopIndex = this.lbResponses.Items.Count - 1;
                    }
                    if (data.StartsWith("Grbl"))
                    {
                        this.GrblVersion = Convert.ToInt32(data.Substring(5, 1));
                        if (this.GrblVersion == 1)
                        {
                            this.pins.PinsSeen = true;
                        }
                        else
                        {
                            this.pins.LimitsSeen = true;
                        }
                        this.tbGrblVersion.Text = Strings.Split(data, "[", -1, CompareMethod.Binary)[0];
                        this.state.GrblConnected("Connected");
                        gcode.ResetGcode(false);
                    }
                    if (data.StartsWith("error:") && char.IsDigit(data["error:".Length + 1]))
                    {
                        int errorCode = (int)Convert.ToInt16(data.Substring(6, data.Length - 6 - 2));
                        data = data + " -> " + this._errors[Convert.ToString(errorCode)];
                        this.lbResponses.Items.Add(data);
                        this.lbResponses.TopIndex = this.lbResponses.Items.Count - 1;
                    }
                    if (this.GrblVersion == 0)
                    {
                        if (data.Contains("Buf:"))
                        {
                            data = data.Remove(data.Length - 3, 3);
                            string[] positions = Strings.Split(data, ":", -1, CompareMethod.Binary);
                            try
                            {
                                string[] buffer = Strings.Split(positions[3], ",", -1, CompareMethod.Binary);
                                string[] rx = Strings.Split(positions[4], ",", -1, CompareMethod.Binary);
                                this.prgbRxBuf.Value = Convert.ToInt32(rx[0]);
                                this.prgBarQ.Value = Convert.ToInt32(buffer[0]);
                            }
                            catch (Exception arg_32F_0)
                            {
                                ProjectData.SetProjectError(arg_32F_0);
                                ProjectData.ClearProjectError();
                            }
                        }
                        string[] status = Strings.Split(data, ",", -1, CompareMethod.Binary);
                        if (!Information.IsNothing(status))
                        {
                            this.statusSetIndicators(status[0]);
                        }
                        if (String.Compare(status[0], "<Idle", false) == 0 || String.Compare(status[0], "<Run", false) == 0)
                        {
                            this.btnUnlock.BackColor = Color.Transparent;
                            this.btnHold.BackColor = Color.Transparent;
                            this.btnReset.BackColor = Color.Transparent;
                            this.btnStartResume.BackColor = Color.Transparent;
                            this.btnStartResume.Text = Resources.MsgFilter_PreFilterMessage_Start;
                        }
                        if (data.StartsWith("<Queue") || data.StartsWith("<Hold"))
                        {
                            this.btnStartResume.BackColor = Color.Crimson;
                            this.btnStartResume.Text = Resources.GrblGui_showGrblStatus_Resume;
                        }
                        if (String.Compare(status[0], "<Alarm", false) == 0)
                        {
                            this.btnUnlock.BackColor = Color.Crimson;
                        }
                        if (String.Compare(status[0], "<Alarm", false) == 0 || status[0].StartsWith("ALARM"))
                        {
                            this.statusSetIndicators(status[0].Substring(0, 6));
                        }
                        if (String.Compare(Convert.ToString(data[0]), "[", false) == 0 && data.Contains("F"))
                        {
                            this.state.ProcessGCode(data);
                        }
                    }
                    if (this.GrblVersion == 1)
                    {
                        data.StartsWith("[MSG:");
                        if (data.StartsWith("[GC:"))
                        {
                            this.state.ProcessGCode(data);
                        }
                        if (data.StartsWith("<"))
                        {
                            data = data.Remove(data.Length - 3, 3);
                            string[] array = Strings.Split(data, "|", -1, CompareMethod.Binary);
                            for (int i = 0; i < array.Length; i++)
                            {
                                string[] portion = Strings.Split(array[i], ":", -1, CompareMethod.Binary);
                                string text = portion[0];
                                uint num = < PrivateImplementationDetails >.ComputeStringHash(text);
                                if (num <= 1976784350u)
                                {
                                    if (num <= 987596377u)
                                    {
                                        if (num != 699605275u)
                                        {
                                            if (num == 987596377u)
                                            {
                                                if (String.Compare(text, "Bf", false) == 0)
                                                {
                                                    string[] values = Strings.Split(portion[1], ",", -1, CompareMethod.Binary);
                                                    try
                                                    {
                                                        this.prgBarQ.Value = (int)Math.Round(unchecked(15.0 - Conversions.ToDouble(values[0])));
                                                        this.prgbRxBuf.Value = (int)Math.Round(unchecked(128.0 - Conversions.ToDouble(values[1])));
                                                    }
                                                    catch (Exception arg_913_0)
                                                    {
                                                        ProjectData.SetProjectError(arg_913_0);
                                                        ProjectData.ClearProjectError();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (String.Compare(text, "<Door", false) == 0)
                                            {
                                                this.tbCurrentStatus.BackColor = Color.LightGreen;
                                                this.tbCurrentStatus.Text = "DOOR";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (num != 1539971036u)
                                        {
                                            if (num != 1581177773u)
                                            {
                                                if (num == 1976784350u)
                                                {
                                                    if (String.Compare(text, "FS", false) != 0)
                                                    {
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (String.Compare(text, "<Check", false) == 0)
                                                {
                                                    this.btnCheckMode.BackColor = Color.Crimson;
                                                    this.tbCurrentStatus.BackColor = Color.LightGreen;
                                                    this.tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_CHECK;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (String.Compare(text, "<Run", false) == 0)
                                            {
                                                this.btnUnlock.BackColor = Color.Transparent;
                                                this.btnHold.BackColor = Color.Transparent;
                                                this.btnReset.BackColor = Color.Transparent;
                                                this.btnStartResume.BackColor = Color.Transparent;
                                                this.btnStartResume.Text = Resources.MsgFilter_PreFilterMessage_Start;
                                                this.tbCurrentStatus.BackColor = Color.LightGreen;
                                                this.tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_RUN;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (num <= 2795595633u)
                                    {
                                        if (num != 2397059160u)
                                        {
                                            if (num != 2605235321u)
                                            {
                                                if (num == 2795595633u)
                                                {
                                                    if (String.Compare(text, "<Idle", false) == 0)
                                                    {
                                                        this.btnUnlock.BackColor = Color.Transparent;
                                                        this.btnHold.BackColor = Color.Transparent;
                                                        this.btnReset.BackColor = Color.Transparent;
                                                        this.btnCheckMode.BackColor = Color.Transparent;
                                                        this.btnStartResume.BackColor = Color.Transparent;
                                                        this.btnStartResume.Text = Resources.MsgFilter_PreFilterMessage_Start;
                                                        this.tbCurrentStatus.BackColor = Color.LightGreen;
                                                        this.tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_IDLE;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (String.Compare(text, "<Jog", false) == 0)
                                                {
                                                    this.tbCurrentStatus.BackColor = Color.LightGreen;
                                                    this.tbCurrentStatus.Text = "JOG";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (String.Compare(text, "<Home", false) == 0)
                                            {
                                                this.tbCurrentStatus.BackColor = Color.LightGreen;
                                                this.tbCurrentStatus.Text = "HOME";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (num != 2984128730u)
                                        {
                                            if (num != 3272340793u)
                                            {
                                                if (num == 3988724808u)
                                                {
                                                    if (String.Compare(text, "<Alarm", false) == 0)
                                                    {
                                                        this.btnUnlock.BackColor = Color.Crimson;
                                                        this.statusSetIndicators("<Alarm");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (String.Compare(text, "F", false) != 0)
                                                {
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (String.Compare(text, "<Hold", false) == 0)
                                            {
                                                this.btnStartResume.BackColor = Color.Crimson;
                                                this.btnStartResume.Text = Resources.GrblGui_showGrblStatus_Resume;
                                                this.tbCurrentStatus.BackColor = Color.LightGreen;
                                                this.tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_HOLD;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (data.StartsWith("ALARM"))
                        {
                            this.statusSetIndicators(data.Substring(0, 6));
                        }
                    }
                    if (String.Compare(Convert.ToString(data[0]), "$", false) == 0 && char.IsDigit(data[1]))
                    {
                        this.settings.FillSettings(data);
                    }
                }
            }
        }

        private void statusSetIndicators(string status)
        {
            uint num = < PrivateImplementationDetails >.ComputeStringHash(status);
            if (num <= 1799202042u)
            {
                if (num != 1539971036u)
                {
                    if (num != 1581177773u)
                    {
                        if (num != 1799202042u)
                        {
                            return;
                        }
                        if (String.Compare(status, "ALARM", false) != 0)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (String.Compare(status, "<Check", false) != 0)
                        {
                            return;
                        }
                        this.tbCurrentStatus.BackColor = Color.YellowGreen;
                        this.tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_CHECK;
                        return;
                    }
                }
                else
                {
                    if (String.Compare(status, "<Run", false) != 0)
                    {
                        return;
                    }
                    this.tbCurrentStatus.BackColor = Color.LightGreen;
                    this.tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_RUN;
                    return;
                }
            }
            else
            {
                if (num > 2795595633u)
                {
                    if (num != 3110289738u)
                    {
                        if (num == 3988724808u)
                        {
                            if (String.Compare(status, "<Alarm", false) != 0)
                            {
                                return;
                            }
                            goto IL_C5;
                        }
                    }
                    else
                    {
                        if (String.Compare(status, "<Queue", false) != 0)
                        {
                            return;
                        }
                        this.tbCurrentStatus.BackColor = Color.YellowGreen;
                        this.tbCurrentStatus.Text = "QUEUE";
                    }
                    return;
                }
                if (num != 2450152000u)
                {
                    if (num != 2795595633u)
                    {
                        return;
                    }
                    if (String.Compare(status, "<Idle", false) != 0)
                    {
                        return;
                    }
                    this.tbCurrentStatus.BackColor = Color.LightGreen;
                    this.tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_IDLE;
                    return;
                }
                else
                {
                    if (String.Compare(status, "ALARM:", false) != 0)
                    {
                        return;
                    }
                }
            }
            IL_C5:
            this.tbCurrentStatus.BackColor = Color.Red;
            this.tbCurrentStatus.Text = "ALARM";
        }
        */
    }
}