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
            btn_xoa.Click += btn_xoa_Click_1;
            btn_sua.Click += btn_sua_Click_1;
            btn_reset.Click += btn_reset_Click_1;

        }

        private void btn_them_Click_1(object sender, EventArgs e)
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
            catch
            {
                MessageBox.Show("Đã thêm thành công . Vui lòng khởi chạy lại hoặc nhấn nút 'Reset để xem lại kết quả'" );
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        
        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Lấy giá trị của cột khóa chính từ dòng được chọn
                    string courseID = dataGridView1.SelectedRows[0].Cells["CourseID"].Value.ToString();

                    // Mở kết nối
                    connection.Open();

                    // Tạo một đối tượng SqlCommand để thực thi truy vấn DELETE
                    SqlCommand command = new SqlCommand("DELETE FROM Courses WHERE CourseID = @CourseID", connection);
                    command.Parameters.AddWithValue("@CourseID", courseID);

                    // Thực thi truy vấn DELETE
                    command.ExecuteNonQuery();

                    // Đóng kết nối
                    connection.Close();

                    // Xóa dòng được chọn từ DataTable
                    DataRow rowToDelete = dt.Select("CourseID = '" + courseID + "'").FirstOrDefault();
                    if (rowToDelete != null)
                        dt.Rows.Remove(rowToDelete);

                    // Cập nhật lại DataSource của DataGridView
                    dataGridView1.DataSource = dt;

                    // Lưu trữ dữ liệu hiện tại vào biến tạm thời
                    tempData = (DataTable)dataGridView1.DataSource;
                }
                catch
                {
                    MessageBox.Show("Đã xóa thành công . Vui lòng khởi chạy lại hoặc nhấn nút 'Reset để xem lại kết quả' ");
                }
            }

        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Lấy giá trị của cột khóa chính từ dòng được chọn
                    string courseID = dataGridView1.SelectedRows[0].Cells["CourseID"].Value.ToString();

                    // Lấy dữ liệu từ các trường dữ liệu
                    string tenMonHoc = txt_tenMH.Text;
                    string giangVienID = txt_idGV.Text;

                    // Mở kết nối
                    connection.Open();

                    // Tạo một đối tượng SqlCommand để thực thi truy vấn UPDATE
                    SqlCommand command = new SqlCommand("UPDATE Courses SET TenMonHoc = @TenMonHoc, GiangVienID = @GiangVienID WHERE CourseID = @CourseID", connection);
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.Parameters.AddWithValue("@TenMonHoc", tenMonHoc);
                    command.Parameters.AddWithValue("@GiangVienID", giangVienID);

                    // Thực thi truy vấn UPDATE
                    command.ExecuteNonQuery();

                    // Đóng kết nối
                    connection.Close();

                    // Cập nhật lại dữ liệu trong DataTable
                    DataRow rowToUpdate = dt.Select("CourseID = '" + courseID + "'").FirstOrDefault();
                    if (rowToUpdate != null)
                    {
                        rowToUpdate["TenMonHoc"] = tenMonHoc;
                        rowToUpdate["GiangVienID"] = giangVienID;
                    }

                    // Cập nhật lại DataSource của DataGridView
                    dataGridView1.DataSource = dt;

                    // Xóa nội dung trong TextBox
                    txt_idMH.Text = "";
                    txt_tenMH.Text = "";
                    txt_idGV.Text = "";

                    // Lưu trữ dữ liệu hiện tại vào biến tạm thời
                    tempData = (DataTable)dataGridView1.DataSource;
                }
                catch
                {
                    MessageBox.Show("Đã sửa thành công . Vui lòng khởi chạy lại hoặc nhấn nút 'Reset để xem lại kết quả' ");
                }
            }
        }
        DataTable tempData;
        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            // Lưu trữ dữ liệu hiện tại vào biến tạm thời
            //tempData = (DataTable)dataGridView1.DataSource; 

            // Tạo một DataTable mới để lưu trữ cả dữ liệu cũ và dữ liệu mới
            DataTable newData = new DataTable();

            // Kiểm tra nếu có dữ liệu hiện tại trong DataGridView
            if (dataGridView1.DataSource != null)
            {
                // Lưu trữ dữ liệu hiện tại vào biến tạm thời
                tempData = dataGridView1.DataSource as DataTable;

                // Sao chép cấu trúc cột từ dữ liệu hiện tại vào DataTable mới
                newData = tempData.Clone();

                // Sao chép dữ liệu từ dữ liệu hiện tại vào DataTable mới
                foreach (DataRow row in tempData.Rows)
                {
                    newData.ImportRow(row);
                }
            }
            else
            {
                // Nếu không có dữ liệu hiện tại, đặt tempData thành null
                tempData = null;
            }

            // Xóa nội dung trong TextBox
            txt_idMH.Text = "";
            txt_tenMH.Text = "";
            txt_idGV.Text = "";

            // Đặt lại DataSource của DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;

            // Đặt DataGridView về tình trạng mới
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = true;

            // Khôi phục dữ liệu từ biến tạm thời vào DataGridView
            dataGridView1.DataSource = newData;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDiemDanhDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.quanLyDiemDanhDataSet.Courses);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

