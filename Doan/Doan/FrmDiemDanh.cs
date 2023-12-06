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
            //string query = 

            //// Thực hiện truy vấn
            //DataTable dt = db.getDataTable(query);

           
        }
        private void dataGridView_DiemDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDiemDanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDiemDanhSVDataSet4.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter1.Fill(this.quanLyDiemDanhSVDataSet4.Attendance);
            // TODO: This line of code loads data into the 'quanLyDiemDanhSVDataSet3.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.quanLyDiemDanhSVDataSet3.Attendance);
            // TODO: This line of code loads data into the 'quanLyDiemDanhSVDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.quanLyDiemDanhSVDataSet.Classes);

        }

    }
}
