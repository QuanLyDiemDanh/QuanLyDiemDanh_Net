﻿using System;
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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
namespace DoAn
{
    public partial class frm_QLGV : Form
    {
        DBConnect db = new DBConnect();
        public frm_QLGV()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadInitialData();
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
        //-------------------------------HỦY----------------------------------------------
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
        //-------------------------------TÌM----------------------------------------------
        private void btn_tim_Click(object sender, EventArgs e)
        {
            string MaGiangVien = txt_tim.Text.Trim();

            if (!string.IsNullOrEmpty(MaGiangVien))
            {
                try
                {
                    DBConnect dbConnect = new DBConnect();
                    string query = "SELECT * FROM GiangVien WHERE MaGiangVien = '" + MaGiangVien + "'";
                    DataTable dataTable = dbConnect.getDataTable(query);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Hiển thị thông tin giáo viên đã tìm thấy
                        dataGridGV.DataSource = dataTable; // Hiển thị kết quả trong DataGridView

                        MessageBox.Show("Đã tìm thấy giáo viên!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giáo viên với mã này!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm giáo viên: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã giáo viên cần tìm kiếm!");
            }
        }
        private DataTable originalDataTable;
        private void LoadInitialData()
        {
            // Load dữ liệu ban đầu từ CSDL hoặc từ một nguồn nào đó vào DataGridView
            // Ví dụ, dùng đoạn mã sau để lấy dữ liệu từ DBConnect:
            DBConnect dbConnect = new DBConnect();
            string query = "SELECT * FROM GiangVien";
            originalDataTable = dbConnect.getDataTable(query);

            // Hiển thị dữ liệu trong DataGridView
            dataGridGV.DataSource = originalDataTable;
        }

        //-------------------------------HIỂN THỊ----------------------------------------------
        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            if (originalDataTable != null)
            {
                // Khôi phục dữ liệu ban đầu bằng cách gán lại giá trị của bản sao cho DataGridView
                dataGridGV.DataSource = originalDataTable.Copy();
                MessageBox.Show("Đã hiển thị danh sách Giảng Viên!");
            }
            else
            {
                MessageBox.Show("Lỗi! Không thể hiển thị");
            }
        }


        //-------------------------------THÊM----------------------------------------------
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string maGiangVien = txt_ma.Text.Trim();
                string password = txt_pass.Text.Trim();
                string hoVaTen = txt_hovaten.Text.Trim();
                string trinhDo = txt_trinhdo.Text.Trim();
                string chuyenMon = txt_chuyenmon.Text.Trim();

                // Kiểm tra và thêm dữ liệu vào DataTable hoặc Database trực tiếp ở đây

                // Ví dụ: Thêm vào DataTable trước
                DataTable dataTable = new DataTable(); // Khởi tạo hoặc lấy từ DataGridView nếu đã có dữ liệu
                DataRow newRow = dataTable.NewRow();
                newRow["MaGiangVien"] = maGiangVien;
                newRow["Password"] = password;
                newRow["HoTenGiangVien"] = hoVaTen;
                newRow["TrinhDo"] = trinhDo;
                newRow["ChuyenMon"] = chuyenMon;
                dataTable.Rows.Add(newRow);

                // Cập nhật DataGridView
                dataGridGV.DataSource = dataTable;

                // Lưu vào Database thông qua lớp DBConnect
                DBConnect dbConnect = new DBConnect();
                string query = "INSERT INTO GiangVien (MaGiangVien, Password, HoTenGiangVien, TrinhDo, ChuyenMon) VALUES ('" + maGiangVien + "', '" + password + "', '" + hoVaTen + "', '" + trinhDo + "', '" + chuyenMon + "')";

                int rowsAffected = dbConnect.executeNonQuery(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công vào CSDL!");
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu vào CSDL!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã giáo viên cần xóa từ DataGridView hoặc TextBox hoặc control tương ứng
                string maGiangVienToDelete = txt_ma.Text.Trim(); // Thay thế bằng control hoặc điều kiện tương ứng

                // Xác định và thực hiện xóa dữ liệu thông qua DBConnect
                DBConnect dbConnect = new DBConnect();
                string query = "DELETE FROM GiangVien WHERE MaGiangVien = '" + maGiangVienToDelete + "'";

                int rowsAffected = dbConnect.executeNonQuery(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã xóa dữ liệu thành công từ CSDL!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa dữ liệu từ CSDL!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Xuat(string Path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridGV.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridGV.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridGV.Rows.Count; i++)

            {
                for (int j = 0; i < dataGridGV.Columns.Count; i++)
                {
                    application.Cells[i + 2, j + 1] = dataGridGV.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(Path);
            application.ActiveWorkbook.Saved = true;
        }
        private void butXuat_Click(object sender, EventArgs e)
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
                    MessageBox.Show(" không thành công\n" + ex.Message);
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
                dataGridGV.DataSource = dataTable;
            }
        }

        private void butIP_Click(object sender, EventArgs e)
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

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void butWord_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {

        }
    }
}
