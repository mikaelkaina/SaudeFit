using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.Features.Food.Queries.GetAllFood;
using SaudeFit.Application.Features.Food.Queries.GetByCategory;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlimentosController : ControllerBase
{
    private readonly IGetFoodByCategory _getFoodByCategory;
    private readonly IGetAllFood _getAllFood;

    public AlimentosController(IGetFoodByCategory getFoodByCategory, IGetAllFood getAllFood)
    {
        _getFoodByCategory = getFoodByCategory;
        _getAllFood = getAllFood;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var alimentos = await _getAllFood.Handle();
        return Ok(alimentos);
    }

    [HttpGet("categoria/{categoria}")]
    public async Task<IActionResult> GetByCategoria(string categoria)
    {
        var alimentos = await  _getFoodByCategory.Execute(categoria);
        if (!alimentos.Any())
            return NotFound($"Nenhum exercício encontrado para a categoria '{categoria}'.");
        return Ok(alimentos);
    }
}