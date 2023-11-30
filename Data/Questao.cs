namespace info_app.Data;

public class Questao
{
        public int Id { get; set; }
        public string QuestaoTitulo {get; set;} = string.Empty;

        public IEnumerable<string> Opcoes {get; set;} = new List<string>();

        public string Resposta {get; set;} = string.Empty;

}