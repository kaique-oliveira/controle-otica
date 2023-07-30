using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;
using System.Linq;

namespace Kvision.Frame.Servicos
{
    public class ServicosProduto : IServicos<Produto>
    {

        private readonly IProduto _produto;

        public ServicosProduto(IProduto produto)
        {
            _produto = produto;
        }

        public string Cadastrar(Produto produto)
        {
            string resultValidacao = ValidarCampos(produto);

            if (resultValidacao == "")
            {
                if (_produto.Insert(produto))
                {
                    return "Produto cadastro com sucesso!";
                }

                return "Ops, algo deu errado";
            }

            return resultValidacao;
        }

        public List<Produto> ConsultarTodos()
        {
            var result = _produto.FindAll().ToList<Produto>();

            return result;
        }

        public string Deletar(Produto entidade)
        {
            throw new NotImplementedException();
        }

        public string Editar(Produto produto)
        {
            string resultValidacao = ValidarCampos(produto);

            if (resultValidacao == "")
            {
                if (_produto.Update(produto))
                {
                    return "Produto editado com sucesso!";
                }

                return "Ops, algo deu errado";
            }

            return resultValidacao;
        }

        private string ValidarCampos(Produto produto)
        {
            if (string.IsNullOrEmpty(produto.Nome) 
                || string.IsNullOrEmpty(produto.Quantidade.ToString()) 
                || string.IsNullOrEmpty(produto.Valor.ToString()))
            {
                return "Preencha todos os campos!";
            }

            return "";
        }
    }
}
