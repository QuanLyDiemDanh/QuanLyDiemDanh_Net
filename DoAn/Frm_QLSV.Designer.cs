
namespace DoAn
{
    partial class Frm_QLSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_SinhVien = new System.Windows.Forms.DataGridView();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLopNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btn_HienThiALL = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Label();
            this.txt_LopNienChe = new System.Windows.Forms.TextBox();
            this.cbbLopNienChe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaSv = new System.Windows.Forms.TextBox();
            this.butEp = new System.Windows.Forms.Button();
            this.butImSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lớp niên chế";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(528, 445);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(219, 30);
            this.txtTimKiem.TabIndex = 1;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(12, 135);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(219, 30);
            this.txt_Pass.TabIndex = 2;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(12, 213);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(219, 30);
            this.txt_HoTen.TabIndex = 3;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgaySinh.Location = new System.Drawing.Point(12, 296);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(219, 30);
            this.NgaySinh.TabIndex = 4;
            this.NgaySinh.Value = new System.DateTime(2023, 12, 22, 14, 57, 48, 0);
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbb_GioiTinh.Location = new System.Drawing.Point(12, 372);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(219, 30);
            this.cbb_GioiTinh.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(384, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "THÔNG TIN SINH VIÊN";
            // 
            // dataGridView_SinhVien
            // 
            this.dataGridView_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSV,
            this.colHoTen,
            this.colNgaySinh,
            this.GioiTinh,
            this.colLopNC});
            this.dataGridView_SinhVien.Location = new System.Drawing.Point(269, 55);
            this.dataGridView_SinhVien.Name = "dataGridView_SinhVien";
            this.dataGridView_SinhVien.RowHeadersWidth = 51;
            this.dataGridView_SinhVien.RowTemplate.Height = 24;
            this.dataGridView_SinhVien.Size = new System.Drawing.Size(943, 309);
            this.dataGridView_SinhVien.TabIndex = 8;
            // 
            // colMaSV
            // 
            this.colMaSV.DataPropertyName = "MaSinhVien";
            this.colMaSV.HeaderText = "Mã Sinh Viên";
            this.colMaSV.MinimumWidth = 6;
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            this.colMaSV.Width = 90;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTenSinhVien";
            this.colHoTen.HeaderText = "Họ Tên Sinh Viên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Width = 150;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 75;
            // 
            // colLopNC
            // 
            this.colLopNC.DataPropertyName = "LopNienChe";
            this.colLopNC.HeaderText = "Lớp Niên Chế";
            this.colLopNC.MinimumWidth = 6;
            this.colLopNC.Name = "colLopNC";
            this.colLopNC.ReadOnly = true;
            this.colLopNC.Width = 125;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthem.Location = new System.Drawing.Point(942, 387);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 51);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1092, 387);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 51);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(942, 457);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(120, 51);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnhuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(1092, 457);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(120, 50);
            this.btnhuy.TabIndex = 12;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btn_HienThiALL
            // 
            this.btn_HienThiALL.AutoSize = true;
            this.btn_HienThiALL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_HienThiALL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HienThiALL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThiALL.Location = new System.Drawing.Point(762, 389);
            this.btn_HienThiALL.Name = "btn_HienThiALL";
            this.btn_HienThiALL.Size = new System.Drawing.Size(140, 46);
            this.btn_HienThiALL.TabIndex = 24;
            this.btn_HienThiALL.Text = "Hiển thị tất cả";
            this.btn_HienThiALL.UseVisualStyleBackColor = false;
            this.btn_HienThiALL.Click += new System.EventHandler(this.btn_HienThiALL_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(762, 437);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 46);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(267, 392);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(167, 23);
            this.search.TabIndex = 21;
            this.search.Text = "Tìm kiếm sinh viên";
            // 
            // txt_LopNienChe
            // 
            this.txt_LopNienChe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LopNienChe.Location = new System.Drawing.Point(12, 447);
            this.txt_LopNienChe.Name = "txt_LopNienChe";
            this.txt_LopNienChe.Size = new System.Drawing.Size(219, 30);
            this.txt_LopNienChe.TabIndex = 3;
            // 
            // cbbLopNienChe
            // 
            this.cbbLopNienChe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLopNienChe.FormattingEnabled = true;
            this.cbbLopNienChe.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbLopNienChe.Location = new System.Drawing.Point(528, 390);
            this.cbbLopNienChe.Name = "cbbLopNienChe";
            this.cbbLopNienChe.Size = new System.Drawing.Size(219, 30);
            this.cbbLopNienChe.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tìm kiếm theo mã sinh viên";
            // 
            // txt_MaSv
            // 
            this.txt_MaSv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSv.Location = new System.Drawing.Point(12, 54);
            this.txt_MaSv.Name = "txt_MaSv";
            this.txt_MaSv.Size = new System.Drawing.Size(219, 30);
            this.txt_MaSv.TabIndex = 1;
            // 
            // butEp
            // 
            this.butEp.Location = new System.Drawing.Point(776, 494);
            this.butEp.Name = "butEp";
            this.butEp.Size = new System.Drawing.Size(91, 23);
            this.butEp.TabIndex = 25;
            this.butEp.Text = "Export";
            this.butEp.UseVisualStyleBackColor = true;
            this.butEp.Click += new System.EventHandler(this.butEp_Click);
            // 
            // butImSV
            // 
            this.butImSV.Location = new System.Drawing.Point(652, 495);
            this.butImSV.Name = "butImSV";
            this.butImSV.Size = new System.Drawing.Size(75, 23);
            this.butImSV.TabIndex = 26;
            this.butImSV.Text = "Import";
            this.butImSV.UseVisualStyleBackColor = true;
            this.butImSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn.Properties.Resources.Red_Color;
            this.ClientSize = new System.Drawing.Size(1224, 529);
            this.Controls.Add(this.butImSV);
            this.Controls.Add(this.butEp);
            this.Controls.Add(this.btn_HienThiALL);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView_SinhVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbLopNienChe);
            this.Controls.Add(this.cbb_GioiTinh);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.txt_LopNienChe);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_MaSv);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_QLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_QLSV";
            this.Load += new System.EventHandler(this.Frm_QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_SinhVien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btn_HienThiALL;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox txt_LopNienChe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLopNC;
        private System.Windows.Forms.ComboBox cbbLopNienChe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaSv;
        private System.Windows.Forms.Button butEp;
        private System.Windows.Forms.Button butImSV;
    }
}