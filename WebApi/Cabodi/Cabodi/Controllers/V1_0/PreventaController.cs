using AutoMapper;
using Cabodi.Data.Repository;
using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cabodi.Models.Input;
using System.Threading.Tasks;

namespace Cabodi.Controllers.V1_0
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/preventa")]
    public class PreventaController : ApiController
    {
        private readonly ICabodiRepository _cabodiRepository;
        private readonly IMapper _mapper;

        public PreventaController(ICabodiRepository cabodiRepository, IMapper mapper)
        {
            _cabodiRepository = cabodiRepository;
            _mapper = mapper;
        }

        [Route()]
        [HttpPost]
        public async Task<IHttpActionResult> CreatePreventa([FromBody] PreventaInternalModel prevent)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    prevent.NumeroPreventa = 99999;
                    return Ok(prevent);
                }
                else
                {
                    InternalServerError();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }

            return BadRequest();
        }

        [Route()]
        [HttpGet]
        public async Task<IHttpActionResult> GetPreventas()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var items = new List<ItemPreventaInternalModel>()
                    {
                        new ItemPreventaInternalModel()
                        {
                            CodigoArticulo = "ART0001", TipoProducto = "TPO0001", Precio = 1000, Cantidad = 2, Total = 2000
                        },
                        new ItemPreventaInternalModel()
                        {
                            CodigoArticulo = "ART0002", TipoProducto = "TPO0001", Precio = 2000, Cantidad = 3, Total = 6000
                        }
                    };

                    var Preventas = new List<PreventaInternalModel>()
                    {
                        new PreventaInternalModel()
                        {
                            FechaDesde = DateTime.Today, FechaHasta = DateTime.Today.AddDays(5), FechaMovimiento = DateTime.Today,
                            NumeroCliente = "VH0293", NumeroPreventa = 9090, Observacion = "obs1", UserName = "Z0026", ItemsPreventa = items
                        },
                        new PreventaInternalModel()
                        {
                            FechaDesde = DateTime.Today, FechaHasta = DateTime.Today.AddDays(15), FechaMovimiento = DateTime.Today,
                            NumeroCliente = "VH0293", NumeroPreventa = 9090, Observacion = "", UserName = "Z0026", ItemsPreventa = items
                        },
                        new PreventaInternalModel()
                        {
                            FechaDesde = DateTime.Today, FechaHasta = DateTime.Today.AddDays(25), FechaMovimiento = DateTime.Today,
                            NumeroCliente = "VH0293", NumeroPreventa = 9090, Observacion = "", UserName = "Z0026", ItemsPreventa = items
                        },
                        new PreventaInternalModel()
                        {
                            FechaDesde = DateTime.Today, FechaHasta = DateTime.Today.AddDays(35), FechaMovimiento = DateTime.Today,
                            NumeroCliente = "VH0295", NumeroPreventa = 9090, Observacion = "obs4", UserName = "Z0026", ItemsPreventa = items
                        },
                        new PreventaInternalModel()
                        {
                            FechaDesde = DateTime.Today, FechaHasta = DateTime.Today.AddDays(65), FechaMovimiento = DateTime.Today,
                            NumeroCliente = "VH0297", NumeroPreventa = 9090, Observacion = "obs5", UserName = "Z0026", ItemsPreventa = items
                        }
                    };

                    return Ok(Preventas);
                }
                else
                {
                    InternalServerError();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }

            return BadRequest();
        }
    }
}
