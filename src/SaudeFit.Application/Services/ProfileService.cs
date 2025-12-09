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

        double imc = dto.Peso / (dto.Altura * dto.Altura);

        string classificacao = ClassificarImc(imc);

        var profile = new UserProfile
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            Sexo = dto.Sexo,
            Idade = dto.Idade,
            Peso = dto.Peso,
            Altura = dto.Altura,
            Imc = Math.Round(imc, 2),
            Classificacao = classificacao
        };

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

        profile.Sexo = dto.Sexo;
        profile.Idade = dto.Idade;
        profile.Peso = dto.Peso;
        profile.Altura = dto.Altura;

        double imc = profile.Peso / (profile.Altura * profile.Altura);
        profile.Imc = Math.Round(imc, 2);
        profile.Classificacao = ClassificarImc(imc);

        await _repository.UpdateAsync(profile);

        return MapToDto(profile);
    }

    // ------------------------
    // Métodos auxiliares
    // ------------------------

    private static string ClassificarImc(double imc)
    {
        return imc switch
        {
            < 18.5 => "Abaixo do peso",
            >= 18.5 and < 24.9 => "Peso normal",
            >= 25 and < 29.9 => "Sobrepeso",
            _ => "Obesidade"
        };
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