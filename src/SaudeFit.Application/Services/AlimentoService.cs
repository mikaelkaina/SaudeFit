using Microsoft.EntityFrameworkCore;
using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;
using SaudeFit.Infrastructure.Data;

namespace SaudeFit.Application.Services;

public class AlimentoService : IAlimentoService
{
    private readonly ApplicationDbContext _context;

    public AlimentoService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<AlimentoDto>> GetAlimentosByCategoriaAsync(string categoria)
    {
        return await _context.Alimentos
            .Where(a => a.Categoria == categoria)
            .Select(a => new AlimentoDto
            {
                Nome = a.Nome,
                Refeicao = a.Refeicao,
                Descricao = a.Descricao,
                Categoria = a.Categoria,
                Calorias = a.Calorias
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<AlimentoDto>> GetTodosAsync()
    {
        return await _context.Alimentos
            .Select(a => new AlimentoDto
            {
                Nome = a.Nome,
                Refeicao = a.Refeicao,
                Descricao = a.Descricao,
                Categoria = a.Categoria,
                Calorias = a.Calorias
            })
            .ToListAsync();
    }
}
