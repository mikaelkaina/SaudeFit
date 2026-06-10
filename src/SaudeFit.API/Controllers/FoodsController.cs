using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.Features.Foods.Queries.GetAll;
using SaudeFit.Application.Features.Foods.Queries.GetByCategory;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FoodsController : ControllerBase
{
    private readonly IGetFoodByCategory _getFoodByCategory;
    private readonly IGetAllFood _getAllFood;

    public FoodsController(IGetFoodByCategory getFoodByCategory, IGetAllFood getAllFood)
    {
        _getFoodByCategory = getFoodByCategory;
        _getAllFood = getAllFood;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var foods = await _getAllFood.Handle();
        return Ok(foods);
    }

    [HttpGet("categoria/{categoria}")]
    public async Task<IActionResult> GetByCategoria(string categoria)
    {
        var foods = await  _getFoodByCategory.Execute(categoria);
        if (!foods.Any())
            return NotFound($"Nenhum exercício encontrado para a categoria '{categoria}'.");
        return Ok(foods);
    }
}