using SaudeFit.Application.Features.Foods.Shared;
using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public class GetFoodByCategoryHandler : IGetFoodByCategoryHandler
{
    private readonly IFoodRepository _repository;

    public GetFoodByCategoryHandler(IFoodRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<FoodResponse>> Handle(string categoria)
    {
        var foods = await _repository.GetByCategoriaAsync(categoria);
        return foods.Select(a => a.ToResponse()).ToList();
    }
}