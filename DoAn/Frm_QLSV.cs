using System;
using System.Data;
using System.Windows.Forms;
using DoAn.Models;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace DoAn
{
    public partial class Frm_QLSV : Form
    {
        private DBConnect db = new DBConnect();

        public Frm_QLSV()
        {
            InitializeComponent();
            btnthem.Click += btnthem_Click;
            btnupdate.Click += btnupdate_Click;
            btnxoa.Click += btnxoa_Click;
            btnhuy.Click += btnhuy_Click;
            btnSearch.Click += btnSearch_Click;
            dataGridView_SinhVien.CellContentClick += DataGridView_SinhVien_CellContentClick;
            LoadData();
            LoadLopNienChe();

            // Gán sự kiện cho ô tìm kiếm
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
        }

        private void LoadLopNienChe()
        {
            try
            {
                // Giả sử danh sách lớp niên chế được lấy từ cơ sở dữ liệu
                string query = "SELECT DISTINCT LopNienChe FROM SinhVien";
                DataTable dtLopNienChe = db.getDataTable(query);

                // Làm trống ComboBox trước khi thêm mới
                cbbLopNienChe.Items.Clear();

                // Thêm tất cả các lớp niên chế vào ComboBox
                foreach (DataRow row in dtLopNienChe.Rows)
                {
                    cbbLopNienChe.Items.Add(row["LopNienChe"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                string str = "SELECT * FROM SinhVien";
                DataTable dt = db.getDataTable(str);

                // Hiển thị danh sách SinhVien lên dataGridView_SinhVien
                dataGridView_SinhVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TimKiemSinhVien();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemSinhVien();
            }
        }

        private void TimKiemSinhVien()
        {
            try
            {
                string maSinhVienCanTim = txtTimKiem.Text.Trim();

                if (!string.IsNullOrEmpty(maSinhVienCanTim))
                {
                    string query = $"SELECT * FROM SinhVien WHERE MaSinhVien LIKE '%{maSinhVienCanTim}%'";
                    DataTable dt = db.getDataTable(query);

                    // Hiển thị kết quả tìm kiếm lên dataGridView_SinhVien
                    dataGridView_SinhVien.DataSource = dt;
                }
                else
                {
                    // Nếu ô tìm kiếm trống, hiển thị toàn bộ danh sách
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DataGridView_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_SinhVien.CurrentRow.Index;
            txt_MaSv.Text = dataGridView_SinhVien.Rows[i].Cells[0].Value.ToString();
            txt_Pass.Text = dataGridView_SinhVien.Rows[i].Cells[1].Value.ToString();
            txt_HoTen.Text = dataGridView_SinhVien.Rows[i].Cells[2].Value.ToString();
            NgaySinh.Text = dataGridView_SinhVien.Rows[i].Cells[3].Value.ToString();
            cbb_GioiTinh.Text = dataGridView_SinhVien.Rows[i].Cells[4].Value.ToString();
            txt_LopNienChe.Text = dataGridView_SinhVien.Rows[i].Cells[5].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien newStudent = new SinhVien
                {
                    MaSinhVien = txt_MaSv.Text,
                    Password = txt_Pass.Text,
                    HoTenSinhVien = txt_HoTen.Text,
                    NgaySinh = NgaySinh.Value,
                    GioiTinh = cbb_GioiTinh.Text,
                    LopNienChe = txt_LopNienChe.Text
                };

                string query = $"INSERT INTO SinhVien (MaSinhVien, Password, HoTenSinhVien, NgaySinh, GioiTinh, LopNienChe) " +
                               $"VALUES ('{newStudent.MaSinhVien}', '{newStudent.Password}', '{newStudent.HoTenSinhVien}', " +
                               $"'{newStudent.NgaySinh:yyyy-MM-dd}', '{newStudent.GioiTinh}', '{newStudent.LopNienChe}')";

                int rowsAffected = db.getNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sinh viên đã được thêm vào cơ sở dữ liệu.");
                    LoadData(); // Reload dữ liệu sau khi thêm
                }
                else
                {
                    MessageBox.Show("Không thể thêm sinh viên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien updatedStudent = new SinhVien
                {
                    MaSinhVien = txt_MaSv.Text,
                    Password = txt_Pass.Text,
                    HoTenSinhVien = txt_HoTen.Text,
                    NgaySinh = NgaySinh.Value,
                    GioiTinh = cbb_GioiTinh.Text,
                    LopNienChe = txt_LopNienChe.Text
                };

                string query = $"UPDATE SinhVien SET Password = '{updatedStudent.Password}', " +
                               $"HoTenSinhVien = '{updatedStudent.HoTenSinhVien}', " +
                               $"NgaySinh = '{updatedStudent.NgaySinh:yyyy-MM-dd}', " +
                               $"GioiTinh = '{updatedStudent.GioiTinh}', " +
                               $"LopNienChe = '{updatedStudent.LopNienChe}' " +
                               $"WHERE MaSinhVien = '{updatedStudent.MaSinhVien}'";

                int rowsAffected = db.getNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thông tin sinh viên đã được cập nhật.");
                    LoadData(); // Reload dữ liệu sau khi sửa
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin sinh viên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSinhVien = txt_MaSv.Text;

                if (!string.IsNullOrEmpty(maSinhVien))
                {
                    // Kiểm tra xác nhận từ người dùng trước khi xóa
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string query = $"DELETE FROM SinhVien WHERE MaSinhVien = '{maSinhVien}'";

                        int rowsAffected = db.getNonQuery(query);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sinh viên đã được xóa khỏi cơ sở dữ liệu.");
                            LoadData(); // Reload dữ liệu sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa sinh viên.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            // Làm trắng tất cả các ô TextBox
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            // Duyệt qua tất cả các control trên form và làm trắng TextBox
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
            }

            // Làm trắng các ComboBox khác (nếu có)
            cbb_GioiTinh.SelectedIndex = -1;
            cbbLopNienChe.SelectedIndex = -1;
        }
        private void btn_HienThiALL_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Frm_QLSV_Load(object sender, EventArgs e)
        {

        }
        private void Xuat(string Path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView_SinhVien.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView_SinhVien.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView_SinhVien.Rows.Count; i++)

            {
                for (int j = 0; i < dataGridView_SinhVien.Columns.Count; i++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView_SinhVien.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(Path);
            application.ActiveWorkbook.Saved = true;
        }
        private void butEp_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel Workbook (.xlx)|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Xuat(saveFileDialog.FileName);
                    MessageBox.Show("file thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("thành công" + ex.Message);
                }
            }
        }
        private void ImportEX(string Path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(Path))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> list = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        list.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(list.ToArray());
                }
                dataGridView_SinhVien.DataSource = dataTable;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel Workbook (.xlx)|.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportEX(openFileDialog.FileName);
                    MessageBox.Show("file thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" không thành công\n" + ex.Message);
                }
            }
        }
    }
}
