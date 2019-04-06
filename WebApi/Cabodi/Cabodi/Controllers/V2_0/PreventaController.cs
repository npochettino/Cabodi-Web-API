using AutoMapper;
using Cabodi.Data.Repository;
using Cabodi.Models.Input;
using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Cabodi.Models;

namespace Cabodi.Controllers.V2_0
{
    [ApiVersion("2.0")]
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
        public async Task<IHttpActionResult> CrearPreventa([FromBody] PreventaInternalModel preventa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PreVenta NewPreventa = MapearPreventa(preventa);
                    List<ItemPreVenta> Items = MapearItemPreVenta(preventa);

                    _cabodiRepository.AddPreventa(NewPreventa);

                    foreach (var item in Items)
                        _cabodiRepository.AddItemPreventa(item);

                    if (await _cabodiRepository.SaveChangesAsync())
                    {
                        return Ok();
                    }
                }
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }

            return BadRequest();
        }


        private PreVenta MapearPreventa(PreventaInternalModel preventa)
        {
            //TODO: Obtener ultimo numero de PREVENTA -> NROFOR
            var LastPreventa = _cabodiRepository.GetLastPreventa();
            //TODO: Obtener CLIENTE -> DIRENT, PAIENT, CODENT, VNDDOR
            var cliente = _cabodiRepository.GetCliente(preventa.NumeroCliente);

            var NewPreventa = new PreVenta()
            {
                FCRMVH_MODFOR = "FC",
                FCRMVH_CODFOR = "PREVENT",
                FCRMVH_NROFOR = LastPreventa.FCRMVH_NROFOR + 1,//"OBTENER Nro PREVENTA",
                FCRMVH_NROGEN = LastPreventa.FCRMVH_NROGEN + 1,//"OBTENER Nro PREVENTA",
                FCRMVH_CIRCOM = "0100",
                FCRMVH_CIRGEN = "0100",
                FCRMVH_CIRAPL = "0100",
                FCRMVH_SUCURS = "0001",
                FCRMVH_NROCTA = preventa.NumeroCliente,
                FCRMVH_NROSUB = preventa.NumeroCliente,
                FCRMVH_DIRENT = cliente.VTMCLH_DIRENT,
                FCRMVH_PAIENT = cliente.VTMCLH_PAIENT,
                FCRMVH_CODENT = cliente.VTMCLH_CODENT,
                FCRMVH_CAMION = cliente.VTMCLH_CAMION,
                FCRMVH_VNDDOR = cliente.VTMCLH_VNDDOR,
                FCRMVH_CNDPAG = cliente.VTMCLH_CNDPAG,
                FCRMVH_DEPOSI = cliente.VTMCLH_DEPOSI,
                FCRMVH_SECTOR = cliente.VTMCLH_SECTOR,
                FCRMVH_CODLIS = cliente.VTMCLH_CNDPRE,
                FCRMVH_JURISD = cliente.VTMCLH_JURISD,
                FCRMVH_CONIVA = cliente.VTMCLH_CNDIVA,
                FCRMVH_CODZON = cliente.VTMCLH_CODZON,
                FCRMVH_ISPRCT = "N",
                FCRMVH_CODEMP = "CABODI",
                FCRMVH_EMPGEN = "CABODI",
                FCRMVH_EMPFST = "CABODI",
                FCRMVH_MODGEN = "FC",
                FCRMVH_CODGEN = "PREVENT",
                FCRMVH_COFLIS = "PESOS",
                FCRMVH_COFDEU = "PESOS",
                FCRMVH_COFFAC = "PESOS",

                FCRMVH_FCHMOV = preventa.FechaMovimiento,
                FCRMVH_FCHDES = preventa.FechaDesde,
                FCRMVH_FCHHAS = preventa.FechaHasta,
                FCRMVH_USERID = preventa.UserName,
            };

            return NewPreventa;
        }

        private List<ItemPreVenta> MapearItemPreVenta(PreventaInternalModel items)
        {
            List<ItemPreVenta> ItemsPreventa = new List<ItemPreVenta>();

            foreach (var i in items.ItemsPreventa)
            {
                var NewItem = new ItemPreVenta()
                {
                    FCRMVI_ARTCOD = i.CodigoArticulo,
                    FCRMVI_TIPPRO = i.TipoProducto
                };

                ItemsPreventa.Add(NewItem);
            }

            return ItemsPreventa;
        }

    }
}

