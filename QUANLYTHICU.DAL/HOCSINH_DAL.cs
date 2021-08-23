using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHICU.DAL
{
    public class HOCSINH_DAL
    {
        public List<HOCSINH> LayDanhSachHocSinh()
        {
            using (var dbcontext = new QUANLITHYCU())
            {
                return dbcontext.HOCSINHs.ToList();
            }

        }
        public bool KiemTraHocSinh(string tenDangNhap, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    return dbcontext.HOCSINHs.Any(hs => hs.TENDANGNHAP == tenDangNhap);
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
        public bool CapNhatHocSinh(int idHocSinh, HOCSINH hocSinh, out string error)
        {
            using (var db = new QUANLITHYCU())
            {
                error = string.Empty;
                try
                {
                    var ketQua = db.HOCSINHs.SingleOrDefault(hs => hs.IDHOCSINH == idHocSinh);
                    if (ketQua == null) return false;
                    ketQua.HOTEN = hocSinh.HOTEN;
                    ketQua.TENDANGNHAP = hocSinh.TENDANGNHAP;
                    ketQua.MATKHAU = hocSinh.MATKHAU;
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
        public bool TaoMoiHocSinh(HOCSINH hocSinh, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    dbcontext.HOCSINHs.AddOrUpdate(hocSinh);
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
        public bool XoaHocSinh(int idHocSinh, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    var hs = (from s1 in dbcontext.HOCSINHs
                              where s1.IDHOCSINH == idHocSinh
                              select s1).SingleOrDefault();

                    if (hs == null) return false;

                    dbcontext.HOCSINHs.Remove(hs);
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
