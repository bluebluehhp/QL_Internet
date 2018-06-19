using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Internet.DAO
{
    public class BanggiaDAO
    {
        private static BanggiaDAO instance;
        public static BanggiaDAO Instance
        {
            get { if (instance == null) instance = new BanggiaDAO(); return instance; }
            private set { instance = value; }
        }
        private BanggiaDAO() { }

        public bool XoaThucdon(string tenthucdon)
        {
            string query = String.Format("delete Do_An where Ten_DA=N'{0}'", tenthucdon);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ThemMoiThucdon(string tenthucdon, int dongia)
        {
            string query = String.Format("insert into Do_An values(N'{0}',{1})", tenthucdon, dongia);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaThucdon(string tenthucdon, int dongia, int mathucdon)
        {
            string query = String.Format("update Do_An set Ten_DA=N'{0}', DonGia={1} where Ma_DA={2}", tenthucdon, dongia, mathucdon);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool LoadDanhSachThucDon()
        {
            string query = String.Format("select Do_An.Ten_DA from Do_An");
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void ThemBillChoTaiKhoanMoi(string tenmay)
        {
            string query = String.Format("insert into May(Ten_May) values ('{0}')", tenmay);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void XoaBillKhiXoaTaiKhoan(string tenmay)
        {
            string query = String.Format("delete May where Ten_May='{0}'", tenmay);
            DataProvider.Instance.ExecuteQuery(query);

        }
        public int GetMaDoAn(string tenthucdon)
        {
            string query = String.Format("select Do_An.Ma_DA from Do_An where Ten_DA=N'{0}'", tenthucdon);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
        public double GetDonGia(int mathucdon)
        {
            double temp;
            string query = String.Format("select Do_An.DonGia from Do_An where Do_An.Ma_DA={0}", mathucdon);
            object result = DataProvider.Instance.ExecuteScalar(query);

            if (result.Equals(null))
            {
                return temp = 0;
            }
            else
            {
                temp = Convert.ToDouble(result);
                return temp;
            }
        }

        public double ShowThanhTien(string tenmay)
        {
            double temp;
            string query = String.Format("select Sum(ThanhTien) from DonHang_DA where Ten_May='{0}'", tenmay);
            int i = (int)DataProvider.Instance.ExecuteNonQuery(query);
            object a = DataProvider.Instance.ExecuteScalar(query);

            try
            {
                temp = Convert.ToDouble(a);
                return temp;
            }
            catch (Exception)
            {

                return temp = 0.0;
            }


        }

    }

}

