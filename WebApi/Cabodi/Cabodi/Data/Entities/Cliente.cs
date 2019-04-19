namespace Cabodi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VTMCLH")]
    public partial class Cliente
    {
        [Key]
        [StringLength(13)]
        public string VTMCLH_NROCTA { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR01 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR03 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR04 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR05 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR06 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR07 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR08 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR09 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR10 { get; set; }

        [StringLength(13)]
        public string VTMCLH_RUBR02 { get; set; }

        [Required]
        [StringLength(120)]
        public string VTMCLH_NOMBRE { get; set; }

        [StringLength(13)]
        public string VTMCLH_NROSUB { get; set; }

        [StringLength(60)]
        public string VTMCLH_RESPON { get; set; }

        [StringLength(255)]
        public string VTMCLH_DIRECC { get; set; }

        [StringLength(6)]
        public string VTMCLH_NUMERO { get; set; }

        [StringLength(6)]
        public string VTMCLH_DPPISO { get; set; }

        [StringLength(6)]
        public string VTMCLH_DEPTOS { get; set; }

        [StringLength(6)]
        public string VTMCLH_CODFIL { get; set; }

        [Required]
        [StringLength(3)]
        public string VTMCLH_CODPAI { get; set; }

        [Required]
        [StringLength(10)]
        public string VTMCLH_CODPOS { get; set; }

        [StringLength(6)]
        public string VTMCLH_MUNICP { get; set; }

        [StringLength(1)]
        public string VTMCLH_FLETES { get; set; }

        [StringLength(30)]
        public string VTMCLH_TELEFN { get; set; }

        [StringLength(20)]
        public string VTMCLH_NROFAX { get; set; }

        [StringLength(15)]
        public string VTMCLH_NTELEX { get; set; }

        [Required]
        [StringLength(6)]
        public string VTMCLH_CNDIVA { get; set; }

        [StringLength(4)]
        public string VTMCLH_TIPDOC { get; set; }

        [StringLength(50)]
        public string VTMCLH_NRODOC { get; set; }

        [Required]
        [StringLength(6)]
        public string VTMCLH_VNDDOR { get; set; }

        [Required]
        [StringLength(6)]
        public string VTMCLH_COBRAD { get; set; }

        [Required]
        [StringLength(6)]
        public string VTMCLH_JURISD { get; set; }

        [Required]
        [StringLength(6)]
        public string VTMCLH_CODZON { get; set; }

        [StringLength(6)]
        public string VTMCLH_ACTIVD { get; set; }

        [StringLength(6)]
        public string VTMCLH_CATEGO { get; set; }

        [Required]
        [StringLength(6)]
        public string VTMCLH_CNDPAG { get; set; }

        [StringLength(10)]
        public string VTMCLH_CNDPRE { get; set; }

        [StringLength(6)]
        public string VTMCLH_CODCRD { get; set; }

        [StringLength(6)]
        public string VTMCLH_GRUBON { get; set; }

        [StringLength(6)]
        public string VTMCLH_CAMION { get; set; }

        [StringLength(6)]
        public string VTMCLH_CAMALT { get; set; }

        [StringLength(6)]
        public string VTMCLH_TRACOD { get; set; }

        [StringLength(2)]
        public string VTMCLH_DIREP1 { get; set; }

        [StringLength(2)]
        public string VTMCLH_DIREP2 { get; set; }

        [StringLength(2)]
        public string VTMCLH_DIREP3 { get; set; }

        [StringLength(2)]
        public string VTMCLH_DIREP4 { get; set; }

        [StringLength(2)]
        public string VTMCLH_DIREP5 { get; set; }

        [StringLength(20)]
        public string VTMCLH_HORREC { get; set; }

        [StringLength(255)]
        public string VTMCLH_DIRENT { get; set; }

        [StringLength(3)]
        public string VTMCLH_PAIENT { get; set; }

        [StringLength(10)]
        public string VTMCLH_CODENT { get; set; }

        [StringLength(6)]
        public string VTMCLH_JURENT { get; set; }

        [StringLength(6)]
        public string VTMCLH_ZONENT { get; set; }

        public short VTMCLH_COPIVT { get; set; }

        public short VTMCLH_COPIFC { get; set; }

        public short VTMCLH_COPIST { get; set; }

        [Column(TypeName = "text")]
        public string VTMCLH_TEXTOS { get; set; }

        [StringLength(4)]
        public string VTMCLH_TIPDO1 { get; set; }

        [StringLength(50)]
        public string VTMCLH_NRODO1 { get; set; }

        [StringLength(4)]
        public string VTMCLH_TIPDO2 { get; set; }

        [StringLength(50)]
        public string VTMCLH_NRODO2 { get; set; }

        [StringLength(4)]
        public string VTMCLH_TIPDO3 { get; set; }

        [StringLength(50)]
        public string VTMCLH_NRODO3 { get; set; }

        [StringLength(4)]
        public string VTMCLH_TIPDO4 { get; set; }

        [StringLength(50)]
        public string VTMCLH_NRODO4 { get; set; }

        [StringLength(4)]
        public string VTMCLH_TIPDO5 { get; set; }

        [StringLength(50)]
        public string VTMCLH_NRODO5 { get; set; }

        [StringLength(60)]
        public string VTMCLH_DIREML { get; set; }

        [StringLength(1)]
        public string VTMCLH_SEGPRO { get; set; }

        [StringLength(1)]
        public string VTMCLH_CONTAD { get; set; }

        [StringLength(1)]
        public string VTMCLH_EDISUB { get; set; }

        [StringLength(40)]
        public string VTMCLH_CUENTA { get; set; }

        public short? VTMCLH_MAXITM { get; set; }

        public short? VTMCLH_DIFDIA { get; set; }

        public DateTime? VTMCLH_DIFDES { get; set; }

        public DateTime? VTMCLH_DIFHAS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VTMCLH_PERINA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VTMCLH_IMPDIF { get; set; }

        [StringLength(60)]
        public string VTMCLH_EMAIL { get; set; }

        [StringLength(6)]
        public string VTMCLH_CNDINT { get; set; }

        [StringLength(1)]
        public string VTMCLH_DISTRI { get; set; }

        [StringLength(15)]
        public string VTMCLH_DEPOSI { get; set; }

        [StringLength(15)]
        public string VTMCLH_SECTOR { get; set; }

        [StringLength(13)]
        public string VTMCLH_NRODIS { get; set; }

        [Column(TypeName = "text")]
        public string VTMCLH_OLEOLE { get; set; }

        [StringLength(255)]
        public string VTMCLH_BMPBMP { get; set; }

        [StringLength(1)]
        public string VTMCLH_INHIBE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VTMCLH_PRMXPR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VTMCLH_PRMIPR { get; set; }

        [StringLength(1)]
        public string VTMCLH_TRAFCR { get; set; }

        [StringLength(6)]
        public string VTMCLH_CODCOF { get; set; }

        [StringLength(2)]
        public string VTMCLH_MODCPT { get; set; }

        [StringLength(1)]
        public string VTMCLH_TIPCPT { get; set; }

        [StringLength(6)]
        public string VTMCLH_CODCPT { get; set; }

        [StringLength(1)]
        public string VTMCLH_LISCLI { get; set; }

        [StringLength(6)]
        public string VTMCLH_TIPOPR { get; set; }

        [StringLength(30)]
        public string VTMCLH_CODOPR { get; set; }

        [StringLength(2)]
        public string VTMCLH_MODPAG { get; set; }

        [StringLength(1)]
        public string VTMCLH_TIPPAG { get; set; }

        [StringLength(6)]
        public string VTMCLH_MEDPAG { get; set; }

        [StringLength(1)]
        public string VTMCLH_LANEXP { get; set; }

        [StringLength(1)]
        public string VTMCLH_GENXML { get; set; }

        [StringLength(15)]
        public string VTMCLH_GLNDES { get; set; }

        [StringLength(6)]
        public string VTMCLH_CODEXP { get; set; }

        [StringLength(1)]
        public string VTMCLH_OBLCON { get; set; }

        [StringLength(15)]
        public string VTMCLH_DEPTRA { get; set; }

        [StringLength(15)]
        public string VTMCLH_SECTRA { get; set; }

        [Required]
        [StringLength(1)]
        public string VTMCLH_FISJUR { get; set; }

        [StringLength(60)]
        public string VTMCLH_APELL1 { get; set; }

        [StringLength(60)]
        public string VTMCLH_APELL2 { get; set; }

        [StringLength(60)]
        public string VTMCLH_NOMB01 { get; set; }

        [StringLength(60)]
        public string VTMCLH_NOMB02 { get; set; }

        public short? USR_VTMCLH_COMISI { get; set; }

        [Column(TypeName = "text")]
        public string USR_VTMCLH_ENTREGA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? USR_VTMCLH_COMEXT { get; set; }

        [StringLength(1)]
        public string USR_VTMCLH_FINOTA { get; set; }

        public DateTime? VTMCLH_FECALT { get; set; }

        public DateTime? VTMCLH_FECMOD { get; set; }

        [StringLength(1)]
        public string VTMCLH_ULTOPR { get; set; }

        [StringLength(1)]
        public string VTMCLH_DEBAJA { get; set; }

        [StringLength(10)]
        public string VTMCLH_HORMOV { get; set; }

        [StringLength(10)]
        public string VTMCLH_MODULE { get; set; }

        [StringLength(10)]
        public string VTMCLH_OALIAS { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VTMCLH_TSTAMP { get; set; }

        [StringLength(6)]
        public string VTMCLH_LOTTRA { get; set; }

        [StringLength(6)]
        public string VTMCLH_LOTREC { get; set; }

        [StringLength(6)]
        public string VTMCLH_LOTORI { get; set; }

        [StringLength(36)]
        public string VTMCLH_USERID { get; set; }

        [StringLength(10)]
        public string VTMCLH_SYSVER { get; set; }

        [StringLength(10)]
        public string VTMCLH_CMPVER { get; set; }

        [StringLength(250)]
        public string USR_VTMCLH_CONAPP { get; set; }
    }
}
