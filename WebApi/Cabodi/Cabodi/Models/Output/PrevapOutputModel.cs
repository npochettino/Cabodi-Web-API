using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cabodi.Models.Input;

namespace Cabodi.Models.Output
{
    public class PrevapOutputModel
    {
        public List<PreventaInternalModel> Prevaps { get; set; }

        public bool Resultado { get; set; }

        public string Mensaje { get; set; }
    }
}