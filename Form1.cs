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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            metroLabel1.Text = Program.whoami[0] + " " + Program.whoami[1];
            Console.WriteLine(Program.whoami[0] + " " + Program.whoami[1]);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Hide();
            MemberDetails obj = new MemberDetails();
            obj.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Hide();
            BookDetails obj = new BookDetails();
            obj.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Hide();
            StaffLogin obj = new StaffLogin();
            obj.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Hide();
            StaffDetails_Registration obj = new StaffDetails_Registration();
            obj.ShowDialog();
        }

        
        private void metroTile6_Click(object sender, EventArgs e)
        {
            Hide();
            MemberRegister obj = new MemberRegister();
            obj.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Hide();
            ForgetPassword obj = new ForgetPassword();
            obj.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile5_Click_1(object sender, EventArgs e)
        {
            Hide();
            Borrowing obj = new Borrowing();
            obj.ShowDialog();
        }

        private void metroTile7_Click_1(object sender, EventArgs e)
        {
            Hide();
            HandOver obj = new HandOver();
            obj.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            new StaffLogin().Show();
        }
    }
}
