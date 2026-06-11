namespace SaudeFit.Application.Features.UserProfile.Commands.Create;

public record CreateUserProfileResponse(
    string UserId,
    string Gender,
    int Age,
    double Weight,
    double Height,
    double Bmi,
    string Classification);