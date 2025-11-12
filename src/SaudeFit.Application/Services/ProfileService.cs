using Microsoft.EntityFrameworkCore;
using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;
using SaudeFit.Domain.Entities;
using SaudeFit.Infrastructure.Data;

namespace SaudeFit.Application.Services;

public class ProfileService : IProfileService
{
    private readonly ApplicationDbContext _context;

    public ProfileService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<UserProfileDto?> CreateProfileAsync(string userId, CreateProfileDto dto)
    {
        var existing = await _context.UserProfiles.FirstOrDefaultAsync(p => p.UserId == userId);
        if (existing != null) return null;

        double imc = dto.Peso / (dto.Altura * dto.Altura);
        string classificacao = imc switch
        {
            < 18.5 => "Abaixo do peso",
            >= 18.5 and < 24.9 => "Peso normal",
            >= 25 and < 29.9 => "Sobrepeso",
            _ => "Obesidade"
        };

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

        _context.UserProfiles.Add(profile);
        await _context.SaveChangesAsync();

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

    public async Task<UserProfileDto?> GetProfileByUserAsync(string userId)
    {
        var profile = await _context.UserProfiles.FirstOrDefaultAsync(p => p.UserId == userId);
        if (profile == null) return null;

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

    public async Task<UserProfileDto?> UpdateProfileAsync(string userId, CreateProfileDto dto)
    {
        var profile = await _context.UserProfiles.FirstOrDefaultAsync(p => p.UserId == userId);
        if (profile == null) return null;

        profile.Sexo = dto.Sexo;
        profile.Idade = dto.Idade;
        profile.Peso = dto.Peso;
        profile.Altura = dto.Altura;

        double imc = profile.Peso / (profile.Altura * profile.Altura);
        profile.Imc = Math.Round(imc, 2);
        profile.Classificacao = imc switch
        {
            < 18.5 => "Abaixo do peso",
            >= 18.5 and < 24.9 => "Peso normal",
            >= 25 and < 29.9 => "Sobrepeso",
            _ => "Obesidade"
        };

        _context.UserProfiles.Update(profile);
        await _context.SaveChangesAsync();

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