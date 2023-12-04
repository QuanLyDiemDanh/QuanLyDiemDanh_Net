
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
            this.txt_day = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDanhDataSet1 = new Doan.QuanLyDiemDanhDataSet1();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classesTableAdapter = new Doan.QuanLyDiemDanhDataSet1TableAdapters.ClassesTableAdapter();
            this.quanLyDiemDanhDataSet2 = new Doan.QuanLyDiemDanhDataSet2();
            this.classesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter1 = new Doan.QuanLyDiemDanhDataSet2TableAdapters.ClassesTableAdapter();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lb_QLL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QLL.Location = new System.Drawing.Point(346, 25);
            this.lb_QLL.Name = "lb_QLL";
            this.lb_QLL.Size = new System.Drawing.Size(175, 26);
            this.lb_QLL.TabIndex = 0;
            this.lb_QLL.Text = "Quản lý lớp học";
            // 
            // lb_malop
            // 
            this.lb_malop.AutoSize = true;
            this.lb_malop.Location = new System.Drawing.Point(8, 14);
            this.lb_malop.Name = "lb_malop";
            this.lb_malop.Size = new System.Drawing.Size(58, 17);
            this.lb_malop.TabIndex = 1;
            this.lb_malop.Text = "Mã lớp :";
            // 
            // lb_ngayhoc
            // 
            this.lb_ngayhoc.AutoSize = true;
            this.lb_ngayhoc.Location = new System.Drawing.Point(8, 50);
            this.lb_ngayhoc.Name = "lb_ngayhoc";
            this.lb_ngayhoc.Size = new System.Drawing.Size(76, 17);
            this.lb_ngayhoc.TabIndex = 2;
            this.lb_ngayhoc.Text = "Ngày học :";
            // 
            // lb_TGbatdau
            // 
            this.lb_TGbatdau.AutoSize = true;
            this.lb_TGbatdau.Location = new System.Drawing.Point(6, 18);
            this.lb_TGbatdau.Name = "lb_TGbatdau";
            this.lb_TGbatdau.Size = new System.Drawing.Size(127, 17);
            this.lb_TGbatdau.TabIndex = 3;
            this.lb_TGbatdau.Text = "Thời gian bắt đầu :";
            // 
            // lb_TGketthuc
            // 
            this.lb_TGketthuc.AutoSize = true;
            this.lb_TGketthuc.Location = new System.Drawing.Point(6, 54);
            this.lb_TGketthuc.Name = "lb_TGketthuc";
            this.lb_TGketthuc.Size = new System.Drawing.Size(129, 17);
            this.lb_TGketthuc.TabIndex = 4;
            this.lb_TGketthuc.Text = "Thời gian kết thúc :";
            // 
            // lb_idMH
            // 
            this.lb_idMH.AutoSize = true;
            this.lb_idMH.Location = new System.Drawing.Point(8, 85);
            this.lb_idMH.Name = "lb_idMH";
            this.lb_idMH.Size = new System.Drawing.Size(93, 17);
            this.lb_idMH.TabIndex = 5;
            this.lb_idMH.Text = "Mã môn học :";
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(107, 11);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(100, 22);
            this.txt_malop.TabIndex = 6;
            // 
            // txt_idMH
            // 
            this.txt_idMH.Location = new System.Drawing.Point(107, 82);
            this.txt_idMH.Name = "txt_idMH";
            this.txt_idMH.Size = new System.Drawing.Size(100, 22);
            this.txt_idMH.TabIndex = 7;
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(168, 13);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(100, 22);
            this.txt_start.TabIndex = 9;
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(168, 51);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(100, 22);
            this.txt_end.TabIndex = 10;
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(107, 47);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(100, 22);
            this.txt_day.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.NgayHoc,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc,
            this.CourseID});
            this.dataGridView1.Location = new System.Drawing.Point(29, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 189);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.btn_them.Location = new System.Drawing.Point(446, 183);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(583, 183);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(720, 183);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_day);
            this.groupBox1.Controls.Add(this.txt_idMH);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.lb_idMH);
            this.groupBox1.Controls.Add(this.lb_ngayhoc);
            this.groupBox1.Controls.Add(this.lb_malop);
            this.groupBox1.Location = new System.Drawing.Point(127, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 117);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_end);
            this.groupBox2.Controls.Add(this.txt_start);
            this.groupBox2.Controls.Add(this.lb_TGketthuc);
            this.groupBox2.Controls.Add(this.lb_TGbatdau);
            this.groupBox2.Location = new System.Drawing.Point(470, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 91);
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
            // FrmQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_QLL);
            this.Name = "FrmQuanLyLop";
            this.Text = "FrmQuanLyLop";
            this.Load += new System.EventHandler(this.FrmQuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
    }
}