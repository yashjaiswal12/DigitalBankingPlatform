using DigitalBanking.Application.Interfaces.Persistence;
using DigitalBanking.Domain.Entities;
using DigitalBanking.Infrastructure.Persistence;

namespace DigitalBanking.Infrastructure.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly ApplicationDbContext _context;

        public RefreshTokenRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddTokenAsync(RefreshToken refreshToken, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<RefreshToken?> GetByRefreshTokenAsync(string token, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTokenAsync(RefreshToken refreshToken, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
