
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_DiemDanh = new System.Windows.Forms.DataGridView();
            this.colMaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
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
            this.dataGridView_DiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSinhVien,
            this.ColMaMH,
            this.ColNgayHoc,
            this.ColTT});
            this.dataGridView_DiemDanh.Location = new System.Drawing.Point(27, 214);
            this.dataGridView_DiemDanh.Name = "dataGridView_DiemDanh";
            this.dataGridView_DiemDanh.RowHeadersWidth = 51;
            this.dataGridView_DiemDanh.RowTemplate.Height = 24;
            this.dataGridView_DiemDanh.Size = new System.Drawing.Size(740, 150);
            this.dataGridView_DiemDanh.TabIndex = 2;
            this.dataGridView_DiemDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DiemDanh_CellContentClick);
            // 
            // colMaSinhVien
            // 
            this.colMaSinhVien.HeaderText = "Mã số sinh viên";
            this.colMaSinhVien.MinimumWidth = 6;
            this.colMaSinhVien.Name = "colMaSinhVien";
            this.colMaSinhVien.Width = 125;
            // 
            // ColMaMH
            // 
            this.ColMaMH.HeaderText = "Mã môn học";
            this.ColMaMH.MinimumWidth = 6;
            this.ColMaMH.Name = "ColMaMH";
            this.ColMaMH.Width = 125;
            // 
            // ColNgayHoc
            // 
            this.ColNgayHoc.HeaderText = "Ngày học";
            this.ColNgayHoc.MinimumWidth = 6;
            this.ColNgayHoc.Name = "ColNgayHoc";
            this.ColNgayHoc.Width = 125;
            // 
            // ColTT
            // 
            this.ColTT.HeaderText = "Trạng Thái";
            this.ColTT.Items.AddRange(new object[] {
            "Vắng có phép",
            "Vắng không phép",
            "Có mặt"});
            this.ColTT.MinimumWidth = 6;
            this.ColTT.Name = "ColTT";
            this.ColTT.Width = 125;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_DiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTT;
    }
}