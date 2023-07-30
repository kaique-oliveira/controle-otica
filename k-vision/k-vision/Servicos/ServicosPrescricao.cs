using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Servicos
{
    public class ServicosPrescricao : IServicos<Prescricao>
    {
        private readonly IPrescricao _prescricao;

        public ServicosPrescricao(IPrescricao prescricao)
        {
            _prescricao = prescricao;
        }

        public string Cadastrar(Prescricao prescricao)
        {

            if (_prescricao.Insert(prescricao))
            {
                return "Receita cadastrada com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

        public List<Prescricao> ConsultarTodos()
        {
            var result = _prescricao.FindAll().ToList<Prescricao>();

            return result;
        }

        public List<Prescricao> ConsultarOne( int idReceita)
        {
            var result = _prescricao.FindAll().Where(p => p.Receita.Id == idReceita).ToList<Prescricao>();

            return result;
        }

        public string Deletar(Prescricao precricao)
        {
            if (_prescricao.Delete(precricao))
            {
                return "Prescricão deletada com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

        public string Editar(Prescricao prescricao)
        {
            if (_prescricao.Update(prescricao))
            {
                return "Receita cadastrada com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

    }
}
