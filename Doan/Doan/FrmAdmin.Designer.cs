
namespace Doan
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThemGV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXoaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUpdateGV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPhanCongGV = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuanLySV = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gánSinhViênVàoLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnToolStripMenuItem,
            this.quảnLýLớpHọcToolStripMenuItem,
            this.tsQLTK,
            this.tsQuanLySV,
            this.tsDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnToolStripMenuItem
            // 
            this.quảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThemGV,
            this.tsXoaGV,
            this.tsUpdateGV,
            this.tsPhanCongGV});
            this.quảnToolStripMenuItem.Image = global::Doan.Properties.Resources.green;
            this.quảnToolStripMenuItem.Name = "quảnToolStripMenuItem";
            this.quảnToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.quảnToolStripMenuItem.Text = "Quản Lý Giảng Viên";
            this.quảnToolStripMenuItem.Click += new System.EventHandler(this.quảnToolStripMenuItem_Click);
            // 
            // tsThemGV
            // 
            this.tsThemGV.Name = "tsThemGV";
            this.tsThemGV.Size = new System.Drawing.Size(257, 26);
            this.tsThemGV.Text = "Thêm Giảng Viên";
            // 
            // tsXoaGV
            // 
            this.tsXoaGV.Name = "tsXoaGV";
            this.tsXoaGV.Size = new System.Drawing.Size(257, 26);
            this.tsXoaGV.Text = "Xóa Giảng Viên";
            // 
            // tsUpdateGV
            // 
            this.tsUpdateGV.Name = "tsUpdateGV";
            this.tsUpdateGV.Size = new System.Drawing.Size(257, 26);
            this.tsUpdateGV.Text = "Sửa thông tin Giảng Viên";
            // 
            // tsPhanCongGV
            // 
            this.tsPhanCongGV.Name = "tsPhanCongGV";
            this.tsPhanCongGV.Size = new System.Drawing.Size(257, 26);
            this.tsPhanCongGV.Text = "Phân công Giảng Viên";
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânCôngGiảngViênToolStripMenuItem,
            this.sửaThôngTinLớpHọcToolStripMenuItem,
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem});
            this.quảnLýLớpHọcToolStripMenuItem.Image = global::Doan.Properties.Resources.blue;
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản Lý Lớp Học";
            // 
            // phânCôngGiảngViênToolStripMenuItem
            // 
            this.phânCôngGiảngViênToolStripMenuItem.Name = "phânCôngGiảngViênToolStripMenuItem";
            this.phânCôngGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.phânCôngGiảngViênToolStripMenuItem.Text = "Thêm Lớp Học";
            this.phânCôngGiảngViênToolStripMenuItem.Click += new System.EventHandler(this.phânCôngGiảngViênToolStripMenuItem_Click);
            // 
            // sửaThôngTinLớpHọcToolStripMenuItem
            // 
            this.sửaThôngTinLớpHọcToolStripMenuItem.Name = "sửaThôngTinLớpHọcToolStripMenuItem";
            this.sửaThôngTinLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.sửaThôngTinLớpHọcToolStripMenuItem.Text = "Sửa thông tin Lớp Học";
            // 
            // tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem
            // 
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem.Name = "tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem";
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem.Text = "Tạo và xem báo cáo điểm danh";
            // 
            // tsQLTK
            // 
            this.tsQLTK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem,
            this.quảnLýTàiKhoảnSinhVienToolStripMenuItem});
            this.tsQLTK.Image = global::Doan.Properties.Resources.pexels_codioful__formerly_gradienta__7135019;
            this.tsQLTK.Name = "tsQLTK";
            this.tsQLTK.Size = new System.Drawing.Size(163, 24);
            this.tsQLTK.Text = "Quản Lý Tài Khoản";
            // 
            // quảnLýTàiKhoảnGiảngViênToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem.Name = "quảnLýTàiKhoảnGiảngViênToolStripMenuItem";
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.quảnLýTàiKhoảnGiảngViênToolStripMenuItem.Text = "Quản Lý Tài Khoản Giảng Viên";
            // 
            // quảnLýTàiKhoảnSinhVienToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnSinhVienToolStripMenuItem.Name = "quảnLýTàiKhoảnSinhVienToolStripMenuItem";
            this.quảnLýTàiKhoảnSinhVienToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.quảnLýTàiKhoảnSinhVienToolStripMenuItem.Text = "Quản Lý Tài Khoản Sinh Viên";
            this.quảnLýTàiKhoảnSinhVienToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnSinhVienToolStripMenuItem_Click);
            // 
            // tsQuanLySV
            // 
            this.tsQuanLySV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSinhViênToolStripMenuItem,
            this.xóaSinhViênToolStripMenuItem,
            this.sửaThôngTinSinhViênToolStripMenuItem,
            this.gánSinhViênVàoLớpHọcToolStripMenuItem});
            this.tsQuanLySV.Image = global::Doan.Properties.Resources.cooldownpink;
            this.tsQuanLySV.Name = "tsQuanLySV";
            this.tsQuanLySV.Size = new System.Drawing.Size(160, 24);
            this.tsQuanLySV.Text = "Quản Lý Sinh Viên";
            // 
            // thêmSinhViênToolStripMenuItem
            // 
            this.thêmSinhViênToolStripMenuItem.Name = "thêmSinhViênToolStripMenuItem";
            this.thêmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.thêmSinhViênToolStripMenuItem.Text = "Thêm sinh viên";
            // 
            // xóaSinhViênToolStripMenuItem
            // 
            this.xóaSinhViênToolStripMenuItem.Name = "xóaSinhViênToolStripMenuItem";
            this.xóaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.xóaSinhViênToolStripMenuItem.Text = "Xóa Sinh Viên";
            // 
            // sửaThôngTinSinhViênToolStripMenuItem
            // 
            this.sửaThôngTinSinhViênToolStripMenuItem.Name = "sửaThôngTinSinhViênToolStripMenuItem";
            this.sửaThôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.sửaThôngTinSinhViênToolStripMenuItem.Text = "Sửa thông tin Sinh Viên";
            // 
            // gánSinhViênVàoLớpHọcToolStripMenuItem
            // 
            this.gánSinhViênVàoLớpHọcToolStripMenuItem.Name = "gánSinhViênVàoLớpHọcToolStripMenuItem";
            this.gánSinhViênVàoLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.gánSinhViênVàoLớpHọcToolStripMenuItem.Text = "Gán Sinh Viên vào lớp học";
            // 
            // tsDangXuat
            // 
            this.tsDangXuat.Image = global::Doan.Properties.Resources.logout;
            this.tsDangXuat.Name = "tsDangXuat";
            this.tsDangXuat.Size = new System.Drawing.Size(111, 24);
            this.tsDangXuat.Text = "Đăng xuất";
            this.tsDangXuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 575);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ ĐIỂM DANH";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsThemGV;
        private System.Windows.Forms.ToolStripMenuItem tsXoaGV;
        private System.Windows.Forms.ToolStripMenuItem tsUpdateGV;
        private System.Windows.Forms.ToolStripMenuItem tsPhanCongGV;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsQLTK;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsQuanLySV;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gánSinhViênVàoLớpHọcToolStripMenuItem;
    }
}