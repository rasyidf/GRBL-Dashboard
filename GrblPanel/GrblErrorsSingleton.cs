using GrblPanel.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace GrblPanel
{
	public class GrblErrorsSingleton
	{
		private static GrblErrorsSingleton _instance = null;
		private static readonly object _mylock = RuntimeHelpers.GetObjectValue(new object());
		private static Dictionary<string, string> _errors;
		private GrblErrorsSingleton()
		{
		}
		public static GrblErrorsSingleton GetInstance()
		{
			object mylock = GrblErrorsSingleton._mylock;
			ObjectFlowControl.CheckForSyncLockOnValueType(mylock);
			GrblErrorsSingleton GetInstance;
			lock (mylock)
			{
				if (GrblErrorsSingleton._instance == null)
				{
					GrblErrorsSingleton._instance = new GrblErrorsSingleton();
				}
				GetInstance = GrblErrorsSingleton._instance;
			}
			return GetInstance;
		}
		public Dictionary<string, string> GetErrorsDct()
		{
			GrblErrorsSingleton._errors = new Dictionary<string, string>
			{

				{
					"0",
					"ok"
				},

				{
					"1",
					Resources.GrblGcodeView_ExpectedCommandLetter
				},

				{
					"2",
					Resources.GrblGcodeView_BadNumberFormat
				},

				{
					"3",
					Resources.GrblGcodeView_InvalidStatement
				},

				{
					"4",
					Resources.GrblGcodeView_Value0
				},

				{
					"5",
					Resources.GrblGcodeView_SettingDisabled
				},

				{
					"6",
					Resources.GrblGcodeView_Value3Usec
				},

				{
					"7",
					Resources.GrblGcodeView_EEPROMReadFailUsingDefaults
				},

				{
					"8",
					Resources.GrblGcodeView_NotIdle
				},

				{
					"9",
					Resources.GrblGcodeView_AlarmLock
				},

				{
					"10",
					Resources.GrblGcodeView_HomingIsNotEnabled
				},

				{
					"11",
					Resources.GrblGcodeView_LineOverflow
				},

				{
					"12",
					Resources.GrblGcodeView_StepRate30kHz
				},

				{
					"13",
					Resources.GrblGcodeView_CheckDoor
				},

				{
					"14",
					Resources.GrblGcodeView_BuildInfoLength
				},

				{
					"15",
					Resources.GrblGcodeView_JogTravel
				},

				{
					"16",
					Resources.GrblGcodeView_JogFormat
				},

				{
					"20",
					Resources.GrblGcodeView_UnsupportedCommand
				},

				{
					"21",
					Resources.GrblGcodeView_ModalGroupViolation
				},

				{
					"22",
					Resources.GrblGcodeView_UndefinedFeedRate
				},

				{
					"23",
					Resources.GrblGcodeView_CommandValueIsNotInteger
				},

				{
					"24",
					Resources.GrblGcodeView_AxisCommandConflict
				},

				{
					"25",
					Resources.GrblGcodeView_WordRepeated
				},

				{
					"26",
					Resources.GrblGcodeView_NoAxisWords
				},

				{
					"27",
					Resources.GrblGcodeView_InvalidLineNumber
				},

				{
					"28",
					Resources.GrblGcodeView_ValueWordMissing
				},

				{
					"29",
					Resources.GrblGcodeView_UnsupportedCoordinateSystem
				},

				{
					"30",
					Resources.GrblGcodeView_G53InvalidMotionMode
				},

				{
					"31",
					Resources.GrblGcodeView_AxisWordsExist
				},

				{
					"32",
					Resources.GrblGcodeView_NoAxisWordsInPlane
				},

				{
					"33",
					Resources.GrblGcodeView_InvalidTarget
				},

				{
					"34",
					Resources.GrblGcodeView_ArcRadiusError
				},

				{
					"35",
					Resources.GrblGcodeView_NoOffsetsInPlane
				},

				{
					"36",
					Resources.GrblGcodeView_UnusedWords
				},

				{
					"37",
					Resources.GrblGcodeView_G43DynamicAxisError
				},

				{
					"38",
					Resources.GrblGcodeView_InvalidToolNumber
				}
			};
			return GrblErrorsSingleton._errors;
		}
	}
}
