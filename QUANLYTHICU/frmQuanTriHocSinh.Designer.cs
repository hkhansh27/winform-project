
namespace QUANLYTHICU
{
    partial class frmQuanTriHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblCauHoiNavigation = new System.Windows.Forms.Label();
            this.lblHocSinhNavigation = new System.Windows.Forms.Label();
            this.lblMonHocNavigation = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamMoiHocSinh = new System.Windows.Forms.Button();
            this.btnXoaHocSinh = new System.Windows.Forms.Button();
            this.btnThemSuaHocSinh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKetQua);
            this.panel1.Controls.Add(this.lblCauHoiNavigation);
            this.panel1.Controls.Add(this.lblHocSinhNavigation);
            this.panel1.Controls.Add(this.lblMonHocNavigation);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 64);
            this.panel1.TabIndex = 5;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKetQua.Location = new System.Drawing.Point(870, 16);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(103, 24);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "KẾT QUẢ";
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // lblCauHoiNavigation
            // 
            this.lblCauHoiNavigation.AutoSize = true;
            this.lblCauHoiNavigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCauHoiNavigation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCauHoiNavigation.Location = new System.Drawing.Point(438, 16);
            this.lblCauHoiNavigation.Name = "lblCauHoiNavigation";
            this.lblCauHoiNavigation.Size = new System.Drawing.Size(95, 24);
            this.lblCauHoiNavigation.TabIndex = 0;
            this.lblCauHoiNavigation.Text = "CÂU HỎI";
            this.lblCauHoiNavigation.Click += new System.EventHandler(this.lblCauHoiNavigation_Click);
            // 
            // lblHocSinhNavigation
            // 
            this.lblHocSinhNavigation.AutoSize = true;
            this.lblHocSinhNavigation.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocSinhNavigation.Location = new System.Drawing.Point(711, 12);
            this.lblHocSinhNavigation.Name = "lblHocSinhNavigation";
            this.lblHocSinhNavigation.Size = new System.Drawing.Size(129, 29);
            this.lblHocSinhNavigation.TabIndex = 3;
            this.lblHocSinhNavigation.Text = "HỌC SINH";
            // 
            // lblMonHocNavigation
            // 
            this.lblMonHocNavigation.AutoSize = true;
            this.lblMonHocNavigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonHocNavigation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMonHocNavigation.Location = new System.Drawing.Point(574, 16);
            this.lblMonHocNavigation.Name = "lblMonHocNavigation";
            this.lblMonHocNavigation.Size = new System.Drawing.Size(108, 24);
            this.lblMonHocNavigation.TabIndex = 2;
            this.lblMonHocNavigation.Text = "MÔN HỌC";
            this.lblMonHocNavigation.Click += new System.EventHandler(this.lblMonHocNavigation_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(121, 141);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 1);
            this.panel3.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.Gold;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(121, 123);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(292, 20);
            this.txtHoTen.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ và tên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(522, 141);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 1);
            this.panel2.TabIndex = 15;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.Gold;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(522, 123);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(292, 20);
            this.txtTenDangNhap.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên đăng nhập";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(935, 141);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 1);
            this.panel4.TabIndex = 18;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Gold;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMatKhau.Location = new System.Drawing.Point(935, 123);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(292, 20);
            this.txtMatKhau.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1026, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mật khẩu";
            // 
            // btnLamMoiHocSinh
            // 
            this.btnLamMoiHocSinh.BackColor = System.Drawing.Color.White;
            this.btnLamMoiHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiHocSinh.Location = new System.Drawing.Point(741, 192);
            this.btnLamMoiHocSinh.Margin = new System.Windows.Forms.Padding(1);
            this.btnLamMoiHocSinh.Name = "btnLamMoiHocSinh";
            this.btnLamMoiHocSinh.Size = new System.Drawing.Size(150, 30);
            this.btnLamMoiHocSinh.TabIndex = 24;
            this.btnLamMoiHocSinh.Text = "Làm mới";
            this.btnLamMoiHocSinh.UseVisualStyleBackColor = false;
            this.btnLamMoiHocSinh.Click += new System.EventHandler(this.btnLamMoiHocSinh_Click);
            // 
            // btnXoaHocSinh
            // 
            this.btnXoaHocSinh.BackColor = System.Drawing.Color.White;
            this.btnXoaHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHocSinh.Location = new System.Drawing.Point(560, 193);
            this.btnXoaHocSinh.Margin = new System.Windows.Forms.Padding(1);
            this.btnXoaHocSinh.Name = "btnXoaHocSinh";
            this.btnXoaHocSinh.Size = new System.Drawing.Size(150, 30);
            this.btnXoaHocSinh.TabIndex = 23;
            this.btnXoaHocSinh.Text = "Xoá";
            this.btnXoaHocSinh.UseVisualStyleBackColor = false;
            this.btnXoaHocSinh.Click += new System.EventHandler(this.btnXoaHocSinh_Click);
            // 
            // btnThemSuaHocSinh
            // 
            this.btnThemSuaHocSinh.BackColor = System.Drawing.Color.White;
            this.btnThemSuaHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSuaHocSinh.Location = new System.Drawing.Point(382, 192);
            this.btnThemSuaHocSinh.Margin = new System.Windows.Forms.Padding(1);
            this.btnThemSuaHocSinh.Name = "btnThemSuaHocSinh";
            this.btnThemSuaHocSinh.Size = new System.Drawing.Size(150, 30);
            this.btnThemSuaHocSinh.TabIndex = 22;
            this.btnThemSuaHocSinh.Text = "Thêm/Sửa";
            this.btnThemSuaHocSinh.UseVisualStyleBackColor = false;
            this.btnThemSuaHocSinh.Click += new System.EventHandler(this.btnThemSuaHocSinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "DANH SÁCH HỌC SINH";
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.AllowUserToAddRows = false;
            this.dgvDanhSachHocSinh.AllowUserToDeleteRows = false;
            this.dgvDanhSachHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHocSinh.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvDanhSachHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachHocSinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.hoVaTen,
            this.tenDangNhap,
            this.matKhau,
            this.idHS});
            this.dgvDanhSachHocSinh.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachHocSinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(0, 279);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.ReadOnly = true;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(1345, 615);
            this.dgvDanhSachHocSinh.TabIndex = 26;
            this.dgvDanhSachHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHocSinh_CellClick);
            // 
            // stt
            // 
            this.stt.FillWeight = 50.76142F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // hoVaTen
            // 
            this.hoVaTen.FillWeight = 149.2386F;
            this.hoVaTen.HeaderText = "Họ và tên";
            this.hoVaTen.Name = "hoVaTen";
            this.hoVaTen.ReadOnly = true;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.FillWeight = 149.2386F;
            this.tenDangNhap.HeaderText = "Tên đăng nhập";
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.ReadOnly = true;
            // 
            // matKhau
            // 
            this.matKhau.FillWeight = 149.2386F;
            this.matKhau.HeaderText = "Mật khẩu";
            this.matKhau.Name = "matKhau";
            this.matKhau.ReadOnly = true;
            // 
            // idHS
            // 
            this.idHS.HeaderText = "IDHS";
            this.idHS.Name = "idHS";
            this.idHS.ReadOnly = true;
            this.idHS.Visible = false;
            // 
            // frmQuanTriHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1348, 821);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLamMoiHocSinh);
            this.Controls.Add(this.btnXoaHocSinh);
            this.Controls.Add(this.btnThemSuaHocSinh);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmQuanTriHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN TRỊ";
            this.Load += new System.EventHandler(this.FrmQuanTriHocSinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCauHoiNavigation;
        private System.Windows.Forms.Label lblHocSinhNavigation;
        private System.Windows.Forms.Label lblMonHocNavigation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoiHocSinh;
        private System.Windows.Forms.Button btnXoaHocSinh;
        private System.Windows.Forms.Button btnThemSuaHocSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHS;
        private System.Windows.Forms.Label lblKetQua;
    }
}