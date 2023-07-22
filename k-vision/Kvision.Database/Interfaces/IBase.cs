
namespace Kvision.Database.Interfaces
{
    public interface IBase<T>
    {
        bool Insert(T entidade);
        bool Update(T entidade);
        bool Delete(T entidade);
        T FindOne(int id);
        IList<T> FindAll();
    }
}
