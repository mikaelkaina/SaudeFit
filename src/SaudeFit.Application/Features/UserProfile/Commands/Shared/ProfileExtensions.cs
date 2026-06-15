namespace SaudeFit.Application.Features.UserProfile.Commands.Shared;

public static class ProfileExtensions
{
    public static ProfileResponse ToResponse(this Domain.Entities.UserProfile profile) =>
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