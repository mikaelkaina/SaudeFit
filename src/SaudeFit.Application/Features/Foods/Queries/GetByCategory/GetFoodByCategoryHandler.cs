using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public class GetFoodByCategoryHandler : IGetFoodByCategoryHandler
{
    private readonly IAlimentoRepository _repository;

    public GetFoodByCategoryHandler(IAlimentoRepository repository)
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