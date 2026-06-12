using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Foods.Shared;

public static class FoodExtensions
{
    public static FoodResponse ToResponse(this Food foods) =>
        new(
            foods.Name,
            foods.Snack, 
            foods.Description,
            foods.Category,
            foods.Calories
        );
}