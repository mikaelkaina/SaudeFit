using SaudeFit.Domain.Entities;

namespace SaudeFit.Domain.Interfaces;

public interface IExerciseRepository
{
    Task<IEnumerable<Exercise>> GetTodosAsync();
    Task<IEnumerable<Exercise>> GetByCategoriaAsync(string categoria);
}
