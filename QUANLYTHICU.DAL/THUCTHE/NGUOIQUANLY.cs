namespace QUANLYTHICU.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIQUANLY")]
    public partial class NGUOIQUANLY
    {
        [Key]
        public int IDQUANLY { get; set; }

        [Required]
        [StringLength(50)]
        public string TENDANGNHAP { get; set; }

        [Required]
        [StringLength(50)]
        public string MATKHAU { get; set; }
    }
}
