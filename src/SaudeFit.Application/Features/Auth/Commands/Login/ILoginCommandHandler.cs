using SaudeFit.Application.Common;

namespace SaudeFit.Application.Features.Auth.Commands.Login;

public interface ILoginCommandHandler
{
    Task<AuthResponse?> Handle(LoginCommand command);
}
