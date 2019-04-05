using System.Threading.Tasks;
using Cabodi.Data.Entities;
using Cabodi.Models;
using Cabodi.Models.Input;
using Cabodi.Models.Output;

namespace Cabodi.Data.Repository
{
    public interface ICabodiRepository
    {
        Task<Cliente[]> GetClientesAsync();
        Task<Cliente> GetCliente(string NROCTA);
        Task<bool> SaveChangesAsync();
        Task<Cliente[]> GetClientesPorVendedorAsync(string vendedor);
        Task<Vendedor[]> GetVendedoresAsync();
        Task<ProductoModel[]> GetProductosAsync();
        Task<ProductoModel> GetProductoPorINDCODAsync(string INDCOD);
        Task<Producto> GetProductoPorTIPPRO_ARTCODAsync(string TIPPRO, string ARTCOD);
        Task<ListaPrecio[]> GetListaDePreciosAsync();
        Task<AuthOutputModel> ValidatePassword(AuthInternalModel authModel);
    }
}