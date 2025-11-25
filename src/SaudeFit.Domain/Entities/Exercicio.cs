namespace SaudeFit.Domain.Entities;

public class Exercicio
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string? Descricao { get; set; }
    public string NivelDificuldade { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public int Repeticoes { get; set; }
    public int DuracaoMinutos { get; set; }
}