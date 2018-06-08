using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace GrblPanel.My
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());
		private static bool addedHandler;
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string Port
		{
			get
			{
				return Convert.ToString(this["Port"]);
			}
			set
			{
				this["Port"] = value;
			}
		}
		[DefaultSettingValue("115200"), UserScopedSetting, DebuggerNonUserCode]
		public string Baud
		{
			get
			{
				return Convert.ToString(this["Baud"]);
			}
			set
			{
				this["Baud"] = value;
			}
		}
		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool JoggingUnitsMetric
		{
			get
			{
				return Conversions.ToBoolean(this["JoggingUnitsMetric"]);
			}
			set
			{
				this["JoggingUnitsMetric"] = value;
			}
		}
		[DefaultSettingValue("G90 G10 L20 P0 X0 Y0 Z0"), UserScopedSetting, DebuggerNonUserCode]
		public string Work0Cmd
		{
			get
			{
				return Convert.ToString(this["Work0Cmd"]);
			}
			set
			{
				this["Work0Cmd"] = value;
			}
		}
		[DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode]
		public bool StatusPollEnabled
		{
			get
			{
				return Conversions.ToBoolean(this["StatusPollEnabled"]);
			}
			set
			{
				this["StatusPollEnabled"] = value;
			}
		}
		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool StatusVerbose
		{
			get
			{
				return Conversions.ToBoolean(this["StatusVerbose"]);
			}
			set
			{
				this["StatusVerbose"] = value;
			}
		}
		[DefaultSettingValue("200"), UserScopedSetting, DebuggerNonUserCode]
		public string StatusPollInterval
		{
			get
			{
				return Convert.ToString(this["StatusPollInterval"]);
			}
			set
			{
				this["StatusPollInterval"] = value;
			}
		}
		[DefaultSettingValue("G90 G10 L20 P0 X0"), UserScopedSetting, DebuggerNonUserCode]
		public string WorkX0Cmd
		{
			get
			{
				return Convert.ToString(this["WorkX0Cmd"]);
			}
			set
			{
				this["WorkX0Cmd"] = value;
			}
		}
		[DefaultSettingValue("G90 G10 L20 P0 Y0"), UserScopedSetting, DebuggerNonUserCode]
		public string WorkY0Cmd
		{
			get
			{
				return Convert.ToString(this["WorkY0Cmd"]);
			}
			set
			{
				this["WorkY0Cmd"] = value;
			}
		}
		[DefaultSettingValue("G90 G10 L20 P0 Z0"), UserScopedSetting, DebuggerNonUserCode]
		public string WorkZ0Cmd
		{
			get
			{
				return Convert.ToString(this["WorkZ0Cmd"]);
			}
			set
			{
				this["WorkZ0Cmd"] = value;
			}
		}
		[DefaultSettingValue("100,50,10,5"), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingFRImperial
		{
			get
			{
				return Convert.ToString(this["JoggingFRImperial"]);
			}
			set
			{
				this["JoggingFRImperial"] = value;
			}
		}
		[DefaultSettingValue("1,0.1,0.01,0.001"), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingFIImperial
		{
			get
			{
				return Convert.ToString(this["JoggingFIImperial"]);
			}
			set
			{
				this["JoggingFIImperial"] = value;
			}
		}
		[DefaultSettingValue("10,1,0.1,0.01 "), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingFIMEtric
		{
			get
			{
				return Convert.ToString(this["JoggingFIMEtric"]);
			}
			set
			{
				this["JoggingFIMEtric"] = value;
			}
		}
		[DefaultSettingValue("1000,500,100,5"), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingFRMetric
		{
			get
			{
				return Convert.ToString(this["JoggingFRMetric"]);
			}
			set
			{
				this["JoggingFRMetric"] = value;
			}
		}
		[DefaultSettingValue("17"), UserScopedSetting, DebuggerNonUserCode]
		public string QBuffMaxSize
		{
			get
			{
				return Convert.ToString(this["QBuffMaxSize"]);
			}
			set
			{
				this["QBuffMaxSize"] = value;
			}
		}
		[DefaultSettingValue("127"), UserScopedSetting, DebuggerNonUserCode]
		public string RBuffMaxSize
		{
			get
			{
				return Convert.ToString(this["RBuffMaxSize"]);
			}
			set
			{
				this["RBuffMaxSize"] = value;
			}
		}
		[DefaultSettingValue("2.5"), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingXRepeat
		{
			get
			{
				return Convert.ToString(this["JoggingXRepeat"]);
			}
			set
			{
				this["JoggingXRepeat"] = value;
			}
		}
		[DefaultSettingValue("2.5"), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingZRepeat
		{
			get
			{
				return Convert.ToString(this["JoggingZRepeat"]);
			}
			set
			{
				this["JoggingZRepeat"] = value;
			}
		}
		[DefaultSettingValue("2.5"), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingYRepeat
		{
			get
			{
				return Convert.ToString(this["JoggingYRepeat"]);
			}
			set
			{
				this["JoggingYRepeat"] = value;
			}
		}
		[DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode]
		public bool GCodePauseOnError
		{
			get
			{
				return Conversions.ToBoolean(this["GCodePauseOnError"]);
			}
			set
			{
				this["GCodePauseOnError"] = value;
			}
		}
		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool GrblConnectOnLoad
		{
			get
			{
				return Conversions.ToBoolean(this["GrblConnectOnLoad"]);
			}
			set
			{
				this["GrblConnectOnLoad"] = value;
			}
		}
		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool JoggingUseKeyboard
		{
			get
			{
				return Conversions.ToBoolean(this["JoggingUseKeyboard"]);
			}
			set
			{
				this["JoggingUseKeyboard"] = value;
			}
		}
		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool LeftHandedGUI
		{
			get
			{
				return Conversions.ToBoolean(this["LeftHandedGUI"]);
			}
			set
			{
				this["LeftHandedGUI"] = value;
			}
		}
		[DefaultSettingValue("G28"), UserScopedSetting, DebuggerNonUserCode]
		public string MachineSpclPosition1
		{
			get
			{
				return Convert.ToString(this["MachineSpclPosition1"]);
			}
			set
			{
				this["MachineSpclPosition1"] = value;
			}
		}
		[DefaultSettingValue("G30"), UserScopedSetting, DebuggerNonUserCode]
		public string MachineSpclPosition2
		{
			get
			{
				return Convert.ToString(this["MachineSpclPosition2"]);
			}
			set
			{
				this["MachineSpclPosition2"] = value;
			}
		}
		[DefaultSettingValue("$132"), UserScopedSetting, DebuggerNonUserCode]
		public string GrblLastParamID
		{
			get
			{
				return Convert.ToString(this["GrblLastParamID"]);
			}
			set
			{
				this["GrblLastParamID"] = value;
			}
		}
		[DefaultSettingValue("I2"), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingFIDefault
		{
			get
			{
				return Convert.ToString(this["JoggingFIDefault"]);
			}
			set
			{
				this["JoggingFIDefault"] = value;
			}
		}
		[DefaultSettingValue("F2"), UserScopedSetting, DebuggerNonUserCode]
		public string JoggingFRDefault
		{
			get
			{
				return Convert.ToString(this["JoggingFRDefault"]);
			}
			set
			{
				this["JoggingFRDefault"] = value;
			}
		}
		[DefaultSettingValue("1.5"), UserScopedSetting, DebuggerNonUserCode]
		public string StartupDelay
		{
			get
			{
				return Convert.ToString(this["StartupDelay"]);
			}
			set
			{
				this["StartupDelay"] = value;
			}
		}
		[DefaultSettingValue("txt"), UserScopedSetting, DebuggerNonUserCode]
		public string DefaultFileExt
		{
			get
			{
				return Convert.ToString(this["DefaultFileExt"]);
			}
			set
			{
				this["DefaultFileExt"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string IPAddress
		{
			get
			{
				return Convert.ToString(this["IPAddress"]);
			}
			set
			{
				this["IPAddress"] = value;
			}
		}
		[DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
		public string ConnectionType
		{
			get
			{
				return Convert.ToString(this["ConnectionType"]);
			}
			set
			{
				this["ConnectionType"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string Macro1
		{
			get
			{
				return Convert.ToString(this["Macro1"]);
			}
			set
			{
				this["Macro1"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string Macro2
		{
			get
			{
				return Convert.ToString(this["Macro2"]);
			}
			set
			{
				this["Macro2"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string Macro3
		{
			get
			{
				return Convert.ToString(this["Macro3"]);
			}
			set
			{
				this["Macro3"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string Macro4
		{
			get
			{
				return Convert.ToString(this["Macro4"]);
			}
			set
			{
				this["Macro4"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string Macro5
		{
			get
			{
				return Convert.ToString(this["Macro5"]);
			}
			set
			{
				this["Macro5"] = value;
			}
		}
		[DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode]
		public bool UpgradeSettings
		{
			get
			{
				return Conversions.ToBoolean(this["UpgradeSettings"]);
			}
			set
			{
				this["UpgradeSettings"] = value;
			}
		}
		[DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
		public string TruncationDigits
		{
			get
			{
				return Convert.ToString(this["TruncationDigits"]);
			}
			set
			{
				this["TruncationDigits"] = value;
			}
		}
		public MySettings()
		{
			base.SettingChanging += new SettingChangingEventHandler(this.traphere);
			base.PropertyChanged += new PropertyChangedEventHandler(this.settings_SettingsChanged);
		}
		[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}
		private void traphere(object sender, SettingChangingEventArgs e)
		{
		}
		private void settings_SettingsChanged(object sender, PropertyChangedEventArgs e)
		{
		}
	}
}
