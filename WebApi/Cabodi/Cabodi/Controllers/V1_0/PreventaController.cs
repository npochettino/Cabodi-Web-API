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
