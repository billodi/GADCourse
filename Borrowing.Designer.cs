namespace MetroLibrary
{
    partial class Borrowing
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
            this.mlbl_borrowid = new MetroFramework.Controls.MetroLabel();
            this.mlbl_bmnic = new MetroFramework.Controls.MetroLabel();
            this.mlbl_bbid = new MetroFramework.Controls.MetroLabel();
            this.mlbl_borrowdate = new MetroFramework.Controls.MetroLabel();
            this.mlbl_returndate = new MetroFramework.Controls.MetroLabel();
            this.mlbl_fine = new MetroFramework.Controls.MetroLabel();
            this.txt_borrowid = new MetroFramework.Controls.MetroTextBox();
            this.txt_memnic = new MetroFramework.Controls.MetroTextBox();
            this.txt_borrowbid = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.txt_bfine = new MetroFramework.Controls.MetroTextBox();
            this.btn_borrowsave = new MetroFramework.Controls.MetroButton();
            this.btn_borrowclear = new MetroFramework.Controls.MetroButton();
            this.btn_borrowexit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mlbl_borrowid
            // 
            this.mlbl_borrowid.AutoSize = true;
            this.mlbl_borrowid.Location = new System.Drawing.Point(30, 90);
            this.mlbl_borrowid.Name = "mlbl_borrowid";
            this.mlbl_borrowid.Size = new System.Drawing.Size(89, 20);
            this.mlbl_borrowid.TabIndex = 0;
            this.mlbl_borrowid.Text = "Borrowing ID";
            // 
            // mlbl_bmnic
            // 
            this.mlbl_bmnic.AutoSize = true;
            this.mlbl_bmnic.Location = new System.Drawing.Point(30, 143);
            this.mlbl_bmnic.Name = "mlbl_bmnic";
            this.mlbl_bmnic.Size = new System.Drawing.Size(89, 20);
            this.mlbl_bmnic.TabIndex = 1;
            this.mlbl_bmnic.Text = "Member NIC";
            // 
            // mlbl_bbid
            // 
            this.mlbl_bbid.AutoSize = true;
            this.mlbl_bbid.Location = new System.Drawing.Point(30, 192);
            this.mlbl_bbid.Name = "mlbl_bbid";
            this.mlbl_bbid.Size = new System.Drawing.Size(57, 20);
            this.mlbl_bbid.TabIndex = 2;
            this.mlbl_bbid.Text = "Book ID";
            // 
            // mlbl_borrowdate
            // 
            this.mlbl_borrowdate.AutoSize = true;
            this.mlbl_borrowdate.Location = new System.Drawing.Point(30, 243);
            this.mlbl_borrowdate.Name = "mlbl_borrowdate";
            this.mlbl_borrowdate.Size = new System.Drawing.Size(86, 20);
            this.mlbl_borrowdate.TabIndex = 3;
            this.mlbl_borrowdate.Text = "Borrow Date";
            // 
            // mlbl_returndate
            // 
            this.mlbl_returndate.AutoSize = true;
            this.mlbl_returndate.Location = new System.Drawing.Point(30, 297);
            this.mlbl_returndate.Name = "mlbl_returndate";
            this.mlbl_returndate.Size = new System.Drawing.Size(83, 20);
            this.mlbl_returndate.TabIndex = 4;
            this.mlbl_returndate.Text = "Return Date";
            // 
            // mlbl_fine
            // 
            this.mlbl_fine.AutoSize = true;
            this.mlbl_fine.Location = new System.Drawing.Point(30, 347);
            this.mlbl_fine.Name = "mlbl_fine";
            this.mlbl_fine.Size = new System.Drawing.Size(35, 20);
            this.mlbl_fine.TabIndex = 5;
            this.mlbl_fine.Text = "Fine";
            // 
            // txt_borrowid
            // 
            // 
            // 
            // 
            this.txt_borrowid.CustomButton.Image = null;
            this.txt_borrowid.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txt_borrowid.CustomButton.Name = "";
            this.txt_borrowid.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txt_borrowid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_borrowid.CustomButton.TabIndex = 1;
            this.txt_borrowid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_borrowid.CustomButton.UseSelectable = true;
            this.txt_borrowid.CustomButton.Visible = false;
            this.txt_borrowid.Lines = new string[0];
            this.txt_borrowid.Location = new System.Drawing.Point(235, 77);
            this.txt_borrowid.MaxLength = 32767;
            this.txt_borrowid.Name = "txt_borrowid";
            this.txt_borrowid.PasswordChar = '\0';
            this.txt_borrowid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_borrowid.SelectedText = "";
            this.txt_borrowid.SelectionLength = 0;
            this.txt_borrowid.SelectionStart = 0;
            this.txt_borrowid.ShortcutsEnabled = true;
            this.txt_borrowid.Size = new System.Drawing.Size(186, 33);
            this.txt_borrowid.TabIndex = 6;
            this.txt_borrowid.UseSelectable = true;
            this.txt_borrowid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_borrowid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_memnic
            // 
            // 
            // 
            // 
            this.txt_memnic.CustomButton.Image = null;
            this.txt_memnic.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txt_memnic.CustomButton.Name = "";
            this.txt_memnic.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_memnic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_memnic.CustomButton.TabIndex = 1;
            this.txt_memnic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_memnic.CustomButton.UseSelectable = true;
            this.txt_memnic.CustomButton.Visible = false;
            this.txt_memnic.Lines = new string[0];
            this.txt_memnic.Location = new System.Drawing.Point(235, 136);
            this.txt_memnic.MaxLength = 32767;
            this.txt_memnic.Name = "txt_memnic";
            this.txt_memnic.PasswordChar = '\0';
            this.txt_memnic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_memnic.SelectedText = "";
            this.txt_memnic.SelectionLength = 0;
            this.txt_memnic.SelectionStart = 0;
            this.txt_memnic.ShortcutsEnabled = true;
            this.txt_memnic.Size = new System.Drawing.Size(212, 27);
            this.txt_memnic.TabIndex = 7;
            this.txt_memnic.UseSelectable = true;
            this.txt_memnic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_memnic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_borrowbid
            // 
            // 
            // 
            // 
            this.txt_borrowbid.CustomButton.Image = null;
            this.txt_borrowbid.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.txt_borrowbid.CustomButton.Name = "";
            this.txt_borrowbid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_borrowbid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_borrowbid.CustomButton.TabIndex = 1;
            this.txt_borrowbid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_borrowbid.CustomButton.UseSelectable = true;
            this.txt_borrowbid.CustomButton.Visible = false;
            this.txt_borrowbid.Lines = new string[0];
            this.txt_borrowbid.Location = new System.Drawing.Point(235, 182);
            this.txt_borrowbid.MaxLength = 32767;
            this.txt_borrowbid.Name = "txt_borrowbid";
            this.txt_borrowbid.PasswordChar = '\0';
            this.txt_borrowbid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_borrowbid.SelectedText = "";
            this.txt_borrowbid.SelectionLength = 0;
            this.txt_borrowbid.SelectionStart = 0;
            this.txt_borrowbid.ShortcutsEnabled = true;
            this.txt_borrowbid.Size = new System.Drawing.Size(184, 30);
            this.txt_borrowbid.TabIndex = 8;
            this.txt_borrowbid.UseSelectable = true;
            this.txt_borrowbid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_borrowbid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(235, 233);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 30);
            this.metroDateTime1.TabIndex = 9;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(235, 287);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 30);
            this.metroDateTime2.TabIndex = 10;
            // 
            // txt_bfine
            // 
            // 
            // 
            // 
            this.txt_bfine.CustomButton.Image = null;
            this.txt_bfine.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txt_bfine.CustomButton.Name = "";
            this.txt_bfine.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txt_bfine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bfine.CustomButton.TabIndex = 1;
            this.txt_bfine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bfine.CustomButton.UseSelectable = true;
            this.txt_bfine.CustomButton.Visible = false;
            this.txt_bfine.Lines = new string[0];
            this.txt_bfine.Location = new System.Drawing.Point(235, 331);
            this.txt_bfine.MaxLength = 32767;
            this.txt_bfine.Name = "txt_bfine";
            this.txt_bfine.PasswordChar = '\0';
            this.txt_bfine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bfine.SelectedText = "";
            this.txt_bfine.SelectionLength = 0;
            this.txt_bfine.SelectionStart = 0;
            this.txt_bfine.ShortcutsEnabled = true;
            this.txt_bfine.Size = new System.Drawing.Size(208, 36);
            this.txt_bfine.TabIndex = 11;
            this.txt_bfine.UseSelectable = true;
            this.txt_bfine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bfine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_borrowsave
            // 
            this.btn_borrowsave.Location = new System.Drawing.Point(97, 396);
            this.btn_borrowsave.Name = "btn_borrowsave";
            this.btn_borrowsave.Size = new System.Drawing.Size(101, 46);
            this.btn_borrowsave.TabIndex = 12;
            this.btn_borrowsave.Text = "Save";
            this.btn_borrowsave.UseSelectable = true;
            // 
            // btn_borrowclear
            // 
            this.btn_borrowclear.Location = new System.Drawing.Point(326, 395);
            this.btn_borrowclear.Name = "btn_borrowclear";
            this.btn_borrowclear.Size = new System.Drawing.Size(121, 47);
            this.btn_borrowclear.TabIndex = 13;
            this.btn_borrowclear.Text = "Clear";
            this.btn_borrowclear.UseSelectable = true;
            // 
            // btn_borrowexit
            // 
            this.btn_borrowexit.Location = new System.Drawing.Point(572, 396);
            this.btn_borrowexit.Name = "btn_borrowexit";
            this.btn_borrowexit.Size = new System.Drawing.Size(130, 46);
            this.btn_borrowexit.TabIndex = 14;
            this.btn_borrowexit.Text = "Exit";
            this.btn_borrowexit.UseSelectable = true;
            // 
            // Borrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_borrowexit);
            this.Controls.Add(this.btn_borrowclear);
            this.Controls.Add(this.btn_borrowsave);
            this.Controls.Add(this.txt_bfine);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.txt_borrowbid);
            this.Controls.Add(this.txt_memnic);
            this.Controls.Add(this.txt_borrowid);
            this.Controls.Add(this.mlbl_fine);
            this.Controls.Add(this.mlbl_returndate);
            this.Controls.Add(this.mlbl_borrowdate);
            this.Controls.Add(this.mlbl_bbid);
            this.Controls.Add(this.mlbl_bmnic);
            this.Controls.Add(this.mlbl_borrowid);
            this.Name = "Borrowing";
            this.Text = "Borrowing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Borrowing_FormClosed);
            this.Load += new System.EventHandler(this.Borrowing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlbl_borrowid;
        private MetroFramework.Controls.MetroLabel mlbl_bmnic;
        private MetroFramework.Controls.MetroLabel mlbl_bbid;
        private MetroFramework.Controls.MetroLabel mlbl_borrowdate;
        private MetroFramework.Controls.MetroLabel mlbl_returndate;
        private MetroFramework.Controls.MetroLabel mlbl_fine;
        private MetroFramework.Controls.MetroTextBox txt_borrowid;
        private MetroFramework.Controls.MetroTextBox txt_memnic;
        private MetroFramework.Controls.MetroTextBox txt_borrowbid;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroTextBox txt_bfine;
        private MetroFramework.Controls.MetroButton btn_borrowsave;
        private MetroFramework.Controls.MetroButton btn_borrowclear;
        private MetroFramework.Controls.MetroButton btn_borrowexit;
    }
}