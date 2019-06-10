using System.Collections.Generic;
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
        Task<Cliente> GetClienteAsync(string NROCTA);
        Cliente GetCliente(string NROCTA);
        Task<bool> SaveChangesAsync();
        bool SaveChanges();
        Task<Cliente[]> GetClientesPorVendedorAsync(string vendedor);
        Task<Vendedor[]> GetVendedoresAsync();
        Task<ProductoModel[]> GetProductosAsync();
        Task<ProductoModel[]> GetProductosPorCondicionIVA(string CondicionIVA);
        Task<ProductoModel> GetProductoPorINDCODAsync(string INDCOD);
        ProductoModel GetProductoPorINDCOD(string INDCOD);
        Task<Producto> GetProductoPorTIPPRO_ARTCODAsync(string TIPPRO, string ARTCOD);
        Producto GetProductoPorTIPPRO_ARTCOD(string TIPPRO, string ARTCOD);
        Task<ListaPrecio[]> GetListaDePreciosAsync();
        Task<AuthOutputModel> ValidatePassword(AuthInternalModel authModel);
        void AddItemPreventa(ItemPreVenta item);
        void AddPreventa(PreVenta newPreventa);

        PreVenta GetLastPreventa();
        Task<PreventaInternalModel[]> GetPreventasPorVendedorAsync(string id);
        List<PreventaInternalModel> GetPreventasHeaderPorVendedor(string id);
        List<ItemPreventaInternalModel> GetItemsPreventa(int id);
        Task<ItemPreVenta[]> GetItemsPrevenAsync(int preventID);
        Task<PreVenta> GetPrevenAsync(int preventID);
        void DeleteItemsPreven(ItemPreVenta[] items);
        void DeletePreven(PreVenta preven);
    }
}