using DigitalBanking.Domain.Entities;

namespace DigitalBanking.Application.Interfaces.Persistence
{
    public interface IRefreshTokenRepository
    {
        Task AddTokenAsync(RefreshToken refreshToken, CancellationToken cancellationToken);
        Task<RefreshToken?> GetByRefreshTokenAsync(string token, CancellationToken cancellationToken);
        Task UpdateTokenAsync(RefreshToken refreshToken, CancellationToken cancellationToken);
    }
}
