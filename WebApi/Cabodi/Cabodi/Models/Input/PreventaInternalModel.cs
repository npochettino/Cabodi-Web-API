using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabodi.Models.Input
{
    public class PreventaInternalModel
    {
        public DateTime FechaMovimiento { get; set; }

        public int NumeroPreventa { get; set; }

        public string NumeroCliente { get; set; }

        public DateTime? FechaDesde { get; set; }

        public DateTime? FechaHasta { get; set; }

        public string UserName { get; set; }

        public string Observacion { get; set; }

        public virtual List<ItemPreventaInternalModel> ItemsPreventa { get; set; }

    }
}