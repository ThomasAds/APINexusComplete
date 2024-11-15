using Microsoft.AspNetCore.Mvc;
using APINexus.Services;

namespace APINexus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (_authService.Authenticate(request.Email, request.Senha))
            {
                return Ok("Login bem-sucedido!");
            }

            return Unauthorized("Credenciais inválidas.");
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; } = null!;
        public string Senha { get; set; } = null!;
    }

}
