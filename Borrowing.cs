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
    public partial class Borrowing : MetroFramework.Forms.MetroForm
    {
        public Borrowing()
        {
            InitializeComponent();
        }

        private void Borrowing_Load(object sender, EventArgs e)
        {

        }

        private void Borrowing_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void btn_borrowsave_Click(object sender, EventArgs e)
        {
            DBIO.IUD("INSERT INTO borrowinghistory values("+txt_borrowid.Text+","+txt_borrowbid.Text+","+txt_memnic.Text+",'"+ DateTime.Now.ToString("yyyy-MM-dd") + "','"+ DateTime.Now.ToString("yyyy-MM-dd") + "','Y')");
        }
    }
}
