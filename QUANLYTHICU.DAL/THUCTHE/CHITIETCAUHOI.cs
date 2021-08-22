namespace QUANLYTHICU.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETCAUHOI")]
    public partial class CHITIETCAUHOI
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHOCSINH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCAUHOI { get; set; }

        public bool TRANGTHAI { get; set; }

        public virtual CAUHOI CAUHOI { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }
    }
}
