using Voyara.Domain.Entities;
using Voyara.Domain.Interfaces;
using Voyara.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyara.Infrastructure.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext ctx) : base(ctx) { }

        public async Task<Post?> GetByIdWithDetailsAsync(int id)
        {
            return await _dbSet
                .Include(x => x.User)
                .Include(x => x.Media)
                .Include(x => x.Reactions)
                .Include(x => x.Location)
                .Include(x => x.Comments).ThenInclude(c => c.User)
                .Include(x => x.Comments).ThenInclude(c => c.Media)
                .Include(x => x.Comments).ThenInclude(c => c.Reactions)
                .FirstOrDefaultAsync(x => x.PostID == id);
        }
    }
}
