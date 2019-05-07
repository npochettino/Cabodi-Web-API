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

namespace Cabodi.Controllers.V1_0
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {

        private readonly ICabodiRepository _cabodiRepository;
        private readonly IMapper _mapper;

        public UsersController(ICabodiRepository cabodiRepository, IMapper mapper)
        {
        _cabodiRepository = cabodiRepository;
        _mapper = mapper;
        }

        /// <summary>
        /// Get All Users.
        /// </summary>
        /// <param name="model">Validate pasword model</param>
        /// <response code="200">Password validated successfully</response>
        /// <response code="400">Incorrect request data</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">An unexpected error has occured</response>
        [Route()]
        public async Task<IHttpActionResult> GetUsers()
        {
            if (ModelState.IsValid)
            {
                return await Task.Run(() => Ok(
                    new List<ClienteModel>()
                    {
                        new  ClienteModel(){ NroVendedor = "ZI0022", Password = "CABADI"},
                        new  ClienteModel(){ NroVendedor = "ZI0023", Password = "CABADI"},
                        new  ClienteModel(){ NroVendedor = "ZI0024", Password = "CABADI"},
                        new  ClienteModel(){ NroVendedor = "ZI0025", Password = "CABADI"},
                        new  ClienteModel(){ NroVendedor = "ZI0026", Password = "CABADI"},
                        new  ClienteModel(){ NroVendedor = "ZI0026", Password = "CABADI"},
                        new  ClienteModel(){ NroVendedor = "ZI0027", Password = "CABADI"},
                        new  ClienteModel(){ NroVendedor = "ZI0028", Password = "CABADI"},
                    }));
            }
            else
                return BadRequest();
        }
    }
}
