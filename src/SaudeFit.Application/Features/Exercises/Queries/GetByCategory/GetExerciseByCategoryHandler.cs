using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Application.Features.Exercises.Queries.GetByCategory;

public class GetExerciseByCategoryHandler : IGetExerciseByCategoryHandler
{
    private readonly IExerciseRepository _repository;

    public GetExerciseByCategoryHandler(IExerciseRepository repository)
    {
        _repository = repository;
    }
    public async Task<IEnumerable<GetExerciseByCategoryResponse>> Handle(string categoria)
    {
        var exercise = await _repository.GetByCategoriaAsync(categoria);
        return exercise.Select(e => e.ToResponse()).ToList();
    }
}