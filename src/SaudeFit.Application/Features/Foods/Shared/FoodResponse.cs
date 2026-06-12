namespace SaudeFit.Application.Features.Foods.Shared;

public record FoodResponse(
    string Name,
    string Snack,
    string Description,
    string Category,
    int Calories);