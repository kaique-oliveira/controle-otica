using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;
using System.Linq;

namespace Kvision.Frame.Servicos
{
    public class ServicoCaixa : IServicos<Caixa>
    {
        private readonly ICaixa _caixa;

        public ServicoCaixa(ICaixa caixa)
        {
            _caixa = caixa;
        }

        public string Cadastrar(Caixa caixa)
        {
            if (_caixa.Insert(caixa))
            {
                return "Caixa cadastrada com sucesso!";
            }

            return "Ops, algo deu errado";
        }

        public List<Caixa> ConsultarTodos()
        {
            var result = _caixa.FindAll().ToList<Caixa>();

            return result;
        }

        public string Deletar(Caixa caixa)
        {
            if (_caixa.Delete(caixa))
            {
                return "Caixa deletado com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

        public string Editar(Caixa caixa)
        {
            if(_caixa.Update(caixa))
                {
                return "Caixa editada com sucesso!";
            }

            return "Ops, algo deu errado";
        }
    }
}
