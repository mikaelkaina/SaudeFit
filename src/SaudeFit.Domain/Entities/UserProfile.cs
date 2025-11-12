namespace SaudeFit.Domain.Entities;

public class UserProfile
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string Sexo { get; set; } = string.Empty;
    public int Idade { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double Imc { get; set; }
    public string Classificacao { get; set; } = string.Empty;
}