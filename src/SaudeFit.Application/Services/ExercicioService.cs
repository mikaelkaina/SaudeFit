using SaudeFit.Application.DTOs;
using SaudeFit.Application.Interfaces;

namespace SaudeFit.Application.Services;

public class ExercicioService : IExercicioService
{
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