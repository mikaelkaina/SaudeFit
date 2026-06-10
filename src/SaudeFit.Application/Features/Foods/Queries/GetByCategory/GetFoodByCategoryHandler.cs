using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public class GetFoodByCategoryHandler : IGetFoodByCategoryHandler
{
    private readonly IFoodRepository _repository;

    public GetFoodByCategoryHandler(IFoodRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<GetFoodByCategoryResponse>> Handle(string categoria)
    {
        var foods = await _repository.GetByCategoriaAsync(categoria);
        return foods.Select(a => a.ToResponse()).ToList();
    }
}