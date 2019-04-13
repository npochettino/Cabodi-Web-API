namespace Cabodi.Models.Input
{
    public class ItemPreventaInternalModel
    {
        public int NumeroItem { get; set; }

        public string TipoProducto { get; set; }

        public string CodigoArticulo { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Total { get; set; }
    }
}
