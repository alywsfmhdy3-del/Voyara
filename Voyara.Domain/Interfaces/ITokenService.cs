using Voyara.Domain.Entities;

namespace Voyara.Domain.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateTokenAsync(ApplicationUser user);
        string GenerateRefreshToken();
    }
}