namespace DataAccess;

public interface IEntityRepository<T>
{
    T GetById(int id);
    List<T> GetAll();
    T Create(T entity);
    T Update(T entity);
    T Delete(int id);
}