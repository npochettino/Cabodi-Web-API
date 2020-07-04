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
    [RoutePrefix("api/listaprecios")]
    public class ListaPreciosController : ApiController
    {
        private readonly ICabodiRepository _cabodiRepository;
        private readonly IMapper _mapper;

        public ListaPreciosController(ICabodiRepository cabodiRepository, IMapper mapper)
        {
            _cabodiRepository = cabodiRepository;
            _mapper = mapper;
        }

        //[Route()]
        //public async Task<IHttpActionResult> GetListaPreciosAsync()
        //{
        //    try
        //    {
        //        var result = await _cabodiRepository.GetListaDePreciosAsync();

        //        //Mapper
        //        var mappedResult = _mapper.Map<IEnumerable<ListaPrecioModel>>(result);

        //        return Ok(mappedResult);
        //    }
        //    catch (Exception ex)
        //    {
        //        return InternalServerError(ex);
        //    }

        //}
    }
}
