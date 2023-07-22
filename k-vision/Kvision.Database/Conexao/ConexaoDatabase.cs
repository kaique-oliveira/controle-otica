using Kvision.Database.Interfaces;
using NHibernate;
using NHibernate.Cfg;

namespace Kvision.Database.Conexao
{
    public class ConexaoDatabase : IConexao
    {
        private static ISessionFactory sessao;

        public ISessionFactory CriarSessao()
        {
            if (sessao != null)
            {
                return sessao;
            }

            Configuration cfg = new Configuration()
             .AddAssembly("Kvision.Dominio");
            sessao = cfg.BuildSessionFactory();


            return sessao;

        }

        public ISession Abrir()
        {
            return CriarSessao().OpenSession();
        }
    }
}
