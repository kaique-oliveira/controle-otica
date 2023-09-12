using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Frame.Paginas.PgVendas;
using Kvision.Frame.Servicos;

namespace Kvision.Frame.Paginas.PgCaixa
{
    public partial class MainCaixa : Form
    {
        private TelaBlur _blur;
        public MainCaixa(TelaBlur blur)
        {
            InitializeComponent();
            _blur = blur;
            this.ShowInTaskbar = false;
        }

        ServicoCaixa _servicoCaixa = new ServicoCaixa(new CrudCaixa(new ConexaoDatabase()));
        ServicoMovimentacao _servicoMovimentacao = new ServicoMovimentacao(new CrudMovimentacao(new ConexaoDatabase()));
        List<Movimentacao> listaMovimentacao = new List<Movimentacao>();

        Movimentacao movimentacao = new Movimentacao();

        public void atualizarGridMovimentacoes()
        {
            dg_movimentacoes.AutoGenerateColumns = false;
            listaMovimentacao = _servicoMovimentacao.ConsultarTodos()
                .OrderByDescending(m => m.DataCadastro.ToShortDateString()).ToList();

            if (listaMovimentacao.Count > 0)
            {
                dg_movimentacoes.DataSource = listaMovimentacao;
                dg_movimentacoes.ClearSelection();
                movimentacao = null;
            }
        }

        public void colorirLinhas()
        {
            foreach (DataGridViewRow row in dg_movimentacoes.Rows)
            {
                if (row.Cells[3].Value.ToString() == "Entrada")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.DarkSalmon;
                }
            }

            dg_movimentacoes.ClearSelection();
        }

        public void buscarCaixa()
        {
            txt_total_caixa.Text = "R$ " + string.Format("{0:#,##0.00}", _servicoCaixa.ConsultarTodos().First<Caixa>().Valor);
        }

        private void btn_show_vendas_Click(object sender, EventArgs e)
        {
            var pgVendas = new MainVenda(this, _blur);
            this.Opacity = 0;
            pgVendas.ShowDialog();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _blur.Close();
            this.Close();
        }

        private void MainCaixa_Shown(object sender, EventArgs e)
        {
            atualizarGridMovimentacoes();
            buscarCaixa();
     

            colorirLinhas();

            dg_movimentacoes.ClearSelection();
        }




        private void btn_show_movimentacao_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            var f_movi = new PersistirMovimentacao(this, null);
            f_movi.ShowDialog();
        }

        private void dg_movimentacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            movimentacao = listaMovimentacao[dg_movimentacoes.CurrentCell.RowIndex];

            if (movimentacao.IdVenda == null)
            {
                btn_show_editar.Enabled = true;
                btn_deletar.Enabled = true;
            }
            else
            {
                btn_show_editar.Enabled = false;
                btn_deletar.Enabled = false;
                movimentacao = null;
            }
        }

        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            var t_Movi = new PersistirMovimentacao(this, movimentacao);
            this.Opacity = 0;
            t_Movi.ShowDialog();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (movimentacao != null)
            {
                var result = MessageBox.Show($"Deseja realmente deletar está movimentação?", "Antenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"{_servicoMovimentacao.Deletar(movimentacao)}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarGridMovimentacoes();
                    colorirLinhas();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma movimentação da lista!", "Atenção");
            }
        }


        List<Movimentacao> listaViewMovimentacoesFiltrada = new List<Movimentacao>();
        DateTime filtro;

        private void cb_tipo_mov_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = (ComboBox)sender;
            TipoMovimentacao tipo;
            atualizarGridMovimentacoes();

            switch (c.SelectedIndex.ToString())
            {
                case "1":
                    tipo = TipoMovimentacao.Entrada;

                    if (filtro.Date.ToShortDateString() != "01/01/0001")
                    {
                        listaMovimentacao = listaMovimentacao.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
                        && v.DataCadastro.Date <= dtp_data_fim.Value.Date);

                        listaMovimentacao = listaMovimentacao.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
                        && v.DataCadastro.Date <= dtp_data_fim.Value.Date);
                    }

                    listaMovimentacao = listaMovimentacao.Where(m => m.Tipo == tipo)
                        .OrderByDescending(m => m.DataCadastro.ToShortDateString()).ToList();
                    break;
                case "2":
                    tipo = TipoMovimentacao.Saida;
                    if (filtro.Date.ToShortDateString() != "01/01/0001")
                    {
                        listaMovimentacao = listaMovimentacao.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
                        && v.DataCadastro.Date <= dtp_data_fim.Value.Date);

                        listaMovimentacao = listaMovimentacao.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
                        && v.DataCadastro.Date <= dtp_data_fim.Value.Date);
                    }

                    listaMovimentacao = listaMovimentacao.Where(m => m.Tipo == tipo)
                       .OrderByDescending(m => m.DataCadastro.ToShortDateString()).ToList();
                    break;
                default:

                    if (filtro.Date.ToShortDateString() != "01/01/0001")
                    {
                        listaMovimentacao = listaMovimentacao.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
                        && v.DataCadastro.Date <= dtp_data_fim.Value.Date);

                        listaMovimentacao = listaMovimentacao.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
                        && v.DataCadastro.Date <= dtp_data_fim.Value.Date);
                    }

                    listaMovimentacao = listaMovimentacao
                       .OrderByDescending(m => m.DataCadastro.ToShortDateString()).ToList();
                    break;
            }

            dg_movimentacoes.DataSource = listaMovimentacao;

            decimal total = 0;
            foreach (var item in listaMovimentacao)
            {
                total += item.Valor;
            }

            txt_total_caixa.Text = "R$ " + string.Format("{0:#,##0.00}", total.ToString());

            colorirLinhas();

        }

        private void dtp_data_inicio_ValueChanged(object sender, EventArgs e)
        {
            dtp_data_fim.Enabled = true;
            dtp_data_fim.MinDate = dtp_data_inicio.Value;

            listaMovimentacao = listaMovimentacao.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
            && v.DataCadastro.Date <= dtp_data_fim.Value.Date);


            dg_movimentacoes.DataSource = listaMovimentacao;


            decimal total = 0;

            foreach (var item in listaMovimentacao)
            {
                total += item.Valor;
            }

            txt_total_caixa.Text = "R$ " + string.Format("{0:#,##0.00}", total.ToString());
            colorirLinhas();
        }

        private void dtp_data_fim_ValueChanged(object sender, EventArgs e)
        {
            listaMovimentacao = listaMovimentacao.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
            && v.DataCadastro.Date <= dtp_data_fim.Value.Date);
            filtro = dtp_data_fim.Value.Date;

            dg_movimentacoes.DataSource = listaMovimentacao;

            decimal total = 0;
            foreach (var item in listaMovimentacao)
            {
                total += item.Valor;
            }

            txt_total_caixa.Text = "R$ " + string.Format("{0:#,##0.00}", total.ToString());
            colorirLinhas();

        }

        private void btn_limpar_filtro_Click(object sender, EventArgs e)
        {
            dtp_data_inicio.Value = DateTime.Now.Date;
            dtp_data_fim.Value = DateTime.Now.Date;
            dg_movimentacoes.DataSource = listaMovimentacao;
            dtp_data_fim.Enabled = false;
            atualizarGridMovimentacoes();
            buscarCaixa();
            colorirLinhas();
        }

    }
}
