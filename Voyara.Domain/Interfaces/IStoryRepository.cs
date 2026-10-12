using Voyara.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Voyara.Domain.Interfaces
{
    public interface IStoryRepository : IRepository<Story>
    {
        Task<List<Story>> GetActiveStoriesAsync();
        Task<List<Story>> GetStoriesByUserAsync(string userId);
    }
}
