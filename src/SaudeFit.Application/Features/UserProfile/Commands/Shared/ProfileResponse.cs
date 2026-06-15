namespace SaudeFit.Application.Features.UserProfile.Commands.Shared;

public record ProfileResponse(
    string UserId,
    string Gender,
    int Age,
    double Weight,
    double Height,
    double Bmi,
    string Classification);