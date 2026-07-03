using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaudeFit.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DifficultyLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Repetitions = table.Column<int>(type: "int", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Snack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Bmi = table.Column<double>(type: "float", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Description", "DifficultyLevel", "DurationMinutes", "Name", "Repetitions" },
                values: new object[,]
                {
                    { 1, "Abaixo do peso", "Caminhada de 20 minutos para ganho de resistência", "Leve", 20, "Caminhada leve", 1 },
                    { 2, "Abaixo do peso", "Série de alongamentos diários", "Leve", 15, "Alongamento completo", 1 },
                    { 3, "Peso normal", "Corrida de 30 minutos", "Moderado", 30, "Corrida leve", 1 },
                    { 4, "Peso normal", "Série com agachamento, prancha e flexão", "Moderado", 25, "Treino funcional", 3 },
                    { 5, "Sobrepeso", "Cardio leve para queima de gordura", "Moderado", 25, "Bicicleta ergométrica", 1 },
                    { 6, "Sobrepeso", "Exercício controlado para pernas", "Moderado", 15, "Agachamento com apoio", 2 },
                    { 7, "Obesidade", "Exercício de baixo impacto", "Leve", 20, "Caminhada aquática", 1 },
                    { 8, "Obesidade", "Série para melhorar a capacidade pulmonar", "Leve", 10, "Exercícios respiratórios", 1 },
                    { 9, "Abaixo do peso", "Exercícios focados em alinhamento corporal e equilíbrio", "Leve", 10, "Treino de postura", 2 },
                    { 10, "Abaixo do peso", "Sequência leve para fortalecimento e relaxamento", "Leve", 25, "Yoga básica", 1 },
                    { 11, "Peso normal", "Sequência de polichinelos, corrida no lugar e prancha curta", "Moderado", 20, "Circuito aeróbico", 2 },
                    { 12, "Peso normal", "Série alternada com elásticos e abdominais", "Moderado", 30, "Treino de resistência", 3 },
                    { 13, "Sobrepeso", "Exercício de esteira com leve inclinação para resistência", "Moderado", 20, "Caminhada inclinada", 1 },
                    { 14, "Sobrepeso", "Série para tonificar braços e costas", "Moderado", 15, "Treino leve com elástico", 2 },
                    { 15, "Obesidade", "Movimentos na água para estimular a circulação", "Leve", 25, "Hidroginástica leve", 1 },
                    { 16, "Obesidade", "Série simples para aumentar a mobilidade", "Leve", 15, "Alongamento sentado", 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Category", "Description", "Name", "Snack" },
                values: new object[,]
                {
                    { 1, 300, "Abaixo do peso", "Fonte de energia e fibras para ganho de peso saudável", "Vitamina de banana com aveia", "Café da manhã" },
                    { 2, 600, "Abaixo do peso", "Refeição completa e rica em proteínas e carboidratos", "Arroz, feijão e frango grelhado", "Almoço" },
                    { 3, 350, "Abaixo do peso", "Boa combinação de gorduras boas e proteínas", "Pão integral com pasta de amendoim", "Lanche da tarde" },
                    { 4, 400, "Abaixo do peso", "Refeição leve, rica em proteínas e nutrientes", "Omelete com legumes e arroz", "Jantar" },
                    { 5, 250, "Peso normal", "Mantém o equilíbrio entre proteínas e fibras", "Iogurte natural com frutas", "Café da manhã" },
                    { 6, 500, "Peso normal", "Refeição equilibrada para manutenção do peso", "Peito de frango com legumes e arroz integral", "Almoço" },
                    { 7, 200, "Peso normal", "Fonte de gorduras boas e energia natural", "Mix de castanhas e frutas secas", "Lanche da tarde" },
                    { 8, 300, "Peso normal", "Refeição leve e nutritiva para o fim do dia", "Sopa de legumes com carne magra", "Jantar" },
                    { 9, 220, "Sobrepeso", "Baixo teor de gordura e boa fonte de proteína", "Tapioca com ovo mexido", "Café da manhã" },
                    { 10, 400, "Sobrepeso", "Refeição balanceada e rica em ômega 3", "Peixe grelhado com salada e arroz integral", "Almoço" },
                    { 11, 150, "Sobrepeso", "Opção leve com fibras e proteínas", "Iogurte light com chia", "Lanche da tarde" },
                    { 12, 280, "Sobrepeso", "Refeição rica em nutrientes e de baixa caloria", "Frango desfiado com legumes refogados", "Jantar" },
                    { 13, 180, "Obesidade", "Mistura de frutas, couve e linhaça para desintoxicação", "Smoothie verde", "Café da manhã" },
                    { 14, 300, "Obesidade", "Baixo teor calórico e rico em nutrientes", "Filé de peixe com legumes no vapor", "Almoço" },
                    { 15, 160, "Obesidade", "Fonte leve de energia e fibras naturais", "Salada de frutas com aveia", "Lanche da tarde" },
                    { 16, 220, "Obesidade", "Jantar leve, nutritivo e de fácil digestão", "Sopa de abóbora com frango desfiado", "Jantar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
