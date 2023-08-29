using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;
using System.Linq;

namespace Kvision.Frame.Servicos
{
    public class ServicosVendaServico : IServicos<VendaServico>
    {
        private readonly IVendaServico _vendaServico;

        public ServicosVendaServico(IVendaServico vendaServico)
        {
            _vendaServico = vendaServico;
        }

        public string Cadastrar(VendaServico vendaServico)
        {
            if (_vendaServico.Insert(vendaServico))
            {
                return "Venda finalizada!";
            }

            return "Algo deu errado";
        }

        public List<VendaServico> ConsultarTodos()
        {
            var result = _vendaServico.FindAll().ToList<VendaServico>();

            return result;
        }

        public string Deletar(VendaServico vendaServico)
        {
            if (_vendaServico.Delete(vendaServico))
            {
                return "Venda deletada com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

        public string Editar(VendaServico vendaServico)
        {
            if (_vendaServico.Update(vendaServico))
            {
                return "Venda editada com sucesso!";
            }

            return "Ops, algo deu errado";
        }
    }
}
