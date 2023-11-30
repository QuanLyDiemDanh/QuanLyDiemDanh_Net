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
    public partial class FrmQuanLyGiangVien : Form
    {
        DBConnect db = new DBConnect();
        public FrmQuanLyGiangVien()
        {
            InitializeComponent();
        }

        private void FrmQuanLyGiangVien_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            string str = "select * from GiangVien";
            DataTable dt = db.getDataTable(str);
            GiangVien std = new GiangVien();
            foreach (DataRow i in dt.Rows)
            {
                std.GiangVienID = i["GiangVienID"].ToString();
                std.HoTen = i["HoTen"].ToString();
                std.NgaySinh = Convert.ToDateTime(i["NgaySinh"]);
                std.GioiTinh = i["GioiTinh"].ToString();
            }
            dataGridViewGiangVien.DataSource = dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string str = "insert into GiangVien Values('" + txtGiangVienID.Text + "',N'" + txtHoTen.Text + "','" + date_NgaySinh.Text + "',N'" + cboGender.Text + "')";
            int a = db.getNonQuery(str);
            if (a != 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string str = "update GiangVien Set HoTen = N'" + txtHoTen.Text + "',NgaySinh ='" + date_NgaySinh.Text + "',GioiTinh=N'" + cboGender.Text + "' where StudentID =" + txtGiangVienID.Text + " ";
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string str = "Delete from GiangVien Where GiangVienID ='" + txtGiangVienID.Text + "'";
            int a = db.getNonQuery(str);
            if (a != 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtGiangVienID.Clear();
            txtHoTen.Clear();
            date_NgaySinh.Text = "1/1/1990";
            cboGender.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewGiangVien.DataSource = db.getDataTable("Select * from GiangVien where HoTen like N'%" + txtSearch.Text + "%'");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewGiangVien.DataSource = db.getDataTable("Select * from GiangVien where HoTen like N'%" + txtSearch.Text + "%'");
        }

        private void btn_HienThiALL_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridViewGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewGiangVien.CurrentRow.Index;
            txtGiangVienID.Text = dataGridViewGiangVien.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridViewGiangVien.Rows[i].Cells[1].Value.ToString();
            date_NgaySinh.Text = dataGridViewGiangVien.Rows[i].Cells[2].Value.ToString();
            cboGender.Text = dataGridViewGiangVien.Rows[i].Cells[3].Value.ToString();
        }

        private void txtGiangVienID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
