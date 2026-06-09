using SaudeFit.Domain.Entities;
using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Food.Queries.GetFood;

public class GetFood : IGetFood
{
    private readonly IAlimentoRepository _repository;

    public GetFood(IAlimentoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Alimento>> Execute()
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
}
