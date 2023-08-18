using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Servicos;


namespace Kvision.Frame.Paginas.PgExames
{
    public partial class MainReceita : Form
    {
        private readonly Cliente _cliente;
        private readonly MainFrame _mainFrame;
        public MainReceita(Cliente cliente, MainFrame mainFrame)
        {
            _mainFrame = mainFrame;
            _cliente = cliente;
            InitializeComponent();
        }


        ServicosReceita servicos = new ServicosReceita(new CrudReceita(new ConexaoDatabase()));
        ServicosPrescricao servicosPrescricao = new ServicosPrescricao(new CrudPrescricao(new ConexaoDatabase()));
        List<Receita> listaReceita = new List<Receita>();
        List<Prescricao> listaPrescricoes = new List<Prescricao>();
        Receita receita = new Receita();
        public int indexlista = -1;


        public void atualizarGrid()
        {
            dg_receitas.AutoGenerateColumns = false;
            listaReceita = servicos.ConsultarTodos().FindAll(r => r.Cliente.Id == _cliente.Id).OrderByDescending(c => c.DataCadastro).ToList();

            if (listaReceita.Count > 0)
            {
                dg_receitas.DataSource = listaReceita;
                indexlista = -1;
                dg_receitas.Rows[0].Cells[0].Selected = false;
                _mainFrame.atualizarGridReceitas();
            }
        }

        private void buscarPrescricao()
        {
            Prescricao prescricao = new Prescricao();

            listaPrescricoes = servicosPrescricao.ConsultarOne(listaReceita[indexlista].Id);

            void carregarLonge(Prescricao presc)
            {
                txt_esf_direito_longe.Text = presc.EsfericoDireito;
                txt_cil_direito_longe.Text = presc.CilindricoDireito;
                txt_eixo_direito_longe.Text = presc.EixoDireito;
                txt_dp_direito_longe.Text = presc.DPDireito;
                ;
                txt_esf_esquerdo_longe.Text = presc.EsfericoEsquerdo;
                txt_cil_esquerdo_longe.Text = presc.CilindricoEsquerdo;
                txt_eixo_esquerdo_longe.Text = presc.EixoEsquerdo;
                txt_dp_esquerdo_longe.Text = presc.DPEsquerdo;
            }

            void carregarPerto(Prescricao presc)
            {
                txt_esf_direito_perto.Text = presc.EsfericoDireito;
                txt_cil_direito_perto.Text = presc.CilindricoDireito;
                txt_eixo_direito_perto.Text = presc.EixoDireito;
                txt_dp_direito_perto.Text = presc.DPDireito;

                txt_esf_esquerdo_perto.Text = presc.EsfericoEsquerdo;
                txt_cil_esquerdo_perto.Text = presc.CilindricoEsquerdo;
                txt_eixo_esquerdo_perto.Text = presc.EixoEsquerdo;
                txt_dp_esquerdo_perto.Text = presc.DPEsquerdo;
            }


            foreach (var presc in listaPrescricoes)
            {
                switch (presc.Tipo)
                {
                    case Dominio.Enums.TiposPrescricao.Longe:
                        carregarLonge(presc);
                        break;
                    case Dominio.Enums.TiposPrescricao.Perto:
                        carregarPerto(presc);
                        break;
                    default:
                        break;
                }
            }
        }

        public void limparCampos()
        {
            txt_esf_direito_longe.Text = "";
            txt_cil_direito_longe.Text = "";
            txt_eixo_direito_longe.Text = "";
            txt_dp_direito_longe.Text = "";
            ;
            txt_esf_esquerdo_longe.Text = "";
            txt_cil_esquerdo_longe.Text = "";
            txt_eixo_esquerdo_longe.Text = "";
            txt_dp_esquerdo_longe.Text = "";

            txt_esf_direito_perto.Text = "";
            txt_cil_direito_perto.Text = "";
            txt_eixo_direito_perto.Text = "";
            txt_dp_direito_perto.Text = "";

            txt_esf_esquerdo_perto.Text = "";
            txt_cil_esquerdo_perto.Text = "";
            txt_eixo_esquerdo_perto.Text = "";
            txt_dp_esquerdo_perto.Text = "";
        }

        private void bnt_cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var persistirExame = new PersistirReceita(_cliente, null, null, TiposOperacoes.Cadastrar, this);
            persistirExame.ShowDialog();
        }

        private void dg_receitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlista = dg_receitas.CurrentCell.RowIndex;
            receita = listaReceita[indexlista];
            buscarPrescricao();
        }

        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            if (indexlista > -1)
            {
                this.Hide();
                var persistirExame = new PersistirReceita(_cliente, receita, listaPrescricoes, TiposOperacoes.Editar, this);
                persistirExame.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecione uma receita da lista!", "Atenção");
            }

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

            if (indexlista > -1)
            {
                var result = MessageBox.Show($"Deseja realmente deletar esta receita?", "Antenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"{servicos.Deletar(receita, listaPrescricoes, servicosPrescricao)}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    indexlista = -1;
                    atualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente da lista!", "Atenção");
            }
        }

        private void MainReceita_Shown(object sender, EventArgs e)
        {

            atualizarGrid();

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainFrame.Show();
            this.Close();
        }
    }
}
