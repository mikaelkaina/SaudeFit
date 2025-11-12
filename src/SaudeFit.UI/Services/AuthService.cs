using SaudeFit.UI.Models;
using System.Net.Http.Json;

namespace SaudeFit.UI.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private readonly AuthStateProvider _authStateProvider;

    public AuthService(HttpClient httpClient, AuthStateProvider authStateProvider)
    {
        _httpClient = httpClient;
        _authStateProvider = authStateProvider;
    }

    public async Task<AuthResponse?> LoginAsync(LoginRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync("api/auth/login", request);
        if (!response.IsSuccessStatusCode) return null;

        var result = await response.Content.ReadFromJsonAsync<AuthResponse>();
        if (result?.Token != null)
        {
            await _authStateProvider.SetTokenAsync(result.Token);
        }
        return result;
    }

    public async Task<bool> RegisterAsync(RegisterRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync("api/auth/register", request);
        return response.IsSuccessStatusCode;
    }

    public async Task LogoutAsync()
    {
        await _authStateProvider.ClearTokenAsync();
    }
}

