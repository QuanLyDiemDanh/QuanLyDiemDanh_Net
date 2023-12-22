
using System;

namespace DoAn
{
    partial class FrmKhoa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsQuanLySV,
            this.tsDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnToolStripMenuItem
            // 
            this.quảnToolStripMenuItem.Name = "quảnToolStripMenuItem";
            this.quảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.quảnToolStripMenuItem.Text = "Quản Lý Giảng Viên";
            this.quảnToolStripMenuItem.Click += new System.EventHandler(this.quảnToolStripMenuItem_Click);
            // 
            // tsQuanLySV
            // 
            this.tsQuanLySV.Name = "tsQuanLySV";
            this.tsQuanLySV.Size = new System.Drawing.Size(140, 24);
            this.tsQuanLySV.Text = "Quản Lý Sinh Viên";
            this.tsQuanLySV.Click += new System.EventHandler(this.tsQuanLySV_Click);
            // 
            // tsDangXuat
            // 
            this.tsDangXuat.Name = "tsDangXuat";
            this.tsDangXuat.Size = new System.Drawing.Size(91, 24);
            this.tsDangXuat.Text = "Đăng xuất";
            this.tsDangXuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // FrmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 575);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmKhoa";
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
        private System.Windows.Forms.ToolStripMenuItem tsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsQuanLySV;
    }
}