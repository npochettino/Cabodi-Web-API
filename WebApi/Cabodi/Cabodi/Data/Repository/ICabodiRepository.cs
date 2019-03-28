using System.Threading.Tasks;
using Cabodi.Models;

namespace Cabodi.Data.Repository
{
    public interface ICabodiRepository
    {
        Task<Cliente[]> GetClientsAsync();
    }
}