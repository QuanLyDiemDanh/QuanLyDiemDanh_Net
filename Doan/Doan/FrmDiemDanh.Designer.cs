
namespace Doan
{
    partial class FrmDiemDanh
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_DiemDanh = new System.Windows.Forms.DataGridView();
            this.quanLyDiemDanhSVDataSet = new Doan.QuanLyDiemDanhSVDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Doan.QuanLyDiemDanhSVDataSetTableAdapters.ClassesTableAdapter();
            this.quanLyDiemDanhSVDataSet3 = new Doan.QuanLyDiemDanhSVDataSet3();
            this.quanLyDiemDanhSVDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new Doan.QuanLyDiemDanhSVDataSet3TableAdapters.AttendanceTableAdapter();
            this.quanLyDiemDanhSVDataSet4 = new Doan.QuanLyDiemDanhSVDataSet4();
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter1 = new Doan.QuanLyDiemDanhSVDataSet4TableAdapters.AttendanceTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhSVDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhSVDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhSVDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.classesBindingSource;
            this.comboBox1.DisplayMember = "NgayHoc";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "NgayHoc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày";
            // 
            // dataGridView_DiemDanh
            // 
            this.dataGridView_DiemDanh.AutoGenerateColumns = false;
            this.dataGridView_DiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView_DiemDanh.DataSource = this.attendanceBindingSource1;
            this.dataGridView_DiemDanh.Location = new System.Drawing.Point(27, 214);
            this.dataGridView_DiemDanh.Name = "dataGridView_DiemDanh";
            this.dataGridView_DiemDanh.RowHeadersWidth = 51;
            this.dataGridView_DiemDanh.RowTemplate.Height = 24;
            this.dataGridView_DiemDanh.Size = new System.Drawing.Size(761, 150);
            this.dataGridView_DiemDanh.TabIndex = 2;
            this.dataGridView_DiemDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DiemDanh_CellContentClick);
            // 
            // quanLyDiemDanhSVDataSet
            // 
            this.quanLyDiemDanhSVDataSet.DataSetName = "QuanLyDiemDanhSVDataSet";
            this.quanLyDiemDanhSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.quanLyDiemDanhSVDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyDiemDanhSVDataSet3
            // 
            this.quanLyDiemDanhSVDataSet3.DataSetName = "QuanLyDiemDanhSVDataSet3";
            this.quanLyDiemDanhSVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyDiemDanhSVDataSet3BindingSource
            // 
            this.quanLyDiemDanhSVDataSet3BindingSource.DataSource = this.quanLyDiemDanhSVDataSet3;
            this.quanLyDiemDanhSVDataSet3BindingSource.Position = 0;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.quanLyDiemDanhSVDataSet3BindingSource;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyDiemDanhSVDataSet4
            // 
            this.quanLyDiemDanhSVDataSet4.DataSetName = "QuanLyDiemDanhSVDataSet4";
            this.quanLyDiemDanhSVDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataMember = "Attendance";
            this.attendanceBindingSource1.DataSource = this.quanLyDiemDanhSVDataSet4;
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.classIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            this.classIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_DiemDanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmDiemDanh";
            this.Text = "FrmDiemDanh";
            this.Load += new System.EventHandler(this.FrmDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhSVDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhSVDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDanhSVDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_DiemDanh;
        private QuanLyDiemDanhSVDataSet quanLyDiemDanhSVDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private QuanLyDiemDanhSVDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource quanLyDiemDanhSVDataSet3BindingSource;
        private QuanLyDiemDanhSVDataSet3 quanLyDiemDanhSVDataSet3;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private QuanLyDiemDanhSVDataSet3TableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private QuanLyDiemDanhSVDataSet4 quanLyDiemDanhSVDataSet4;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private QuanLyDiemDanhSVDataSet4TableAdapters.AttendanceTableAdapter attendanceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}