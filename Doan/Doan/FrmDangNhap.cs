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
    public partial class FrmDangNhap : Form
    {
        DBConnect db = new DBConnect();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string str = "select * from TaiKhoanGV where GiangVienID = '" + txtTaiKhoan.Text + "'";
            string mk = txtpass.Text;
            string strcheckAdmin = "select * from TaiKhoanAdmin where username = '" + txtTaiKhoan.Text + "'";
            DataTable dt1 = db.getDataTable(strcheckAdmin);
            TaiKhoanAdmin taikhoanam = new TaiKhoanAdmin();
            DataTable dt = db.getDataTable(str);
            TaiKhoanGV taikhoan = new TaiKhoanGV();

            foreach (DataRow i in dt.Rows)
            {
                taikhoan.GiangVienID = i["GiangVienID"].ToString();
                taikhoan.PassGV = i["PassGV"].ToString();
            }
            foreach (DataRow i in dt1.Rows)
            {
                taikhoanam.username = i["username"].ToString();
                taikhoanam.adminpass = i["adminpass"].ToString();
            }
            if(taikhoan.GiangVienID==txtTaiKhoan.Text && taikhoan.PassGV==mk)
            {
                this.Hide();
                new FrmGiangVien().Show();
            }    
            else if(taikhoanam.username == txtTaiKhoan.Text && taikhoanam.adminpass == mk)
            {
                this.Hide();
                new FrmAdmin().Show();
            }    
            else
            {
                MessageBox.Show("Thông tin tài khoản không chính xác!", "Thông báo", MessageBoxButtons.OKCancel);
            }    
        }
        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
