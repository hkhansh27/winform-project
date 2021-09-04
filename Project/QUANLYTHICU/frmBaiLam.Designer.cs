
namespace QUANLYTHICU
{
    partial class frmBaiLam
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
            this.btnNopBai = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBaiLam = new System.Windows.Forms.Panel();
            this.lblMonThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.Color.White;
            this.btnNopBai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNopBai.Location = new System.Drawing.Point(567, 770);
            this.btnNopBai.Margin = new System.Windows.Forms.Padding(1);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(150, 30);
            this.btnNopBai.TabIndex = 20;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(1113, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(46, 18);
            this.lable1.TabIndex = 21;
            this.lable1.Text = "Môn: ";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(1152, 9);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(0, 18);
            this.lblMonHoc.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "BÀI LÀM";
            // 
            // pnBaiLam
            // 
            this.pnBaiLam.Location = new System.Drawing.Point(3, 36);
            this.pnBaiLam.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnBaiLam.Name = "pnBaiLam";
            this.pnBaiLam.Size = new System.Drawing.Size(1344, 730);
            this.pnBaiLam.TabIndex = 24;
            // 
            // lblMonThi
            // 
            this.lblMonThi.AutoSize = true;
            this.lblMonThi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonThi.Location = new System.Drawing.Point(1158, 9);
            this.lblMonThi.Name = "lblMonThi";
            this.lblMonThi.Size = new System.Drawing.Size(0, 19);
            this.lblMonThi.TabIndex = 25;
            // 
            // frmBaiLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1348, 821);
            this.Controls.Add(this.lblMonThi);
            this.Controls.Add(this.pnBaiLam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.btnNopBai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBaiLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI THI";
            this.Load += new System.EventHandler(this.frmBaiLam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBaiLam;
        private System.Windows.Forms.Label lblMonThi;
    }
}