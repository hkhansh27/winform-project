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
    public partial class frmQuanTriHocSinh : Form
    {
        private readonly HOCSINH_BAL _hocSinhBAL;
        private int idHocSinh;
        public frmQuanTriHocSinh()
        {
            InitializeComponent();
            _hocSinhBAL = new HOCSINH_BAL();
            Load += FrmQuanTriHocSinh_Load;
        }
        
      

        private void FrmQuanTriHocSinh_Load(object sender, EventArgs e)
        {
            btnLamMoiHocSinh.PerformClick();
        }

        private void TaiDanhSachHocSinh()
        {
            int soThuTu = 1;
            dgvDanhSachHocSinh.Rows.Clear();
            var danhSachHocSinh = _hocSinhBAL.LayDanhSachHocSinh();
            //Kiểm tra danh sách rỗng
            if (danhSachHocSinh.Count <= 0) return;
            //Đổ dữ liệu ra bảng
            foreach (var hs in danhSachHocSinh)
            {
                int indexRow = dgvDanhSachHocSinh.Rows.Add();
                dgvDanhSachHocSinh.Rows[indexRow].Cells[0].Value = soThuTu++;
                dgvDanhSachHocSinh.Rows[indexRow].Cells[1].Value = hs.HOTEN;
                dgvDanhSachHocSinh.Rows[indexRow].Cells[2].Value = hs.TENDANGNHAP;
                dgvDanhSachHocSinh.Rows[indexRow].Cells[3].Value = hs.MATKHAU;
                dgvDanhSachHocSinh.Rows[indexRow].Cells[4].Value = hs.IDHOCSINH;
            }
            dgvDanhSachHocSinh.Rows[0].Selected = false;

        }
        private void dgvDanhSachHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachHocSinh.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachHocSinh.CurrentRow.Selected = true;
                txtHoTen.Text = dgvDanhSachHocSinh.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtTenDangNhap.Text = dgvDanhSachHocSinh.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtMatKhau.Text = dgvDanhSachHocSinh.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                idHocSinh = int.Parse(dgvDanhSachHocSinh.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            }
        }
        private void btnThemSuaHocSinh_Click(object sender, EventArgs e)
        {
            string error;
            try
            {
                HOCSINH hocSinh = new HOCSINH();
                //Kiểm tra môn học đã tồn tại trước khi thêm
                 if (_hocSinhBAL.KiemTraHocSinh(txtTenDangNhap.Text, out error))
                {
                    string tenHocSinhMoi = Prompt.ShowDialog("Nhập tên học sinh mới", "Sửa học sinh");
                    string tenDangNhapMoi = Prompt.ShowDialog("Nhập tên đăng nhập mới", "Sửa học sinh");
                    string matKhauMoi = Prompt.ShowDialog("Nhập mật khẩu mới ", "Sửa học sinh");

                    hocSinh.HOTEN = tenHocSinhMoi;
                    hocSinh.TENDANGNHAP = tenDangNhapMoi;
                    hocSinh.MATKHAU = matKhauMoi;
                    if (_hocSinhBAL.CapNhatHocSinh(idHocSinh, hocSinh, out error))
                        MessageBox.Show("Cập nhật!", "Sửa học sinh");
                    TaiDanhSachHocSinh();
                    return;
                }
                hocSinh.HOTEN = txtHoTen.Text;
                hocSinh.TENDANGNHAP = txtTenDangNhap.Text;
                hocSinh.MATKHAU = txtMatKhau.Text;
                //Thêm môn học vào db
                _hocSinhBAL.LuuHocSinh(hocSinh, out error);
                //Tải lại danh sách
                TaiDanhSachHocSinh();
                MessageBox.Show("Lưu thành công!", "Lưu học sinh");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show(error, "Có lỗi xảy ra!");
            }
        }
        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            string error;
            try
            {
                if (idHocSinh == 0) { MessageBox.Show("Rỗng, không xoá được!", "Xoá học sinh"); return; }
                _hocSinhBAL.XoaHocSinh(idHocSinh, out error);
                idHocSinh = 0;
                //Tải lại danh sách
                TaiDanhSachHocSinh();
                MessageBox.Show("Xoá thành công!", "Xoá học sinh");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show(error, "Có lỗi xảy ra!");
            }
        }
        private void btnLamMoiHocSinh_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            TaiDanhSachHocSinh();
        }

        /*private void lblHocSinhNavigation_Click(object sender, EventArgs e)
        {
            frmQuanTriHocSinh frmQuanTriHocSinh = new frmQuanTriHocSinh();
            this.Hide();
            frmQuanTriHocSinh.ShowDialog();
            this.Close();
            //frmQuanTriHocSinh.Show();
        }*/
    }
}
