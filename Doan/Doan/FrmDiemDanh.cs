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
            string strQuery = "SELECT Students.StudentID, Courses.CourseID, Classes.NgayHoc " +
             "FROM Attendance " +
             "JOIN Students ON Attendance.StudentID = Students.StudentID " +
             "JOIN Classes ON Attendance.ClassID = Classes.ClassID " +
             "JOIN Courses ON Classes.CourseID = Courses.CourseID";

            // Gọi hàm getDataTable từ DBConnect để lấy dữ liệu
            DataTable dt = db.getDataTable(strQuery);

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
            loadData();
        }
        private void btn_xem_Click(object sender, EventArgs e)
        {


            // Hiển thị thông tin của các dòng chưa được đánh dấu check trong MessageBox
        }
    }
}
