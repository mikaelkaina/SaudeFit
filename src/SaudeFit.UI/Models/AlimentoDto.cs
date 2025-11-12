namespace SaudeFit.UI.Models;

public class AlimentoDto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public string? Categoria { get; set; }
    public string? Refeicao { get; set; } // Café da manhã, Almoço, etc.
    public int Calorias { get; set; }
}
