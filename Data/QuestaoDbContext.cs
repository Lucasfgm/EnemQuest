using Microsoft.EntityFrameworkCore;

namespace info_app.Data;

public class QuestaoDbContext : DbContext{
    #region Construtor

    public QuestaoDbContext(DbContextOptions<QuestaoDbContext> options): base (options){

    }
    #endregion

    #region Propriedades

    public DbSet<Questao> Questao {get; set; }
    #endregion

    #region Métodos privados

    private List<Questao> RetornaQuestoes()
    {
        return new List<Questao>{

            new Questao{
                Id = 1001,
                QuestaoTitulo ="O acúmulo de capitais, a modernização da agricultura, a disponibilidade de mão de obra e de recursos naturais e a força do puritanismo ajudam a explicar o pioneirismo da __________ na Revolução Industrial.Das opções abaixo listadas, o país que melhor preenche o espaço acima é:",
                Opcao1 = "a) Alemanha",
                Opcao2 = "b) Holanda",
                Opcao3 = "c) Itália",
                Opcao4 = "d) Inglaterra",
                Opcao5 = "e) Espanha",
                Resposta = "d) Inglaterra"
            },

            new Questao{
                Id=1002,
                QuestaoTitulo ="O novo processo de produção introduzido com a Revolução Industrial, no século XVIII, caracterizou-se pela:",
                Opcao1 = "a) implantação da indústria doméstica rural em substituição às oficinas.",
                Opcao2 = "b) realização da produção em grandes unidades fabris e intensa divisão do trabalho.",
                Opcao3 = "c) mecanização da produção agrícola e consequente fixação do homem à terra.",
                Opcao4 = "d) facilidade na compra de máquinas pelos artesãos que conseguiam financiamento para isso.",
                Opcao5 = "e) preocupação em aumentar a produção, respeitando-se o limite da força física do trabalhador.",
                Resposta = "b) realização da produção em grandes unidades fabris e intensa divisão do trabalho."
            },

            new Questao{
                Id=1003,
                QuestaoTitulo = "O século XIX foi um momento repleto de invenções em vários campos do saber. Dentre elas, podemos destacar:",
                Opcao1 = "a) O rádio, o telefone e a televisão",
                Opcao2 = "b) A locomotiva, o automóvel e a vacina",
                Opcao3 = "c) A fotografia, o cinema e a eletricidade",
                Opcao4 = "d) O para-raios, a calculadora e o telégrafo.",
                Opcao5 = "e) A televisão, o computador e o iphone", 
                Resposta = "c) A fotografia, o cinema e a eletricidade"
            }


        };


    }


    #endregion


}
