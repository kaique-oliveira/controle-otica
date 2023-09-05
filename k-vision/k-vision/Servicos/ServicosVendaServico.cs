using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Servicos
{
    public class ServicosVendaServico : IServicos<VendaServico>
    {
        private readonly IVendaServico _vendaServico;
        ServicoMovimentacao _servicoMovimentacao = new ServicoMovimentacao(new CrudMovimentacao(new ConexaoDatabase()));

        public ServicosVendaServico(IVendaServico vendaServico)
        {
            _vendaServico = vendaServico;
        }

        public string Cadastrar(VendaServico vendaServico)
        {
            if (_vendaServico.Insert(vendaServico))
            {
                var v = _vendaServico.FindAll().Last();

                var movimentacao = new Movimentacao()
                {
                    Id = 0,
                    Descricao = "Venda de serviço",
                    IdVenda = v.Id,
                    Tipo = Dominio.Enums.TipoMovimentacao.Entrada,
                    Valor = v.Total
                };

                var response = _servicoMovimentacao.Cadastrar(movimentacao);
                if (response != "")
                {
                    return "Venda finalizada!";
                }
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
                Movimentacao mov = _servicoMovimentacao.ConsultarTodos().Where(m => m.IdVenda == vendaServico.Id).First();
                _servicoMovimentacao.Deletar(mov);
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
                Movimentacao mov = _servicoMovimentacao.ConsultarTodos().Where(m => m.IdVenda == vendaServico.Id).First();
                mov.Valor = vendaServico.Total;
                _servicoMovimentacao.Editar(mov);
                return "Venda editada com sucesso!";
            }

            return "";
        }
    }
}
