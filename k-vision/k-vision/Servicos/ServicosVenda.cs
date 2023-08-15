using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Interfaces;
using System.Linq;
using System.Text.Json;

namespace Kvision.Frame.Servicos
{
    public class ServicosVenda : IServicos<Venda>
    {

        private readonly IVenda _venda;

        public ServicosVenda(IVenda venda)
        {
            _venda = venda;
        }

        public string Cadastrar(Venda venda)
        {
            if (_venda.Insert(venda))
            {
                return "Venda finalizada!";
            }

            return "Ops, algo deu errado";
        }

        public string AjustarSaldo(Venda venda, ServicosProduto servicoProduto) {

            var itemProdutos = JsonSerializer.Deserialize<List<ItemProduto>>(venda.Produtos);
            var produtos = servicoProduto.ConsultarTodos();

            foreach (var item in itemProdutos)
            {

                var _produto = produtos.Find(p => p.Id == item.Id);
                
                if(_produto.Quantidade != 0 && _produto.Quantidade > 0)
                {
                    _produto.Quantidade = _produto.Quantidade > item.Quantidade ? _produto.Quantidade - item.Quantidade : 0;
                }

                servicoProduto.Editar(_produto);
                
            }

            return Cadastrar(venda);
        }

        public List<Venda> ConsultarTodos()
        {
            var result = _venda.FindAll().ToList<Venda>();

            return result;
        }

        public string Deletar(Venda entidade)
        {
            throw new NotImplementedException();
        }

        public string Editar(Venda venda)
        {
            if (_venda.Update(venda))
            {
                return "Venda editada com sucesso!";
            }

            return "Ops, algo deu errado";
        }
    }
}
