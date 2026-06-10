using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Foods.Queries.GetAll;

public static class GetAllFoodExtensions
{
    public static GetAllFoodResponse ToResponse(this Food foods) =>
    new(
        foods.Name,
        foods.Snack, 
        foods.Description,
        foods.Category,
        foods.Calories
    );
}