using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Paginas.PgCliente;
using Kvision.Frame.Servicos;

namespace Kvision.Frame.Paginas.PgProduto
{
    public partial class MainProduto : Form
    {
        private readonly MainFrame _mainFrame;
        public MainProduto(MainFrame mainFrame)
        {
            _mainFrame = mainFrame;
            InitializeComponent();
        }

        ServicosProduto servicos = new ServicosProduto(new CrudProduto(new ConexaoDatabase()));
        List<Produto> listaProdutos = new List<Produto>();
        Produto produto = new Produto();
        public int indexlista = -1;


        public void atualizarGrid()
        {
            indexlista = -1;
            dg_produtos.AutoGenerateColumns = false;
            listaProdutos = servicos.ConsultarTodos();

            if (listaProdutos.Count > 0)
            {
                dg_produtos.DataSource = listaProdutos.OrderBy(p => p.Nome).ToList();
                dg_produtos.Rows[0].Cells[0].Selected = false;
                _mainFrame.atualizarGridProduto();
            }
        }


        private void MainProduto_Shown(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void bnt_show_cadastrar_Click(object sender, EventArgs e)
        {
            var crud_produto = new PersistirProduto(TiposOperacoes.Cadastrar, servicos, null, this);
            crud_produto.ShowDialog();
        }

        private void dg_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlista = dg_produtos.CurrentCell.RowIndex;
            produto = listaProdutos[indexlista];
        }

        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            if (indexlista > -1)
            {
                var crud_produto = new PersistirProduto(TiposOperacoes.Editar, servicos, produto, this);
                crud_produto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecione um produto da lista!", "Atenção");
            }
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            dg_produtos.DataSource = listaProdutos.FindAll(x => x.Nome.ToUpperInvariant().Contains(txt_filtro.Text.ToUpperInvariant()));
        }
    }
}
