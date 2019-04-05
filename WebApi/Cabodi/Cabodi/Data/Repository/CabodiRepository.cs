using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Cabodi.Data.Entities;
using Cabodi.Models;
using Cabodi.Models.Input;
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

        public async Task<bool> SaveChangesAsync()
        {
            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        //Auth
        public async Task<AuthOutputModel> ValidatePassword(AuthInternalModel model)
        {
            try
            {
                var user = _context.Clientes
                    .Where(u => u.VTMCLH_NROCTA == model.user &&
                                u.VTMCLH_NROCTA == model.pass &&
                                u.VTMCLH_NROCTA.Contains("Z"))
                    .FirstOrDefault();
                
                return await Task.Run(() => new AuthOutputModel()
                {
                    Valid = user == null ? false : true,
                    Description = "",
                    nombre = user.VTMCLH_NOMBRE
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

        public async Task<Cliente> GetCliente(string NROCTA)
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
                    STTPRE_PRECIO = lista.STTPRE_PRECIO
                };

            var grouped = query2.OrderByDescending(l => l.STTPRE_PRECIO).FirstOrDefault();

            return await Task.Run(() => grouped);
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