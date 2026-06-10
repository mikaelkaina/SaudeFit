namespace SaudeFit.Application.Features.Exercises.Queries.GetAll;

public record GetAllExerciseResponse(
    string Name,
    string? Description,
    string DifficultyLevel,
    string Category,
    int Repetitions,
    int DurationMinutes);