using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using Cabodi.Data.Repository;
using Cabodi.Models;

namespace Cabodi.Controllers
{
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

        public async Task<IHttpActionResult> GetClientes()
        {
            try
            {
                var result = await _cabodiRepository.GetClientsAsync();

                //Mapper
                var mappedResult = _mapper.Map<IEnumerable<ClienteModel>>(result);

                return Ok(mappedResult);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            
        }
    }
}
