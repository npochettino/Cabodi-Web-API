using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabodi.Models.Input
{
    public class PrevapFilterInputModel
    {
        public string NumeroVendedor { get; set; }

        public string NumeroCliente { get; set; }

        public DateTime? FechaDesde { get; set; }

        public DateTime? FechaHasta { get; set; }
    }
}