using AutoMapper;
using Cabodi.Data.Repository;
using Cabodi.Models;
using Cabodi.Models.Input;
using Cabodi.Models.Output;
using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Cabodi.Data.Helper;

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
        /// Validar Acceso del Usuario
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
                        NroCuenta = model.NroCuenta,
                        Password = model.Password
                    });

                return await Task.Run(() => Ok(validPass));
            }
            else
                return BadRequest();
        }

        /// <summary>
        /// Cambiar la Contraseña del Usuario
        /// </summary>
        /// <param name="model">Update password model</param>
        /// <response code="200">Password updated successfully</response>
        /// <response code="400">Incorrect request data</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">An unexpected error has occured</response>
        [HttpPut()]
        [Route()]
        public async Task<IHttpActionResult> UpdatePassword([FromBody] UpdatePasswordInputModel model)
        {
            try
            {

                var cliente = await _cabodiRepository.GetClienteAsync(model.NroCuenta);
                if (cliente == null) return NotFound();

                string EPass = Common.ComputeHash(model.NewPassword, "SHA512", null);

                cliente.USR_VTMCLH_CONAPP = EPass;

                if (await _cabodiRepository.SaveChangesAsync())
                {
                    var c = new AuthOutputModel()
                        {Valid = true, nombre = cliente.VTMCLH_NOMBRE, Description = "Contraseña Modificada"};

                    return Ok(c);
                }
                else
                {
                    return InternalServerError();
                }
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }

        }

    }
}