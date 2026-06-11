namespace SaudeFit.Application.Features.UserProfile.Queries.GetUserProfile;

public record GetUserProfileResponse(
    string UserId,
    string Gender,
    int Age,
    double Weight,
    double Height,
    double Bmi,
    string Classification);