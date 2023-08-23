
using Kvision.Dominio.Enums;

namespace Kvision.Dominio.Entidades
{
    public class PrescricaoAdicional
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual string AdicaoDireito { get; set; }
        public virtual string AlturaDireito { get; set; }

        public virtual string AdicaoEsquerdo { get; set; }
        public virtual string AlturaEsquerdo { get; set; }
       
    }
}
