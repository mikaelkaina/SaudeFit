using SaudeFit.Infrastructure.Identity;
using SaudeFit.Infrastructure.Identity.DTOs;

namespace SaudeFit.Infrastructure.Generator;

public interface ITokenGenerator
{
    AuthResponse GenerateToken(ApplicationUser user);
}
