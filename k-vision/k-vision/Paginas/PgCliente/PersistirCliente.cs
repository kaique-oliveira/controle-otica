using Kvision.Dominio.Entidades;
using Kvision.Dominio.Servico;
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

            _cliente.Cep = txt_cep.Text;
            _cliente.Logradouro = txt_logradouro.Text;
            _cliente.NumeroCasa = int.Parse(txt_numero.Text);
            _cliente.Bairro = txt_bairro.Text;
            _cliente.Localidade = txt_localidade.Text;
            _cliente.Complemento = txt_complemento.Text;


            if (_tiposOperacoes == TiposOperacoes.Cadastrar)
            {
                var result = MessageBox.Show($"{_servicos.Cadastrar(_cliente)}", "Antenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    _mainCliente.atualizarGrid();
                    limparCampos();
                    _mainCliente.indexlista = -1;

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

                }
            }
            _mainCliente.Show();
            this.Close();
        }

        private void PersistirCliente_Load(object sender, EventArgs e)
        {
            if (_tiposOperacoes == TiposOperacoes.Editar)
            {
                txt_nome.Text = _cliente.Nome;
                txt_telefone.Text = _cliente.Telefone;

                txt_cep.Text = _cliente.Cep;
                txt_logradouro.Text = _cliente.Logradouro;
                txt_numero.Text = _cliente.NumeroCasa.ToString();
                txt_bairro.Text = _cliente.Bairro;
                txt_localidade.Text = _cliente.Localidade;
                txt_complemento.Text = _cliente.Complemento;

                lblTitulo.Text = "Editando cliente";
            }
            else
            {
                lblTitulo.Text = "Cadastrando cliente";
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void txt_cep_Validated(object sender, EventArgs e)
        {
            var endereco = ServiceBuscarEndereco.BuscarEndereco(txt_cep.Text);
            if (endereco != null)
            {
                if (endereco.Street.Equals("erro"))
                {
                    MessageBox.Show("Sem conexão com a internet, não foi possivel buscar o endereço!");
                }
                else
                {
                    txt_cep.Text = endereco.Cep;
                    txt_logradouro.Text = endereco.Street;
                    txt_bairro.Text = endereco.Neighborhood;
                    txt_localidade.Text = endereco.City;
                }
            }
        }
    }
}
