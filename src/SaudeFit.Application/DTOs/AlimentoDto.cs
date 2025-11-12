namespace SaudeFit.Application.DTOs;

public class AlimentoDto
{
    public string Nome { get; set; } = string.Empty;
    public string Refeicao { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public int Calorias { get; set; }
}