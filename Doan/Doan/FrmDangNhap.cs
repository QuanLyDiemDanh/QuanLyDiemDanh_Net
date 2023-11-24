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

namespace Doan

{
    public partial class FrmDangNhap : Form
    {
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
            string userName = txtTaiKhoan.Text;
            string password = txtpass.Text;
            checkLogin(userName, password);
        }
        private void checkLogin(string userName, string password)
        {
            
        }
        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
