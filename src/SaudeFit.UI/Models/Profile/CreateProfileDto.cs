namespace SaudeFit.UI.Models.Profile;

public class CreateProfileDto
{
    public string Sexo { get; set; } = string.Empty;
    public int Idade { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
}