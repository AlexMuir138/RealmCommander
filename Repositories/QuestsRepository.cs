using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using RealmCommander.Models;

namespace RealmCommander.Repositories
{
  public class QuestsRepository : IRepository<Quest>
  {
    private readonly IDbConnection _db;

    public QuestsRepository(IDbConnection db)
    {
        _db = db;
    }
    public Quest Create(Quest quest)
    {
      int id = _db.ExecuteScalar<int>(@"
      INSERT INTO quests (title, description, completed)
      VALUES (@Title, @Description, @Completed);
      SELECT LAST_INSERT_ID();
      ", quest);
      quest.Id = id;
      return quest;
    }

    public bool Delete(int id)
    {
     int success = _db.Execute(@"
      DELETE FROM quests WHERE id = @id
      ", new { id });
      return success > 0;
    }

    public List<Quest> Find()
    {
     return _db.Query<Quest>("SELECT * FROM quests").ToList();
    }

    public Quest FindById(int id)
    {
     return _db.Query<Quest>("SELECT * FROM quests WHERE id = @id", new {id}).FirstOrDefault();
    }
  }
}