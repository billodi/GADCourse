namespace MetroLibrary
{
    partial class BookDetails
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
            this.mlbl_bid = new MetroFramework.Controls.MetroLabel();
            this.mlbl_title = new MetroFramework.Controls.MetroLabel();
            this.txt_title = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_author = new MetroFramework.Controls.MetroLabel();
            this.mlbl_pubyear = new MetroFramework.Controls.MetroLabel();
            this.mlbl_isbn = new MetroFramework.Controls.MetroLabel();
            this.mlbl_availablecount = new MetroFramework.Controls.MetroLabel();
            this.txt_author = new MetroFramework.Controls.MetroTextBox();
            this.txt_pubyear = new MetroFramework.Controls.MetroTextBox();
            this.txt_isbn = new MetroFramework.Controls.MetroTextBox();
            this.txt_availablecount = new MetroFramework.Controls.MetroTextBox();
            this.txt_bid = new MetroFramework.Controls.MetroTextBox();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mlbl_bid
            // 
            this.mlbl_bid.AutoSize = true;
            this.mlbl_bid.Location = new System.Drawing.Point(30, 78);
            this.mlbl_bid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_bid.Name = "mlbl_bid";
            this.mlbl_bid.Size = new System.Drawing.Size(55, 19);
            this.mlbl_bid.TabIndex = 0;
            this.mlbl_bid.Text = "Book ID";
            this.mlbl_bid.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_title
            // 
            this.mlbl_title.AutoSize = true;
            this.mlbl_title.Location = new System.Drawing.Point(30, 120);
            this.mlbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_title.Name = "mlbl_title";
            this.mlbl_title.Size = new System.Drawing.Size(33, 19);
            this.mlbl_title.TabIndex = 1;
            this.mlbl_title.Text = "Title";
            this.mlbl_title.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_title
            // 
            // 
            // 
            // 
            this.txt_title.CustomButton.Image = null;
            this.txt_title.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txt_title.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_title.CustomButton.Name = "";
            this.txt_title.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txt_title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_title.CustomButton.TabIndex = 1;
            this.txt_title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_title.CustomButton.UseSelectable = true;
            this.txt_title.CustomButton.Visible = false;
            this.txt_title.Lines = new string[0];
            this.txt_title.Location = new System.Drawing.Point(218, 113);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_title.MaxLength = 32767;
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_title.SelectedText = "";
            this.txt_title.SelectionLength = 0;
            this.txt_title.SelectionStart = 0;
            this.txt_title.ShortcutsEnabled = true;
            this.txt_title.Size = new System.Drawing.Size(253, 23);
            this.txt_title.TabIndex = 3;
            this.txt_title.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_title.UseSelectable = true;
            this.txt_title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_author
            // 
            this.mlbl_author.AutoSize = true;
            this.mlbl_author.Location = new System.Drawing.Point(30, 163);
            this.mlbl_author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_author.Name = "mlbl_author";
            this.mlbl_author.Size = new System.Drawing.Size(49, 19);
            this.mlbl_author.TabIndex = 4;
            this.mlbl_author.Text = "Author";
            this.mlbl_author.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_pubyear
            // 
            this.mlbl_pubyear.AutoSize = true;
            this.mlbl_pubyear.Location = new System.Drawing.Point(30, 204);
            this.mlbl_pubyear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_pubyear.Name = "mlbl_pubyear";
            this.mlbl_pubyear.Size = new System.Drawing.Size(102, 19);
            this.mlbl_pubyear.TabIndex = 5;
            this.mlbl_pubyear.Text = "Publication year";
            this.mlbl_pubyear.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_isbn
            // 
            this.mlbl_isbn.AutoSize = true;
            this.mlbl_isbn.Location = new System.Drawing.Point(30, 248);
            this.mlbl_isbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_isbn.Name = "mlbl_isbn";
            this.mlbl_isbn.Size = new System.Drawing.Size(37, 19);
            this.mlbl_isbn.TabIndex = 6;
            this.mlbl_isbn.Text = "ISBN";
            this.mlbl_isbn.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlbl_availablecount
            // 
            this.mlbl_availablecount.AutoSize = true;
            this.mlbl_availablecount.Location = new System.Drawing.Point(30, 292);
            this.mlbl_availablecount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlbl_availablecount.Name = "mlbl_availablecount";
            this.mlbl_availablecount.Size = new System.Drawing.Size(101, 19);
            this.mlbl_availablecount.TabIndex = 7;
            this.mlbl_availablecount.Text = "Available Count";
            this.mlbl_availablecount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_author
            // 
            // 
            // 
            // 
            this.txt_author.CustomButton.Image = null;
            this.txt_author.CustomButton.Location = new System.Drawing.Point(177, 2);
            this.txt_author.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_author.CustomButton.Name = "";
            this.txt_author.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txt_author.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_author.CustomButton.TabIndex = 1;
            this.txt_author.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_author.CustomButton.UseSelectable = true;
            this.txt_author.CustomButton.Visible = false;
            this.txt_author.Lines = new string[0];
            this.txt_author.Location = new System.Drawing.Point(218, 160);
            this.txt_author.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_author.MaxLength = 32767;
            this.txt_author.Name = "txt_author";
            this.txt_author.PasswordChar = '\0';
            this.txt_author.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_author.SelectedText = "";
            this.txt_author.SelectionLength = 0;
            this.txt_author.SelectionStart = 0;
            this.txt_author.ShortcutsEnabled = true;
            this.txt_author.Size = new System.Drawing.Size(254, 20);
            this.txt_author.TabIndex = 8;
            this.txt_author.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_author.UseSelectable = true;
            this.txt_author.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_author.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pubyear
            // 
            // 
            // 
            // 
            this.txt_pubyear.CustomButton.Image = null;
            this.txt_pubyear.CustomButton.Location = new System.Drawing.Point(77, 2);
            this.txt_pubyear.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pubyear.CustomButton.Name = "";
            this.txt_pubyear.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txt_pubyear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pubyear.CustomButton.TabIndex = 1;
            this.txt_pubyear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pubyear.CustomButton.UseSelectable = true;
            this.txt_pubyear.CustomButton.Visible = false;
            this.txt_pubyear.Lines = new string[0];
            this.txt_pubyear.Location = new System.Drawing.Point(218, 198);
            this.txt_pubyear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pubyear.MaxLength = 32767;
            this.txt_pubyear.Name = "txt_pubyear";
            this.txt_pubyear.PasswordChar = '\0';
            this.txt_pubyear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pubyear.SelectedText = "";
            this.txt_pubyear.SelectionLength = 0;
            this.txt_pubyear.SelectionStart = 0;
            this.txt_pubyear.ShortcutsEnabled = true;
            this.txt_pubyear.Size = new System.Drawing.Size(123, 22);
            this.txt_pubyear.TabIndex = 9;
            this.txt_pubyear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_pubyear.UseSelectable = true;
            this.txt_pubyear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pubyear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_isbn
            // 
            // 
            // 
            // 
            this.txt_isbn.CustomButton.Image = null;
            this.txt_isbn.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txt_isbn.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_isbn.CustomButton.Name = "";
            this.txt_isbn.CustomButton.Size = new System.Drawing.Size(19, 20);
            this.txt_isbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_isbn.CustomButton.TabIndex = 1;
            this.txt_isbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_isbn.CustomButton.UseSelectable = true;
            this.txt_isbn.CustomButton.Visible = false;
            this.txt_isbn.Lines = new string[0];
            this.txt_isbn.Location = new System.Drawing.Point(218, 237);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_isbn.MaxLength = 32767;
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.PasswordChar = '\0';
            this.txt_isbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_isbn.SelectedText = "";
            this.txt_isbn.SelectionLength = 0;
            this.txt_isbn.SelectionStart = 0;
            this.txt_isbn.ShortcutsEnabled = true;
            this.txt_isbn.Size = new System.Drawing.Size(132, 27);
            this.txt_isbn.TabIndex = 10;
            this.txt_isbn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_isbn.UseSelectable = true;
            this.txt_isbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_isbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_availablecount
            // 
            // 
            // 
            // 
            this.txt_availablecount.CustomButton.Image = null;
            this.txt_availablecount.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.txt_availablecount.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_availablecount.CustomButton.Name = "";
            this.txt_availablecount.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.txt_availablecount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_availablecount.CustomButton.TabIndex = 1;
            this.txt_availablecount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_availablecount.CustomButton.UseSelectable = true;
            this.txt_availablecount.CustomButton.Visible = false;
            this.txt_availablecount.Lines = new string[0];
            this.txt_availablecount.Location = new System.Drawing.Point(218, 283);
            this.txt_availablecount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_availablecount.MaxLength = 32767;
            this.txt_availablecount.Name = "txt_availablecount";
            this.txt_availablecount.PasswordChar = '\0';
            this.txt_availablecount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_availablecount.SelectedText = "";
            this.txt_availablecount.SelectionLength = 0;
            this.txt_availablecount.SelectionStart = 0;
            this.txt_availablecount.ShortcutsEnabled = true;
            this.txt_availablecount.Size = new System.Drawing.Size(90, 25);
            this.txt_availablecount.TabIndex = 11;
            this.txt_availablecount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_availablecount.UseSelectable = true;
            this.txt_availablecount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_availablecount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_bid
            // 
            // 
            // 
            // 
            this.txt_bid.CustomButton.Image = null;
            this.txt_bid.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.txt_bid.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bid.CustomButton.Name = "";
            this.txt_bid.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.txt_bid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bid.CustomButton.TabIndex = 1;
            this.txt_bid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bid.CustomButton.UseSelectable = true;
            this.txt_bid.CustomButton.Visible = false;
            this.txt_bid.Lines = new string[0];
            this.txt_bid.Location = new System.Drawing.Point(218, 69);
            this.txt_bid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bid.MaxLength = 32767;
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.PasswordChar = '\0';
            this.txt_bid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bid.SelectedText = "";
            this.txt_bid.SelectionLength = 0;
            this.txt_bid.SelectionStart = 0;
            this.txt_bid.ShortcutsEnabled = true;
            this.txt_bid.Size = new System.Drawing.Size(91, 25);
            this.txt_bid.TabIndex = 12;
            this.txt_bid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_bid.UseSelectable = true;
            this.txt_bid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(71, 323);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 31);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_save.UseSelectable = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(255, 324);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 30);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_clear.UseSelectable = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(430, 323);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 31);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_exit.UseSelectable = true;
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_bid);
            this.Controls.Add(this.txt_availablecount);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txt_pubyear);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.mlbl_availablecount);
            this.Controls.Add(this.mlbl_isbn);
            this.Controls.Add(this.mlbl_pubyear);
            this.Controls.Add(this.mlbl_author);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.mlbl_title);
            this.Controls.Add(this.mlbl_bid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookDetails";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Book Details";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookDetails_FormClosed);
            this.Load += new System.EventHandler(this.BookDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlbl_bid;
        private MetroFramework.Controls.MetroLabel mlbl_title;
        private MetroFramework.Controls.MetroTextBox txt_title;
        private MetroFramework.Controls.MetroLabel mlbl_author;
        private MetroFramework.Controls.MetroLabel mlbl_pubyear;
        private MetroFramework.Controls.MetroLabel mlbl_isbn;
        private MetroFramework.Controls.MetroLabel mlbl_availablecount;
        private MetroFramework.Controls.MetroTextBox txt_author;
        private MetroFramework.Controls.MetroTextBox txt_pubyear;
        private MetroFramework.Controls.MetroTextBox txt_isbn;
        private MetroFramework.Controls.MetroTextBox txt_availablecount;
        private MetroFramework.Controls.MetroTextBox txt_bid;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_exit;
    }
}