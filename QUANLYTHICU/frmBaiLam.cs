using QUANLYTHICU.BAL;
using QUANLYTHICU.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHICU
{
    public partial class frmBaiLam : Form
    {
        private readonly CAUHOI_BAL _cauHoiBAL;
        private readonly CHITIETCAUHOI_BAL _chiTietCauHoiBAL;
        private readonly CHITIETMONHOC_BAL _chiTietMonHocBAL;
        List<CAUHOI> danhSachCauHoi;
        private int idHocSinh, idMonThi, diem;
        private int soCauHoi = 4;
        public frmBaiLam(int IDMonThi, int idHocSinh)
        {
            InitializeComponent();
            _cauHoiBAL = new CAUHOI_BAL();
            _chiTietCauHoiBAL = new CHITIETCAUHOI_BAL();
            _chiTietMonHocBAL = new CHITIETMONHOC_BAL();
            danhSachCauHoi = _cauHoiBAL.LayDanhSachCauHoiTheoMon(IDMonThi);
            this.idMonThi = IDMonThi;
            this.idHocSinh = idHocSinh;
        }
        private void frmBaiLam_Load(object sender, EventArgs e)
        {
            KhoiTaoCauHoi();
        }

        private void KhoiTaoCauHoi()
        {
           
            List<string> cauHoi = new List<string>();
            List<string> traLoi1 = new List<string>();
            List<string> traLoi2 = new List<string>();
            List<string> traLoi3 = new List<string>();
            List<string> dapAn = new List<string>();
            List<int> idCauHoi = new List<int>();
            List<CAUHOI> mh = new List<CAUHOI>();
            foreach (var ch in danhSachCauHoi)
            {
                cauHoi.Add(ch.CAUHOI1);
                traLoi1.Add(ch.TRALOI1);
                traLoi2.Add(ch.TRALOI2);
                traLoi3.Add(ch.TRALOI3);
                dapAn.Add(ch.DAPAN);
                idCauHoi.Add(ch.IDCAUHOI);
                mh.Add(ch);
            }
            GroupBox gb;
            RadioButton rb;
            int tabIndexGB = 24;
            int tabIndexRB = 50;
            int X = 334; //300
            int Y = 23;
            int tl1 = 0;
            int tl2 = 0;
            int tl3 = 0;
            for (int i = 0; i < soCauHoi; i++)
            {
                gb = new GroupBox();
                gb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                gb.Location = new System.Drawing.Point((i * X) + 9, 43);
                gb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
                gb.Size = new System.Drawing.Size(200, 101);
                gb.Name = "gb" + i;
                gb.Tag = idCauHoi[i];
                gb.TabIndex = ++tabIndexGB;
                gb.TabStop = false;
                gb.AutoSize = true;
                gb.Text = cauHoi[i];
                for (int j = 0; j < 3; j++)
                {
                    rb = new RadioButton();
                    rb.AutoSize = true;
                    rb.Location = new System.Drawing.Point(6, (j * Y) + 19);
                    rb.Name = "rb" + i + "0" + j;
                    rb.Size = new System.Drawing.Size(85, 17);
                    rb.TabIndex = ++tabIndexRB;
                    rb.UseVisualStyleBackColor = true;
                    rb.TabStop = true;
                    rb.Tag = dapAn[i];
                    if(j == 0) rb.Text = traLoi1[tl1++];
                    if (j == 1) rb.Text = traLoi2[tl2++];
                    if (j == 2) rb.Text = traLoi3[tl3++];
                    gb.Controls.Add(rb);
                }
                pnBaiLam.Controls.Add(gb);
            }
        }
        private void btnNopBai_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            bool trangThai = false;
            CHITIETCAUHOI ctCauHoi;
            CHITIETMONHOC ctMonHoc;
            int soCauDung = 0;
            foreach (Control gb in pnBaiLam.Controls)
            {
                GroupBox groupBox = (GroupBox)gb;
                ctCauHoi = new CHITIETCAUHOI();
                ctCauHoi.IDCAUHOI = int.Parse(gb.Tag.ToString());
                ctCauHoi.IDHOCSINH = idHocSinh;
                foreach (Control rb in gb.Controls)
                {
                    RadioButton radioButton = (RadioButton)rb;
                    if (!radioButton.Checked) continue;
                    if (radioButton.Text == radioButton.Tag.ToString())
                    {
                        trangThai = true;
                        soCauDung++;
                    } 
                }
                ctCauHoi.TRANGTHAI = trangThai;
                try
                {
                    _chiTietCauHoiBAL.LuuChiTietCauHoi(ctCauHoi, out error); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            diem = soCauDung * 10 / soCauHoi;
            ctMonHoc = new CHITIETMONHOC();
            ctMonHoc.IDHOCSINH = idHocSinh;
            ctMonHoc.IDMONHOC = idMonThi;
            ctMonHoc.DIEM = diem;
            ctMonHoc.TRANGTHAI = diem > 5 ? "Đạt" : "Rớt";
            _chiTietMonHocBAL.LuuChiTietMonHoc(ctMonHoc, out error);
            this.Close();
        }

    }
}