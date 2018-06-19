using QL_Internet.DAO;
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
    public partial class frmMaychu_Login : Form
    {
        public frmMaychu_Login()
        {
            InitializeComponent();
        }

        private void btnMaychu_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            txtMaychu_Mk.Text = "";
            txtMaychu_Tk.Text = "";
        }

        private void btnMaychu_Dangnhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtMaychu_Tk.Text;
            string matkhau = txtMaychu_Mk.Text;

            TaiKhoanDAO.Instance.getTaikhoan = taikhoan;

            if (LoginNhanVien(taikhoan, matkhau))
            {
                txtMaychu_Mk.Text = "";
                txtMaychu_Tk.Text = "";
                frmMayChu_Main frm = new frmMayChu_Main();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                
            }
            else
            {
                txtMaychu_Mk.Text = "";
                txtMaychu_Tk.Text = "";
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
            }
          
            bool LoginNhanVien(string taikhoann, string matkhauu)
            {
                return TaiKhoanDAO.Instance.LoginNhanvien(taikhoan, matkhau);
            }
            

        }

        private void frmMaychu_Login_Load(object sender, EventArgs e)
        {
            txtMaychu_Mk.Text = "";
            txtMaychu_Tk.Text = "";
            txtMaychu_Tk.Focus();
        }

        private void txtMaychu_Mk_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                string taikhoan = txtMaychu_Tk.Text;
                string matkhau = txtMaychu_Mk.Text;

                TaiKhoanDAO.Instance.getTaikhoan = taikhoan;

                if (LoginNhanVien(taikhoan, matkhau))
                {
                    frmMayChu_Main frm = new frmMayChu_Main();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
                }

                bool LoginNhanVien(string taikhoann, string matkhauu)
                {
                    return TaiKhoanDAO.Instance.LoginNhanvien(taikhoan, matkhau);
                }
                txtMaychu_Mk.Text = "";
                txtMaychu_Tk.Text = "";
                txtMaychu_Tk.Focus();
            }
            else
            {
            }
            
        }

        private void txtMaychu_Tk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                txtMaychu_Mk.Focus();
               
            }
            else { }

        }
    }
}
