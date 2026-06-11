namespace SaudeFit.Application.Features.UserProfile.Commands.Update;

public record UpdateUserProfileResponse(
    string UserId,
    string Gender,
    int Age,
    double Weight,
    double Height,
    double Bmi,
    string Classification);