using Microsoft.EntityFrameworkCore;

namespace info_app.Data;

public class UsuarioDbContext : DbContext{
    #region Construtor
    public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options): base(options){

    }
    #endregion

    #region Propriedades
    public DbSet<Usuario> Usuario { get; set; }
    #endregion

    #region Métodos sobrecarregados
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Usuario>().HasData(RetornaUsuario());
        base.OnModelCreating(modelBuilder);
    }
    #endregion


    #region Métodos privados
    private List<Usuario> RetornaUsuario(){
        return new List<Usuario>{
        new Usuario { Id = 1, Nome = "Vanessa", Apelido = "Nessa", Email = "nessa@mail.com", Senha ="12345678", Status = false},
        new Usuario { Id = 2, Nome = "Jose Junior", Apelido = "Jose", Email = "josejunior@mail.com", Senha ="12345678", Status = true}
    };
    }
    #endregion
}