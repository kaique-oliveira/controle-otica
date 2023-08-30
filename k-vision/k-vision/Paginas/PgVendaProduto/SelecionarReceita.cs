using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Paginas.PgVendas;
using Kvision.Frame.Servicos;
using System.Data;


namespace Kvision.Frame.Paginas.PgVendaProduto
{
    public partial class SelecionarReceita : Form
    {
        private readonly Cliente _cliente;
        private SelecionarCliente _selecionarCliente;

        private MainFrame? _mainFrame;
        private EditarVendaProduto? _editarVenda;

        public SelecionarReceita(Cliente cliente, SelecionarCliente selecionarCliente, MainFrame? mainFrame, EditarVendaProduto? editarVenda)
        {
            _cliente = cliente;
            _selecionarCliente = selecionarCliente;
            _mainFrame = mainFrame;
            _editarVenda = editarVenda; 

            InitializeComponent();

        }


        ServicosReceita servicosReceita = new ServicosReceita(new CrudReceita(new ConexaoDatabase()));
        ServicosPrescricao servicosPrescricao = new ServicosPrescricao(new CrudPrescricao(new ConexaoDatabase()));
        List<Receita> listaReceita = new List<Receita>();
        List<Prescricao> listaPrescricoes = new List<Prescricao>();
        Receita receita = new Receita();
        public int indexlista = -1;


        public void atualizarGrid()
        {
            dg_receitas.AutoGenerateColumns = false;
            listaReceita = servicosReceita.ConsultarTodos().FindAll(r => r.Cliente.Id == _cliente.Id).OrderByDescending(c => c.Id).ToList();

            if (listaReceita.Count > 0)
            {
                dg_receitas.DataSource = listaReceita;
                indexlista = -1;
                dg_receitas.Rows[0].Cells[0].Selected = false;
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

            txtAdicaoDireito.Text = listaReceita[indexlista].PrescricaoAdicional.AdicaoDireito.ToString();
            txtAlturaDireito.Text = listaReceita[indexlista].PrescricaoAdicional.AlturaDireito.ToString();
            txtAdicaoEsquerdo.Text = listaReceita[indexlista].PrescricaoAdicional.AdicaoEsquerdo.ToString();
            txtAlturaEsquerdo.Text = listaReceita[indexlista].PrescricaoAdicional.AlturaEsquerdo.ToString();

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


        private void SelecionarReceita_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void dg_receitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlista = dg_receitas.CurrentCell.RowIndex;
            receita = listaReceita[indexlista];
            buscarPrescricao();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _selecionarCliente.Opacity = 100;
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (receita != null && indexlista > -1)
            {
                if (_mainFrame != null)
                {
                    _mainFrame.confirmarSelecaoReceita(receita);
                    _selecionarCliente.Fechar();
                    this.Close();
                }else 
                if(_editarVenda != null)
                {
                    _editarVenda.confirmarSelecaoReceita(receita);
                    _selecionarCliente.Fechar();
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma receita da lista, para continuar!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        }
    
}
