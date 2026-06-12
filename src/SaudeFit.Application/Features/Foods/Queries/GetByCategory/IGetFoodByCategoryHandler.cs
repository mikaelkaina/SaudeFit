using SaudeFit.Application.Features.Foods.Shared;

namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public interface IGetFoodByCategoryHandler
{
    Task<IEnumerable<FoodResponse>> Handle(string categoria);
}