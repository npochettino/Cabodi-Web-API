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

        [Route("{vendedor}")]
        public async Task<IHttpActionResult> GetClientesPorVendedor(string vendedor)
        {
            try
            {
                var result = await _cabodiRepository.GetClientesPorVendedorAsync(vendedor);
                if (result == null) return NotFound();
                {
                    
                }
                //Mapper
                return Ok(_mapper.Map<IEnumerable<ClienteModel>>(result));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
