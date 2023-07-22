namespace MetroLibrary
{
    partial class StaffDetails_Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlbl_snic = new MetroFramework.Controls.MetroLabel();
            this.mlbl_sname = new MetroFramework.Controls.MetroLabel();
            this.mlbl_saddress = new MetroFramework.Controls.MetroLabel();
            this.mlbl_stp = new MetroFramework.Controls.MetroLabel();
            this.mlbl_semail = new MetroFramework.Controls.MetroLabel();
            this.mlbl_sid = new MetroFramework.Controls.MetroLabel();
            this.mlbl_stafftype = new MetroFramework.Controls.MetroLabel();
            this.txt_snic = new MetroFramework.Controls.MetroTextBox();
            this.txt_sname = new MetroFramework.Controls.MetroTextBox();
            this.txt_saddress = new MetroFramework.Controls.MetroTextBox();
            this.txt_stp = new MetroFramework.Controls.MetroTextBox();
            this.txt_semail = new MetroFramework.Controls.MetroTextBox();
            this.txt_sid = new MetroFramework.Controls.MetroTextBox();
            this.btn_ssave = new MetroFramework.Controls.MetroButton();
            this.btn_sclear = new MetroFramework.Controls.MetroButton();
            this.metroComboBox_stafftype = new MetroFramework.Controls.MetroComboBox();
            this.lblNICError = new MetroFramework.Controls.MetroLabel();
            this.lblNameError = new MetroFramework.Controls.MetroLabel();
            this.lblAddressError = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNoError = new MetroFramework.Controls.MetroLabel();
            this.lblEmailError = new MetroFramework.Controls.MetroLabel();
            this.lblStaffTypeError = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stafftype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registereddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIDError = new MetroFramework.Controls.MetroLabel();
            this.btn_supdate = new MetroFramework.Controls.MetroButton();
            this.txt_pwd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblcpwdError = new MetroFramework.Controls.MetroLabel();
            this.txt_cpwd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_sdelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // mlbl_snic
            // 
            this.mlbl_snic.AutoSize = true;
            this.mlbl_snic.Location = new System.Drawing.Point(39, 73);
            this.mlbl_snic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_snic.Name = "mlbl_snic";
            this.mlbl_snic.Size = new System.Drawing.Size(31, 19);
            this.mlbl_snic.TabIndex = 0;
            this.mlbl_snic.Text = "NIC";
            this.mlbl_snic.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_sname
            // 
            this.mlbl_sname.AutoSize = true;
            this.mlbl_sname.Location = new System.Drawing.Point(39, 122);
            this.mlbl_sname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_sname.Name = "mlbl_sname";
            this.mlbl_sname.Size = new System.Drawing.Size(45, 19);
            this.mlbl_sname.TabIndex = 1;
            this.mlbl_sname.Text = "Name";
            this.mlbl_sname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_saddress
            // 
            this.mlbl_saddress.AutoSize = true;
            this.mlbl_saddress.Location = new System.Drawing.Point(39, 175);
            this.mlbl_saddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_saddress.Name = "mlbl_saddress";
            this.mlbl_saddress.Size = new System.Drawing.Size(56, 19);
            this.mlbl_saddress.TabIndex = 2;
            this.mlbl_saddress.Text = "Address";
            this.mlbl_saddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_stp
            // 
            this.mlbl_stp.AutoSize = true;
            this.mlbl_stp.Location = new System.Drawing.Point(39, 279);
            this.mlbl_stp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_stp.Name = "mlbl_stp";
            this.mlbl_stp.Size = new System.Drawing.Size(99, 19);
            this.mlbl_stp.TabIndex = 3;
            this.mlbl_stp.Text = "Phone Number";
            this.mlbl_stp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_semail
            // 
            this.mlbl_semail.AutoSize = true;
            this.mlbl_semail.Location = new System.Drawing.Point(39, 332);
            this.mlbl_semail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_semail.Name = "mlbl_semail";
            this.mlbl_semail.Size = new System.Drawing.Size(47, 19);
            this.mlbl_semail.TabIndex = 4;
            this.mlbl_semail.Text = "E-mail";
            this.mlbl_semail.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_sid
            // 
            this.mlbl_sid.AutoSize = true;
            this.mlbl_sid.Location = new System.Drawing.Point(39, 226);
            this.mlbl_sid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_sid.Name = "mlbl_sid";
            this.mlbl_sid.Size = new System.Drawing.Size(21, 19);
            this.mlbl_sid.TabIndex = 5;
            this.mlbl_sid.Text = "ID";
            this.mlbl_sid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlbl_sid.Click += new System.EventHandler(this.mlbl_sid_Click);
            // 
            // mlbl_stafftype
            // 
            this.mlbl_stafftype.AutoSize = true;
            this.mlbl_stafftype.Location = new System.Drawing.Point(39, 386);
            this.mlbl_stafftype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_stafftype.Name = "mlbl_stafftype";
            this.mlbl_stafftype.Size = new System.Drawing.Size(66, 19);
            this.mlbl_stafftype.TabIndex = 6;
            this.mlbl_stafftype.Text = "Staff Type";
            this.mlbl_stafftype.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_snic
            // 
            // 
            // 
            // 
            this.txt_snic.CustomButton.Image = null;
            this.txt_snic.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_snic.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_snic.CustomButton.Name = "";
            this.txt_snic.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_snic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_snic.CustomButton.TabIndex = 1;
            this.txt_snic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_snic.CustomButton.UseSelectable = true;
            this.txt_snic.CustomButton.Visible = false;
            this.txt_snic.Lines = new string[0];
            this.txt_snic.Location = new System.Drawing.Point(177, 68);
            this.txt_snic.Margin = new System.Windows.Forms.Padding(2);
            this.txt_snic.MaxLength = 32767;
            this.txt_snic.Name = "txt_snic";
            this.txt_snic.PasswordChar = '\0';
            this.txt_snic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_snic.SelectedText = "";
            this.txt_snic.SelectionLength = 0;
            this.txt_snic.SelectionStart = 0;
            this.txt_snic.ShortcutsEnabled = true;
            this.txt_snic.Size = new System.Drawing.Size(234, 24);
            this.txt_snic.TabIndex = 8;
            this.txt_snic.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_snic.UseSelectable = true;
            this.txt_snic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_snic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_snic.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_snic_KeyUp);
            // 
            // txt_sname
            // 
            // 
            // 
            // 
            this.txt_sname.CustomButton.Image = null;
            this.txt_sname.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_sname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sname.CustomButton.Name = "";
            this.txt_sname.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_sname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sname.CustomButton.TabIndex = 1;
            this.txt_sname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sname.CustomButton.UseSelectable = true;
            this.txt_sname.CustomButton.Visible = false;
            this.txt_sname.Lines = new string[0];
            this.txt_sname.Location = new System.Drawing.Point(177, 117);
            this.txt_sname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sname.MaxLength = 32767;
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.PasswordChar = '\0';
            this.txt_sname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sname.SelectedText = "";
            this.txt_sname.SelectionLength = 0;
            this.txt_sname.SelectionStart = 0;
            this.txt_sname.ShortcutsEnabled = true;
            this.txt_sname.Size = new System.Drawing.Size(234, 24);
            this.txt_sname.TabIndex = 9;
            this.txt_sname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_sname.UseSelectable = true;
            this.txt_sname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sname_KeyUp);
            // 
            // txt_saddress
            // 
            // 
            // 
            // 
            this.txt_saddress.CustomButton.Image = null;
            this.txt_saddress.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_saddress.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_saddress.CustomButton.Name = "";
            this.txt_saddress.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_saddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_saddress.CustomButton.TabIndex = 1;
            this.txt_saddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_saddress.CustomButton.UseSelectable = true;
            this.txt_saddress.CustomButton.Visible = false;
            this.txt_saddress.Lines = new string[0];
            this.txt_saddress.Location = new System.Drawing.Point(177, 166);
            this.txt_saddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_saddress.MaxLength = 32767;
            this.txt_saddress.Name = "txt_saddress";
            this.txt_saddress.PasswordChar = '\0';
            this.txt_saddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_saddress.SelectedText = "";
            this.txt_saddress.SelectionLength = 0;
            this.txt_saddress.SelectionStart = 0;
            this.txt_saddress.ShortcutsEnabled = true;
            this.txt_saddress.Size = new System.Drawing.Size(234, 24);
            this.txt_saddress.TabIndex = 10;
            this.txt_saddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_saddress.UseSelectable = true;
            this.txt_saddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_saddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_saddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_saddress_KeyUp);
            // 
            // txt_stp
            // 
            // 
            // 
            // 
            this.txt_stp.CustomButton.Image = null;
            this.txt_stp.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_stp.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stp.CustomButton.Name = "";
            this.txt_stp.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_stp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_stp.CustomButton.TabIndex = 1;
            this.txt_stp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_stp.CustomButton.UseSelectable = true;
            this.txt_stp.CustomButton.Visible = false;
            this.txt_stp.Lines = new string[0];
            this.txt_stp.Location = new System.Drawing.Point(176, 274);
            this.txt_stp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stp.MaxLength = 32767;
            this.txt_stp.Name = "txt_stp";
            this.txt_stp.PasswordChar = '\0';
            this.txt_stp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stp.SelectedText = "";
            this.txt_stp.SelectionLength = 0;
            this.txt_stp.SelectionStart = 0;
            this.txt_stp.ShortcutsEnabled = true;
            this.txt_stp.Size = new System.Drawing.Size(234, 24);
            this.txt_stp.TabIndex = 11;
            this.txt_stp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_stp.UseSelectable = true;
            this.txt_stp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_stp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_stp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_stp_KeyUp);
            // 
            // txt_semail
            // 
            // 
            // 
            // 
            this.txt_semail.CustomButton.Image = null;
            this.txt_semail.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_semail.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_semail.CustomButton.Name = "";
            this.txt_semail.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_semail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_semail.CustomButton.TabIndex = 1;
            this.txt_semail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_semail.CustomButton.UseSelectable = true;
            this.txt_semail.CustomButton.Visible = false;
            this.txt_semail.Lines = new string[0];
            this.txt_semail.Location = new System.Drawing.Point(176, 327);
            this.txt_semail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_semail.MaxLength = 32767;
            this.txt_semail.Name = "txt_semail";
            this.txt_semail.PasswordChar = '\0';
            this.txt_semail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_semail.SelectedText = "";
            this.txt_semail.SelectionLength = 0;
            this.txt_semail.SelectionStart = 0;
            this.txt_semail.ShortcutsEnabled = true;
            this.txt_semail.Size = new System.Drawing.Size(234, 24);
            this.txt_semail.TabIndex = 12;
            this.txt_semail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_semail.UseSelectable = true;
            this.txt_semail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_semail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_semail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_semail_KeyUp);
            // 
            // txt_sid
            // 
            // 
            // 
            // 
            this.txt_sid.CustomButton.Image = null;
            this.txt_sid.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_sid.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sid.CustomButton.Name = "";
            this.txt_sid.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_sid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sid.CustomButton.TabIndex = 1;
            this.txt_sid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sid.CustomButton.UseSelectable = true;
            this.txt_sid.CustomButton.Visible = false;
            this.txt_sid.Lines = new string[0];
            this.txt_sid.Location = new System.Drawing.Point(178, 221);
            this.txt_sid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sid.MaxLength = 32767;
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.PasswordChar = '\0';
            this.txt_sid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sid.SelectedText = "";
            this.txt_sid.SelectionLength = 0;
            this.txt_sid.SelectionStart = 0;
            this.txt_sid.ShortcutsEnabled = true;
            this.txt_sid.Size = new System.Drawing.Size(234, 24);
            this.txt_sid.TabIndex = 13;
            this.txt_sid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_sid.UseSelectable = true;
            this.txt_sid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sid_KeyUp);
            // 
            // btn_ssave
            // 
            this.btn_ssave.Location = new System.Drawing.Point(39, 540);
            this.btn_ssave.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ssave.Name = "btn_ssave";
            this.btn_ssave.Size = new System.Drawing.Size(88, 36);
            this.btn_ssave.TabIndex = 16;
            this.btn_ssave.Text = "Save";
            this.btn_ssave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_ssave.UseSelectable = true;
            this.btn_ssave.Click += new System.EventHandler(this.btn_ssave_Click);
            // 
            // btn_sclear
            // 
            this.btn_sclear.Location = new System.Drawing.Point(317, 540);
            this.btn_sclear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sclear.Name = "btn_sclear";
            this.btn_sclear.Size = new System.Drawing.Size(95, 36);
            this.btn_sclear.TabIndex = 17;
            this.btn_sclear.Text = "Clear";
            this.btn_sclear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_sclear.UseSelectable = true;
            this.btn_sclear.Click += new System.EventHandler(this.btn_sclear_Click);
            // 
            // metroComboBox_stafftype
            // 
            this.metroComboBox_stafftype.FormattingEnabled = true;
            this.metroComboBox_stafftype.ItemHeight = 23;
            this.metroComboBox_stafftype.Items.AddRange(new object[] {
            "General Public",
            "Student",
            "Other"});
            this.metroComboBox_stafftype.Location = new System.Drawing.Point(177, 376);
            this.metroComboBox_stafftype.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox_stafftype.Name = "metroComboBox_stafftype";
            this.metroComboBox_stafftype.Size = new System.Drawing.Size(234, 29);
            this.metroComboBox_stafftype.TabIndex = 19;
            this.metroComboBox_stafftype.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox_stafftype.UseSelectable = true;
            this.metroComboBox_stafftype.SelectedIndexChanged += new System.EventHandler(this.metroComboBox_stafftype_SelectedIndexChanged);
            // 
            // lblNICError
            // 
            this.lblNICError.AutoSize = true;
            this.lblNICError.ForeColor = System.Drawing.Color.Red;
            this.lblNICError.Location = new System.Drawing.Point(178, 93);
            this.lblNICError.Name = "lblNICError";
            this.lblNICError.Size = new System.Drawing.Size(81, 19);
            this.lblNICError.TabIndex = 20;
            this.lblNICError.Text = "metroLabel1";
            this.lblNICError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNICError.UseCustomForeColor = true;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(178, 142);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(83, 19);
            this.lblNameError.TabIndex = 21;
            this.lblNameError.Text = "metroLabel2";
            this.lblNameError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNameError.UseCustomForeColor = true;
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(178, 192);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(83, 19);
            this.lblAddressError.TabIndex = 22;
            this.lblAddressError.Text = "metroLabel3";
            this.lblAddressError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAddressError.UseCustomForeColor = true;
            // 
            // lblPhoneNoError
            // 
            this.lblPhoneNoError.AutoSize = true;
            this.lblPhoneNoError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNoError.Location = new System.Drawing.Point(178, 300);
            this.lblPhoneNoError.Name = "lblPhoneNoError";
            this.lblPhoneNoError.Size = new System.Drawing.Size(83, 19);
            this.lblPhoneNoError.TabIndex = 24;
            this.lblPhoneNoError.Text = "metroLabel5";
            this.lblPhoneNoError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPhoneNoError.UseCustomForeColor = true;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(178, 353);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(83, 19);
            this.lblEmailError.TabIndex = 25;
            this.lblEmailError.Text = "metroLabel6";
            this.lblEmailError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblEmailError.UseCustomForeColor = true;
            // 
            // lblStaffTypeError
            // 
            this.lblStaffTypeError.AutoSize = true;
            this.lblStaffTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblStaffTypeError.Location = new System.Drawing.Point(178, 406);
            this.lblStaffTypeError.Name = "lblStaffTypeError";
            this.lblStaffTypeError.Size = new System.Drawing.Size(83, 19);
            this.lblStaffTypeError.TabIndex = 26;
            this.lblStaffTypeError.Text = "metroLabel7";
            this.lblStaffTypeError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStaffTypeError.UseCustomForeColor = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NIC,
            this.name,
            this.address,
            this.tp,
            this.email,
            this.stafftype,
            this.registereddate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(417, 63);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(882, 525);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 27;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NIC
            // 
            this.NIC.HeaderText = "NIC";
            this.NIC.Name = "NIC";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // tp
            // 
            this.tp.HeaderText = "Phone Number";
            this.tp.Name = "tp";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // stafftype
            // 
            this.stafftype.HeaderText = "Staff Type";
            this.stafftype.Name = "stafftype";
            // 
            // registereddate
            // 
            this.registereddate.HeaderText = "Registered Date";
            this.registereddate.Name = "registereddate";
            // 
            // lblIDError
            // 
            this.lblIDError.AutoSize = true;
            this.lblIDError.ForeColor = System.Drawing.Color.Red;
            this.lblIDError.Location = new System.Drawing.Point(178, 247);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(83, 19);
            this.lblIDError.TabIndex = 28;
            this.lblIDError.Text = "metroLabel5";
            this.lblIDError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblIDError.UseCustomForeColor = true;
            // 
            // btn_supdate
            // 
            this.btn_supdate.Location = new System.Drawing.Point(127, 540);
            this.btn_supdate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_supdate.Name = "btn_supdate";
            this.btn_supdate.Size = new System.Drawing.Size(95, 36);
            this.btn_supdate.TabIndex = 29;
            this.btn_supdate.Text = "Update";
            this.btn_supdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_supdate.UseSelectable = true;
            // 
            // txt_pwd
            // 
            // 
            // 
            // 
            this.txt_pwd.CustomButton.Image = null;
            this.txt_pwd.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_pwd.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pwd.CustomButton.Name = "";
            this.txt_pwd.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pwd.CustomButton.TabIndex = 1;
            this.txt_pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pwd.CustomButton.UseSelectable = true;
            this.txt_pwd.CustomButton.Visible = false;
            this.txt_pwd.Lines = new string[0];
            this.txt_pwd.Location = new System.Drawing.Point(178, 429);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pwd.MaxLength = 32767;
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '\0';
            this.txt_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pwd.SelectedText = "";
            this.txt_pwd.SelectionLength = 0;
            this.txt_pwd.SelectionStart = 0;
            this.txt_pwd.ShortcutsEnabled = true;
            this.txt_pwd.Size = new System.Drawing.Size(234, 24);
            this.txt_pwd.TabIndex = 31;
            this.txt_pwd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_pwd.UseSelectable = true;
            this.txt_pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 434);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblcpwdError
            // 
            this.lblcpwdError.AutoSize = true;
            this.lblcpwdError.ForeColor = System.Drawing.Color.Red;
            this.lblcpwdError.Location = new System.Drawing.Point(178, 504);
            this.lblcpwdError.Name = "lblcpwdError";
            this.lblcpwdError.Size = new System.Drawing.Size(83, 19);
            this.lblcpwdError.TabIndex = 35;
            this.lblcpwdError.Text = "metroLabel5";
            this.lblcpwdError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblcpwdError.UseCustomForeColor = true;
            this.lblcpwdError.WrapToLine = true;
            // 
            // txt_cpwd
            // 
            // 
            // 
            // 
            this.txt_cpwd.CustomButton.Image = null;
            this.txt_cpwd.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_cpwd.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cpwd.CustomButton.Name = "";
            this.txt_cpwd.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_cpwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cpwd.CustomButton.TabIndex = 1;
            this.txt_cpwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cpwd.CustomButton.UseSelectable = true;
            this.txt_cpwd.CustomButton.Visible = false;
            this.txt_cpwd.Lines = new string[0];
            this.txt_cpwd.Location = new System.Drawing.Point(178, 478);
            this.txt_cpwd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cpwd.MaxLength = 32767;
            this.txt_cpwd.Name = "txt_cpwd";
            this.txt_cpwd.PasswordChar = '\0';
            this.txt_cpwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cpwd.SelectedText = "";
            this.txt_cpwd.SelectionLength = 0;
            this.txt_cpwd.SelectionStart = 0;
            this.txt_cpwd.ShortcutsEnabled = true;
            this.txt_cpwd.Size = new System.Drawing.Size(234, 24);
            this.txt_cpwd.TabIndex = 34;
            this.txt_cpwd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_cpwd.UseSelectable = true;
            this.txt_cpwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cpwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(39, 483);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Confirm Password";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_sdelete
            // 
            this.btn_sdelete.Location = new System.Drawing.Point(222, 540);
            this.btn_sdelete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sdelete.Name = "btn_sdelete";
            this.btn_sdelete.Size = new System.Drawing.Size(95, 36);
            this.btn_sdelete.TabIndex = 36;
            this.btn_sdelete.Text = "Delete";
            this.btn_sdelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_sdelete.UseSelectable = true;
            this.btn_sdelete.Click += new System.EventHandler(this.btn_sdelete_Click);
            // 
            // StaffDetails_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 607);
            this.Controls.Add(this.btn_sdelete);
            this.Controls.Add(this.lblcpwdError);
            this.Controls.Add(this.txt_cpwd);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btn_supdate);
            this.Controls.Add(this.lblIDError);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lblStaffTypeError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblPhoneNoError);
            this.Controls.Add(this.lblAddressError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblNICError);
            this.Controls.Add(this.metroComboBox_stafftype);
            this.Controls.Add(this.btn_sclear);
            this.Controls.Add(this.btn_ssave);
            this.Controls.Add(this.txt_sid);
            this.Controls.Add(this.txt_semail);
            this.Controls.Add(this.txt_stp);
            this.Controls.Add(this.txt_saddress);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.txt_snic);
            this.Controls.Add(this.mlbl_stafftype);
            this.Controls.Add(this.mlbl_sid);
            this.Controls.Add(this.mlbl_semail);
            this.Controls.Add(this.mlbl_stp);
            this.Controls.Add(this.mlbl_saddress);
            this.Controls.Add(this.mlbl_sname);
            this.Controls.Add(this.mlbl_snic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffDetails_Registration";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Staff Details and Registration";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffDetails_Registration_FormClosed);
            this.Load += new System.EventHandler(this.StaffDetails_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlbl_snic;
        private MetroFramework.Controls.MetroLabel mlbl_sname;
        private MetroFramework.Controls.MetroLabel mlbl_saddress;
        private MetroFramework.Controls.MetroLabel mlbl_stp;
        private MetroFramework.Controls.MetroLabel mlbl_semail;
        private MetroFramework.Controls.MetroLabel mlbl_sid;
        private MetroFramework.Controls.MetroLabel mlbl_stafftype;
        private MetroFramework.Controls.MetroTextBox txt_snic;
        private MetroFramework.Controls.MetroTextBox txt_sname;
        private MetroFramework.Controls.MetroTextBox txt_saddress;
        private MetroFramework.Controls.MetroTextBox txt_stp;
        private MetroFramework.Controls.MetroTextBox txt_semail;
        private MetroFramework.Controls.MetroTextBox txt_sid;
        private MetroFramework.Controls.MetroButton btn_ssave;
        private MetroFramework.Controls.MetroButton btn_sclear;
        private MetroFramework.Controls.MetroComboBox metroComboBox_stafftype;
        private MetroFramework.Controls.MetroLabel lblNICError;
        private MetroFramework.Controls.MetroLabel lblNameError;
        private MetroFramework.Controls.MetroLabel lblAddressError;
        private MetroFramework.Controls.MetroLabel lblPhoneNoError;
        private MetroFramework.Controls.MetroLabel lblEmailError;
        private MetroFramework.Controls.MetroLabel lblStaffTypeError;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn stafftype;
        private System.Windows.Forms.DataGridViewTextBoxColumn registereddate;
        private MetroFramework.Controls.MetroLabel lblIDError;
        private MetroFramework.Controls.MetroButton btn_supdate;
        private MetroFramework.Controls.MetroTextBox txt_pwd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblcpwdError;
        private MetroFramework.Controls.MetroTextBox txt_cpwd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btn_sdelete;
    }
}