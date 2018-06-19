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
    public partial class BanggiaDichvu : Form
    {
        public BanggiaDichvu()
        {
            InitializeComponent();
        }
        
        void HienThiThucDon()
        {
            listViewThucdon.Items.Clear();
            //DataTable data = DataProvider.Instance.ExecuteQuery("select Do_An.Ten_DA,Do_An.DonGia,Do_Uong.Ten_DU,Do_Uong.DonGia from Do_An, Do_Uong");
            DataTable data = DataProvider.Instance.ExecuteQuery("select Do_An.Ma_DA,Do_An.Ten_DA,Do_An.DonGia from Do_An");

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listViewThucdon.Items.Add(item);
            }

        }
        private void BanggiaDichvu_Load(object sender, EventArgs e)
        {
            HienThiThucDon();
        }
        public string maTemp;
        private void listViewThucdon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewThucdon.SelectedItems.Count == 0) return;
            else
            {

                ListViewItem item = listViewThucdon.SelectedItems[0];
                txtBangGia_Tendoan.Text = item.SubItems[1].Text;
                txtBangGia_Dongia.Text= item.SubItems[2].Text;
                maTemp = item.SubItems[0].Text;
            }
        }

        private void btnBangGia_Xoa_Click(object sender, EventArgs e)
        {
            string tenthucdon=txtBangGia_Tendoan.Text.Trim();
            if (BanggiaDAO.Instance.XoaThucdon(tenthucdon))
            {
                MessageBox.Show("Xóa thực đơn thành công");
                
                HienThiThucDon();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thực đơn");
                HienThiThucDon();
            }
            txtBangGia_Tendoan.Text = "";
            txtBangGia_Dongia.Text = "";
        }

        private void btnBangGia_Them_Click(object sender, EventArgs e)
        {
            string tenthucdon = txtBangGia_Tendoan.Text;
            int dongia =int.Parse(txtBangGia_Dongia.Text.Trim().ToString());
            if (BanggiaDAO.Instance.ThemMoiThucdon(tenthucdon,dongia))
            {
                MessageBox.Show("Thêm mới thực đơn thành công");
                HienThiThucDon();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm mới thực đơn");
                HienThiThucDon();
            }
            txtBangGia_Dongia.Text = "";
            txtBangGia_Tendoan.Text = "";
        }

        private void btnBangGia_Sua_Click(object sender, EventArgs e)
        {
            string tenthucdon = txtBangGia_Tendoan.Text;
            int dongia = int.Parse(txtBangGia_Dongia.Text.Trim().ToString());
            int mathucdonn = int.Parse(maTemp.ToString().Trim());
            if (BanggiaDAO.Instance.SuaThucdon(tenthucdon, dongia,mathucdonn))
            {
                MessageBox.Show("sửa thực đơn thành công");
                HienThiThucDon();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thực đơn");
                HienThiThucDon();
            }
            txtBangGia_Dongia.Text = "";
            txtBangGia_Tendoan.Text = "";
        }
    }
}
