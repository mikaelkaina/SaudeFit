using SaudeFit.Domain.Entities;

namespace SaudeFit.Domain.Interfaces;

public interface IProfileRepository
{
    Task<UserProfile?> GetByUserIdAsync(string userId);
    Task AddAsync(UserProfile profile);
    Task UpdateAsync(UserProfile profile);
}
