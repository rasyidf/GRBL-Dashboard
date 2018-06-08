using System.Windows.Forms;

namespace GrblPanel
{
    public class GrblState
    {
        private GrblGui _gui;

        public GrblState(ref GrblGui gui)
        {
            this._gui = gui;
            MyProject.Forms.Connected += new ConnectedEventHandler(this.GrblConnected);
        }

        public void EnableState(bool yes)
        {
            if (yes)
            {
                this._gui.gbState.Enabled = true;
                return;
            }
            this._gui.gbState.Enabled = false;
        }

        public void GrblConnected(string msg)
        {
            if (String.Compare(msg, "Connected", false) == 0)
            {
                gcode.sendGCodeLine("$G");
            }
        }

        public void ProcessGCode(string line)
        {
            char[] ignore = new char[]
            {
                    '$',
                    '!',
                    '~',
                    '?',
                    '('
            };
            char[] codes = new char[]
            {
                    'M',
                    'T',
                    'S',
                    'G',
                    'F'
            };
            char[] allcodes = new char[]
            {
                    'M',
                    'T',
                    'F',
                    'G',
                    'P',
                    'S',
                    'X',
                    'Y',
                    'Z',
                    'I',
                    'J',
                    'K',
                    ' ',
                    '[',
                    ']',
                    '\n'
            };
            char[] spclcodes = new char[]
            {
                    'T',
                    'S',
                    'F'
            };
            bool collect = false;
            string[] gcodes = new string[0];
            int gcodeIndex = 0;
            checked
            {
                if (line.Length != 0 && !ignore.Contains(line[0]) && allcodes.Contains(line[0]))
                {
                    StringBuilder sb = new StringBuilder();
                    bool ef = false;
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if (!ef)
                        {
                            if (allcodes.Contains(c))
                            {
                                collect = false;
                                gcodes[gcodeIndex - 1] = sb.ToString();
                                if (codes.Contains(c))
                                {
                                    collect = true;
                                    sb = new StringBuilder();
                                    gcodes = (string[])Utils.CopyArray(gcodes, new string[gcodeIndex + 1 + 1]);
                                    sb.Append(c);
                                    gcodeIndex++;
                                }
                            }
                            else
                            {
                                if (collect)
                                {
                                    sb.Append(c);
                                }
                            }
                            if (String.Compare(Convert.ToString(c), "(", false) == 0)
                            {
                                ef = true;
                            }
                        }
                    }
                    ef = false;
                    string[] array = gcodes;
                    for (int j = 0; j < array.Length; j++)
                    {
                        string code = array[j];
                        if (Information.IsNothing(code))
                        {
                            ef = true;
                        }
                        if (!ef)
                        {
                            if (spclcodes.Contains(code[0]))
                            {
                                char c2 = code[0];
                                if (c2 != 'F')
                                {
                                    if (c2 != 'S')
                                    {
                                        if (c2 == 'T')
                                        {
                                            this._gui.tbStateTool.Text = code.Remove(0, 1);
                                        }
                                    }
                                    else
                                    {
                                        this._gui.tbStateSpindleRPM.Text = code.Remove(0, 1);
                                    }
                                }
                                else
                                {
                                    this._gui.tbStateFeedRate.Text = code.Remove(0, 1);
                                }
                            }
                            else
                            {
                                uint num = < PrivateImplementationDetails >.ComputeStringHash(code);
                                if (num > 3928018819u)
                                {
                                    if (num <= 4162905485u)
                                    {
                                        if (num <= 4129350247u)
                                        {
                                            if (num != 4112572628u)
                                            {
                                                if (num != 4129350247u)
                                                {
                                                    goto IL_657;
                                                }
                                                if (String.Compare(code, "G54", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                                goto IL_545;
                                            }
                                            else
                                            {
                                                if (String.Compare(code, "G55", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                                goto IL_545;
                                            }
                                        }
                                        else
                                        {
                                            if (num != 4131321723u)
                                            {
                                                if (num != 4146127866u)
                                                {
                                                    if (num != 4162905485u)
                                                    {
                                                        goto IL_657;
                                                    }
                                                    if (String.Compare(code, "G56", false) != 0)
                                                    {
                                                        goto IL_657;
                                                    }
                                                    goto IL_545;
                                                }
                                                else
                                                {
                                                    if (String.Compare(code, "G57", false) != 0)
                                                    {
                                                        goto IL_657;
                                                    }
                                                    goto IL_545;
                                                }
                                            }
                                            else
                                            {
                                                if (String.Compare(code, "G94", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (num <= 4179830199u)
                                        {
                                            if (num != 4163052580u)
                                            {
                                                if (num != 4179830199u)
                                                {
                                                    goto IL_657;
                                                }
                                                if (String.Compare(code, "G21", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                            }
                                            else
                                            {
                                                if (String.Compare(code, "G20", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                            }
                                            this._gui.cbxStateUnits.SelectedItem = RuntimeHelpers.GetObjectValue(this.find(this._gui.cbxStateUnits, code));
                                            goto IL_657;
                                        }
                                        if (num != 4181654580u)
                                        {
                                            if (num != 4198432199u)
                                            {
                                                if (num != 4215209818u)
                                                {
                                                    goto IL_657;
                                                }
                                                if (String.Compare(code, "G93", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                                goto IL_5B1;
                                            }
                                            else
                                            {
                                                if (String.Compare(code, "G90", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (String.Compare(code, "G91", false) != 0)
                                            {
                                                goto IL_657;
                                            }
                                        }
                                        this._gui.cbxStateDistance.SelectedItem = RuntimeHelpers.GetObjectValue(this.find(this._gui.cbxStateDistance, code));
                                        goto IL_657;
                                    }
                                    IL_5B1:
                                    this._gui.cbxStateFeedMode.SelectedItem = RuntimeHelpers.GetObjectValue(this.find(this._gui.cbxStateFeedMode, code));
                                    goto IL_657;
                                }
                                if (num > 400526807u)
                                {
                                    if (num <= 1898618468u)
                                    {
                                        if (num != 1730842278u)
                                        {
                                            if (num != 1898618468u)
                                            {
                                                goto IL_657;
                                            }
                                            if (String.Compare(code, "G19", false) != 0)
                                            {
                                                goto IL_657;
                                            }
                                        }
                                        else
                                        {
                                            if (String.Compare(code, "G17", false) != 0)
                                            {
                                                goto IL_657;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (num != 1915396087u)
                                        {
                                            if (num != 3911241200u)
                                            {
                                                if (num != 3928018819u)
                                                {
                                                    goto IL_657;
                                                }
                                                if (String.Compare(code, "G58", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                                goto IL_545;
                                            }
                                            else
                                            {
                                                if (String.Compare(code, "G59", false) != 0)
                                                {
                                                    goto IL_657;
                                                }
                                                goto IL_545;
                                            }
                                        }
                                        else
                                        {
                                            if (String.Compare(code, "G18", false) != 0)
                                            {
                                                goto IL_657;
                                            }
                                        }
                                    }
                                    this._gui.cbxStatePlane.SelectedItem = RuntimeHelpers.GetObjectValue(this.find(this._gui.cbxStatePlane, code));
                                    goto IL_657;
                                }
                                if (num <= 199195379u)
                                {
                                    if (num != 182417760u)
                                    {
                                        if (num != 199195379u)
                                        {
                                            goto IL_657;
                                        }
                                        if (String.Compare(code, "M9", false) != 0)
                                        {
                                            goto IL_657;
                                        }
                                    }
                                    else
                                    {
                                        if (String.Compare(code, "M8", false) != 0)
                                        {
                                            goto IL_657;
                                        }
                                    }
                                    this._gui.cbxStateCoolant.SelectedItem = RuntimeHelpers.GetObjectValue(this.find(this._gui.cbxStateCoolant, code));
                                    goto IL_657;
                                }
                                if (num != 366971569u)
                                {
                                    if (num != 383749188u)
                                    {
                                        if (num != 400526807u)
                                        {
                                            goto IL_657;
                                        }
                                        if (String.Compare(code, "M5", false) != 0)
                                        {
                                            goto IL_657;
                                        }
                                    }
                                    else
                                    {
                                        if (String.Compare(code, "M4", false) != 0)
                                        {
                                            goto IL_657;
                                        }
                                    }
                                }
                                else
                                {
                                    if (String.Compare(code, "M3", false) != 0)
                                    {
                                        goto IL_657;
                                    }
                                }
                                this._gui.cbxStateSpindle.SelectedItem = RuntimeHelpers.GetObjectValue(this.find(this._gui.cbxStateSpindle, code));
                                goto IL_657;
                                IL_545:
                                this._gui.cbxStateOffset.SelectedItem = RuntimeHelpers.GetObjectValue(this.find(this._gui.cbxStateOffset, code));
                                this._gui.lblPositionCurrentOffset.Text = code;
                            }
                        }
                        IL_657:;
                    }
                }
            }
        }

        private object find(ComboBox bx, string code)
        {
            object find;
            try
            {
                IEnumerator enumerator = bx.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    object i = RuntimeHelpers.GetObjectValue(enumerator.Current);
                    if (i.ToString().Contains(code))
                    {
                        find = i;
                        return find;
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
            find = null;
            return find;
        }
    }
}