using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;

namespace SaudeFit.Application.Services;

public class ExercicioService : IExercicioService
{
    private readonly IExercicioRepository _repo;

    public ExercicioService(IExercicioRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<ExercicioDto>> GetTodosAsync()
    {
        var exercicios = await _repo.GetTodosAsync();

        return exercicios.Select(e => new ExercicioDto
        {
            Id = e.Id,
            Nome = e.Nome,
            Descricao = e.Descricao,
            NivelDificuldade = e.NivelDificuldade,
            Categoria = e.Categoria,
            Repeticoes = e.Repeticoes,
            DuracaoMinutos = e.DuracaoMinutos
        });
    }

    public async Task<IEnumerable<ExercicioDto>> GetExerciciosPorCategoriaAsync(string categoria)
    {
        var exercicios = await _repo.GetByCategoriaAsync(categoria);

        return exercicios.Select(e => new ExercicioDto
        {
            Id = e.Id,
            Nome = e.Nome,
            Descricao = e.Descricao,
            NivelDificuldade = e.NivelDificuldade,
            Categoria = e.Categoria,
            Repeticoes = e.Repeticoes,
            DuracaoMinutos = e.DuracaoMinutos
        });
    }
}