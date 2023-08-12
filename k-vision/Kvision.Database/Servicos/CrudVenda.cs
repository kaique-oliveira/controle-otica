using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudVenda : CrudBase<Venda>, IVenda
    {
        public CrudVenda(IConexao conexao) : base(conexao)
        {
        }
    }
}
