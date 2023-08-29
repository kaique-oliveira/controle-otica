using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Servicos;
using System.Data;


namespace Kvision.Frame.Paginas.PgVendaProduto
{
    public partial class SelecionarProduto : Form
    {
        private MainFrame _mainFrame;
        private TelaBlur _blur;
        public SelecionarProduto(MainFrame mainFrame, TelaBlur blur)
        {
            _mainFrame = mainFrame;
            InitializeComponent();
            _blur = blur;
            this.ShowInTaskbar = false;
        }


        ServicosProduto servicos = new ServicosProduto(new CrudProduto(new ConexaoDatabase()));
        List<Produto> listaProdutos = new List<Produto>();
        Produto produto = new Produto();
        public int indexlista = -1;

        public void atualizarGrid()
        {
            indexlista = -1;
            dg_produtos.AutoGenerateColumns = false;
            listaProdutos = servicos.ConsultarTodos().OrderBy(p => p.Nome).ToList();

            if (listaProdutos.Count > 0)
            {
                dg_produtos.DataSource = listaProdutos;
                dg_produtos.Rows[0].Cells[0].Selected = false;
            }
        }


        private void SelecionarProduto_Shown(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void dg_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlista = dg_produtos.CurrentCell.RowIndex;
            produto = listaProdutos[indexlista];
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (produto != null && indexlista != -1)
            {
                _mainFrame.confirmarSelecaoProduto(produto);

                MessageBox.Show("Produto adicionado!", "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dg_produtos.ClearSelection();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto da lista, para continuar!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _blur.Close();
            this.Close();
        }
    }
}
