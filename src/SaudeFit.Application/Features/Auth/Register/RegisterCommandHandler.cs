using SaudeFit.Application.Abstractions;

namespace SaudeFit.Application.Features.Auth.Register;

public class RegisterCommandHandler : IRegisterCommandHandler
{
    private readonly IIdentityService _identityService;

    public RegisterCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<bool> Handle(RegisterCommand command)
    {
        var result = await _identityService.RegisterAsync(command.Email, command.Password);

        return result.Succeeded;
    }
}
