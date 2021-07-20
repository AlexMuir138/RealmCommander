using System.Collections.Generic;

namespace RealmCommander.Repositories
{
  public interface IRepository
  {
  }
}namespace RealmCommander.Repositories
{
  public interface IRepository<T>
  {
    T Create(T t);
    T FindById(int id);
    List<T> Find();
    bool Delete(int id);
  }
}