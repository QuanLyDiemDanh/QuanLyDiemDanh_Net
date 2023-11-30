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
            int i;
            i = dataGridView_TKGV.CurrentRow.Index;
            txtMaGV.Text = dataGridView_TKGV.Rows[i].Cells[0].Value.ToString();
            txtPass.Text = dataGridView_TKGV.Rows[i].Cells[1].Value.ToString();
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtPass.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string str = "Delete from TaiKhoanGV where GiangVienID = '" + txtMaGV.Text + "'";
            int kt = db.getNonQuery(str);
            if (kt != 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            string str = "update TaiKhoanGV Set PassGV = '"+txtPass.Text+"' where GiangVienID = '"+txtMaGV.Text+"'";
            int a = db.getNonQuery(str);
            if (a != 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }
    }
}
