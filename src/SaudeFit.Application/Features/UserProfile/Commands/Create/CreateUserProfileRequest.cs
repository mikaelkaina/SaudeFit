namespace SaudeFit.Application.Features.UserProfile.Commands.Create;

public record CreateUserProfileRequest(
    string UserId,
    string Gender,
    int Age,
    double Weight,
    double Height);