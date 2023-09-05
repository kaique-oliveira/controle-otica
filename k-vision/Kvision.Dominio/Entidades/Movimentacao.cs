using Kvision.Dominio.Enums;


namespace Kvision.Dominio.Entidades
{
    public class Movimentacao
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual string Descricao { get; set; }
        public virtual TipoMovimentacao Tipo { get; set; }
        public virtual int? IdVenda { get; set; }
        public virtual decimal Valor { get; set; }
    }
}
