using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Interfaces;
using Kvision.Frame.Servicos;
using System.Globalization;

namespace Kvision.Frame.Paginas.PgCliente
{
    public partial class PersistirCliente : Form
    {

        private readonly TiposOperacoes _tiposOperacoes;
        private readonly IServicos<Cliente> _servicos;
        private Cliente _cliente;
        private readonly MainCliente _mainCliente;

        public PersistirCliente(TiposOperacoes tiposOperacoes, IServicos<Cliente> servicos, Cliente? cliente, MainCliente mainCliente)
        {
            _tiposOperacoes = tiposOperacoes;
            _servicos = servicos;
            _cliente = cliente ?? new Cliente();
            _mainCliente = mainCliente;
            InitializeComponent();
        }


        public void limparCampos()
        {
            txt_nome.Text = "";
            txt_telefone.Text = "";
        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {          
            _cliente.Nome = txt_nome.Text;
            _cliente.Telefone = txt_telefone.Text;

            if (_tiposOperacoes == TiposOperacoes.Cadastrar)
            {   
                MessageBox.Show($"{_servicos.Cadastrar(_cliente)}", "Atenção");
            }
            else
            {          
                MessageBox.Show($"{_servicos.Editar(_cliente)}", "Atenção");
            }

            _mainCliente.atualizarGrid();
            limparCampos();
        }

        private void PersistirCliente_Load(object sender, EventArgs e)
        {
            if(_cliente != null)
            {
                txt_nome.Text = _cliente.Nome;
                txt_telefone.Text = _cliente.Telefone;
            }
        }
    }
}
