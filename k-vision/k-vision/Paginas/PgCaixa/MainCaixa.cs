using Kvision.Frame.Paginas.PgVendas;

namespace Kvision.Frame.Paginas.PgCaixa
{
    public partial class MainCaixa : Form
    {
        private TelaBlur _blur;
        public MainCaixa(TelaBlur blur)
        {
            InitializeComponent();
            _blur = blur;
            this.ShowInTaskbar = false;
        }

        private void btn_show_vendas_Click(object sender, EventArgs e)
        {
            var pgVendas = new MainVenda(this, _blur);
            this.Opacity = 0;
            pgVendas.ShowDialog();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _blur.Close();
            this.Close();
        }
    }
}
