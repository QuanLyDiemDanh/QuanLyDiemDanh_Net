using Doan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    public partial class FrmQuanLyTaiKhoanGV : Form
    {
        DBConnect db = new DBConnect();
        public FrmQuanLyTaiKhoanGV()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmQuanLyTaiKhoanGV_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            string str = "Select * from TaiKhoanGV";
            DataTable dt = db.getDataTable(str);
            TaiKhoanGV tkGV = new TaiKhoanGV();
            foreach (DataRow i in dt.Rows)
            {
                tkGV.GiangVienID = i["GiangVienID"].ToString();
                tkGV.PassGV = i["PassGV"].ToString();
            }
            dataGridView_TKGV.DataSource = dt;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
