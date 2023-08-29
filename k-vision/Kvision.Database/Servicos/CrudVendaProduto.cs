using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudVendaProduto : CrudBase<VendaProduto>, IVendaProduto
    {
        public CrudVendaProduto(IConexao conexao) : base(conexao)
        {
        }
    }
}
