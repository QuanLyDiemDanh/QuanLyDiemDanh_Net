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

namespace Doan
{
    public partial class FrmQuanLyMonHoc : Form
    {
        string connectstring = @"Data Source=LAPTOP-GGGJGJI6\SQLBYDAU;Initial Catalog=QuanLyDiemDanh;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public FrmQuanLyMonHoc()
        {
            InitializeComponent();

            // Khởi tạo đối tượng SqlConnection
            connection = new SqlConnection(connectstring);
        }

        private void ketnoicsdl()
        {
            connection.Open();
            string sql = "select * from Courses";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;
        }

        private void FrmQuanLyLopVaMonHoc_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Courses", connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo một đối tượng SqlCommand để thực thi truy vấn INSERT
                SqlCommand command = new SqlCommand("INSERT INTO Courses (CourseID, TenMonHoc , GiangVienID) VALUES (@CourseID, @TenMonHoc, @GiangVienID)", connection);

                // Thay thế các tham số trong truy vấn bằng giá trị thực tế
                command.Parameters.AddWithValue("@CourseID", txt_idMH.Text);
                command.Parameters.AddWithValue("@TenMonHoc", txt_tenMH.Text);
                command.Parameters.AddWithValue("@GiangVienID", txt_idGV.Text);

                // Thực thi truy vấn INSERT
                command.ExecuteNonQuery();

                // Đóng kết nối
                connection.Close();

                // Thêm một dòng mới vào DataTable và gán giá trị từ TextBox
                DataRow newRow = dt.NewRow();
                newRow["CourseID"] = txt_idMH.Text;
                newRow["TenMonHoc"] = txt_tenMH.Text;
                newRow["GiangVienID"] = txt_idGV.Text;
                dt.Rows.Add(newRow);

                // Cập nhật lại DataSource của DataGridView
                dataGridView1.DataSource = dt;

                // Xóa nội dung trong TextBox
                txt_idMH.Text = "";
                txt_tenMH.Text = "";
                txt_idGV.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;

//namespace Doan
//{
//    public partial class FrmQuanLyMonHoc : Form
//    {
//        string connectstring = @"Data Source=LAPTOP-GGGJGJI6\SQLBYDAU;Initial Catalog=QuanLyDiemDanh;Integrated Security=True";
//        SqlConnection connection;
//        SqlCommand command;
//        SqlDataAdapter adapter;
//        DataTable dt = new DataTable();

//        public FrmQuanLyMonHoc()
//        {
//            InitializeComponent();
//        }

//        private void FrmQuanLyLopVaMonHoc_Load(object sender, EventArgs e)
//        {
//            // TODO: This line of code loads data into the 'quanLyDiemDanhDataSet3.Courses' table. You can move, or remove it, as needed.
//            this.coursesTableAdapter3.Fill(this.quanLyDiemDanhDataSet3.Courses);
//            // TODO: This line of code loads data into the 'quanLyDiemDanhDataSet2.Courses' table. You can move, or remove it, as needed.
//            this.coursesTableAdapter2.Fill(this.quanLyDiemDanhDataSet2.Courses);
//            // TODO: This line of code loads data into the 'quanLyDiemDanhDataSet1.Courses' table. You can move, or remove it, as needed.
//            this.coursesTableAdapter1.Fill(this.quanLyDiemDanhDataSet1.Courses);
//            // TODO: This line of code loads data into the 'quanLyDiemDanhDataSet.Courses' table. You can move, or remove it, as needed.
//            this.coursesTableAdapter.Fill(this.quanLyDiemDanhDataSet.Courses);
//            // TODO: This line of code loads data into the 'quanLyDiemDanhDataSet.Classes' table. You can move, or remove it, as needed.
//            this.classesTableAdapter.Fill(this.quanLyDiemDanhDataSet.Classes);
//            connection = new SqlConnection(connectstring);
//        }

//        private void btn_load_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                connection.Open();
//                command = new SqlCommand("select * from Courses", connection);
//                adapter = new SqlDataAdapter(command);
//                adapter.Fill(dt);
//                dataGridView1.DataSource = dt;
//                connection.Close();
//            }
//            catch
//            {

//            }
//        }

//        private void btn_them_Click(object sender, EventArgs e)
//        {
//            string courseID = txt_idMH.Text;
//            string tenMonHoc = txt_tenMH.Text;
//            string giangVienID = txt_idGV.Text;

//            // Lấy đối tượng BindingSource từ nguồn dữ liệu của DataGridView
//            var bindingSource = (BindingSource)dataGridView1.DataSource;

//            // Lấy đối tượng DataSet từ nguồn dữ liệu gốc của BindingSource
//            Doan.QuanLyDiemDanhDataSet3 dataSet = (Doan.QuanLyDiemDanhDataSet3)bindingSource.DataSource;

//            // Tạo một hàng mới
//            DataRow newRow = dt.NewRow();

//            // Thêm hàng mới vào DataTable
//            dt.Rows.Add(newRow);

//            // Cập nhật lại nguồn dữ liệu của DataGridView
//            dataGridView1.DataSource = dt;
//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }
//    }
//}
