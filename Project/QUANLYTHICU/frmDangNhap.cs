using QUANLYTHICU.BAL;
using QUANLYTHICU.DAL;
using QUANLYTHICU.Util;
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
    public partial class frmDangNhap : Form
    {
        private readonly NGUOIQUANLY_BAL _nguoiQuanLyBAL;
        private readonly HOCSINH_BAL _hocSinhBAL;
        private readonly MONHOC_BAL _monHocBAL;
        private List<MONHOC> danhSachMonThi;
        private int idMonThi;
        public frmDangNhap()
        {
            InitializeComponent();
            _nguoiQuanLyBAL = new NGUOIQUANLY_BAL();
            _hocSinhBAL = new HOCSINH_BAL();
            _monHocBAL = new MONHOC_BAL();
            danhSachMonThi = _monHocBAL.LayDanhSachMonHoc();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (danhSachMonThi.Count == 0) return;
            idMonThi = danhSachMonThi[0].IDMONHOC;

            cbMonThi.DataSource = danhSachMonThi;
            cbMonThi.DisplayMember = "MONHOC1";
            cbMonThi.ValueMember = "IDMONHOC";
        }
        private void DangNhap()
        {
            string error = string.Empty;
            try
            {
                NGUOIQUANLY nql = new NGUOIQUANLY();
                HOCSINH hs = new HOCSINH();
                nql.TENDANGNHAP = txtTenDangNhap.Text;
                nql.MATKHAU = md5.Encrypt(txtMatKhau.Text);
                hs.TENDANGNHAP = txtTenDangNhap.Text;
                hs.MATKHAU = md5.Encrypt(txtMatKhau.Text);
                if (_nguoiQuanLyBAL.KiemTraNguoiQuanLy(nql, out error))
                {
                    frmQuanTriCauHoi frmQuanTriCauHoi = new frmQuanTriCauHoi();
                    this.Hide();
                    frmQuanTriCauHoi.ShowDialog();
                    this.Close();
                }
                if (_hocSinhBAL.KiemTraHocSinh(hs, out error))
                {
                    var kqHs = _hocSinhBAL.LayHocSinhTheoTenDangNhap(hs);
                    frmBaiLam frmBaiLam = new frmBaiLam(idMonThi, kqHs.IDHOCSINH, cbMonThi.Text);
                    this.Hide();
                    frmBaiLam.ShowDialog();
                    this.Close();
                }
                MessageBox.Show("Đăng nhập thất bại!", "Đăng nhập");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show(error);
            }
            
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "" || txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Không được bỏ trống 1 trong 2 trường này!");
                return;
            }
            DangNhap();
        }

        private void cbMonThi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue == null) return;
            idMonThi = (int)cb.SelectedValue;
        }
    }
}
