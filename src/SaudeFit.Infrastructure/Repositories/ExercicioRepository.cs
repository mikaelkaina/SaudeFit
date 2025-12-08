using Microsoft.EntityFrameworkCore;
using SaudeFit.Application.Interfaces;
using SaudeFit.Domain.Entities;
using SaudeFit.Infrastructure.Data;

namespace SaudeFit.Infrastructure.Repositories;

public class ExercicioRepository : IExercicioRepository
{
    private readonly ApplicationDbContext _context;
    public ExercicioRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Exercicio>> GetByCategoriaAsync(string categoria)
    {
        return await _context.Exercicios
            .Where(e => e.Categoria.ToLower() == categoria.ToLower())
            .ToListAsync();
    }

    public async Task<IEnumerable<Exercicio>> GetTodosAsync()
    { 
         return await _context.Exercicios.ToListAsync();
    }
}
