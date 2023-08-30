using Kvision.Dominio.Enums;

namespace Kvision.Dominio.ViewModel
{
    public class VendaView
    {
        public int Id { get; set; }
        public  DateTime DataCadastro { get; set; }
        public  TiposPagamento TipoPagamento { get; set; }
        public decimal Valor { get; set; }
        public string TipoVenda { get; set; }

    }
}
