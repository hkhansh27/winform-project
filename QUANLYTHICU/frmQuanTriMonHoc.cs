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
    public partial class frmQuanTriMonHoc : Form
    {
        private readonly MONHOC_BAL _monHocBAL;
        private int idMonHoc;
        public frmQuanTriMonHoc()
        {
            InitializeComponent();
            _monHocBAL = new MONHOC_BAL();
            TaiDanhSachMonHoc();
        }
        private void TaiDanhSachMonHoc()
        {
            int soThuTu = 1;
            dgvDanhSachMonHoc.Rows.Clear();
            var danhSachMonHoc = _monHocBAL.LayDanhSachMonHoc();
            foreach (var mh in danhSachMonHoc)
            {
                
                int indexRow = dgvDanhSachMonHoc.Rows.Add();
                dgvDanhSachMonHoc.Rows[indexRow].Cells[0].Value = soThuTu++;
                dgvDanhSachMonHoc.Rows[indexRow].Cells[1].Value = mh.MONHOC1;
                dgvDanhSachMonHoc.Rows[indexRow].Cells[2].Value = mh.IDMONHOC;
            }
        }
        private void btnThemSuaMonHoc_Click(object sender, EventArgs e)
        {
            string error;
            string tinNhan = "Lưu thành công!";
            //Kiểm tra môn học đã tồn tại trước khi thêm
            if (_monHocBAL.KiemTraMonHoc(txtTenMon.Text, out error))
            {
                DialogResult kq = MessageBox.Show("Môn học đã tồn tại! Bạn có muốn sửa?", "Lưu môn học", MessageBoxButtons.YesNo);
                return;
                // tinNhan = "Sửa thành công!";
                //if (kq == DialogResult.No) return ;
            }
            MONHOC monHoc = new MONHOC();
            monHoc.MONHOC1 = txtTenMon.Text;
            //Thêm môn học vào db
            _monHocBAL.LuuMonHoc(monHoc, out error);
            //Tải danh sách môn học
            TaiDanhSachMonHoc();
            MessageBox.Show(tinNhan, "Lưu môn học"); 
        }
        private void dgvDanhSachMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDanhSachMonHoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDanhSachMonHoc.CurrentRow.Selected = true;
                    txtTenMon.Text = dgvDanhSachMonHoc.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    idMonHoc = int.Parse(dgvDanhSachMonHoc.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có vẻ bạn chọn sai chỗ!", "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            string error;
            if(idMonHoc == 0) { MessageBox.Show("Rỗng, không xoá được!", "Xoá môn học"); return; }
            _monHocBAL.XoaMonHoc(idMonHoc, out error);
            idMonHoc = 0; 
            //Tải danh sách môn học
            TaiDanhSachMonHoc();
            MessageBox.Show("Xoá thành công!", "Xoá môn học");

        }
    }
}

