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
    public partial class frmMayKhach_Login : Form
    {
        public frmMayKhach_Login()
        {
            InitializeComponent();
        }

        private void btnMaykhach_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            txtMaykhach_Tk.Focus();
        }
       
        private void btnMaykhach_Dangnhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtMaykhach_Tk.Text;
            string matkhau = txtMaykhach_Mk.Text;

            TaiKhoanDAO.Instance.getTaikhoan = taikhoan;

            if (LoginKhach(taikhoan, matkhau))
            {
              
                if (TaiKhoanDAO.Instance.GetSodutk(taikhoan)==0)
                {
                    MessageBox.Show("Bạn đã hết thời gian, vui lòng nạp thêm tiền để sử dụng","Thông báo");
                }
                else
                {
                    frmMayKhach_Main frm = new frmMayKhach_Main();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                txtMaykhach_Tk.Focus();
                txtMaykhach_Mk.Text = "";
                txtMaykhach_Tk.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
            }

            bool LoginKhach(string taikhoann, string matkhauu)
            {
                return TaiKhoanDAO.Instance.LoginKhach(taikhoan, matkhau);
            }

        }

        private void frmMayKhach_Login_Load(object sender, EventArgs e)
        {
            txtMaykhach_Tk.Focus();
            txtMaykhach_Mk.Text = "";
            txtMaykhach_Tk.Text = "";
        }

        private void txtMaykhach_Tk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMaykhach_Mk.Focus();
                
            }
            else { }
        }

        private void txtMaykhach_Mk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string taikhoan = txtMaykhach_Tk.Text;
                string matkhau = txtMaykhach_Mk.Text;

                TaiKhoanDAO.Instance.getTaikhoan = taikhoan;

                if (LoginKhach(taikhoan, matkhau))
                {

                    if (TaiKhoanDAO.Instance.GetSodutk(taikhoan) == 0)
                    {
                        MessageBox.Show("Bạn đã hết thời gian, vui lòng nạp thêm tiền để sử dụng");
                    }
                    else
                    {
                        frmMayKhach_Main frm = new frmMayKhach_Main();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
                }

                bool LoginKhach(string taikhoann, string matkhauu)
                {
                    return TaiKhoanDAO.Instance.LoginKhach(taikhoan, matkhau);
                }
                txtMaykhach_Tk.Focus();
                txtMaykhach_Mk.Text = "";
                txtMaykhach_Tk.Text = "";
            }
            else { }
        }
    }
}
