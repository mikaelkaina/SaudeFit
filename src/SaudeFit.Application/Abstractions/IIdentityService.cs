using SaudeFit.Application.Common;

namespace SaudeFit.Application.Abstractions;

public interface IIdentityService
{
    Task<AuthenticatedUser?> ValidateCredentialsAsync(string email, string password);
    Task<(bool Succeeded, IEnumerable<string> Errors)> RegisterAsync(string email, string password);
}