using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudMovimentacao : CrudBase<Movimentacao>, IMovimentacao
    {
        public CrudMovimentacao(IConexao conexao) : base(conexao)
        {
        }
    }
}
