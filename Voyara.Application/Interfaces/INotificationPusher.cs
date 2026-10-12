using System.Threading.Tasks;

namespace Voyara.Application.Interfaces
{
    public interface INotificationPusher
    {
        Task PushToUserAsync(string userId, string title, string message);
    }
}
