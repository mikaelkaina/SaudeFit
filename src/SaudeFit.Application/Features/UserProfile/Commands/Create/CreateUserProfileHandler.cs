using SaudeFit.Domain.Exceptions;
using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.UserProfile.Commands.Create;

public class CreateUserProfileHandler : ICreateUserProfileHandler
{
    private readonly IProfileRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserProfileHandler(IProfileRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<CreateUserProfileResponse> Handle(CreateUserProfileRequest request, CancellationToken cancellationToken)
    {
        var existingProfile = await _repository.GetByUserIdAsync(request.UserId);

        if (existingProfile is not null)
            throw new DomainException("User already has a profile");

        var profile = new Domain.Entities.UserProfile(
            request.UserId,
            request.Gender,
            request.Age,
            request.Weight,
            request.Height);

        await _repository.AddAsync(profile);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return profile.ToResponse();
    }
}