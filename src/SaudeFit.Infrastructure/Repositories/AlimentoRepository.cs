using SaudeFit.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using SaudeFit.Domain.Entities;
using SaudeFit.Infrastructure.Data;

namespace SaudeFit.Infrastructure.Repositories;

public class AlimentoRepository : IAlimentoRepository
{
    private readonly ApplicationDbContext _context;
    public AlimentoRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Alimento>> GetByCategoriaAsync(string categoria)
    {
        return await _context.Alimentos
            .Where(a => a.Categoria == categoria)
            .ToListAsync();
    }

    public async Task<IEnumerable<Alimento>> GetTodosAsync()
    {
        return await _context.Alimentos.ToListAsync();
    }
}