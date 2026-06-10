namespace SaudeFit.Application.Features.Exercises.Queries.GetByCategory;

public interface IGetExerciseByCategoryHandler
{
    Task<IEnumerable<GetExerciseByCategoryResponse>> Handle(string categoria);
}