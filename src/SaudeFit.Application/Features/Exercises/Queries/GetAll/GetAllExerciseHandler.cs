using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Exercises.Queries.GetAll;

public class GetAllExerciseHandler : IGetAllExerciseHandler
{
    private readonly IExercicioRepository _repository;

    public GetAllExerciseHandler(IExercicioRepository repository)
    {
        _repository = repository;
    }
    public async Task<IEnumerable<GetAllExerciseResponse>> Handle()
    {
        var exercise = await _repository.GetTodosAsync();
        return exercise.Select(a => a.ToResponse()).ToList();
    }
}