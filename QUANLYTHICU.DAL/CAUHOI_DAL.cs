using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace QUANLYTHICU.DAL
{
    public class CAUHOI_DAL
    {
        public List<CAUHOI> LayDanhSachCauHoiTheoMon(int idMonHoc)
        {
            using (var dbcontext = new QUANLITHYCU())
            {
                return (from s1 in dbcontext.CAUHOIs
                        where s1.IDMONHOC == idMonHoc
                        select s1).ToList();
            }
        }    
        public List<CAUHOI> LayDanhSachCauHoi()
        {
            using (var dbcontext = new QUANLITHYCU())
            {
                return dbcontext.CAUHOIs.ToList();
            }
        }
        public bool KiemTraCauHoi(int idCauHoi, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    return dbcontext.CAUHOIs.Any(ch => ch.IDCAUHOI == idCauHoi);
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
        public bool CapNhatCauHoi(int idCauHoi, CAUHOI cauHoi ,out string error)
        {
            using (var db = new QUANLITHYCU())
            {
                error = string.Empty;
                try
                {
                    var ketQua = db.CAUHOIs.SingleOrDefault(ch => ch.IDCAUHOI == idCauHoi);
                    if (ketQua == null) return false;

                    ketQua.CAUHOI1 = cauHoi.CAUHOI1;
                    ketQua.TRALOI1 = cauHoi.TRALOI1;
                    ketQua.TRALOI2 = cauHoi.TRALOI2;
                    ketQua.TRALOI3 = cauHoi.TRALOI3;
                    ketQua.DAPAN = cauHoi.DAPAN;
                    ketQua.IDMONHOC = cauHoi.IDMONHOC;
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
        public bool TaoMoiCauHoi(CAUHOI cauHoi, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    dbcontext.CAUHOIs.AddOrUpdate(cauHoi);
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
        public bool XoaCauHoi(int idCauHoi, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    var ch = (from s1 in dbcontext.CAUHOIs
                                where s1.IDCAUHOI == idCauHoi
                              select s1).SingleOrDefault();

                    if (ch == null) return false;
                    
                    dbcontext.CAUHOIs.Remove(ch);
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
