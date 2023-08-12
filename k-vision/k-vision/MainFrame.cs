using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Paginas.PgCliente;
using Kvision.Frame.Paginas.PgExames;
using Kvision.Frame.Paginas.PgProduto;
using Kvision.Frame.Paginas.PgVendas;
using Kvision.Frame.Servicos;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace k_vision
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
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
                indexlistaReceita = -1;
                dg_receitas.Rows[0].Cells[0].Selected = false;
                dg_receitas.Enabled = true;
                btn_gerenciar_receitas.Enabled = true;
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

        public void limparVendaToda() {
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

        }

        private void MainFrame_Shown(object sender, EventArgs e)
        {
            atualizarGridClientes();
            atualizarGridProduto();
            lbl_valor_total.Text = $"R$ 0,00";
        }

        private void btn_gerenciar_receitas_Click(object sender, EventArgs e)
        {
            if (indexlistaCliente > -1)
            {
                var mainExames = new MainReceita(_cliente, this);
                mainExames.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente da lista!", "Aten��o");
            }
        }

        private void btn_gerenciar_clientes_Click(object sender, EventArgs e)
        {
            var f_cliente = new MainCliente(this);
            f_cliente.ShowDialog();
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

      

        private void btn_gerenciar_produto_Click(object sender, EventArgs e)
        {
            var f_produto = new MainProduto(this);
            f_produto.ShowDialog();
        }

        private void btn_gerenciar_vendas_Click(object sender, EventArgs e)
        {
            var f_venda = new MainVenda(servicosVenda);
            f_venda.ShowDialog();
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
            else {
                MessageBox.Show("Preencha todos os campos!", "Aten��o");
            }
        }

        private void bnt_finalizar_venda_Click(object sender, EventArgs e)
        {
            _venda.TipoPagamento = TiposPagamento.Cart�o;
            _venda.Total = valorTotal;
            _venda.Cliente = _cliente;
            _venda.Receita = _receita;
            _venda.Produtos = JsonSerializer.Serialize<List<ItemProduto>>(listaItemProduto);
            _venda.Adicionais = JsonSerializer.Serialize<List<Adicional>>(listaAdicional);

            limparVendaToda();

            MessageBox.Show(servicosVenda.AjustarSaldo(_venda, servicosProduto), "Aten��o");

            atualizarGridProduto();
        }



        private void btn_add_produto_lista_Click(object sender, EventArgs e)
        {
            if (indexlistaProduto != -1)
            {
                _produto =  listaProdutos[indexlistaProduto];


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
            else {
                MessageBox.Show("Selecione um produto!", "Aten��o");
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


    }
}