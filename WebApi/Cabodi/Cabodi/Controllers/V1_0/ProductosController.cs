using AutoMapper;
using Cabodi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Cabodi.Models;
using Microsoft.Web.Http;

namespace Cabodi.Controllers.V1_0
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/productos")]
    public class ProductosController : ApiController
    {
        private readonly ICabodiRepository _cabodiRepository;
        private readonly IMapper _mapper;

        public ProductosController(ICabodiRepository cabodiRepository, IMapper mapper)
        {
            _cabodiRepository = cabodiRepository;
            _mapper = mapper;
        }

        [Route()]
        public async Task<IHttpActionResult> GetProductosAsync()
        {
            try
            {
                var productos = new List<ProductoModel>()
                {
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "HCAPD50C", STTPRE_PRECIO = 1500, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Harina Pandulcera - Cabodi - Bolsa 50kg Coteada", STMPDH_UNIMED = "BOL50",
                        STMPDH_INDCOD = "13"
                    },
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "SLICA01G", STTPRE_PRECIO = 25, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Semolin de trigo - Cabodi - Granel", STMPDH_UNIMED = "KILOS",
                        STMPDH_INDCOD = "24"
                    },
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "HCA3025P", STTPRE_PRECIO = 510, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Harina Cabodi 000 Bolsa 25kg Papel", STMPDH_UNIMED = "BOL25",
                        STMPDH_INDCOD = "18"
                    },
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "HCA3050P", STTPRE_PRECIO = 1000, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Harina Cabodi 000 Bolsa 50kg Papel", STMPDH_UNIMED = "BOL50",
                        STMPDH_INDCOD = "2"
                    },
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "HESPI50C", STTPRE_PRECIO = 1300, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Harina Pan Ingles - Cabodi - Bolsa 50kg Polipropileno",
                        STMPDH_UNIMED = "BOL50L", STMPDH_INDCOD = "11"
                    }
                };
                
                return await Task.Run(() => Ok(productos));

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        [Route("{codigo}")]
        public async Task<IHttpActionResult> GetProductoPorINDCODAsync(string codigo)
        {
            try
            {
                var productos = new List<ProductoModel>()
                {
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "HCAPD50C", STTPRE_PRECIO = 1500, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Harina Pandulcera - Cabodi - Bolsa 50kg Coteada", STMPDH_UNIMED = "BOL50",
                        STMPDH_INDCOD = "13"
                    },
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "SLICA01G", STTPRE_PRECIO = 25, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Semolin de trigo - Cabodi - Granel", STMPDH_UNIMED = "KILOS",
                        STMPDH_INDCOD = "24"
                    },
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "HCA3025P", STTPRE_PRECIO = 510, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Harina Cabodi 000 Bolsa 25kg Papel", STMPDH_UNIMED = "BOL25",
                        STMPDH_INDCOD = "18"
                    },
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "HCA3050P", STTPRE_PRECIO = 1000, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Harina Cabodi 000 Bolsa 50kg Papel", STMPDH_UNIMED = "BOL50",
                        STMPDH_INDCOD = "2"
                    },
                    new ProductoModel()
                    {
                        STMPDH_ARTCOD = "HESPI50C", STTPRE_PRECIO = 1300, STMPDH_TIPPRO = "MIPRES",
                        STMPDH_DESCRP = "Harina Pan Ingles - Cabodi - Bolsa 50kg Polipropileno",
                        STMPDH_UNIMED = "BOL50L", STMPDH_INDCOD = "11"
                    }
                };
                var result = productos.Where(c => c.STMPDH_INDCOD == codigo).ToList();
                if (result.Count == 0) return NotFound();

                return await Task.Run(() => Ok(result));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
