using QUANLYTHICU.DAL;
using QUANLYTHICU.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHICU.BAL
{
    public class CHITIETMONHOC_BAL
    {
        private readonly CHITIETMONHOC_DAL _ctMonHocDAL;
        public CHITIETMONHOC_BAL()
        {
            _ctMonHocDAL = new CHITIETMONHOC_DAL();
        }
        public bool LuuChiTietMonHoc(CHITIETMONHOC ctMonHoc, out string error)
        {
            return _ctMonHocDAL.TaoMoiChiTietMonHoc(ctMonHoc, out error);
        }
        public List<KETQUA> LayDanhSachKetQua()
        {
            return _ctMonHocDAL.LayDanhSachChiTietMonHoc();
        }
    }
}
