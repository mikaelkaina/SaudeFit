using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Exercises.Queries.GetByCategory;

public static class GetExerciseByCategoryExtencions
{
    public static GetExerciseByCategoryResponse ToResponse(this Exercise exercise) =>
        new(
            exercise.Name,
            exercise.Description,
            exercise.DifficultyLevel,
            exercise.Category,
            exercise.Repetitions,
            exercise.DurationMinutes);

}