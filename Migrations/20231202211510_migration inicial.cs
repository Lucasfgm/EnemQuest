using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnemQuest.Migrations
{
    /// <inheritdoc />
    public partial class migrationinicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestaoTitulo = table.Column<string>(type: "TEXT", nullable: true),
                    Opcao1 = table.Column<string>(type: "TEXT", nullable: true),
                    Opcao2 = table.Column<string>(type: "TEXT", nullable: true),
                    Opcao3 = table.Column<string>(type: "TEXT", nullable: true),
                    Opcao4 = table.Column<string>(type: "TEXT", nullable: true),
                    Opcao5 = table.Column<string>(type: "TEXT", nullable: true),
                    Resposta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questao", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Questao",
                columns: new[] { "Id", "Opcao1", "Opcao2", "Opcao3", "Opcao4", "Opcao5", "QuestaoTitulo", "Resposta" },
                values: new object[,]
                {
                    { 1001, "a) Alemanha", "b) Holanda", "c) Itália", "d) Inglaterra", "e) Espanha", "O acúmulo de capitais, a modernização da agricultura, a disponibilidade de mão de obra e de recursos naturais e a força do puritanismo ajudam a explicar o pioneirismo da __________ na Revolução Industrial.Das opções abaixo listadas, o país que melhor preenche o espaço acima é:", "d) Inglaterra" },
                    { 1002, "a) implantação da indústria doméstica rural em substituição às oficinas.", "b) realização da produção em grandes unidades fabris e intensa divisão do trabalho.", "c) mecanização da produção agrícola e consequente fixação do homem à terra.", "d) facilidade na compra de máquinas pelos artesãos que conseguiam financiamento para isso.", "e) preocupação em aumentar a produção, respeitando-se o limite da força física do trabalhador.", "O novo processo de produção introduzido com a Revolução Industrial, no século XVIII, caracterizou-se pela:", "b) realização da produção em grandes unidades fabris e intensa divisão do trabalho." },
                    { 1003, "a) O rádio, o telefone e a televisão", "b) A locomotiva, o automóvel e a vacina", "c) A fotografia, o cinema e a eletricidade", "d) O para-raios, a calculadora e o telégrafo.", "e) A televisão, o computador e o iphone", "O século XIX foi um momento repleto de invenções em vários campos do saber. Dentre elas, podemos destacar:", "c) A fotografia, o cinema e a eletricidade" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questao");
        }
    }
}
