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
    public partial class FrmDiemDanh : Form
    {
        DBConnect db = new DBConnect();
        public FrmDiemDanh()
        {
            InitializeComponent();
            btn_xem.Click += btn_xem_Click;
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
            dataGridView1.DataSource = dt;
        }
        private void FrmDiemDanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDiemDanhDataSet4.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.quanLyDiemDanhDataSet4.Students);
            loadData();

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            // Tạo một danh sách để lưu trữ thông tin các dòng chưa được đánh dấu check
    List<string> uncheckedRowsInfo = new List<string>();

            // Duyệt qua các dòng trong DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra giá trị của checkbox trong từng dòng
                DataGridViewCheckBoxCell checkboxCell = row.Cells["CoMat"] as DataGridViewCheckBoxCell;
                if (checkboxCell != null && checkboxCell.Value != null && !(bool)checkboxCell.Value)
                {
                    // Nếu checkbox không được chọn, lấy thông tin của dòng và thêm vào danh sách
                    string rowInfo = string.Format("Lop: {5}",row.Cells["Lop"].Value);

                    uncheckedRowsInfo.Add(rowInfo);
                }
            }

            // Hiển thị thông tin của các dòng chưa được đánh dấu check trong MessageBox
            if (uncheckedRowsInfo.Count > 0)
            {
                string message = string.Join("\n", uncheckedRowsInfo);
                MessageBox.Show(message, "Thông tin dòng chưa được đánh dấu check");
            }
            else
            {
                MessageBox.Show("Không có dòng nào chưa được đánh dấu check.", "Thông báo");
            }
        }
    }
}
