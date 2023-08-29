using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Interfaces;
using System.Text.RegularExpressions;

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

            this.ShowInTaskbar = false;
            txt_valor.Text = string.Format("{0:#,##0.00}", 0d);
        }


        private void TextKeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals('\b'))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);


                if (e.KeyChar.Equals('\b'))
                {
                    if (w == string.Empty) w = "00";
                    w = w.Substring(0, w.Length - 1);
                }
                else
                {
                    w += e.KeyChar;

                    t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                    t.Select(t.Text.Length, 0);
                    e.Handled = true;
                }
                return;
            }
            var x = e.KeyChar;
            e.Handled = true;
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
                    _mainProduto.Opacity = 100;
                    this.Close();
                }
            }
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
            _mainProduto.Opacity = 100;
            this.Close();
        }
    }
}
