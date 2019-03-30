using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabodi.Models
{
    public class ListaPrecioModel
    {
        public string STTPRE_CODLIS { get; set; }

        public string STTPRE_TIPPRO { get; set; }

        public string STTPRE_ARTCOD { get; set; }

        public DateTime STTPRE_FECLIS { get; set; }

        public decimal? STTPRE_PRECIO { get; set; }
    }
}