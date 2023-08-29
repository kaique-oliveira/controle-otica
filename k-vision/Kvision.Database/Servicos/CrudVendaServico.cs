using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudVendaServico : CrudBase<VendaServico>, IVendaServico
    {
        public CrudVendaServico(IConexao conexao) : base(conexao)
        {
        }
    }
}
