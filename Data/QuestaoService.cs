using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace info_app.Data;
public class QuestaoService
{

    #region Métodos privados

    private QuestaoDbContext dbContext;
    #endregion

    #region Construtor

    public QuestaoService(QuestaoDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion

    #region Métodos Publicos
     /// <summary>
    /// Retorna a lista de questoes
    /// </summary>
    /// <returns></returns>

    public async Task<List<Questao>> RetornaQuestaoAsync()
    {
        return await dbContext.Questao.ToListAsync();
    }

    /// <summary>
    /// Adiciona uma nova questao para DbContext e a salva
    /// </summary>
    /// <param name="quest"></param>
    /// <returns></returns>
    /// 

    public async Task<Questao> AddQuestaoAsync(Questao quest)
    {
        try
        {
            dbContext.Questao.Add(quest);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return quest;

    }
    /// <summary>
    /// Atualiza uma questao e salva as mudanças
    /// </summary>
    /// <param name="quest"></param>
    /// <returns></returns>
    
    public async Task<Questao> UpdateQuestaoAsync(Questao quest)
    {
        try
        {
            var questionExist = dbContext.Questao.FirstOrDefault(q => q.Id ==quest.Id);
            if(questionExist != null)
            {
                dbContext.Update(quest);
                await dbContext.SaveChangesAsync();
            }
        }
        catch(Exception)
            {
                throw;   
            }
        return quest;
    }
    /// <summary>
    /// Remove uma questao de DbContext e o salva
    /// </summary>
    /// <param name="questao"></param>
    /// <returns></returns>
    
    public async Task DeleteQuestionAsync(Questao questao)
    {
      try
        {
        dbContext.Questao.Remove(questao);
        await dbContext.SaveChangesAsync();
        }
       catch(Exception)
       {
        throw;
       }
    }
    #endregion
}