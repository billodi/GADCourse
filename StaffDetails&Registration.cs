using MetroFramework;
using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MetroLibrary
{
    public partial class StaffDetails_Registration : MetroFramework.Forms.MetroForm
    {
        char[] t = { 'S' };
        public StaffDetails_Registration()
        {
            InitializeComponent();
            lblAddressError.Visible = false;
            lblEmailError.Visible = false;
            lblNameError.Visible = false;
            lblNICError.Visible = false;
            lblPhoneNoError.Visible = false;
            lblIDError.Visible = false;
            lblStaffTypeError.Visible = false;
            lblcpwdError.Visible = false;
            
            try
            {
                SQLiteDataReader r = DBIO.Search("SELECT max(id) FROM staff");
                if (r.Read())
                    txt_sid.Text = (Convert.ToInt32(r.GetValue(0).ToString().Trim(t)) + 1).ToString();
            }
            catch (Exception)
            {
                txt_sid.Text = "1";
            }
            Console.WriteLine(txt_sid.Text);
            txt_sid.Text = String.Format("{0:'S'000}", Convert.ToInt32(txt_sid.Text));

        }

        private void StaffDetails_Registration_Load(object sender, EventArgs e)
        {
            using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff"))
            {
                while (read.Read())
                {
                    metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                }
            }
        }

        private void StaffDetails_Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void mlbl_sid_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox_stafftype_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroGrid1.Rows.Clear();
            using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff WHERE stafftype LIKE '%" + metroComboBox_stafftype.Text + "%'"))
            {
                while (read.Read())
                {
                    metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                }
            }
        }

        private void btn_ssave_Click(object sender, EventArgs e)
        {
            lblAddressError.Visible = false;
            lblEmailError.Visible = false;
            lblNameError.Visible = false;
            lblNICError.Visible = false;
            lblPhoneNoError.Visible = false;
            lblIDError.Visible = false;
            lblStaffTypeError.Visible = false;
            lblcpwdError.Visible = false;
            Boolean error = false;

            // Validate the staff type.

            if (metroComboBox_stafftype.SelectedIndex == -1)
            {
                lblStaffTypeError.Text = "Invalid staff type.";
                lblStaffTypeError.Visible = true;
                metroComboBox_stafftype.Focus();
                error = true;
            }

            // Validate the email address.

            if (!Regex.IsMatch(txt_semail.Text, @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+"))
            {
                lblEmailError.Text = "Invalid email address.";
                lblEmailError.Visible = true;
                txt_semail.Focus();
                error = true;
            }

            // Validate the ID

            if (DBIO.Search("SELECT id FROM staff WHERE id='" + txt_sid.Text + "'").Read())
            {
                lblIDError.Text = "There cannot be Duplicate ID.";
                lblIDError.Visible = true;
                txt_sid.Focus();
                error = true;
            }

            // Validate the phone number.

            if (txt_stp.Text.Length != 10)
            {
                lblPhoneNoError.Text = "Phone number must be 10 digits long.";
                lblPhoneNoError.Visible = true;
                txt_stp.Focus();
                error = true;
            }

            // Validate the address.

            if (txt_saddress.Text.Length < 10)
            {
                lblAddressError.Text = "Address must be at least 10 characters long.";
                lblAddressError.Visible = true;
                txt_saddress.Focus();
                error = true;
            }

            // Validate the name.

            if (txt_sname.Text.Length < 3)
            {
                lblNameError.Text = "Name must be at least 3 characters long.";
                lblNameError.Visible = true;
                txt_sname.Focus();
                error = true;
            }

            // Validate the NIC.

            if (!Regex.IsMatch(txt_snic.Text, "^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
            {
                lblNICError.Text = "Enter a Valid NIC.";
                lblNICError.Visible = true;
                txt_snic.Focus();
                error = true;
            }

            // Check if the passwords match.
            if (txt_pwd.Text != txt_cpwd.Text)
            {
                // Display an error message.
                lblcpwdError.Text = "Passwords do not match.";
                lblcpwdError.Visible = true;
                txt_cpwd.Focus();
                error = true;
            }

            // Check if the password meets the minimum requirements using regex.
            Regex regex = new Regex(@"^(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$");
            if (!regex.IsMatch(txt_pwd.Text))
            {
                // Display an error message.
                lblcpwdError.Text = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.";
                lblcpwdError.Visible = true;
                txt_pwd.Focus();
                error = true;
            }

            // All validation passed, so show a success message.
            if (!error)
            {
                DBIO.IUD("INSERT INTO staff('ID','nic','name','address','tp','email','stafftype','registered_date','password') VALUES('" + txt_sid.Text + "','" + txt_snic.Text + "','" + txt_sname.Text + "','" + txt_saddress.Text + "','" + txt_stp.Text + "','" + txt_semail.Text + "','" + metroComboBox_stafftype.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txt_pwd.Text + "')");
                SQLiteDataReader r = DBIO.Search("SELECT max(id) FROM staff");
                r.Read();
                txt_sid.Text = (Convert.ToInt32(r.GetValue(0).ToString().Trim(t)) + 1).ToString();
                txt_sid.Text = String.Format("{0:'S'000}", Convert.ToInt32(txt_sid.Text));
                metroGrid1.Rows.Clear();
                using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff"))
                {
                    while (read.Read())
                    {
                        metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                    }
                }
                
                txt_cpwd.Text = "";
                txt_pwd.Text = "";
                txt_saddress.Text = "";
                txt_semail.Text = "";
                txt_sname.Text = "";
                txt_snic.Text = "";
                txt_stp.Text = "";
                metroComboBox_stafftype.SelectedIndex = -1;
            }

        }

        private void txt_snic_KeyUp(object sender, KeyEventArgs e)
        {
            metroGrid1.Rows.Clear();
            using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff WHERE nic LIKE '%" + txt_snic.Text + "%'"))
            {
                while (read.Read())
                {
                    metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                }
            }
        }

        private void txt_sname_KeyUp(object sender, KeyEventArgs e)
        {
            metroGrid1.Rows.Clear();
            using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff WHERE name LIKE '%" + txt_sname.Text + "%'"))
            {
                while (read.Read())
                {
                    metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                }
            }
        }

        private void txt_saddress_KeyUp(object sender, KeyEventArgs e)
        {
            metroGrid1.Rows.Clear();
            using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff WHERE address LIKE '%" + txt_saddress.Text + "%'"))
            {
                while (read.Read())
                {
                    metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                }
            }
        }

        private void txt_sid_KeyUp(object sender, KeyEventArgs e)
        {
            metroGrid1.Rows.Clear();
            using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff WHERE id LIKE '%" + txt_sid.Text + "%'"))
            {
                while (read.Read())
                {
                    metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                }
            }
        }

        private void txt_stp_KeyUp(object sender, KeyEventArgs e)
        {
            metroGrid1.Rows.Clear();
            using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff WHERE tp LIKE '%" + txt_stp.Text + "%'"))
            {
                while (read.Read())
                {
                    metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                }
            }
        }

        private void txt_semail_KeyUp(object sender, KeyEventArgs e)
        {
            metroGrid1.Rows.Clear();
            using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff WHERE email LIKE '%" + txt_semail.Text + "%'"))
            {
                while (read.Read())
                {
                    metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                }
            }
        }

        private void btn_sclear_Click(object sender, EventArgs e)
        {
            Console.WriteLine(metroGrid1.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_sdelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MetroMessageBox.Show(this, "Are you sure you want to delete?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                DBIO.IUD("DELETE FROM staff WHERE ID='" + metroGrid1.CurrentRow.Cells[0].Value.ToString() + "'");
                metroGrid1.Rows.Clear();
                using (SQLiteDataReader read = DBIO.Search("SELECT id,nic,name,address,tp,email,stafftype,registered_date FROM staff"))
                {
                    while (read.Read())
                    {
                        metroGrid1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(6),
                        read.GetValue(7)
                    });
                    }
                }
            }
        }
    }
}
