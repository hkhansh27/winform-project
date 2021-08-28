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
    public partial class frmQuanTriMonHoc : Form
    {
        private readonly MONHOC_BAL _monHocBAL;
        private int idMonHoc;
        public frmQuanTriMonHoc()
        {
            InitializeComponent();
            _monHocBAL = new MONHOC_BAL();
            Load += FrmQuanTriMonHoc_Load;
        }

        private void FrmQuanTriMonHoc_Load(object sender, EventArgs e)
        {
            btnLamMoiMonHoc.PerformClick();
        }

        private void TaiDanhSachMonHoc()
        {
            int soThuTu = 1; 
            dgvDanhSachMonHoc.Rows.Clear();
            var danhSachMonHoc = _monHocBAL.LayDanhSachMonHoc();
            
            //Kiểm tra danh sách rỗng
            if (danhSachMonHoc.Count <= 0) return;
            //Đổ dữ liệu ra bảng
            foreach (var mh in danhSachMonHoc)
            {
                int indexRow = dgvDanhSachMonHoc.Rows.Add();
                dgvDanhSachMonHoc.Rows[indexRow].Cells[0].Value = soThuTu++;
                dgvDanhSachMonHoc.Rows[indexRow].Cells[1].Value = mh.MONHOC1;
                dgvDanhSachMonHoc.Rows[indexRow].Cells[2].Value = mh.IDMONHOC;
            }
            dgvDanhSachMonHoc.Rows[0].Selected = false;
        }
        private void dgvDanhSachMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dgvDanhSachMonHoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;

            dgvDanhSachMonHoc.CurrentRow.Selected = true;
            txtTenMon.Text = dgvDanhSachMonHoc.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            idMonHoc = int.Parse(dgvDanhSachMonHoc.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
               
        }
        private void btnThemSuaMonHoc_Click(object sender, EventArgs e)
        {
            if(txtTenMon.Text == "") { MessageBox.Show("Không được để trống trường này!"); return; }
            string error;
            try
            {
                MONHOC monHoc = new MONHOC();
                //Kiểm tra môn học đã tồn tại trước khi thêm
                if (_monHocBAL.KiemTraMonHoc(txtTenMon.Text, out error))
                {
                    string tenMonMoi = Prompt.ShowDialog("Vui lòng nhập tên môn mà bạn muốn sửa", "Sửa môn học");
                    monHoc.MONHOC1 = tenMonMoi;

                    if (_monHocBAL.CapNhatMonHoc(idMonHoc, monHoc, out error))
                        MessageBox.Show("Cập nhật!", "Sửa môn học");
                    TaiDanhSachMonHoc();
                    return;
                }
                monHoc.MONHOC1 = txtTenMon.Text;
                //Thêm môn học vào db
                _monHocBAL.LuuMonHoc(monHoc, out error);
                //Tải lại danh sách
                TaiDanhSachMonHoc();
                MessageBox.Show("Lưu thành công!", "Lưu môn học");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show(error, "Có lỗi xảy ra!");
            }
        }
        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            string error;
            try
            {
                if (idMonHoc == 0) { MessageBox.Show("Rỗng, không xoá được!", "Xoá môn học"); return; }
                _monHocBAL.XoaMonHoc(idMonHoc, out error);
                idMonHoc = 0;
                //Tải lại danh sách
                TaiDanhSachMonHoc();
                MessageBox.Show("Xoá thành công!", "Xoá môn học");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show(error, "Có lỗi xảy ra!");
            }
        }
        private void btnLamMoiMonHoc_Click(object sender, EventArgs e)
        {
            txtTenMon.Text = "";
            TaiDanhSachMonHoc();
        }

        private void lblHocSinhNavigation_Click(object sender, EventArgs e)
        {
            var frmQuanTriHocSinh = new frmQuanTriHocSinh();
            this.Hide();
            frmQuanTriHocSinh.ShowDialog();
            this.Close();
        }

        private void lblCauHoiNavigation_Click(object sender, EventArgs e)
        {
            var frmQuanTriCauHoi = new frmQuanTriCauHoi();
            this.Hide();
            frmQuanTriCauHoi.ShowDialog();
            this.Close();
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {
            var frmQuanTriKetQua = new frmQuanTriKetQua();
            this.Hide();
            frmQuanTriKetQua.ShowDialog();
            this.Close();
        }
    }
}

