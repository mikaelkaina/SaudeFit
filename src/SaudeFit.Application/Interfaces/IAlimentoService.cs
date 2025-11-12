using SaudeFit.Application.DTOs;

namespace SaudeFit.Application.Interfaces;

public interface IAlimentoService
{
    Task<IEnumerable<AlimentoDto>> GetAlimentosByCategoriaAsync(string categoria);
    Task<IEnumerable<AlimentoDto>> GetTodosAsync();
}
