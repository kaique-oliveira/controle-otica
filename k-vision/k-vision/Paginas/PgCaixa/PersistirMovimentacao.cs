using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Servicos;
using System.Drawing;
using System.Text.RegularExpressions;


namespace Kvision.Frame.Paginas.PgCaixa
{
    public partial class PersistirMovimentacao : Form
    {
        private MainCaixa _mainCaixa;
        private Movimentacao? _movimentacao;
        public PersistirMovimentacao(MainCaixa mainCaixa, Movimentacao? movimentacao)
        {
            InitializeComponent();
            _mainCaixa = mainCaixa;
            _movimentacao = movimentacao;
        }

        ServicoMovimentacao _servicoMovimentacao = new ServicoMovimentacao(new CrudMovimentacao(new ConexaoDatabase()));

        private void PersistirMovimentacao_Load(object sender, EventArgs e)
        {
            cb_tipo_mov.SelectedIndex = 0;
            txt_valor.Text = "0,00";

            if (_movimentacao != null)
            {
                txt_descricao.Text = _movimentacao.Descricao;
                txt_valor.Text = _movimentacao.Valor.ToString();
                cb_tipo_mov.SelectedIndex = _movimentacao.Tipo == Dominio.Enums.TipoMovimentacao.Entrada ? 0 : 1;
            }
            
        }

        private void btn_salvar_edicao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_descricao.Text) && !string.IsNullOrEmpty(txt_valor.Text))
            {
                var response = "";

                if (_movimentacao != null)
                {
                    _movimentacao.Descricao = txt_descricao.Text;
                    _movimentacao.Tipo = cb_tipo_mov.Text == "Entrada" ? Dominio.Enums.TipoMovimentacao.Entrada : Dominio.Enums.TipoMovimentacao.Saida;
                    _movimentacao.Valor = decimal.Parse(txt_valor.Text);

                    response = _servicoMovimentacao.Editar(_movimentacao);

                    _mainCaixa.Opacity = 100;
                    this.Close();
                }
                else
                {
                    var mov = new Movimentacao()
                    {
                        Descricao = txt_descricao.Text,
                        Tipo = cb_tipo_mov.Text == "Entrada" ? Dominio.Enums.TipoMovimentacao.Entrada : Dominio.Enums.TipoMovimentacao.Saida,
                        Valor = decimal.Parse(txt_valor.Text)
                    };

                    response = _servicoMovimentacao.Cadastrar(mov);
                }


                if (response != "")
                {
                    var resp = MessageBox.Show(response, "Tudo certo", MessageBoxButtons.OK);
                    if (resp == DialogResult.OK)
                    {
                        txt_descricao.Text = "";
                        txt_valor.Text = "0,00";
                        cb_tipo_mov.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Algo deu errado", "Ops");
                }

                _mainCaixa.buscarCaixa();
                _mainCaixa.atualizarGridMovimentacoes();
                _mainCaixa.colorirLinhas();
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos", "Ops");
            }
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

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainCaixa.Opacity = 100;
            this.Close();
        }
    }
}
