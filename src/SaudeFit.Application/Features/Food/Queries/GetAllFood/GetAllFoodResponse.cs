namespace SaudeFit.Application.Features.Food.Queries.GetAllFood;

public record GetAllFoodResponse(
    string Nome,
    string Refeicao,
    string Descricao,
    string Categoria,
    int Calorias);