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
    public partial class MemberRegister : MetroFramework.Forms.MetroForm
    {
        public MemberRegister()
        {
            InitializeComponent();
        }

        private void MemberRegister_Load(object sender, EventArgs e)
        {

        }

        private void MemberRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().ShowDialog();
            Application.Exit();
        }

        private void mlbl_mtype_Click(object sender, EventArgs e)
        {

        }

        private void txt_mname_Click(object sender, EventArgs e)
        {

        }
    }
}
