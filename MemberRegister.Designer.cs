namespace MetroLibrary
{
    partial class MemberRegister
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
            this.lblStaffTypeError = new MetroFramework.Controls.MetroLabel();
            this.lblEmailError = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNoError = new MetroFramework.Controls.MetroLabel();
            this.lblAddressError = new MetroFramework.Controls.MetroLabel();
            this.lblNameError = new MetroFramework.Controls.MetroLabel();
            this.lblNICError = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox_membertype = new MetroFramework.Controls.MetroComboBox();
            this.btn_sexit = new MetroFramework.Controls.MetroButton();
            this.btn_sclear = new MetroFramework.Controls.MetroButton();
            this.btn_msave = new MetroFramework.Controls.MetroButton();
            this.txt_mid = new MetroFramework.Controls.MetroTextBox();
            this.txt_memail = new MetroFramework.Controls.MetroTextBox();
            this.txt_mtp = new MetroFramework.Controls.MetroTextBox();
            this.txt_maddress = new MetroFramework.Controls.MetroTextBox();
            this.txt_mname = new MetroFramework.Controls.MetroTextBox();
            this.txt_mnic = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_stafftype = new MetroFramework.Controls.MetroLabel();
            this.mlbl_sid = new MetroFramework.Controls.MetroLabel();
            this.mlbl_semail = new MetroFramework.Controls.MetroLabel();
            this.mlbl_stp = new MetroFramework.Controls.MetroLabel();
            this.mlbl_saddress = new MetroFramework.Controls.MetroLabel();
            this.mlbl_sname = new MetroFramework.Controls.MetroLabel();
            this.mlbl_snic = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblStaffTypeError
            // 
            this.lblStaffTypeError.AutoSize = true;
            this.lblStaffTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblStaffTypeError.Location = new System.Drawing.Point(168, 406);
            this.lblStaffTypeError.Name = "lblStaffTypeError";
            this.lblStaffTypeError.Size = new System.Drawing.Size(83, 19);
            this.lblStaffTypeError.TabIndex = 49;
            this.lblStaffTypeError.Text = "metroLabel7";
            this.lblStaffTypeError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStaffTypeError.UseCustomForeColor = true;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(168, 353);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(83, 19);
            this.lblEmailError.TabIndex = 48;
            this.lblEmailError.Text = "metroLabel6";
            this.lblEmailError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblEmailError.UseCustomForeColor = true;
            // 
            // lblPhoneNoError
            // 
            this.lblPhoneNoError.AutoSize = true;
            this.lblPhoneNoError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNoError.Location = new System.Drawing.Point(168, 300);
            this.lblPhoneNoError.Name = "lblPhoneNoError";
            this.lblPhoneNoError.Size = new System.Drawing.Size(83, 19);
            this.lblPhoneNoError.TabIndex = 47;
            this.lblPhoneNoError.Text = "metroLabel5";
            this.lblPhoneNoError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPhoneNoError.UseCustomForeColor = true;
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(168, 192);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(83, 19);
            this.lblAddressError.TabIndex = 46;
            this.lblAddressError.Text = "metroLabel3";
            this.lblAddressError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAddressError.UseCustomForeColor = true;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(168, 142);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(83, 19);
            this.lblNameError.TabIndex = 45;
            this.lblNameError.Text = "metroLabel2";
            this.lblNameError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNameError.UseCustomForeColor = true;
            // 
            // lblNICError
            // 
            this.lblNICError.AutoSize = true;
            this.lblNICError.ForeColor = System.Drawing.Color.Red;
            this.lblNICError.Location = new System.Drawing.Point(168, 93);
            this.lblNICError.Name = "lblNICError";
            this.lblNICError.Size = new System.Drawing.Size(81, 19);
            this.lblNICError.TabIndex = 44;
            this.lblNICError.Text = "metroLabel1";
            this.lblNICError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNICError.UseCustomForeColor = true;
            // 
            // metroComboBox_membertype
            // 
            this.metroComboBox_membertype.FormattingEnabled = true;
            this.metroComboBox_membertype.ItemHeight = 23;
            this.metroComboBox_membertype.Items.AddRange(new object[] {
            "General Public",
            "Student",
            "Other"});
            this.metroComboBox_membertype.Location = new System.Drawing.Point(167, 376);
            this.metroComboBox_membertype.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox_membertype.Name = "metroComboBox_membertype";
            this.metroComboBox_membertype.Size = new System.Drawing.Size(234, 29);
            this.metroComboBox_membertype.TabIndex = 43;
            this.metroComboBox_membertype.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox_membertype.UseSelectable = true;
            // 
            // btn_sexit
            // 
            this.btn_sexit.Location = new System.Drawing.Point(314, 443);
            this.btn_sexit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sexit.Name = "btn_sexit";
            this.btn_sexit.Size = new System.Drawing.Size(86, 36);
            this.btn_sexit.TabIndex = 42;
            this.btn_sexit.Text = "Exit";
            this.btn_sexit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_sexit.UseSelectable = true;
            // 
            // btn_sclear
            // 
            this.btn_sclear.Location = new System.Drawing.Point(168, 443);
            this.btn_sclear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sclear.Name = "btn_sclear";
            this.btn_sclear.Size = new System.Drawing.Size(95, 36);
            this.btn_sclear.TabIndex = 41;
            this.btn_sclear.Text = "Clear";
            this.btn_sclear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_sclear.UseSelectable = true;
            // 
            // btn_msave
            // 
            this.btn_msave.Location = new System.Drawing.Point(29, 443);
            this.btn_msave.Margin = new System.Windows.Forms.Padding(2);
            this.btn_msave.Name = "btn_msave";
            this.btn_msave.Size = new System.Drawing.Size(88, 36);
            this.btn_msave.TabIndex = 40;
            this.btn_msave.Text = "Save";
            this.btn_msave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_msave.UseSelectable = true;
            // 
            // txt_mid
            // 
            // 
            // 
            // 
            this.txt_mid.CustomButton.Image = null;
            this.txt_mid.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_mid.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mid.CustomButton.Name = "";
            this.txt_mid.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_mid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mid.CustomButton.TabIndex = 1;
            this.txt_mid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mid.CustomButton.UseSelectable = true;
            this.txt_mid.CustomButton.Visible = false;
            this.txt_mid.Lines = new string[0];
            this.txt_mid.Location = new System.Drawing.Point(168, 221);
            this.txt_mid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mid.MaxLength = 32767;
            this.txt_mid.Name = "txt_mid";
            this.txt_mid.PasswordChar = '\0';
            this.txt_mid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mid.SelectedText = "";
            this.txt_mid.SelectionLength = 0;
            this.txt_mid.SelectionStart = 0;
            this.txt_mid.ShortcutsEnabled = true;
            this.txt_mid.Size = new System.Drawing.Size(234, 24);
            this.txt_mid.TabIndex = 39;
            this.txt_mid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_mid.UseSelectable = true;
            this.txt_mid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_memail
            // 
            // 
            // 
            // 
            this.txt_memail.CustomButton.Image = null;
            this.txt_memail.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_memail.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_memail.CustomButton.Name = "";
            this.txt_memail.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_memail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_memail.CustomButton.TabIndex = 1;
            this.txt_memail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_memail.CustomButton.UseSelectable = true;
            this.txt_memail.CustomButton.Visible = false;
            this.txt_memail.Lines = new string[0];
            this.txt_memail.Location = new System.Drawing.Point(166, 327);
            this.txt_memail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_memail.MaxLength = 32767;
            this.txt_memail.Name = "txt_memail";
            this.txt_memail.PasswordChar = '\0';
            this.txt_memail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memail.SelectedText = "";
            this.txt_memail.SelectionLength = 0;
            this.txt_memail.SelectionStart = 0;
            this.txt_memail.ShortcutsEnabled = true;
            this.txt_memail.Size = new System.Drawing.Size(234, 24);
            this.txt_memail.TabIndex = 38;
            this.txt_memail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_memail.UseSelectable = true;
            this.txt_memail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_memail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_mtp
            // 
            // 
            // 
            // 
            this.txt_mtp.CustomButton.Image = null;
            this.txt_mtp.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_mtp.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mtp.CustomButton.Name = "";
            this.txt_mtp.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_mtp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mtp.CustomButton.TabIndex = 1;
            this.txt_mtp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mtp.CustomButton.UseSelectable = true;
            this.txt_mtp.CustomButton.Visible = false;
            this.txt_mtp.Lines = new string[0];
            this.txt_mtp.Location = new System.Drawing.Point(166, 274);
            this.txt_mtp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mtp.MaxLength = 32767;
            this.txt_mtp.Name = "txt_mtp";
            this.txt_mtp.PasswordChar = '\0';
            this.txt_mtp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mtp.SelectedText = "";
            this.txt_mtp.SelectionLength = 0;
            this.txt_mtp.SelectionStart = 0;
            this.txt_mtp.ShortcutsEnabled = true;
            this.txt_mtp.Size = new System.Drawing.Size(234, 24);
            this.txt_mtp.TabIndex = 37;
            this.txt_mtp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_mtp.UseSelectable = true;
            this.txt_mtp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mtp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_maddress
            // 
            // 
            // 
            // 
            this.txt_maddress.CustomButton.Image = null;
            this.txt_maddress.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_maddress.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maddress.CustomButton.Name = "";
            this.txt_maddress.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_maddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_maddress.CustomButton.TabIndex = 1;
            this.txt_maddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_maddress.CustomButton.UseSelectable = true;
            this.txt_maddress.CustomButton.Visible = false;
            this.txt_maddress.Lines = new string[0];
            this.txt_maddress.Location = new System.Drawing.Point(167, 166);
            this.txt_maddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maddress.MaxLength = 32767;
            this.txt_maddress.Name = "txt_maddress";
            this.txt_maddress.PasswordChar = '\0';
            this.txt_maddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_maddress.SelectedText = "";
            this.txt_maddress.SelectionLength = 0;
            this.txt_maddress.SelectionStart = 0;
            this.txt_maddress.ShortcutsEnabled = true;
            this.txt_maddress.Size = new System.Drawing.Size(234, 24);
            this.txt_maddress.TabIndex = 36;
            this.txt_maddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_maddress.UseSelectable = true;
            this.txt_maddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_maddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_mname
            // 
            // 
            // 
            // 
            this.txt_mname.CustomButton.Image = null;
            this.txt_mname.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_mname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mname.CustomButton.Name = "";
            this.txt_mname.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_mname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mname.CustomButton.TabIndex = 1;
            this.txt_mname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mname.CustomButton.UseSelectable = true;
            this.txt_mname.CustomButton.Visible = false;
            this.txt_mname.Lines = new string[0];
            this.txt_mname.Location = new System.Drawing.Point(167, 117);
            this.txt_mname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mname.MaxLength = 32767;
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.PasswordChar = '\0';
            this.txt_mname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mname.SelectedText = "";
            this.txt_mname.SelectionLength = 0;
            this.txt_mname.SelectionStart = 0;
            this.txt_mname.ShortcutsEnabled = true;
            this.txt_mname.Size = new System.Drawing.Size(234, 24);
            this.txt_mname.TabIndex = 35;
            this.txt_mname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_mname.UseSelectable = true;
            this.txt_mname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_mnic
            // 
            // 
            // 
            // 
            this.txt_mnic.CustomButton.Image = null;
            this.txt_mnic.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txt_mnic.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mnic.CustomButton.Name = "";
            this.txt_mnic.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_mnic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mnic.CustomButton.TabIndex = 1;
            this.txt_mnic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mnic.CustomButton.UseSelectable = true;
            this.txt_mnic.CustomButton.Visible = false;
            this.txt_mnic.Lines = new string[0];
            this.txt_mnic.Location = new System.Drawing.Point(167, 68);
            this.txt_mnic.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mnic.MaxLength = 32767;
            this.txt_mnic.Name = "txt_mnic";
            this.txt_mnic.PasswordChar = '\0';
            this.txt_mnic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mnic.SelectedText = "";
            this.txt_mnic.SelectionLength = 0;
            this.txt_mnic.SelectionStart = 0;
            this.txt_mnic.ShortcutsEnabled = true;
            this.txt_mnic.Size = new System.Drawing.Size(234, 24);
            this.txt_mnic.TabIndex = 34;
            this.txt_mnic.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_mnic.UseSelectable = true;
            this.txt_mnic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mnic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_stafftype
            // 
            this.mlbl_stafftype.AutoSize = true;
            this.mlbl_stafftype.Location = new System.Drawing.Point(29, 386);
            this.mlbl_stafftype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_stafftype.Name = "mlbl_stafftype";
            this.mlbl_stafftype.Size = new System.Drawing.Size(91, 19);
            this.mlbl_stafftype.TabIndex = 33;
            this.mlbl_stafftype.Text = "Member Type";
            this.mlbl_stafftype.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_sid
            // 
            this.mlbl_sid.AutoSize = true;
            this.mlbl_sid.Location = new System.Drawing.Point(29, 226);
            this.mlbl_sid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_sid.Name = "mlbl_sid";
            this.mlbl_sid.Size = new System.Drawing.Size(21, 19);
            this.mlbl_sid.TabIndex = 32;
            this.mlbl_sid.Text = "ID";
            this.mlbl_sid.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_semail
            // 
            this.mlbl_semail.AutoSize = true;
            this.mlbl_semail.Location = new System.Drawing.Point(29, 332);
            this.mlbl_semail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_semail.Name = "mlbl_semail";
            this.mlbl_semail.Size = new System.Drawing.Size(47, 19);
            this.mlbl_semail.TabIndex = 31;
            this.mlbl_semail.Text = "E-mail";
            this.mlbl_semail.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_stp
            // 
            this.mlbl_stp.AutoSize = true;
            this.mlbl_stp.Location = new System.Drawing.Point(29, 279);
            this.mlbl_stp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_stp.Name = "mlbl_stp";
            this.mlbl_stp.Size = new System.Drawing.Size(99, 19);
            this.mlbl_stp.TabIndex = 30;
            this.mlbl_stp.Text = "Phone Number";
            this.mlbl_stp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_saddress
            // 
            this.mlbl_saddress.AutoSize = true;
            this.mlbl_saddress.Location = new System.Drawing.Point(29, 175);
            this.mlbl_saddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_saddress.Name = "mlbl_saddress";
            this.mlbl_saddress.Size = new System.Drawing.Size(56, 19);
            this.mlbl_saddress.TabIndex = 29;
            this.mlbl_saddress.Text = "Address";
            this.mlbl_saddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_sname
            // 
            this.mlbl_sname.AutoSize = true;
            this.mlbl_sname.Location = new System.Drawing.Point(29, 122);
            this.mlbl_sname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_sname.Name = "mlbl_sname";
            this.mlbl_sname.Size = new System.Drawing.Size(45, 19);
            this.mlbl_sname.TabIndex = 28;
            this.mlbl_sname.Text = "Name";
            this.mlbl_sname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_snic
            // 
            this.mlbl_snic.AutoSize = true;
            this.mlbl_snic.Location = new System.Drawing.Point(29, 73);
            this.mlbl_snic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_snic.Name = "mlbl_snic";
            this.mlbl_snic.Size = new System.Drawing.Size(31, 19);
            this.mlbl_snic.TabIndex = 27;
            this.mlbl_snic.Text = "NIC";
            this.mlbl_snic.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MemberRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 509);
            this.Controls.Add(this.lblStaffTypeError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblPhoneNoError);
            this.Controls.Add(this.lblAddressError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblNICError);
            this.Controls.Add(this.metroComboBox_membertype);
            this.Controls.Add(this.btn_sexit);
            this.Controls.Add(this.btn_sclear);
            this.Controls.Add(this.btn_msave);
            this.Controls.Add(this.txt_mid);
            this.Controls.Add(this.txt_memail);
            this.Controls.Add(this.txt_mtp);
            this.Controls.Add(this.txt_maddress);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.txt_mnic);
            this.Controls.Add(this.mlbl_stafftype);
            this.Controls.Add(this.mlbl_sid);
            this.Controls.Add(this.mlbl_semail);
            this.Controls.Add(this.mlbl_stp);
            this.Controls.Add(this.mlbl_saddress);
            this.Controls.Add(this.mlbl_sname);
            this.Controls.Add(this.mlbl_snic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberRegister";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Member Register";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberRegister_FormClosed);
            this.Load += new System.EventHandler(this.MemberRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblStaffTypeError;
        private MetroFramework.Controls.MetroLabel lblEmailError;
        private MetroFramework.Controls.MetroLabel lblPhoneNoError;
        private MetroFramework.Controls.MetroLabel lblAddressError;
        private MetroFramework.Controls.MetroLabel lblNameError;
        private MetroFramework.Controls.MetroLabel lblNICError;
        private MetroFramework.Controls.MetroComboBox metroComboBox_membertype;
        private MetroFramework.Controls.MetroButton btn_sexit;
        private MetroFramework.Controls.MetroButton btn_sclear;
        private MetroFramework.Controls.MetroButton btn_msave;
        private MetroFramework.Controls.MetroTextBox txt_mid;
        private MetroFramework.Controls.MetroTextBox txt_memail;
        private MetroFramework.Controls.MetroTextBox txt_mtp;
        private MetroFramework.Controls.MetroTextBox txt_maddress;
        private MetroFramework.Controls.MetroTextBox txt_mname;
        private MetroFramework.Controls.MetroTextBox txt_mnic;
        private MetroFramework.Controls.MetroLabel mlbl_stafftype;
        private MetroFramework.Controls.MetroLabel mlbl_sid;
        private MetroFramework.Controls.MetroLabel mlbl_semail;
        private MetroFramework.Controls.MetroLabel mlbl_stp;
        private MetroFramework.Controls.MetroLabel mlbl_saddress;
        private MetroFramework.Controls.MetroLabel mlbl_sname;
        private MetroFramework.Controls.MetroLabel mlbl_snic;
    }
}