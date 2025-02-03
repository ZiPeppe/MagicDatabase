using MagicDatabase.DTOs;
using MagicDatabase.Repositories.Interfaces;
using MagicDatabase.Services.Implementations;
using MagicDatabase.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MagicDatabase.Models.Refresh_Tokens;

namespace MagicDatabase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            try
            {
                // Usa il servizio per autenticare e ottenere il token
                var token = await _userService.AuthenticateAsync(login.Username, login.Password);
                // Genera il refresh token
                var refreshToken = await _userService.GenerateRefreshTokenAsync(login.Username);
                return Ok(new
                {
                    token,
                    refreshToken = refreshToken.Token
                });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized(new { message = "Invalid username or password." });
            }
        }

        [HttpPost("validate-refresh-token")]
        public async Task<IActionResult> ValidateRefreshToken([FromBody] RefreshTokenRequest request)
        {
            var newAccessToken = await _userService.ValidateRefreshTokenAsync(request.RefreshToken);

            if (string.IsNullOrEmpty(newAccessToken))
            {
                return Unauthorized(new { message = "Invalid or expired refresh token." });
            }

            return Ok(new { accessToken = newAccessToken });
        }
    }
}
