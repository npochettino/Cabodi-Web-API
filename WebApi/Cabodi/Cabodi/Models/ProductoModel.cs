using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabodi.Models
{
    public class ProductoModel
    {
        public string STMPDH_TIPPRO { get; set; }

        public string STMPDH_ARTCOD { get; set; }

        public string STMPDH_DESCRP { get; set; }

        public string STMPDH_UNIMED { get; set; }

        public string STMPDH_INDCOD { get; set; }

        public string STMPDH_UNICON { get; set; }

        //Precio
        public decimal? STTPRE_PRECIO { get; set; }
    }
}