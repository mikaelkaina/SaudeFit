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
    
    public async Task<IEnumerable<Domain.Entities.Food>> Execute(string categoria)
    {
        var alimentos = await _repository.GetByCategoriaAsync(categoria);

        return alimentos.Select(a => new Domain.Entities.Food()
        {
            Name = a.Name,
            Snack = a.Snack,
            Description = a.Description,
            Category = a.Category,
            Calories = a.Calories
        });
    }
}