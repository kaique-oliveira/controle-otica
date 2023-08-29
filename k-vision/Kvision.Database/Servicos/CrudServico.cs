using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudServico : CrudBase<Servico>, IServico
    {
        public CrudServico(IConexao conexao) : base(conexao)
        {
        }
    }
}
