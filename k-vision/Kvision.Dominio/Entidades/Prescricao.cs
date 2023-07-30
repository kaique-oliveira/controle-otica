using Kvision.Dominio.Enums;
using System;

namespace Kvision.Dominio.Entidades
{
    public class Prescricao
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual TiposPrescricao Tipo { get; set; }
        public virtual string? EsfericoDireito { get; set; }
        public virtual string? CilindricoDireito { get; set; }
        public virtual string? EixoDireito { get; set; }
        public virtual string? DPDireito { get; set; }
        public virtual string? EsfericoEsquerdo { get; set; }
        public virtual string? CilindricoEsquerdo { get; set; }
        public virtual string? EixoEsquerdo { get; set; }
        public virtual string? DPEsquerdo { get; set; }
        public virtual Receita Receita { get; set; }
    }
}
