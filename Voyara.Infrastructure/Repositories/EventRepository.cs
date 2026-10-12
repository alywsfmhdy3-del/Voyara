using Voyara.Domain.Entities;
using Voyara.Domain.Interfaces;
using Voyara.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyara.Infrastructure.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(ApplicationDbContext ctx) : base(ctx) { }

    }
}
