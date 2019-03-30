using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Cabodi.Data.Repository;
using System.Threading.Tasks;
using System.Web.Routing;
using Cabodi.Models;
using Cabodi.Models.Output;

namespace Cabodi.Controllers.V1_0
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        private readonly ICabodiRepository _cabodiRepository;
        private readonly IMapper _mapper;

        public AuthController(ICabodiRepository cabodiRepository, IMapper mapper)
        {
            _cabodiRepository = cabodiRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates user’s password.
        /// </summary>
        /// <param name="model">Validate pasword model</param>
        /// <response code="200">Password validated successfully</response>
        /// <response code="400">Incorrect request data</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">An unexpected error has occured</response>
        [Route()]
        public async Task<IHttpActionResult> ValidatePassword([FromBody] AuthInternalModel model)
        {
            if (ModelState.IsValid)
            {
                return await Task.Run(() => Ok(
                    new AuthOutputModel()
                    {
                        Valid = model.user == "ZI0026" && model.pass == "ZI0026" ? true : false,
                        Description = ""
                    }));
            }
            else
                return BadRequest();
        }

    }
}


