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
                        CodigoArticulo = "HCAPD50C", Precio = 1500, TipoProducto = "MIPRES",
                        Descripcion = "Harina Pandulcera - Cabodi - Bolsa 50kg Coteada", UnidadMedida = "BOL50",
                        Indcod = "13"
                    },
                    new ProductoModel()
                    {
                        CodigoArticulo = "SLICA01G", Precio = 25, TipoProducto = "MIPRES",
                        Descripcion = "Semolin de trigo - Cabodi - Granel", UnidadMedida = "KILOS",
                        Indcod = "24"
                    },
                    new ProductoModel()
                    {
                        CodigoArticulo = "HCA3025P", Precio = 510, TipoProducto = "MIPRES",
                        Descripcion = "Harina Cabodi 000 Bolsa 25kg Papel", UnidadMedida = "BOL25",
                        Indcod = "18"
                    },
                    new ProductoModel()
                    {
                        CodigoArticulo = "HCA3050P", Precio = 1000, TipoProducto = "MIPRES",
                        Descripcion = "Harina Cabodi 000 Bolsa 50kg Papel", UnidadMedida = "BOL50",
                        Indcod = "2"
                    },
                    new ProductoModel()
                    {
                        CodigoArticulo = "HESPI50C", Precio = 1300, TipoProducto = "MIPRES",
                        Descripcion = "Harina Pan Ingles - Cabodi - Bolsa 50kg Polipropileno",
                        UnidadMedida = "BOL50L", Indcod = "11"
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
                        CodigoArticulo = "HCAPD50C", Precio = 1500, TipoProducto = "MIPRES",
                        Descripcion = "Harina Pandulcera - Cabodi - Bolsa 50kg Coteada", UnidadMedida = "BOL50",
                        Indcod = "13"
                    },
                    new ProductoModel()
                    {
                        CodigoArticulo = "SLICA01G", Precio = 25, TipoProducto = "MIPRES",
                        Descripcion = "Semolin de trigo - Cabodi - Granel", UnidadMedida = "KILOS",
                        Indcod = "24"
                    },
                    new ProductoModel()
                    {
                        CodigoArticulo = "HCA3025P", Precio = 510, TipoProducto = "MIPRES",
                        Descripcion = "Harina Cabodi 000 Bolsa 25kg Papel", UnidadMedida = "BOL25",
                        Indcod = "18"
                    },
                    new ProductoModel()
                    {
                        CodigoArticulo = "HCA3050P", Precio = 1000, TipoProducto = "MIPRES",
                        Descripcion = "Harina Cabodi 000 Bolsa 50kg Papel", UnidadMedida = "BOL50",
                        Indcod = "2"
                    },
                    new ProductoModel()
                    {
                        CodigoArticulo = "HESPI50C", Precio = 1300, TipoProducto = "MIPRES",
                        Descripcion = "Harina Pan Ingles - Cabodi - Bolsa 50kg Polipropileno",
                        UnidadMedida = "BOL50L", Indcod = "11"
                    }
                };
                var result = productos.Where(c => c.Indcod == codigo).ToList();
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
