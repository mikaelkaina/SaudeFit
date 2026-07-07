namespace SaudeFit.Application.Features.Auth.Register;

public interface IRegisterCommandHandler
{
    Task<bool> Handle(RegisterCommand command);
}
