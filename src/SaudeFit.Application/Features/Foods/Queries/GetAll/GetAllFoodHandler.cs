using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Foods.Queries.GetAll;

public class GetAllFoodHandler : IGetAllFood
{
    private readonly IAlimentoRepository _repository;

    public GetAllFoodHandler(IAlimentoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<GetAllFoodResponse>> Handle()
    {
        var foods = await _repository.GetTodosAsync();

        return foods.Select(a => a.ToResponse()).ToList();
    }
}
