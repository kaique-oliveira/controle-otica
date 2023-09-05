using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Servicos
{
    public class ServicoMovimentacao : IServicos<Movimentacao>
    {
        private readonly IMovimentacao _movimentacao;
        ServicoCaixa _servicoCaixa = new ServicoCaixa(new CrudCaixa(new ConexaoDatabase()));

        public ServicoMovimentacao(IMovimentacao movimentacao)
        {
            _movimentacao = movimentacao;
        }

        public string Cadastrar(Movimentacao movimentacao)
        {
            if (_movimentacao.Insert(movimentacao))
            {
                var caixa = _servicoCaixa.ConsultarTodos().First<Caixa>();

                if (movimentacao.Tipo == Dominio.Enums.TipoMovimentacao.Entrada)
                {
                    caixa.Valor += movimentacao.Valor;
                }
                else
                {
                    caixa.Valor -= movimentacao.Valor;
                }

                _servicoCaixa.Editar(caixa);

                return "Movimentação cadastrada com sucesso!";
            }

            return "";
        }

        public List<Movimentacao> ConsultarTodos()
        {
            var result = _movimentacao.FindAll().ToList<Movimentacao>();

            return result;
        }

        public string Deletar(Movimentacao movimentacao)
        {
            var caixa = _servicoCaixa.ConsultarTodos().First<Caixa>();

            if (_movimentacao.Delete(movimentacao))
            {
                caixa.Valor -= movimentacao.Valor;
                _servicoCaixa.Editar(caixa);

                return "Movimentação deletada com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

        public string Editar(Movimentacao movimentacao)
        {
            var mov = _movimentacao.FindAll().Where(m => m.Id == movimentacao.Id).First<Movimentacao>();

            if (_movimentacao.Update(movimentacao))
            {
                var caixa = _servicoCaixa.ConsultarTodos().First<Caixa>();

                if(mov.Tipo == Dominio.Enums.TipoMovimentacao.Entrada)
                {
                    caixa.Valor -= mov.Valor;

                    if (movimentacao.Tipo == Dominio.Enums.TipoMovimentacao.Entrada)
                    {
                        caixa.Valor += movimentacao.Valor;
                    }
                    else
                    {
                        caixa.Valor -= movimentacao.Valor;
                    }
                }
                else
                {
                    caixa.Valor += mov.Valor;

                    if (movimentacao.Tipo == Dominio.Enums.TipoMovimentacao.Entrada)
                    {
                        caixa.Valor += movimentacao.Valor;
                    }
                    else
                    {
                        caixa.Valor -= movimentacao.Valor;
                    }
                }

                _servicoCaixa.Editar(caixa);
                return "Movimentação editada com sucesso!";
            }

            return "";
        }
    }
}
