using QUANLYTHICU.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHICU.BAL
{
    public class MONHOC_BAL
    {
        private readonly MONHOC_DAL _monHocDAL;

        public MONHOC_BAL()
        {
            _monHocDAL = new MONHOC_DAL();
        }
        public List<MONHOC> LayDanhSachMonHoc()
        {
            return _monHocDAL.LayDanhSachMonHoc();
        }
        public bool KiemTraMonHoc(string tenMon, out string error)
        {
            return _monHocDAL.KiemTraMonHoc(tenMon, out error);
        }
        public bool LuuMonHoc(MONHOC monHoc, out string error)
        {
            return _monHocDAL.TaoMoiMonHoc(monHoc, out error);
        }
        public bool XoaMonHoc(int idMonHoc, out string error)
        {
            return _monHocDAL.XoaMonHoc(idMonHoc, out error);
        }
    }
}
