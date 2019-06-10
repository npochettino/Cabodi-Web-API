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
        /// Obtener todas las PREVENTAS por ID de Vendedor - Ultimos 15 días
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
                //var result = _cabodiRepository.GetPreventasHeaderPorVendedor(id);

                if (result == null) return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        /// <summary>
        /// Obtener items de una PREVEN
        /// </summary>
        /// <returns></returns>
        [Route("{id}/items")]
        [HttpGet]
        public async Task<IHttpActionResult> GetItemsPreventa([FromUri] int id)
        {
            try
            {
                var result = _cabodiRepository.GetItemsPreventa(id);

                if (result == null) return NotFound();

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
                        foreach (var item in preventa.ItemsPreventa)
                        {
                            var articulo = _cabodiRepository.GetProductoPorTIPPRO_ARTCOD(item.TipoProducto, item.CodigoArticulo);
                            item.DescripcionArticulo = articulo.STMPDH_DESCRP;
                        }

                        return Ok(preventa);
                    }
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
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
            DateTime? _fechaHasta;
            if (preventa.FechaHasta == null)
            {
                if (preventa.FechaDesde == null)
                {
                    _fechaHasta = preventa.FechaMovimiento;
                }
                else
                {
                    _fechaHasta = preventa.FechaDesde;
                }
            }
            else
            {
                _fechaHasta = preventa.FechaHasta;
            }

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
                FCRMVH_DEPOSI = "HAR001",
                FCRMVH_SECTOR = "U",
                FCRMVH_CODLIS = cliente.VTMCLH_CNDPRE,
                FCRMVH_JURISD = cliente.VTMCLH_JURISD,
                FCRMVH_CNDIVA = cliente.VTMCLH_CNDIVA,
                FCRMVH_CODZON = cliente.VTMCLH_CODZON,
                FCRMVH_ISPRCT = "N",
                FCRMVH_ULTOPR = "A",
                FCRMVH_DEBAJA = "N",
                FCRMVH_CODEMP = "CABODI",
                FCRMVH_EMPGEN = "CABODI",
                FCRMVH_EMPFST = "CABODI",
                FCRMVH_MODGEN = "FC",
                FCRMVH_CODGEN = "PREVEN",
                FCRMVH_COFLIS = "PESOS",
                FCRMVH_COFDEU = "PESOS",
                FCRMVH_COFFAC = "PESOS",
                FCRMVH_CAMBIO = 0,
                FCRMVH_CAMUSS = 0,
                FCRMVH_NROFCR = 0,
                FCRMVH_NROFST = 0,
                FCRMVH_CAMSEC = 0,
                FCRMVH_DIAENT = 0,
                FCRMVH_TEXTOS = preventa.Observacion,
                FCRMVH_FECLIS = preventa.FechaMovimiento.Date,
                FCRMVH_FECALT = preventa.FechaMovimiento,
                FCRMVH_FECMOD = preventa.FechaMovimiento,
                FCRMVH_CONGEL = "S",
                FCRMVH_FCHMOV = preventa.FechaMovimiento.Date,
                FCRMVH_FCHDES = preventa.FechaDesde == null ? preventa.FechaMovimiento : preventa.FechaDesde,
                FCRMVH_FCHHAS = _fechaHasta,  
                FCRMVH_USERID = preventa.UserName,
                FCRMVH_OALIAS = "FCRMVH"
            };

            return NewPreventa;
        }

        private List<ItemPreVenta> MapearItemPreVenta(PreventaInternalModel items, PreVenta LastPreventa, Cliente cliente)
        {
            DateTime? _fechaHasta;
            if (items.FechaHasta == null)
            {
                if (items.FechaDesde == null)
                {
                    _fechaHasta = items.FechaMovimiento;
                }
                else
                {
                    _fechaHasta = items.FechaDesde;
                }
            }
            else
            {
                _fechaHasta = items.FechaHasta;
            }

            List<ItemPreVenta> ItemsPreventa = new List<ItemPreVenta>();

            var nroItem = 0;
            foreach (var i in items.ItemsPreventa)
            {
                nroItem++;
                var articulo = _cabodiRepository.GetProductoPorTIPPRO_ARTCOD(i.TipoProducto,i.CodigoArticulo);

                var NewItem = new ItemPreVenta()
                {
                    FCRMVI_MODFOR = "FC",
                    FCRMVI_CODFOR = "PREVEN",
                    FCRMVI_NROFOR = LastPreventa.FCRMVH_NROFOR + 1,//"OBTENER Nro PREVENTA",
                    FCRMVI_NROITM = nroItem,
                    FCRMVI_NIVEXP = "1",
                    FCRMVI_MODAPL = "FC",
                    FCRMVI_CODAPL = "PREVEN",
                    FCRMVI_NROAPL = LastPreventa.FCRMVH_NROFOR + 1,//"OBTENER Nro PREVENTA",
                    FCRMVI_ITMAPL = nroItem,
                    FCRMVI_EXPAPL = "1",
                    FCRMVI_ARTCOD = i.CodigoArticulo,
                    FCRMVI_TIPPRO = i.TipoProducto,
                    FCRMVI_MODCPT = articulo.STMPDH_MODCPT,
                    FCRMVI_TIPCPT = articulo.STMPDH_TIPCPC,
                    FCRMVI_CODCPT = articulo.STMPDH_CODCPT,
                    FCRMVI_DEPOSI = "HAR001",
                    FCRMVI_SECTOR = "U",
                    FCRMVI_SUCURS = "0001",
                    FCRMVI_FACSEC = articulo.STMPDH_FACSEC,
                    FCRMVI_CNTSEC = i.Cantidad * articulo.STMPDH_FACSEC,
                    FCRMVI_TIPUNI = "F",
                    FCRMVI_FACFAC = 0,
                    FCRMVI_CNTFAC = i.Cantidad,
                    FCRMVI_UNIALT = articulo.STMPDH_UNIALT,
                    FCRMVI_FACALT = articulo.STMPDH_FACALT,
                    FCRMVI_CNTALT = i.Cantidad * articulo.STMPDH_FACALT,
                    FCRMVI_TIPORI = i.TipoProducto,
                    FCRMVI_ARTORI = i.CodigoArticulo,
                    FCRMVI_NROCTA = cliente.VTMCLH_NROCTA,
                    FCRMVI_NROSUB = cliente.VTMCLH_NROSUB,
                    FCRMVI_PRECIO = i.Precio,
                    FCRMVI_CANTID = i.Cantidad,
                    FCRMVI_UNIMED = articulo.STMPDH_UNIMED,
                    FCRMVI_UNICON = articulo.STMPDH_UNICON,
                    FCRMVI_FACCON = articulo.STMPDH_FACCON,
                    FCRMVI_CNTCON = i.Cantidad * articulo.STMPDH_FACCON,
                    FCRMVI_PCTBF1 = 0,
                    FCRMVI_PCTBF2 = 0,
                    FCRMVI_PCTBF3 = 0,
                    FCRMVI_PCTBF4 = 0,
                    FCRMVI_PCTBF5 = 0,
                    FCRMVI_PCTBF6 = 0,
                    FCRMVI_PCTBF7 = 0,
                    FCRMVI_PCTBF8 = 0,
                    FCRMVI_PCTBF9 = 0,
                    FCRMVI_PCTBFN = 0,
                    FCRMVI_TEXTOS = "0",
                    FCRMVI_FCHENT = items.FechaDesde == null ? items.FechaMovimiento : items.FechaDesde,
                    FCRMVI_FCHHAS = _fechaHasta,
                    FCRMVI_MODORI = "FC",
                    FCRMVI_CODORI = "PREVEN",
                    FCRMVI_NROORI = LastPreventa.FCRMVH_NROFOR + 1,
                    FCRMVI_ITMORI = nroItem,
                    FCRMVI_EXPORI = "1",
                    FCRMVI_CUENTA = articulo.STMPDH_CUENVT,
                    FCRMVI_CNTANT = 0,
                    FCRMVI_PORANT = 0,

                    FCRMVI_CANTST = i.Cantidad,
                    FCRMVI_CNTORI = i.Cantidad,
                    FCRMVI_NROINI = 0,
                    FCRMVI_ITMINI = 1,
                    FCRMVI_COFLIS = "PESOS",
                    FCRMVI_CAMBIO = 0,
                    FCRMVI_NROGAN = 0,
                    FCRMVI_CNTVAR = 0,
                    FCRMVI_CNTUNI = 0,
                    FCRMVI_FACTOR = 0,
                    FCRMVI_NCNPNA = "N",

                    FCRMVI_NROOST = 0,
                    FCRMVI_ITMOST = nroItem,
                    FCRMVI_EXPOST = "1",
                    FCRMVI_PREEXT = 0,
                    FCRMVI_PREUSS = 0,

                    FCRMVI_OALIAS = "FCRMVI",

                    FCRMVI_CNTBON = 0,
                    FCRMVI_PRENAC = i.Precio,
                    FCRMVI_TOTLIN = i.Total,
                    FCRMVI_USERID = items.UserName,
                    FCRMVI_CODEMP = "CABODI",
                    FCRMVI_EMPAPL = "CABODI",
                    FCRMVI_EMPORI = "CABODI",

                    FCRMVI_FECALT = items.FechaMovimiento
                };

                ItemsPreventa.Add(NewItem);
            }

            return ItemsPreventa;
        }

    }
}

