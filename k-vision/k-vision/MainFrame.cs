using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Interfaces;
using Kvision.Frame.Paginas.PgCliente;
using Kvision.Frame.Paginas.PgProduto;
using Kvision.Frame.Servicos;

namespace k_vision
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        ServicosCliente servicosCliente = new ServicosCliente(new CrudCliente(new ConexaoDatabase()));
        ServicosReceita servicosReceita = new ServicosReceita(new CrudReceita(new ConexaoDatabase()));

        List<Cliente> listaClientes = new List<Cliente>();
        List<Receita> listaReceita = new List<Receita>();
        private int indexlistaCliente = -1, indexlistaReceita = -1;

        Cliente _cliente = new Cliente();



        //ServicosPrescricao servicosPrescricao = new ServicosPrescricao(new CrudPrescricao(new ConexaoDatabase()));

        //List<Prescricao> listaPrescricoes = new List<Prescricao>();
        //Receita receita = new Receita();


        private void btn_show_cliente_Click(object sender, EventArgs e)
        {
            var f_cliente = new MainCliente();
            f_cliente.ShowDialog();
        }

        private void btn_show_prod_Click(object sender, EventArgs e)
        {
            var f_produto = new MainProduto();
            f_produto.ShowDialog();
        }


        private void MainFrame_Shown(object sender, EventArgs e)
        {
            atualizarGridClientes();
        }



        public void atualizarGridClientes()
        {
            indexlistaCliente = -1;
            dg_clientes.AutoGenerateColumns = false;
            listaClientes = servicosCliente.ConsultarTodos();

            if (listaClientes.Count > 0)
            {
                dg_clientes.DataSource = listaClientes.OrderBy(c => c.Nome).ToList();
                dg_clientes.Rows[0].Cells[0].Selected = false;
            }
        }

        public void atualizarGridReceitas()
        {
            dg_receitas.AutoGenerateColumns = false;
            listaReceita = servicosReceita.ConsultarTodos().FindAll(r => r.Cliente.Id == _cliente.Id);

            if (listaReceita.Count > 0)
            {
                dg_receitas.DataSource = listaReceita;
                indexlistaReceita = -1;
                dg_receitas.Rows[0].Cells[0].Selected = false;
                dg_receitas.Enabled = true;
            }
            else
            {
                dg_receitas.DataSource = null;
            }
        }

        private void dg_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlistaCliente = dg_clientes.CurrentCell.RowIndex;
            _cliente = listaClientes[indexlistaCliente];
            atualizarGridReceitas();
        }
    }
}