using FluentNHibernate.Data;
using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using NHibernate;

namespace Kvision.Database.Servicos
{
    public class CrudCliente : CrudBase<Cliente>, ICliente
    {
        public CrudCliente(IConexao conexao) : base(conexao)
        {
        }

    }
}
