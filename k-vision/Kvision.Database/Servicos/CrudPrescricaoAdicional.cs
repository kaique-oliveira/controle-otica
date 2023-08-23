using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;

namespace Kvision.Database.Servicos
{
    public class CrudPrescricaoAdicional : CrudBase<PrescricaoAdicional>, IPrescricaoAdicional
    {
        public CrudPrescricaoAdicional(IConexao conexao) : base(conexao)
        {
        }
    }
}
