using SaudeFit.Application.Features.Exercises.Shared;

namespace SaudeFit.Application.Features.Exercises.Queries.GetAll;

public interface IGetAllExerciseHandler
{
    Task <IEnumerable<ExerciseResponse>> Handle();
}