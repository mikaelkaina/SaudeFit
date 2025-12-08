using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;

namespace SaudeFit.Application.Services;

public class AlimentoService : IAlimentoService
{
    private readonly IAlimentoRepository _repository;

    public AlimentoService(IAlimentoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<AlimentoDto>> GetTodosAsync()
    {
        var alimentos = await _repository.GetTodosAsync();

        return alimentos.Select(a => new AlimentoDto
        {
            Nome = a.Nome,
            Refeicao = a.Refeicao,
            Descricao = a.Descricao,
            Categoria = a.Categoria,
            Calorias = a.Calorias
        });
    }

    public async Task<IEnumerable<AlimentoDto>> GetAlimentosByCategoriaAsync(string categoria)
    {
        var alimentos = await _repository.GetByCategoriaAsync(categoria);

        return alimentos.Select(a => new AlimentoDto
        {
            Nome = a.Nome,
            Refeicao = a.Refeicao,
            Descricao = a.Descricao,
            Categoria = a.Categoria,
            Calorias = a.Calorias
        });
    }
}
