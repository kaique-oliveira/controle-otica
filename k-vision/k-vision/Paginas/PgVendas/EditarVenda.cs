using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Servicos;
using System.Text.Json;

namespace Kvision.Frame.Paginas.PgVendas
{
    public partial class EditarVenda : Form
    {
        private readonly MainVenda _mainVenda;
        private Venda _vendaParaEditar;
        public EditarVenda(MainVenda mainVenda, Venda venda)
        {
            _mainVenda = mainVenda;
            _vendaParaEditar = venda;
            InitializeComponent();
            _mainVenda = mainVenda;
        }

        ServicosCliente servicosCliente = new ServicosCliente(new CrudCliente(new ConexaoDatabase()));
        ServicosReceita servicosReceita = new ServicosReceita(new CrudReceita(new ConexaoDatabase()));
        ServicosProduto servicosProduto = new ServicosProduto(new CrudProduto(new ConexaoDatabase()));
        ServicosVenda servicosVenda = new ServicosVenda(new CrudVenda(new ConexaoDatabase()));

        List<Cliente> listaClientes = new List<Cliente>();
        List<Receita> listaReceitas = new List<Receita>();
        List<Produto> listaProdutos = new List<Produto>();
        List<Adicional> listaAdicional = new List<Adicional>();
        List<ItemProduto> listaItemProduto = new List<ItemProduto>();

        private int indexlistaCliente = -1, indexlistaReceita = -1, indexlistaProduto = -1;

        Cliente _cliente = new Cliente();
        Produto _produto = new Produto();
        Receita _receita = new Receita();
        Adicional _adiconal = new Adicional();
        Venda _venda = new Venda();

        private decimal valorTotal = 0;


        public void atualizarGridReceitas()
        {
            dg_receitas.AutoGenerateColumns = false;
            listaReceitas = servicosReceita.ConsultarTodos().FindAll(r => r.Cliente.Id == _cliente.Id);

            if (listaReceitas.Count > 0)
            {
                dg_receitas.DataSource = listaReceitas;

                dg_receitas.ClearSelection();
                dg_receitas.Enabled = true;
                indexlistaReceita = -1;
            }
            else
            {
                dg_receitas.DataSource = null;
            }
        }
        public void atualizarGridProduto()
        {
            indexlistaProduto = -1;
            dg_produtos.AutoGenerateColumns = false;
            listaProdutos = servicosProduto.ConsultarTodos().OrderBy(p => p.Nome).ToList();

            if (listaProdutos.Count > 0)
            {
                dg_produtos.DataSource = listaProdutos;
                dg_produtos.Rows[0].Cells[0].Selected = false;
            }
        }
        public void atualizarGridClientes()
        {
            indexlistaCliente = -1;
            dg_clientes.AutoGenerateColumns = false;
            listaClientes = servicosCliente.ConsultarTodos().OrderBy(c => c.Nome).ToList();

            if (listaClientes.Count > 0)
            {
                dg_clientes.DataSource = listaClientes;
                dg_clientes.Rows[0].Cells[0].Selected = false;
            }
        }

        public void limparVendaToda()
        {
            listViewProdutos.Items.Clear();
            listaItemProduto.Clear();
            listaAdicional.Clear();
            valorTotal = 0;
            lbl_valor_total.Text = $"R$ 0,00";
            lblClienteVenda.Text = "";
            lblReceita_selecionada.Text = "";
            dg_clientes.ClearSelection();
            dg_receitas.ClearSelection();
            dg_receitas.DataSource = null;
            cbo_tipo_pagamento.SelectedIndex = -1;
            indexlistaCliente = -1;
            indexlistaReceita = -1;
            indexlistaProduto = -1;
        }

        private void EditarVenda_Shown(object sender, EventArgs e)
        {
            atualizarGridClientes();
            atualizarGridProduto();

            cbo_tipo_pagamento.Items.Add(TiposPagamento.Cartão);
            cbo_tipo_pagamento.Items.Add(TiposPagamento.Dinheiro);
            cbo_tipo_pagamento.Items.Add(TiposPagamento.Pix);

            _cliente = _vendaParaEditar.Cliente;
            _receita = _vendaParaEditar.Receita;
            _venda = _vendaParaEditar;

            lbl_valor_total.Text = _vendaParaEditar.Total.ToString();
            valorTotal = _vendaParaEditar.Total;
            lblClienteVenda.Text = _vendaParaEditar.Cliente.Nome;
            lblReceita_selecionada.Text = $"{_vendaParaEditar.Receita.DataCadastro.ToShortDateString()} - {_vendaParaEditar.Receita.NomeExaminador}";


            switch (_vendaParaEditar.TipoPagamento.ToString())
            {
                case "Cartão":
                    cbo_tipo_pagamento.SelectedIndex = 0;
                    break;
                case "Dinheiro":
                    cbo_tipo_pagamento.SelectedIndex = 1;
                    break;
                case "Pix":
                    cbo_tipo_pagamento.SelectedIndex = 2;
                    break;
            }


            var produtos = JsonSerializer.Deserialize<List<Produto>>(_vendaParaEditar.Produtos);
            
            foreach (var item in produtos)
            {
                ListViewItem itemList = new ListViewItem($"{item.Quantidade} - {item.Nome}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewProdutos.Items.Add(itemList);
                listaItemProduto.Add(new ItemProduto() { Id = item.Id, Nome = item.Nome, Quantidade = item.Quantidade, Valor = item.Valor});
            }

            var adicionais = JsonSerializer.Deserialize<List<Adicional>>(_vendaParaEditar.Adicionais);
            foreach (var item in adicionais)
            {
                ListViewItem itemList = new ListViewItem($"1 - {item.Descricao}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewProdutos.Items.Add(itemList);
            }

        }



        private void txt_filtro_cliente_TextChanged(object sender, EventArgs e)
        {
            dg_clientes.DataSource = listaClientes.FindAll(x => x.Nome.ToUpperInvariant().Contains(txt_filtro_cliente.Text.ToUpperInvariant())
               || x.Telefone.Contains(txt_filtro_cliente.Text));
            indexlistaCliente = -1;
        }

        private void txt_filtro_produto_TextChanged(object sender, EventArgs e)
        {
            dg_produtos.DataSource = listaProdutos.FindAll(p => p.Nome.ToUpperInvariant().Contains(txt_filtro_produto.Text.ToUpperInvariant()));
        }



        private void dg_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlistaCliente = dg_clientes.CurrentCell.RowIndex;
            _cliente = listaClientes[indexlistaCliente];
            lblClienteVenda.Text = $"{_cliente.Nome}";
            atualizarGridReceitas();
        }

        private void dg_receitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlistaReceita = dg_receitas.CurrentCell.RowIndex;
            _receita = listaReceitas[indexlistaReceita];
            lblReceita_selecionada.Text = $"{_receita.DataCadastro.ToShortDateString()} - {_receita.NomeExaminador}";
        }

        private void dg_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlistaProduto = dg_produtos.CurrentCell.RowIndex;
        }



        private void btn_add_adicional_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_descricao_adiconal.Text) && !string.IsNullOrEmpty(txt_valor_adicional.Text))
            {
                ListViewItem itemList = new ListViewItem($"1 - {txt_descricao_adiconal.Text}");
                itemList.SubItems.Add($"R$ {decimal.Parse(txt_valor_adicional.Text.Replace(".", ","))}");
                listViewProdutos.Items.Add(itemList);

                _adiconal.Descricao = txt_descricao_adiconal.Text;
                _adiconal.Valor = decimal.Parse(txt_valor_adicional.Text.Replace(".", ","));

                listaAdicional.Add(_adiconal);


                valorTotal += decimal.Parse(txt_valor_adicional.Text.Replace(".", ","));
                lbl_valor_total.Text = $"R$ {valorTotal}";

                txt_descricao_adiconal.Clear();
                txt_valor_adicional.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção");
            }
        }


        private void btn_add_produto_lista_Click(object sender, EventArgs e)
        {
            if (indexlistaProduto != -1)
            {
                _produto = listaProdutos[indexlistaProduto];


                if (listaItemProduto.Count != 0 && listaItemProduto.Where(p => p.Id == _produto.Id).Count() != 0)
                {
                    listaItemProduto.Find(p => p.Id == _produto.Id).Quantidade += 1;
                    listaItemProduto.Find(p => p.Id == _produto.Id).Valor += _produto.Valor;
                }
                else
                {
                    ItemProduto _itemProduto = new ItemProduto();
                    _itemProduto.Id = _produto.Id;
                    _itemProduto.Nome = _produto.Nome;
                    _itemProduto.Valor = _produto.Valor;
                    _itemProduto.Quantidade = 1;

                    listaItemProduto.Add(_itemProduto);
                }


                listViewProdutos.Items.Clear();

                foreach (var item in listaItemProduto)
                {
                    ListViewItem itemList = new ListViewItem($"{item.Quantidade} - {item.Nome}");
                    itemList.SubItems.Add($"R$ {item.Valor}");

                    listViewProdutos.Items.Add(itemList);
                }

                if (listaAdicional.Count > 0)
                {
                    foreach (var item in listaAdicional)
                    {
                        ListViewItem itemList = new ListViewItem($"1 - {item.Descricao}");
                        itemList.SubItems.Add($"R$ {item.Valor}");

                        listViewProdutos.Items.Add(itemList);
                    }
                }

                valorTotal += _produto.Valor;
                lbl_valor_total.Text = $"R$ {valorTotal}";

                dg_produtos.ClearSelection();
            }
            else
            {
                MessageBox.Show("Selecione um produto!", "Atenção");
            }
        }

        private void btn_limpar_produtos_Click(object sender, EventArgs e)
        {
            listViewProdutos.Items.Clear();
            listaItemProduto.Clear();
            listaAdicional.Clear();
            valorTotal = 0;
            lbl_valor_total.Text = $"R$ 0,00";
        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            switch (cbo_tipo_pagamento.SelectedItem.ToString())
            {
                case "Cartão":
                    _venda.TipoPagamento = TiposPagamento.Cartão;
                    break;
                case "Dinheiro":
                    _venda.TipoPagamento = TiposPagamento.Dinheiro;
                    break;
                case "Pix":
                    _venda.TipoPagamento = TiposPagamento.Pix;
                    break;
            }

            _venda.Total = valorTotal;
            _venda.Cliente = _cliente;
            _venda.Receita = _receita;
            _venda.Produtos = JsonSerializer.Serialize<List<ItemProduto>>(listaItemProduto);
            _venda.Adicionais = JsonSerializer.Serialize<List<Adicional>>(listaAdicional);

            servicosVenda.Editar(_venda);

            _mainVenda.atualizarGridVendas();

            _mainVenda.Show();
            this.Close();
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainVenda.Show();
            this.Close();
        }
    }
}
