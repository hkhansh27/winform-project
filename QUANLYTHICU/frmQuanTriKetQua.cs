using QUANLYTHICU.BAL;
using QUANLYTHICU.DAL;
using QUANLYTHICU.DTO;
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
    public partial class frmQuanTriKetQua : Form
    {
        private readonly CHITIETMONHOC_BAL _chiTietMonHocBAL;
        public frmQuanTriKetQua()
        {
            InitializeComponent();
            _chiTietMonHocBAL = new CHITIETMONHOC_BAL();
        }
        private void frmQuanTriKetQua_Load(object sender, EventArgs e)
        {
            TaiDanhSachCauHoi(_chiTietMonHocBAL.LayDanhSachKetQua());
        }
        private void TaiDanhSachCauHoi(List<KETQUA> danhSachKetQua)
        {
            int soThuTu = 1;
            dgvKetQua.Rows.Clear();
            //Kiểm tra danh sách rỗng
            if (danhSachKetQua.Count <= 0) return;
            //Đổ dữ liệu ra bảng
            foreach (var kq in danhSachKetQua)
            {
                int indexRow = dgvKetQua.Rows.Add();
                dgvKetQua.Rows[indexRow].Cells[0].Value = soThuTu++;
                dgvKetQua.Rows[indexRow].Cells[1].Value = kq.tenHocSinh;
                dgvKetQua.Rows[indexRow].Cells[2].Value = kq.tenMonHoc;
                dgvKetQua.Rows[indexRow].Cells[3].Value = kq.diem;
                dgvKetQua.Rows[indexRow].Cells[4].Value = kq.trangThai;
              
            }
            dgvKetQua.Rows[0].Selected = false;
        }
        private void lblHocSinhNavigation_Click(object sender, EventArgs e)
        {
            var frmQuanTriHocSinh = new frmQuanTriHocSinh();
            this.Hide();
            frmQuanTriHocSinh.ShowDialog();
            this.Close();
        }
        private void lblMonHocNavigation_Click(object sender, EventArgs e)
        {
            var frmQuanTriMonHoc = new frmQuanTriMonHoc();
            this.Hide();
            frmQuanTriMonHoc.ShowDialog();
            this.Close();
        }
        private void lblCauHoiNavigation_Click(object sender, EventArgs e)
        {
            var frmQuanTriCauHoi = new frmQuanTriCauHoi();
            this.Hide();
            frmQuanTriCauHoi.ShowDialog();
            this.Close();
        }

    }
}
