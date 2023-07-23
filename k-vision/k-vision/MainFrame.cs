using Kvision.Frame.Paginas.PgCliente;


namespace k_vision
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f_cliente = new MainCliente();
            f_cliente.ShowDialog();
        }
    }
}