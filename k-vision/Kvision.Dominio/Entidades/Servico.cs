
namespace Kvision.Dominio.Entidades
{
    public class Servico
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual string Nome { get; set; }
        public virtual decimal Valor { get; set; }
    }
}
