
namespace Doan
{
    partial class FrmQuanLyLop
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
            this.components = new System.ComponentModel.Container();
            this.lb_QLL = new System.Windows.Forms.Label();
            this.lb_malop = new System.Windows.Forms.Label();
            this.lb_ngayhoc = new System.Windows.Forms.Label();
            this.lb_TGbatdau = new System.Windows.Forms.Label();
            this.lb_TGketthuc = new System.Windows.Forms.Label();
            this.lb_idMH = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.txt_idMH = new System.Windows.Forms.TextBox();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.dataGridView_Class = new System.Windows.Forms.DataGridView();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDanhDataSet1 = new Doan.QuanLyDiemDanhDataSet1();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_NgayHoc = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classesTableAdapter = new Doan.QuanLyDiemDanhDataSet1TableAdapters.ClassesTableAdapter();
            this.quanLyDiemDanhDataSet2 = new Doan.QuanLyDiemDanhDataSet2();
            this.classesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter1 = new Doan.QuanLyDiemDanhDataSet2TableAdapters.ClassesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_QLL
            // 
            this.lb_QLL.AutoSize = true;
            this.lb_QLL.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QLL.Location = new System.Drawing.Point(370, 42);
            this.lb_QLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_QLL.Name = "lb_QLL";
            this.lb_QLL.Size = new System.Drawing.Size(217, 35);
            this.lb_QLL.TabIndex = 0;
            this.lb_QLL.Text = "Quản lý lớp học";
            this.lb_QLL.Click += new System.EventHandler(this.lb_QLL_Click);
            // 
            // lb_malop
            // 
            this.lb_malop.AutoSize = true;
            this.lb_malop.Location = new System.Drawing.Point(11, 19);
            this.lb_malop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_malop.Name = "lb_malop";
            this.lb_malop.Size = new System.Drawing.Size(79, 22);
            this.lb_malop.TabIndex = 1;
            this.lb_malop.Text = "Mã lớp :";
            // 
            // lb_ngayhoc
            // 
            this.lb_ngayhoc.AutoSize = true;
            this.lb_ngayhoc.Location = new System.Drawing.Point(11, 69);
            this.lb_ngayhoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ngayhoc.Name = "lb_ngayhoc";
            this.lb_ngayhoc.Size = new System.Drawing.Size(95, 22);
            this.lb_ngayhoc.TabIndex = 2;
            this.lb_ngayhoc.Text = "Ngày học :";
            // 
            // lb_TGbatdau
            // 
            this.lb_TGbatdau.AutoSize = true;
            this.lb_TGbatdau.Location = new System.Drawing.Point(8, 25);
            this.lb_TGbatdau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TGbatdau.Name = "lb_TGbatdau";
            this.lb_TGbatdau.Size = new System.Drawing.Size(159, 22);
            this.lb_TGbatdau.TabIndex = 3;
            this.lb_TGbatdau.Text = "Thời gian bắt đầu :";
            // 
            // lb_TGketthuc
            // 
            this.lb_TGketthuc.AutoSize = true;
            this.lb_TGketthuc.Location = new System.Drawing.Point(8, 74);
            this.lb_TGketthuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TGketthuc.Name = "lb_TGketthuc";
            this.lb_TGketthuc.Size = new System.Drawing.Size(163, 22);
            this.lb_TGketthuc.TabIndex = 4;
            this.lb_TGketthuc.Text = "Thời gian kết thúc :";
            // 
            // lb_idMH
            // 
            this.lb_idMH.AutoSize = true;
            this.lb_idMH.Location = new System.Drawing.Point(11, 117);
            this.lb_idMH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idMH.Name = "lb_idMH";
            this.lb_idMH.Size = new System.Drawing.Size(118, 22);
            this.lb_idMH.TabIndex = 5;
            this.lb_idMH.Text = "Mã môn học :";
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(147, 15);
            this.txt_malop.Margin = new System.Windows.Forms.Padding(4);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(136, 30);
            this.txt_malop.TabIndex = 6;
            // 
            // txt_idMH
            // 
            this.txt_idMH.Location = new System.Drawing.Point(147, 113);
            this.txt_idMH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idMH.Name = "txt_idMH";
            this.txt_idMH.Size = new System.Drawing.Size(136, 30);
            this.txt_idMH.TabIndex = 7;
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(231, 18);
            this.txt_start.Margin = new System.Windows.Forms.Padding(4);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(136, 30);
            this.txt_start.TabIndex = 9;
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(231, 70);
            this.txt_end.Margin = new System.Windows.Forms.Padding(4);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(136, 30);
            this.txt_end.TabIndex = 10;
            // 
            // dataGridView_Class
            // 
            this.dataGridView_Class.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Class.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.NgayHoc,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc,
            this.CourseID});
            this.dataGridView_Class.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView_Class.Location = new System.Drawing.Point(102, 346);
            this.dataGridView_Class.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Class.Name = "dataGridView_Class";
            this.dataGridView_Class.RowHeadersWidth = 51;
            this.dataGridView_Class.RowTemplate.Height = 24;
            this.dataGridView_Class.Size = new System.Drawing.Size(775, 260);
            this.dataGridView_Class.TabIndex = 12;
            this.dataGridView_Class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "Mã lớp";
            this.ClassID.MinimumWidth = 6;
            this.ClassID.Name = "ClassID";
            this.ClassID.Width = 125;
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "NgayHoc";
            this.NgayHoc.HeaderText = "Ngày học ";
            this.NgayHoc.MinimumWidth = 6;
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.Width = 125;
            // 
            // ThoiGianBatDau
            // 
            this.ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            this.ThoiGianBatDau.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDau.MinimumWidth = 6;
            this.ThoiGianBatDau.Name = "ThoiGianBatDau";
            this.ThoiGianBatDau.Width = 125;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.HeaderText = "Thời Gian Kết Thúc";
            this.ThoiGianKetThuc.MinimumWidth = 6;
            this.ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.Width = 125;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "Mã môn học ";
            this.CourseID.MinimumWidth = 6;
            this.CourseID.Name = "CourseID";
            this.CourseID.Width = 125;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.quanLyDiemDanhDataSet1;
            // 
            // quanLyDiemDanhDataSet1
            // 
            this.quanLyDiemDanhDataSet1.DataSetName = "QuanLyDiemDanhDataSet1";
            this.quanLyDiemDanhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(515, 271);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(103, 32);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(673, 271);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(103, 32);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(812, 271);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(103, 32);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_NgayHoc);
            this.groupBox1.Controls.Add(this.txt_idMH);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.lb_idMH);
            this.groupBox1.Controls.Add(this.lb_ngayhoc);
            this.groupBox1.Controls.Add(this.lb_malop);
            this.groupBox1.Location = new System.Drawing.Point(87, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(330, 161);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // date_NgayHoc
            // 
            this.date_NgayHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayHoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgayHoc.Location = new System.Drawing.Point(147, 62);
            this.date_NgayHoc.Margin = new System.Windows.Forms.Padding(4);
            this.date_NgayHoc.Name = "date_NgayHoc";
            this.date_NgayHoc.Size = new System.Drawing.Size(136, 30);
            this.date_NgayHoc.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_end);
            this.groupBox2.Controls.Add(this.txt_start);
            this.groupBox2.Controls.Add(this.lb_TGketthuc);
            this.groupBox2.Controls.Add(this.lb_TGbatdau);
            this.groupBox2.Location = new System.Drawing.Point(515, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(389, 124);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyDiemDanhDataSet2
            // 
            this.quanLyDiemDanhDataSet2.DataSetName = "QuanLyDiemDanhDataSet2";
            this.quanLyDiemDanhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource1
            // 
            this.classesBindingSource1.DataMember = "Classes";
            this.classesBindingSource1.DataSource = this.quanLyDiemDanhDataSet2;
            // 
            // classesTableAdapter1
            // 
            this.classesTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Hiển Thị Tất Cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doan.Properties.Resources.tet3;
            this.ClientSize = new System.Drawing.Size(961, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView_Class);
            this.Controls.Add(this.lb_QLL);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLyLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyLop";
            this.Load += new System.EventHandler(this.FrmQuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_QLL;
        private System.Windows.Forms.Label lb_malop;
        private System.Windows.Forms.Label lb_ngayhoc;
        private System.Windows.Forms.Label lb_TGbatdau;
        private System.Windows.Forms.Label lb_TGketthuc;
        private System.Windows.Forms.Label lb_idMH;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.TextBox txt_idMH;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.DataGridView dataGridView_Class;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QuanLyDiemDanhDataSet1 quanLyDiemDanhDataSet1;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private QuanLyDiemDanhDataSet1TableAdapters.ClassesTableAdapter classesTableAdapter;
        private QuanLyDiemDanhDataSet2 quanLyDiemDanhDataSet2;
        private System.Windows.Forms.BindingSource classesBindingSource1;
        private QuanLyDiemDanhDataSet2TableAdapters.ClassesTableAdapter classesTableAdapter1;
        private System.Windows.Forms.DateTimePicker date_NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.Button button1;
    }
}