using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Paginas.PgExames;
using Kvision.Frame.Servicos;

namespace Kvision.Frame.Paginas.PgCliente
{
    public partial class MainCliente : Form
    {
        private TelaBlur _blur;
        public MainCliente(TelaBlur blur)
        {
            _blur = blur;
            InitializeComponent();

            this.ShowInTaskbar = false;
        }

        ServicosCliente servicos = new ServicosCliente(new CrudCliente(new ConexaoDatabase()));
        List<Cliente> listaClientes = new List<Cliente>();
        Cliente cliente = new Cliente();
        public int indexlista = -1;

        public void atualizarGrid()
        {
            indexlista = -1;
            dg_clientes.AutoGenerateColumns = false;
            listaClientes = servicos.ConsultarTodos().OrderBy(c => c.Nome).ToList();

            if (listaClientes.Count > 0)
            {
                dg_clientes.DataSource = listaClientes;
                dg_clientes.Rows[0].Cells[0].Selected = false;
            }
        }

        private void bnt_show_cadastrar_Click(object sender, EventArgs e)
        {
            var crud_cliente = new PersistirCliente(TiposOperacoes.Cadastrar, servicos, null, this);
            this.Opacity = 0;
            crud_cliente.ShowDialog();
        }
        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            if (indexlista > -1)
            {
                Cliente clienteRecuperado = listaClientes[indexlista];
                var crud_cliente = new PersistirCliente(TiposOperacoes.Editar, servicos, clienteRecuperado, this);
                this.Opacity = 0;
                crud_cliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente da lista!", "Atenção");
            }
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            dg_clientes.DataSource = listaClientes.FindAll(x => x.Nome.ToUpperInvariant().Contains(txt_filtro.Text.ToUpperInvariant())
                || x.Telefone.Contains(txt_filtro.Text));
        }



        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (indexlista > -1)
            {
                var result = MessageBox.Show($"Deseja realmente deletar este cliente?", "Antenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    MessageBox.Show($"{servicos.Deletar(cliente)}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente da lista!", "Atenção");
            }
        }

        private void dg_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlista = dg_clientes.CurrentCell.RowIndex;
            cliente = listaClientes[indexlista];

            txt_cep.Text = cliente.Cep;
            txt_logradouro.Text = cliente.Logradouro;
            txt_numero.Text = cliente.NumeroCasa.ToString();
            txt_bairro.Text = cliente.Bairro;
            txt_localidade.Text = cliente.Localidade;
            txt_complemento.Text = cliente.Complemento;

            btn_deletar.Enabled = true;
            btn_show_editar.Enabled = true;
            btn_show_receitas.Enabled = true;
        }


        private void MainCliente_Shown(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _blur.Close();
            this.Close();
        }

        private void btn_show_receitas_Click(object sender, EventArgs e)
        {
            var pgReceita = new MainReceita(cliente, this);
            this.Opacity = 0;
            pgReceita.ShowDialog();
        }
    }
}
