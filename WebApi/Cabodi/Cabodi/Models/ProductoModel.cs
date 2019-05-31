using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabodi.Models
{
    public class ProductoModel
    {
        public string TipoProducto { get; set; }

        public string CodigoArticulo { get; set; }

        public string Descripcion { get; set; }

        public string UnidadMedida { get; set; }

        public string Indcod { get; set; }

        public string Unidad { get; set; }

        //Precio
        public decimal? Precio { get; set; }
    }
}