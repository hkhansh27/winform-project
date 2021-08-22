
namespace QUANLYTHICU
{
    partial class frmQuanTriMonHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCauHoiNavigation = new System.Windows.Forms.Label();
            this.lblHocSinhNavigation = new System.Windows.Forms.Label();
            this.lblMonHocNavigation = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoiMonHoc = new System.Windows.Forms.Button();
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.btnThemSuaMonHoc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCauHoiNavigation);
            this.panel1.Controls.Add(this.lblHocSinhNavigation);
            this.panel1.Controls.Add(this.lblMonHocNavigation);
            this.panel1.Location = new System.Drawing.Point(2, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 64);
            this.panel1.TabIndex = 5;
            // 
            // lblCauHoiNavigation
            // 
            this.lblCauHoiNavigation.AutoSize = true;
            this.lblCauHoiNavigation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCauHoiNavigation.Location = new System.Drawing.Point(479, 15);
            this.lblCauHoiNavigation.Name = "lblCauHoiNavigation";
            this.lblCauHoiNavigation.Size = new System.Drawing.Size(95, 24);
            this.lblCauHoiNavigation.TabIndex = 0;
            this.lblCauHoiNavigation.Text = "CÂU HỎI";
            // 
            // lblHocSinhNavigation
            // 
            this.lblHocSinhNavigation.AutoSize = true;
            this.lblHocSinhNavigation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocSinhNavigation.Location = new System.Drawing.Point(752, 15);
            this.lblHocSinhNavigation.Name = "lblHocSinhNavigation";
            this.lblHocSinhNavigation.Size = new System.Drawing.Size(108, 24);
            this.lblHocSinhNavigation.TabIndex = 3;
            this.lblHocSinhNavigation.Text = "HỌC SINH";
            // 
            // lblMonHocNavigation
            // 
            this.lblMonHocNavigation.AutoSize = true;
            this.lblMonHocNavigation.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMonHocNavigation.Location = new System.Drawing.Point(603, 10);
            this.lblMonHocNavigation.Name = "lblMonHocNavigation";
            this.lblMonHocNavigation.Size = new System.Drawing.Size(128, 29);
            this.lblMonHocNavigation.TabIndex = 2;
            this.lblMonHocNavigation.Text = "MÔN HỌC";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(528, 150);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 1);
            this.panel3.TabIndex = 9;
            // 
            // txtTenMon
            // 
            this.txtTenMon.BackColor = System.Drawing.Color.Gold;
            this.txtTenMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenMon.Location = new System.Drawing.Point(528, 132);
            this.txtTenMon.Multiline = true;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(292, 20);
            this.txtTenMon.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên môn";
            // 
            // btnLamMoiMonHoc
            // 
            this.btnLamMoiMonHoc.BackColor = System.Drawing.Color.White;
            this.btnLamMoiMonHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiMonHoc.Location = new System.Drawing.Point(783, 208);
            this.btnLamMoiMonHoc.Margin = new System.Windows.Forms.Padding(1);
            this.btnLamMoiMonHoc.Name = "btnLamMoiMonHoc";
            this.btnLamMoiMonHoc.Size = new System.Drawing.Size(150, 30);
            this.btnLamMoiMonHoc.TabIndex = 24;
            this.btnLamMoiMonHoc.Text = "Làm mới";
            this.btnLamMoiMonHoc.UseVisualStyleBackColor = false;
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.BackColor = System.Drawing.Color.White;
            this.btnXoaMonHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMonHoc.Location = new System.Drawing.Point(602, 209);
            this.btnXoaMonHoc.Margin = new System.Windows.Forms.Padding(1);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(150, 30);
            this.btnXoaMonHoc.TabIndex = 23;
            this.btnXoaMonHoc.Text = "Xoá";
            this.btnXoaMonHoc.UseVisualStyleBackColor = false;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaMonHoc_Click);
            // 
            // btnThemSuaMonHoc
            // 
            this.btnThemSuaMonHoc.BackColor = System.Drawing.Color.White;
            this.btnThemSuaMonHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSuaMonHoc.Location = new System.Drawing.Point(424, 208);
            this.btnThemSuaMonHoc.Margin = new System.Windows.Forms.Padding(1);
            this.btnThemSuaMonHoc.Name = "btnThemSuaMonHoc";
            this.btnThemSuaMonHoc.Size = new System.Drawing.Size(150, 30);
            this.btnThemSuaMonHoc.TabIndex = 22;
            this.btnThemSuaMonHoc.Text = "Thêm/Sửa";
            this.btnThemSuaMonHoc.UseVisualStyleBackColor = false;
            this.btnThemSuaMonHoc.Click += new System.EventHandler(this.btnThemSuaMonHoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "DANH SÁCH MÔN HỌC";
            // 
            // dgvDanhSachMonHoc
            // 
            this.dgvDanhSachMonHoc.AllowUserToAddRows = false;
            this.dgvDanhSachMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachMonHoc.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvDanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenMon,
            this.idMH});
            this.dgvDanhSachMonHoc.Location = new System.Drawing.Point(2, 264);
            this.dgvDanhSachMonHoc.Name = "dgvDanhSachMonHoc";
            this.dgvDanhSachMonHoc.Size = new System.Drawing.Size(1345, 556);
            this.dgvDanhSachMonHoc.TabIndex = 26;
            this.dgvDanhSachMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMonHoc_CellClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // tenMon
            // 
            this.tenMon.HeaderText = "Tên môn";
            this.tenMon.Name = "tenMon";
            // 
            // idMH
            // 
            this.idMH.HeaderText = "ID Môn học";
            this.idMH.Name = "idMH";
            this.idMH.Visible = false;
            // 
            // frmQuanTriMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1348, 821);
            this.Controls.Add(this.dgvDanhSachMonHoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLamMoiMonHoc);
            this.Controls.Add(this.btnXoaMonHoc);
            this.Controls.Add(this.btnThemSuaMonHoc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmQuanTriMonHoc";
            this.Text = "QUẢN TRỊ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCauHoiNavigation;
        private System.Windows.Forms.Label lblHocSinhNavigation;
        private System.Windows.Forms.Label lblMonHocNavigation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoiMonHoc;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.Button btnThemSuaMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDanhSachMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMH;
    }
}