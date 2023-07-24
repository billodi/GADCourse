using MetroFramework;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace MetroLibrary
{
    public partial class StaffLogin : MetroFramework.Forms.MetroForm
    {
        public StaffLogin()
        {
            InitializeComponent();
            lbl_userWrong.Visible = false;
            lbl_pwdWrong.Visible = false;
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }

        private void StaffLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lbl_userWrong.Visible = false;
            lbl_pwdWrong.Visible = false;
            try
            {
                SQLiteDataReader r = DBIO.Search("SELECT ID,Password,name,stafftype FROM staff WHERE ID='" + txt_username.Text + "'");
                if (r.Read())
                {
                    if (r.GetString(1) == txt_password.Text)
                    {
                        Program.whoami[0] = r.GetString(0);
                        Program.whoami[1] = r.GetString(2);
                        Program.whoami[2] = r.GetString(3);
                        Program.whoamitemp[0] = Program.whoami[0];
                        Program.whoamitemp[1] = Program.whoami[1];
                        Program.whoamitemp[2] = Program.whoami[2];
                        Console.WriteLine(Program.whoami[0]);
                        new Form1().Show();
                        this.Dispose();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Type the Correct Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        txt_password.Focus();
                        txt_password.SelectAll();
                    }
                }
                else
                {
                    DialogResult dialogResult = MetroMessageBox.Show(this, "There's No Such ID\nDo You want to Sign Up?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Dispose();
                        new StaffDetails_Registration().Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        
                        txt_username.Focus();
                        txt_username.SelectAll();

                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_username_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SQLiteDataReader r = DBIO.Search("SELECT ID,Password FROM staff WHERE ID='" + txt_username.Text + "'");
                if (!r.Read())
                {
                    lbl_userWrong.Visible = true;
                }
                else
                {
                    if (r.GetString(1) == txt_password.Text)
                    {
                        lbl_pwdWrong.Visible = false;
                    }
                    else
                    {
                        lbl_pwdWrong.Text = "Incorrect Password";
                        lbl_pwdWrong.Visible = true;
                    }
                    lbl_userWrong.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SQLiteDataReader r = DBIO.Search("SELECT ID,Password FROM staff WHERE ID='" + txt_username.Text + "'");
                if (r.Read())
                {
                    lbl_userWrong.Visible = false;

                    if (r.GetString(1) == txt_password.Text)
                    {
                        lbl_pwdWrong.Visible = false;
                    }
                    else
                    {
                        lbl_pwdWrong.Text = "Incorrect Password";
                        lbl_pwdWrong.Visible = true;
                    }
                }
                else
                {
                    lbl_userWrong.Visible = true;
                    lbl_pwdWrong.Text = "Type the Correct ID";
                    lbl_pwdWrong.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new staffSignUp().Show();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

        }
    }
}
