using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.UserProfile.Queries.GetUserProfile;

public class GetUserProfileHandler : IGetUserProfileHandler
{
    private readonly IProfileRepository _repository;

    public GetUserProfileHandler(IProfileRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<GetUserProfileResponse?> Handle(GetUserProfileRequest request)
    {
        
        var profile = await _repository.GetByUserIdAsync(request.UserId);

        return profile?.ToResponse();
    }
}