using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaudeFit.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedExerciciosData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelDificuldade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Repeticoes = table.Column<int>(type: "int", nullable: false),
                    DuracaoMinutos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exercicios",
                columns: new[] { "Id", "Categoria", "Descricao", "DuracaoMinutos", "NivelDificuldade", "Nome", "Repeticoes" },
                values: new object[,]
                {
                    { 1, "Abaixo do peso", "Caminhada de 20 minutos para ganho de resistência", 20, "Leve", "Caminhada leve", 1 },
                    { 2, "Abaixo do peso", "Série de alongamentos diários", 15, "Leve", "Alongamento completo", 1 },
                    { 3, "Peso normal", "Corrida de 30 minutos", 30, "Moderado", "Corrida leve", 1 },
                    { 4, "Peso normal", "Série com agachamento, prancha e flexão", 25, "Moderado", "Treino funcional", 3 },
                    { 5, "Sobrepeso", "Cardio leve para queima de gordura", 25, "Moderado", "Bicicleta ergométrica", 1 },
                    { 6, "Sobrepeso", "Exercício controlado para pernas", 15, "Moderado", "Agachamento com apoio", 2 },
                    { 7, "Obesidade", "Exercício de baixo impacto", 20, "Leve", "Caminhada aquática", 1 },
                    { 8, "Obesidade", "Série para melhorar a capacidade pulmonar", 10, "Leve", "Exercícios respiratórios", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercicios");
        }
    }
}
