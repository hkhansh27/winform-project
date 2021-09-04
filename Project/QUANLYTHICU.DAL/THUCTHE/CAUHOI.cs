namespace QUANLYTHICU.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAUHOI")]
    public partial class CAUHOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAUHOI()
        {
            CHITIETCAUHOIs = new HashSet<CHITIETCAUHOI>();
        }

        [Key]
        public int IDCAUHOI { get; set; }

        [Column("CAUHOI")]
        [Required]
        [StringLength(255)]
        public string CAUHOI1 { get; set; }

        [StringLength(255)]
        public string TRALOI1 { get; set; }

        [StringLength(255)]
        public string TRALOI2 { get; set; }

        [StringLength(255)]
        public string TRALOI3 { get; set; }

        [Required]
        [StringLength(255)]
        public string DAPAN { get; set; }

        public int IDMONHOC { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETCAUHOI> CHITIETCAUHOIs { get; set; }
    }
}
