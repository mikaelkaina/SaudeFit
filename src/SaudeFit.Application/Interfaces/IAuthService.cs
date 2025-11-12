using SaudeFit.Application.DTOs;

namespace SaudeFit.Application.Interfaces;

public interface IAuthService
{
    Task<AuthResponse?> LoginAsync(AuthRequest request);
    Task<bool> RegisterAsync(AuthRequest request);
}