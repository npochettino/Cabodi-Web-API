using Cabodi.Models;
using Cabodi.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabodi.Data.Helper
{
    public class Common
    {
        public PreVenta MapearPreventa(PreventaInternalModel preventa)
        {
            var NewPreventa = new PreVenta()
            {
                FCRMVH_NROCTA = preventa.NumeroCliente
            };

            return NewPreventa;
        }

        public List<ItemPreVenta> MapearItemPreVenta(PreventaInternalModel items)
        {
            List<ItemPreVenta> ItemsPreventa = new List<ItemPreVenta>();

            foreach (var i in items.ItemsPreventa)
            {
                var NewItem = new ItemPreVenta()
                {
                    FCRMVI_ARTCOD = i.CodigoArticulo,
                    FCRMVI_TIPPRO = i.TipoProducto
                };
                
                ItemsPreventa.Add(NewItem);
            }

            return ItemsPreventa;
        }
    }
}