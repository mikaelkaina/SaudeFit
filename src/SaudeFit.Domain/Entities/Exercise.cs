namespace SaudeFit.Domain.Entities;

public class Exercise
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string DifficultyLevel { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Repetitions { get; set; }
    public int DurationMinutes { get; set; }
}