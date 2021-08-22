using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace QUANLYTHICU.DAL
{
    public class MONHOC_DAL
    {
        public List<MONHOC> LayDanhSachMonHoc()
        {
            using (var dbcontext = new QUANLITHYCU())
            {
                return dbcontext.MONHOCs.ToList();
            }

        }
        public bool KiemTraMonHoc(string tenMonHoc, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    return dbcontext.MONHOCs.Any(mh => mh.MONHOC1 == tenMonHoc);
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
        public bool CapNhatMonHoc(int idMonHoc, MONHOC monHoc ,out string error)
        {
            using (var db = new QUANLITHYCU())
            {
                error = string.Empty;
                try
                {
                    var ketQua = db.MONHOCs.SingleOrDefault(mh => mh.IDMONHOC == idMonHoc);
                    if (ketQua == null) return false;
                    ketQua.MONHOC1 = monHoc.MONHOC1;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
                
            }
        }
        public bool TaoMoiMonHoc(MONHOC monHoc, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    dbcontext.MONHOCs.AddOrUpdate(monHoc);
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
        public bool XoaMonHoc(int idMonHoc, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    var mh = (from s1 in dbcontext.MONHOCs
                                where s1.IDMONHOC == idMonHoc
                              select s1).SingleOrDefault();

                    if (mh == null) return false;
                    
                    dbcontext.MONHOCs.Remove(mh);
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
