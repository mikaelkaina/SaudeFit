namespace SaudeFit.Application.Features.Exercises.Queries.GetByCategory;

public record GetExerciseByCategoryResponse(
    string Name,
    string? Description,
    string DifficultyLevel,
    string Category,
    int Repetitions,
    int DurationMinutes);