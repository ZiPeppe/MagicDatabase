﻿using MagicDatabase.DTOs;
using MagicDatabase.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace MagicDatabase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)] // Nasconde il controller da Swagger
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
    }
    
    /*public class UserController : ControllerBase
    {
        private readonly UserService _authService;

        public UserController(UserService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            try
            {
                var token = await _authService.AuthenticateAsync(loginDto.Username, loginDto.Password);
                return Ok(new { Token = token });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }*/
}
