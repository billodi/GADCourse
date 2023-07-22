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
    public partial class BookDetails : MetroFramework.Forms.MetroForm
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
           
        }

        private void BookDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void txt_author_Click(object sender, EventArgs e)
        {

        }
    }
}
