using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan.ThongKe
{
    public partial class tkNVNghiCP : UserControl
    {
        public tkNVNghiCP()
        {
            InitializeComponent();
        }
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();
        int thang = DateTime.Now.Month, nam = DateTime.Now.Year, ngay = DateTime.Now.Day;
        DateTime n;
        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaydau = Convert.ToDateTime(Convert.ToInt32(cbThang.Text) + "/" + "01/" + Convert.ToInt32(cbNam.Text) + " ");
                DateTime ngaycuoi = Convert.ToDateTime(Convert.ToInt32(cbThang.Text) + "/" + "29/" + Convert.ToInt32(cbNam.Text) + " ");
                if (rdNTN.Checked == true)
                {
                    try
                    {
                        n = Convert.ToDateTime(Convert.ToInt32(cbThang.Text) + "/" + Convert.ToInt32(txtNgay.Text) + "/" + Convert.ToInt32(cbNam.Text));
                        dt.Clear();
                        dt = tkcl.tkNhanVienNghiCP(n, n, 1);
                        dtgv.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    txtNgay.Enabled = false;
                    try
                    {
                        dt.Clear();
                        dt = tkcl.tkNhanVienNghiCP(ngaydau, ngaycuoi, 0);
                        dtgv.DataSource = dt;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập đầy đủ thông tin!!");
            }
        }
        private void load()
        {
            txtNgay.Enabled = false;
            cbThang.Enabled = false;
            cbNam.Enabled = false;
            btXem.Enabled = false;
        }
        private void tkNVNghiCoPhep_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
