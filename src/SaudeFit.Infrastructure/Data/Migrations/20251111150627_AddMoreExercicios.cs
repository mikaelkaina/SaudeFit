using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaudeFit.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreExercicios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercicios",
                columns: new[] { "Id", "Categoria", "Descricao", "DuracaoMinutos", "NivelDificuldade", "Nome", "Repeticoes" },
                values: new object[,]
                {
                    { 9, "Abaixo do peso", "Exercícios focados em alinhamento corporal e equilíbrio", 10, "Leve", "Treino de postura", 2 },
                    { 10, "Abaixo do peso", "Sequência leve para fortalecimento e relaxamento", 25, "Leve", "Yoga básica", 1 },
                    { 11, "Peso normal", "Sequência de polichinelos, corrida no lugar e prancha curta", 20, "Moderado", "Circuito aeróbico", 2 },
                    { 12, "Peso normal", "Série alternada com elásticos e abdominais", 30, "Moderado", "Treino de resistência", 3 },
                    { 13, "Sobrepeso", "Exercício de esteira com leve inclinação para resistência", 20, "Moderado", "Caminhada inclinada", 1 },
                    { 14, "Sobrepeso", "Série para tonificar braços e costas", 15, "Moderado", "Treino leve com elástico", 2 },
                    { 15, "Obesidade", "Movimentos na água para estimular a circulação", 25, "Leve", "Hidroginástica leve", 1 },
                    { 16, "Obesidade", "Série simples para aumentar a mobilidade", 15, "Leve", "Alongamento sentado", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercicios",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
