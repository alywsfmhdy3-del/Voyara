using Voyara.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voyara.Domain.Interfaces
{
    public interface ITripRepository : IRepository<Trip>
    {
        Task<IEnumerable<Trip>> GetByUserIdAsync(string userId, int page, int size);
        Task<int> GetCountByUserIdAsync(string userId);
        Task<Trip?> GetWithPlacesAsync(int id);
    }
}
