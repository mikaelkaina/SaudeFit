using SaudeFit.Application.Features.Foods.Shared;

namespace SaudeFit.Application.Features.Foods.Queries.GetAll;

public interface IGetAllFoodHandler
{
    Task<IEnumerable<FoodResponse>> Handle();
}