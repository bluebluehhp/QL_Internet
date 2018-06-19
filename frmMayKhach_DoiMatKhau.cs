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
    public partial class frmMayKhach_DoiMatKhau : Form
    {
        public frmMayKhach_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnMaykhach_Doimk_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaykhach_Doimk_Xacnhan_Click(object sender, EventArgs e)
        {
            if (txtMaykhach_Doimk_Matkhaucu.Text == TaiKhoanDAO.Instance.LoadMatKhauKhachHang() && txtMaykhach_Doimk_Matkhaumoi1.Text.Trim() == txtMaykhach_Doimk_Matkhaumoi2.Text.Trim())
            {
                string update =String.Format( "update Khach_Hang set Mat_Khau='{0}' where Ten_Dang_Nhap='{1}'",txtMaykhach_Doimk_Matkhaumoi1.Text.Trim(),TaiKhoanDAO.Instance.getTaikhoan);
                DataProvider.Instance.ExecuteQuery(update);
                MessageBox.Show("Cập nhật mật khẩu mới thành công", "Thông báo", MessageBoxButtons.OK);
                
                txtMaykhach_Doimk_Matkhaucu.Text = "";
                txtMaykhach_Doimk_Matkhaumoi1.Text = "";
                txtMaykhach_Doimk_Matkhaumoi2.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đúng mật khẩu cũ", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void frmMayKhach_DoiMatKhau_Load(object sender, EventArgs e)
        {
            lbMaykhach_Doimk_Tentaikhoan.Text ="Xin chào                        "+ TaiKhoanDAO.Instance.getTaikhoan;
        }
    }
}
