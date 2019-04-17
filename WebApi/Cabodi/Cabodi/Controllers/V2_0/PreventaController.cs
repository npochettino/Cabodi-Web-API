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
using System.Web.Management;
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

        /// <summary>
        /// Obtener todas las PREVENTAS por ID de Vendedor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetPreventasPorVendedor(string id)
        {
            try
            {
                var result = await _cabodiRepository.GetPreventasPorVendedorAsync(id);
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        /// <summary>
        /// Crear una nueva PREVENTA
        /// </summary>
        /// <param name="preventa"></param>
        /// <returns></returns>
        [Route()]
        [HttpPost]
        public async Task<IHttpActionResult> CrearPreventa([FromBody] PreventaInternalModel preventa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //TODO: Obtener ultimo numero de PREVENTA -> NROFOR
                    var LastPreventa = _cabodiRepository.GetLastPreventa();
                    //TODO: Obtener CLIENTE -> DIRENT, PAIENT, CODENT, VNDDOR
                    var cliente = _cabodiRepository.GetCliente(preventa.NumeroCliente);

                    PreVenta NewPreventa = MapearPreventa(preventa, LastPreventa, cliente);
                    List<ItemPreVenta> Items = MapearItemPreVenta(preventa, LastPreventa, cliente);

                    _cabodiRepository.AddPreventa(NewPreventa);

                    preventa.NumeroPreventa = NewPreventa.FCRMVH_NROFOR;

                    var result = _cabodiRepository.SaveChanges();
                    
                    foreach (var item in Items)
                        _cabodiRepository.AddItemPreventa(item);

                    if (await _cabodiRepository.SaveChangesAsync())
                    {
                        preventa.NumeroPreventa = NewPreventa.FCRMVH_NROFOR;

                        return Ok(preventa);
                    }
                }
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }

            return BadRequest();
        }

        /// <summary>
        /// Eliminar PREVENT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id}")]
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                var items = await _cabodiRepository.GetItemsPrevenAsync(id);
                var preven = await _cabodiRepository.GetPrevenAsync(id);
                if (items == null || preven == null) return NotFound();

                _cabodiRepository.DeleteItemsPreven(items);
                _cabodiRepository.DeletePreven(preven);

                if (await _cabodiRepository.SaveChangesAsync())
                {
                    return Ok();
                }
                else
                {
                    return InternalServerError();
                }

            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        private PreVenta MapearPreventa(PreventaInternalModel preventa, PreVenta LastPreventa, Cliente cliente)
        {
            var NewPreventa = new PreVenta()
            {
                FCRMVH_MODFOR = "FC",
                FCRMVH_CODFOR = "PREVEN",
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
                FCRMVH_CODGEN = "PREVEN",
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

        private List<ItemPreVenta> MapearItemPreVenta(PreventaInternalModel items, PreVenta LastPreventa, Cliente cliente)
        {
            List<ItemPreVenta> ItemsPreventa = new List<ItemPreVenta>();

            foreach (var i in items.ItemsPreventa)
            {
                var articulo = _cabodiRepository.GetProductoPorTIPPRO_ARTCOD(i.TipoProducto,i.CodigoArticulo);

                var NewItem = new ItemPreVenta()
                {
                    FCRMVI_MODFOR = "FC",
                    FCRMVI_CODFOR = "PREVEN",
                    FCRMVI_NROFOR = LastPreventa.FCRMVH_NROFOR + 1,//"OBTENER Nro PREVENTA",
                    FCRMVI_NROITM = i.NumeroItem,
                    FCRMVI_NIVEXP = "1",
                    FCRMVI_MODAPL = "FC",
                    FCRMVI_CODAPL = "PREVEN",
                    FCRMVI_NROAPL = LastPreventa.FCRMVH_NROFOR + 1,//"OBTENER Nro PREVENTA",
                    FCRMVI_ITMAPL = i.NumeroItem,
                    FCRMVI_EXPAPL = "1",
                    FCRMVI_ARTCOD = i.CodigoArticulo,
                    FCRMVI_TIPPRO = i.TipoProducto,
                    FCRMVI_MODCPT = cliente.VTMCLH_MODCPT,
                    FCRMVI_TIPCPT = cliente.VTMCLH_TIPCPT,
                    FCRMVI_CODCPT = cliente.VTMCLH_CODCPT,
                    FCRMVI_TIPORI = i.TipoProducto,
                    FCRMVI_ARTORI = i.CodigoArticulo,
                    FCRMVI_NROCTA = cliente.VTMCLH_NROCTA,
                    FCRMVI_NROSUB = cliente.VTMCLH_NROSUB,
                    FCRMVI_PRECIO = i.Precio,
                    FCRMVI_CANTID = i.Cantidad,
                    FCRMVI_UNIMED = articulo.STMPDH_UNIMED,
                    FCRMVI_UNICON = articulo.STMPDH_UNICON,
                    FCRMVI_PRENAC = i.Precio,
                    FCRMVI_TOTLIN = i.Total,
                    FCRMVI_USERID = cliente.VTMCLH_USERID,
                    FCRMVI_CODEMP = "CABODI",
                    FCRMVI_EMPAPL = "CABODI",
                    FCRMVI_EMPORI = "CABODI"
                };

                ItemsPreventa.Add(NewItem);
            }

            return ItemsPreventa;
        }

    }
}

