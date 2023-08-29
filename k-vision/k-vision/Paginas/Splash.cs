using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Frame.Servicos;

namespace Kvision.Frame.Paginas
{
    public partial class Splash : Form
    {
        MainFrame _mainFrame;
        public Splash(MainFrame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            this.ShowInTaskbar = false;
        }

        ServicosCliente servicosCliente = new ServicosCliente(new CrudCliente(new ConexaoDatabase()));

        private void Splash_Shown(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pb_loading.Value += 10;

            if (pb_loading.Value >= 100)
            {
                timer.Enabled = false;
                _mainFrame.Opacity = 100;
                _mainFrame.ShowInTaskbar = true;
                this.Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;

            servicosCliente.ConsultarTodos();
        }
    }
}
