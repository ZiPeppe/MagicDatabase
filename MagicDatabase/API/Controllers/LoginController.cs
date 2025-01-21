using MagicDatabase.Models;
using MagicDatabase.Repositories.Interfaces;
using MagicDatabase.Services.Implementations;
using MagicDatabase.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
        {
            try
            {
                // Usa il servizio per autenticare e ottenere il token
                var token = await _userService.AuthenticateAsync(login.Username, login.Password);
                return Ok(new { token });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized(new { message = "Invalid username or password." });
            }
        }
    }
}
