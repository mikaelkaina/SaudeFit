namespace SaudeFit.Application.Features.UserProfile.Commands.Create;

public static class CreateUserProfileExtensions
{
    public static CreateUserProfileResponse ToResponse(this Domain.Entities.UserProfile profile) =>
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