using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHICU.DAL
{
    public class NGUOIQUANLY_DAL
    {
        public bool KiemTraNguoiQuanLy(NGUOIQUANLY ql, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    return dbcontext.NGUOIQUANLies.Any(nql => nql.TENDANGNHAP == ql.TENDANGNHAP && nql.MATKHAU == ql.MATKHAU);
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
    }
}
