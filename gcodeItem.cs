namespace GrblPanel
{
    public class GcodeItem
    {
        public string Status { get; set; }

        public int LineNum { get; set; }

        public string Gcode { get; set; }

        public bool File { get; set; }

        public bool Sent { get; set; }

        public bool Acked { get; set; }

        public bool M0 { get; }

        public bool M6 { get; }

        public GcodeItem()
        {
            this.File = false;
            this.Sent = false;
            this.Acked = false;
            this.M0 = false;
            this.M6 = false;
        }
    }
}