namespace QUANLYTHICU.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETMONHOC")]
    public partial class CHITIETMONHOC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHOCSINH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDMONHOC { get; set; }

        [Required]
        [StringLength(50)]
        public string TRANGTHAI { get; set; }

        public int DIEM { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }

        public virtual MONHOC MONHOC { get; set; }
    }
}
