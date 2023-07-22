using System;

namespace Kvision.Dominio.Entidades
{
    public class ItemPedido
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }

    }
}
