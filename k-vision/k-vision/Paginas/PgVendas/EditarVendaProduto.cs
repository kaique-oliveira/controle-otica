using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Paginas.PgVendaProduto;
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
        private Receita _receita_selecionada;




        public void confirmarSelecaoReceita(Receita receita)
        {
            _receita_selecionada = new Receita();
            _receita_selecionada = receita;

            lblClienteVenda.Text = receita.Cliente.Nome;
            lblReceitaVenda.Text = $"{receita.NomeExaminador} -  data: {receita.DataCadastro.ToShortDateString()} | val: {receita.DataValExame.ToShortDateString()}";
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

            txt_total_produto.Text = $"R$ {_vendaProduto.Total}";
            txt_observacao_produto.Text = _vendaProduto.Observacao;

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainVenda.Opacity = 100;
            this.Close();
        }
    }
}
