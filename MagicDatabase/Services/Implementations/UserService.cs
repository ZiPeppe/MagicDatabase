using MagicDatabase.Models;
using MagicDatabase.Repositories.Interfaces;
using MagicDatabase.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MagicDatabase.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordHasher<User> _passwordHasher;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _passwordHasher = new PasswordHasher<User>();
            _configuration = configuration;
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

            // Genera un token JWT per l'utente autenticato
            return GenerateJwtToken(user);
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetUserByUsernameAsync(username);
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]); // Legge la chiave dal file di configurazione

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role) // Opzionale
            }),
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:TokenExpiryInMinutes"])),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
