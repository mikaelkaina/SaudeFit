using SaudeFit.UI.Models;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace SaudeFit.UI.Services;

public class ProfileService
{
    private readonly HttpClient _httpClient;

    public ProfileService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<UserProfileDto?> GetProfileAsync()
    {
        var response = await _httpClient.GetAsync("api/profile");

        if (response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<UserProfileDto>();

        return null;
    }

    public async Task<bool> CreateProfileAsync(CreateProfileDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/profile", dto);
        return response.IsSuccessStatusCode;
    }

    public async Task<UserProfileDto?> UpdateProfileAsync(CreateProfileDto dto)
    {
        var response = await _httpClient.PutAsJsonAsync("api/profile", dto);
        if (!response.IsSuccessStatusCode) return null;
        return await response.Content.ReadFromJsonAsync<UserProfileDto>();
    }
}