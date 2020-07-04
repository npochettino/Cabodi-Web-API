using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabodi.Models.Output
{
    public class ClienteOutputModel
    {
        public string NroCuenta { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string NroVendedor { get; set; }
        public string CondicionIVA { get; set; }
    }
}