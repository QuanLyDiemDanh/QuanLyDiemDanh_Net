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
            string query = 

            // Thực hiện truy vấn
            DataTable dt = db.getDataTable(query);

           
        }
        private void dataGridView_DiemDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDiemDanh_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======

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
                    string rowInfo = string.Format("CoMat: {5}",row.Cells["CoMat"].Value);

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
>>>>>>> 29b9e836fd71950cbbe024d7808f9c5e15ad6473
    }
}
