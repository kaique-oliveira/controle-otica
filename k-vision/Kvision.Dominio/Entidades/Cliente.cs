
namespace Kvision.Dominio.Entidades
{
    public class Cliente
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual string Nome { get; set; }
        public virtual string Telefone { get; set; }
    }
}
