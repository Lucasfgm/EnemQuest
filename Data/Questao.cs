namespace info_app.Data;

public class Questao
{
        public int Id { get; set; }
        public string QuestaoTitulo {get; set;} = string.Empty;

        public string Opcao1 {get; set;} = string.Empty;

        public string Opcao2 {get; set;} = string.Empty;

        public string Opcao3 {get; set;} = string.Empty;

        public string Opcao4 {get; set;} = string.Empty;

        public string Opcao5 {get; set;} = string.Empty;

        public string Resposta {get; set;} = string.Empty;

}