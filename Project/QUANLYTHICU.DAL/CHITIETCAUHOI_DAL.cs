using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;


namespace QUANLYTHICU.DAL
{
    public class CHITIETCAUHOI_DAL
    {
        public bool TaoMoiChiTietCauHoi(CHITIETCAUHOI ctCauHoi, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    dbcontext.CHITIETCAUHOIs.AddOrUpdate(ctCauHoi);
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
