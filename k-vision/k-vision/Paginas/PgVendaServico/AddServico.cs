using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Paginas.PgVendas;
using Kvision.Frame.Servicos;
using System.Data;
using System.Text.RegularExpressions;

namespace Kvision.Frame.Paginas.PgVendaServico
{
    public partial class AddServico : Form
    {

        private MainFrame? _mainFrame;
        private EditarVendaServico? _editarVendaServico;
        private TelaBlur _blur;
        public AddServico(MainFrame mainFrame, EditarVendaServico? vendaServico, TelaBlur telaBlur)
        {
            _mainFrame = mainFrame;
            _editarVendaServico = vendaServico;
            _blur = telaBlur;

            InitializeComponent();

            this.ShowInTaskbar = false;
            txt_valor.Text = string.Format("{0:#,##0.00}", 0d);
            txt_quantidade.Text = "1";
        }

        ServicosServico servicosServico = new ServicosServico(new CrudServico(new ConexaoDatabase()));
        List<Servico> listaServico = new List<Servico>();
        Servico _servico = new Servico();
        public int indexlista = -1;

        public void buscarServicos()
        {
            dg_servicos.AutoGenerateColumns = false;
            listaServico = servicosServico.ConsultarTodos().OrderBy(c => c.Nome).ToList();

            if (listaServico.Count > 0)
            {
                dg_servicos.DataSource = listaServico;
                dg_servicos.ClearSelection();
            }
        }

        private void bnt_confirmar_Click(object sender, EventArgs e)
        {
            if (_mainFrame != null)
            {
                if (!string.IsNullOrEmpty(txt_valor.Text))
                {
                    _servico.Valor = decimal.Parse(string.Format("{0:#,##0.00}", (_servico.Valor * int.Parse(txt_quantidade.Text))));

                    _mainFrame.valor_total_servico += _servico.Valor;
                    _mainFrame.confirmarServico(_servico);

                    txt_valor.Text = "";
                    MessageBox.Show($"Serviço adicionado!", "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    indexlista = -1;
                    dg_servicos.ClearSelection();
                    _servico = new Servico();
                    buscarServicos();
                    txt_quantidade.Text = "1";
                    txt_quantidade.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Digite um valor para este serviço, para continuar!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_valor.Text))
                {
                    _servico.Valor = decimal.Parse(string.Format("{0:#,##0.00}", (_servico.Valor * int.Parse(txt_quantidade.Text))));

                    _editarVendaServico.valor_total_servico += _servico.Valor;
                    _editarVendaServico.confirmarServico(_servico);

                    txt_valor.Text = "";
                    MessageBox.Show($"Serviço adicionado!", "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    indexlista = -1;
                    dg_servicos.ClearSelection();
                    _servico = new Servico();
                    buscarServicos();
                    txt_quantidade.Text = "";
                }
                else
                {
                    MessageBox.Show($"Digite um valor para este serviço, para continuar!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dg_servicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_quantidade.Enabled = true;
            indexlista = dg_servicos.CurrentCell.RowIndex;
            _servico = listaServico[indexlista];

            txt_valor.Text = string.Format("{0:#,##0.00}", _servico.Valor);
            bnt_confirmar.Enabled = true;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            if (_mainFrame != null)
            {
                _blur.Close();
                this.Close();
            }
            else
            {
                _editarVendaServico.Opacity = 100;
                this.Close();
            }

        }

        private void AddServico_Shown(object sender, EventArgs e)
        {
            buscarServicos();
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


        private void TextNumero(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);


            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals('\b'))
            {
                if (e.KeyChar.Equals('\b'))
                {
                    if (w == string.Empty) w = "0";
                    w = w.Substring(0, w.Length - 1);
                }
                else
                {
                    t.Text += e.KeyChar.ToString();
                    t.Select(t.Text.Length, 0);
                    e.Handled = true;
                }
                return;
            }

            e.Handled = true;
        }
    }
}
