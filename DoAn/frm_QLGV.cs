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
            // Lấy giá trị từ các ô textbox
            string MaGiangVien = txt_ma.Text.Trim();
            string Password = txt_pass.Text.Trim();
            string HoVaTen = txt_hovaten.Text.Trim();
            string TrinhDo = txt_trinhdo.Text.Trim();
            string ChuyenMon = txt_chuyenmon.Text.Trim();

            // Kiểm tra nếu một trong các ô textbox rỗng thì thông báo và không thêm vào cơ sở dữ liệu
            if (!string.IsNullOrEmpty(MaGiangVien) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(HoVaTen) && !string.IsNullOrEmpty(TrinhDo) && !string.IsNullOrEmpty(ChuyenMon))
            {
                try
                {
                    // Thực hiện thêm dữ liệu vào cơ sở dữ liệu thông qua lớp DBConnect
                    DBConnect dbConnect = new DBConnect();
                    string query = "INSERT INTO GiangVien (MaGiangVien, Password, HoVaTen, TrinhDo, ChuyenMon) VALUES (@MaGiangVien, @Password, @HoTenGiangVien, @TrinhDo, @ChuyenMon)";

                    SqlCommand command = new SqlCommand(query); // Khởi tạo SqlCommand
                    command.Parameters.AddWithValue("@MaGiangVien", MaGiangVien);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@HoTenGiangVien", HoVaTen);
                    command.Parameters.AddWithValue("@TrinhDo", TrinhDo);
                    command.Parameters.AddWithValue("@ChuyenMon", ChuyenMon);

                    int rowsAffected = dbConnect.executeNonQuery(query); // Truyền đối tượng SqlCommand vào hàm executeNonQuery

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã thêm dữ liệu vào cơ sở dữ liệu!");

                        // Cập nhật DataGridView sau khi thêm dữ liệu
                        string selectQuery = "SELECT * FROM GiangVien";
                        DataTable dataTable = dbConnect.getDataTable(selectQuery);
                        dataGridGV.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm dữ liệu vào cơ sở dữ liệu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để thêm dữ liệu!");
            }
        }
    }
    }
