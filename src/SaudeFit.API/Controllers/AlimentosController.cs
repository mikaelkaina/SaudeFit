using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.Features.Food.Queries.GetByCategory;
using SaudeFit.Application.Features.Food.Queries.GetFood;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlimentosController : ControllerBase
{
    private readonly IGetFoodByCategory _getFoodByCategory;
    private readonly IGetFood _getFood;

    public AlimentosController(IGetFoodByCategory getFoodByCategory, IGetFood getFood)
    {
        _getFoodByCategory = getFoodByCategory;
        _getFood = getFood;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var alimentos = await _getFood.Execute();
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