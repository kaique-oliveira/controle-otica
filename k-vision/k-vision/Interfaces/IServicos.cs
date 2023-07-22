
namespace Kvision.Frame.Interfaces
{
    public interface IServicos<T>
    {
        string Cadastrar(T entidade);
        string Editar(T entidade);
        string Deletar (T entidade);
        List<T> ConsultarTodos();
    }
}
