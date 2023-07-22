using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroLibrary
{
    public partial class ForgetPassword : MetroFramework.Forms.MetroForm
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }
    }
}
