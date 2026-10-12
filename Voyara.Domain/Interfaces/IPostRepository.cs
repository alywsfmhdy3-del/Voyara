using Voyara.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voyara.Domain.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<Post?> GetByIdWithDetailsAsync(int id);
    }
}
