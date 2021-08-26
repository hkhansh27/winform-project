using QUANLYTHICU.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHICU.BAL
{
    public class NGUOIQUANLY_BAL
    {
        private readonly NGUOIQUANLY_DAL _nguoiQuanLyDAL;

        public NGUOIQUANLY_BAL()
        {
            _nguoiQuanLyDAL = new NGUOIQUANLY_DAL();
        }

       
        public bool KiemTraNguoiQuanLy(NGUOIQUANLY nql, out string error)
        {
            return _nguoiQuanLyDAL.KiemTraNguoiQuanLy(nql, out error);
        }
    }
}
