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

        private void quảnLýTàiKhoảnSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
        private void quảnLýTàiKhoảnGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsQuanLySV_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("Frm_QLSV"))
            {
                Frm_QLSV frm = new Frm_QLSV();
                frm.MdiParent = this;
                frm.Name = "FrmQuanLySV";
                frm.Show();
            }
            else
            {
                ActiveChildForm("FrmQuanLySV");
            }
        }
    }
}
   
