using System;
using System.Collections.Generic;
using QUANLYTHICU.DAL;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHICU.BAL;
using QUANLYTHICU.Util;

namespace QUANLYTHICU
{
    public partial class frmQuanTriCauHoi : Form
    {
        private readonly MONHOC_BAL _monHocBAL;
        private readonly CAUHOI_BAL _cauHoiBAL;
        private List<CAUHOI> danhSachCauHoi;
        private int idCauHoi, idMonHoc;
        public frmQuanTriCauHoi()
        {
            InitializeComponent();
            _monHocBAL = new MONHOC_BAL();
            _cauHoiBAL = new CAUHOI_BAL();
            Load += FrmQuanTriCauHoi_Load;
        }
        
        private void FrmQuanTriCauHoi_Load(object sender, EventArgs e)
        {
            btnLamMoiCauHoi.PerformClick();
        }

        private void frmQuanTriCauHoi_Load(object sender, EventArgs e)
        {
            //mặc định idmonhoc là giá trị đầu tiên khi load
           idMonHoc = _monHocBAL.LayDanhSachMonHoc().FirstOrDefault().IDMONHOC;

           cbMonHoc.DataSource = _monHocBAL.LayDanhSachMonHoc();
           cbMonHoc.DisplayMember = "MONHOC1";
           cbMonHoc.ValueMember = "IDMONHOC";
        }
        private void TaiDanhSachCauHoi(List<CAUHOI> danhSachCauHoi)
        {
            int soThuTu = 1;
            dgvDanhSachCauHoi.Rows.Clear();
            //Kiểm tra danh sách rỗng
            if (danhSachCauHoi.Count <= 0) return;
            //Đổ dữ liệu ra bảng
            foreach (var ch in danhSachCauHoi)
            {
                int indexRow = dgvDanhSachCauHoi.Rows.Add();
                dgvDanhSachCauHoi.Rows[indexRow].Cells[0].Value = soThuTu++;
                dgvDanhSachCauHoi.Rows[indexRow].Cells[1].Value = ch.CAUHOI1;
                dgvDanhSachCauHoi.Rows[indexRow].Cells[2].Value = ch.TRALOI1;
                dgvDanhSachCauHoi.Rows[indexRow].Cells[3].Value = ch.TRALOI2;
                dgvDanhSachCauHoi.Rows[indexRow].Cells[4].Value = ch.TRALOI3;
                dgvDanhSachCauHoi.Rows[indexRow].Cells[5].Value = ch.DAPAN;
                dgvDanhSachCauHoi.Rows[indexRow].Cells[6].Value = ch.IDCAUHOI;
                dgvDanhSachCauHoi.Rows[indexRow].Cells[7].Value = ch.IDMONHOC;
            }
            dgvDanhSachCauHoi.Rows[0].Selected = false;

        }
        private void dgvDanhSachCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachCauHoi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachCauHoi.CurrentRow.Selected = true;
                txtCauHoi.Text = dgvDanhSachCauHoi.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtTraLoi1.Text = dgvDanhSachCauHoi.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtTraLoi2.Text = dgvDanhSachCauHoi.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtTraLoi3.Text = dgvDanhSachCauHoi.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtDapAn.Text = dgvDanhSachCauHoi.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                idCauHoi = int.Parse(dgvDanhSachCauHoi.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                idMonHoc = int.Parse(dgvDanhSachCauHoi.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
            }
        }
        private void btnThemSuaCauHoi_Click(object sender, EventArgs e)
        {
            string error;
            try
            {
                CAUHOI cauHoi = new CAUHOI();
                //Kiểm tra câu hỏi đã tồn tại trước khi thêm
                if (_cauHoiBAL.KiemTraCauHoi(idCauHoi, out error))
                {
                    string cauHoiMoi = Prompt.ShowDialog("Nhập câu hỏi mới", "Sửa câu hỏi");
                    string traLoi1Moi = Prompt.ShowDialog("Nhập trả lời 1 mới", "Sửa câu hỏi");
                    string traLoi2Moi = Prompt.ShowDialog("Nhập trả lời 2 mới ", "Sửa câu hỏi");
                    string traLoi3Moi = Prompt.ShowDialog("Nhập trả lời 3 mới ", "Sửa câu hỏi");
                    string dapAnMoi = Prompt.ShowDialog("Nhập đáp án mới ", "Sửa câu hỏi");
                    int idMonHocMoi = idMonHoc;

                    cauHoi.CAUHOI1 = cauHoiMoi;
                    cauHoi.TRALOI1 = traLoi1Moi;
                    cauHoi.TRALOI2 = traLoi2Moi;
                    cauHoi.TRALOI3 = traLoi3Moi;
                    cauHoi.DAPAN = dapAnMoi;
                    cauHoi.IDMONHOC = idMonHocMoi;

                    if (_cauHoiBAL.CapNhatCauHoi(idCauHoi, cauHoi, out error))
                        MessageBox.Show("Cập nhật!", "Sửa câu hỏi");
                    //tải lại khi cập nhật, chưa làm được.
                    TaiDanhSachCauHoi(danhSachCauHoi);
                    return;
                }
                //thêm nếu chưa có
                cauHoi.CAUHOI1 = txtCauHoi.Text;
                cauHoi.TRALOI1 = txtTraLoi1.Text;
                cauHoi.TRALOI2 = txtTraLoi2.Text;
                cauHoi.TRALOI3 = txtTraLoi3.Text;
                cauHoi.DAPAN = txtDapAn.Text;
                cauHoi.IDMONHOC = idMonHoc;
                //Thêm câu hỏi vào db
                _cauHoiBAL.LuuCauHoi(cauHoi, out error);
                //Tải lại danh sách
                TaiDanhSachCauHoi(danhSachCauHoi);
                MessageBox.Show("Lưu thành công!", "Lưu câu hỏi");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show(error, "Có lỗi xảy ra!");
            }
        }
        private void btnXoaCauHoi_Click(object sender, EventArgs e)
        {
            string error;
            try
            {
                if (idCauHoi == 0) { MessageBox.Show("Rỗng, không xoá được!", "Xoá câu hỏi"); return; }
                _cauHoiBAL.XoaCauHoi(idCauHoi, out error);
                idCauHoi = 0;
                //Tải lại danh sách
                TaiDanhSachCauHoi(danhSachCauHoi);
                MessageBox.Show("Xoá thành công!", "Xoá câu hỏi");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show(error, "Có lỗi xảy ra!");
            }
        }
        private void btnLamMoiCauHoi_Click(object sender, EventArgs e)
        {
            txtCauHoi.Text ="";
            txtTraLoi1.Text ="";
            txtTraLoi2.Text ="";
            txtTraLoi3.Text = "";
            txtDapAn.Text = "";
            //Tải lại danh sách
            danhSachCauHoi = _cauHoiBAL.LayDanhSachCauHoi();
            TaiDanhSachCauHoi(danhSachCauHoi);
        }
        private void lblHocSinhNavigation_Click(object sender, EventArgs e)
        {
            frmQuanTriHocSinh frmQuanTriHocSinh = new frmQuanTriHocSinh();
            this.Hide();
            frmQuanTriHocSinh.ShowDialog();
            this.Close();
        }
        private void lblMonHocNavigation_Click(object sender, EventArgs e)
        {
            frmQuanTriMonHoc frmQuanTriMonHoc = new frmQuanTriMonHoc();
            this.Hide();
            frmQuanTriMonHoc.ShowDialog();
            this.Close();
        }

        private void cbMonHoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue == null) return;
            idMonHoc = (int)cb.SelectedValue;
            var dsCauHoiTheoMon = _cauHoiBAL.LayDanhSachCauHoiTheoMon(idMonHoc);
            TaiDanhSachCauHoi(dsCauHoiTheoMon);
        }
    }
}
