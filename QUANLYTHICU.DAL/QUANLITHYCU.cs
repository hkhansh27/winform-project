using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QUANLYTHICU.DAL
{
    public partial class QUANLITHYCU : DbContext
    {
        public QUANLITHYCU()
            : base("name=QUANLYTHICU_MODEL")
        {
        }

        public virtual DbSet<CAUHOI> CAUHOIs { get; set; }
        public virtual DbSet<CHITIETCAUHOI> CHITIETCAUHOIs { get; set; }
        public virtual DbSet<CHITIETMONHOC> CHITIETMONHOCs { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<NGUOIQUANLY> NGUOIQUANLies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.TENDANGNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.MONHOC1)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIQUANLY>()
                .Property(e => e.TENDANGNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIQUANLY>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);
        }
    }
}
