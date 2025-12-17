using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;
using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Services;

public class ProfileService : IProfileService
{
    private readonly IProfileRepository _repository;

    public ProfileService(IProfileRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserProfileDto?> CreateProfileAsync(string userId, CreateProfileDto dto)
    {
        var existing = await _repository.GetByUserIdAsync(userId);
        if (existing != null) return null;

        var profile = new UserProfile(
            userId,
            dto.Sexo,
            dto.Idade,
            dto.Peso,
            dto.Altura
        );

        await _repository.AddAsync(profile);

        return MapToDto(profile);
    }

    public async Task<UserProfileDto?> GetProfileByUserAsync(string userId)
    {
        var profile = await _repository.GetByUserIdAsync(userId);
        return profile == null ? null : MapToDto(profile);
    }

    public async Task<UserProfileDto?> UpdateProfileAsync(string userId, CreateProfileDto dto)
    {
        var profile = await _repository.GetByUserIdAsync(userId);
        if (profile == null) return null;

        profile.AtualizarDados(
            dto.Sexo,
            dto.Idade,
            dto.Peso,
            dto.Altura
        );

        await _repository.UpdateAsync(profile);

        return MapToDto(profile);
    }

    private static UserProfileDto MapToDto(UserProfile profile)
    {
        return new UserProfileDto
        {
            Sexo = profile.Sexo,
            Idade = profile.Idade,
            Peso = profile.Peso,
            Altura = profile.Altura,
            Imc = profile.Imc,
            Classificacao = profile.Classificacao
        };
    }
}