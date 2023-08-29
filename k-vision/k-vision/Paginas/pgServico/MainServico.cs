using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Servicos;
using System.Data;

namespace Kvision.Frame.Paginas.pgServico
{
    public partial class MainServico : Form
    {
        private TelaBlur _blur;
        public MainServico(TelaBlur blur)
        {
            _blur = blur;
            InitializeComponent();

            this.ShowInTaskbar = false;
        }


        ServicosServico servicosServico = new ServicosServico(new CrudServico(new ConexaoDatabase()));
        List<Servico> listaServico = new List<Servico>();
        Servico _servico = new Servico();
        int indexLista = -1;

        public void buscarServicos()
        {
            listaServico = servicosServico.ConsultarTodos().OrderBy(c => c.Nome).ToList();

            if (listaServico.Count > 0)
            {
                dg_servicos.AutoGenerateColumns = false;
                dg_servicos.DataSource = listaServico;
                dg_servicos.ClearSelection();
            }
        }

        private void MainServico_Shown(object sender, EventArgs e)
        {
            buscarServicos();
        }

        private void bnt_show_cadastrar_Click(object sender, EventArgs e)
        {
            var pg_servico = new PersistirServico(Enum.TiposOperacoes.Cadastrar, this, new Servico());
            this.Opacity = 0;
            pg_servico.ShowDialog();
        }
        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            var pg_servico = new PersistirServico(Enum.TiposOperacoes.Editar, this, _servico);
            this.Opacity = 0;
            pg_servico.ShowDialog();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _blur.Close();
            this.Close();
        }

        private void dg_servicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexLista = dg_servicos.CurrentCell.RowIndex;
            _servico = listaServico[indexLista];

            btn_show_editar.Enabled = true;
            btn_deletar.Enabled = true;
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (indexLista > -1)
            {
                var result = MessageBox.Show($"Deseja realmente deletar este serviço?", "Antenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    MessageBox.Show($"{servicosServico.Deletar(_servico)}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buscarServicos();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente da lista!", "Atenção");
            }
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            dg_servicos.DataSource = listaServico.FindAll(x => x.Nome.ToUpperInvariant().Contains(txt_filtro.Text.ToUpperInvariant()));
        }
    }
}
