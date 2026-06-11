using SaudeFit.Domain.Exceptions;
using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.UserProfile.Commands.Update;

public class UpdateUserProfileHandler : IUpdateUserProfileHandler
{
    private readonly IProfileRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateUserProfileHandler(IProfileRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<UpdateUserProfileResponse> Handle(UpdateUserProfileRequest request, CancellationToken cancellationToken)
    {
        var profile = await _repository.GetByUserIdAsync(request.UserId);

        if (profile is null)
            throw new DomainException("User profile not found");

        profile.UpdateData(
            request.Gender,
            request.Age,
            request.Weight,
            request.Height);

        await _repository.UpdateAsync(profile);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return profile.ToResponse();
    }
}