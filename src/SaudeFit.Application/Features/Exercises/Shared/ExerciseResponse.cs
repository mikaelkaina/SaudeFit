namespace SaudeFit.Application.Features.Exercises.Shared;

public record ExerciseResponse(
    string Name,
    string? Description,
    string DifficultyLevel,
    string Category,
    int Repetitions,
    int DurationMinutes);