using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Models;
namespace DoAn
{
    public partial class Frm_QLSV : Form
    {
        DBConnect db = new DBConnect();
        public Frm_QLSV()
        {
            InitializeComponent();
        }

        private void Frm_QLSV_Load(object sender, EventArgs e)
        {
            cbb_GioiTinh.Items.Add("Nam");
            cbb_GioiTinh.Items.Add("Nu");
            loadData();
            this.WindowState = FormWindowState.Maximized;
        }

        void loadData()
        {
            string str = "select * from SinhVien";
            DataTable dt = db.getDataTable(str);
            SinhVien sv = new SinhVien();
            foreach (DataRow i in dt.Rows)
            {
                sv.MaSinhVien = i["MaSinhVien"].ToString();
                sv.HoTenSinhVien = i["HoTenSinhVien"].ToString();
                sv.NgaySinh = Convert.ToDateTime(i["NgaySinh"]);
                sv.GioiTinh = i["GioiTinh"].ToString();
                sv.LopNienChe = i["LopNienChe"].ToString();
            }
            dataGridView_SinhVien.DataSource = dt;
        }
    }
}
