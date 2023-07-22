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
    public partial class MemberDetails : MetroFramework.Forms.MetroForm
    {
        public MemberDetails()
        {
            InitializeComponent();
        }

        private void MemberDetails_Registration_Load(object sender, EventArgs e)
        {

        }

        private void MemberDetails_Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }
    }
}
