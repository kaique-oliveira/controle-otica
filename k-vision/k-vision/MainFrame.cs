using Kvision.Frame.Paginas.PgCliente;
using Kvision.Frame.Paginas.PgProduto;

namespace k_vision
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }




        private void btn_show_clientes_Click(object sender, EventArgs e)
        {
            var f_cliente = new MainCliente();
            f_cliente.ShowDialog();
        }

        private void btn_show_produtos_Click(object sender, EventArgs e)
        {
            var f_produto = new MainProduto();
            f_produto.ShowDialog();
        }
    }
}