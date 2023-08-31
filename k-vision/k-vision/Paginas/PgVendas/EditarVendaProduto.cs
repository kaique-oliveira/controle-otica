using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Paginas.PgVendaProduto;
using Kvision.Frame.Servicos;
using System.Text.Json;


namespace Kvision.Frame.Paginas.PgVendas
{
    public partial class EditarVendaProduto : Form
    {

        private TelaBlur _telaBlur;
        private VendaProduto _vendaProduto;
        private MainVenda _mainVenda;
        public EditarVendaProduto(MainVenda mainVenda, TelaBlur telaBlur, VendaProduto vendaProduto)
        {
            _telaBlur = telaBlur;
            InitializeComponent();
            _vendaProduto = vendaProduto;
            _mainVenda = mainVenda;
        }


        List<ItemProduto> listaProdutos = new List<ItemProduto>();
        List<Adicional> listaAdicional = new List<Adicional>();

        private TiposPagamento tipoPagamento_produto;
        private Receita _receita_selecionada = new Receita();

        ServicosVendaProduto servicosVendaPoduto = new ServicosVendaProduto(new CrudVendaProduto(new ConexaoDatabase()));
        ServicosProduto servicosPoduto = new ServicosProduto(new CrudProduto(new ConexaoDatabase()));

        private decimal valorTotal = 0;

        public void confirmarSelecaoReceita(Receita receita)
        {
            _receita_selecionada = receita;

            lblClienteVenda.Text = receita.Cliente.Nome;
            lblReceitaVenda.Text = $"{receita.NomeExaminador} -  data: {receita.DataCadastro.ToShortDateString()} | val: {receita.DataValExame.ToShortDateString()}";
        }
        public void confirmarSelecaoProduto(Produto _produto)
        {
            if (listaProdutos.Count != 0 && listaProdutos.Where(p => p.Id == _produto.Id).Count() != 0)
            {
                listaProdutos.Find(p => p.Id == _produto.Id).Quantidade += 1;
                listaProdutos.Find(p => p.Id == _produto.Id).Valor += _produto.Valor;
            }
            else
            {
                ItemProduto _itemProduto = new ItemProduto();
                _itemProduto.Id = _produto.Id;
                _itemProduto.Nome = _produto.Nome;
                _itemProduto.Valor = _produto.Valor;
                _itemProduto.Quantidade = 1;

                listaProdutos.Add(_itemProduto);
            }

            listViewProdutos.Items.Clear();

            foreach (var item in listaProdutos)
            {
                ListViewItem itemList = new ListViewItem($"{item.Quantidade} - {item.Nome}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewProdutos.Items.Add(itemList);
            }

            valorTotal += _produto.Valor;
            txt_total_produto.Text = $"R$ {valorTotal}";
            btn_salvar_edicao.Enabled = true;
        }
        public void confirmarAdicional(Adicional adicional)
        {
            listaAdicional.Add(adicional);
            valorTotal += adicional.Valor;
            txt_total_produto.Text = $"R$ {valorTotal}";

            listViewAdicionais.Items.Clear();
            foreach (var item in listaAdicional)
            {
                ListViewItem itemList = new ListViewItem($"1 - {item.Descricao}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewAdicionais.Items.Add(itemList);
            }
        }

        public void limparVendaProduto()
        {
            valorTotal = 0;
            listaProdutos.Clear();
            listaAdicional.Clear();

            listViewProdutos.Items.Clear();
            listViewAdicionais.Items.Clear();
            txt_observacao_produto.Text = "";

            rb_dinheiro_produto.Checked = false;
            rb_pix_produto.Checked = false;
            rb_debito_produto.Checked = false;
            rb_credito_produto.Checked = false;

            lblClienteVenda.Text = "Nome do cliente";
            lblReceitaVenda.Text = "Receita do cliente";
            txt_total_produto.Text = $"R$ 0,00";
        }


        private void btn_show_select_cliente_Click(object sender, EventArgs e)
        {
            var selectCliente = new SelecionarCliente(null, this, _telaBlur);
            selectCliente.ShowDialog();
        }

        private void rb_dinheiro_produto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_produto = TiposPagamento.Dinheiro;
                painel_produtos.Visible = true;
            }
        }

        private void rb_pix_produto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_produto = TiposPagamento.Pix;
                painel_produtos.Visible = true;
            }
        }

        private void rb_debito_produto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_produto = TiposPagamento.Debito;
                painel_produtos.Visible = true;
            }
        }

        private void rb_credito_produto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_produto = TiposPagamento.Credito;
                painel_produtos.Visible = true;
            }
        }

        private void EditarVendaProduto_Shown(object sender, EventArgs e)
        {
            listaProdutos = JsonSerializer.Deserialize<List<ItemProduto>>(_vendaProduto.Produtos);
            listaAdicional = JsonSerializer.Deserialize<List<Adicional>>(_vendaProduto.Adicionais);

            if (listaProdutos != null)
            {
                foreach (var item in listaProdutos)
                {
                    ListViewItem itemList = new ListViewItem($"{item.Quantidade} - {item.Nome}");
                    itemList.SubItems.Add($"R$ {item.Valor}");

                    listViewProdutos.Items.Add(itemList);
                }
            }

            if (listaAdicional != null)
            {
                foreach (var item in listaAdicional)
                {
                    ListViewItem itemList = new ListViewItem($"1 - {item.Descricao}");
                    itemList.SubItems.Add($"R$ {item.Valor}");

                    listViewAdicionais.Items.Add(itemList);
                }
            }

            lblClienteVenda.Text = _vendaProduto.Cliente.Nome;
            lblReceitaVenda.Text = $"{_vendaProduto.Receita.NomeExaminador} -  data: {_vendaProduto.Receita.DataCadastro.ToShortDateString()} | val: {_vendaProduto.Receita.DataValExame.ToShortDateString()}";

            switch (_vendaProduto.TipoPagamento.ToString())
            {
                case "Dinheiro":
                    rb_dinheiro_produto.Checked = true;
                    break;
                case "Pix":
                    rb_pix_produto.Checked = true;
                    break;
                case "Debito":
                    rb_debito_produto.Checked = true;
                    break;
                case "Credito":
                    rb_credito_produto.Checked = true;
                    break;
            }

            valorTotal = _vendaProduto.Total;
            txt_total_produto.Text = $"R$ {_vendaProduto.Total}";
            txt_observacao_produto.Text = _vendaProduto.Observacao;
            _receita_selecionada = _vendaProduto.Receita;

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainVenda.Opacity = 100;
            this.Close();
        }

        private void btn_salvar_edicao_Click(object sender, EventArgs e)
        {
            var newVenda = new VendaProduto()
            {
                Id = _vendaProduto.Id,
                Receita = _receita_selecionada,
                Cliente = _receita_selecionada.Cliente,
                Produtos = JsonSerializer.Serialize<List<ItemProduto>>(listaProdutos),
                Adicionais = JsonSerializer.Serialize<List<Adicional>>(listaAdicional),
                TipoPagamento = tipoPagamento_produto,
                Observacao = txt_observacao_produto.Text,
                Total = valorTotal
            };


            string response = servicosVendaPoduto.AjustarSaldoEditado(_vendaProduto, newVenda, servicosPoduto);

            if (response == "Venda editada com sucesso!")
            {
                var result = MessageBox.Show($"Edição da venda concluída!", "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    _mainVenda.atualizarGridVendas();
                    _mainVenda.Opacity = 100;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Algo deu errado", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btn_show_select_produto_Click(object sender, EventArgs e)
        {
            var sp = new SelecionarProduto(null, this, _telaBlur);
            this.Opacity = 0;
            sp.ShowDialog();
        }

        private void btn_show_add_adicional_Click(object sender, EventArgs e)
        {
            var a = new AddAdicional(null, this, _telaBlur);
            this.Opacity = 0;
            a.ShowDialog();
        }



        private void btn_apagar_produto_Click(object sender, EventArgs e)
        {

            listViewProdutos.Items.Clear();
            btn_salvar_edicao.Enabled = false;

            foreach (var item in listaProdutos)
            {
                valorTotal -= item.Valor;
            }

            listaProdutos.Clear();
            txt_total_produto.Text = $"R$ {valorTotal}";
        }

        private void btn_apagar_adicionais_Click(object sender, EventArgs e)
        {
            foreach (var item in listaAdicional)
            {
                valorTotal -= item.Valor;
            }
            listViewAdicionais.Items.Clear();
            listaAdicional.Clear();
            txt_total_produto.Text = $"R$ {valorTotal}";
        }
    }
}
