using Voyara.Domain.Entities;
using Voyara.Domain.Interfaces;
using Voyara.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Voyara.Infrastructure.Repositories
{
    public class ReactionRepository : IReactionRepository
    {
        private readonly ApplicationDbContext _ctx;

        public ReactionRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }




    }
}
