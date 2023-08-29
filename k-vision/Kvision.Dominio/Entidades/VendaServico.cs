using Kvision.Dominio.Enums;

namespace Kvision.Dominio.Entidades
{
    public class VendaServico
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual TiposPagamento TipoPagamento { get; set; }
        public virtual decimal Total { get; set; }
        public virtual string? Observacao { get; set; }
        public virtual string Servicos { get; set; }
    }
}
