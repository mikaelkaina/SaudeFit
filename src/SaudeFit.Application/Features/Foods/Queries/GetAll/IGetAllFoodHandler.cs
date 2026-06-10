namespace SaudeFit.Application.Features.Foods.Queries.GetAll;

public interface IGetAllFoodHandler
{
    Task<IEnumerable<GetAllFoodResponse>> Handle();
}