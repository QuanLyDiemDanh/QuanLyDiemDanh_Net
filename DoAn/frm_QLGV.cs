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

        //public DataTable SearchTeacherByCode(string teacherCode)
        //{
        //    DataTable dataTable = new DataTable();

        //    using (SqlConnection connection = new SqlConnection(stringConnection))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            string query = "SELECT * FROM GiangVien WHERE MaGiangVien = @MaGiangVien";
        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.Parameters.AddWithValue("@MaGiangVien", teacherCode);

        //            SqlDataAdapter adapter = new SqlDataAdapter(command);
        //            adapter.Fill(dataTable);
        //        }
        //        catch (Exception ex)
        //        {
        //            // Xử lý exception nếu có
        //            // Ví dụ: throw ex; hoặc xử lý thông báo lỗi
        //        }
        //    }

        //    return dataTable;
        //}
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
        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            if (originalDataTable != null)
            {
                // Khôi phục dữ liệu ban đầu bằng cách gán lại giá trị của bản sao cho DataGridView
                dataGridGV.DataSource = originalDataTable.Copy();
                MessageBox.Show("Đã hiển thị tất cả danh sách Giảng Viên!");
            }
            else
            {
                MessageBox.Show("Lỗi! Không thể hiển thị");
            }
        }
    }
    }
