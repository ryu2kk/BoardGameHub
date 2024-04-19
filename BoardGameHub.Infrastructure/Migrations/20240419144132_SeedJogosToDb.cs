using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoardGameHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedJogosToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "db_Jogos",
                columns: new[] { "Id", "Additional", "Category", "Description", "ImageUrl", "Name", "PlayerNumber" },
                values: new object[,]
                {
                    { 1, "Variações de tabuleiro, cartas de desenvolvimento, recursos (madeira, trigo, lã, etc.)", "Estratégia", "Catan é um jogo de estratégia no qual os jogadores competem para construir colônias e expandir seu território em uma ilha fictícia.", "https://example.com/catan-image", "Catan", 3 },
                    { 2, "Varios modos, diferentes edições temáticas, cartas de sorte/azar.", "Clássico/Negócio", "Monopólio é um jogo clássico de negociação imobiliária no qual os jogadores compram, vendem e trocam propriedades para acumular riqueza e falir os seus adversários.", "https://example.com/monopoly-image", "Monopólio", 2 },
                    { 3, "Tabuleiros assimétricos, cartas de objetivos, miniaturas de unidades.", "Estratégia", "Scythe é um jogo de estratégia ambientado em uma realidade alternativa dos anos 1920, onde os jogadores controlam facções e competem pela supremacia em uma terra devastada pela guerra.", "https://example.com/scythe-image", "Scythe", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "db_Jogos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "db_Jogos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "db_Jogos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
