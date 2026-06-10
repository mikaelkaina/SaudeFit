using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.Features.Exercises.Queries.GetAll;
using SaudeFit.Application.Interfaces;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExercicioController : ControllerBase
{
    private readonly IGetAllExerciseHandler _getAllExerciseHandler;

    public ExercicioController(IGetAllExerciseHandler getAllExerciseHandler)
    {
        _getAllExerciseHandler = getAllExerciseHandler;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var exercise = await _getAllExerciseHandler.Handle();
        return Ok(exercise);
    }

    [HttpGet("categoria/{categoria}")]
    public async Task<IActionResult> GetByCategoria(string categoria)
    {
        var exercise = await _exercicioService.GetExerciciosPorCategoriaAsync(categoria);
        if (!exercise.Any())
            return NotFound($"Nenhum exercício encontrado para a categoria '{categoria}'.");
        return Ok(exercise);
    }
}
