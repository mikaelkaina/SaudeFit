using SaudeFit.Application.Features.UserProfile.Commands.Shared;

namespace SaudeFit.Application.Features.UserProfile.Commands.Create;

public interface ICreateUserProfileHandler
{
    Task<ProfileResponse> Handle(CreateUserProfileRequest request, CancellationToken cancellationToken);
}