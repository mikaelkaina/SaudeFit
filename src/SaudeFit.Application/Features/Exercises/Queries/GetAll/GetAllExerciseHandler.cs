using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Exercises.Queries.GetAll;

public class GetAllExerciseHandler : IGetAllExerciseHandler
{
    private readonly IExerciseRepository _repository;

    public GetAllExerciseHandler(IExerciseRepository repository)
    {
        _repository = repository;
    }
    public async Task<IEnumerable<GetAllExerciseResponse>> Handle()
    {
        var exercise = await _repository.GetTodosAsync();
        return exercise.Select(e => e.ToResponse()).ToList();
    }
}