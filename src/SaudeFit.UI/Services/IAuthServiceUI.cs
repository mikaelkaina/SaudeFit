using SaudeFit.UI.Models.Auth;

namespace SaudeFit.UI.Services;

public interface IAuthServiceUI
{
    Task<AuthResponse?> LoginAsync(LoginRequest request);
    Task<bool> RegisterAsync(RegisterRequest request);
    Task LogoutAsync();
}