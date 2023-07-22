using Kvision.Dominio.Enums;
using System;

namespace Kvision.Dominio.Entidades
{
    public class Prescricao
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual TiposPrescricao Tipo { get; set; }
        public virtual int EsfericoDireito { get; set; }
        public virtual decimal CilindricoDireito { get; set; }
        public virtual decimal EixoDireito { get; set; }
        public virtual decimal DPDireito { get; set; }
        public virtual int EsfericoEsquerdo { get; set; }
        public virtual decimal CilindricoEsquerdo { get; set; }
        public virtual decimal EixoEsquerdo { get; set; }
        public virtual decimal DPEsquerdo { get; set; }
        public virtual Receita Receita { get; set; }
    }
}
