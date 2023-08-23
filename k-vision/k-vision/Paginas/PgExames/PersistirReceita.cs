using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Frame.Enum;
using Kvision.Frame.Servicos;

namespace Kvision.Frame.Paginas.PgExames
{
    public partial class PersistirReceita : Form
    {
        private readonly Cliente _cliente;
        private Receita _receita;
        private List<Prescricao> _prescricao;
        private TiposOperacoes _tiposOperacoes;
        private MainReceita _mainReceita;
        public PersistirReceita(Cliente cliente, Receita? receita, List<Prescricao>? prescricao, TiposOperacoes tiposOperacoes, MainReceita mainReceita)
        {
            _cliente = cliente;
            _receita = receita ?? new Receita();
            _prescricao = prescricao ?? new List<Prescricao>();
            _tiposOperacoes = tiposOperacoes;
            _mainReceita = mainReceita;

            InitializeComponent();

        }

        ServicosReceita servicosReceita = new ServicosReceita(new CrudReceita(new ConexaoDatabase()));
        ServicosPrescricao servicosPrescricao = new ServicosPrescricao(new CrudPrescricao(new ConexaoDatabase()));
        ServicosPrescricaoAdicional servicoPrescricaoAdicional = new ServicosPrescricaoAdicional(new CrudPrescricaoAdicional(new ConexaoDatabase()));
        private TiposPrescricao _tipo;
        PrescricaoAdicional _prescriAdicional;


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            _prescriAdicional = new PrescricaoAdicional()
            {
                AdicaoDireito = txt_adicao_direito.Text,
                AlturaDireito = txt_altura_direito.Text,
                AdicaoEsquerdo = txt_adicao_esquerdo.Text,
                AlturaEsquerdo = txt_altura_esquerdo.Text
            };

            if (_tiposOperacoes == TiposOperacoes.Cadastrar)
            {
                servicoPrescricaoAdicional.Cadastrar(_prescriAdicional);

                _prescriAdicional = servicoPrescricaoAdicional.ConsultarTodos().Last();
            }
            else
            {
                _prescriAdicional.Id = _receita.PrescricaoAdicional.Id;
                servicoPrescricaoAdicional.Editar(_prescriAdicional);
            }

            _receita.DataExame = DateTime.Parse(dtp_data_realizado.Value.ToString());
            _receita.DataValExame = DateTime.Parse(_receita.DataExame.AddMonths(12).ToShortDateString());
            _receita.NomeExaminador = txt_nome_dr.Text;
            _receita.Cliente = _cliente;
            _receita.PrescricaoAdicional = _prescriAdicional;


            if (_tiposOperacoes == TiposOperacoes.Cadastrar)
            {
                servicosReceita.Cadastrar(_receita);

                _receita = servicosReceita.ConsultarTodos().Last();
            }
            else
            {
                servicosReceita.Editar(_receita);
            }




            Prescricao recuperarLonge()
            {
                Prescricao prescricao = new Prescricao();

                prescricao.Tipo = TiposPrescricao.Longe;

                if (_tiposOperacoes == TiposOperacoes.Editar)
                {
                    prescricao = _prescricao.Where(p => p.Tipo == prescricao.Tipo).First();

                }

                prescricao.Receita = _receita;
                prescricao.EsfericoDireito = txt_esf_direito_longe.Text;
                prescricao.EixoDireito = txt_eixo_direito_longe.Text;
                prescricao.CilindricoDireito = txt_cil_direito_longe.Text;
                prescricao.DPDireito = txt_dp_direito_longe.Text;

                prescricao.EsfericoEsquerdo = txt_esf_esquerdo_longe.Text;
                prescricao.EixoEsquerdo = txt_eixo_esquerdo_longe.Text;
                prescricao.CilindricoEsquerdo = txt_cil_esquerdo_longe.Text;
                prescricao.DPEsquerdo = txt_dp_esquerdo_longe.Text;

                return prescricao;
            }

            Prescricao recuperarPerto()
            {
                Prescricao prescricao = new Prescricao();

                prescricao.Tipo = TiposPrescricao.Perto;

                if (_tiposOperacoes == TiposOperacoes.Editar)
                {
                    prescricao = _prescricao.Where(p => p.Tipo == prescricao.Tipo).First();
                }

                prescricao.Receita = _receita;
                prescricao.EsfericoDireito = txt_esf_direito_perto.Text;
                prescricao.EixoDireito = txt_eixo_direito_perto.Text;
                prescricao.CilindricoDireito = txt_cil_direito_perto.Text;
                prescricao.DPDireito = txt_dp_direito_perto.Text;

                prescricao.EsfericoEsquerdo = txt_esf_esquerdo_perto.Text;
                prescricao.EixoEsquerdo = txt_eixo_esquerdo_perto.Text;
                prescricao.CilindricoEsquerdo = txt_cil_esquerdo_perto.Text;
                prescricao.DPEsquerdo = txt_dp_esquerdo_perto.Text;

                return prescricao;
            }

            var longe = recuperarLonge();
            var perto = recuperarPerto();

            if (_tiposOperacoes == TiposOperacoes.Editar)
            {
                _prescricao.Remove(_prescricao.Where(p => p.Id == longe.Id).First());
                _prescricao.Remove(_prescricao.Where(p => p.Id == perto.Id).First());
            }

            _prescricao.Add(longe);
            _prescricao.Add(perto);


            string res = "";
            foreach (Prescricao presc in _prescricao)
            {
                switch (_tiposOperacoes)
                {
                    case TiposOperacoes.Cadastrar:
                        res = servicosPrescricao.Cadastrar(presc);
                        break;
                    case TiposOperacoes.Editar:
                        res = servicosPrescricao.Editar(presc);
                        break;
                    default:
                        break;
                }

            }

            var result = MessageBox.Show(res, "Antenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                _mainReceita.atualizarGrid();
                _mainReceita.limparCampos();
                _mainReceita.indexlista = -1;
                _mainReceita.Show();
                this.Close();
            }
        }

        private void PersistirReceita_Load(object sender, EventArgs e)
        {
            if (_tiposOperacoes == TiposOperacoes.Editar)
            {
                dtp_data_realizado.Value = _receita.DataExame;
                txt_nome_dr.Text = _receita.NomeExaminador.ToString();

                txt_adicao_direito.Text = _receita.PrescricaoAdicional.AdicaoDireito.ToString();
                txt_altura_direito.Text = _receita.PrescricaoAdicional.AlturaDireito.ToString();
                txt_adicao_esquerdo.Text = _receita.PrescricaoAdicional.AdicaoEsquerdo.ToString();
                txt_altura_esquerdo.Text = _receita.PrescricaoAdicional.AlturaEsquerdo.ToString();

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

                foreach (var presc in _prescricao)
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
                lblTitulo.Text = "Editando receita";
            }
            else
            {
                lblTitulo.Text = "Cadastrando receita";
            }

            dtp_data_realizado.MaxDate = DateTime.Now;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
