using System.Collections.Generic;
using RealmCommander.Models;
using RealmCommander.Repositories;

namespace RealmCommander.Services
{

  public class QuestsService
  {
    private readonly QuestsRepository _repo;

    public QuestsService(QuestsRepository repo)
    {
      _repo = repo;
    }
     public Quest Create(Quest quest)
    {
      //business rule
      //user == role admin
      // allow the quest.completed
      return _repo.Create(quest);
    }

    public bool Delete(int id)
    {
      return _repo.Delete(id);
    }

    public Quest FindById(int id){
      return _repo.FindById(id);
    }

    public List<Quest> Find(){
      return _repo.Find();
    }
  }
}
