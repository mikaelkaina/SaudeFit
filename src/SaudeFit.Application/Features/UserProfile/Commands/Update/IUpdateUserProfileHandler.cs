namespace SaudeFit.Application.Features.UserProfile.Commands.Update;

public interface IUpdateUserProfileHandler
{
    Task<UpdateUserProfileResponse> Handle(UpdateUserProfileRequest request, CancellationToken cancellationToken);
}