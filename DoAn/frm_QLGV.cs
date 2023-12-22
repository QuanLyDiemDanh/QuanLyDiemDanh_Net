using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Models;

namespace DoAn
{
    public partial class frm_QLGV : Form
    {
        DBConnect db = new DBConnect();
        public frm_QLGV()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void loadData()
        {
            string str = "select * from GiangVien";
            DataTable dt = db.getDataTable(str);
            GiangVien sv = new GiangVien();
            foreach (DataRow i in dt.Rows)
            {
                sv.MaGiangVien = i["MaGiangVien"].ToString();
                sv.Password = i["Password"].ToString();
                sv.HoTenGiangVien = i["HoTenGiangVien"].ToString();
                sv.TrinhDo = i["TrinhDo"].ToString();
                sv.ChuyenMon = i["ChuyenMon"].ToString();
            }
            dataGridGV.DataSource = dt;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                FrmKhoa secondForm = new FrmKhoa(); // Tạo instance của SecondForm
                secondForm.Show(); // Hiển thị SecondForm
                this.Hide(); // Ẩn MainForm
            }
        }

        private void frm_QLGV_Load(object sender, EventArgs e)
        {
            loadData();
            //this.WindowState = FormWindowState.Maximized;

        }
    }
}
