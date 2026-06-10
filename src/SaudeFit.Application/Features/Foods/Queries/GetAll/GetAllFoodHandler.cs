using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Foods.Queries.GetAll;

public class GetAllFoodHandler : IGetAllFoodHandler
{
    private readonly IFoodRepository _repository;

    public GetAllFoodHandler(IFoodRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<GetAllFoodResponse>> Handle()
    {
        var foods = await _repository.GetTodosAsync();

        return foods.Select(f => f.ToResponse()).ToList();
    }
}
