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

namespace Cabodi.Controllers.V2_0
{
    [ApiVersion("2.0")]
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

        /// <summary>
        /// Obtener todos los PRODUCTOS
        /// </summary>
        /// <returns></returns>
        [Route()]
        public async Task<IHttpActionResult> GetProductos()
        {
            try
            {
                var result = await _cabodiRepository.GetProductosAsync();

                //Mapper
                var mappedResult = _mapper.Map<IEnumerable<ProductoModel>>(result);

                return Ok(mappedResult);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        /// <summary>
        /// Obtener PRODUCTOS por CondicionIVA Cliente
        /// </summary>
        /// <returns></returns>
        [Route("{CondicionIVA}")]
        public async Task<IHttpActionResult> GetProductosPorCondicionIVA(string CondicionIVA)
        {
            try
            {
                var result = await _cabodiRepository.GetProductosPorCondicionIVA(CondicionIVA);

                //Mapper
                var mappedResult = _mapper.Map<IEnumerable<ProductoModel>>(result);

                return Ok(mappedResult);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        /// <summary>
        /// Obtener Producto por INDCOD
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        //[Route("{codigo}")]
        //public async Task<IHttpActionResult> GetProductoPorINDCODAsync(string codigo)
        //{
        //    try
        //    {
        //        var result = await _cabodiRepository.GetProductoPorINDCODAsync(codigo);

        //        //Mapper
        //        var mappedResult = _mapper.Map<ProductoModel>(result);

        //        return Ok(mappedResult);
        //    }
        //    catch (Exception ex)
        //    {
        //        return InternalServerError(ex);
        //    }

        //}
    }
}
