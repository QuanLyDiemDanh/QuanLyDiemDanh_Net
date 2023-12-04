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
using System.Globalization;

namespace Doan
{
    public partial class FrmQuanLyLop : Form
    {
        string connectstring = @"Data Source=LAPTOP-GGGJGJI6\SQLBYDAU;Initial Catalog=QuanLyDiemDanh;Integrated Security=True";
        SqlConnection connection;
        DataTable dt = new DataTable();
        //string connectstring = @"Data Source=LAPTOP-GGGJGJI6\SQLBYDAU;Initial Catalog=QuanLyDiemDanh;Integrated Security=True";
        //SqlConnection connection;
        //DataTable dt = new DataTable();
        public FrmQuanLyLop()
        {
            InitializeComponent();
            // Khởi tạo đối tượng SqlConnection
            connection = new SqlConnection(connectstring);

           // Khởi tạo DataTable
           //dataTable = new DataTable();

            //// Khởi tạo BindingSource và liên kết nó với DataTable
            //bindingSource = new BindingSource();
            //bindingSource.DataSource = dataTable;

            //// Gán BindingSource cho DataGridView
            //dataGridView1.DataSource = bindingSource;

        }
        private void ketnoicsdl()
        {
            connection.Open();
            string sql = "SELECT * FROM Classes";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            dt.Clear(); // Xóa dữ liệu hiện tại trong biến dataTable (DataTable)
            da.Fill(dt); // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            connection.Close();
            dataGridView1.DataSource = dt; // Gán DataTable làm nguồn dữ liệu cho DataGridView
        }

        private void FrmQuanLyLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDiemDanhDataSet2.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter1.Fill(this.quanLyDiemDanhDataSet2.Classes);
            ketnoicsdl(); // Gọi phương thức ketnoicsdl() để hiển thị dữ liệu trong DataGridView
            this.classesTableAdapter.Fill(this.quanLyDiemDanhDataSet1.Classes);
            btn_them.Click += btn_them_Click;

        }

        private DataTable dataTable;
        //private BindingSource bindingSource;
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo một đối tượng SqlCommand để thực thi truy vấn INSERT
                SqlCommand command = new SqlCommand("INSERT INTO Classes (ClassID, NgayHoc, ThoiGianBatDau, ThoiGianKetThuc, CourseID) VALUES (@ClassID, @NgayHoc, @ThoiGianBatDau, @ThoiGianKetThuc, @CourseID)", connection);

                // Thay thế các tham số trong truy vấn bằng giá trị thực tế
                command.Parameters.AddWithValue("@ClassID", txt_malop.Text);
                command.Parameters.AddWithValue("@NgayHoc", txt_day.Text);
                command.Parameters.AddWithValue("@ThoiGianBatDau", txt_start.Text);
                command.Parameters.AddWithValue("@ThoiGianKetThuc", txt_end.Text);
                command.Parameters.AddWithValue("@CourseID", txt_idMH.Text);

                // Thực thi truy vấn INSERT
                command.ExecuteNonQuery();

                // Đóng kết nối
                connection.Close();

                // Thêm một dòng mới vào DataTable và gán giá trị từ TextBox
                DataRow newRow = dataTable.NewRow();
                newRow["ClassID"] = txt_malop.Text;
                newRow["NgayHoc"] = txt_day.Text;
                newRow["ThoiGianBatDau"] = txt_start.Text;
                newRow["ThoiGianKetThuc"] = txt_end.Text;
                newRow["CourseID"] = txt_idMH.Text;
                dataTable.Rows.Add(newRow);

                //// Cập nhật lại nguồn dữ liệu của DataGridView
                //bindingSource.ResetBindings(false);
                //dataGridView1.DataSource = bindingSource;
                dataGridView1.DataSource = dataTable;

                // Xóa nội dung trong TextBox
                txt_malop.Text = "";
                txt_day.Text = "";
                txt_start.Text = "";
                txt_end.Text = "";
                txt_idMH.Text = "";
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm dữ liệu.");
            }
            ////try
            ////{
            ////    // Mở kết nối
            ////    connection.Open();

            ////    // Tạo một đối tượng SqlCommand để thực thi truy vấn INSERT
            ////    SqlCommand command = new SqlCommand("INSERT INTO Classes (ClassID, NgayHoc , ThoiGianBatDau , ThoiGianKetThuc , CourseID) VALUES (@ClassID, @NgayHoc, @ThoiGianBatDau, @ThoiGianKetThuc, @CourseID)", connection);

            ////    // Thay thế các tham số trong truy vấn bằng giá trị thực tế
            ////    command.Parameters.AddWithValue("@ClassID", txt_malop.Text);
            ////    command.Parameters.AddWithValue("@NgayHoc", txt_day.Text);
            ////    command.Parameters.AddWithValue("@ThoiGianBatDau", txt_start.Text);
            ////    command.Parameters.AddWithValue("@ThoiGianKetThuc", txt_end.Text);
            ////    command.Parameters.AddWithValue("@CourseID", txt_idMH.Text);

            ////    // Thực thi truy vấn INSERT
            ////    command.ExecuteNonQuery();

            ////    // Đóng kết nối
            ////    connection.Close();

            ////    // Thêm một dòng mới vào DataTable và gán giá trị từ TextBox
            ////    DataRow newRow = dt.NewRow();
            ////    newRow["ClassID"] = txt_malop.Text;
            ////    newRow["NgayHoc"] = txt_day.Text;
            ////    newRow["ThoiGianBatDau"] = txt_start.Text;
            ////    newRow["ThoiGianKetThuc"] = txt_end.Text;
            ////    newRow["CourseID"] = txt_idMH.Text;
            ////    dt.Rows.Add(newRow);

            ////    // Cập nhật lại DataSource của DataGridView
            ////    dataGridView1.DataSource = dt;

            ////    // Xóa nội dung trong TextBox
            ////    txt_malop.Text = "";
            ////    txt_day.Text = "";
            ////    txt_start.Text = "";
            ////    txt_end.Text = "";
            ////    txt_idMH.Text = "";

            ////}
            ////catch
            ////{
            ////    MessageBox.Show("Đã thêm thành công . Vui lòng khởi chạy lại hoặc nhấn nút 'Reset để xem lại kết quả'");
            ////}
            ///

            //    // Kiểm tra định dạng ngày học
            //    if (!DateTime.TryParseExact(txt_day.Text.Trim(), "yy//MM//dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayHoc))
            //    {
            //        MessageBox.Show("Ngày học không đúng định dạng yy//MM//dd.");
            //        return;
            //    }

            //    // Kiểm tra định dạng giờ bắt đầu
            //    if (!TimeSpan.TryParseExact(txt_start.Text.Trim(), "hh':'mm':'ss", CultureInfo.InvariantCulture, out TimeSpan gioBatDau))
            //    {
            //        MessageBox.Show("Giờ bắt đầu không đúng định dạng hh:mm:ss.");
            //        return;
            //    }

            //    // Kiểm tra định dạng giờ kết thúc
            //    if (!TimeSpan.TryParseExact(txt_end.Text.Trim(), "hh':'mm':'ss", CultureInfo.InvariantCulture, out TimeSpan gioKetThuc))
            //    {
            //        MessageBox.Show("Giờ kết thúc không đúng định dạng hh:mm:ss.");
            //        return;
            //    }

            //    // Lấy giá trị từ các TextBox
            //    string maLop = txt_malop.Text.Trim();
            //    string idMH = txt_idMH.Text.Trim();

            //    // Thêm dữ liệu vào DataTable thông qua BindingSource
            //    bindingSource.Add(new object[] { maLop, ngayHoc, idMH, gioBatDau, gioKetThuc });



            //    // Xóa nội dung trong các TextBox sau khi thêm dữ liệu
            //    txt_malop.Text = "";
            //    txt_day.Text = "";
            //    txt_idMH.Text = "";
            //    txt_start.Text = "";
            //    txt_end.Text = "";

            //    // Cập nhật lại nguồn dữ liệu của DataGridView
            //    bindingSource.ResetBindings(false);
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
