namespace SaudeFit.Application.Features.UserProfile.Commands.Update;

public static class UpdateUserProfileExtensions
{
    public static UpdateUserProfileResponse ToResponse(this Domain.Entities.UserProfile profile) =>
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