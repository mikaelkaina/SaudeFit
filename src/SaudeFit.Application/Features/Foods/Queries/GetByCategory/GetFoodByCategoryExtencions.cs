using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public static class GetFoodByCategoryExtencions
{
    public static GetFoodByCategoryResponse ToResponse(this Food foods) =>
        new(
            foods.Name,
            foods.Snack, 
            foods.Description,
            foods.Category,
            foods.Calories
        );
}