using Microsoft.EntityFrameworkCore;
using SaudeFit.Domain.Entities;
using SaudeFit.Domain.Interfaces;
using SaudeFit.Infrastructure.Data;

namespace SaudeFit.Infrastructure.Repositories;

public class FoodRepository : IAlimentoRepository
{
    private readonly ApplicationDbContext _context;
    public FoodRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Food>> GetByCategoriaAsync(string categoria)
    {
        return await _context.Foods
            .Where(a => a.Category == categoria)
            .ToListAsync();
    }

    public async Task<IEnumerable<Food>> GetTodosAsync()
    {
        return await _context.Foods.ToListAsync();
    }
}