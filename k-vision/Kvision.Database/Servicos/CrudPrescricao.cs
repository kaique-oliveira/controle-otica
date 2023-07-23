using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudPrescricao : CrudBase<Prescricao>, IPrescricao
    {
        public CrudPrescricao(IConexao conexao) : base(conexao)
        {
        }
    }
}
