namespace SaudeFit.Application.Features.Foods.Queries.GetAll;

public record GetAllFoodResponse(
    string Name,
    string Snack,
    string Description,
    string Category,
    int Calories);