namespace SaudeFit.Application.Features.Foods.Queries.GetByCategory;

public interface IGetFoodByCategoryHandler
{
    Task<IEnumerable<GetFoodByCategoryResponse>> Handle(string categoria);
}