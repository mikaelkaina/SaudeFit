using Microsoft.EntityFrameworkCore;
using SaudeFit.Domain.Entities;
using SaudeFit.Domain.Interfaces;
using SaudeFit.Infrastructure.Data;

namespace SaudeFit.Infrastructure.Repositories;

public class ExerciseRepository : IExerciseRepository
{
    private readonly ApplicationDbContext _context;
    public ExerciseRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Exercise>> GetByCategoriaAsync(string categoria)
    {
        return await _context.Exercises
            .Where(e => e.Category.ToLower() == categoria.ToLower())
            .ToListAsync();
    }

    public async Task<IEnumerable<Exercise>> GetTodosAsync()
    { 
         return await _context.Exercises.ToListAsync();
    }
}
