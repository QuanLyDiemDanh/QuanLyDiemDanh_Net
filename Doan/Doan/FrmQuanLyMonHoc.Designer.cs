﻿
namespace Doan
{
    partial class FrmQuanLyMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_idGV = new System.Windows.Forms.TextBox();
            this.txt_tenMH = new System.Windows.Forms.TextBox();
            this.txt_idMH = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_TenMonHoc = new System.Windows.Forms.Label();
            this.lb_IDGV = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDanhDataSet = new Doan.QuanLyDiemDanhDataSet();
            this.coursesTableAdapter = new Doan.QuanLyDiemDanhDataSetTableAdapters.CoursesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiangVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVienIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý môn học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_idGV);
            this.groupBox4.Controls.Add(this.txt_tenMH);
            this.groupBox4.Controls.Add(this.txt_idMH);
            this.groupBox4.Controls.Add(this.lb_id);
            this.groupBox4.Controls.Add(this.lb_TenMonHoc);
            this.groupBox4.Controls.Add(this.lb_IDGV);
            this.groupBox4.Location = new System.Drawing.Point(69, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 166);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhập thông tin";
            // 
            // txt_idGV
            // 
            this.txt_idGV.Location = new System.Drawing.Point(121, 110);
            this.txt_idGV.Name = "txt_idGV";
            this.txt_idGV.Size = new System.Drawing.Size(100, 22);
            this.txt_idGV.TabIndex = 9;
            // 
            // txt_tenMH
            // 
            this.txt_tenMH.Location = new System.Drawing.Point(121, 71);
            this.txt_tenMH.Name = "txt_tenMH";
            this.txt_tenMH.Size = new System.Drawing.Size(100, 22);
            this.txt_tenMH.TabIndex = 8;
            // 
            // txt_idMH
            // 
            this.txt_idMH.Location = new System.Drawing.Point(121, 37);
            this.txt_idMH.Name = "txt_idMH";
            this.txt_idMH.Size = new System.Drawing.Size(100, 22);
            this.txt_idMH.TabIndex = 7;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(16, 40);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(93, 17);
            this.lb_id.TabIndex = 6;
            this.lb_id.Text = "Mã môn học :";
            // 
            // lb_TenMonHoc
            // 
            this.lb_TenMonHoc.AutoSize = true;
            this.lb_TenMonHoc.Location = new System.Drawing.Point(16, 76);
            this.lb_TenMonHoc.Name = "lb_TenMonHoc";
            this.lb_TenMonHoc.Size = new System.Drawing.Size(99, 17);
            this.lb_TenMonHoc.TabIndex = 4;
            this.lb_TenMonHoc.Text = "Tên môn học :";
            // 
            // lb_IDGV
            // 
            this.lb_IDGV.AutoSize = true;
            this.lb_IDGV.Location = new System.Drawing.Point(17, 113);
            this.lb_IDGV.Name = "lb_IDGV";
            this.lb_IDGV.Size = new System.Drawing.Size(98, 17);
            this.lb_IDGV.TabIndex = 5;
            this.lb_IDGV.Text = "ID giảng viên :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_them);
            this.groupBox5.Controls.Add(this.btn_xoa);
            this.groupBox5.Controls.Add(this.btn_sua);
            this.groupBox5.Controls.Add(this.btn_reset);
            this.groupBox5.Location = new System.Drawing.Point(375, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(120, 148);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(24, 21);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(24, 50);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(24, 79);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(24, 107);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Courses";
            this.bindingSource1.DataSource = this.quanLyDiemDanhDataSet;
            // 
            // quanLyDiemDanhDataSet
            // 
            this.quanLyDiemDanhDataSet.DataSetName = "QuanLyDiemDanhDataSet";
            this.quanLyDiemDanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.TenMonHoc,
            this.GiangVienID,
            this.courseIDDataGridViewTextBoxColumn,
            this.tenMonHocDataGridViewTextBoxColumn,
            this.giangVienIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(69, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "Mã môn học";
            this.CourseID.MinimumWidth = 6;
            this.CourseID.Name = "CourseID";
            this.CourseID.Width = 125;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Tên Môn Học";
            this.TenMonHoc.MinimumWidth = 6;
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.Width = 125;
            // 
            // GiangVienID
            // 
            this.GiangVienID.DataPropertyName = "GiangVienID";
            this.GiangVienID.HeaderText = "ID giảng viên";
            this.GiangVienID.MinimumWidth = 6;
            this.GiangVienID.Name = "GiangVienID";
            this.GiangVienID.Width = 125;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenMonHocDataGridViewTextBoxColumn
            // 
            this.tenMonHocDataGridViewTextBoxColumn.DataPropertyName = "TenMonHoc";
            this.tenMonHocDataGridViewTextBoxColumn.HeaderText = "TenMonHoc";
            this.tenMonHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonHocDataGridViewTextBoxColumn.Name = "tenMonHocDataGridViewTextBoxColumn";
            this.tenMonHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // giangVienIDDataGridViewTextBoxColumn
            // 
            this.giangVienIDDataGridViewTextBoxColumn.DataPropertyName = "GiangVienID";
            this.giangVienIDDataGridViewTextBoxColumn.HeaderText = "GiangVienID";
            this.giangVienIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giangVienIDDataGridViewTextBoxColumn.Name = "giangVienIDDataGridViewTextBoxColumn";
            this.giangVienIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmQuanLyMonHoc
            // 
            this.ClientSize = new System.Drawing.Size(545, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyMonHoc";
            this.Load += new System.EventHandler(this.FrmQuanLyMonHoc_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_TenMonHoc;
        private System.Windows.Forms.Label lb_IDGV;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox txt_idGV;
        private System.Windows.Forms.TextBox txt_tenMH;
        private System.Windows.Forms.TextBox txt_idMH;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_reset;
        private QuanLyDiemDanhDataSet quanLyDiemDanhDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QuanLyDiemDanhDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiangVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangVienIDDataGridViewTextBoxColumn;
    }
}