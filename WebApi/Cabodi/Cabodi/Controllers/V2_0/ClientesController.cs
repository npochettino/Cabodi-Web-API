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
using Cabodi.Models.Output;
using Microsoft.Web.Http;

namespace Cabodi.Controllers.V2_0
{
    [ApiVersion("2.0")]
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

        /// <summary>
        /// Obtener Todos los clientes
        /// </summary>
        /// <returns></returns>
        [Route()]
        public async Task<IHttpActionResult> GetClientes()
        {
            try
            {
                var result = await _cabodiRepository.GetClientesAsync();

                var mappedResult = new List<ClienteOutputModel>();

                foreach (var cliente in result)
                {
                    var c = new ClienteOutputModel()
                    {
                        Nombre = cliente.VTMCLH_NOMBRE,
                        NroCuenta = cliente.VTMCLH_NROCTA,
                        Direccion = cliente.VTMCLH_DIRECC,
                        NroVendedor = cliente.VTMCLH_NRODIS
                    };
                        
                    mappedResult.Add(c);
                }

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
                var result = await _cabodiRepository.GetClientesPorVendedorAsync(vendedor);

                if (result == null) return NotFound();

                var mappedResult = new List<ClienteOutputModel>();

                foreach (var cliente in result)
                {
                    var c = new ClienteOutputModel()
                    {
                        Nombre = cliente.VTMCLH_NOMBRE,
                        NroCuenta = cliente.VTMCLH_NROCTA,
                        Direccion = cliente.VTMCLH_DIRECC,
                        NroVendedor = cliente.VTMCLH_NRODIS
                    };

                    mappedResult.Add(c);
                }

                return Ok(mappedResult);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
