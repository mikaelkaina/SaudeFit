using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaudeFit.Domain.Entities;
using SaudeFit.Infrastructure.Identity;

namespace SaudeFit.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;

    public DbSet<UserProfile> UserProfiles { get; set; } = null!;

    public DbSet<Exercise> Exercises { get; set; } = default!;

    public DbSet<Food> Foods { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        modelBuilder.Entity<Exercise>().HasData(

            // Abaixo do peso
            new Exercise
            {
                Id = 1, Name = "Caminhada leve", Description = "Caminhada de 20 minutos para ganho de resistência",
                DifficultyLevel = "Leve", Category = "Abaixo do peso", Repetitions = 1, DurationMinutes = 20
            },
            new Exercise
            {
                Id = 2, Name = "Alongamento completo", Description = "Série de alongamentos diários",
                DifficultyLevel = "Leve", Category = "Abaixo do peso", Repetitions = 1, DurationMinutes = 15
            },
            new Exercise
            {
                Id = 9, Name = "Treino de postura",
                Description = "Exercícios focados em alinhamento corporal e equilíbrio", DifficultyLevel = "Leve",
                Category = "Abaixo do peso", Repetitions = 2, DurationMinutes = 10
            },
            new Exercise
            {
                Id = 10, Name = "Yoga básica", Description = "Sequência leve para fortalecimento e relaxamento",
                DifficultyLevel = "Leve", Category = "Abaixo do peso", Repetitions = 1, DurationMinutes = 25
            },

            // Peso normal
            new Exercise
            {
                Id = 3, Name = "Corrida leve", Description = "Corrida de 30 minutos", DifficultyLevel = "Moderado",
                Category = "Peso normal", Repetitions = 1, DurationMinutes = 30
            },
            new Exercise
            {
                Id = 4, Name = "Treino funcional", Description = "Série com agachamento, prancha e flexão",
                DifficultyLevel = "Moderado", Category = "Peso normal", Repetitions = 3, DurationMinutes = 25
            },
            new Exercise
            {
                Id = 11, Name = "Circuito aeróbico",
                Description = "Sequência de polichinelos, corrida no lugar e prancha curta",
                DifficultyLevel = "Moderado", Category = "Peso normal", Repetitions = 2, DurationMinutes = 20
            },
            new Exercise
            {
                Id = 12, Name = "Treino de resistência", Description = "Série alternada com elásticos e abdominais",
                DifficultyLevel = "Moderado", Category = "Peso normal", Repetitions = 3, DurationMinutes = 30
            },

            // Sobrepeso
            new Exercise
            {
                Id = 5, Name = "Bicicleta ergométrica", Description = "Cardio leve para queima de gordura",
                DifficultyLevel = "Moderado", Category = "Sobrepeso", Repetitions = 1, DurationMinutes = 25
            },
            new Exercise
            {
                Id = 6, Name = "Agachamento com apoio", Description = "Exercício controlado para pernas",
                DifficultyLevel = "Moderado", Category = "Sobrepeso", Repetitions = 2, DurationMinutes = 15
            },
            new Exercise
            {
                Id = 13, Name = "Caminhada inclinada",
                Description = "Exercício de esteira com leve inclinação para resistência", DifficultyLevel = "Moderado",
                Category = "Sobrepeso", Repetitions = 1, DurationMinutes = 20
            },
            new Exercise
            {
                Id = 14, Name = "Treino leve com elástico", Description = "Série para tonificar braços e costas",
                DifficultyLevel = "Moderado", Category = "Sobrepeso", Repetitions = 2, DurationMinutes = 15
            },

            // Obesidade
            new Exercise
            {
                Id = 7, Name = "Caminhada aquática", Description = "Exercício de baixo impacto",
                DifficultyLevel = "Leve", Category = "Obesidade", Repetitions = 1, DurationMinutes = 20
            },
            new Exercise
            {
                Id = 8, Name = "Exercícios respiratórios", Description = "Série para melhorar a capacidade pulmonar",
                DifficultyLevel = "Leve", Category = "Obesidade", Repetitions = 1, DurationMinutes = 10
            },
            new Exercise
            {
                Id = 15, Name = "Hidroginástica leve", Description = "Movimentos na água para estimular a circulação",
                DifficultyLevel = "Leve", Category = "Obesidade", Repetitions = 1, DurationMinutes = 25
            },
            new Exercise
            {
                Id = 16, Name = "Alongamento sentado", Description = "Série simples para aumentar a mobilidade",
                DifficultyLevel = "Leve", Category = "Obesidade", Repetitions = 1, DurationMinutes = 15
            }
        );

        modelBuilder.Entity<Food>().HasData(

            // Abaixo do peso
            new Food
            {
                Id = 1, Name = "Vitamina de banana com aveia", Snack = "Café da manhã",
                Description = "Fonte de energia e fibras para ganho de peso saudável", Category = "Abaixo do peso",
                Calories = 300
            },
            new Food
            {
                Id = 2, Name = "Arroz, feijão e frango grelhado", Snack = "Almoço",
                Description = "Refeição completa e rica em proteínas e carboidratos", Category = "Abaixo do peso",
                Calories = 600
            },
            new Food
            {
                Id = 3, Name = "Pão integral com pasta de amendoim", Snack = "Lanche da tarde",
                Description = "Boa combinação de gorduras boas e proteínas", Category = "Abaixo do peso", Calories = 350
            },
            new Food
            {
                Id = 4, Name = "Omelete com legumes e arroz", Snack = "Jantar",
                Description = "Refeição leve, rica em proteínas e nutrientes", Category = "Abaixo do peso",
                Calories = 400
            },

            // Peso normal
            new Food
            {
                Id = 5, Name = "Iogurte natural com frutas", Snack = "Café da manhã",
                Description = "Mantém o equilíbrio entre proteínas e fibras", Category = "Peso normal", Calories = 250
            },
            new Food
            {
                Id = 6, Name = "Peito de frango com legumes e arroz integral", Snack = "Almoço",
                Description = "Refeição equilibrada para manutenção do peso", Category = "Peso normal", Calories = 500
            },
            new Food
            {
                Id = 7, Name = "Mix de castanhas e frutas secas", Snack = "Lanche da tarde",
                Description = "Fonte de gorduras boas e energia natural", Category = "Peso normal", Calories = 200
            },
            new Food
            {
                Id = 8, Name = "Sopa de legumes com carne magra", Snack = "Jantar",
                Description = "Refeição leve e nutritiva para o fim do dia", Category = "Peso normal", Calories = 300
            },

            // Sobrepeso
            new Food
            {
                Id = 9, Name = "Tapioca com ovo mexido", Snack = "Café da manhã",
                Description = "Baixo teor de gordura e boa fonte de proteína", Category = "Sobrepeso", Calories = 220
            },
            new Food
            {
                Id = 10, Name = "Peixe grelhado com salada e arroz integral", Snack = "Almoço",
                Description = "Refeição balanceada e rica em ômega 3", Category = "Sobrepeso", Calories = 400
            },
            new Food
            {
                Id = 11, Name = "Iogurte light com chia", Snack = "Lanche da tarde",
                Description = "Opção leve com fibras e proteínas", Category = "Sobrepeso", Calories = 150
            },
            new Food
            {
                Id = 12, Name = "Frango desfiado com legumes refogados", Snack = "Jantar",
                Description = "Refeição rica em nutrientes e de baixa caloria", Category = "Sobrepeso", Calories = 280
            },

            // Obesidade
            new Food
            {
                Id = 13, Name = "Smoothie verde", Snack = "Café da manhã",
                Description = "Mistura de frutas, couve e linhaça para desintoxicação", Category = "Obesidade",
                Calories = 180
            },
            new Food
            {
                Id = 14, Name = "Filé de peixe com legumes no vapor", Snack = "Almoço",
                Description = "Baixo teor calórico e rico em nutrientes", Category = "Obesidade", Calories = 300
            },
            new Food
            {
                Id = 15, Name = "Salada de frutas com aveia", Snack = "Lanche da tarde",
                Description = "Fonte leve de energia e fibras naturais", Category = "Obesidade", Calories = 160
            },
            new Food
            {
                Id = 16, Name = "Sopa de abóbora com frango desfiado", Snack = "Jantar",
                Description = "Jantar leve, nutritivo e de fácil digestão", Category = "Obesidade", Calories = 220
            }
        );
    }
}


