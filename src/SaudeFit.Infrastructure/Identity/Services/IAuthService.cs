using SaudeFit.Infrastructure.Identity.DTOs;

namespace SaudeFit.Infrastructure.Identity.Services;

public interface IAuthService
{
    Task<AuthResponse?> LoginAsync(AuthRequest request);
    Task<bool> RegisterAsync(AuthRequest request);
}