namespace SaudeFit.Application.Features.Foods.Queries.GetAll;

public record GetAllFoodResponse(
    string Nome,
    string Refeicao,
    string Descricao,
    string Categoria,
    int Calorias);