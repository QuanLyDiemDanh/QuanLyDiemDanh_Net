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
using DoAn.Models;
namespace DoAn

{
    public partial class FrmDangNhap : Form
    { 
        DBConnect db = new DBConnect();
        public FrmDangNhap()
        {
            
            InitializeComponent();
            SetDefaultButton();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string mk = txtpass.Text;
            //Giảng viên
            string str = "select * from GiangVien where MaGiangVien = '" + taikhoan + "'";
            DataTable dt = db.getDataTable(str);
            GiangVien taikhoan_GV = new GiangVien();
            //Khoa
            string strcheckKhoa = "select * from Khoa where khoa_Username = '" + taikhoan + "'";
            DataTable dt1 = db.getDataTable(strcheckKhoa);
            Khoa taikhoanKhoa = new Khoa();
            //Sinh viên
            string strCheckSV = "select * from SinhVien where MaSinhVien= '" + taikhoan + "'";
            DataTable dt2 = db.getDataTable(strCheckSV);
            SinhVien taikhoan_SV = new SinhVien();

            foreach (DataRow i in dt.Rows)
            {
                taikhoan_GV.MaGiangVien = i["MaGiangVien"].ToString();
                taikhoan_GV.Password = i["Password"].ToString();
            }
            foreach (DataRow i in dt1.Rows)
            {
                taikhoanKhoa.khoa_Username = i["khoa_Username"].ToString();
                taikhoanKhoa.khoa_pass = i["khoa_pass"].ToString();
            }
            foreach (DataRow i in dt2.Rows)
            {
                taikhoan_SV.MaSinhVien = i["MaSinhVien"].ToString();
                taikhoan_SV.Password = i["Password"].ToString();
            }

            if (taikhoan_GV.MaGiangVien == taikhoan && taikhoan_GV.Password == mk)
            {
                frm_GiangVien f = new frm_GiangVien();
                f.getID(taikhoan);
                f.Show();
                this.Hide();
                f.Show();
            }
            else if (taikhoan_SV.MaSinhVien == taikhoan && taikhoan_SV.Password == mk)
            {
                frm_SinhVien f_sv = new frm_SinhVien();
                f_sv.getID(taikhoan);
                f_sv.Show();
                this.Hide();
            }
            else if (taikhoanKhoa.khoa_Username == taikhoan && taikhoanKhoa.khoa_pass == mk)
            {
                FrmKhoa f = new FrmKhoa();
                f.Show();
                this.Hide();
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
        private void SetDefaultButton()
        {
            // Chọn nút đăng nhập làm nút mặc định (AcceptButton)
            this.AcceptButton = btnDangNhap;

        }


    }
}
