using QL_Internet.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Internet
{
    public partial class frmMayChu_Main : Form
    {
        public frmMayChu_Main()
        {
            InitializeComponent();
        }

        void HienThiNhanVien()
        {
            listViewNhanvien.Items.Clear();
            DataTable data = DataProvider.Instance.ExecuteQuery("select Nhan_Vien.Ma_NV,Nhan_Vien.Ten_Dang_Nhap,Nhan_Vien.HoTen,Nhan_Vien.SDT from Nhan_Vien");

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listViewNhanvien.Items.Add(item);
            }

        }
        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thayĐổiTàiKhoảnAminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhauNhanVien f = new frmDoiMatKhauNhanVien();
            f.ShowDialog();

        }



        private void HienThiThongTinKhachHang()
        {
            listView_Thanhvien.Items.Clear();

            DataTable data = DataProvider.Instance.ExecuteQuery("select  kh.Ma_KH, kh.Ten_Dang_Nhap, kh.So_Du_TG,kh.Kieu_ND from Khach_Hang as kh ");

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    if (i == 2)
                    {
                        int temp = Convert.ToInt32(row[i].ToString().Trim());
                        item.SubItems.Add("" + DataProvider.Instance.STSecondToHour(temp).ToString() + " giờ " + DataProvider.Instance.STMinute(temp).ToString() + " phút " + "" + DataProvider.Instance.STSecond(temp).ToString() + " giây");
                    }
                    else
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                }
                listView_Thanhvien.Items.Add(item);

            }

        }
        private void bảngGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanggiaDichvu f = new BanggiaDichvu();
            f.ShowDialog();
        }

        private void frmMayChu_Main_Load(object sender, EventArgs e)
        {
            HienThiThongTinKhachHang();
            HienThiNhanVien();
            HienThiDonDatHang();
            if (TaiKhoanDAO.Instance.checkedAdmin(TaiKhoanDAO.Instance.getTaikhoan) == true)
            {
                panelAdmin.Show();
            }
            else
            {
                panelAdmin.Hide();
            }


        }

        void HienThiDonDatHang()
        {

            listView_Maychu_DonDathang.Items.Clear();
            string query = String.Format("select DonHang_DA.Ten_May,Do_An.Ten_DA, Do_An.DonGia, DonHang_DA.SL, DonHang_DA.ThanhTien from DonHang_DA, Do_An where DonHang_DA.Ma_DA=Do_An.Ma_DA");
            DataTable dataa = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataa.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dataa.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView_Maychu_DonDathang.Items.Add(item);
            }

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
        private void listView_Thanhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (listView_Thanhvien.SelectedItems.Count == 0) return;
            else
            {
                    ListViewItem item = listView_Thanhvien.SelectedItems[0];
                    txtMC_TenDangNhap.Text = item.SubItems[1].Text;
                    
            }
        }

        private void btnMC_Them_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMC_TenDangNhap.Text) || String.IsNullOrWhiteSpace(txtMC_TenDangNhap.Text) || String.IsNullOrEmpty(txtMC_Matkhau.Text) || String.IsNullOrWhiteSpace(txtMC_Matkhau.Text))
            {
                MessageBox.Show("Bạn cần nhập tài khoản và mật khẩu", "Thông báo");

            }
            else
            {
                string tendangnhap = txtMC_TenDangNhap.Text.Trim();
                string matkhau = txtMC_Matkhau.Text.Trim();
                if (TaiKhoanDAO.Instance.Themmoitaikhoan(tendangnhap, matkhau))
                {
                    BanggiaDAO.Instance.ThemBillChoTaiKhoanMoi(tendangnhap);
                    MessageBox.Show("Thêm mới tài khoản thành công");
                    HienThiThongTinKhachHang();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm tài khoản");
                }
                txtKieunguoidung.Text = "";
                txtMC_Matkhau.Text = "";
                txtMC_TenDangNhap.Text = "";
                txtSotiennap.Text = "";
            }



              
        }

        private void btnMC_Xoa_Click(object sender, EventArgs e)
        {

            string tendangnhap = txtMC_TenDangNhap.Text.Trim();
            if (TaiKhoanDAO.Instance.Xoataikhoan(tendangnhap))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                BanggiaDAO.Instance.XoaBillKhiXoaTaiKhoan(tendangnhap);
                HienThiThongTinKhachHang();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa tài khoản");
            }
            txtKieunguoidung.Text = "";
            txtMC_Matkhau.Text = "";
            txtMC_TenDangNhap.Text = "";
            txtSotiennap.Text = "";
        }

        private void btnMC_Naptien_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMC_TenDangNhap.Text) || String.IsNullOrWhiteSpace(txtMC_TenDangNhap.Text)|| String.IsNullOrEmpty(txtSotiennap.Text) || String.IsNullOrWhiteSpace(txtSotiennap.Text))
            {
                MessageBox.Show("Bạn cần nhập số tiền nạp và tên tài khoản", "Thông báo");

            }
            else
            {
                string tendangnhap = txtMC_TenDangNhap.Text.Trim();
                int sotien = (DataProvider.Instance.TinhSoThoiGian100(5000)) * (Convert.ToInt32(txtSotiennap.Text.Trim()) / 100);


                int temp = TaiKhoanDAO.Instance.GetSodutk(tendangnhap);
                int total = sotien + temp;
                if (TaiKhoanDAO.Instance.NapTien(total, tendangnhap))
                {
                    MessageBox.Show("Nạp tiền vào tài khoản thành công");
                    HienThiThongTinKhachHang();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi nạp tiền vào tài khoản");
                }
                txtKieunguoidung.Text = "";
                txtMC_Matkhau.Text = "";
                txtMC_TenDangNhap.Text = "";
                txtSotiennap.Text = "";
            }

            
        }

        private void btnMC_Sua_Click(object sender, EventArgs e)
        {
        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        void XoaDonDatHang()
        {
            string query = string.Format("delete DonHang_DA");
            DataProvider.Instance.ExecuteQuery(query);
        }
        private void btnGiaohang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã giao hàng xong cho khách","Thông báo");
            XoaDonDatHang();
            HienThiDonDatHang();
        }

        private void btnTabNhanVien_Them_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMCNhanVien_Hoten.Text) || String.IsNullOrWhiteSpace(txtMCNhanVien_Hoten.Text) ||
                String.IsNullOrEmpty(txtMCNhanVien_tendangnhap.Text) || String.IsNullOrWhiteSpace(txtMCNhanVien_tendangnhap.Text)
                || String.IsNullOrEmpty(txtMCNhanVien_matkhau.Text) || String.IsNullOrWhiteSpace(txtMCNhanVien_matkhau.Text) || 
                String.IsNullOrEmpty(txtMCNhanVien_sodt.Text) || String.IsNullOrWhiteSpace(txtMCNhanVien_sodt.Text))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo");

            }
            else
            {

                string hoten = txtMCNhanVien_Hoten.Text.Trim();
                string tendangnhap = txtMCNhanVien_tendangnhap.Text.Trim();
                string matkhau = txtMCNhanVien_matkhau.Text.Trim();
                string sodt = txtMCNhanVien_sodt.Text.Trim();

                if (TaiKhoanDAO.Instance.ThemmoiNhanVien(hoten, tendangnhap, matkhau, sodt))
                {
                    MessageBox.Show("Thêm mới nhân viên thành công", "Thông báo");
                    HienThiNhanVien();
                    txtMCNhanVien_Hoten.Text = "";
                    txtMCNhanVien_matkhau.Text= "";
                    txtMCNhanVien_sodt.Text = "";
                    txtMCNhanVien_tendangnhap.Text = "";
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm mới nhân viên", "Thông báo");
                }
            }

        }

        private void btnTabNhanvien_xoa_Click(object sender, EventArgs e)
        {
            
            string tendangnhap = txtMCNhanVien_tendangnhap.Text.Trim();

            if (TaiKhoanDAO.Instance.checkedAdmin(tendangnhap) == true||tendangnhap==TaiKhoanDAO.Instance.getTaikhoan)
            {
                MessageBox.Show("Bạn không đủ quyền xóa tài khoản này");
            }
            else
            {
                if (TaiKhoanDAO.Instance.XoaNhanVien(tendangnhap))
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                    HienThiNhanVien();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa nhân viên", "Thông báo");
                }
            }

        }

        private void listViewNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNhanvien.SelectedItems.Count == 0) return;
            else
            {
                ListViewItem item = listViewNhanvien.SelectedItems[0];
                txtMCNhanVien_tendangnhap.Text = item.SubItems[1].Text;
                txtMCNhanVien_Hoten.Text = item.SubItems[2].Text;
                txtMCNhanVien_sodt.Text = item.SubItems[3].Text;

            }
        }

        private void thànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanggiaDichvu f = new BanggiaDichvu();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
