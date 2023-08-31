using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Interfaces;
using System.Text.Json;

namespace Kvision.Frame.Servicos
{
    public class ServicosVendaProduto : IServicos<VendaProduto>
    {

        private readonly IVendaProduto _venda;

        public ServicosVendaProduto(IVendaProduto venda)
        {
            _venda = venda;
        }

        public string Cadastrar(VendaProduto venda)
        {
            if (_venda.Insert(venda))
            {
                return "Venda finalizada!";
            }

            return "Algo deu errado";
        }

        public string AjustarSaldo(VendaProduto venda, ServicosProduto servicoProduto) {

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

        public string AjustarSaldoEditado(VendaProduto venda, VendaProduto newVenda, ServicosProduto servicoProduto)
        {
            var itemProdutos = JsonSerializer.Deserialize<List<ItemProduto>>(venda.Produtos);
            var newItemProdustos = JsonSerializer.Deserialize<List<ItemProduto>>(newVenda.Produtos);
            var produtos = servicoProduto.ConsultarTodos();


            foreach (var item in itemProdutos)
            {
                var _produto = produtos.Find(p => p.Id == item.Id);

                if (_produto.Quantidade != 0 && _produto.Quantidade > 0)
                {
                    _produto.Quantidade = _produto.Quantidade > item.Quantidade ? _produto.Quantidade + item.Quantidade : 0;
                }

                servicoProduto.Editar(_produto);
            }

            foreach (var item in newItemProdustos)
            {
                var _produto = produtos.Find(p => p.Id == item.Id);

                if (_produto.Quantidade != 0 && _produto.Quantidade > 0)
                {
                    _produto.Quantidade = _produto.Quantidade > item.Quantidade ? _produto.Quantidade - item.Quantidade : 0;
                }

                servicoProduto.Editar(_produto);
            }


            return Editar(newVenda);
        }
        public List<VendaProduto> ConsultarTodos()
        {
            var result = _venda.FindAll().ToList<VendaProduto>();

            return result;
        }

        public string Deletar(VendaProduto venda)
        {
            if (_venda.Delete(venda))
            {
                return "Venda deletada com sucesso!";
            }
            else
            {
                return "Ops, algo deu errado";
            }
        }

        public string Editar(VendaProduto venda)
        {
            if (_venda.Update(venda))
            {
                return "Venda editada com sucesso!";
            }

            return "Ops, algo deu errado";
        }
    }
}
