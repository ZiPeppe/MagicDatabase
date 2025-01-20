using MagicDatabase.Models;
using MagicDatabase.Repositories.Interfaces;
using MagicDatabase.Services.Implementations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MagicDatabase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtService;
        private readonly PasswordHasher<User> _passwordHasher;

        public LoginController(IUserRepository userRepository, JwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
            _passwordHasher = new PasswordHasher<User>();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
        {
            // Recupera l'utente dal database usando il repository
            var user = await _userRepository.GetUserByUsernameAsync(login.Username);

            // Verifica se l'utente esiste e se la password è valida
            if (user == null ||
                _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, login.Password) != PasswordVerificationResult.Success)
            {
                return Unauthorized(new { message = "Invalid username or password." });
            }

            // Genera un token JWT
            var token = _jwtService.GenerateToken(user);

            return Ok(new { token });
        }
    }
}
