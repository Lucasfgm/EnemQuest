using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnemQuest.Migrations
{
    /// <inheritdoc />
    public partial class segundomigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Questao",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Competencia",
                table: "Questao",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Dificuldade",
                table: "Questao",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Habilidade",
                table: "Questao",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Area", "Competencia", "Dificuldade", "Habilidade" },
                values: new object[] { "Ciências Humanas", 2, "Fácil", 6 });

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Area", "Competencia", "Dificuldade", "Habilidade" },
                values: new object[] { "Ciências Humanas", 5, "Médio", 10 });

            migrationBuilder.UpdateData(
                table: "Questao",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Area", "Competencia", "Dificuldade", "Habilidade" },
                values: new object[] { "Ciências Humanas", 7, "Difícil", 14 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Questao");

            migrationBuilder.DropColumn(
                name: "Competencia",
                table: "Questao");

            migrationBuilder.DropColumn(
                name: "Dificuldade",
                table: "Questao");

            migrationBuilder.DropColumn(
                name: "Habilidade",
                table: "Questao");
        }
    }
}
