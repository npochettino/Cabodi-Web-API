using Cabodi.Data.Entities;

namespace Cabodi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CabodiContext : DbContext
    {
        public CabodiContext()
            : base("name=CabodiModel")
        {
        }

        public virtual DbSet<PreVenta> Preventa { get; set; }
        public virtual DbSet<ItemPreVenta> ItemPreVentas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<TipoProducto> TipoProductos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Vendedor> Vendedores { get; set; }
        public virtual DbSet<ListaPrecio> ListaPrecios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MODFOR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODFOR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CIRCOM)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CIRAPL)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_SUCURS)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_NROCTA)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_NROSUB)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MASCAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DIRENT)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PAIENT)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODENT)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CAMION)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_VNDDOR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CNDPAG)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DEPOSI)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_SECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODLIS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CONGEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_GRUBON)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TRACOD)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TRANSP)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TIPDOC)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TRCUIT)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TRANDR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TEXTOS)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MODGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MODULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_COFLIS)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_COFFAC)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_COFDEU)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CAMBIO)
                .HasPrecision(20, 8);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CAMUSS)
                .HasPrecision(20, 8);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CIRGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_IMPTCN)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DIRECC)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODPAI)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODPOS)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CONIVA)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CNTPDC)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_NRODOC)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DIMOBL)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_SUBCUE)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DIMORI)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_SUBORI)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_JURISD)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DEPTRA)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_SECTRA)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MODOCJ)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODOCJ)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MODOST)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODOST)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CNDIVA)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CONBON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CLPRFA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_USRAUT)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_OLEOLE)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_BMPBMP)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MODFCR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODFCR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MODFST)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODFST)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_ACCFST)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CAMSEC)
                .HasPrecision(20, 8);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TIPOPR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODOPR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_HORENT)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CONTAC)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TELEFN)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODZON)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MUNICP)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_ISPRCT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CTAEN1)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CDENT1)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CTAEN2)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CDENT2)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODEMP)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_EMPFCR)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_EMPGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_EMPOCJ)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_EMPOST)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_EMPFST)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CANANT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_COMORI)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CODORI)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_JURCTD)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTDES)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTFIN)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TASAIN)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTBF1)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTBF2)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTBF3)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTBF4)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTBF5)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTBL1)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTBL2)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTBL3)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTDI1)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTDM1)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTDI2)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTDM2)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTDI3)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_PCTDM3)
                .HasPrecision(15, 7);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DIALIB)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_EDVACP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DOCFIS)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_LETFIS)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_SUCFIS)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CNDCOM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TIPEXP)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.USR_FCRMVH_ESTAUT)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_USERID)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_ULTOPR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_DEBAJA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_HORMOV)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_OALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_TSTAMP)
                .IsFixedLength();

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_LOTTRA)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_LOTREC)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_LOTORI)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_SYSVER)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_CMPVER)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_NROCAE)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_AUXDEV)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_MOTDEV)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_OLDUID)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_EMBARQ)
                .IsUnicode(false);

            modelBuilder.Entity<PreVenta>()
                .Property(e => e.FCRMVH_AERPUE)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MODFOR)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODFOR)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NIVEXP)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MODAPL)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODAPL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_EXPAPL)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TIPPRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_ARTCOD)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MODCPT)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TIPCPT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODCPT)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TIPORI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_ARTORI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NSERIE)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NDESPA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_ENVASE)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NOTROS)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NATRIB)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NESTAN)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NUBICA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NFECHA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TSERIE)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TDESPA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TENVAS)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TOTROS)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TATRIB)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TESTAN)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TUBICA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TFECHA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_DEPOSI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_SECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_SUCURS)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NROCTA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NROSUB)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_OLDPRE)
                .HasPrecision(20, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NEWPRE)
                .HasPrecision(20, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PRECIO)
                .HasPrecision(20, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CANTID)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_FACSEC)
                .HasPrecision(12, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTSEC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_UNIMED)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_UNISEC)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TIPUNI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_UNIFAC)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_FACFAC)
                .HasPrecision(12, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTFAC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_UNIALT)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_FACALT)
                .HasPrecision(12, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTALT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_UNICON)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_FACCON)
                .HasPrecision(12, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTCON)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF1)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF2)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF3)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF4)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF5)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF6)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF7)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF8)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBF9)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTBFN)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TEXTOS)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTPEN)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MODORI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODORI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_EXPORI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTBON)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTANT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PORANT)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_ARTEQU)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CANTST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTORI)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MCDAPL)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CCDAPL)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_DEPTRA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_SECTRA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MODINI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODINI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NIVINI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_COFLIS)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CAMBIO)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MODGAN)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODGAN)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTVAR)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CNTUNI)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_FACTOR)
                .HasPrecision(12, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NCNPNA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NGENPN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NCANPN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_NGENST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PRESEC)
                .HasPrecision(20, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TIPOPR)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODOPR)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODEMP)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_EMPAPL)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_EMPGAN)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_EMPINI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_EMPORI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PCTCOM)
                .HasPrecision(15, 7);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MODOST)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODOST)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_EXPOST)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_EMPOST)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PRENAC)
                .HasPrecision(20, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PREEXT)
                .HasPrecision(20, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_PREUSS)
                .HasPrecision(20, 6);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TOTLIN)
                .HasPrecision(15, 4);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODPRO)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CODTAR)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_USERID)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_ULTOPR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_DEBAJA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_HORMOV)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_OALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_TSTAMP)
                .IsFixedLength();

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_LOTTRA)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_LOTREC)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_LOTORI)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_SYSVER)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CMPVER)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_OLDUID)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_CANCEL)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPreVenta>()
                .Property(e => e.FCRMVI_AERPUE)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TIPPRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_ARTCOD)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DESCRP)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PESCTR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PESFAC)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PESMAX)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PESMIN)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TEXTOS)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNIMED)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNISEC)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNIPES)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_STKMIN)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_STKMAX)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PTOPED)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_LOTFAB)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_LOTCPA)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PREREF)
                .HasPrecision(20, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MONREF)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEFSER)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DDEREF)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEFDES)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEFENV)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEFOTR)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TIPPRQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_ARTCOQ)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MODCPT)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TIPCPT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CODCPT)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_ARTDIS)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR01)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR02)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR03)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR04)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR05)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR06)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR07)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR08)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR09)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RUBR10)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNIFAC)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNIALT)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNICON)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FACFAC)
                .HasPrecision(12, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FACALT)
                .HasPrecision(12, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FACCON)
                .HasPrecision(12, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNIFCO)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNIACO)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_UNICCO)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FACFCO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FACACO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FACCCO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MODCPC)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TIPCPC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CODCPC)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TOLCOM)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TOLVEN)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TOLPRO)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CUENVT)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CUENPV)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PREREP)
                .HasPrecision(20, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MONREP)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PREUCO)
                .HasPrecision(20, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MONUCO)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DDEREP)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PREPRD)
                .HasPrecision(20, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MONPRD)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_BIEUSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DDEUCO)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_KITSFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_KITSCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FORMFC)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FORMCO)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_EDCOCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DDEPRD)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_EDCACO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_EDCOFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_EDCAFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_ARGCOS)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_GASIMP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_METPRO)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CLASAR)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_SIMUPD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_SIMUFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_SIMUCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PROVE1)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PROVE2)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PCTCFV)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PCTCFC)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_INDCOD)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DESCAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_OLEOLE)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_BMPBMP)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TIPGAS)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_EXPRES)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_POCOSTO)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_AGRUMP)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CODFAM)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MONGAS)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEFFEC)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEFATR)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEFUBI)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEFEST)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PRMXPR)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PRMIPR)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_FACSEC)
                .HasPrecision(12, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MINSEC)
                .HasPrecision(15, 4);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MAXSEC)
                .HasPrecision(15, 4);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CTRLBF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PORBOF)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CTRLBC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PORBOC)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_NVRPRE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CODREG)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_REFSEC)
                .HasPrecision(20, 6);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_HABRET)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TLFFAC)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TLFALT)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TLFCON)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TLCFAC)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TLCALT)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TLCCON)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MASCLP)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_APLTOT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.USR_STMPDH_NOMMER)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_USERID)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_ULTOPR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_DEBAJA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_HORMOV)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_OALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TSTAMP)
                .IsFixedLength();

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_LOTTRA)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_LOTREC)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_LOTORI)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_SYSVER)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CMPVER)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_PESUNI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CODMER)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CODSEC)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CODMTX)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_OBSERV)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_NOMCOT)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TRAZAB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CNMMAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_HABIME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_ESTAMO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_COMORI)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_OLDUID)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_CLASIF)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_RECALC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_TIPFAM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.STMPDH_ARTFAM)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_TIPPRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_DESCRP)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_STOCKS)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKAR)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKSR)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKDS)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKEN)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKOT)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKFE)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKAT)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKUB)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MASKES)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_HABIFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_HABICO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_HABIPD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_ANIDAD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_OLEOLE)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_BMPBMP)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_TRUSEC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_RQUSEC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_NUMAUT)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_TEXTOS)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_ATMNUM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_NUMPOR)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.USR_STTTPH_ORDEN)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_USERID)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_ULTOPR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_DEBAJA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_HORMOV)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_OALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_TSTAMP)
                .IsFixedLength();

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_LOTTRA)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_LOTREC)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_LOTORI)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_SYSVER)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_CMPVER)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_HABIME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_BIEUSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_CARATR)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.STTTPH_OLDUID)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NROCTA)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR01)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR03)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR04)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR05)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR06)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR07)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR08)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR09)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR10)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RUBR02)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NROSUB)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_RESPON)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DIRECC)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DPPISO)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DEPTOS)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODFIL)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODPAI)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODPOS)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_MUNICP)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_FLETES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TELEFN)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NROFAX)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NTELEX)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CNDIVA)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPDOC)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NRODOC)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_VNDDOR)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_COBRAD)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_JURISD)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODZON)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_ACTIVD)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CATEGO)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CNDPAG)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CNDPRE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODCRD)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_GRUBON)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CAMION)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CAMALT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TRACOD)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DIREP1)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DIREP2)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DIREP3)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DIREP4)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DIREP5)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_HORREC)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DIRENT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_PAIENT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODENT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_JURENT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_ZONENT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TEXTOS)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPDO1)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NRODO1)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPDO2)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NRODO2)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPDO3)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NRODO3)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPDO4)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NRODO4)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPDO5)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NRODO5)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DIREML)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_SEGPRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CONTAD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_EDISUB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_PERINA)
                .HasPrecision(6, 0);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CNDINT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DISTRI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DEPOSI)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_SECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NRODIS)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_OLEOLE)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_BMPBMP)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_INHIBE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_PRMXPR)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_PRMIPR)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TRAFCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODCOF)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_MODCPT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPCPT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODCPT)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_LISCLI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPOPR)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODOPR)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_MODPAG)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TIPPAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_MEDPAG)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_LANEXP)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_GENXML)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_GLNDES)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CODEXP)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_OBLCON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DEPTRA)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_SECTRA)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_FISJUR)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_APELL1)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_APELL2)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NOMB01)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_NOMB02)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.USR_VTMCLH_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.USR_VTMCLH_COMEXT)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.USR_VTMCLH_FINOTA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_OLDUID)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_ULTOPR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_DEBAJA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_HORMOV)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_OALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_TSTAMP)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_LOTTRA)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_LOTREC)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_LOTORI)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_USERID)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_SYSVER)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTMCLH_CMPVER)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_VNDDOR)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_DESCRP)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_GRUCOM)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_PORCEN)
                .HasPrecision(15, 7);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_LEGAJO)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_NATMER)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_TIPLIQ)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_CODPAI)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_CODPOS)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_NROTEL)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_CAMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_OLEOLE)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_BMPBMP)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.USR_VTTVND_VALFLE)
                .HasPrecision(14, 8);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.USR_VTTVND_TIPCOMI)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.USR_VTTVND_PORIVA)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.USR_VTTVND_COMEXT)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_OLDUID)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_ULTOPR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_DEBAJA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_HORMOV)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_OALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_TSTAMP)
                .IsFixedLength();

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_LOTTRA)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_LOTREC)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_LOTORI)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_USERID)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_SYSVER)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.VTTVND_CMPVER)
                .IsUnicode(false);
        }
    }
}
