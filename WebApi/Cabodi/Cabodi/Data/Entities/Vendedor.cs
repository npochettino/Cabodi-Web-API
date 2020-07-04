namespace Cabodi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VTTVND")]
    public partial class Vendedor
    {
        [Key]
        [StringLength(6)]
        public string VTTVND_VNDDOR { get; set; }

        [Required]
        [StringLength(60)]
        public string VTTVND_DESCRP { get; set; }

        [StringLength(6)]
        public string VTTVND_GRUCOM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VTTVND_PORCEN { get; set; }

        [StringLength(13)]
        public string VTTVND_LEGAJO { get; set; }

        [StringLength(20)]
        public string VTTVND_NATMER { get; set; }

        [StringLength(1)]
        public string VTTVND_TIPLIQ { get; set; }

        [StringLength(3)]
        public string VTTVND_CODPAI { get; set; }

        [StringLength(10)]
        public string VTTVND_CODPOS { get; set; }

        [StringLength(30)]
        public string VTTVND_NROTEL { get; set; }

        [Column(TypeName = "text")]
        public string VTTVND_CAMAIL { get; set; }

        [Column(TypeName = "text")]
        public string VTTVND_OLEOLE { get; set; }

        [StringLength(255)]
        public string VTTVND_BMPBMP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? USR_VTTVND_VALFLE { get; set; }

        [StringLength(2)]
        public string USR_VTTVND_TIPCOMI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? USR_VTTVND_PORIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? USR_VTTVND_COMEXT { get; set; }

        public DateTime? VTTVND_FECALT { get; set; }

        public DateTime? VTTVND_FECMOD { get; set; }
        
        [StringLength(1)]
        public string VTTVND_ULTOPR { get; set; }

        [StringLength(1)]
        public string VTTVND_DEBAJA { get; set; }

        [StringLength(10)]
        public string VTTVND_HORMOV { get; set; }

        [StringLength(10)]
        public string VTTVND_MODULE { get; set; }

        [StringLength(10)]
        public string VTTVND_OALIAS { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VTTVND_TSTAMP { get; set; }

        [StringLength(6)]
        public string VTTVND_LOTTRA { get; set; }

        [StringLength(6)]
        public string VTTVND_LOTREC { get; set; }

        [StringLength(6)]
        public string VTTVND_LOTORI { get; set; }

        [StringLength(36)]
        public string VTTVND_USERID { get; set; }

        [StringLength(10)]
        public string VTTVND_SYSVER { get; set; }

        [StringLength(10)]
        public string VTTVND_CMPVER { get; set; }
    }
}
