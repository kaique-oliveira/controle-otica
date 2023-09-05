
using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudCaixa : CrudBase<Caixa>, ICaixa
    {
        public CrudCaixa(IConexao conexao) : base(conexao)
        {
        }
    }
}
