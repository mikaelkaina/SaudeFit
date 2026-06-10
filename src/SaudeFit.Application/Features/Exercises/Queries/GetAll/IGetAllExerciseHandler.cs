namespace SaudeFit.Application.Features.Exercises.Queries.GetAll;

public interface IGetAllExerciseHandler
{
    Task <IEnumerable<GetAllExerciseResponse>> Handle();
}