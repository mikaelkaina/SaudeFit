using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Food.Queries.GetAllFood;

public class GetAllFoodHandler : IGetAllFood
{
    private readonly IAlimentoRepository _repository;

    public GetAllFoodHandler(IAlimentoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<GetAllFoodResponse>> Handle()
    {
        var alimentos = await _repository.GetTodosAsync();

        return alimentos.Select(a => a.ToResponse()).ToList();
    }
}
