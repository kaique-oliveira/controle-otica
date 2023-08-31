

using k_vision;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Paginas.PgCaixa;
using Kvision.Frame.Paginas.PgCliente;
using Kvision.Frame.Paginas.PgProduto;
using Kvision.Frame.Paginas.pgServico;
using Kvision.Frame.Paginas.PgVendaProduto;
using Kvision.Frame.Paginas.PgVendas;
using Kvision.Frame.Paginas.PgVendaServico;
using System.Windows.Forms;

namespace Kvision.Frame.Paginas
{
    public partial class TelaBlur : Form
    {

        string tela;
        MainFrame _mainFrame;
        public TelaBlur(MainFrame mainFrame, string tela)
        {
            InitializeComponent();

            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = mainFrame.Height;
            this.ShowInTaskbar = false;

            this.tela = tela;
            _mainFrame = mainFrame;
        }




        private void TelaBlur_Shown(object sender, EventArgs e)
        {
            switch (tela)
            {
                case "servico":
                    var s = new MainServico(this);
                    s.ShowDialog();
                    break;
                case "cliente":
                    var c = new MainCliente(this);
                    c.ShowDialog();
                    break;
                case "produto":
                    var p = new MainProduto(this);
                    p.ShowDialog();
                    break;
                case "selecionar-produto":
                    var sp = new SelecionarProduto(_mainFrame, null, this);
                    sp.ShowDialog();
                    break;
                case "selecionar-cliente":
                    var sc = new SelecionarCliente(_mainFrame, null, this);
                    sc.ShowDialog();
                    break;
                case "selecionar-adicional":
                    var a = new AddAdicional(_mainFrame, null, this);
                    a.ShowDialog();
                    break;
                case "selecionar-servico":
                    var sv = new AddServico(_mainFrame, this);
                    sv.ShowDialog();
                    break;
                case "caixa":
                    var cx = new MainCaixa(this);
                    cx.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
