using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Food.Queries.GetByCategory;

public interface IGetFoodByCategory
{
    Task<IEnumerable<Alimento>> Execute(string categoria);
}