
namespace QUANLYTHICU
{
    partial class frmQuanTriKetQua
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
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKetQua);
            this.panel1.Controls.Add(this.lblCauHoiNavigation);
            this.panel1.Controls.Add(this.lblHocSinhNavigation);
            this.panel1.Controls.Add(this.lblMonHocNavigation);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 64);
            this.panel1.TabIndex = 5;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblKetQua.Location = new System.Drawing.Point(859, 12);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(120, 29);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "KẾT QUẢ";
            // 
            // lblCauHoiNavigation
            // 
            this.lblCauHoiNavigation.AutoSize = true;
            this.lblCauHoiNavigation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCauHoiNavigation.Location = new System.Drawing.Point(413, 17);
            this.lblCauHoiNavigation.Name = "lblCauHoiNavigation";
            this.lblCauHoiNavigation.Size = new System.Drawing.Size(95, 24);
            this.lblCauHoiNavigation.TabIndex = 0;
            this.lblCauHoiNavigation.Text = "CÂU HỎI";
            this.lblCauHoiNavigation.Click += new System.EventHandler(this.lblCauHoiNavigation_Click);
            // 
            // lblHocSinhNavigation
            // 
            this.lblHocSinhNavigation.AutoSize = true;
            this.lblHocSinhNavigation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocSinhNavigation.Location = new System.Drawing.Point(723, 17);
            this.lblHocSinhNavigation.Name = "lblHocSinhNavigation";
            this.lblHocSinhNavigation.Size = new System.Drawing.Size(108, 24);
            this.lblHocSinhNavigation.TabIndex = 3;
            this.lblHocSinhNavigation.Text = "HỌC SINH";
            this.lblHocSinhNavigation.Click += new System.EventHandler(this.lblHocSinhNavigation_Click);
            // 
            // lblMonHocNavigation
            // 
            this.lblMonHocNavigation.AutoSize = true;
            this.lblMonHocNavigation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMonHocNavigation.Location = new System.Drawing.Point(574, 17);
            this.lblMonHocNavigation.Name = "lblMonHocNavigation";
            this.lblMonHocNavigation.Size = new System.Drawing.Size(108, 24);
            this.lblMonHocNavigation.TabIndex = 2;
            this.lblMonHocNavigation.Text = "MÔN HỌC";
            this.lblMonHocNavigation.Click += new System.EventHandler(this.lblMonHocNavigation_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.hocSinh,
            this.monThi,
            this.diem,
            this.trangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQua.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKetQua.Location = new System.Drawing.Point(1, 198);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(1352, 628);
            this.dgvKetQua.TabIndex = 23;
            // 
            // stt
            // 
            this.stt.FillWeight = 50.76142F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // hocSinh
            // 
            this.hocSinh.HeaderText = "Học sinh";
            this.hocSinh.Name = "hocSinh";
            this.hocSinh.ReadOnly = true;
            // 
            // monThi
            // 
            this.monThi.HeaderText = "Môn thi";
            this.monThi.Name = "monThi";
            this.monThi.ReadOnly = true;
            // 
            // diem
            // 
            this.diem.HeaderText = "Điểm";
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "KẾT QUẢ";
            // 
            // frmQuanTriKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1348, 821);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmQuanTriKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN TRỊ";
            this.Load += new System.EventHandler(this.frmQuanTriKetQua_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblCauHoiNavigation;
        private System.Windows.Forms.Label lblHocSinhNavigation;
        private System.Windows.Forms.Label lblMonHocNavigation;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn monThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}