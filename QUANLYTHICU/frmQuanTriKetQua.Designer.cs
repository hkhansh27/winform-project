
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblCauHoiNavigation = new System.Windows.Forms.Label();
            this.lblHocSinhNavigation = new System.Windows.Forms.Label();
            this.lblMonHocNavigation = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonThi = new System.Windows.Forms.ComboBox();
            this.cbHocSinh = new System.Windows.Forms.ComboBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.hocSinh,
            this.monThi,
            this.diem,
            this.trangThai});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQua.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKetQua.Location = new System.Drawing.Point(1, 228);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(1352, 598);
            this.dgvKetQua.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "KẾT QUẢ";
            // 
            // cbMonThi
            // 
            this.cbMonThi.FormattingEnabled = true;
            this.cbMonThi.Location = new System.Drawing.Point(315, 150);
            this.cbMonThi.Name = "cbMonThi";
            this.cbMonThi.Size = new System.Drawing.Size(121, 21);
            this.cbMonThi.TabIndex = 25;
            // 
            // cbHocSinh
            // 
            this.cbHocSinh.FormattingEnabled = true;
            this.cbHocSinh.Location = new System.Drawing.Point(782, 150);
            this.cbHocSinh.Name = "cbHocSinh";
            this.cbHocSinh.Size = new System.Drawing.Size(121, 21);
            this.cbHocSinh.TabIndex = 26;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(263, 153);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(46, 18);
            this.lable1.TabIndex = 27;
            this.lable1.Text = "Môn: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Học sinh:";
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
            // frmQuanTriKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1348, 821);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.cbHocSinh);
            this.Controls.Add(this.cbMonThi);
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
        private System.Windows.Forms.ComboBox cbMonThi;
        private System.Windows.Forms.ComboBox cbHocSinh;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn monThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}