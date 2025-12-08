using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Interfaces;

public interface IAlimentoRepository
{
    Task<IEnumerable<Alimento>> GetTodosAsync();
    Task<IEnumerable<Alimento>> GetByCategoriaAsync(string categoria);
}
