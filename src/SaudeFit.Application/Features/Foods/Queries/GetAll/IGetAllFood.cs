namespace SaudeFit.Application.Features.Foods.Queries.GetAll;

public interface IGetAllFood
{
    Task<IEnumerable<GetAllFoodResponse>> Handle();
}