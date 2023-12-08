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
using Doan.Models;
namespace Doan
{
    public partial class FrmQuanLyLop : Form
    {
        DBConnect db = new DBConnect();
        string connectstring = @"Data Source=DESKTOP-B3HHTL3\SQLEXPRESS;Initial Catalog=QuanLyDiemDanh;Integrated Security=True";
        SqlConnection connection;
        DataTable dt = new DataTable();
        public FrmQuanLyLop()
        {
            InitializeComponent();
        }

        private void FrmQuanLyLop_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            string str = "select * from Classes";
            DataTable dt = db.getDataTable(str);
            Classes clss = new Classes();
            foreach (DataRow i in dt.Rows)
            {
                clss.ClassID = int.Parse(i["ClassID"].ToString());
                clss.NgayHoc = Convert.ToDateTime(i["NgayHoc"]);
                clss.ThoiGianBatDau = TimeSpan.Parse(i["ThoiGianBatDau"].ToString());
                clss.ThoiGianKetThuc = TimeSpan.Parse(i["ThoiGianKetThuc"].ToString());
                clss.CourseID = int.Parse(i["CourseID"].ToString());
            }
            dataGridView_Class.DataSource = dt;
        }
        //private BindingSource bindingSource;
        private void btn_them_Click(object sender, EventArgs e)
        {
            string str = "insert into Classes Values('" + txt_malop.Text + "','" + txt_start.Text + "','" + txt_end.Text + "','" + txt_idMH.Text + "','" + date_NgayHoc.Text + "')";
            int a = db.getNonQuery(str);
            if (a != 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
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
            int i;
            i = dataGridView_Class.CurrentRow.Index;
            txt_malop.Text = dataGridView_Class.Rows[i].Cells[0].Value.ToString();
            date_NgayHoc.Text = dataGridView_Class.Rows[i].Cells[4].Value.ToString();
            txt_idMH.Text = dataGridView_Class.Rows[i].Cells[3].Value.ToString();
            txt_start.Text = dataGridView_Class.Rows[i].Cells[1].Value.ToString();
            txt_end.Text = dataGridView_Class.Rows[i].Cells[2].Value.ToString();
        }

        private void lb_QLL_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string str = "Delete from Classes Where ClassID ='" + txt_malop.Text + "'";
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string str = "update Classes Set ThoiGianBatDau ='" + txt_start.Text + "',ThoiGianKetThuc='" + txt_end.Text + "',CourseID=" + txt_idMH.Text + ", NgayHoc ='" + date_NgayHoc.Text + "' where ClassID =" + txt_malop.Text + "";
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
