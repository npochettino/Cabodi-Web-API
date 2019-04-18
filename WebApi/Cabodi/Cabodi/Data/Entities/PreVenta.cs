namespace Cabodi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FCRMVH")]
    public partial class PreVenta
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string FCRMVH_MODFOR { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string FCRMVH_CODFOR { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FCRMVH_NROFOR { get; set; }

        [Required]
        [StringLength(6)]
        public string FCRMVH_CIRCOM { get; set; }

        [Required]
        [StringLength(6)]
        public string FCRMVH_CIRAPL { get; set; }

        [StringLength(6)]
        public string FCRMVH_SUCURS { get; set; }

        public DateTime FCRMVH_FCHMOV { get; set; }

        [Required]
        [StringLength(13)]
        public string FCRMVH_NROCTA { get; set; }

        [StringLength(13)]
        public string FCRMVH_NROSUB { get; set; }

        [StringLength(6)]
        public string FCRMVH_MASCAR { get; set; }

        [StringLength(255)]
        public string FCRMVH_DIRENT { get; set; }

        [StringLength(3)]
        public string FCRMVH_PAIENT { get; set; }

        [StringLength(10)]
        public string FCRMVH_CODENT { get; set; }

        [StringLength(6)]
        public string FCRMVH_CAMION { get; set; }

        [Required]
        [StringLength(6)]
        public string FCRMVH_VNDDOR { get; set; }

        [Required]
        [StringLength(6)]
        public string FCRMVH_CNDPAG { get; set; }

        [StringLength(15)]
        public string FCRMVH_DEPOSI { get; set; }

        [StringLength(15)]
        public string FCRMVH_SECTOR { get; set; }

        [Required]
        [StringLength(10)]
        public string FCRMVH_CODLIS { get; set; }

        public DateTime? FCRMVH_FECLIS { get; set; }

        [StringLength(1)]
        public string FCRMVH_CONGEL { get; set; }

        [StringLength(6)]
        public string FCRMVH_GRUBON { get; set; }

        [StringLength(6)]
        public string FCRMVH_TRACOD { get; set; }

        [StringLength(60)]
        public string FCRMVH_TRANSP { get; set; }

        [StringLength(4)]
        public string FCRMVH_TIPDOC { get; set; }

        [StringLength(50)]
        public string FCRMVH_TRCUIT { get; set; }

        [StringLength(60)]
        public string FCRMVH_TRANDR { get; set; }

        [Column(TypeName = "text")]
        public string FCRMVH_TEXTOS { get; set; }

        [StringLength(2)]
        public string FCRMVH_MODGEN { get; set; }

        [Required]
        [StringLength(6)]
        public string FCRMVH_CODGEN { get; set; }

        [StringLength(2)]
        public string FCRMVH_MODULO { get; set; }

        [StringLength(6)]
        public string FCRMVH_COFLIS { get; set; }

        [StringLength(6)]
        public string FCRMVH_COFFAC { get; set; }

        [StringLength(6)]
        public string FCRMVH_COFDEU { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_CAMBIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_CAMUSS { get; set; }

        [Required]
        [StringLength(6)]
        public string FCRMVH_CIRGEN { get; set; }

        public short? FCRMVH_IMPRES { get; set; }

        public int FCRMVH_NROGEN { get; set; }

        [StringLength(6)]
        public string FCRMVH_IMPTCN { get; set; }

        [StringLength(120)]
        public string FCRMVH_NOMBRE { get; set; }

        [StringLength(255)]
        public string FCRMVH_DIRECC { get; set; }

        [StringLength(3)]
        public string FCRMVH_CODPAI { get; set; }

        [StringLength(10)]
        public string FCRMVH_CODPOS { get; set; }

        [StringLength(6)]
        public string FCRMVH_CONIVA { get; set; }

        [StringLength(4)]
        public string FCRMVH_CNTPDC { get; set; }

        [StringLength(50)]
        public string FCRMVH_NRODOC { get; set; }

        [StringLength(6)]
        public string FCRMVH_DIMOBL { get; set; }

        [StringLength(40)]
        public string FCRMVH_SUBCUE { get; set; }

        [StringLength(6)]
        public string FCRMVH_DIMORI { get; set; }

        [StringLength(40)]
        public string FCRMVH_SUBORI { get; set; }

        [Required]
        [StringLength(6)]
        public string FCRMVH_JURISD { get; set; }

        [StringLength(15)]
        public string FCRMVH_DEPTRA { get; set; }

        [StringLength(15)]
        public string FCRMVH_SECTRA { get; set; }

        [StringLength(2)]
        public string FCRMVH_MODOCJ { get; set; }

        [StringLength(6)]
        public string FCRMVH_CODOCJ { get; set; }

        public int? FCRMVH_NROOCJ { get; set; }

        [StringLength(2)]
        public string FCRMVH_MODOST { get; set; }

        [StringLength(6)]
        public string FCRMVH_CODOST { get; set; }

        public int? FCRMVH_NROOST { get; set; }

        [StringLength(6)]
        public string FCRMVH_CNDIVA { get; set; }

        public DateTime? FCRMVH_FCHDES { get; set; }

        public DateTime? FCRMVH_FCHHAS { get; set; }

        [StringLength(1)]
        public string FCRMVH_CONBON { get; set; }

        [StringLength(1)]
        public string FCRMVH_CLPRFA { get; set; }

        public short? FCRMVH_ESTAUT { get; set; }

        [StringLength(36)]
        public string FCRMVH_USRAUT { get; set; }

        public DateTime? FCRMVH_FCHAUT { get; set; }

        [Column(TypeName = "text")]
        public string FCRMVH_OLEOLE { get; set; }

        [StringLength(255)]
        public string FCRMVH_BMPBMP { get; set; }

        public DateTime? FCRMVH_FCHVEN { get; set; }

        [StringLength(2)]
        public string FCRMVH_MODFCR { get; set; }

        [StringLength(6)]
        public string FCRMVH_CODFCR { get; set; }

        public int? FCRMVH_NROFCR { get; set; }

        public DateTime? FCRMVH_FECFCR { get; set; }

        [StringLength(2)]
        public string FCRMVH_MODFST { get; set; }

        [StringLength(6)]
        public string FCRMVH_CODFST { get; set; }

        public int? FCRMVH_NROFST { get; set; }

        [StringLength(1)]
        public string FCRMVH_ACCFST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_CAMSEC { get; set; }

        [StringLength(6)]
        public string FCRMVH_TIPOPR { get; set; }

        [StringLength(30)]
        public string FCRMVH_CODOPR { get; set; }

        public short? FCRMVH_DIAENT { get; set; }

        [StringLength(60)]
        public string FCRMVH_HORENT { get; set; }

        [StringLength(60)]
        public string FCRMVH_CONTAC { get; set; }

        [StringLength(30)]
        public string FCRMVH_TELEFN { get; set; }

        [StringLength(6)]
        public string FCRMVH_CODZON { get; set; }

        [StringLength(6)]
        public string FCRMVH_MUNICP { get; set; }

        [StringLength(1)]
        public string FCRMVH_ISPRCT { get; set; }

        [StringLength(13)]
        public string FCRMVH_CTAEN1 { get; set; }

        [StringLength(6)]
        public string FCRMVH_CDENT1 { get; set; }

        [StringLength(13)]
        public string FCRMVH_CTAEN2 { get; set; }

        [StringLength(6)]
        public string FCRMVH_CDENT2 { get; set; }

        [StringLength(10)]
        public string FCRMVH_CODEMP { get; set; }

        [StringLength(10)]
        public string FCRMVH_EMPFCR { get; set; }

        [StringLength(10)]
        public string FCRMVH_EMPGEN { get; set; }

        [StringLength(10)]
        public string FCRMVH_EMPOCJ { get; set; }

        [StringLength(10)]
        public string FCRMVH_EMPOST { get; set; }

        [StringLength(10)]
        public string FCRMVH_EMPFST { get; set; }

        [StringLength(1)]
        public string FCRMVH_CANANT { get; set; }

        [StringLength(4)]
        public string FCRMVH_COMORI { get; set; }

        [StringLength(20)]
        public string FCRMVH_CODORI { get; set; }

        [StringLength(6)]
        public string FCRMVH_JURCTD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTDES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTFIN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_TASAIN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTBF1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTBF2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTBF3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTBF4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTBF5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTBL1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTBL2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTBL3 { get; set; }

        public short? FCRMVH_DIADI1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTDI1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTDM1 { get; set; }

        public short? FCRMVH_DIADI2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTDI2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTDM2 { get; set; }

        public short? FCRMVH_DIADI3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTDI3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_PCTDM3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCRMVH_DIALIB { get; set; }

        [StringLength(1)]
        public string FCRMVH_EDVACP { get; set; }

        [StringLength(6)]
        public string FCRMVH_DOCFIS { get; set; }

        [StringLength(6)]
        public string FCRMVH_LETFIS { get; set; }

        [StringLength(6)]
        public string FCRMVH_SUCFIS { get; set; }

        public int? FCRMVH_NROFIS { get; set; }

        [StringLength(6)]
        public string FCRMVH_CNDCOM { get; set; }

        [StringLength(6)]
        public string FCRMVH_TIPEXP { get; set; }

        [StringLength(2)]
        public string USR_FCRMVH_ESTAUT { get; set; }

        public DateTime? FCRMVH_FECALT { get; set; }

        public DateTime? FCRMVH_FECMOD { get; set; }

        [StringLength(36)]
        public string FCRMVH_USERID { get; set; }

        [StringLength(1)]
        public string FCRMVH_ULTOPR { get; set; }

        [StringLength(1)]
        public string FCRMVH_DEBAJA { get; set; }

        [StringLength(10)]
        public string FCRMVH_HORMOV { get; set; }

        [StringLength(10)]
        public string FCRMVH_MODULE { get; set; }

        [StringLength(10)]
        public string FCRMVH_OALIAS { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FCRMVH_TSTAMP { get; set; }

        [StringLength(6)]
        public string FCRMVH_LOTTRA { get; set; }

        [StringLength(6)]
        public string FCRMVH_LOTREC { get; set; }

        [StringLength(6)]
        public string FCRMVH_LOTORI { get; set; }

        [StringLength(10)]
        public string FCRMVH_SYSVER { get; set; }

        [StringLength(10)]
        public string FCRMVH_CMPVER { get; set; }

        [StringLength(20)]
        public string FCRMVH_NROCAE { get; set; }

        [StringLength(3)]
        public string FCRMVH_AUXDEV { get; set; }

        [StringLength(6)]
        public string FCRMVH_MOTDEV { get; set; }

        [StringLength(6)]
        public string FCRMVH_EMBARQ { get; set; }

        [StringLength(6)]
        public string FCRMVH_AERPUE { get; set; }
    }
}
