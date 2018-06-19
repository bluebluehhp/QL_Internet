using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Internet.DAO
{
   public class ThoiGian
    {
        public string getTaikhoan;
        private static ThoiGian instance;
        public static ThoiGian Instance
        {
            get { if (instance == null) instance = new ThoiGian(); return instance; }
            private set { instance = value; }
        }
        private ThoiGian() { }






    }
}
