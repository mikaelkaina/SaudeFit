using Microsoft.EntityFrameworkCore;
using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;
using SaudeFit.Infrastructure.Data;

namespace SaudeFit.Application.Services;

public class ExercicioService : IExercicioService
{
    private readonly ApplicationDbContext _context;

    public ExercicioService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ExercicioDto>> GetTodosAsync()
    {
        return await _context.Exercicios
            .Select(e => new ExercicioDto
            {
                Id = e.Id,
                Nome = e.Nome,
                Descricao = e.Descricao,
                NivelDificuldade = e.NivelDificuldade,
                Categoria = e.Categoria,
                Repeticoes = e.Repeticoes,
                DuracaoMinutos = e.DuracaoMinutos
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<ExercicioDto>> GetExerciciosPorCategoriaAsync(string categoria)
    {
        return await _context.Exercicios
            .Where(e => e.Categoria.ToLower() == categoria.ToLower())
            .Select(e => new ExercicioDto
            {
                Id = e.Id,
                Nome = e.Nome,
                Descricao = e.Descricao,
                NivelDificuldade = e.NivelDificuldade,
                Categoria = e.Categoria,
                Repeticoes = e.Repeticoes,
                DuracaoMinutos = e.DuracaoMinutos
            })
            .ToListAsync();
    }
}