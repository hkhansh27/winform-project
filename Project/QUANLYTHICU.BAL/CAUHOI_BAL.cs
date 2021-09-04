using QUANLYTHICU.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHICU.BAL
{
    public class CAUHOI_BAL
    {
        private readonly CAUHOI_DAL _cauHoiDAL;

        public CAUHOI_BAL()
        {
            _cauHoiDAL = new CAUHOI_DAL();
        }

        public List<CAUHOI> LayDanhSachCauHoi()
        {
            return _cauHoiDAL.LayDanhSachCauHoi();
        }
        public List<CAUHOI> LayDanhSachCauHoiTheoMon(int idMonHoc)
        {
            return _cauHoiDAL.LayDanhSachCauHoiTheoMon(idMonHoc);
        }
        public bool KiemTraCauHoi(int idCauHoi, out string error)
        {
            return _cauHoiDAL.KiemTraCauHoi(idCauHoi, out error);
        }
        public bool LuuCauHoi(CAUHOI cauHoi, out string error)
        {
            return _cauHoiDAL.TaoMoiCauHoi(cauHoi, out error);
        }
        public bool CapNhatCauHoi(int idCauHoi, CAUHOI cauHoi, out string error)
        {
            return _cauHoiDAL.CapNhatCauHoi(idCauHoi, cauHoi, out error);
        }
        public bool XoaCauHoi(int idCauHoi, out string error)
        {
            return _cauHoiDAL.XoaCauHoi(idCauHoi, out error);
        }
    }
}
