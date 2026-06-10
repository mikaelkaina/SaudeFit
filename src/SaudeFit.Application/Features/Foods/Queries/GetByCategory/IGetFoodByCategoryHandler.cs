namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public interface IGetFoodByCategoryHandler
{
    Task<IEnumerable<Domain.Entities.Food>> Execute(string categoria);
}