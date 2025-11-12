using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaudeFit.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAlimentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refeicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Alimentos",
                columns: new[] { "Id", "Calorias", "Categoria", "Descricao", "Nome", "Refeicao" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alimentos");
        }
    }
}
