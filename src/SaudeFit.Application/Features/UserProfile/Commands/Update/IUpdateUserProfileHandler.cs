using SaudeFit.Application.Features.UserProfile.Commands.Shared;

namespace SaudeFit.Application.Features.UserProfile.Commands.Update;

public interface IUpdateUserProfileHandler
{
    Task<ProfileResponse> Handle(UpdateUserProfileRequest request, CancellationToken cancellationToken);
}