using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.Features.Exercises.Queries.GetAll;
using SaudeFit.Application.Features.Exercises.Queries.GetByCategory;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExercicioController : ControllerBase
{
    private readonly IGetAllExerciseHandler _getAllExerciseHandler;
    private readonly IGetExerciseByCategoryHandler _getExerciseByCategoryHandler;

    public ExercicioController(IGetAllExerciseHandler getAllExerciseHandler,
        IGetExerciseByCategoryHandler getExerciseByCategoryHandler)
    {
        _getAllExerciseHandler = getAllExerciseHandler;
        _getExerciseByCategoryHandler = getExerciseByCategoryHandler;
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
        var exercise = await _getExerciseByCategoryHandler.Handle(categoria);
        if (!exercise.Any())
            return NotFound($"Nenhum exercício encontrado para a categoria '{categoria}'.");
        return Ok(exercise);
    }
}
