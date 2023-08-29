using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Paginas.PgProduto;
using Kvision.Frame.Servicos;
using System.Text.RegularExpressions;

namespace Kvision.Frame.Paginas.pgServico
{
    public partial class PersistirServico : Form
    {
        private MainServico _mainServico;
        private readonly TiposOperacoes _tiposOperacoes;
        private Servico _servico;
        public PersistirServico(TiposOperacoes tiposOperacoes, MainServico mainServico, Servico? servico)
        {
            InitializeComponent();
            _mainServico = mainServico;
            _tiposOperacoes = tiposOperacoes;
            _servico = servico ?? new Servico();

            this.ShowInTaskbar = false;
        }

        ServicosServico servicosServico = new ServicosServico(new CrudServico(new ConexaoDatabase()));



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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nome.Text))
            {
                decimal n;
                bool isNumeric = decimal.TryParse(txt_valor.Text, out n);
                Servico servico = new Servico()
                {
                    Id = _servico.Id,
                    Nome = txt_nome.Text,
                    Valor = !isNumeric ? 0 : decimal.Parse(string.Format("{0:#,##0.00}", txt_valor.Text))
                };

                var result = _tiposOperacoes == TiposOperacoes.Cadastrar ? servicosServico.Cadastrar(servico)
                    : servicosServico.Editar(servico);

                if (!string.IsNullOrEmpty(result))
                {
                    var ms = MessageBox.Show(result, "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ms == DialogResult.OK && _tiposOperacoes == TiposOperacoes.Editar)
                    {
                        _mainServico.Opacity = 100;
                        this.Close();
                    }
                    else
                    {
                        txt_nome.Text = "";
                        txt_valor.Text = "";
                    }

                    _mainServico.buscarServicos();

                }
                else
                {
                    MessageBox.Show("Algo deu errado!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                var mensagem = new Mensagem("Ops", "Por favor, preencha o campo nome, para continuar!", false);
                mensagem.ShowDialog();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainServico.Opacity = 100;
            this.Close();
        }

        private void PersistirServico_Shown(object sender, EventArgs e)
        {
            this.BringToFront();

            if (_tiposOperacoes == TiposOperacoes.Editar)
            {
                txt_nome.Text = _servico.Nome;
                txt_valor.Text = _servico.Valor.ToString() == "0,00" ? "" : _servico.Valor.ToString();
            }
        }
    }
}
