using Voyara.Domain.Entities;
using Voyara.Domain.Interfaces;
using Voyara.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyara.Infrastructure.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext ctx) : base(ctx) { }

    }
}
