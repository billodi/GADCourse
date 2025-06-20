﻿namespace MetroLibrary
{
    partial class StaffAuth
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
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_username = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(103, 193);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(106, 23);
            this.btn_login.TabIndex = 27;
            this.btn_login.Text = "Login";
            this.btn_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(164, 142);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(123, 23);
            this.txt_password.TabIndex = 25;
            this.txt_password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_password.UseSelectable = true;
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_username
            // 
            // 
            // 
            // 
            this.txt_username.CustomButton.Image = null;
            this.txt_username.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txt_username.CustomButton.Name = "";
            this.txt_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_username.CustomButton.TabIndex = 1;
            this.txt_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_username.CustomButton.UseSelectable = true;
            this.txt_username.CustomButton.Visible = false;
            this.txt_username.Lines = new string[0];
            this.txt_username.Location = new System.Drawing.Point(164, 97);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(123, 23);
            this.txt_username.TabIndex = 23;
            this.txt_username.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_username.UseSelectable = true;
            this.txt_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "ID";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StaffAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 240);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.metroLabel1);
            this.Name = "StaffAuth";
            this.Text = "Authenticate";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StaffAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_username;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}