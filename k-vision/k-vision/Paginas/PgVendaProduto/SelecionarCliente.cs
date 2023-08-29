using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Servicos;
using System.Data;


namespace Kvision.Frame.Paginas.PgVendaProduto
{
    public partial class SelecionarCliente : Form
    {
        private MainFrame _mainFrame;
        private TelaBlur _blur;
        public SelecionarCliente(MainFrame mainFrame, TelaBlur blur)
        {
            _mainFrame = mainFrame;
            InitializeComponent();
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
                var selectReceita = new SelecionarReceita(_cliente, this, _mainFrame);
                this.Opacity = 0;
                selectReceita.ShowDialog();
            }
            else
            {
                var mensagem = new Mensagem("Ops", "Por favor, selecione um cliente da lista, para continuar!", false);
                mensagem.ShowDialog();
            }
        }

        private void dg_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlista = dg_clientes.CurrentCell.RowIndex;
            _cliente = listaClientes[indexlista];
        }
    }
}
