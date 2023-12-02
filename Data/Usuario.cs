namespace info_app.Data;

public class Usuario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Apelido { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public bool Status { get; set; } // true se for professor, false se for aluno
}
