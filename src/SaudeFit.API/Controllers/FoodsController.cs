using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.Features.Foods.Queries.GetAll;
using SaudeFit.Application.Features.Foods.Queries.GetByCategory;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FoodsController : ControllerBase
{
    private readonly IGetFoodByCategoryHandler _getFoodByCategoryHandler;
    private readonly IGetAllFoodHandler _getAllFoodHandler;

    public FoodsController(IGetFoodByCategoryHandler getFoodByCategoryHandler, IGetAllFoodHandler getAllFoodHandler)
    {
        _getFoodByCategoryHandler = getFoodByCategoryHandler;
        _getAllFoodHandler = getAllFoodHandler;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var foods = await _getAllFoodHandler.Handle();
        return Ok(foods);
    }

    [HttpGet("categoria/{categoria}")]
    public async Task<IActionResult> GetByCategoria(string categoria)
    {
        var foods = await  _getFoodByCategoryHandler.Execute(categoria);
        if (!foods.Any())
            return NotFound($"Nenhum exercício encontrado para a categoria '{categoria}'.");
        return Ok(foods);
    }
}