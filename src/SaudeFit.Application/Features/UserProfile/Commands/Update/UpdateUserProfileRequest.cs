namespace SaudeFit.Application.Features.UserProfile.Commands.Update;

public record UpdateUserProfileRequest(
    string UserId,
    string Gender,
    int Age,
    double Weight,
    double Height);