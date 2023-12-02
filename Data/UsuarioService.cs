using Microsoft.EntityFrameworkCore;

namespace info_app.Data;
public class UsuarioService
{
    #region Métodos privados
    private UsuarioDbContext dbContext;
    #endregion

    #region Construtor
    public UsuarioService(UsuarioDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion

    #region Metodos Publicos 
    /// <summary>
    /// Retorna a lista de Usuarios
    /// </summary>
    /// <returns></returns>
    public async Task<List<Usuario>> RetornaUsuarioAsync()
    {
        return await dbContext.Usuario.ToListAsync();
    }

    /// <summary>
    /// Adiciona um novo Usuario para DbContext e o salva
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<Usuario> AddUsuarioAsync(Usuario user)
    {
        try
        {
            dbContext.Usuario.Add(user);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return user;
    }

    /// <summary>
    /// Atualiza um Usuario e salva as mudanças
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<Usuario> UpdateUsuarioAsync(Usuario user)
    {
        try
        {
            var usuarioExist = dbContext.Usuario.FirstOrDefault(p => p.Id == user.Id);
            if (usuarioExist != null)
            {
                dbContext.Update(user);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return user;
    }

    /// <summary>
    /// Remove um Usuario de DbContext e o salva
    /// </summary>
    /// <param name="usuario"></param>
    /// <returns></returns>
    public async Task DeleteUsuarioAsync(Usuario usuario)
    {
        try
        {
            dbContext.Usuario.Remove(usuario);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}