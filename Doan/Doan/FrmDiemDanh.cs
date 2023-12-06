using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Models;
namespace Doan
{
    public partial class FrmDiemDanh : Form
    {
        string giangVienID;
        DBConnect db = new DBConnect();
        public FrmDiemDanh()
        {
            InitializeComponent();
        }
        public FrmDiemDanh(string giangVienID)
        {
            InitializeComponent();
            this.giangVienID = giangVienID;
        }
        void loadData()
        {
<<<<<<< Updated upstream
            //string query = 

            //// Thực hiện truy vấn
            //DataTable dt = db.getDataTable(query);
=======
<<<<<<< HEAD
            string strQuery = "SELECT Students.StudentID, Courses.CourseID, Classes.NgayHoc " +
             "FROM Attendance " +
             "JOIN Students ON Attendance.StudentID = Students.StudentID " +
             "JOIN Classes ON Attendance.ClassID = Classes.ClassID " +
             "JOIN Courses ON Classes.CourseID = Courses.CourseID";

            // Gọi hàm getDataTable từ DBConnect để lấy dữ liệu
            DataTable dt = db.getDataTable(strQuery);
=======
            //string query = 
>>>>>>> Stashed changes

            //// Thực hiện truy vấn
            //DataTable dt = db.getDataTable(query);
>>>>>>> 3596880c044ea9090811079f1c7e833757078ee1

            // Tạo một List để lưu thông tin điểm danh
            DiemDanh diemdanh = new DiemDanh();

            // Duyệt qua từng dòng dữ liệu trong DataTable và thêm vào List
            foreach (DataRow row in dt.Rows)
            {
                DiemDanh diemDanh = new DiemDanh();
                diemDanh.StudentID = row["StudentID"].ToString();
                diemDanh.CourseID = int.Parse(row["CourseID"].ToString());
                diemDanh.NgayHoc = Convert.ToDateTime(row["NgayHoc"]);
            }
            dataGridView_DiemDanh.DataSource = dt;
        }
        private void dataGridView_DiemDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDiemDanh_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
            loadData();
        }
        private void btn_xem_Click(object sender, EventArgs e)
        {


            // Hiển thị thông tin của các dòng chưa được đánh dấu check trong MessageBox
        }
=======
>>>>>>> Stashed changes
            // TODO: This line of code loads data into the 'quanLyDiemDanhSVDataSet4.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter1.Fill(this.quanLyDiemDanhSVDataSet4.Attendance);
            // TODO: This line of code loads data into the 'quanLyDiemDanhSVDataSet3.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.quanLyDiemDanhSVDataSet3.Attendance);
            // TODO: This line of code loads data into the 'quanLyDiemDanhSVDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.quanLyDiemDanhSVDataSet.Classes);

        }

<<<<<<< Updated upstream
=======
>>>>>>> 3596880c044ea9090811079f1c7e833757078ee1
>>>>>>> Stashed changes
    }
}
