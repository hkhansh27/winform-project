using QUANLYTHICU.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHICU.BAL
{
    public class CHITIETCAUHOI_BAL
    {
        private readonly CHITIETCAUHOI_DAL ctCauHoi_DAL;
        public CHITIETCAUHOI_BAL()
        {
            ctCauHoi_DAL = new CHITIETCAUHOI_DAL();
        }
        public bool LuuChiTietCauHoi(CHITIETCAUHOI ctCauHoi, out string error)
        {
            return ctCauHoi_DAL.TaoMoiChiTietCauHoi(ctCauHoi, out error);
        }
    }
}
