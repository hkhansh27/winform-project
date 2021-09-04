using QUANLYTHICU.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHICU.BAL
{
    public class HOCSINH_BAL
    {
        private readonly HOCSINH_DAL _hocSinhDAL;

        public HOCSINH_BAL()
        {
            _hocSinhDAL = new HOCSINH_DAL();
        }
        public HOCSINH LayHocSinhTheoTenDangNhap(HOCSINH hs)
        {
            return _hocSinhDAL.LayHocSinhTheoTenDangNhap(hs);
        }
        public List<HOCSINH> LayDanhSachHocSinh()
        {
            return _hocSinhDAL.LayDanhSachHocSinh();
        }
        public bool KiemTraHocSinh(HOCSINH hs, out string error)
        {
            return _hocSinhDAL.KiemTraHocSinh(hs, out error);
        }
        public bool LuuHocSinh(HOCSINH hocSinh, out string error)
        {
            return _hocSinhDAL.TaoMoiHocSinh(hocSinh, out error);
        }
        public bool CapNhatHocSinh(int idHocSinh, HOCSINH hocSinh, out string error)
        {
            return _hocSinhDAL.CapNhatHocSinh(idHocSinh, hocSinh, out error);
        }
        public bool XoaHocSinh(int idHocSinh, out string error)
        {
            return _hocSinhDAL.XoaHocSinh(idHocSinh, out error);
        }
    }
}
