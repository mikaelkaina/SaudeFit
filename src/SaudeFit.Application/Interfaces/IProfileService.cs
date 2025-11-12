using SaudeFit.Application.DTOs;

namespace SaudeFit.Application.Interfaces;

public interface IProfileService
{
    Task<UserProfileDto?> CreateProfileAsync(string userId, CreateProfileDto dto);
    Task<UserProfileDto?> GetProfileByUserAsync(string userId);
    Task<UserProfileDto?> UpdateProfileAsync(string userId, CreateProfileDto dto);
}
