using SaudeFit.Domain.Entities;
using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Food.Queries.GetByCategory;

public class GetFoodByCategory : IGetFoodByCategory
{
    private readonly IAlimentoRepository _repository;

    public GetFoodByCategory(IAlimentoRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<Alimento>> Execute(string categoria)
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