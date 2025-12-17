using SaudeFit.Domain.Exceptions;

namespace SaudeFit.Domain.Entities;

public class UserProfile
{
    public Guid Id { get; private set; }
    public string UserId { get; private set; } = string.Empty;
    public string Sexo { get; private set; } = string.Empty;
    public int Idade { get; private set; }
    public double Peso { get; private set; }
    public double Altura { get; private set; }
    public double Imc { get; private set; }
    public string Classificacao { get; private set; } = string.Empty;

    private UserProfile() { } // EF Core

    public UserProfile(string userId, string sexo, int idade, double peso, double altura)
    {
        Id = Guid.NewGuid();
        UserId = userId;

        AtualizarDados(sexo, idade, peso, altura);
    }

    public void AtualizarDados(string sexo, int idade, double peso, double altura)
    {
        if (peso <= 0)
            throw new DomainException("Peso deve ser maior que zero");

        if (altura <= 0)
            throw new DomainException("Altura deve ser maior que zero");

        Sexo = sexo;
        Idade = idade;
        Peso = peso;
        Altura = altura;

        CalcularImc();
    }

    private void CalcularImc()
    {
        Imc = Math.Round(Peso / (Altura * Altura), 2);
        Classificacao = ClassificarImc(Imc);
    }

    private static string ClassificarImc(double imc)
    {
        return imc switch
        {
            < 18.5 => "Abaixo do peso",
            < 25 => "Peso normal",
            < 30 => "Sobrepeso",
            _ => "Obesidade"
        };
    }
}