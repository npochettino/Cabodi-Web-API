using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Management;
using AutoMapper;
using Cabodi.Data.Repository;
using Cabodi.Models;
using Microsoft.Web.Http;

namespace Cabodi.Controllers.V1_0
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/clientes")]
    public class ClientesController : ApiController
    {
        private readonly ICabodiRepository _cabodiRepository;
        private readonly IMapper _mapper;

        public ClientesController(ICabodiRepository cabodiRepository, IMapper mapper)
        {
            _cabodiRepository = cabodiRepository;
            _mapper = mapper;
        }

        [Route()]
        public async Task<IHttpActionResult> GetClientes()
        {
            try
            {
                var result = await _cabodiRepository.GetClientesAsync();

                //Mapper
                var mappedResult = _mapper.Map<IEnumerable<ClienteModel>>(result);

                return Ok(mappedResult);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            
        }
        /// <summary>
        /// Obtener Clientes por Vendedor
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        [Route("{vendedor}")]
        public async Task<IHttpActionResult> GetClientesPorVendedor(string vendedor)
        {
            try
            {
                return await Task.Run(() => Ok(
                    new List<ClienteModel>()
                    {
                       new  ClienteModel(){ VTMCLH_NOMBRE = "BLANCO, OSCAR ALFREDO", VTMCLH_NROCTA = "VH1255"}, 
                       new  ClienteModel(){ VTMCLH_NOMBRE = "GUASCO, OSCAR ALFREDO JOSE", VTMCLH_NROCTA = "VH1311"}, 
                       new  ClienteModel(){ VTMCLH_NOMBRE = "ALBUERNE, DANIEL LEANDRO", VTMCLH_NROCTA = "VH1610"}, 
                       new  ClienteModel(){ VTMCLH_NOMBRE = "BALLESTER, JOSE LUIS Y OMAR", VTMCLH_NROCTA = "VH1623"}, 
                       new  ClienteModel(){ VTMCLH_NOMBRE = "COSTAS, OMAR DANIEL", VTMCLH_NROCTA = "VH1635"}, 
                       new  ClienteModel(){ VTMCLH_NOMBRE = "DENTONE, PEDRO OSMAR", VTMCLH_NROCTA = "VH1655"}, 
                    }));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
