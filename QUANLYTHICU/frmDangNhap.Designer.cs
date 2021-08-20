
namespace QUANLYTHICU
{
    partial class frmDangNhap
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
            System.Windows.Forms.TextBox txtMatKhau;
            this.lblTiêuđề = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangnhap = new System.Windows.Forms.Button();
            txtMatKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = System.Drawing.Color.Snow;
            txtMatKhau.Location = new System.Drawing.Point(281, 338);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new System.Drawing.Size(200, 20);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblTiêuđề
            // 
            this.lblTiêuđề.AutoSize = true;
            this.lblTiêuđề.BackColor = System.Drawing.Color.Transparent;
            this.lblTiêuđề.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTiêuđề.Location = new System.Drawing.Point(123, 22);
            this.lblTiêuđề.Name = "lblTiêuđề";
            this.lblTiêuđề.Size = new System.Drawing.Size(493, 41);
            this.lblTiêuđề.TabIndex = 0;
            this.lblTiêuđề.Text = "QUẢN LÝ HỆ THỐNG THI CỬ";
            this.lblTiêuđề.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.Snow;
            this.txtTenDangNhap.Location = new System.Drawing.Point(281, 273);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(200, 20);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::QUANLYTHICU.Properties.Resources.icon_login1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(281, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 88);
            this.panel1.TabIndex = 6;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(319, 388);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(125, 50);
            this.btnDangnhap.TabIndex = 7;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::QUANLYTHICU.Properties.Resources.img_login;
            this.ClientSize = new System.Drawing.Size(718, 540);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(txtMatKhau);
            this.Controls.Add(this.lblTiêuđề);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiêuđề;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangnhap;
    }
}

