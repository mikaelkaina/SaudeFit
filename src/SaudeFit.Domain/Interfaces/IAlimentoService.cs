using SaudeFit.Domain.Entities;

namespace SaudeFit.Domain.Interfaces;

public interface IAlimentoService
{
    Task<IEnumerable<Alimento>> GetAlimentosByCategoriaAsync(string categoria);
    Task<IEnumerable<Alimento>> GetTodosAsync();
}
