using SaudeFit.Domain.Entities;

namespace SaudeFit.Domain.Interfaces;

public interface IAlimentoRepository
{
    Task<IEnumerable<Food>> GetTodosAsync();
    Task<IEnumerable<Food>> GetByCategoriaAsync(string categoria);
}
