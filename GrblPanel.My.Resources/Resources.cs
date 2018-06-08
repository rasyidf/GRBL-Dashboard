using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
namespace GrblPanel.My.Resources
{
	[StandardModule, HideModuleName, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal sealed class Resources
	{
		private static ResourceManager resourceMan;
		private static CultureInfo resourceCulture;
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					Resources.resourceMan = new ResourceManager("GrblPanel.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}
		internal static string AboutBox_AboutBox_Load_ForMoreDetailsOnThisAppPleaseVisit
		{
			get
			{
				return Resources.ResourceManager.GetString("AboutBox_AboutBox_Load_ForMoreDetailsOnThisAppPleaseVisit", Resources.resourceCulture);
			}
		}
		internal static string AboutBox_AboutBox_Load_GrblPanelIsDesignedForUseWithGrbl09GOrLater
		{
			get
			{
				return Resources.ResourceManager.GetString("AboutBox_AboutBox_Load_GrblPanelIsDesignedForUseWithGrbl09GOrLater", Resources.resourceCulture);
			}
		}
		internal static string Button_Connection_Text_Connect
		{
			get
			{
				return Resources.ResourceManager.GetString("Button_Connection_Text_Connect", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_AlarmLock
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_AlarmLock", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_ArcRadiusError
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_ArcRadiusError", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_AxisCommandConflict
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_AxisCommandConflict", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_AxisWordsExist
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_AxisWordsExist", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_BadNumberFormat
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_BadNumberFormat", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_BuildInfoLength
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_BuildInfoLength", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_CheckDoor
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_CheckDoor", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_CommandValueIsNotInteger
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_CommandValueIsNotInteger", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_EEPROMReadFailUsingDefaults
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_EEPROMReadFailUsingDefaults", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_ExpectedCommandLetter
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_ExpectedCommandLetter", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_G43DynamicAxisError
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_G43DynamicAxisError", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_G53InvalidMotionMode
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_G53InvalidMotionMode", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_HomingIsNotEnabled
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_HomingIsNotEnabled", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_InvalidLineNumber
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_InvalidLineNumber", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_InvalidStatement
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_InvalidStatement", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_InvalidTarget
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_InvalidTarget", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_InvalidToolNumber
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_InvalidToolNumber", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_JogFormat
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_JogFormat", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_JogTravel
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_JogTravel", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_LineOverflow
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_LineOverflow", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_ModalGroupViolation
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_ModalGroupViolation", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_New_Line
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_New_Line", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_NoAxisWords
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_NoAxisWords", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_NoAxisWordsInPlane
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_NoAxisWordsInPlane", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_NoOffsetsInPlane
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_NoOffsetsInPlane", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_NotIdle
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_NotIdle", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_SettingDisabled
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_SettingDisabled", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_StepRate30kHz
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_StepRate30kHz", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_UndefinedFeedRate
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_UndefinedFeedRate", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_UnsupportedCommand
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_UnsupportedCommand", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_UnsupportedCoordinateSystem
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_UnsupportedCoordinateSystem", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_UnusedWords
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_UnusedWords", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_Value0
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_Value0", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_Value3Usec
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_Value3Usec", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_ValueWordMissing
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_ValueWordMissing", Resources.resourceCulture);
			}
		}
		internal static string GrblGcodeView_WordRepeated
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGcodeView_WordRepeated", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnAdd_Click_DataValidationError
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnAdd_Click_DataValidationError", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnAdd_Click_YouCannotCreateAMacroWithoutAName
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnAdd_Click_YouCannotCreateAMacroWithoutAName", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnAdd_Click_YouNeedToAddSomeGCodeToSaveAMacro
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnAdd_Click_YouNeedToAddSomeGCodeToSaveAMacro", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_And_A_Port_Number_In_The_Format
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_And_A_Port_Number_In_The_Format", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_Connect
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Connect", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_Connect_Error
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Connect_Error", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_Disconnect
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Disconnect", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_Disconnected
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Disconnected", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_End
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_End", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_Idle
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Idle", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_Or_Connect_The_Cable
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Or_Connect_The_Cable", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_OrConnectTheCable
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_OrConnectTheCable", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_Please_Enter_An_IP_Address
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Please_Enter_An_IP_Address", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_Please_Select_A_Com_Port
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Please_Select_A_Com_Port", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnConnDisconnect_Click_PleaseSelectAComPort
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_PleaseSelectAComPort", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnDeleteMacro_Click_AreYouSureYouWantToDeleteThe
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnDeleteMacro_Click_AreYouSureYouWantToDeleteThe", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_btnDeleteMacro_Click_ConfirmDelete
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_btnDeleteMacro_Click_ConfirmDelete", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_dgMacros_DoubleClick_Update
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_dgMacros_DoubleClick_Update", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_grblgui_unload_Are_You_Certain_That_You_Want_To_Close
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_grblgui_unload_Are_You_Certain_That_You_Want_To_Close", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_grblgui_unload_AreYouCertainThatYouWantToClose
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_grblgui_unload_AreYouCertainThatYouWantToClose", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_GrblMacroButtons_FormClosing_AreYouSureYouWantToExitWithoutSavingYourMacroChanges
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_GrblMacroButtons_FormClosing_AreYouSureYouWantToExitWithoutSavingYourMacroChanges", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_GrblMacroButtons_FormClosing_ConfirmExitWithoutSaving
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_GrblMacroButtons_FormClosing_ConfirmExitWithoutSaving", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_GrblMacroButtons_Load_Add
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_GrblMacroButtons_Load_Add", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_showGrblStatus_CHECK
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_showGrblStatus_CHECK", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_showGrblStatus_HOLD
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_showGrblStatus_HOLD", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_showGrblStatus_IDLE
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_showGrblStatus_IDLE", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_showGrblStatus_Resume
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_showGrblStatus_Resume", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_showGrblStatus_RUN
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_showGrblStatus_RUN", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_UpdateToolTip_CommitAllChangesToSettingsAndClose
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_UpdateToolTip_CommitAllChangesToSettingsAndClose", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_UpdateToolTip_DblClickNameToEditMacro
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_UpdateToolTip_DblClickNameToEditMacro", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_UpdateToolTip_DeleteTheSelectedMacro
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_UpdateToolTip_DeleteTheSelectedMacro", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_UpdateToolTip_GCodeToSendWhenTheButtonIsClicked
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_UpdateToolTip_GCodeToSendWhenTheButtonIsClicked", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_UpdateToolTip_GetMeOuttaHereCancelAllChanges
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_UpdateToolTip_GetMeOuttaHereCancelAllChanges", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_UpdateToolTip_LimitIs5Macros
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_UpdateToolTip_LimitIs5Macros", Resources.resourceCulture);
			}
		}
		internal static string GrblGui_UpdateToolTip_NameAppearsOnTheButtonSoKeepItSmall
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblGui_UpdateToolTip_NameAppearsOnTheButtonSoKeepItSmall", Resources.resourceCulture);
			}
		}
		internal static string GrblIF_Disconnect_ErrorOnCloseOfGrblPort
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblIF_Disconnect_ErrorOnCloseOfGrblPort", Resources.resourceCulture);
			}
		}
		internal static string GrblIF_sendData_FatalErrorOnWriteToGrbl
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblIF_sendData_FatalErrorOnWriteToGrbl", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_AAccelMmSec2
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_AAccelMmSec2", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_AMaxRateMmMin
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_AMaxRateMmMin", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_AMaxTravelMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_AMaxTravelMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_ArcToleranceMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_ArcToleranceMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_AStepMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_AStepMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_DirPortInvertMask
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_DirPortInvertMask", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_FillSettings_Value
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_FillSettings_Value", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_HardLimitsBool
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_HardLimitsBool", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_HomingCycleBool
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_HomingCycleBool", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_HomingDebounceMsec
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_HomingDebounceMsec", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_HomingDirInvertMask
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_HomingDirInvertMask", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_HomingFeedMmMin
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_HomingFeedMmMin", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_HomingPullOffMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_HomingPullOffMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_HomingSeekMmMin
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_HomingSeekMmMin", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_JunctionDeviationMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_JunctionDeviationMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_LaserMode
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_LaserMode", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_LimitPinsInvertBool
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_LimitPinsInvertBool", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_ProbePinInvertBool
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_ProbePinInvertBool", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_ReportInchesBool
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_ReportInchesBool", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_RpmMax
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_RpmMax", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_RpmMin
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_RpmMin", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_SoftLimitsBool
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_SoftLimitsBool", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_StatusReportMask
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_StatusReportMask", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_StepEnableInvertBool
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_StepEnableInvertBool", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_StepIdleDelayMsec
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_StepIdleDelayMsec", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_StepPortInvertMask
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_StepPortInvertMask", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_StepPulseUsec
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_StepPulseUsec", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_XAccelMmSec2
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_XAccelMmSec2", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_XMaxRateMmMin
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_XMaxRateMmMin", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_XMaxTravelMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_XMaxTravelMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_XStepMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_XStepMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_YAccelMmSec2
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_YAccelMmSec2", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_YMaxRateMmMin
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_YMaxRateMmMin", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_YMaxTravelMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_YMaxTravelMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_YStepMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_YStepMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_ZAccelMmSec2
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_ZAccelMmSec2", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_ZMaxRateMmMin
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_ZMaxRateMmMin", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_ZMaxTravelMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_ZMaxTravelMm", Resources.resourceCulture);
			}
		}
		internal static string GrblSettings_ZStepMm
		{
			get
			{
				return Resources.ResourceManager.GetString("GrblSettings_ZStepMm", Resources.resourceCulture);
			}
		}
		internal static string MsgFilter_PreFilterMessage_Start
		{
			get
			{
				return Resources.ResourceManager.GetString("MsgFilter_PreFilterMessage_Start", Resources.resourceCulture);
			}
		}
	}
}
