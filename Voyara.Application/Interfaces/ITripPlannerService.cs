using Voyara.Application.DTOs;
using System.Threading.Tasks;

namespace Voyara.Application.Interfaces
{
    public interface ITripPlannerService
    {
        Task<TripPlanResponseDto> GenerateTripPlanAsync(TripPlanRequestDto request);
        Task<string> SwapPlaceAsync(string currentPlaceName, string preferences);
    }
}
