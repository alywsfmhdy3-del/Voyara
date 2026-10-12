using System.Threading;
using System.Threading.Tasks;
using Voyara.Application.DTOs;

namespace Voyara.Application.Interfaces
{
    public interface IPlacesSyncService
    {
        Task<SyncResultDto> SyncGovernorateAsync(int governorateId, CancellationToken ct = default);
        Task<SyncResultDto> TestSyncPortSaidAsync(CancellationToken ct = default);
    }
}
