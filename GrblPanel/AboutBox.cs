using GrblPanel.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GrblPanel
{
    [DesignerGenerated]
    public class AboutBox : Form
    {
        public class ListViewItemComparer : IComparer
        {
            private readonly int _intCol;
            private readonly bool _IsAscending;

            public ListViewItemComparer()
            {
                this._IsAscending = true;
                this._intCol = 0;
                this._IsAscending = true;
            }

            public ListViewItemComparer(int column, bool ascending = true)
            {
                this._IsAscending = true;
                if (column < 0)
                {
                    this._IsAscending = false;
                }
                else
                {
                    this._IsAscending = ascending;
                }
                this._intCol = checked(Math.Abs(column) - 1);
            }

            public int Compare(object x, object y)
            {
                int intResult = string.Compare(((ListViewItem)x).SubItems[this._intCol].Text, ((ListViewItem)y).SubItems[this._intCol].Text);
                int Compare;
                if (this._IsAscending)
                {
                    Compare = intResult;
                }
                else
                {
                    Compare = checked(0 - intResult);
                }
                return Compare;
            }
        }

        private IContainer components;

        private Button _btnAboutLicense;
        private bool _IsPainted;
        private string _EntryAssemblyName;
        private string _CallingAssemblyName;
        private string _ExecutingAssemblyName;
        private Assembly _EntryAssembly;
        private NameValueCollection _EntryAssemblyAttribCollection;
        private int _MinWindowHeight;
        private string githubLink;
        private GroupBox GroupBox1 { get; set; }
        internal RichTextBox MoreRichTextBox { get; set; }
        internal ListView AppInfoListView { get; set; }
        internal ColumnHeader colKey { get; set; }
        internal ColumnHeader colValue { get; set; }
        internal ListView AssemblyInfoListView { get; set; }
        internal ColumnHeader colAssemblyName { get; set; }
        internal ColumnHeader colAssemblyVersion { get; set; }
        internal ColumnHeader colAssemblyBuilt { get; set; }
        internal ColumnHeader colAssemblyCodeBase { get; set; }
        internal TabControl TabPanelDetails { get; set; }
        internal TabPage TabPageApplication { get; set; }
        internal TabPage TabPageAssemblies { get; set; }
        internal TabPage TabPageAssemblyDetails { get; set; }
        internal ListView AssemblyDetailsListView { get; set; }
        internal ColumnHeader ColumnHeader1 { get; set; }
        internal ColumnHeader ColumnHeader2 { get; set; }
        internal ComboBox AssemblyNamesComboBox { get; set; }
        private Button OKButton { get; set; }
        private Label AppTitleLabel { get; set; }
        private Label AppDescriptionLabel { get; set; }
        private Label AppVersionLabel { get; set; }
        private Label AppCopyrightLabel { get; set; }
        private Button SysInfoButton { get; set; }
        private Label AppDateLabel { get; set; }
        private PictureBox ImagePictureBox { get; set; }
        private Button DetailsButton { get; set; }
        internal Button btnAboutChanges { get; set; }
        internal Button btnAboutCredits { get; set; }
        internal Button btnAboutLicense { get; set; }

        public Assembly AppEntryAssembly
        {
            get
            {
                return this._EntryAssembly;
            }
            set
            {
                this._EntryAssembly = value;
            }
        }

        public string AppTitle
        {
            get
            {
                return this.AppTitleLabel.Text;
            }
            set
            {
                this.AppTitleLabel.Text = value;
            }
        }

        public string AppDescription
        {
            get
            {
                return this.AppDescriptionLabel.Text;
            }
            set
            {
                if (String.Compare(value, "", false) == 0)
                {
                    this.AppDescriptionLabel.Visible = false;
                    return;
                }
                this.AppDescriptionLabel.Visible = true;
                this.AppDescriptionLabel.Text = value;
            }
        }

        public string AppVersion
        {
            get
            {
                return this.AppVersionLabel.Text;
            }
            set
            {
                if (String.Compare(value, "", false) == 0)
                {
                    this.AppVersionLabel.Visible = false;
                    return;
                }
                this.AppVersionLabel.Visible = true;
                this.AppVersionLabel.Text = value;
            }
        }

        public string AppCopyright
        {
            get
            {
                return this.AppCopyrightLabel.Text;
            }
            set
            {
                if (String.Compare(value, "", false) == 0)
                {
                    this.AppCopyrightLabel.Visible = false;
                    return;
                }
                this.AppCopyrightLabel.Visible = true;
                this.AppCopyrightLabel.Text = value;
            }
        }

        public Image AppImage
        {
            get
            {
                return this.ImagePictureBox.Image;
            }
            set
            {
                this.ImagePictureBox.Image = value;
            }
        }

        public string AppMoreInfo
        {
            get
            {
                return this.MoreRichTextBox.Text;
            }
            set
            {
                if (String.Compare(value, "", false) == 0)
                {
                    this.MoreRichTextBox.Visible = false;
                    return;
                }
                this.MoreRichTextBox.Visible = true;
                this.MoreRichTextBox.Text = value;
            }
        }

        public bool AppDetailsButton
        {
            get
            {
                return this.DetailsButton.Visible;
            }
            set
            {
                this.DetailsButton.Visible = value;
            }
        }

        public AboutBox()
        {
            base.Load += new EventHandler(this.AboutBox_Load);
            base.Paint += new PaintEventHandler(this.AboutBox_Paint);
            this._IsPainted = false;
            this.githubLink = "http://github.com/Gerritv/Grbl-Panel/wiki";
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.OKButton = new Button();
            this.AppTitleLabel = new Label();
            this.GroupBox1 = new GroupBox();
            this.AppDescriptionLabel = new Label();
            this.AppVersionLabel = new Label();
            this.AppCopyrightLabel = new Label();
            this.SysInfoButton = new Button();
            this.AppDateLabel = new Label();
            this.ImagePictureBox = new PictureBox();
            this.DetailsButton = new Button();
            this.MoreRichTextBox = new RichTextBox();
            this.TabPanelDetails = new TabControl();
            this.TabPageApplication = new TabPage();
            this.AppInfoListView = new ListView();
            this.colKey = new ColumnHeader();
            this.colValue = new ColumnHeader();
            this.TabPageAssemblies = new TabPage();
            this.AssemblyInfoListView = new ListView();
            this.colAssemblyName = new ColumnHeader();
            this.colAssemblyVersion = new ColumnHeader();
            this.colAssemblyBuilt = new ColumnHeader();
            this.colAssemblyCodeBase = new ColumnHeader();
            this.TabPageAssemblyDetails = new TabPage();
            this.AssemblyDetailsListView = new ListView();
            this.ColumnHeader1 = new ColumnHeader();
            this.ColumnHeader2 = new ColumnHeader();
            this.AssemblyNamesComboBox = new ComboBox();
            this.btnAboutChanges = new Button();
            this.btnAboutCredits = new Button();
            this.btnAboutLicense = new Button();
            ((ISupportInitialize)this.ImagePictureBox).BeginInit();
            this.TabPanelDetails.SuspendLayout();
            this.TabPageApplication.SuspendLayout();
            this.TabPageAssemblies.SuspendLayout();
            this.TabPageAssemblyDetails.SuspendLayout();
            base.SuspendLayout();
            this.OKButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.OKButton.DialogResult = DialogResult.Cancel;
            this.OKButton.Location = new Point(482, 474);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new Size(59, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.AppTitleLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.AppTitleLabel.Location = new Point(60, 8);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new Size(496, 16);
            this.AppTitleLabel.TabIndex = 2;
            this.AppTitleLabel.Text = "%title%";
            this.GroupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.GroupBox1.Location = new Point(8, 48);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(548, 2);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "GroupBox1";
            this.AppDescriptionLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.AppDescriptionLabel.Location = new Point(60, 28);
            this.AppDescriptionLabel.Name = "AppDescriptionLabel";
            this.AppDescriptionLabel.Size = new Size(496, 16);
            this.AppDescriptionLabel.TabIndex = 4;
            this.AppDescriptionLabel.Text = "%description%";
            this.AppVersionLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.AppVersionLabel.Location = new Point(8, 60);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new Size(548, 16);
            this.AppVersionLabel.TabIndex = 5;
            this.AppVersionLabel.Text = "Version %version%";
            this.AppCopyrightLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.AppCopyrightLabel.Location = new Point(8, 100);
            this.AppCopyrightLabel.Name = "AppCopyrightLabel";
            this.AppCopyrightLabel.Size = new Size(548, 16);
            this.AppCopyrightLabel.TabIndex = 6;
            this.AppCopyrightLabel.Text = "Copyright © %year%, %trademark%";
            this.SysInfoButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.SysInfoButton.Location = new Point(395, 474);
            this.SysInfoButton.Name = "SysInfoButton";
            this.SysInfoButton.Size = new Size(81, 23);
            this.SysInfoButton.TabIndex = 7;
            this.SysInfoButton.Text = "&System Info";
            this.SysInfoButton.Visible = false;
            this.AppDateLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.AppDateLabel.Location = new Point(8, 80);
            this.AppDateLabel.Name = "AppDateLabel";
            this.AppDateLabel.Size = new Size(548, 16);
            this.AppDateLabel.TabIndex = 8;
            this.AppDateLabel.Text = "Built on %builddate%";
            this.ImagePictureBox.Location = new Point(16, 8);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new Size(32, 32);
            this.ImagePictureBox.TabIndex = 9;
            this.ImagePictureBox.TabStop = false;
            this.DetailsButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.DetailsButton.Location = new Point(406, 474);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new Size(59, 23);
            this.DetailsButton.TabIndex = 10;
            this.DetailsButton.Text = "&Details >>";
            this.MoreRichTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.MoreRichTextBox.BackColor = SystemColors.ControlLight;
            this.MoreRichTextBox.Location = new Point(8, 119);
            this.MoreRichTextBox.Name = "MoreRichTextBox";
            this.MoreRichTextBox.ReadOnly = true;
            this.MoreRichTextBox.Size = new Size(548, 347);
            this.MoreRichTextBox.TabIndex = 13;
            this.MoreRichTextBox.Text = "";
            this.MoreRichTextBox.WordWrap = false;
            this.TabPanelDetails.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.TabPanelDetails.Controls.Add(this.TabPageApplication);
            this.TabPanelDetails.Controls.Add(this.TabPageAssemblies);
            this.TabPanelDetails.Controls.Add(this.TabPageAssemblyDetails);
            this.TabPanelDetails.Location = new Point(8, 119);
            this.TabPanelDetails.Name = "TabPanelDetails";
            this.TabPanelDetails.SelectedIndex = 0;
            this.TabPanelDetails.Size = new Size(546, 347);
            this.TabPanelDetails.TabIndex = 15;
            this.TabPanelDetails.Visible = false;
            this.TabPageApplication.Controls.Add(this.AppInfoListView);
            this.TabPageApplication.Location = new Point(4, 22);
            this.TabPageApplication.Name = "TabPageApplication";
            this.TabPageApplication.Size = new Size(538, 321);
            this.TabPageApplication.TabIndex = 0;
            this.TabPageApplication.Text = "Application";
            this.AppInfoListView.Columns.AddRange(new ColumnHeader[]
            {
                this.colKey,
                this.colValue
            });
            this.AppInfoListView.Dock = DockStyle.Fill;
            this.AppInfoListView.FullRowSelect = true;
            this.AppInfoListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.AppInfoListView.Location = new Point(0, 0);
            this.AppInfoListView.Name = "AppInfoListView";
            this.AppInfoListView.Size = new Size(538, 321);
            this.AppInfoListView.TabIndex = 16;
            this.AppInfoListView.UseCompatibleStateImageBehavior = false;
            this.AppInfoListView.View = View.Details;
            this.colKey.Text = "Application Key";
            this.colKey.Width = 120;
            this.colValue.Text = "Value";
            this.colValue.Width = 700;
            this.TabPageAssemblies.Controls.Add(this.AssemblyInfoListView);
            this.TabPageAssemblies.Location = new Point(4, 22);
            this.TabPageAssemblies.Name = "TabPageAssemblies";
            this.TabPageAssemblies.Size = new Size(368, 121);
            this.TabPageAssemblies.TabIndex = 1;
            this.TabPageAssemblies.Text = "Assemblies";
            this.AssemblyInfoListView.Columns.AddRange(new ColumnHeader[]
            {
                this.colAssemblyName,
                this.colAssemblyVersion,
                this.colAssemblyBuilt,
                this.colAssemblyCodeBase
            });
            this.AssemblyInfoListView.Dock = DockStyle.Fill;
            this.AssemblyInfoListView.FullRowSelect = true;
            this.AssemblyInfoListView.Location = new Point(0, 0);
            this.AssemblyInfoListView.MultiSelect = false;
            this.AssemblyInfoListView.Name = "AssemblyInfoListView";
            this.AssemblyInfoListView.Size = new Size(368, 121);
            this.AssemblyInfoListView.Sorting = SortOrder.Ascending;
            this.AssemblyInfoListView.TabIndex = 13;
            this.AssemblyInfoListView.UseCompatibleStateImageBehavior = false;
            this.AssemblyInfoListView.View = View.Details;
            this.colAssemblyName.Text = "Assembly";
            this.colAssemblyName.Width = 123;
            this.colAssemblyVersion.Text = "Version";
            this.colAssemblyVersion.Width = 100;
            this.colAssemblyBuilt.Text = "Built";
            this.colAssemblyBuilt.Width = 130;
            this.colAssemblyCodeBase.Text = "CodeBase";
            this.colAssemblyCodeBase.Width = 750;
            this.TabPageAssemblyDetails.Controls.Add(this.AssemblyDetailsListView);
            this.TabPageAssemblyDetails.Controls.Add(this.AssemblyNamesComboBox);
            this.TabPageAssemblyDetails.Location = new Point(4, 22);
            this.TabPageAssemblyDetails.Name = "TabPageAssemblyDetails";
            this.TabPageAssemblyDetails.Size = new Size(368, 121);
            this.TabPageAssemblyDetails.TabIndex = 2;
            this.TabPageAssemblyDetails.Text = "Assembly Details";
            this.AssemblyDetailsListView.Columns.AddRange(new ColumnHeader[]
            {
                this.ColumnHeader1,
                this.ColumnHeader2
            });
            this.AssemblyDetailsListView.Dock = DockStyle.Fill;
            this.AssemblyDetailsListView.FullRowSelect = true;
            this.AssemblyDetailsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.AssemblyDetailsListView.Location = new Point(0, 21);
            this.AssemblyDetailsListView.Name = "AssemblyDetailsListView";
            this.AssemblyDetailsListView.Size = new Size(368, 100);
            this.AssemblyDetailsListView.Sorting = SortOrder.Ascending;
            this.AssemblyDetailsListView.TabIndex = 19;
            this.AssemblyDetailsListView.UseCompatibleStateImageBehavior = false;
            this.AssemblyDetailsListView.View = View.Details;
            this.ColumnHeader1.Text = "Assembly Key";
            this.ColumnHeader1.Width = 120;
            this.ColumnHeader2.Text = "Value";
            this.ColumnHeader2.Width = 700;
            this.AssemblyNamesComboBox.Dock = DockStyle.Top;
            this.AssemblyNamesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AssemblyNamesComboBox.Location = new Point(0, 0);
            this.AssemblyNamesComboBox.Name = "AssemblyNamesComboBox";
            this.AssemblyNamesComboBox.Size = new Size(368, 21);
            this.AssemblyNamesComboBox.Sorted = true;
            this.AssemblyNamesComboBox.TabIndex = 18;
            this.btnAboutChanges.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnAboutChanges.Location = new Point(178, 474);
            this.btnAboutChanges.Name = "btnAboutChanges";
            this.btnAboutChanges.Size = new Size(59, 23);
            this.btnAboutChanges.TabIndex = 16;
            this.btnAboutChanges.Text = "Changes";
            this.btnAboutChanges.UseVisualStyleBackColor = true;
            this.btnAboutCredits.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnAboutCredits.Location = new Point(254, 474);
            this.btnAboutCredits.Name = "btnAboutCredits";
            this.btnAboutCredits.Size = new Size(59, 23);
            this.btnAboutCredits.TabIndex = 17;
            this.btnAboutCredits.Text = "Credits";
            this.btnAboutCredits.UseVisualStyleBackColor = true;
            this.btnAboutLicense.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnAboutLicense.Location = new Point(330, 474);
            this.btnAboutLicense.Name = "btnAboutLicense";
            this.btnAboutLicense.Size = new Size(59, 23);
            this.btnAboutLicense.TabIndex = 18;
            this.btnAboutLicense.Text = "License";
            this.btnAboutLicense.UseVisualStyleBackColor = true;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.CancelButton = this.OKButton;
            base.ClientSize = new Size(564, 505);
            base.Controls.Add(this.btnAboutLicense);
            base.Controls.Add(this.btnAboutCredits);
            base.Controls.Add(this.btnAboutChanges);
            base.Controls.Add(this.DetailsButton);
            base.Controls.Add(this.ImagePictureBox);
            base.Controls.Add(this.AppDateLabel);
            base.Controls.Add(this.SysInfoButton);
            base.Controls.Add(this.AppCopyrightLabel);
            base.Controls.Add(this.AppVersionLabel);
            base.Controls.Add(this.AppDescriptionLabel);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.AppTitleLabel);
            base.Controls.Add(this.OKButton);
            base.Controls.Add(this.MoreRichTextBox);
            base.Controls.Add(this.TabPanelDetails);
            this.Font = new Font("Tahoma", 8f);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "AboutBox";
            base.SizeGripStyle = SizeGripStyle.Hide;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "About %title%";
            ((ISupportInitialize)this.ImagePictureBox).EndInit();
            this.TabPanelDetails.ResumeLayout(false);
            this.TabPageApplication.ResumeLayout(false);
            this.TabPageAssemblies.ResumeLayout(false);
            this.TabPageAssemblyDetails.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            if (this._EntryAssembly == null)
            {
                this._EntryAssembly = Assembly.GetEntryAssembly();
            }
            if (this._EntryAssembly == null)
            {
                this._EntryAssembly = Assembly.GetExecutingAssembly();
            }
            this._ExecutingAssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            this._CallingAssemblyName = Assembly.GetCallingAssembly().GetName().Name;
            try
            {
                this._EntryAssemblyName = Assembly.GetEntryAssembly().GetName().Name;
            }
            catch (Exception expr_67)
            {
                ProjectData.SetProjectError(expr_67);
                ProjectData.ClearProjectError();
            }
            this.AppMoreInfo = Resources.AboutBox_AboutBox_Load_GrblPanelIsDesignedForUseWithGrbl09GOrLater + "\n\n" + Resources.AboutBox_AboutBox_Load_ForMoreDetailsOnThisAppPleaseVisit;
            this.AppMoreInfo = this.MoreRichTextBox.Text + this.githubLink;
            this.TabPanelDetails.Visible = false;
            this.MoreRichTextBox.Visible = true;
            this.btnAboutChanges.Visible = true;
            this.btnAboutCredits.Visible = true;
            this.btnAboutLicense.Visible = true;
            this.DetailsButton.Visible = true;
            this.SysInfoButton.Visible = false;
        }

        private void AboutBox_Paint(object sender, PaintEventArgs e)
        {
            if (!this._IsPainted)
            {
                this._IsPainted = true;
                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;
                this.PopulateLabels();
                Cursor.Current = Cursors.Default;
            }
        }

        private static DateTime AssemblyLastWriteTime(Assembly a)
        {
            DateTime AssemblyLastWriteTime;
            try
            {
                AssemblyLastWriteTime = File.GetLastWriteTime(a.Location);
            }
            catch (Exception expr_0E)
            {
                ProjectData.SetProjectError(expr_0E);
                AssemblyLastWriteTime = DateTime.MaxValue;
                ProjectData.ClearProjectError();
            }
            return AssemblyLastWriteTime;
        }

        private static DateTime AssemblyBuildDate(Assembly a, bool ForceFileDate = false)
        {
            Version AssemblyVersion = a.GetName().Version;
            DateTime dt;
            if (ForceFileDate)
            {
                dt = AboutBox.AssemblyLastWriteTime(a);
            }
            else
            {
                dt = Conversions.ToDate("01/01/2000").AddDays((double)AssemblyVersion.Build).AddSeconds((double)checked(AssemblyVersion.Revision * 2));
                if (TimeZone.IsDaylightSavingTime(dt, TimeZone.CurrentTimeZone.GetDaylightChanges(dt.Year)))
                {
                    dt = dt.AddHours(1.0);
                }
                if (DateTime.Compare(dt, DateTime.Now) > 0 || AssemblyVersion.Build < 730 || AssemblyVersion.Revision == 0)
                {
                    dt = AboutBox.AssemblyLastWriteTime(a);
                }
            }
            return dt;
        }

        private NameValueCollection AssemblyAttribs(Assembly a)
        {
            return new NameValueCollection();
        }

        private string RegistryHklmValue(string KeyName, string SubKeyRef)
        {
            string RegistryHklmValue;
            try
            {
                RegistryHklmValue = Convert.ToString(Registry.LocalMachine.OpenSubKey(KeyName).GetValue(SubKeyRef, ""));
            }
            catch (Exception expr_1E)
            {
                ProjectData.SetProjectError(expr_1E);
                RegistryHklmValue = "";
                ProjectData.ClearProjectError();
            }
            return RegistryHklmValue;
        }

        private void ShowSysInfo()
        {
            string strSysInfoPath = "";
            strSysInfoPath = this.RegistryHklmValue("SOFTWARE\\Microsoft\\Shared Tools Location", "MSINFO");
            if (String.Compare(strSysInfoPath, "", false) == 0)
            {
                strSysInfoPath = this.RegistryHklmValue("SOFTWARE\\Microsoft\\Shared Tools\\MSINFO", "PATH");
            }
            if (String.Compare(strSysInfoPath, "", false) == 0)
            {
                MessageBox.Show("System Information is unavailable at this time." + Environment.NewLine + Environment.NewLine + "(couldn't find path for Microsoft System Information Tool in the registry.)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                Process.Start(strSysInfoPath);
            }
            catch (Exception expr_77)
            {
                ProjectData.SetProjectError(expr_77);
                MessageBox.Show(string.Concat(new string[]
                {
                    "System Information is unavailable at this time.",
                    Environment.NewLine,
                    Environment.NewLine,
                    "(couldn't launch '",
                    strSysInfoPath,
                    "')"
                }), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
        }

        private void Populate(ListView lvw, string Key, string Value)
        {
            if (String.Compare(Value, "", false) != 0)
            {
                ListViewItem lvi = new ListViewItem
                {
                    Text = Key
                };
                lvi.SubItems.Add(Value);
                lvw.Items.Add(lvi);
            }
        }

        private void PopulateAppInfo()
        {
            AppDomain d = AppDomain.CurrentDomain;
            this.Populate(this.AppInfoListView, "Application Name", d.SetupInformation.ApplicationName);
            this.Populate(this.AppInfoListView, "Application Base", d.SetupInformation.ApplicationBase);
            this.Populate(this.AppInfoListView, "Cache Path", d.SetupInformation.CachePath);
            this.Populate(this.AppInfoListView, "Configuration File", d.SetupInformation.ConfigurationFile);
            this.Populate(this.AppInfoListView, "Dynamic Base", d.SetupInformation.DynamicBase);
            this.Populate(this.AppInfoListView, "Friendly Name", d.FriendlyName);
            this.Populate(this.AppInfoListView, "License File", d.SetupInformation.LicenseFile);
            this.Populate(this.AppInfoListView, "Private Bin Path", d.SetupInformation.PrivateBinPath);
            this.Populate(this.AppInfoListView, "Shadow Copy Directories", d.SetupInformation.ShadowCopyDirectories);
            this.Populate(this.AppInfoListView, " ", " ");
            this.Populate(this.AppInfoListView, "Entry Assembly", this._EntryAssemblyName);
            this.Populate(this.AppInfoListView, "Executing Assembly", this._ExecutingAssemblyName);
            this.Populate(this.AppInfoListView, "Calling Assembly", this._CallingAssemblyName);
        }

        private void PopulateAssemblies()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            checked
            {
                for (int i = 0; i < assemblies.Length; i++)
                {
                    Assembly a = assemblies[i];
                    this.PopulateAssemblySummary(a);
                }
                this.AssemblyNamesComboBox.SelectedIndex = this.AssemblyNamesComboBox.FindStringExact(this._EntryAssemblyName);
            }
        }

        private void PopulateAssemblySummary(Assembly a)
        {
            NameValueCollection nvc = this.AssemblyAttribs(a);
            string strAssemblyName = a.GetName().Name;
            ListViewItem lvi = new ListViewItem();
            ListViewItem listViewItem = lvi;
            listViewItem.Text = strAssemblyName;
            listViewItem.Tag = strAssemblyName;
            if (String.Compare(strAssemblyName, this._CallingAssemblyName, false) == 0)
            {
                ListViewItem listViewItem2;
                (listViewItem2 = listViewItem).Text = listViewItem2.Text + " (calling)";
            }
            if (String.Compare(strAssemblyName, this._ExecutingAssemblyName, false) == 0)
            {
                ListViewItem listViewItem2;
                (listViewItem2 = listViewItem).Text = listViewItem2.Text + " (executing)";
            }
            if (String.Compare(strAssemblyName, this._EntryAssemblyName, false) == 0)
            {
                ListViewItem listViewItem2;
                (listViewItem2 = listViewItem).Text = listViewItem2.Text + " (entry)";
            }
            listViewItem.SubItems.Add(nvc["version"]);
            listViewItem.SubItems.Add(nvc["builddate"]);
            listViewItem.SubItems.Add(nvc["codebase"]);
            this.AssemblyInfoListView.Items.Add(lvi);
            this.AssemblyNamesComboBox.Items.Add(strAssemblyName);
        }

        private string EntryAssemblyAttrib(string strName)
        {
            string EntryAssemblyAttrib;
            if (String.Compare(this._EntryAssemblyAttribCollection[strName], "", false) == 0)
            {
                EntryAssemblyAttrib = "<Assembly: Assembly" + strName + "(\"\")>";
            }
            else
            {
                EntryAssemblyAttrib = this._EntryAssemblyAttribCollection[strName].ToString();
            }
            return EntryAssemblyAttrib;
        }

        private void PopulateLabels()
        {
            this._EntryAssemblyAttribCollection = this.AssemblyAttribs(this._EntryAssembly);
            if (base.Owner == null)
            {
                this.ImagePictureBox.Visible = false;
                this.AppTitleLabel.Left = this.AppCopyrightLabel.Left;
                this.AppDescriptionLabel.Left = this.AppCopyrightLabel.Left;
            }
            else
            {
                base.Icon = base.Owner.Icon;
                this.ImagePictureBox.Image = base.Icon.ToBitmap();
            }
            this.Text = this.ReplaceTokens(this.Text);
            this.AppTitleLabel.Text = this.ReplaceTokens(this.AppTitleLabel.Text);
            if (this.AppDescriptionLabel.Visible)
            {
                this.AppDescriptionLabel.Text = this.ReplaceTokens(this.AppDescriptionLabel.Text);
            }
            if (this.AppCopyrightLabel.Visible)
            {
                this.AppCopyrightLabel.Text = this.ReplaceTokens(this.AppCopyrightLabel.Text);
            }
            if (this.AppVersionLabel.Visible)
            {
                this.AppVersionLabel.Text = this.ReplaceTokens(this.AppVersionLabel.Text);
            }
            if (this.AppDateLabel.Visible)
            {
                this.AppDateLabel.Text = this.ReplaceTokens(this.AppDateLabel.Text);
            }
            if (this.MoreRichTextBox.Visible)
            {
                this.MoreRichTextBox.Text = this.ReplaceTokens(this.MoreRichTextBox.Text);
            }
        }

        private string ReplaceTokens(string s)
        {
            s = s.Replace("%title%", this.EntryAssemblyAttrib("title"));
            s = s.Replace("%copyright%", this.EntryAssemblyAttrib("copyright"));
            s = s.Replace("%description%", this.EntryAssemblyAttrib("description"));
            s = s.Replace("%company%", this.EntryAssemblyAttrib("company"));
            s = s.Replace("%product%", this.EntryAssemblyAttrib("product"));
            s = s.Replace("%trademark%", this.EntryAssemblyAttrib("trademark"));
            s = s.Replace("%year%", DateTime.Now.Year.ToString());
            s = s.Replace("%version%", this.EntryAssemblyAttrib("version"));
            s = s.Replace("%builddate%", this.EntryAssemblyAttrib("builddate"));
            return s;
        }

        private void PopulateAssemblyDetails(Assembly a, ListView lvw)
        {
            lvw.Items.Clear();
            this.Populate(lvw, "Image Runtime Version", a.ImageRuntimeVersion);
            this.Populate(lvw, "Loaded from GAC", a.GlobalAssemblyCache.ToString());
            NameValueCollection nvc = this.AssemblyAttribs(a);
            IEnumerator enumerator = null;
            try
            {
                enumerator = nvc.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    string strKey = Convert.ToString(enumerator.Current);
                    this.Populate(lvw, strKey, nvc[strKey]);
                }
            }
            finally
            {
                (enumerator as IDisposable)?.Dispose();
            }
        }

        private Assembly MatchAssemblyByName(string AssemblyName)
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            checked
            {
                Assembly MatchAssemblyByName;
                for (int i = 0; i < assemblies.Length; i++)
                {
                    Assembly a = assemblies[i];
                    if (String.Compare(a.GetName().Name, AssemblyName, false) == 0)
                    {
                        MatchAssemblyByName = a;
                        return MatchAssemblyByName;
                    }
                }
                MatchAssemblyByName = null;
                return MatchAssemblyByName;
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.DetailsButton.Visible = false;
            this.btnAboutChanges.Visible = false;
            this.btnAboutCredits.Visible = false;
            this.btnAboutLicense.Visible = false;
            base.SuspendLayout();
            base.MaximizeBox = true;
            base.FormBorderStyle = FormBorderStyle.Sizable;
            base.SizeGripStyle = SizeGripStyle.Show;
            this.MoreRichTextBox.Visible = false;
            this.TabPanelDetails.Visible = true;
            this.SysInfoButton.Visible = true;
            this.PopulateAssemblies();
            this.PopulateAppInfo();
            base.CenterToParent();
            base.ResumeLayout();
            Cursor.Current = Cursors.Default;
        }

        private void SysInfoButton_Click(object sender, EventArgs e)
        {
            this.ShowSysInfo();
        }

        private void AssemblyInfoListView_DoubleClick(object sender, EventArgs e)
        {
            if (this.AssemblyInfoListView.SelectedItems.Count > 0)
            {
                string strAssemblyName = Convert.ToString(RuntimeHelpers.GetObjectValue(this.AssemblyInfoListView.SelectedItems[0].Tag));
                this.AssemblyNamesComboBox.SelectedIndex = this.AssemblyNamesComboBox.FindStringExact(strAssemblyName);
                this.TabPanelDetails.SelectedTab = this.TabPageAssemblyDetails;
            }
        }

        private void AssemblyNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strAssemblyName = Convert.ToString(RuntimeHelpers.GetObjectValue(this.AssemblyNamesComboBox.SelectedItem));
            this.PopulateAssemblyDetails(this.MatchAssemblyByName(strAssemblyName), this.AssemblyDetailsListView);
        }

        private void AssemblyInfoListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            checked
            {
                int intTargetCol = e.Column + 1;
                if (this.AssemblyInfoListView.Tag != null && Math.Abs(Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.AssemblyInfoListView.Tag))) == intTargetCol)
                {
                    intTargetCol = 0 - Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.AssemblyInfoListView.Tag));
                }
                this.AssemblyInfoListView.Tag = intTargetCol;
                this.AssemblyInfoListView.ListViewItemSorter = new AboutBox.ListViewItemComparer(intTargetCol, true);
            }
        }

        private void MoreRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.LinkText);
            }
            catch (Exception expr_0E)
            {
                ProjectData.SetProjectError(expr_0E);
                ProjectData.ClearProjectError();
            }
        }

        private void TabPanelDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TabPanelDetails.SelectedTab == this.TabPageAssemblyDetails)
            {
                this.AssemblyNamesComboBox.Focus();
            }
        }

        private void btnAboutCredits_Click(object sender, EventArgs e)
        {
            this.showFileContents("CREDITS");
        }

        private void btnAboutLicense_Click(object sender, EventArgs e)
        {
            this.showFileContents("LICENSE");
        }

        private void btnAboutChanges_Click(object sender, EventArgs e)
        {
            this.showFileContents("CHANGES");
        }

        private void showFileContents(string fileName)
        {
            byte[] data = new byte[4099];
            AppDomain d = AppDomain.CurrentDomain;
            FileStream fh;
            try
            {
                fh = new FileStream(string.Format("{0}\\{1}.txt", d.BaseDirectory, fileName), FileMode.Open);
            }
            catch (Exception expr_2B)
            {
                ProjectData.SetProjectError(expr_2B);
                MessageBox.Show("Can't find Credits file, did you copy all the files?");
                ProjectData.ClearProjectError();
                return;
            }
            fh.Read(data, 0, 4096);
            fh.Close();
            this.MoreRichTextBox.Text = Encoding.ASCII.GetString(data);
        }
    }
}