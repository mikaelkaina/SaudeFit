using SaudeFit.Domain.Entities;

namespace SaudeFit.Domain.Interfaces;

public interface IExercicioRepository
{
    Task<IEnumerable<Exercicio>> GetTodosAsync();
    Task<IEnumerable<Exercicio>> GetByCategoriaAsync(string categoria);
}
