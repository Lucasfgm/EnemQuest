namespace info_app.Data;

public class Questao
{
        public int Id { get; set; }
        
        public string? QuestaoTitulo {get; set;}

        public string? Opcao1 {get; set;} 

        public string? Opcao2 {get; set;} 

        public string? Opcao3 {get; set;} 

        public string? Opcao4 {get; set;} 

        public string? Opcao5 {get; set;}

        public string? Resposta {get; set;} 

        public string? Area {get; set;}

        public string? Dificuldade {get; set;}

        public int Competencia {get; set;}

        public int Habilidade {get; set;}

}