using System.Collections.Generic;
using System.Windows.Forms;

namespace GrblPanel
{
    public class GrblOffsets
    {
        private GrblGui _gui;
        private bool _wtgForGrbl;
        private bool _collecting;
        private List<string> _offsets;

        public bool OffsetsWtgForGrbl
        {
            get
            {
                return this._wtgForGrbl;
            }
            set
            {
                this._wtgForGrbl = value;
            }
        }

        public bool CollectingOffsets
        {
            get
            {
                return this._collecting;
            }
            set
            {
                this._collecting = value;
            }
        }

        public List<string> Offsets
        {
            get
            {
                return this._offsets;
            }
        }

        public GrblOffsets(ref GrblGui gui)
        {
            this._wtgForGrbl = false;
            this._collecting = false;
            this._offsets = new List<string>();
            this._gui = gui;
            this._gui.Connected += delegate (string a0)
            {
                this.GrblConnected();
            };
        }

        public void enableOffsets(bool action)
        {
            this._gui.gbStatus.Enabled = action;
            if (action)
            {
                this._gui.grblPort.AddRcvDelegate(new GrblIF.grblDataReceived(this._gui.showGrblOffsets));
                return;
            }
            this._gui.grblPort.DeleteRcvDelegate(new GrblIF.grblDataReceived(this._gui.showGrblOffsets));
        }

        public void ClearParams()
        {
            this._offsets.Clear();
        }

        public void AddOffset(string data)
        {
            this._offsets.Add(data);
        }

        public void SaveOffsets()
        {
            checked
            {
                if (this._gui.sfdOffsets.ShowDialog() == DialogResult.OK)
                {
                    XmlWriterSettings settings = new XmlWriterSettings
                    {
                        Indent = true,
                        NewLineOnAttributes = true
                    };
                    XmlWriter writer = XmlWriter.Create(this._gui.sfdOffsets.FileName, settings);
                    writer.WriteStartElement("WorkOffsets");
                    string[] array = new string[]
                    {
                            "G54",
                            "G55",
                            "G56",
                            "G57",
                            "G58",
                            "G59"
                    };
                    Control[] ctls;
                    for (int i = 0; i < array.Length; i++)
                    {
                        string id = array[i];
                        writer.WriteStartElement(id);
                        string[] array2 = new string[]
                        {
                                "X",
                                "Y",
                                "Z"
                        };
                        for (int j = 0; j < array2.Length; j++)
                        {
                            string axis = array2[j];
                            ctls = this._gui.tpOffsets.Controls.Find("tbOffsets" + id + axis, true);
                            writer.WriteAttributeString(axis, ctls[0].Text);
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteStartElement("G43");
                    ctls = this._gui.tpOffsets.Controls.Find("tbOffsetsG43Z", true);
                    writer.WriteAttributeString("Z", ctls[0].Text);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.Close();
                }
            }
        }

        public void LoadOffsets()
        {
            if (this._gui.ofdOffsets.ShowDialog() == DialogResult.OK)
            {
                XmlReader reader = XmlReader.Create(this._gui.ofdOffsets.FileName);
                while (reader.Read())
                {
                    XmlNodeType nodeType = reader.NodeType;
                    if (nodeType == XmlNodeType.Element && reader.HasAttributes)
                    {
                        string offsetName = reader.Name;
                        while (reader.MoveToNextAttribute())
                        {
                            this._gui.tpOffsets.Controls.Find("tbOffsets" + offsetName + reader.Name, true)[0].Text = reader.Value;
                        }
                    }
                }
            }
        }

        private void GrblConnected()
        {
            this.OffsetsWtgForGrbl = true;
            gcode.sendGCodeLine("$#");
        }

        [CompilerGenerated]
        private void _Lambda$__R4-1(string a0)

			{
				this.private GrblConnected();
    }
}