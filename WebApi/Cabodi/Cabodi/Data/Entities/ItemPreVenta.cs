namespace Cabodi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FCRMVI")]
    public partial class ItemPreVenta
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string FCRMVI_MODFOR { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string FCRMVI_CODFOR { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FCRMVI_NROFOR { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FCRMVI_NROITM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string FCRMVI_NIVEXP { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string FCRMVI_MODAPL { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(6)]
        public string FCRMVI_CODAPL { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FCRMVI_NROAPL { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FCRMVI_ITMAPL { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(3)]
        public string FCRMVI_EXPAPL { get; set; }

        [Required]
        [StringLength(6)]
        public string FCRMVI_TIPPRO { get; set; }

        [Required]
        [StringLength(30)]
        public string FCRMVI_ARTCOD { get; set; }

        [StringLength(2)]
        public string FCRMVI_MODCPT { get; set; }

        [StringLength(1)]
        public string FCRMVI_TIPCPT { get; set; }

        [StringLength(6)]
        public string FCRMVI_CODCPT { get; set; }

        [StringLength(6)]
        public string FCRMVI_TIPORI { get; set; }

        [StringLength(30)]
        public string FCRMVI_ARTORI { get; set; }

        [StringLength(30)]
        public string FCRMVI_NSERIE { get; set; }

        [StringLength(30)]
        public string FCRMVI_NDESPA { get; set; }

        [StringLength(30)]
        public string FCRMVI_ENVASE { get; set; }

        [StringLength(30)]
        public string FCRMVI_NOTROS { get; set; }

        [StringLength(30)]
        public string FCRMVI_NATRIB { get; set; }

        [StringLength(30)]
        public string FCRMVI_NESTAN { get; set; }

        [StringLength(30)]
        public string FCRMVI_NUBICA { get; set; }

        [StringLength(30)]
        public string FCRMVI_NFECHA { get; set; }

        [StringLength(30)]
        public string FCRMVI_TSERIE { get; set; }

        [StringLength(30)]
        public string FCRMVI_TDESPA { get; set; }

        [StringLength(30)]
        public string FCRMVI_TENVAS { get; set; }

        [StringLength(30)]
        public string FCRMVI_TOTROS { get; set; }

        [StringLength(30)]
        public string FCRMVI_TATRIB { get; set; }

        [StringLength(30)]
        public string FCRMVI_TESTAN { get; set; }

        [StringLength(30)]
        public string FCRMVI_TUBICA { get; set; }

        [StringLength(30)]
        public string FCRMVI_TFECHA { get; set; }

        [StringLength(15)]
        public string FCRMVI_DEPOSI { get; set; }

        [StringLength(15)]
        public string FCRMVI_SECTOR { get; set; }

        [StringLength(6)]
        public string FCRMVI_SUCURS { get; set; }

        [StringLength(13)]
        public string FCRMVI_NROCTA { get; set; }

        [StringLength(13)]
        public string FCRMVI_NROSUB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_OLDPRE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_NEWPRE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PRECIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CANTID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_FACSEC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTSEC { get; set; }

        [StringLength(6)]
        public string FCRMVI_UNIMED { get; set; }

        [StringLength(6)]
        public string FCRMVI_UNISEC { get; set; }

        [StringLength(1)]
        public string FCRMVI_TIPUNI { get; set; }

        [StringLength(6)]
        public string FCRMVI_UNIFAC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_FACFAC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTFAC { get; set; }

        [StringLength(6)]
        public string FCRMVI_UNIALT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_FACALT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTALT { get; set; }

        [StringLength(6)]
        public string FCRMVI_UNICON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_FACCON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTCON { get; set; }

        public DateTime? FCRMVI_FCHENT { get; set; }

        public DateTime? FCRMVI_FCHHAS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBF9 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTBFN { get; set; }

        [Column(TypeName = "text")]
        public string FCRMVI_TEXTOS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTPEN { get; set; }

        [StringLength(2)]
        public string FCRMVI_MODORI { get; set; }

        [StringLength(6)]
        public string FCRMVI_CODORI { get; set; }

        public int? FCRMVI_NROORI { get; set; }

        public int? FCRMVI_ITMORI { get; set; }

        [StringLength(3)]
        public string FCRMVI_EXPORI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTBON { get; set; }

        [StringLength(40)]
        public string FCRMVI_CUENTA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTANT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PORANT { get; set; }

        [StringLength(60)]
        public string FCRMVI_ARTEQU { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CANTST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTORI { get; set; }

        [StringLength(2)]
        public string FCRMVI_MCDAPL { get; set; }

        [StringLength(6)]
        public string FCRMVI_CCDAPL { get; set; }

        [StringLength(15)]
        public string FCRMVI_DEPTRA { get; set; }

        [StringLength(15)]
        public string FCRMVI_SECTRA { get; set; }

        [StringLength(2)]
        public string FCRMVI_MODINI { get; set; }

        [StringLength(6)]
        public string FCRMVI_CODINI { get; set; }

        public int? FCRMVI_NROINI { get; set; }

        public int? FCRMVI_ITMINI { get; set; }

        [StringLength(3)]
        public string FCRMVI_NIVINI { get; set; }

        [StringLength(6)]
        public string FCRMVI_COFLIS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CAMBIO { get; set; }

        [StringLength(2)]
        public string FCRMVI_MODGAN { get; set; }

        [StringLength(6)]
        public string FCRMVI_CODGAN { get; set; }

        public int? FCRMVI_NROGAN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTVAR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_CNTUNI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_FACTOR { get; set; }

        [StringLength(1)]
        public string FCRMVI_NCNPNA { get; set; }

        [StringLength(1)]
        public string FCRMVI_NGENPN { get; set; }

        [StringLength(1)]
        public string FCRMVI_NCANPN { get; set; }

        [StringLength(1)]
        public string FCRMVI_NGENST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PRESEC { get; set; }

        [StringLength(6)]
        public string FCRMVI_TIPOPR { get; set; }

        [StringLength(30)]
        public string FCRMVI_CODOPR { get; set; }

        [StringLength(10)]
        public string FCRMVI_CODEMP { get; set; }

        [StringLength(10)]
        public string FCRMVI_EMPAPL { get; set; }

        [StringLength(10)]
        public string FCRMVI_EMPGAN { get; set; }

        [StringLength(10)]
        public string FCRMVI_EMPINI { get; set; }

        [StringLength(10)]
        public string FCRMVI_EMPORI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PCTCOM { get; set; }

        [StringLength(2)]
        public string FCRMVI_MODOST { get; set; }

        [StringLength(6)]
        public string FCRMVI_CODOST { get; set; }

        public int? FCRMVI_NROOST { get; set; }

        public int? FCRMVI_ITMOST { get; set; }

        [StringLength(3)]
        public string FCRMVI_EXPOST { get; set; }

        [StringLength(10)]
        public string FCRMVI_EMPOST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PRENAC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PREEXT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_PREUSS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVI_TOTLIN { get; set; }

        [StringLength(40)]
        public string FCRMVI_CODPRO { get; set; }

        [StringLength(20)]
        public string FCRMVI_CODTAR { get; set; }

        public DateTime? FCRMVI_FECALT { get; set; }

        public DateTime? FCRMVI_FECMOD { get; set; }

        [StringLength(36)]
        public string FCRMVI_USERID { get; set; }

        [StringLength(1)]
        public string FCRMVI_ULTOPR { get; set; }

        [StringLength(1)]
        public string FCRMVI_DEBAJA { get; set; }

        [StringLength(10)]
        public string FCRMVI_HORMOV { get; set; }

        [StringLength(10)]
        public string FCRMVI_MODULE { get; set; }

        [StringLength(10)]
        public string FCRMVI_OALIAS { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FCRMVI_TSTAMP { get; set; }

        [StringLength(6)]
        public string FCRMVI_LOTTRA { get; set; }

        [StringLength(6)]
        public string FCRMVI_LOTREC { get; set; }

        [StringLength(6)]
        public string FCRMVI_LOTORI { get; set; }

        [StringLength(10)]
        public string FCRMVI_SYSVER { get; set; }

        [StringLength(10)]
        public string FCRMVI_CMPVER { get; set; }

        [StringLength(15)]
        public string FCRMVI_OLDUID { get; set; }

        [StringLength(1)]
        public string FCRMVI_CANCEL { get; set; }

        [StringLength(6)]
        public string FCRMVI_AERPUE { get; set; }
    }
}
