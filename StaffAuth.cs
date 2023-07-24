using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroLibrary
{
    public partial class StaffAuth : MetroFramework.Forms.MetroForm
    {
        public StaffAuth()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
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
                        Console.WriteLine(Program.whoami[0]);
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

        private void StaffAuth_Load(object sender, EventArgs e)
        {

        }
    }
}
