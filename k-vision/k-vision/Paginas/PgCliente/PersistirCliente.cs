using Kvision.Dominio.Entidades;
using Kvision.Frame.Enum;
using Kvision.Frame.Interfaces;

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
                var result = MessageBox.Show($"{_servicos.Cadastrar(_cliente)}", "Antenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    _mainCliente.atualizarGrid();
                    limparCampos();
                    _mainCliente.indexlista = -1;
                    this.Close();
                }
            }
            else
            {
                var result = MessageBox.Show($"{_servicos.Editar(_cliente)}", "Antenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    _mainCliente.atualizarGrid();
                    limparCampos();
                    _mainCliente.indexlista = -1;
                    this.Close();
                }
            }
        }

        private void PersistirCliente_Load(object sender, EventArgs e)
        {
            if (_tiposOperacoes == TiposOperacoes.Editar)
            {
                txt_nome.Text = _cliente.Nome;
                txt_telefone.Text = _cliente.Telefone;
                this.Text = "Editando cliente";
            }
            else
            {
                this.Text = "Cadastrando cliente";
            }
        }
    }
}
