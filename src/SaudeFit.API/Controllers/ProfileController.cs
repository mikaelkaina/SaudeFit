using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;
using System.Security.Claims;
using SaudeFit.Application.Features.UserProfile.Commands.Create;
using SaudeFit.Domain.Interfaces;

namespace SaudeFit.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly IProfileService _profileService;
    private readonly ICreateUserProfileHandler _createUserProfileHandler;

    public ProfileController(IProfileService profileService, CreateUserProfileHandler createUserProfileHandler)
    {
        _profileService = profileService;
        _createUserProfileHandler = createUserProfileHandler;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProfile([FromBody] CreateProfileDto dto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null) return Unauthorized();

        var result = await _profileService.CreateProfileAsync(userId, dto);
        if (result == null)
            return BadRequest(new { message = "Perfil já existente." });

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetProfile()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null) return Unauthorized();

        var result = await _profileService.GetProfileByUserAsync(userId);
        if (result == null) return NotFound(new { message = "Perfil não encontrado." });

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProfile([FromBody] CreateProfileDto dto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null) return Unauthorized();

        var result = await _profileService.UpdateProfileAsync(userId, dto);
        if (result == null) return BadRequest(new { message = "Não foi possível atualizar o perfil." });

        return Ok(result);
    }
}