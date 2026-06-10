namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public interface IGetFoodByCategory
{
    Task<IEnumerable<Domain.Entities.Food>> Execute(string categoria);
}