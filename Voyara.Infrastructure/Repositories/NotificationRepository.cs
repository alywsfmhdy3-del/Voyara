using Voyara.Domain.Entities;
using Voyara.Domain.Interfaces;
using Voyara.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyara.Infrastructure.Repositories
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        public NotificationRepository(ApplicationDbContext ctx) : base(ctx) { }

    }
}
