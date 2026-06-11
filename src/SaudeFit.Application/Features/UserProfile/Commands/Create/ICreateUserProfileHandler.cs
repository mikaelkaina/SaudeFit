namespace SaudeFit.Application.Features.UserProfile.Commands.Create;

public interface ICreateUserProfileHandler
{
    Task<CreateUserProfileResponse> Handle(CreateUserProfileRequest request, CancellationToken cancellationToken);
}