

using Kvision.Dominio.Enums;

namespace Kvision.Dominio.ViewModel
{
    public class VendaView
    {
        public virtual DateTime DataCadastro { get; set; }
        public virtual string Nome { get; set; }
        public virtual TiposPagamento TipoPagamento { get; set; }
    }
}
