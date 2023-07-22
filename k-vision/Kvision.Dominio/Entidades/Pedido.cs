using Kvision.Dominio.Enums;
using System;

namespace Kvision.Dominio.Entidades
{
    public class Pedido
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual TiposPagamento TipoPagamento { get; set; }
        public virtual decimal Total { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Receita Receita { get; set; }
    }
}
