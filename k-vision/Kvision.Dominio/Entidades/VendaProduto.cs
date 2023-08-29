using Kvision.Dominio.Enums;


namespace Kvision.Dominio.Entidades
{
    public class VendaProduto
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual TiposPagamento TipoPagamento { get; set; }
        public virtual decimal Total { get; set; }
        public virtual string Produtos { get; set; }
        public virtual string Adicionais { get; set; }
        public virtual string? Observacao { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Receita Receita { get; set; }
    }
}
