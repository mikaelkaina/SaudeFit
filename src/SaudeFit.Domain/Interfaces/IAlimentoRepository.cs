using SaudeFit.Domain.Entities;

namespace SaudeFit.Domain.Interfaces;

public interface IAlimentoRepository
{
    Task<IEnumerable<Alimento>> GetTodosAsync();
    Task<IEnumerable<Alimento>> GetByCategoriaAsync(string categoria);
}
