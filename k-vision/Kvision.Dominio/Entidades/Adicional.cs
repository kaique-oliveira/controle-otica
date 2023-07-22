
namespace Kvision.Dominio.Entidades
{
    public class Adicional
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual string Descricao { get; set; }
        public virtual decimal Valor { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}

