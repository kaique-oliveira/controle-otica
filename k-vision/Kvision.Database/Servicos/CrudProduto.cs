
using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudProduto : CrudBase<Produto>, IProduto
    {
        public CrudProduto(IConexao conexao) : base(conexao)
        {
        }
    }
}
