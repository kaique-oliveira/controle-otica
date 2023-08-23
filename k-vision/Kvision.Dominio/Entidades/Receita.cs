namespace Kvision.Dominio.Entidades
{
    public class Receita
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual DateTime DataExame { get; set; }
        public virtual DateTime DataValExame { get; set; }
        public virtual string NomeExaminador { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual PrescricaoAdicional PrescricaoAdicional { get; set; }

    }
}

