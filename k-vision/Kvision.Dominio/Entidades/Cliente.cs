
using System.Runtime.ConstrainedExecution;

namespace Kvision.Dominio.Entidades
{
    public class Cliente
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual string Nome { get; set; }
        public virtual string Telefone { get; set; }

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
    }
}
