
using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Servicos
{
    public class ServicosReceita : IServicos<Receita>
    {
        private readonly IReceita _receita;

        public ServicosReceita(IReceita receita)
        {
            _receita = receita;
        }

        public string Cadastrar(Receita entidade)
        {
            throw new NotImplementedException();
        }

        public List<Receita> ConsultarTodos()
        {
            var result = _receita.FindAll().ToList<Receita>();

            return result;
        }

        public string Deletar(Receita entidade)
        {
            throw new NotImplementedException();
        }

        public string Editar(Receita entidade)
        {
            throw new NotImplementedException();
        }
    }
}
