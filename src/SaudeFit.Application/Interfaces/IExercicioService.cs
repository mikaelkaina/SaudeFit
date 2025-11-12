using SaudeFit.Application.DTOs;

namespace SaudeFit.Application.Interfaces;

public interface IExercicioService
{
    Task<IEnumerable<ExercicioDto>> GetExerciciosPorCategoriaAsync(string categoria);
    Task<IEnumerable<ExercicioDto>> GetTodosAsync();
}
