using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Models;
namespace Doan
{
    public partial class FrmGiangVien : Form
    {
        string giangVienID;
        DBConnect db = new DBConnect();
        public bool isThoat = true;
        public FrmGiangVien()
        {
            InitializeComponent();
        }
        public FrmGiangVien(string giangVienID)
        {
            InitializeComponent();
            this.giangVienID = giangVienID;
        }
        private void frm_GiangVien_Load(object sender, EventArgs e)
        {
            load_CboLop();
            loadData();
        }

        public void loadData()
        {
            string str = "SELECT Classes.ClassID, Courses.TenMonHoc, Courses.CourseID " +
                "FROM Classes " +
                "JOIN Courses ON Classes.CourseID = Courses.CourseID " +
                "WHERE Courses.GiangVienID = '" + giangVienID + "'";

            DataTable dt = db.getDataTable(str);
            List<GiangVienViewModel> giangVienInfoList = new List<GiangVienViewModel>();

            foreach (DataRow row in dt.Rows)
            {
                GiangVienViewModel gvView = new GiangVienViewModel();
                gvView.ClassID = int.Parse(row["ClassID"].ToString());
                gvView.TenMonHoc = row["TenMonHoc"].ToString();
                gvView.CourseID = int.Parse(row["CourseID"].ToString());

                giangVienInfoList.Add(gvView);
            }

            grd_LopGiangDay.DataSource = giangVienInfoList;
        }

        private void frm_GiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        public void load_CboLop()
        {
            string query = "SELECT ClassID FROM Classes " +
               "WHERE CourseID IN (SELECT CourseID FROM Courses WHERE GiangVienID = '" + giangVienID + "')";
            DataTable dt = db.getDataTable(query);
            cbo_Lop.DataSource = dt;
            cbo_Lop.DisplayMember = "ClassID";
            cbo_Lop.ValueMember = "ClassID";
        }
        public void DataBingding(DataTable pdt)
        {
            //cbo_Lop.DataBindings.Clear();
            //cbo_Lop.DataBindings.Add("SelectedValue", pdt, "MaLopMonHoc");
        }

        private void btn_ChonLop_Click(object sender, EventArgs e)
        {         
            FrmDiemDanh f = new FrmDiemDanh(giangVienID);
            f.Show();
        }
        public event EventHandler DangXuat;
        private void LogoutMenuStrip_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }
        void f_DangXuat(object sender, EventArgs e)
        {
            //(sender as FrmGiangVien).isThoat = false;
            //(sender as FrmGiangVien).Close();
            //this.Show();

        }

        private void InfoMenuStrip_Click(object sender, EventArgs e)
        {
            
        }

        void f_DangXuatTTGV(object sender, EventArgs e)
        {
           
        }
    }
}
