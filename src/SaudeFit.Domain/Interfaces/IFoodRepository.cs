using SaudeFit.Domain.Entities;

namespace SaudeFit.Domain.Interfaces;

public interface IFoodRepository
{
    Task<IEnumerable<Food>> GetTodosAsync();
    Task<IEnumerable<Food>> GetByCategoriaAsync(string categoria);
}
