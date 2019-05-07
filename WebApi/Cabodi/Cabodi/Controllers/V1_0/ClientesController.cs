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
                return await Task.Run(() => Ok(
                    new List<ClienteModel>()
                    {
                        new  ClienteModel(){ Nombre = "BLANCO, OSCAR ALFREDO", NroCuenta = "VH1255", NroVendedor = "ZI0026"},
                        new  ClienteModel(){ Nombre = "GUASCO, OSCAR ALFREDO JOSE", NroCuenta = "VH1311", NroVendedor = "ZI0026"},
                        new  ClienteModel(){ Nombre = "ALBUERNE, DANIEL LEANDRO", NroCuenta = "VH1610", NroVendedor = "ZI0026"},
                        new  ClienteModel(){ Nombre = "BALLESTER, JOSE LUIS Y OMAR", NroCuenta = "VH1623", NroVendedor = "ZI0022"},
                        new  ClienteModel(){ Nombre = "COSTAS, OMAR DANIEL", NroCuenta = "VH1635", NroVendedor = "ZI0025"},
                        new  ClienteModel(){ Nombre = "DENTONE, PEDRO OSMAR", NroCuenta = "VH1655", NroVendedor = "ZI0026"},
                        new  ClienteModel(){ Nombre = "BLANCO2, OSCAR ALFREDO", NroCuenta = "VH1255", NroVendedor = "ZI0025"},
                        new  ClienteModel(){ Nombre = "GUASCO2, OSCAR ALFREDO JOSE", NroCuenta = "VH1311", NroVendedor = "ZI0025"},
                        new  ClienteModel(){ Nombre = "ALBUERNE2, DANIEL LEANDRO", NroCuenta = "VH1610", NroVendedor = "ZI0025"},
                        new  ClienteModel(){ Nombre = "BALLESTER2, JOSE LUIS Y OMAR", NroCuenta = "VH1623", NroVendedor = "ZI0023"},
                        new  ClienteModel(){ Nombre = "COSTAS2, OMAR DANIEL", NroCuenta = "VH1635", NroVendedor = "ZI0023"},
                        new  ClienteModel(){ Nombre = "DENTONE2, PEDRO OSMAR", NroCuenta = "VH1655", NroVendedor = "ZI0023"},
                    }));
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
                var clientes = new List<ClienteModel>()
                    {
                        new  ClienteModel(){ Nombre = "BLANCO, OSCAR ALFREDO", NroCuenta = "VH1255", NroVendedor = "ZI0026"},
                        new  ClienteModel(){ Nombre = "GUASCO, OSCAR ALFREDO JOSE", NroCuenta = "VH1311", NroVendedor = "ZI0026"},
                        new  ClienteModel(){ Nombre = "ALBUERNE, DANIEL LEANDRO", NroCuenta = "VH1610", NroVendedor = "ZI0026"},
                        new  ClienteModel(){ Nombre = "BALLESTER, JOSE LUIS Y OMAR", NroCuenta = "VH1623", NroVendedor = "ZI0022"},
                        new  ClienteModel(){ Nombre = "COSTAS, OMAR DANIEL", NroCuenta = "VH1635", NroVendedor = "ZI0025"},
                        new  ClienteModel(){ Nombre = "DENTONE, PEDRO OSMAR", NroCuenta = "VH1655", NroVendedor = "ZI0026"},
                        new  ClienteModel(){ Nombre = "BLANCO2, OSCAR ALFREDO", NroCuenta = "VH1255", NroVendedor = "ZI0025"},
                        new  ClienteModel(){ Nombre = "GUASCO2, OSCAR ALFREDO JOSE", NroCuenta = "VH1311", NroVendedor = "ZI0025"},
                        new  ClienteModel(){ Nombre = "ALBUERNE2, DANIEL LEANDRO", NroCuenta = "VH1610", NroVendedor = "ZI0025"},
                        new  ClienteModel(){ Nombre = "BALLESTER2, JOSE LUIS Y OMAR", NroCuenta = "VH1623", NroVendedor = "ZI0023"},
                        new  ClienteModel(){ Nombre = "COSTAS2, OMAR DANIEL", NroCuenta = "VH1635", NroVendedor = "ZI0023"},
                        new  ClienteModel(){ Nombre = "DENTONE2, PEDRO OSMAR", NroCuenta = "VH1655", NroVendedor = "ZI0023"},
                    };
                var result = clientes.Where(c => c.NroVendedor == vendedor).ToList();
                if(result.Count() == 0) return NotFound();

                return await Task.Run(() => Ok(result));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
