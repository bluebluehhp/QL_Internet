using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Internet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMaychu_Click(object sender, EventArgs e)
        {
            frmMaychu_Login frm = new frmMaychu_Login();
            this.Hide();
            //txtMatkhau.Text = "";
            frm.ShowDialog();
            this.Show();
        }

        private void btnMaykhach_Click(object sender, EventArgs e)
        {
            frmMayKhach_Login frm = new frmMayKhach_Login();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

    }
}
