using MagicDatabase.Models;

namespace MagicDatabase.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> AuthenticateAsync(string username, string password);
        Task<RefreshToken> GenerateRefreshTokenAsync(string username);
        Task<string> ValidateRefreshTokenAsync(string refreshToken);
    }
}
