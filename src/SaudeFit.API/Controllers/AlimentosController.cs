using Microsoft.AspNetCore.Mvc;
using SaudeFit.Application.Interfaces;
using SaudeFit.Application.Services;
using SaudeFit.Domain.Entities;

namespace SaudeFit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlimentosController : ControllerBase
{
    private readonly IAlimentoService _alimentoService;

    public AlimentosController(IAlimentoService alimentoService)
    {
        _alimentoService = alimentoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var alimentos = await _alimentoService.GetTodosAsync();
        return Ok(alimentos);
    }

    [HttpGet("categoria/{categoria}")]
    public async Task<IActionResult> GetByCategoria(string categoria)
    {
        var alimentos = await _alimentoService.GetAlimentosByCategoriaAsync(categoria);
        if (!alimentos.Any())
            return NotFound($"Nenhum exercício encontrado para a categoria '{categoria}'.");
        return Ok(alimentos);
    }
}