
using System;

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
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuanLySV = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsQuanLySV,
            this.tsDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnToolStripMenuItem
            // 
            this.quảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThemGV,
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.quảnToolStripMenuItem.Image = global::Doan.Properties.Resources.green;
            this.quảnToolStripMenuItem.Name = "quảnToolStripMenuItem";
            this.quảnToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.quảnToolStripMenuItem.Text = "Quản Lý Giảng Viên";
            this.quảnToolStripMenuItem.Click += new System.EventHandler(this.quảnToolStripMenuItem_Click);
            // 
            // tsThemGV
            // 
            this.tsThemGV.Name = "tsThemGV";
            this.tsThemGV.Size = new System.Drawing.Size(262, 26);
            this.tsThemGV.Text = "Thêm,Xóa,Sửa Giảng Viên";
            this.tsThemGV.Click += new System.EventHandler(this.tsThemGV_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản Lý Tài Khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânCôngGiảngViênToolStripMenuItem,
            this.quảnLýLớpHọcToolStripMenuItem1,
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem});
            this.quảnLýLớpHọcToolStripMenuItem.Image = global::Doan.Properties.Resources.blue;
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản Lý Lớp Học,Môn Học";
            this.quảnLýLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpHọcToolStripMenuItem_Click);
            // 
            // phânCôngGiảngViênToolStripMenuItem
            // 
            this.phânCôngGiảngViênToolStripMenuItem.Name = "phânCôngGiảngViênToolStripMenuItem";
            this.phânCôngGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.phânCôngGiảngViênToolStripMenuItem.Text = "Quản Lý Môn Học";
            this.phânCôngGiảngViênToolStripMenuItem.Click += new System.EventHandler(this.phânCôngGiảngViênToolStripMenuItem_Click);
            // 
            // quảnLýLớpHọcToolStripMenuItem1
            // 
            this.quảnLýLớpHọcToolStripMenuItem1.Name = "quảnLýLớpHọcToolStripMenuItem1";
            this.quảnLýLớpHọcToolStripMenuItem1.Size = new System.Drawing.Size(301, 26);
            this.quảnLýLớpHọcToolStripMenuItem1.Text = "Quản Lý Lớp Học";
            this.quảnLýLớpHọcToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýLớpHọcToolStripMenuItem1_Click);
            // 
            // tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem
            // 
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem.Name = "tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem";
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem.Text = "Tạo và xem báo cáo điểm danh";
            this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem.Click += new System.EventHandler(this.tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem_Click);
            // 
            // tsQuanLySV
            // 
            this.tsQuanLySV.Image = global::Doan.Properties.Resources.cooldownpink;
            this.tsQuanLySV.Name = "tsQuanLySV";
            this.tsQuanLySV.Size = new System.Drawing.Size(160, 24);
            this.tsQuanLySV.Text = "Quản Lý Sinh Viên";
            this.tsQuanLySV.Click += new System.EventHandler(this.tsQuanLySV_Click);
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 575);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ ĐIỂM DANH";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void QuảnLýLớpHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsThemGV;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoVàXemBáoCáoĐiểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsQuanLySV;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem1;
    }
}