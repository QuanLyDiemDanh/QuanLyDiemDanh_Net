using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Doan.Models;

namespace Doan
{
    public partial class FrmQuanLySV : Form
    {
        DBConnect db = new DBConnect();
        public FrmQuanLySV()
        {
            InitializeComponent();
            LoadGenderOptions();
        }
        private void LoadGenderOptions()
        {
            // Thêm các mục cho ComboBox giới tính
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
        }
        private void QuanLyTTSV_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            string str = "select * from Students";
            DataTable dt = db.getDataTable(str);
            Students std = new Students();
            foreach (DataRow i in dt.Rows)
            {
                std.StudentID = i["StudentID"].ToString();
                std.HoTen = i["HoTen"].ToString();
                std.NgaySinh = Convert.ToDateTime(i["NgaySinh"]);
                std.GioiTinh = i["GioiTinh"].ToString();
                std.Lop = i["Lop"].ToString();
            }
            dataGridViewSinhVien.DataSource = dt;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedGender = cboGender.SelectedItem.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewSinhVien.CurrentRow.Index;
            txtMaSV.Text = dataGridViewSinhVien.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridViewSinhVien.Rows[i].Cells[1].Value.ToString();
            date_NgaySinh.Text = dataGridViewSinhVien.Rows[i].Cells[2].Value.ToString();
            cboGender.Text = dataGridViewSinhVien.Rows[i].Cells[3].Value.ToString();
            txtLop.Text = dataGridViewSinhVien.Rows[i].Cells[4].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string str = "insert into Students Values('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "','" + date_NgaySinh.Text + "',N'" + cboGender.Text + "','" + txtLop.Text + "')";
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

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            date_NgaySinh.Text = "1/1/1990";
            cboGender.Text = "";
            txtLop.Clear();
        }

        private void date_NgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string str = "Delete from Students Where StudentID ='" + txtMaSV.Text + "'";
            int a = db.getNonQuery(str);
            if(a!=0)
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string str = "update Students Set HoTen = N'"+txtHoTen.Text+"',NgaySinh ='" + date_NgaySinh.Text+ "',GioiTinh=N'"+cboGender.Text+ "',Lop='"+txtLop.Text+"' where StudentID ="+txtMaSV.Text+" ";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSinhVien.DataSource = db.getDataTable("Select * from Students where HoTen like N'%" + txtSearch.Text + "%'");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSinhVien.DataSource = db.getDataTable("Select * from Students where HoTen like N'%" + txtSearch.Text + "%'");
        }

        private void btn_HienThiALL_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
