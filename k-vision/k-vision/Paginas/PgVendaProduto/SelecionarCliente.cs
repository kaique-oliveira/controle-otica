using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Paginas.PgVendas;
using Kvision.Frame.Servicos;
using Npgsql.Replication;
using System.Data;


namespace Kvision.Frame.Paginas.PgVendaProduto
{
    public partial class SelecionarCliente : Form
    {
        private MainFrame? _mainFrame;
        private EditarVendaProduto? _editarVenda;
        private TelaBlur _blur;
  
        public SelecionarCliente(MainFrame? mainFrame, EditarVendaProduto? editarVenda, TelaBlur blur)
        {
            InitializeComponent();

            _mainFrame = mainFrame;
            _editarVenda = editarVenda;
            _blur = blur;
            this.ShowInTaskbar = false;
        }


        ServicosCliente servicos = new ServicosCliente(new CrudCliente(new ConexaoDatabase()));
        List<Cliente> listaClientes = new List<Cliente>();
        Cliente _cliente = new Cliente();
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

        private void pgSelecionarCliente_Shown(object sender, EventArgs e)
        {
            atualizarGrid();
        }


        public void Fechar()
        {
            _blur.Close();
            this.Close();
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void bnt_confirma_escolha_Click(object sender, EventArgs e)
        {
            if (_cliente != null && indexlista > -1)
            {

            var selectReceita = new SelecionarReceita(_cliente, this, _mainFrame, _editarVenda);
            this.Opacity = 0;
            selectReceita.ShowDialog();
                
            }
            else
            {

                MessageBox.Show("Por favor, selecione um cliente da lista, para continuar!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void dg_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlista = dg_clientes.CurrentCell.RowIndex;
            _cliente = listaClientes[indexlista];
        }
    }
}
