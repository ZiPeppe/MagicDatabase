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

        public async Task<string?> AuthenticateAsync(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);

            // Se l'utente non esiste, restituisci null o un codice di errore
            if (user == null)
            {
                return null;
            }

            // Verifica la password
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);

            // Se la password non è valida, restituisci null o un codice di errore
            if (result != PasswordVerificationResult.Success)
            {
                return null;
            }

            // Usa il JwtService per generare il token JWT
            return _jwtService.GenerateToken(user);
        }

        public async Task<RefreshToken?> GenerateRefreshTokenAsync(string username)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);

            // Se l'utente non esiste, restituisci null
            if (user == null)
            {
                return null;
            }

            var refreshToken = new RefreshToken
            {
                UserId = user.UserId,
                Token = Guid.NewGuid().ToString(),
                ExpiryDate = DateTime.UtcNow.AddDays(7)
            };

            await _userRepository.SaveRefreshTokenAsync(refreshToken);

            return refreshToken;
        }
        public async Task<string?> ValidateRefreshTokenAsync(string refreshToken)
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
