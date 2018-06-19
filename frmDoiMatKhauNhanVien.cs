using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Internet.DAO;
namespace QL_Internet
{
    public partial class frmDoiMatKhauNhanVien : Form
    {
        public frmDoiMatKhauNhanVien()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhauNhanVien_Load(object sender, EventArgs e)
        {
            label_DoiMatKhauNhanVien_HienthiTen.Text = "Xin chào nhân viên : " + TaiKhoanDAO.Instance.LoadHoTenNhanVien() +" \n\nTài khoản :                "+TaiKhoanDAO.Instance.getTaikhoan;
        }

        private void btnDoiMKAdmin_xacnhan_Click(object sender, EventArgs e)
        {
            if (txtDoiMKAdmin_matkhaucu.Text == TaiKhoanDAO.Instance.LoadMatKhauNhanVien() && txtDoiMKAdmin_matkhaumoi_1.Text.Trim()==txtDoiMKAdmin_matkhaumoi_2.Text.Trim())
            {
                string update= "update Nhan_Vien set Mat_Khau='"+ txtDoiMKAdmin_matkhaumoi_1.Text.ToString().Trim() +"' where Nhan_Vien.Ten_Dang_Nhap='"+TaiKhoanDAO.Instance.getTaikhoan+"'";
                DataProvider.Instance.ExecuteQuery(update);
                MessageBox.Show("Cập nhật mật khẩu mới thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đúng mật khẩu cũ", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDoiMKAdmin_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDoiMKAdmin_matkhaumoi_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDoiMKAdmin_matkhaumoi_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDoiMKAdmin_matkhaucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_DoiMatKhauNhanVien_HienthiTen_Click(object sender, EventArgs e)
        {

        }
    }

}
