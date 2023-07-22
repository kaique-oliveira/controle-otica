using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Interfaces;
using Kvision.Frame.Paginas.PgExames;
using Kvision.Frame.Servicos;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Kvision.Frame.Paginas.PgCliente
{
    public partial class MainCliente : Form
    {
        public MainCliente()
        {

            InitializeComponent();
        }

        ServicosCliente servicos = new ServicosCliente(new CrudCliente(new ConexaoDatabase()));
        List<Cliente> listaClientes = new List<Cliente>();
        int indexlista = -1;

        public void atualizarGrid()
        {
            indexlista = -1;
            dg_clientes.AutoGenerateColumns = false;
            listaClientes = servicos.ConsultarTodos();
            dg_clientes.DataSource = listaClientes;
            dg_clientes.Rows[0].Cells[0].Selected = false;
        }

        private void bnt_show_cadastrar_Click(object sender, EventArgs e)
        {
            var crud_cliente = new PersistirCliente(TiposOperacoes.Cadastrar, servicos, null, this);
            crud_cliente.ShowDialog();
        }

        private void MainCliente_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            dg_clientes.DataSource = listaClientes.FindAll(x => x.Nome.ToUpperInvariant().Contains(txt_filtro.Text.ToUpperInvariant()) 
                || x.Telefone.Contains(txt_filtro.Text));
        }

        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            if(indexlista > -1) { 
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
                    Cliente clienteRecuperado = listaClientes[indexlista];
                    MessageBox.Show($"{servicos.Deletar(clienteRecuperado)}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btn_show_exames_Click(object sender, EventArgs e)
        {
            var mainExames = new MainExames();
            mainExames.ShowDialog();
        }
    }
}
