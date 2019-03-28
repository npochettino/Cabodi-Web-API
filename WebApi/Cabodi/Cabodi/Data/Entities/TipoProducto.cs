namespace Cabodi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STTTPH")]
    public partial class TipoProducto
    {
        [Key]
        [StringLength(6)]
        public string STTTPH_TIPPRO { get; set; }

        [Required]
        [StringLength(60)]
        public string STTTPH_DESCRP { get; set; }

        [Required]
        [StringLength(1)]
        public string STTTPH_STOCKS { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKAR { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKSR { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKDS { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKEN { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKOT { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKFE { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKAT { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKUB { get; set; }

        [StringLength(50)]
        public string STTTPH_MASKES { get; set; }

        [StringLength(1)]
        public string STTTPH_HABIFC { get; set; }

        [StringLength(1)]
        public string STTTPH_HABICO { get; set; }

        [StringLength(1)]
        public string STTTPH_HABIPD { get; set; }

        [StringLength(1)]
        public string STTTPH_ANIDAD { get; set; }

        [Column(TypeName = "text")]
        public string STTTPH_OLEOLE { get; set; }

        [StringLength(255)]
        public string STTTPH_BMPBMP { get; set; }

        [StringLength(1)]
        public string STTTPH_TRUSEC { get; set; }

        [StringLength(1)]
        public string STTTPH_RQUSEC { get; set; }

        [StringLength(6)]
        public string STTTPH_NUMAUT { get; set; }

        [Column(TypeName = "text")]
        public string STTTPH_TEXTOS { get; set; }

        [StringLength(1)]
        public string STTTPH_ATMNUM { get; set; }

        [Required]
        [StringLength(1)]
        public string STTTPH_NUMPOR { get; set; }

        [StringLength(2)]
        public string USR_STTTPH_ORDEN { get; set; }

        public DateTime? STTTPH_FECALT { get; set; }

        public DateTime? STTTPH_FECMOD { get; set; }

        [StringLength(36)]
        public string STTTPH_USERID { get; set; }

        [StringLength(1)]
        public string STTTPH_ULTOPR { get; set; }

        [StringLength(1)]
        public string STTTPH_DEBAJA { get; set; }

        [StringLength(10)]
        public string STTTPH_HORMOV { get; set; }

        [StringLength(10)]
        public string STTTPH_MODULE { get; set; }

        [StringLength(10)]
        public string STTTPH_OALIAS { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] STTTPH_TSTAMP { get; set; }

        [StringLength(6)]
        public string STTTPH_LOTTRA { get; set; }

        [StringLength(6)]
        public string STTTPH_LOTREC { get; set; }

        [StringLength(6)]
        public string STTTPH_LOTORI { get; set; }

        [StringLength(10)]
        public string STTTPH_SYSVER { get; set; }

        [StringLength(10)]
        public string STTTPH_CMPVER { get; set; }

        [StringLength(1)]
        public string STTTPH_HABIME { get; set; }

        [StringLength(1)]
        public string STTTPH_BIEUSO { get; set; }

        [StringLength(6)]
        public string STTTPH_CARATR { get; set; }

        [StringLength(15)]
        public string STTTPH_OLDUID { get; set; }
    }
}
