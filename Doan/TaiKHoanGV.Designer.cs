namespace DoAn
{
    partial class TaiKHoanGV
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
            this.butCN = new System.Windows.Forms.Button();
            this.butT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTD = new System.Windows.Forms.TextBox();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trinh Độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật Khẩu ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên GV";
            // 
            // butCN
            // 
            this.butCN.Location = new System.Drawing.Point(349, 385);
            this.butCN.Name = "butCN";
            this.butCN.Size = new System.Drawing.Size(111, 23);
            this.butCN.TabIndex = 5;
            this.butCN.Text = "Cập Nhập";
            this.butCN.UseVisualStyleBackColor = true;
            // 
            // butT
            // 
            this.butT.Location = new System.Drawing.Point(548, 385);
            this.butT.Name = "butT";
            this.butT.Size = new System.Drawing.Size(75, 23);
            this.butT.TabIndex = 6;
            this.butT.Text = "Thoat";
            this.butT.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chuyên Môn";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(266, 93);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(237, 22);
            this.txtMa.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(266, 205);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(237, 22);
            this.txtTen.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(266, 151);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(237, 22);
            this.txtPass.TabIndex = 10;
            // 
            // txtTD
            // 
            this.txtTD.Location = new System.Drawing.Point(266, 268);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(237, 22);
            this.txtTD.TabIndex = 11;
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(266, 331);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(237, 22);
            this.txtCM.TabIndex = 12;
            // 
            // TaiKHoanGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.txtTD);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butT);
            this.Controls.Add(this.butCN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaiKHoanGV";
            this.Text = "TaiKHoanGV";
            this.Load += new System.EventHandler(this.TaiKHoanGV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butCN;
        private System.Windows.Forms.Button butT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTD;
        private System.Windows.Forms.TextBox txtCM;
    }
}