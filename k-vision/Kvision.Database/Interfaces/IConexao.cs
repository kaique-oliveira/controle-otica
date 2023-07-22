using NHibernate;

namespace Kvision.Database.Interfaces
{
    public interface IConexao
    {
        ISessionFactory CriarSessao();
        ISession Abrir();
    }
}
