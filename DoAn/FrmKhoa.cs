using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FrmKhoa : Form
    {
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void phânCôngGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (!checkExitsForm("FrmQuanLyMonHoc"))
        //    {
        //        FrmQuanLyMonHoc frm = new FrmQuanLyMonHoc();
        //        frm.MdiParent = this;
        //        frm.Name = "FrmQuanLyMonHoc";
        //        frm.Show();
        //    }
        //    else
        //    {
        //        ActiveChildForm("FrmQuanLyMonHoc");
        //    }
        //}

        private void quảnLýTàiKhoảnSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thực hiện các bước đăng xuất, ví dụ: đóng form hiện tại
                this.Hide();
                new FrmDangNhap().Show();
            }
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsQLTK_Click(object sender, EventArgs e)
        {
        }

        private bool checkExitsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        //private void tsQuanLySV_Click(object sender, EventArgs e)
        //{
        //    if (!checkExitsForm("FrmQuanLySV"))
        //    {
        //        FrmQuanLySV frm = new FrmQuanLySV();
        //        frm.MdiParent = this;
        //        frm.Name = "FrmQuanLySV";
        //        frm.Show();
        //    }
        //    else
        //    {
        //        ActiveChildForm("FrmQuanLySV");
        //    }

        //}

        private void quảnLýTàiKhoảnGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    if (!checkExitsForm("FrmQuanLyTaiKhoanGV"))
        //    {
        //        FrmQuanLyTaiKhoanGV frm = new FrmQuanLyTaiKhoanGV();
        //        frm.MdiParent = this;
        //        frm.Name = "FrmQuanLyTaiKhoanGV";
        //        frm.Show();
        //    }
        //    else
        //    {
        //        ActiveChildForm("FrmQuanLyTaiKhoanGV");
        //    }
        //}

        //private void tsThemGV_Click(object sender, EventArgs e)
        //{
        //    if (!checkExitsForm("FrmQuanLyGiangVien"))
        //    {
        //        FrmQuanLyGiangVien frm = new FrmQuanLyGiangVien();
        //        frm.MdiParent = this;
        //        frm.Name = "FrmQuanLyGiangVien";
        //        frm.Show();
        //    }
        //    else
        //    {
        //        ActiveChildForm("FrmQuanLyGiangVien");
        //    }
        //}

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
    //    private void tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
    //    {
    //        if (this != null) // Kiểm tra xem đối tượng 'this' có khác null không
    //        {
    //            if (!checkExitsForm("FrmDiemDanh"))
    //            {
    //                FrmBaoCao frm = new FrmBaoCao();
    //                frm.MdiParent = this;
    //                frm.Name = "FrmDiemDanh";
    //                frm.Show();
    //            }
    //            else
    //            {
    //                ActiveChildForm("FrmDiemDanh");
    //            }
    //        }
    //    }

//    private void quảnLýLớpHọcToolStripMenuItem1_Click(object sender, EventArgs e)
//    {
//        if (!checkExitsForm("FrmQuanLyLop"))
//        {
//            FrmQuanLyLop frm = new FrmQuanLyLop();
//            frm.MdiParent = this;
//            frm.Name = "FrmQuanLyLop";
//            frm.Show();
//        }
//        else
//        {
//            ActiveChildForm("FrmQuanLyLop");
//        }
//    }
//}
