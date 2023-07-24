using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroLibrary
{
    public partial class staffSignUp : MetroFramework.Forms.MetroForm
    {
        char[] t = { 'S' };
        public staffSignUp()
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
                lblcpwdError.Text = "Password must be at least 8 characters\nlong and contain at least one uppercase\nletter, one lowercase letter,\none digit, and one special character.";
                lblcpwdError.Visible = true;
                txt_pwd.Focus();
                error = true;
            }

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

            if (DBIO.Search("SELECT nic FROM staff WHERE nic='" + txt_snic.Text + "'").Read())
            {
                lblNICError.Text = "There cannot be Duplicate NIC.";
                lblNICError.Visible = true;
                txt_snic.Focus();
                error = true;
            }

            // All validation passed
            if (!error)
            {
                if (Program.whoami[2] == "Librarian" || Program.whoami[2] == "ADMIN")
                {
                    DBIO.IUD("INSERT INTO staff('ID','nic','name','address','tp','email','stafftype','registered_date','password') VALUES('" + txt_sid.Text + "','" + txt_snic.Text + "','" + txt_sname.Text + "','" + txt_saddress.Text + "','" + txt_stp.Text + "','" + txt_semail.Text + "','" + metroComboBox_stafftype.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txt_pwd.Text + "')");
                    SQLiteDataReader r = DBIO.Search("SELECT max(id) FROM staff");
                    r.Read();
                    txt_sid.Text = (Convert.ToInt32(r.GetValue(0).ToString().Trim(t)) + 1).ToString();
                    txt_sid.Text = String.Format("{0:'S'000}", Convert.ToInt32(txt_sid.Text));

                    MetroMessageBox.Show(this, "Staff member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_cpwd.Text = "";
                    txt_pwd.Text = "";
                    txt_saddress.Text = "";
                    txt_semail.Text = "";
                    txt_sname.Text = "";
                    txt_snic.Text = "";
                    txt_stp.Text = "";
                    metroComboBox_stafftype.SelectedIndex = -1;

                    Program.whoami[0] = Program.whoamitemp[0];
                    Program.whoami[1] = Program.whoamitemp[1];
                    Program.whoami[2] = Program.whoamitemp[2];
                }
                else
                {
                    new StaffAuth().ShowDialog();
                }
            }
        }

        private void btn_sclear_Click(object sender, EventArgs e)
        {
            txt_cpwd.Text = "";
            txt_pwd.Text = "";
            txt_saddress.Text = "";
            txt_semail.Text = "";
            txt_sname.Text = "";
            txt_snic.Text = "";
            txt_stp.Text = "";
            metroComboBox_stafftype.SelectedIndex = -1;
        }

        private void staffSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            new StaffLogin().Show();
        }
    }
}
