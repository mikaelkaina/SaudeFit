using SaudeFit.Domain.Entities;

namespace SaudeFit.Application.Features.Exercises.Shared;

public static class ExerciseExtensions
{
    public static ExerciseResponse ToResponse(this Exercise exercise) =>
        new(
            exercise.Name,
            exercise.Description,
            exercise.DifficultyLevel,
            exercise.Category,
            exercise.Repetitions,
            exercise.DurationMinutes
        );
}