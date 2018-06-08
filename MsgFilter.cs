using System.Windows.Forms;

namespace GrblPanel
{
    public class MsgFilter : IMessageFilter
    {
        private GrblGui _gui;

        public MsgFilter(ref GrblGui owner)
        {
            this._gui = owner;
        }

        bool IMessageFilter.PreFilterMessage(ref Message msg)
        {
            bool handled = false;
            bool PreFilterMessage;
            if (msg.Msg == 256)
            {
                if (this._gui.gbJogging.Enabled && !this._gui.tbSendData.ContainsFocus && this._gui.cbSettingsKeyboardJogging.Checked)
                {
                    IntPtr wParam = msg.WParam;
                    if (wParam == (IntPtr)37)
                    {
                        this._gui.btnXMinus.PerformClick();
                        handled = true;
                    }
                    else
                    {
                        if (wParam == (IntPtr)39)
                        {
                            this._gui.btnXPlus.PerformClick();
                            handled = true;
                        }
                        else
                        {
                            if (wParam == (IntPtr)38)
                            {
                                this._gui.btnYPlus.PerformClick();
                                handled = true;
                            }
                            else
                            {
                                if (wParam == (IntPtr)40)
                                {
                                    this._gui.btnYMinus.PerformClick();
                                    handled = true;
                                }
                                else
                                {
                                    if (wParam == (IntPtr)33)
                                    {
                                        this._gui.btnZPlus.PerformClick();
                                        handled = true;
                                    }
                                    else
                                    {
                                        if (wParam == (IntPtr)34)
                                        {
                                            this._gui.btnZMinus.PerformClick();
                                            handled = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (handled)
                    {
                        PreFilterMessage = true;
                        return PreFilterMessage;
                    }
                }
                if (!this._gui.tbSendData.ContainsFocus && !this._gui.gbEditor.ContainsFocus && !this._gui.gbSettingsMisc.ContainsFocus && !this._gui.gbSettingsJogging.ContainsFocus && !this._gui.gbSettingsPosition.ContainsFocus && !this._gui.tbWorkX.ContainsFocus && !this._gui.tbWorkY.ContainsFocus && !this._gui.tbWorkZ.ContainsFocus)
                {
                    IntPtr wParam2 = msg.WParam;
                    if (wParam2 == (IntPtr)107 || wParam2 == (IntPtr)(187 & ((-((MyProject.Computer.Keyboard.ShiftKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                    {
                        this._gui.changeDistanceIncrement(true);
                        handled = true;
                    }
                    else
                    {
                        if (wParam2 == (IntPtr)109 || wParam2 == (IntPtr)189)
                        {
                            this._gui.changeDistanceIncrement(false);
                            handled = true;
                        }
                        else
                        {
                            if (wParam2 == (IntPtr)111 || wParam2 == (IntPtr)191)
                            {
                                this._gui.changeFeedRate(true);
                                handled = true;
                            }
                            else
                            {
                                if (wParam2 == (IntPtr)106 || wParam2 == (IntPtr)(56 & ((-((MyProject.Computer.Keyboard.ShiftKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                {
                                    this._gui.changeFeedRate(false);
                                    handled = true;
                                }
                                else
                                {
                                    if (wParam2 == (IntPtr)(88 & ((-((!MyProject.Computer.Keyboard.CtrlKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                    {
                                        this._gui.btnWorkX0.PerformClick();
                                        handled = true;
                                    }
                                    else
                                    {
                                        if (wParam2 == (IntPtr)89)
                                        {
                                            this._gui.btnWorkY0.PerformClick();
                                            handled = true;
                                        }
                                        else
                                        {
                                            if (wParam2 == (IntPtr)90)
                                            {
                                                this._gui.btnWorkZ0.PerformClick();
                                                handled = true;
                                            }
                                            else
                                            {
                                                if (!(wParam2 == (IntPtr)45))
                                                {
                                                    if (wParam2 == (IntPtr)65)
                                                    {
                                                        this._gui.btnWork0.PerformClick();
                                                        handled = true;
                                                    }
                                                    else
                                                    {
                                                        if (wParam2 == (IntPtr)32)
                                                        {
                                                            if (String.Compare(this._gui.btnStartResume.Text, "Start", false) == 0)
                                                            {
                                                                this._gui.btnHold.PerformClick();
                                                            }
                                                            else
                                                            {
                                                                this._gui.btnStartResume.PerformClick();
                                                            }
                                                            handled = true;
                                                        }
                                                        else
                                                        {
                                                            if (wParam2 == (IntPtr)79)
                                                            {
                                                                this._gui.btnFileStep.PerformClick();
                                                                handled = true;
                                                            }
                                                            else
                                                            {
                                                                if (wParam2 == (IntPtr)113)
                                                                {
                                                                    Button macro = this._gui.IsMacroBtn(1);
                                                                    if (!Information.IsNothing(macro))
                                                                    {
                                                                        macro.PerformClick();
                                                                        handled = true;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (wParam2 == (IntPtr)114)
                                                                    {
                                                                        Button macro2 = this._gui.IsMacroBtn(2);
                                                                        if (!Information.IsNothing(macro2))
                                                                        {
                                                                            macro2.PerformClick();
                                                                            handled = true;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (wParam2 == (IntPtr)115)
                                                                        {
                                                                            Button macro3 = this._gui.IsMacroBtn(3);
                                                                            if (!Information.IsNothing(macro3))
                                                                            {
                                                                                macro3.PerformClick();
                                                                                handled = true;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (wParam2 == (IntPtr)116)
                                                                            {
                                                                                Button macro4 = this._gui.IsMacroBtn(4);
                                                                                if (!Information.IsNothing(macro4))
                                                                                {
                                                                                    macro4.PerformClick();
                                                                                    handled = true;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                if (wParam2 == (IntPtr)117)
                                                                                {
                                                                                    Button macro5 = this._gui.IsMacroBtn(5);
                                                                                    if (!Information.IsNothing(macro5))
                                                                                    {
                                                                                        macro5.PerformClick();
                                                                                        handled = true;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (wParam2 == (IntPtr)(72 & ((-((MyProject.Computer.Keyboard.CtrlKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                    {
                                                                                        this._gui.btnHold.PerformClick();
                                                                                        handled = true;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (wParam2 == (IntPtr)(85 & ((-((MyProject.Computer.Keyboard.CtrlKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                        {
                                                                                            this._gui.btnUnlock.PerformClick();
                                                                                            handled = true;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (wParam2 == (IntPtr)(88 & ((-((MyProject.Computer.Keyboard.CtrlKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                            {
                                                                                                this._gui.btnReset.PerformClick();
                                                                                                handled = true;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (wParam2 == (IntPtr)(70 & ((-((MyProject.Computer.Keyboard.ShiftKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                {
                                                                                                    this._gui.btnFeedPlus.PerformClick();
                                                                                                    handled = true;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (wParam2 == (IntPtr)(70 & ((-(((!MyProject.Computer.Keyboard.ShiftKeyDown && !MyProject.Computer.Keyboard.CtrlKeyDown) > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                    {
                                                                                                        this._gui.btnFeedMinus.PerformClick();
                                                                                                        handled = true;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (wParam2 == (IntPtr)(70 & ((-((MyProject.Computer.Keyboard.CtrlKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                        {
                                                                                                            this._gui.btnFeedOverrideReset.PerformClick();
                                                                                                            handled = true;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (wParam2 == (IntPtr)(83 & ((-((MyProject.Computer.Keyboard.ShiftKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                            {
                                                                                                                this._gui.btnSpindlePlus.PerformClick();
                                                                                                                handled = true;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (wParam2 == (IntPtr)(83 & ((-(((!MyProject.Computer.Keyboard.ShiftKeyDown && !MyProject.Computer.Keyboard.CtrlKeyDown) > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                                {
                                                                                                                    this._gui.btnSpindleMinus.PerformClick();
                                                                                                                    handled = true;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (wParam2 == (IntPtr)(83 & ((-((MyProject.Computer.Keyboard.CtrlKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                                    {
                                                                                                                        this._gui.btnSpindleOverrideReset.PerformClick();
                                                                                                                        handled = true;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (wParam2 == (IntPtr)(82 & ((-((MyProject.Computer.Keyboard.ShiftKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                                        {
                                                                                                                            this._gui.btnRapidOverrideReset.PerformClick();
                                                                                                                            handled = true;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (wParam2 == (IntPtr)(82 & ((-((MyProject.Computer.Keyboard.CtrlKeyDown > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                                            {
                                                                                                                                this._gui.btnRapidOverride25.PerformClick();
                                                                                                                                handled = true;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (wParam2 == (IntPtr)(82 & ((-(((!MyProject.Computer.Keyboard.ShiftKeyDown && !MyProject.Computer.Keyboard.CtrlKeyDown) > false) ? 1 : 0)) ? 1 : 0)))
                                                                                                                                {
                                                                                                                                    this._gui.btnRapidOverride50.PerformClick();
                                                                                                                                    handled = true;
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (handled)
                {
                    PreFilterMessage = true;
                    return PreFilterMessage;
                }
            }
            PreFilterMessage = false;
            return PreFilterMessage;
        }
    }
}