using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;
using Cabodi.Data.Entities;
using Cabodi.Models;
using Cabodi.Models.Input;
using Cabodi.Models.Output;
using Microsoft.Ajax.Utilities;
using Cabodi.Data.Helper;

namespace Cabodi.Data.Repository
{
    public class CabodiRepository : ICabodiRepository
    {
        private readonly CabodiContext _context;
        private readonly IMapper _mapper;

        public CabodiRepository(CabodiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool SaveChanges()
        {
            // Only return success if at least one row was changed
            return (_context.SaveChanges()) > 0;
        }

        public async Task<bool> SaveChangesAsync()
        {
            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void AddPreventa(PreVenta preventa)
        {
            _context.Preventa.Add(preventa);
        }

        public async Task<ItemPreVenta[]> GetItemsPrevenAsync(int preventID)
        {
            var query = _context.ItemPreVentas
                .Where(p => p.FCRMVI_NROFOR == preventID)
                .Where(p => p.FCRMVI_MODFOR == "FC" &&
                            p.FCRMVI_CODFOR == "PREVEN");

            return await Task.Run(() => query.ToArrayAsync());
        }

        public async Task<PreVenta> GetPrevenAsync(int preventID)
        {
            var query = _context.Preventa
                .Where(p => p.FCRMVH_NROFOR == preventID)
                .Where(p => p.FCRMVH_MODFOR == "FC" &&
                       p.FCRMVH_CODFOR == "PREVEN");

            return await Task.Run(() => query.FirstOrDefaultAsync());
        }

        public void DeleteItemsPreven(ItemPreVenta[] items)
        {
            foreach (var item in items)
            {
                _context.ItemPreVentas.Remove(item);
            }
        }

        public void DeletePreven(PreVenta preven)
        {
            _context.Preventa.Remove(preven);
        }
    

        public PreVenta GetLastPreventa()
        {
            var preventa = _context.Preventa
                .Where(mf => mf.FCRMVH_MODFOR == "FC" 
                             && mf.FCRMVH_CODFOR == "PREVEN")
                .OrderByDescending(p => p.FCRMVH_NROFOR)
                .FirstOrDefault();

            return preventa;
        }

        public async Task<PreventaInternalModel[]> GetPreventasPorVendedorAsync(string id)
        {
            var date = DateTime.Now.AddDays(-30);
            var preventa = _context.Preventa
                .Where(mf => mf.FCRMVH_MODFOR == "FC"
                             && mf.FCRMVH_CODFOR == "PREVEN"
                             && mf.FCRMVH_USERID == id
                             && mf.FCRMVH_FCHMOV >= date)
                .ToList();

            var items = _context.ItemPreVentas
                .Where(i => i.FCRMVI_USERID == id &&
                            i.FCRMVI_CODFOR == "PREVEN" &&
                            i.FCRMVI_MODFOR == "FC" &&
                            i.FCRMVI_FECALT >= date)
                .ToList();

            var preventas_ = new List<PreventaInternalModel>();

            foreach (var p in preventa)
            {
                var itemspreven_ = items.Where(i => i.FCRMVI_NROFOR == p.FCRMVH_NROFOR &&
                                                    i.FCRMVI_CODFOR == "PREVEN" &&
                                                    i.FCRMVI_USERID == p.FCRMVH_USERID).ToList();
                var itemsp_ = new List<ItemPreventaInternalModel>();
                foreach (var i in itemspreven_)
                {
                    var itemActual = new ItemPreventaInternalModel()
                    {
                        NumeroItem = i.FCRMVI_NROITM,
                        Cantidad = i.FCRMVI_CANTID,
                        CodigoArticulo = i.FCRMVI_ARTCOD,
                        Precio = i.FCRMVI_PRECIO,
                        TipoProducto = i.FCRMVI_TIPPRO,
                        Total = i.FCRMVI_TOTLIN
                    };
                    itemsp_.Add(itemActual);
                }

                var prevenResult = new PreventaInternalModel()
                {
                    FechaDesde = p.FCRMVH_FCHDES,
                    FechaHasta = p.FCRMVH_FCHHAS,
                    FechaMovimiento = p.FCRMVH_FCHMOV,
                    NumeroCliente = p.FCRMVH_NROCTA,
                    UserName = p.FCRMVH_USERID,
                    NumeroPreventa = p.FCRMVH_NROFOR,
                    Observacion = p.FCRMVH_TEXTOS,
                    ItemsPreventa = itemsp_
                };
                preventas_.Add(prevenResult);
            }

            return await Task.Run(() => preventas_.ToArray());
        }

        public void AddItemPreventa(ItemPreVenta item)
        {
            _context.ItemPreVentas.Add(item);
        }

        //Auth
        public async Task<AuthOutputModel> ValidatePassword(AuthInternalModel model)
        {
            try
            {
                //string EPass = Common.ComputeHash(model.pass, "SHA512", null);

                var user = _context.Clientes
                    .Where(u => u.VTMCLH_NROCTA == model.user &&
                                //u.USR_VTMCLH_CONAPP == EPass &&
                                u.VTMCLH_NROCTA.Contains("Z"))
                    .FirstOrDefault();

                bool flag = Common.VerifyHash(model.pass, "SHA512", user.USR_VTMCLH_CONAPP);

                return await Task.Run(() => new AuthOutputModel()
                {
                    Valid = flag == false ? false : true,
                    Description = "",
                    nombre = flag == false ? "No Autentificado" : user.VTMCLH_NOMBRE
                });

            }
            catch (Exception ex)
            {
                return new AuthOutputModel()
                {
                    Valid = false,
                    Description = ex.Message

                };
            }
        }

        public async Task<Cliente> GetClienteAsync(string NROCTA)
        {
            var cliente = _context.Clientes
                .Where(c => c.VTMCLH_NROCTA == NROCTA)
                .FirstOrDefault();

            return await Task.Run(() => cliente);
        }

        //Clientes
        public async Task<Cliente[]> GetClientesAsync()
        {
            var query = _context.Clientes
                .OrderBy(t => t.VTMCLH_APELL1);

            return await query.ToArrayAsync();
        }

        public async Task<Cliente[]> GetClientesPorVendedorAsync(string vendedor)
        {
            var query = _context.Clientes
                .Where(c => c.VTMCLH_NRODIS == vendedor)
                .OrderBy(t => t.VTMCLH_APELL1);

            return await query.ToArrayAsync();
        }

        public Cliente GetCliente(string NROCTA)
        {
            var cliente = _context.Clientes
                .Where(c => c.VTMCLH_NROCTA == NROCTA)
                .FirstOrDefault();

            return cliente;
        }

        //Vendedores
        public async Task<Vendedor[]> GetVendedoresAsync()
        {
            var query = _context.Vendedores
                .OrderBy(t => t.VTTVND_DESCRP);

            return await query.ToArrayAsync();
        }

        //Productos
        public async Task<ProductoModel[]> GetProductosAsync()
        {
            var query2 = from lista in _context.ListaPrecios
                join productos in _context.Productos
                    on lista.STTPRE_ARTCOD equals productos.STMPDH_ARTCOD
                where lista.STTPRE_CODLIS == "LPMIIN0001" && 
                      lista.STTPRE_TIPPRO.Contains("MI") && 
                      (productos.STMPDH_INDCOD != null || productos.STMPDH_INDCOD != "")
                      select new ProductoModel
                      {
                          STMPDH_ARTCOD = productos.STMPDH_ARTCOD,
                          STMPDH_DESCRP = productos.STMPDH_DESCRP,
                          STMPDH_INDCOD = productos.STMPDH_INDCOD,
                          STMPDH_TIPPRO = productos.STMPDH_TIPPRO,
                          STMPDH_UNIMED = productos.STMPDH_UNIMED,
                          STMPDH_UNICON = productos.STMPDH_UNICON,
                          STTPRE_PRECIO = lista.STTPRE_PRECIO
                      };

            var grouped = query2.OrderByDescending(l => l.STTPRE_PRECIO).DistinctBy(c => c.STMPDH_INDCOD).ToList();

            return await Task.Run(() => grouped.ToArray());
        }

        public async Task<ProductoModel> GetProductoPorINDCODAsync(string INDCOD)
        {
            var query2 = from productos in _context.Productos
                join lista in _context.ListaPrecios
                    on productos.STMPDH_TIPPRO + productos.STMPDH_ARTCOD equals lista.STTPRE_TIPPRO + lista.STTPRE_ARTCOD
                where lista.STTPRE_CODLIS == "LPMIIN0001" && productos.STMPDH_INDCOD == INDCOD && productos.STMPDH_TIPPRO.Contains("MI")
                select new ProductoModel
                {
                    STMPDH_ARTCOD = productos.STMPDH_ARTCOD,
                    STMPDH_DESCRP = productos.STMPDH_DESCRP,
                    STMPDH_INDCOD = productos.STMPDH_INDCOD,
                    STMPDH_TIPPRO = productos.STMPDH_TIPPRO,
                    STMPDH_UNIMED = productos.STMPDH_UNIMED,
                    STMPDH_UNICON = productos.STMPDH_UNICON,
                    STTPRE_PRECIO = lista.STTPRE_PRECIO
                };

            var grouped = query2.OrderByDescending(l => l.STTPRE_PRECIO).FirstOrDefault();

            return await Task.Run(() => grouped);
        }

        public ProductoModel GetProductoPorINDCOD(string INDCOD)
        {
            var query2 = from productos in _context.Productos
                join lista in _context.ListaPrecios
                    on productos.STMPDH_TIPPRO + productos.STMPDH_ARTCOD equals lista.STTPRE_TIPPRO + lista.STTPRE_ARTCOD
                where lista.STTPRE_CODLIS == "LPMIIN0001" && productos.STMPDH_INDCOD == INDCOD && productos.STMPDH_TIPPRO.Contains("MI")
                select new ProductoModel
                {
                    STMPDH_ARTCOD = productos.STMPDH_ARTCOD,
                    STMPDH_DESCRP = productos.STMPDH_DESCRP,
                    STMPDH_INDCOD = productos.STMPDH_INDCOD,
                    STMPDH_TIPPRO = productos.STMPDH_TIPPRO,
                    STMPDH_UNIMED = productos.STMPDH_UNIMED,
                    STTPRE_PRECIO = lista.STTPRE_PRECIO,
                    STMPDH_UNICON = productos.STMPDH_UNICON
                };

            var grouped = query2.OrderByDescending(l => l.STTPRE_PRECIO).FirstOrDefault();

            return grouped;
        }

        public async Task<Producto> GetProductoPorTIPPRO_ARTCODAsync(string TIPPRO, string ARTCOD)
        {
            var query = _context.Productos
                .Where(t => t.STMPDH_TIPPRO == TIPPRO &&
                            t.STMPDH_ARTCOD == ARTCOD)
                .OrderBy(t => t.STMPDH_INDCOD);

            return await query.FirstOrDefaultAsync();
        }

        public Producto GetProductoPorTIPPRO_ARTCOD(string TIPPRO, string ARTCOD)
        {
            var query = _context.Productos
                .Where(t => t.STMPDH_TIPPRO == TIPPRO &&
                            t.STMPDH_ARTCOD == ARTCOD)
                .OrderBy(t => t.STMPDH_INDCOD);

            return query.FirstOrDefault();
        }

        //Lista de Precios
        public async Task<ListaPrecio[]> GetListaDePreciosAsync()
        {
            var query = _context.ListaPrecios
                .OrderBy(t => t.STTPRE_CODLIS);

            return await query.ToArrayAsync();
        }

    }
}