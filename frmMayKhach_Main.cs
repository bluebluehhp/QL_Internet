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
    public partial class frmMayKhach_Main : Form
    {
        Timer timer1;
        public frmMayKhach_Main()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
        }



        public int i;
        public int TimeSD;
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSD++;
            i--;
            //lbMainKhach_TongSoGiayConLai.Text = i.ToString();
            lbMainKhach_TimeEnd.Text = "" + DataProvider.Instance.STSecondToHour(i).ToString() + " Giờ " + DataProvider.Instance.STMinute(i).ToString() + " Phút " + "" + DataProvider.Instance.STSecond(i).ToString() + " Giây";
            lbMainKhach_TimeSudung.Text = "" + DataProvider.Instance.STSecondToHour(TimeSD).ToString() + " Giờ " + DataProvider.Instance.STMinute(TimeSD).ToString() + " Phút " + "" + DataProvider.Instance.STSecond(TimeSD).ToString() + " Giây";
            lbMainKhach_TienGiochoi.Text = DataProvider.Instance.TimeToMoney(TimeSD).ToString() + " VND";

            if (i == 0)
            {
                this.Close();
                //luu lai time trong database ve 0
                TaiKhoanDAO.Instance.NapTien(i, TaiKhoanDAO.Instance.getTaikhoan);
            }
        }

        void ShowTongTien(string tenmay)
        {
            txtMayKhachMain_Tongtien.Text = BanggiaDAO.Instance.ShowThanhTien(TaiKhoanDAO.Instance.getTaikhoan).ToString();
        }
        private void frmMayKhach_Main_Load(object sender, EventArgs e)
        {
            lbMainKhach_Tentaikhoan.Text = TaiKhoanDAO.Instance.getTaikhoan;
            //lbMainKhach_TongSoGiayConLai.Text = TaiKhoanDAO.Instance.GetSodutk(TaiKhoanDAO.Instance.getTaikhoan).ToString();
            i = TaiKhoanDAO.Instance.GetSodutk(TaiKhoanDAO.Instance.getTaikhoan);
            timer1.Start();
            cbbMayKhachMain_Tendoan.DataSource = DataProvider.Instance.ExecuteQuery("select Do_An.Ten_DA from Do_An");
            cbbMayKhachMain_Tendoan.DisplayMember = "Ten_DA";
            HienThiBill(TaiKhoanDAO.Instance.getTaikhoan);
            ShowTongTien(TaiKhoanDAO.Instance.getTaikhoan);


        }



        private void btnMayKhach_Dangxuat_Click(object sender, EventArgs e)
        {
            //luu lai so time hien tai vao data base
            TaiKhoanDAO.Instance.NapTien(i, TaiKhoanDAO.Instance.getTaikhoan);
            this.Close();
            timer1.Stop();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMayKhach_DoiMatKhau f = new frmMayKhach_DoiMatKhau();
            f.ShowDialog();
        }

        void HienThiBill(string tenmay)
        {


            listView_MayKhach_Bill.Items.Clear();
            string query = String.Format("select Do_An.Ten_DA, Do_An.DonGia, DonHang_DA.SL, DonHang_DA.ThanhTien from DonHang_DA, Do_An where DonHang_DA.Ma_DA=Do_An.Ma_DA and DonHang_DA.Ten_May='{0}'", TaiKhoanDAO.Instance.getTaikhoan);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView_MayKhach_Bill.Items.Add(item);
            }

        }
        void ThemDoAnVaoBill(string tenmay, int maDoAn, int Soluong, double thanhtien)
        {
            string query = string.Format("insert into DonHang_DA values('{0}',{1},{2},{3})", tenmay, maDoAn, Soluong, thanhtien);
            DataProvider.Instance.ExecuteQuery(query);
        }

        void XoaDon(string tenmay)
        {
            string query = string.Format("delete DonHang_DA where Ten_May='{0}'", tenmay);
            DataProvider.Instance.ExecuteQuery(query);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //nhập thêm dồ ăn vào máy hiện tại
            if (String.IsNullOrEmpty(txtMayKhachMain_Soluong.Text) || String.IsNullOrWhiteSpace(txtMayKhachMain_Soluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng","Thông báo");

            }
            else
            {
                int soluong = 0;
                string tenmay = TaiKhoanDAO.Instance.getTaikhoan;
                int madoan = BanggiaDAO.Instance.GetMaDoAn(cbbMayKhachMain_Tendoan.Text.Trim());
                soluong = int.Parse(txtMayKhachMain_Soluong.Text);
                double dongia = BanggiaDAO.Instance.GetDonGia(madoan);
                double thanhtien = soluong * dongia;
                ThemDoAnVaoBill(tenmay, madoan, soluong, thanhtien);
                HienThiBill(TaiKhoanDAO.Instance.getTaikhoan);
                ShowTongTien(TaiKhoanDAO.Instance.getTaikhoan);
            }

        }

        private void btnMayKhachMain_Huy_Click(object sender, EventArgs e)
        {
            XoaDon(TaiKhoanDAO.Instance.getTaikhoan);
            HienThiBill(TaiKhoanDAO.Instance.getTaikhoan);
            ShowTongTien(TaiKhoanDAO.Instance.getTaikhoan);
            lbMainKhach_TienDichvu.Text = "0 VND";
        }

        private void btnMayKhachMain_DatHang_Click(object sender, EventArgs e)
        {
            listView_MayKhach_Bill.Items.Clear();
            lbMainKhach_TienDichvu.Text = txtMayKhachMain_Tongtien.Text;
            txtMayKhachMain_Tongtien.Text = "";
        }
    }
}
