
using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Servicos
{
    public class ServicosServico : IServicos<Servico>
    {
        private readonly IServico _servico;

        public ServicosServico(IServico servico)
        {
            _servico = servico;
        }

        public string Cadastrar(Servico servico)
        {
            if (_servico.Insert(servico))
            {
                return "Servico cadastrado com sucesso!";
            }

            return "";
        }

        public List<Servico> ConsultarTodos()
        {
            var result = _servico.FindAll().ToList<Servico>();

            return result;
        }

        public string Deletar(Servico servico)
        {
            if (_servico.Delete(servico))
            {
                return "Serviço deletado com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

        public string Editar(Servico servico)
        {
            if (_servico.Update(servico))
            {
                return "Serviço editado com sucesso!";
            }

            return "Ops, algo deu errado";
        }
    }
}
