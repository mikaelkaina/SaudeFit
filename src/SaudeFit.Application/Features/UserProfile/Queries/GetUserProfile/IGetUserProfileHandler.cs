namespace SaudeFit.Application.Features.UserProfile.Queries.GetUserProfile;

public interface IGetUserProfileHandler
{
    Task<GetUserProfileResponse> Handle(GetUserProfileRequest request);
}