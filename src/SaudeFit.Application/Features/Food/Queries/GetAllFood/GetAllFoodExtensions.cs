using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Food.Queries.GetAllFood;

public static class GetAllFoodExtensions
{
    public static GetAllFoodResponse ToResponse(this Alimento alimentos) =>
    new(
        alimentos.Nome,
        alimentos.Refeicao, 
        alimentos.Descricao,
        alimentos.Categoria,
        alimentos.Calorias
    );
}