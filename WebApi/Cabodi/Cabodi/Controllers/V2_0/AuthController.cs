using AutoMapper;
using Cabodi.Data.Repository;
using Cabodi.Models;
using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cabodi.Controllers.V2_0
{
    [ApiVersion("2.0")]
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
                var validPass = await _cabodiRepository.ValidatePassword(
                    new AuthInternalModel()
                    {
                        user = model.user,
                        pass = model.pass
                    });

                return Ok(validPass);
            }
            else
                return BadRequest();
        }

    }
}