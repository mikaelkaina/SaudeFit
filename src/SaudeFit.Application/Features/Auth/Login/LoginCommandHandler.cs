using SaudeFit.Application.Abstractions;
using SaudeFit.Application.Common;

namespace SaudeFit.Application.Features.Auth.Login;

public class LoginCommandHandler : ILoginCommandHandler
{
    private readonly IIdentityService _identityService;
    private readonly ITokenGenerator _tokenGenerator;

    public LoginCommandHandler(IIdentityService identityService, ITokenGenerator tokenGenerator)
    {
        _identityService = identityService;
        _tokenGenerator = tokenGenerator;
    }

    public async Task<AuthResponse?> Handle(LoginCommand command)
    {
        var user = await _identityService.ValidateCredentialsAsync(command.Email, command.Password);
        if (user is null)
            return null;

        return _tokenGenerator.GenerateToken(user);
    }
}
