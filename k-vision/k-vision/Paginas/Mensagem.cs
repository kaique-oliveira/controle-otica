

using k_vision;
using Kvision.Frame.Paginas.PgVendaServico;

namespace Kvision.Frame.Paginas
{
    public partial class Mensagem: Form
    {

 
        private MainFrame? mainFrame;
        private AddServico? addServico;
        public Mensagem(MainFrame main, AddServico add)
        {
            mainFrame = main;
            addServico = add;
            InitializeComponent(); 
        }



        private void Mensagem_Load(object sender, EventArgs e)
        {
            var dd = mainFrame;
            var tt = addServico;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
