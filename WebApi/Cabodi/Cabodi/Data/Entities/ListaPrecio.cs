using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cabodi.Data.Entities
{
    [Table("STTPRE")]
    public class ListaPrecio
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string STTPRE_CODLIS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string STTPRE_TIPPRO { get; set; }

        [Required]
        [StringLength(30)]
        public string STTPRE_ARTCOD { get; set; }

        public DateTime STTPRE_FECLIS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STTPRE_PRECIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STTPRE_PRMIPR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STTPRE_PRMXPR { get; set; }

        public DateTime? STTPRE_FECALT { get; set; }

        public DateTime? STTPRE_FECMOD { get; set; }

        [StringLength(36)]
        public string STTPRE_USERID { get; set; }

        [StringLength(1)]
        public string STTPRE_ULTOPR { get; set; }

        [StringLength(1)]
        public string STTPRE_DEBAJA { get; set; }

        [StringLength(10)]
        public string STTPRE_HORMOV { get; set; }

        [StringLength(10)]
        public string STTPRE_MODULE { get; set; }

        [StringLength(10)]
        public string STTPRE_OALIAS { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] STTPRE_TSTAMP { get; set; }

        [StringLength(6)]
        public string STTPRE_LOTTRA { get; set; }

        [StringLength(6)]
        public string STTPRE_LOTREC { get; set; }

        [StringLength(6)]
        public string STTPRE_LOTORI { get; set; }

        [StringLength(10)]
        public string STTPRE_SYSVER { get; set; }

        [StringLength(10)]
        public string STTPRE_CMPVER { get; set; }
    }
}