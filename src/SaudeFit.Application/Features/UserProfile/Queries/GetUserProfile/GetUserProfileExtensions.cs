namespace SaudeFit.Application.Features.UserProfile.Queries.GetUserProfile;

public static class GetUserProfileExtensions
{
    public static GetUserProfileResponse ToResponse(this Domain.Entities.UserProfile profile) =>
        new(
            profile.UserId,
            profile.Gender,
            profile.Age,
            profile.Weight,
            profile.Height,
            profile.Bmi,
            profile.Classification
        );
}