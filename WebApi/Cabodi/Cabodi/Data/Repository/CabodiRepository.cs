using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Cabodi.Data.Entities;
using Cabodi.Models;
using Cabodi.Models.Output;
using Microsoft.Ajax.Utilities;

namespace Cabodi.Data.Repository
{
    public class CabodiRepository : ICabodiRepository
    {
        private readonly CabodiContext _context;

        public CabodiRepository(CabodiContext context)
        {
            _context = context;
        }
        
        //Auth
        public async Task<AuthOutputModel> ValidatePassword(AuthInternalModel model)
        {
            try
            {
                bool valid;
                var user = _context.Clientes
                    .Where(u => u.VTMCLH_NROCTA == model.user &&
                                u.VTMCLH_NROCTA == model.pass &&
                                u.VTMCLH_NROCTA.Contains("Z"))
                    .FirstOrDefault();

                if (user == null)
                    valid = false;
                else
                    valid = true;

                return new AuthOutputModel()
                {
                    Valid = valid,
                    Description = ""

                };

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
                .Where(c => c.VTMCLH_COBRAD == vendedor)
                .OrderBy(t => t.VTMCLH_APELL1);

            return await query.ToArrayAsync();
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
            //var query1 = _context.Productos
            //    .Where(t => t.STMPDH_TIPPRO.Contains("MI") &&
            //               t.STMPDH_INDCOD.Length > 0)
            //    .OrderBy(t => t.STMPDH_TIPPRO);

            //var query3 = _context.Productos.GroupJoin(_context.ListaPrecios, p => p.STMPDH_ARTCOD, l => l.STTPRE_ARTCOD,
            //    (p, l) => new {Producto = p.STMPDH_ARTCOD, TipoProducto = p.STMPDH_TIPPRO, Desc = p.STMPDH_DESCRP, UM = p.STMPDH_UNIMED, Precio = p.STMPDH_UNIMED});

            //var query4 = _context.Productos.Join(_context.ListaPrecios, p => p.STMPDH_ARTCOD, l => l.STTPRE_ARTCOD,
            //    (p, l) => new
            //    {
            //        Producto = p.STMPDH_ARTCOD, TipoProducto = p.STMPDH_TIPPRO, Desc = p.STMPDH_DESCRP,
            //        UM = p.STMPDH_UNIMED, Precio = l.STTPRE_PRECIO, COD = p.STMPDH_INDCOD, FechaLista = l.STTPRE_FECLIS
            //    })
            //    .Where(tp => tp.TipoProducto.Contains("MI"))
            //    .Where(tp => tp.COD != "" || tp.COD != null)
            //    .OrderByDescending(l => l.FechaLista)
            //    .GroupBy(p => p.COD)
            //    .ToList();

            var query2 = from productos in _context.Productos
                join lista in _context.ListaPrecios
                    on productos.STMPDH_ARTCOD equals lista.STTPRE_ARTCOD
                orderby lista.STTPRE_FECLIS descending
                where lista.STTPRE_CODLIS == "LPMIIN0001" && 
                      productos.STMPDH_TIPPRO.Contains("MI") && 
                      (productos.STMPDH_INDCOD != null || productos.STMPDH_INDCOD != "")
                         select new { Producto = productos, ListaPrecio = lista };

            var grouped = query2.DistinctBy(p => p.Producto.STMPDH_INDCOD).OrderBy(p => p.ListaPrecio.STTPRE_FECLIS);

            List<ProductoModel> result = new List<ProductoModel>();

            foreach (var p in grouped)
            {
                var obj = new ProductoModel()
                {
                    STMPDH_ARTCOD = p.Producto.STMPDH_ARTCOD,
                    STMPDH_TIPPRO = p.Producto.STMPDH_TIPPRO,
                    STMPDH_DESCRP = p.Producto.STMPDH_DESCRP,
                    STMPDH_UNIMED = p.Producto.STMPDH_UNIMED,
                    STTPRE_PRECIO = p.ListaPrecio.STTPRE_PRECIO,
                    STMPDH_INDCOD = p.Producto.STMPDH_INDCOD
                };
                result.Add(obj);
            }

            return result.ToArray();
        }

        public async Task<ProductoModel> GetProductoPorINDCODAsync(string INDCOD)
        {
            var query2 = from productos in _context.Productos
                join lista in _context.ListaPrecios
                    on productos.STMPDH_TIPPRO + productos.STMPDH_ARTCOD equals lista.STTPRE_TIPPRO + lista.STTPRE_ARTCOD
                orderby lista.STTPRE_FECLIS descending
                where lista.STTPRE_CODLIS == "LPMIIN0001" && productos.STMPDH_INDCOD == INDCOD && productos.STMPDH_TIPPRO.Contains("MI")
                select new {Producto = productos, ListaPrecio = lista};

            var obj = new ProductoModel()
            {
                STMPDH_ARTCOD = query2.FirstOrDefault().Producto.STMPDH_ARTCOD,
                STMPDH_TIPPRO = query2.FirstOrDefault().Producto.STMPDH_TIPPRO,
                STMPDH_DESCRP = query2.FirstOrDefault().Producto.STMPDH_DESCRP,
                STMPDH_UNIMED = query2.FirstOrDefault().Producto.STMPDH_UNIMED,
                STTPRE_PRECIO = query2.FirstOrDefault().ListaPrecio.STTPRE_PRECIO,
                STMPDH_INDCOD = query2.FirstOrDefault().Producto.STMPDH_INDCOD
            };

            return obj;
        }

        public async Task<Producto> GetProductoPorTIPPRO_ARTCODAsync(string TIPPRO, string ARTCOD)
        {
            var query = _context.Productos
                .Where(t => t.STMPDH_TIPPRO == TIPPRO &&
                            t.STMPDH_ARTCOD == ARTCOD)
                .OrderBy(t => t.STMPDH_INDCOD);

            return await query.FirstOrDefaultAsync();
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