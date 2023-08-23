using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Interfaces;

namespace Kvision.Frame.Paginas.PgProduto
{
    public partial class PersistirProduto : Form
    {


        private readonly TiposOperacoes _tiposOperacoes;
        private readonly IServicos<Produto> _servicos;
        private Produto _produto;
        private readonly MainProduto _mainProduto;

        public PersistirProduto(TiposOperacoes tiposOperacoes, IServicos<Produto> servicos, Produto? produto, MainProduto mainProduto)
        {
            _tiposOperacoes = tiposOperacoes;
            _servicos = servicos;
            _produto = produto ?? new Produto();
            _mainProduto = mainProduto;
            InitializeComponent();
        }


        public void limparCampos()
        {
            txt_nome.Text = "";
            txt_quantidade.Text = "";
            txt_valor.Text = "";
        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            _produto.Nome = txt_nome.Text;
            _produto.Quantidade = int.Parse(txt_quantidade.Text);
            _produto.Valor = decimal.Parse(txt_valor.Text.Replace(".", ","));


            if (_tiposOperacoes == TiposOperacoes.Cadastrar)
            {
                var result = MessageBox.Show($"{_servicos.Cadastrar(_produto)}", "Antenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    _mainProduto.atualizarGrid();
                    limparCampos();
                    _mainProduto.indexlista = -1;
                    this.Close();
                }
            }

            else
            {
                var result = MessageBox.Show($"{_servicos.Editar(_produto)}", "Antenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    _mainProduto.atualizarGrid();
                    limparCampos();
                    _mainProduto.indexlista = -1;
                    this.Close();
                }
            }

            _mainProduto.Show();
            this.Hide();

        }


        private void PersistirProduto_Load(object sender, EventArgs e)
        {
            if (_tiposOperacoes == TiposOperacoes.Editar)
            {
                txt_nome.Text = _produto.Nome;
                txt_quantidade.Text = _produto.Quantidade.ToString();
                txt_valor.Text = _produto.Valor.ToString();
                lblTitulo.Text = "Editando Produto";
            }
            else
            {
                lblTitulo.Text = "Cadastrando Produto";
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainProduto.Show();
            this.Close();
        }
    }
}
