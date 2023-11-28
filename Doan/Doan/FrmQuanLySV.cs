using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    public partial class FrmQuanLySV : Form
    {
        public FrmQuanLySV()
        {
            InitializeComponent();
            LoadGenderOptions();
        }
        private void LoadGenderOptions()
        {
            // Thêm các mục cho ComboBox giới tính
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
        }
        private void QuanLyTTSV_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedGender = cboGender.SelectedItem.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
