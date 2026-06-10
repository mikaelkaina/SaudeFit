namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public record GetFoodByCategoryResponse(
    string Name,
    string Snack,
    string Description,
    string Category,
    int Calories);