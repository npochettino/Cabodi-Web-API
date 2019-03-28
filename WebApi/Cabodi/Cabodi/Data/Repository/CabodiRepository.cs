using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Cabodi.Models;

namespace Cabodi.Data.Repository
{
    public class CabodiRepository : ICabodiRepository
    {
        private readonly CabodiContext _context;

        public CabodiRepository(CabodiContext context)
        {
            _context = context;
        }

        public async Task<Cliente[]> GetClientsAsync()
        {
            var query = _context.Clientes
                .Where(c => c.VTMCLH_COBRAD == "IN0026")
                .OrderBy(t => t.VTMCLH_APELL1);

            return await query.ToArrayAsync();
        }
    }
}