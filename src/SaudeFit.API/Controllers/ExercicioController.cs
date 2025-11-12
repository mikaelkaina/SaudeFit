using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.Interfaces;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExercicioController : ControllerBase
{
    private readonly IExercicioService _exercicioService;

    public ExercicioController(IExercicioService exercicioService)
    {
        _exercicioService = exercicioService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var exercicios = await _exercicioService.GetTodosAsync();
        return Ok(exercicios);
    }

    [HttpGet("categoria/{categoria}")]
    public async Task<IActionResult> GetByCategoria(string categoria)
    {
        var exercicios = await _exercicioService.GetExerciciosPorCategoriaAsync(categoria);
        if (!exercicios.Any())
            return NotFound($"Nenhum exercício encontrado para a categoria '{categoria}'.");
        return Ok(exercicios);
    }
}
