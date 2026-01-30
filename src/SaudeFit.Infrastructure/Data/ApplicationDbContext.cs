using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaudeFit.Domain.Entities;

namespace SaudeFit.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;

    public DbSet<UserProfile> UserProfiles { get; set; } = null!;

    public DbSet<Exercicio> Exercicios { get; set; } = default!;

    public DbSet<Alimento> Alimentos { get; set; }


   /* protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Exercicio>().HasData(
            // Abaixo do peso
            new Exercicio { Id = 1, Nome = "Caminhada leve", Descricao = "Caminhada de 20 minutos para ganho de resistência", NivelDificuldade = "Leve", Categoria = "Abaixo do peso", Repeticoes = 1, DuracaoMinutos = 20 },
            new Exercicio { Id = 2, Nome = "Alongamento completo", Descricao = "Série de alongamentos diários", NivelDificuldade = "Leve", Categoria = "Abaixo do peso", Repeticoes = 1, DuracaoMinutos = 15 },
            new Exercicio { Id = 9, Nome = "Treino de postura", Descricao = "Exercícios focados em alinhamento corporal e equilíbrio", NivelDificuldade = "Leve", Categoria = "Abaixo do peso", Repeticoes = 2, DuracaoMinutos = 10 },
            new Exercicio { Id = 10, Nome = "Yoga básica", Descricao = "Sequência leve para fortalecimento e relaxamento", NivelDificuldade = "Leve", Categoria = "Abaixo do peso", Repeticoes = 1, DuracaoMinutos = 25 },

            // Peso normal
            new Exercicio { Id = 3, Nome = "Corrida leve", Descricao = "Corrida de 30 minutos", NivelDificuldade = "Moderado", Categoria = "Peso normal", Repeticoes = 1, DuracaoMinutos = 30 },
            new Exercicio { Id = 4, Nome = "Treino funcional", Descricao = "Série com agachamento, prancha e flexão", NivelDificuldade = "Moderado", Categoria = "Peso normal", Repeticoes = 3, DuracaoMinutos = 25 },
            new Exercicio { Id = 11, Nome = "Circuito aeróbico", Descricao = "Sequência de polichinelos, corrida no lugar e prancha curta", NivelDificuldade = "Moderado", Categoria = "Peso normal", Repeticoes = 2, DuracaoMinutos = 20 },
            new Exercicio { Id = 12, Nome = "Treino de resistência", Descricao = "Série alternada com elásticos e abdominais", NivelDificuldade = "Moderado", Categoria = "Peso normal", Repeticoes = 3, DuracaoMinutos = 30 },

            // Sobrepeso
            new Exercicio { Id = 5, Nome = "Bicicleta ergométrica", Descricao = "Cardio leve para queima de gordura", NivelDificuldade = "Moderado", Categoria = "Sobrepeso", Repeticoes = 1, DuracaoMinutos = 25 },
            new Exercicio { Id = 6, Nome = "Agachamento com apoio", Descricao = "Exercício controlado para pernas", NivelDificuldade = "Moderado", Categoria = "Sobrepeso", Repeticoes = 2, DuracaoMinutos = 15 },
            new Exercicio { Id = 13, Nome = "Caminhada inclinada", Descricao = "Exercício de esteira com leve inclinação para resistência", NivelDificuldade = "Moderado", Categoria = "Sobrepeso", Repeticoes = 1, DuracaoMinutos = 20 },
            new Exercicio { Id = 14, Nome = "Treino leve com elástico", Descricao = "Série para tonificar braços e costas", NivelDificuldade = "Moderado", Categoria = "Sobrepeso", Repeticoes = 2, DuracaoMinutos = 15 },

            // Obesidade
            new Exercicio { Id = 7, Nome = "Caminhada aquática", Descricao = "Exercício de baixo impacto", NivelDificuldade = "Leve", Categoria = "Obesidade", Repeticoes = 1, DuracaoMinutos = 20 },
            new Exercicio { Id = 8, Nome = "Exercícios respiratórios", Descricao = "Série para melhorar a capacidade pulmonar", NivelDificuldade = "Leve", Categoria = "Obesidade", Repeticoes = 1, DuracaoMinutos = 10 },
            new Exercicio { Id = 15, Nome = "Hidroginástica leve", Descricao = "Movimentos na água para estimular a circulação", NivelDificuldade = "Leve", Categoria = "Obesidade", Repeticoes = 1, DuracaoMinutos = 25 },
            new Exercicio { Id = 16, Nome = "Alongamento sentado", Descricao = "Série simples para aumentar a mobilidade", NivelDificuldade = "Leve", Categoria = "Obesidade", Repeticoes = 1, DuracaoMinutos = 15 }
        );

        modelBuilder.Entity<Alimento>().HasData(
        //  Abaixo do peso
        new Alimento { Id = 1, Nome = "Vitamina de banana com aveia", Refeicao = "Café da manhã", Descricao = "Fonte de energia e fibras para ganho de peso saudável", Categoria = "Abaixo do peso", Calorias = 300 },
        new Alimento { Id = 2, Nome = "Arroz, feijão e frango grelhado", Refeicao = "Almoço", Descricao = "Refeição completa e rica em proteínas e carboidratos", Categoria = "Abaixo do peso", Calorias = 600 },
        new Alimento { Id = 3, Nome = "Pão integral com pasta de amendoim", Refeicao = "Lanche da tarde", Descricao = "Boa combinação de gorduras boas e proteínas", Categoria = "Abaixo do peso", Calorias = 350 },
        new Alimento { Id = 4, Nome = "Omelete com legumes e arroz", Refeicao = "Jantar", Descricao = "Refeição leve, rica em proteínas e nutrientes", Categoria = "Abaixo do peso", Calorias = 400 },

        //  Peso normal
        new Alimento { Id = 5, Nome = "Iogurte natural com frutas", Refeicao = "Café da manhã", Descricao = "Mantém o equilíbrio entre proteínas e fibras", Categoria = "Peso normal", Calorias = 250 },
        new Alimento { Id = 6, Nome = "Peito de frango com legumes e arroz integral", Refeicao = "Almoço", Descricao = "Refeição equilibrada para manutenção do peso", Categoria = "Peso normal", Calorias = 500 },
        new Alimento { Id = 7, Nome = "Mix de castanhas e frutas secas", Refeicao = "Lanche da tarde", Descricao = "Fonte de gorduras boas e energia natural", Categoria = "Peso normal", Calorias = 200 },
        new Alimento { Id = 8, Nome = "Sopa de legumes com carne magra", Refeicao = "Jantar", Descricao = "Refeição leve e nutritiva para o fim do dia", Categoria = "Peso normal", Calorias = 300 },

        //  Sobrepeso
        new Alimento { Id = 9, Nome = "Tapioca com ovo mexido", Refeicao = "Café da manhã", Descricao = "Baixo teor de gordura e boa fonte de proteína", Categoria = "Sobrepeso", Calorias = 220 },
        new Alimento { Id = 10, Nome = "Peixe grelhado com salada e arroz integral", Refeicao = "Almoço", Descricao = "Refeição balanceada e rica em ômega 3", Categoria = "Sobrepeso", Calorias = 400 },
        new Alimento { Id = 11, Nome = "Iogurte light com chia", Refeicao = "Lanche da tarde", Descricao = "Opção leve com fibras e proteínas", Categoria = "Sobrepeso", Calorias = 150 },
        new Alimento { Id = 12, Nome = "Frango desfiado com legumes refogados", Refeicao = "Jantar", Descricao = "Refeição rica em nutrientes e de baixa caloria", Categoria = "Sobrepeso", Calorias = 280 },

        //  Obesidade
        new Alimento { Id = 13, Nome = "Smoothie verde", Refeicao = "Café da manhã", Descricao = "Mistura de frutas, couve e linhaça para desintoxicação", Categoria = "Obesidade", Calorias = 180 },
        new Alimento { Id = 14, Nome = "Filé de peixe com legumes no vapor", Refeicao = "Almoço", Descricao = "Baixo teor calórico e rico em nutrientes", Categoria = "Obesidade", Calorias = 300 },
        new Alimento { Id = 15, Nome = "Salada de frutas com aveia", Refeicao = "Lanche da tarde", Descricao = "Fonte leve de energia e fibras naturais", Categoria = "Obesidade", Calorias = 160 },
        new Alimento { Id = 16, Nome = "Sopa de abóbora com frango desfiado", Refeicao = "Jantar", Descricao = "Jantar leve, nutritivo e de fácil digestão", Categoria = "Obesidade", Calorias = 220 }
        );
    } */
}

