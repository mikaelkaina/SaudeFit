using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Food.Queries.GetAllFood;

public interface IGetAllFood
{
    Task<IEnumerable<GetAllFoodResponse>> Handle();
}