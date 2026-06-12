using SaudeFit.Domain.Exceptions;
using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.UserProfile.Queries.GetUserProfile;

public class GetUserProfileHandler : IGetUserProfileHandler
{
    private readonly IProfileRepository _repository;

    public GetUserProfileHandler(IProfileRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<GetUserProfileResponse> Handle(GetUserProfileRequest request)
    {
        var profile = await _repository.GetByUserIdAsync(request.UserId);

        if (profile is null)
            throw new NotFoundException("Profile not found.");

        return profile.ToResponse();
    }
}