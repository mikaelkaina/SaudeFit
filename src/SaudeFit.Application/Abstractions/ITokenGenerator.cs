using SaudeFit.Application.Common;

namespace SaudeFit.Application.Abstractions;

public interface ITokenGenerator
{
    AuthResponse GenerateToken(AuthenticatedUser user);
}