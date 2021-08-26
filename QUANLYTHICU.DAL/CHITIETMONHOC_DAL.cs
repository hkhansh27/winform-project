using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using QUANLYTHICU.DTO;

namespace QUANLYTHICU.DAL
{
    public class CHITIETMONHOC_DAL
    {
        public bool TaoMoiChiTietMonHoc(CHITIETMONHOC ctMonHoc, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QUANLITHYCU())
                {
                    dbcontext.CHITIETMONHOCs.AddOrUpdate(ctMonHoc);
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
        public List<KETQUA> LayDanhSachChiTietMonHoc ()
        {
            using (var dbcontext = new QUANLITHYCU())
            {
                return (from mh in dbcontext.MONHOCs
                        join ctMh in dbcontext.CHITIETMONHOCs on mh.IDMONHOC equals ctMh.IDMONHOC
                        join hs in dbcontext.HOCSINHs on ctMh.IDHOCSINH equals hs.IDHOCSINH
                        select new KETQUA()
                        {
                            tenHocSinh = hs.HOTEN,
                            tenMonHoc = ctMh.MONHOC.MONHOC1,
                            diem = ctMh.DIEM,
                            trangThai = ctMh.TRANGTHAI
                        }).ToList();
            }
        }
        /*var entryPoint = (from ep in dbContext.tbl_EntryPoint
                          join e in dbContext.tbl_Entry on ep.EID equals e.EID
                          join t in dbContext.tbl_Title on e.TID equals t.TID
                          where e.OwnerID == user.UID
                          select new
                          {
                              UID = e.OwnerID,
                              TID = e.TID,
                              Title = t.Title,
                              EID = e.EID
                          }).Take(10);*/
    }
}
