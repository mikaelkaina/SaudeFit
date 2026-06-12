using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using SaudeFit.API.Controllers.Body;
using SaudeFit.Application.Features.UserProfile.Commands.Create;
using SaudeFit.Application.Features.UserProfile.Commands.Update;
using SaudeFit.Application.Features.UserProfile.Queries.GetUserProfile;

namespace SaudeFit.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly ICreateUserProfileHandler _createUserProfile;
    private readonly IUpdateUserProfileHandler _updateUserProfile;
    private readonly IGetUserProfileHandler _getUserProfile;

    public ProfileController(
        ICreateUserProfileHandler createUserProfile,
        IUpdateUserProfileHandler updateUserProfile,
        IGetUserProfileHandler getUserProfile)
    {
        _createUserProfile = createUserProfile;
        _updateUserProfile = updateUserProfile;
        _getUserProfile = getUserProfile;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProfile([FromBody] ProfileBody body, CancellationToken cancellationToken)
    {
        var userId = GetUserId();

        var request = new CreateUserProfileRequest(userId, body.Gender, body.Age, body.Weight, body.Height);
        var result = await _createUserProfile.Handle(request, cancellationToken);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetProfile()
    {
        var userId = GetUserId();

        var request = new GetUserProfileRequest(userId);
        var result = await _getUserProfile.Handle(request);

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProfile([FromBody] ProfileBody body, CancellationToken cancellationToken)
    {
        var userId = GetUserId();

        var request = new UpdateUserProfileRequest(userId, body.Gender, body.Age, body.Weight, body.Height);
        var result = await _updateUserProfile.Handle(request, cancellationToken);

        return Ok(result);
    }

    private string GetUserId()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (userId is null)
            throw new UnauthorizedAccessException();

        return userId;
    }
}