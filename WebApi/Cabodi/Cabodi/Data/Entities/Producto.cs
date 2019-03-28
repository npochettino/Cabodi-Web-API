namespace Cabodi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STMPDH")]
    public partial class Producto
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string STMPDH_TIPPRO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string STMPDH_ARTCOD { get; set; }

        [Required]
        [StringLength(120)]
        public string STMPDH_DESCRP { get; set; }

        [StringLength(1)]
        public string STMPDH_PESCTR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PESFAC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PESMAX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PESMIN { get; set; }

        [Column(TypeName = "text")]
        public string STMPDH_TEXTOS { get; set; }

        [Required]
        [StringLength(6)]
        public string STMPDH_UNIMED { get; set; }

        [StringLength(6)]
        public string STMPDH_UNISEC { get; set; }

        [StringLength(6)]
        public string STMPDH_UNIPES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_STKMIN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_STKMAX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PTOPED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_LOTFAB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_LOTCPA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PREREF { get; set; }

        [StringLength(6)]
        public string STMPDH_MONREF { get; set; }

        public DateTime STMPDH_FECREF { get; set; }

        [Required]
        [StringLength(1)]
        public string STMPDH_DEFSER { get; set; }

        public int? STMPDH_LOTREF { get; set; }

        [StringLength(20)]
        public string STMPDH_DDEREF { get; set; }

        [Required]
        [StringLength(1)]
        public string STMPDH_DEFDES { get; set; }

        [Required]
        [StringLength(1)]
        public string STMPDH_DEFENV { get; set; }

        [Required]
        [StringLength(1)]
        public string STMPDH_DEFOTR { get; set; }

        [StringLength(6)]
        public string STMPDH_TIPPRQ { get; set; }

        [StringLength(30)]
        public string STMPDH_ARTCOQ { get; set; }

        [StringLength(2)]
        public string STMPDH_MODCPT { get; set; }

        [StringLength(1)]
        public string STMPDH_TIPCPT { get; set; }

        [StringLength(6)]
        public string STMPDH_CODCPT { get; set; }

        [StringLength(50)]
        public string STMPDH_ARTDIS { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR01 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR02 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR03 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR04 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR05 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR06 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR07 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR08 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR09 { get; set; }

        [StringLength(30)]
        public string STMPDH_RUBR10 { get; set; }

        [StringLength(6)]
        public string STMPDH_UNIFAC { get; set; }

        [StringLength(6)]
        public string STMPDH_UNIALT { get; set; }

        [StringLength(6)]
        public string STMPDH_UNICON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_FACFAC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_FACALT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_FACCON { get; set; }

        [StringLength(6)]
        public string STMPDH_UNIFCO { get; set; }

        [StringLength(6)]
        public string STMPDH_UNIACO { get; set; }

        [StringLength(6)]
        public string STMPDH_UNICCO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_FACFCO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_FACACO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_FACCCO { get; set; }

        [StringLength(2)]
        public string STMPDH_MODCPC { get; set; }

        [StringLength(1)]
        public string STMPDH_TIPCPC { get; set; }

        [StringLength(6)]
        public string STMPDH_CODCPC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TOLCOM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TOLVEN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TOLPRO { get; set; }

        [StringLength(40)]
        public string STMPDH_CUENVT { get; set; }

        [StringLength(40)]
        public string STMPDH_CUENPV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PREREP { get; set; }

        [StringLength(6)]
        public string STMPDH_MONREP { get; set; }

        public DateTime? STMPDH_FECREP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PREUCO { get; set; }

        [StringLength(6)]
        public string STMPDH_MONUCO { get; set; }

        public DateTime? STMPDH_FECUCO { get; set; }

        public int? STMPDH_LOTREP { get; set; }

        [StringLength(20)]
        public string STMPDH_DDEREP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PREPRD { get; set; }

        [StringLength(6)]
        public string STMPDH_MONPRD { get; set; }

        public DateTime? STMPDH_FECPRD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_UTILID { get; set; }

        [StringLength(1)]
        public string STMPDH_BIEUSO { get; set; }

        public int? STMPDH_LOTUCO { get; set; }

        [StringLength(20)]
        public string STMPDH_DDEUCO { get; set; }

        [StringLength(1)]
        public string STMPDH_KITSFC { get; set; }

        [StringLength(1)]
        public string STMPDH_KITSCO { get; set; }

        [StringLength(8)]
        public string STMPDH_FORMFC { get; set; }

        [StringLength(8)]
        public string STMPDH_FORMCO { get; set; }

        [StringLength(1)]
        public string STMPDH_EDCOCO { get; set; }

        public int? STMPDH_LOTPRD { get; set; }

        [StringLength(20)]
        public string STMPDH_DDEPRD { get; set; }

        [StringLength(1)]
        public string STMPDH_EDCACO { get; set; }

        [StringLength(1)]
        public string STMPDH_EDCOFC { get; set; }

        [StringLength(1)]
        public string STMPDH_EDCAFC { get; set; }

        [StringLength(6)]
        public string STMPDH_ARGCOS { get; set; }

        public short? STMPDH_CNTLIN { get; set; }

        [StringLength(1)]
        public string STMPDH_GASIMP { get; set; }

        [StringLength(1)]
        public string STMPDH_METPRO { get; set; }

        [StringLength(6)]
        public string STMPDH_CLASAR { get; set; }

        public short? STMPDH_DIAENT { get; set; }

        [StringLength(1)]
        public string STMPDH_SIMUPD { get; set; }

        [StringLength(1)]
        public string STMPDH_SIMUFC { get; set; }

        [StringLength(1)]
        public string STMPDH_SIMUCO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_VOLUME { get; set; }

        [StringLength(13)]
        public string STMPDH_PROVE1 { get; set; }

        [StringLength(13)]
        public string STMPDH_PROVE2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PCTCFV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PCTCFC { get; set; }

        [StringLength(30)]
        public string STMPDH_INDCOD { get; set; }

        [StringLength(1)]
        public string STMPDH_DESCAR { get; set; }

        [Column(TypeName = "text")]
        public string STMPDH_OLEOLE { get; set; }

        [StringLength(255)]
        public string STMPDH_BMPBMP { get; set; }

        [StringLength(1)]
        public string STMPDH_TIPGAS { get; set; }

        [StringLength(1)]
        public string STMPDH_EXPRES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_POCOSTO { get; set; }

        [StringLength(6)]
        public string STMPDH_AGRUMP { get; set; }

        [StringLength(6)]
        public string STMPDH_CODFAM { get; set; }

        [StringLength(6)]
        public string STMPDH_MONGAS { get; set; }

        [Required]
        [StringLength(1)]
        public string STMPDH_DEFFEC { get; set; }

        [Required]
        [StringLength(1)]
        public string STMPDH_DEFATR { get; set; }

        [Required]
        [StringLength(1)]
        public string STMPDH_DEFUBI { get; set; }

        [Required]
        [StringLength(1)]
        public string STMPDH_DEFEST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PRMXPR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PRMIPR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_FACSEC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_MINSEC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_MAXSEC { get; set; }

        [StringLength(1)]
        public string STMPDH_CTRLBF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PORBOF { get; set; }

        [StringLength(1)]
        public string STMPDH_CTRLBC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_PORBOC { get; set; }

        [StringLength(1)]
        public string STMPDH_NVRPRE { get; set; }

        [StringLength(6)]
        public string STMPDH_CODREG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_REFSEC { get; set; }

        [StringLength(1)]
        public string STMPDH_HABRET { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TLFFAC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TLFALT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TLFCON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TLCFAC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TLCALT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? STMPDH_TLCCON { get; set; }

        [StringLength(6)]
        public string STMPDH_MASCLP { get; set; }

        public short? STMPDH_CNTLIC { get; set; }

        [StringLength(1)]
        public string STMPDH_APLTOT { get; set; }

        [StringLength(10)]
        public string USR_STMPDH_NOMMER { get; set; }

        public DateTime? STMPDH_FECALT { get; set; }

        public DateTime? STMPDH_FECMOD { get; set; }

        [StringLength(36)]
        public string STMPDH_USERID { get; set; }

        [StringLength(1)]
        public string STMPDH_ULTOPR { get; set; }

        [StringLength(1)]
        public string STMPDH_DEBAJA { get; set; }

        [StringLength(10)]
        public string STMPDH_HORMOV { get; set; }

        [StringLength(10)]
        public string STMPDH_MODULE { get; set; }

        [StringLength(10)]
        public string STMPDH_OALIAS { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] STMPDH_TSTAMP { get; set; }

        [StringLength(6)]
        public string STMPDH_LOTTRA { get; set; }

        [StringLength(6)]
        public string STMPDH_LOTREC { get; set; }

        [StringLength(6)]
        public string STMPDH_LOTORI { get; set; }

        [StringLength(10)]
        public string STMPDH_SYSVER { get; set; }

        [StringLength(10)]
        public string STMPDH_CMPVER { get; set; }

        [StringLength(1)]
        public string STMPDH_PESUNI { get; set; }

        [StringLength(25)]
        public string STMPDH_CODMER { get; set; }

        [StringLength(25)]
        public string STMPDH_CODSEC { get; set; }

        [StringLength(25)]
        public string STMPDH_CODMTX { get; set; }

        [StringLength(6)]
        public string STMPDH_OBSERV { get; set; }

        [StringLength(25)]
        public string STMPDH_NOMCOT { get; set; }

        public short? STMPDH_UNIMTX { get; set; }

        [StringLength(1)]
        public string STMPDH_TRAZAB { get; set; }

        [StringLength(1)]
        public string STMPDH_CNMMAN { get; set; }

        [StringLength(1)]
        public string STMPDH_HABIME { get; set; }

        [StringLength(6)]
        public string STMPDH_ESTAMO { get; set; }

        [StringLength(4)]
        public string STMPDH_COMORI { get; set; }

        [StringLength(15)]
        public string STMPDH_OLDUID { get; set; }

        [StringLength(1)]
        public string STMPDH_CLASIF { get; set; }

        public short? STMPDH_ULTNIV { get; set; }

        [StringLength(1)]
        public string STMPDH_RECALC { get; set; }

        [StringLength(6)]
        public string STMPDH_TIPFAM { get; set; }

        [StringLength(30)]
        public string STMPDH_ARTFAM { get; set; }
    }
}
