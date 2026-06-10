namespace SaudeFit.Application.Features.Exercises.Queries.GetAll;

public static class GetAllExerciseExtensions
{
    public static GetAllExerciseResponse ToResponse(this Domain.Entities.Exercise exercise) =>
        new(
            exercise.Name,
            exercise.Description,
            exercise.DifficultyLevel,
            exercise.Category,
            exercise.Repetitions,
            exercise.DurationMinutes
        );
}