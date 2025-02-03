using MagicDatabase.Models;
using MagicDatabase.Repositories.Interfaces;
using MagicDatabase.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MagicDatabase.Services.Implementations;


namespace MagicDatabase.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordHasher<User> _passwordHasher;
        private readonly JwtService _jwtService;

        public UserService(IUserRepository userRepository, JwtService jwtService)
        {
            _userRepository = userRepository;
            _passwordHasher = new PasswordHasher<User>();
            _jwtService = jwtService;
        }

        public async Task<string> AuthenticateAsync(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);

            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            // Verifica la password
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);

            if (result != PasswordVerificationResult.Success)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            // Usa il JwtService per generare il token JWT
            return _jwtService.GenerateToken(user);
        }

        public async Task<RefreshToken> GenerateRefreshTokenAsync(string username)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }
            var refreshToken = new RefreshToken
            {
                UserId = user.UserId,
                Token = Guid.NewGuid().ToString(),
                ExpiryDate = DateTime.UtcNow.AddDays(7) // valido per 7 giorni
            };

            await _userRepository.SaveRefreshTokenAsync(refreshToken);

            return refreshToken;
        }
        public async Task<string> ValidateRefreshTokenAsync(string refreshToken)
        {
            // Logica per validare il refresh token
            var token = await _userRepository.GetRefreshTokenAsync(refreshToken);
            if (token == null || token.ExpiryDate <= DateTime.UtcNow)
            {
                return null; // Token non valido o scaduto
            }

            var user = await _userRepository.GetUserByIdAsync(token.UserId);
            if (user == null)
            {
                return null; // Utente non trovato
            }

            // Invalida il vecchio token
            token.Revoked = true;
            await _userRepository.UpdateRefreshTokenAsync(token);

            // Genera un nuovo JWT
            return _jwtService.GenerateToken(user);
        }
    }
}
