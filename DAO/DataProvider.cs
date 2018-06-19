using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QL_Internet.DAO
{
    class DataProvider
    {

        // code design singleton cho class Dataprovider
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }
        private DataProvider() { }
        private string connectionSTR = @"Data Source=LOUIS-PC\SQLEXPRESS;Initial Catalog=Quan_Ly_Internet;Integrated Security=True";


        //tính số thời gian cho 100VND
        public int TinhSoThoiGian100(int SoTien1Gio)
        {
           
            int soGiay100 = (360000 / SoTien1Gio);

            return soGiay100;
        }
        public int STSecondToHour(int time)
        {
            int hour = time/3600;

            //int conlai = time - hour * 60;

            return hour;
        }
        public int STMinute(int time)
        {
            int tempSecond = time - (STSecondToHour(time) * 3600);
            int minute = tempSecond/60;

            return minute;
        }

        public int TimeToMoney(int sogiay)
        {
            int sotien = 0 ;

            int SoTien1Gio = 5000;//set so tiền 1 giờ
            //=so giay hiện tại * 100 rồi chia so số giay khi 100đ
            sotien = (sogiay*100)/ TinhSoThoiGian100(SoTien1Gio);

            return sotien;
        }
        public int STSecond(int time)
        {
            int second =  time - (STSecondToHour(time) * 3600) - (STMinute(time) * 60);

            return second;
        }
        //Thực thi câu lệnh sql , có thế có tham số truyền vào
        public DataTable ExecuteQuery(string query, object[] paramater = null)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        command.Parameters.AddWithValue(item, paramater[i]);
                        i++;
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(datatable);
                connection.Close();
            }
            return datatable;
        }
        //đếm số dòng thực thi câu lệnh thành công
        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        command.Parameters.AddWithValue(item, paramater[i]);
                        i++;
                    }
                }

                try
                {
                    data = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    data = -1;
                }

                connection.Close();
            }
            return data;
        }
        //lấy dữ liệu dòng fđầu tiên
        public object ExecuteScalar(string query, object[] paramater = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        command.Parameters.AddWithValue(item, paramater[i]);
                        i++;
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }


}
