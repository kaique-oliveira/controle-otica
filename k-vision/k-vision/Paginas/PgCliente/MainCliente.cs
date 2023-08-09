using k_vision;
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
        private readonly MainFrame _mainFrame;
        public MainCliente(MainFrame mainFrame)
        {
            _mainFrame = mainFrame;
            InitializeComponent();
        }

        ServicosCliente servicos = new ServicosCliente(new CrudCliente(new ConexaoDatabase()));
        List<Cliente> listaClientes = new List<Cliente>();
        Cliente cliente = new Cliente();
        public int indexlista = -1;

        public void atualizarGrid()
        {
            indexlista = -1;
            dg_clientes.AutoGenerateColumns = false;
            listaClientes = servicos.ConsultarTodos();

            if (listaClientes.Count > 0)
            {
                dg_clientes.DataSource = listaClientes.OrderBy(c => c.Nome).ToList();
                dg_clientes.Rows[0].Cells[0].Selected = false;
                _mainFrame.atualizarGridClientes();
            }
        }

        private void bnt_show_cadastrar_Click(object sender, EventArgs e)
        {
            var crud_cliente = new PersistirCliente(TiposOperacoes.Cadastrar, servicos, null, this);
            crud_cliente.ShowDialog();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            dg_clientes.DataSource = listaClientes.FindAll(x => x.Nome.ToUpperInvariant().Contains(txt_filtro.Text.ToUpperInvariant())
                || x.Telefone.Contains(txt_filtro.Text));
        }

        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            if (indexlista > -1)
            {
                Cliente clienteRecuperado = listaClientes[indexlista];
                var crud_cliente = new PersistirCliente(TiposOperacoes.Editar, servicos, clienteRecuperado, this);
                crud_cliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente da lista!", "Atenção");
            }
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
        }

        private void btn_show_exames_Click(object sender, EventArgs e)
        {
            //if (indexlista > -1)
            //{
            //    Cliente cliente = listaClientes[indexlista];
            //    var mainExames = new MainReceita(cliente);
            //    mainExames.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Por favor selecione um cliente da lista!", "Atenção");
            //}

        }

        private void MainCliente_Shown(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void dg_clientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
