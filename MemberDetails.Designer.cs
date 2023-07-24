namespace MetroLibrary
{
    partial class MemberDetails
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
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.lblStaffTypeError = new MetroFramework.Controls.MetroLabel();
            this.lblEmailError = new MetroFramework.Controls.MetroLabel();
            this.btn_supdate = new MetroFramework.Controls.MetroButton();
            this.lblIDError = new MetroFramework.Controls.MetroLabel();
            this.btn_sdelete = new MetroFramework.Controls.MetroButton();
            this.lblPhoneNoError = new MetroFramework.Controls.MetroLabel();
            this.lblAddressError = new MetroFramework.Controls.MetroLabel();
            this.lblNameError = new MetroFramework.Controls.MetroLabel();
            this.lblNICError = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox_stafftype = new MetroFramework.Controls.MetroComboBox();
            this.btn_sclear = new MetroFramework.Controls.MetroButton();
            this.btn_ssave = new MetroFramework.Controls.MetroButton();
            this.txt_sid = new MetroFramework.Controls.MetroTextBox();
            this.txt_semail = new MetroFramework.Controls.MetroTextBox();
            this.txt_stp = new MetroFramework.Controls.MetroTextBox();
            this.txt_saddress = new MetroFramework.Controls.MetroTextBox();
            this.txt_sname = new MetroFramework.Controls.MetroTextBox();
            this.txt_snic = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_stafftype = new MetroFramework.Controls.MetroLabel();
            this.mlbl_sid = new MetroFramework.Controls.MetroLabel();
            this.mlbl_semail = new MetroFramework.Controls.MetroLabel();
            this.mlbl_stp = new MetroFramework.Controls.MetroLabel();
            this.mlbl_saddress = new MetroFramework.Controls.MetroLabel();
            this.mlbl_sname = new MetroFramework.Controls.MetroLabel();
            this.mlbl_snic = new MetroFramework.Controls.MetroLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registereddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
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
            this.membertype,
            this.registereddate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(405, 52);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(906, 415);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid1.TabIndex = 59;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // lblStaffTypeError
            // 
            this.lblStaffTypeError.AutoSize = true;
            this.lblStaffTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblStaffTypeError.Location = new System.Drawing.Point(166, 394);
            this.lblStaffTypeError.Name = "lblStaffTypeError";
            this.lblStaffTypeError.Size = new System.Drawing.Size(83, 19);
            this.lblStaffTypeError.TabIndex = 58;
            this.lblStaffTypeError.Text = "metroLabel7";
            this.lblStaffTypeError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStaffTypeError.UseCustomForeColor = true;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(166, 342);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(83, 19);
            this.lblEmailError.TabIndex = 57;
            this.lblEmailError.Text = "metroLabel6";
            this.lblEmailError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblEmailError.UseCustomForeColor = true;
            // 
            // btn_supdate
            // 
            this.btn_supdate.Location = new System.Drawing.Point(115, 422);
            this.btn_supdate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_supdate.Name = "btn_supdate";
            this.btn_supdate.Size = new System.Drawing.Size(95, 36);
            this.btn_supdate.TabIndex = 61;
            this.btn_supdate.Text = "Update";
            this.btn_supdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_supdate.UseSelectable = true;
            this.btn_supdate.Click += new System.EventHandler(this.btn_supdate_Click);
            // 
            // lblIDError
            // 
            this.lblIDError.AutoSize = true;
            this.lblIDError.ForeColor = System.Drawing.Color.Red;
            this.lblIDError.Location = new System.Drawing.Point(166, 238);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(83, 19);
            this.lblIDError.TabIndex = 60;
            this.lblIDError.Text = "metroLabel5";
            this.lblIDError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblIDError.UseCustomForeColor = true;
            // 
            // btn_sdelete
            // 
            this.btn_sdelete.Location = new System.Drawing.Point(210, 422);
            this.btn_sdelete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sdelete.Name = "btn_sdelete";
            this.btn_sdelete.Size = new System.Drawing.Size(95, 36);
            this.btn_sdelete.TabIndex = 67;
            this.btn_sdelete.Text = "Delete";
            this.btn_sdelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_sdelete.UseSelectable = true;
            this.btn_sdelete.Click += new System.EventHandler(this.btn_sdelete_Click);
            // 
            // lblPhoneNoError
            // 
            this.lblPhoneNoError.AutoSize = true;
            this.lblPhoneNoError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNoError.Location = new System.Drawing.Point(166, 290);
            this.lblPhoneNoError.Name = "lblPhoneNoError";
            this.lblPhoneNoError.Size = new System.Drawing.Size(83, 19);
            this.lblPhoneNoError.TabIndex = 56;
            this.lblPhoneNoError.Text = "metroLabel5";
            this.lblPhoneNoError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPhoneNoError.UseCustomForeColor = true;
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(166, 186);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(83, 19);
            this.lblAddressError.TabIndex = 55;
            this.lblAddressError.Text = "metroLabel3";
            this.lblAddressError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAddressError.UseCustomForeColor = true;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(166, 134);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(83, 19);
            this.lblNameError.TabIndex = 54;
            this.lblNameError.Text = "metroLabel2";
            this.lblNameError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNameError.UseCustomForeColor = true;
            // 
            // lblNICError
            // 
            this.lblNICError.AutoSize = true;
            this.lblNICError.ForeColor = System.Drawing.Color.Red;
            this.lblNICError.Location = new System.Drawing.Point(166, 82);
            this.lblNICError.Name = "lblNICError";
            this.lblNICError.Size = new System.Drawing.Size(81, 19);
            this.lblNICError.TabIndex = 53;
            this.lblNICError.Text = "metroLabel1";
            this.lblNICError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNICError.UseCustomForeColor = true;
            // 
            // metroComboBox_stafftype
            // 
            this.metroComboBox_stafftype.FormattingEnabled = true;
            this.metroComboBox_stafftype.ItemHeight = 23;
            this.metroComboBox_stafftype.Items.AddRange(new object[] {
            "Reguler",
            "Student"});
            this.metroComboBox_stafftype.Location = new System.Drawing.Point(165, 363);
            this.metroComboBox_stafftype.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox_stafftype.Name = "metroComboBox_stafftype";
            this.metroComboBox_stafftype.Size = new System.Drawing.Size(234, 29);
            this.metroComboBox_stafftype.TabIndex = 52;
            this.metroComboBox_stafftype.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox_stafftype.UseSelectable = true;
            this.metroComboBox_stafftype.SelectedIndexChanged += new System.EventHandler(this.metroComboBox_stafftype_SelectedIndexChanged);
            // 
            // btn_sclear
            // 
            this.btn_sclear.Location = new System.Drawing.Point(305, 422);
            this.btn_sclear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sclear.Name = "btn_sclear";
            this.btn_sclear.Size = new System.Drawing.Size(95, 36);
            this.btn_sclear.TabIndex = 51;
            this.btn_sclear.Text = "Clear";
            this.btn_sclear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_sclear.UseSelectable = true;
            this.btn_sclear.Click += new System.EventHandler(this.btn_sclear_Click);
            // 
            // btn_ssave
            // 
            this.btn_ssave.Location = new System.Drawing.Point(27, 422);
            this.btn_ssave.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ssave.Name = "btn_ssave";
            this.btn_ssave.Size = new System.Drawing.Size(88, 36);
            this.btn_ssave.TabIndex = 50;
            this.btn_ssave.Text = "Save";
            this.btn_ssave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_ssave.UseSelectable = true;
            this.btn_ssave.Click += new System.EventHandler(this.btn_ssave_Click);
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
            this.txt_sid.Location = new System.Drawing.Point(166, 210);
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
            this.txt_sid.TabIndex = 49;
            this.txt_sid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_sid.UseSelectable = true;
            this.txt_sid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sid_KeyUp);
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
            this.txt_semail.Location = new System.Drawing.Point(164, 312);
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
            this.txt_semail.TabIndex = 48;
            this.txt_semail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_semail.UseSelectable = true;
            this.txt_semail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_semail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_semail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_semail_KeyUp);
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
            this.txt_stp.Location = new System.Drawing.Point(164, 261);
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
            this.txt_stp.TabIndex = 47;
            this.txt_stp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_stp.UseSelectable = true;
            this.txt_stp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_stp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_stp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_stp_KeyUp);
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
            this.txt_saddress.Location = new System.Drawing.Point(165, 159);
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
            this.txt_saddress.TabIndex = 46;
            this.txt_saddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_saddress.UseSelectable = true;
            this.txt_saddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_saddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_saddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_saddress_KeyUp);
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
            this.txt_sname.Location = new System.Drawing.Point(165, 108);
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
            this.txt_sname.TabIndex = 45;
            this.txt_sname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_sname.UseSelectable = true;
            this.txt_sname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sname_KeyUp);
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
            this.txt_snic.Location = new System.Drawing.Point(165, 57);
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
            this.txt_snic.TabIndex = 44;
            this.txt_snic.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_snic.UseSelectable = true;
            this.txt_snic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_snic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_snic.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_snic_KeyUp);
            // 
            // mlbl_stafftype
            // 
            this.mlbl_stafftype.AutoSize = true;
            this.mlbl_stafftype.Location = new System.Drawing.Point(27, 375);
            this.mlbl_stafftype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_stafftype.Name = "mlbl_stafftype";
            this.mlbl_stafftype.Size = new System.Drawing.Size(91, 19);
            this.mlbl_stafftype.TabIndex = 43;
            this.mlbl_stafftype.Text = "Member Type";
            this.mlbl_stafftype.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_sid
            // 
            this.mlbl_sid.AutoSize = true;
            this.mlbl_sid.Location = new System.Drawing.Point(27, 215);
            this.mlbl_sid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_sid.Name = "mlbl_sid";
            this.mlbl_sid.Size = new System.Drawing.Size(21, 19);
            this.mlbl_sid.TabIndex = 42;
            this.mlbl_sid.Text = "ID";
            this.mlbl_sid.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_semail
            // 
            this.mlbl_semail.AutoSize = true;
            this.mlbl_semail.Location = new System.Drawing.Point(27, 321);
            this.mlbl_semail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_semail.Name = "mlbl_semail";
            this.mlbl_semail.Size = new System.Drawing.Size(47, 19);
            this.mlbl_semail.TabIndex = 41;
            this.mlbl_semail.Text = "E-mail";
            this.mlbl_semail.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_stp
            // 
            this.mlbl_stp.AutoSize = true;
            this.mlbl_stp.Location = new System.Drawing.Point(27, 268);
            this.mlbl_stp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_stp.Name = "mlbl_stp";
            this.mlbl_stp.Size = new System.Drawing.Size(99, 19);
            this.mlbl_stp.TabIndex = 40;
            this.mlbl_stp.Text = "Phone Number";
            this.mlbl_stp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_saddress
            // 
            this.mlbl_saddress.AutoSize = true;
            this.mlbl_saddress.Location = new System.Drawing.Point(27, 164);
            this.mlbl_saddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_saddress.Name = "mlbl_saddress";
            this.mlbl_saddress.Size = new System.Drawing.Size(56, 19);
            this.mlbl_saddress.TabIndex = 39;
            this.mlbl_saddress.Text = "Address";
            this.mlbl_saddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_sname
            // 
            this.mlbl_sname.AutoSize = true;
            this.mlbl_sname.Location = new System.Drawing.Point(27, 111);
            this.mlbl_sname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_sname.Name = "mlbl_sname";
            this.mlbl_sname.Size = new System.Drawing.Size(45, 19);
            this.mlbl_sname.TabIndex = 38;
            this.mlbl_sname.Text = "Name";
            this.mlbl_sname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_snic
            // 
            this.mlbl_snic.AutoSize = true;
            this.mlbl_snic.Location = new System.Drawing.Point(27, 62);
            this.mlbl_snic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_snic.Name = "mlbl_snic";
            this.mlbl_snic.Size = new System.Drawing.Size(31, 19);
            this.mlbl_snic.TabIndex = 37;
            this.mlbl_snic.Text = "NIC";
            this.mlbl_snic.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // membertype
            // 
            this.membertype.HeaderText = "Member Type";
            this.membertype.Name = "membertype";
            // 
            // registereddate
            // 
            this.registereddate.HeaderText = "Registered Date";
            this.registereddate.Name = "registereddate";
            // 
            // MemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 486);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lblStaffTypeError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.btn_supdate);
            this.Controls.Add(this.lblIDError);
            this.Controls.Add(this.btn_sdelete);
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
            this.Name = "MemberDetails";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Member Details";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberDetails_Registration_FormClosed);
            this.Load += new System.EventHandler(this.MemberDetails_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel lblStaffTypeError;
        private MetroFramework.Controls.MetroLabel lblEmailError;
        private MetroFramework.Controls.MetroButton btn_supdate;
        private MetroFramework.Controls.MetroLabel lblIDError;
        private MetroFramework.Controls.MetroButton btn_sdelete;
        private MetroFramework.Controls.MetroLabel lblPhoneNoError;
        private MetroFramework.Controls.MetroLabel lblAddressError;
        private MetroFramework.Controls.MetroLabel lblNameError;
        private MetroFramework.Controls.MetroLabel lblNICError;
        private MetroFramework.Controls.MetroComboBox metroComboBox_stafftype;
        private MetroFramework.Controls.MetroButton btn_sclear;
        private MetroFramework.Controls.MetroButton btn_ssave;
        private MetroFramework.Controls.MetroTextBox txt_sid;
        private MetroFramework.Controls.MetroTextBox txt_semail;
        private MetroFramework.Controls.MetroTextBox txt_stp;
        private MetroFramework.Controls.MetroTextBox txt_saddress;
        private MetroFramework.Controls.MetroTextBox txt_sname;
        private MetroFramework.Controls.MetroTextBox txt_snic;
        private MetroFramework.Controls.MetroLabel mlbl_stafftype;
        private MetroFramework.Controls.MetroLabel mlbl_sid;
        private MetroFramework.Controls.MetroLabel mlbl_semail;
        private MetroFramework.Controls.MetroLabel mlbl_stp;
        private MetroFramework.Controls.MetroLabel mlbl_saddress;
        private MetroFramework.Controls.MetroLabel mlbl_sname;
        private MetroFramework.Controls.MetroLabel mlbl_snic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn membertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn registereddate;
    }
}