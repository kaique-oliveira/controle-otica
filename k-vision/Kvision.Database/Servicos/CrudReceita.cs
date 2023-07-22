using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudReceita : CrudBase<Receita>, IReceita
    {
        public CrudReceita(IConexao conexao) : base(conexao)
        {
        }
    }
}
