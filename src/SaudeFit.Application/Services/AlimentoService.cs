using SaudeFit.Application.Interfaces;
using SaudeFit.Domain.Entities;
using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Services;

public class AlimentoService : IAlimentoService
{
    private readonly IAlimentoRepository _repository;

    public AlimentoService(IAlimentoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Alimento>> GetTodosAsync()
    {
        var alimentos = await _repository.GetTodosAsync();

        return alimentos.Select(a => new Alimento()
        {
            Nome = a.Nome,
            Refeicao = a.Refeicao,
            Descricao = a.Descricao,
            Categoria = a.Categoria,
            Calorias = a.Calorias
        });
    }

    public async Task<IEnumerable<Alimento>> GetAlimentosByCategoriaAsync(string categoria)
    {
        var alimentos = await _repository.GetByCategoriaAsync(categoria);

        return alimentos.Select(a => new Alimento()
        {
            Nome = a.Nome,
            Refeicao = a.Refeicao,
            Descricao = a.Descricao,
            Categoria = a.Categoria,
            Calorias = a.Calorias
        });
    }
}
