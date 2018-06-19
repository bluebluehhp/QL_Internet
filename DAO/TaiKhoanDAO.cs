using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Internet.DAO
{
    public class TaiKhoanDAO
    {
        public string getTaikhoan;
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO() { }

        public bool checkedAdmin(string taikhoan)
        {
            string query =string.Format( "select Kieu_ND from Nhan_Vien where Ten_Dang_Nhap='{0}'",taikhoan);
            object kieund = DataProvider.Instance.ExecuteScalar(query);
            string matkhau = kieund.ToString().Trim();

            try
            {
                if (kieund.Equals(null) || kieund.ToString().Trim() != "Manager")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {

                return true;
            }


            //if (kieund.Equals(null)||kieund.ToString().Trim() !="Manager")
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}




            //object result = DataProvider.Instance.ExecuteScalar(query);

            //if (result.Equals(null))
            //{
            //    return temp = 0;
            //}
            //else
            //{
            //    temp = Convert.ToDouble(result);
            //    return temp;
            //}


        }

        public bool LoginNhanvien(string taikhoan, string matkhau)
        {
            string sql = "select * from Nhan_Vien where Nhan_Vien.Ten_Dang_Nhap='" + taikhoan + "' and Nhan_Vien.Mat_Khau='" + matkhau + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            return result.Rows.Count == 1;
        }
        public bool ThemmoiNhanVien(string hoten, string tendangnhap,string matkhau,string sodt)
        {
            string query = String.Format("insert into Nhan_Vien(HoTen,Ten_Dang_Nhap,Mat_Khau,SDT) values (N'{0}','{1}','{2}','{3}')",hoten,tendangnhap,matkhau,sodt);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaNhanVien(string tendangnhap)
        {
            string query = string.Format("delete Nhan_Vien where Ten_Dang_Nhap='{0}'",tendangnhap);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string LoadHoTenNhanVien()
        {
            string query = string.Format("select nv.HoTen from Nhan_Vien as nv where nv.Ten_Dang_Nhap='{0}'", getTaikhoan);
            return (string)DataProvider.Instance.ExecuteScalar(query);
        }
        public string LoadMaNhanVien()
        {
            string tk = TaiKhoanDAO.Instance.getTaikhoan;
            string query = string.Format("select nv.Ma_NV from Nhan_Vien as nv where nv.Ten_Dang_Nhap='{0}' ", getTaikhoan);
            return (string)DataProvider.Instance.ExecuteScalar(query);
        }
        public string LoadMatKhauNhanVien()
        {

            string query = "select nv.Mat_Khau from Nhan_Vien as nv where nv.Ten_Dang_Nhap='" + (string)TaiKhoanDAO.Instance.getTaikhoan + "'";
            string mk = (string)DataProvider.Instance.ExecuteScalar(query);
            string matkhau = mk.Trim();
            return matkhau;
        }

      


        public bool LoginKhach(string taikhoan, string matkhau)
        {
            string sql = "select * from Khach_Hang where Khach_Hang.Ten_Dang_Nhap='" + taikhoan + "' and Khach_Hang.Mat_Khau='" + matkhau + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            return result.Rows.Count == 1;
        }

        public string LoadMaKhachHang()
        {
            string tk = TaiKhoanDAO.Instance.getTaikhoan;
            string query = String.Format("select Khach_Hang.Ma_KH from Khach_Hang where Khach_Hang.Ten_Dang_Nhap='{0}' ", getTaikhoan);
            return (string)DataProvider.Instance.ExecuteScalar(query);
        }
        public string LoadMatKhauKhachHang()
        {

            string query = String.Format("select Khach_Hang.Mat_Khau from Khach_Hang where Khach_Hang.Ten_Dang_Nhap='{0}' ", (string)TaiKhoanDAO.Instance.getTaikhoan);
            string mk = (string)DataProvider.Instance.ExecuteScalar(query);
            string matkhau = mk.Trim();
            return matkhau;
        }
        public int GetSodutk(string tendangnhap)
        {
            int sodutk;
            string query = String.Format("select Khach_Hang.So_Du_TG from Khach_Hang where Ten_Dang_Nhap='{0}' ", tendangnhap);
            object sdtk = DataProvider.Instance.ExecuteScalar(query);
            if (sdtk.Equals(null))
            {
                return sodutk = 0;
            }
            else
            {
                sodutk = Convert.ToInt32(sdtk.ToString().Trim());
                return sodutk;
            }

        }

        public bool Themmoitaikhoan(string tendangnhap, string matkhau)
        {
            string query = String.Format("INSERT INTO Khach_Hang VALUES('{0}','{1}',0,N'Guest')", tendangnhap, matkhau);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Xoataikhoan(string tendangnhap)
        {
            string query = String.Format(" delete Khach_Hang where Ten_Dang_Nhap = '{0}'", tendangnhap);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool NapTien(int sogiay, string tendangnhap)
        {
            string query = String.Format("update Khach_Hang set So_Du_TG={0} where Ten_Dang_Nhap='{1}'", sogiay, tendangnhap);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Sua(string tendangnhap, string matkhau, int sodutk, string kieund)
        {
            string query = String.Format("update Khach_Hang set Ten_Dang_Nhap='{0}',Mat_Khau='{1}' ,So_Du_TG={2} ,Kieu_ND='{3}' where Ten_Dang_Nhap='{4}'", tendangnhap, matkhau, sodutk, kieund, tendangnhap);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        















    }

}
