using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Food.Queries.GetFood;

public interface IGetFood
{
    Task<IEnumerable<Alimento>> Execute();
}