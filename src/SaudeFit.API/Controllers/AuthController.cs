using Azure;
using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(AuthRequest request)
    {
        var response = await _authService.RegisterAsync(request);
        if (!response)
            return BadRequest(new { message = "Erro ao registrar usuário" });

        return Ok(new { message = "Usuário registrado com sucesso!" });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(AuthRequest request)
    {
        var response = await _authService.LoginAsync(request);
        if (response == null) return Unauthorized("Credenciais inválidas");

        Response.Cookies.Append("jwt", response.Token, new CookieOptions
        {
            HttpOnly = true,
            Expires = response.Expiration
        });

        return Ok(response);
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        Response.Cookies.Delete("jwt");
        return Ok("Logout realizado!");
    }
}
