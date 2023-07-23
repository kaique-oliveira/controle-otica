

using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Frame.Interfaces;
using Kvision.Frame.Servicos;

namespace Kvision.Frame.Paginas.PgExames
{
    public partial class PersistirReceita : Form
    {
        private readonly Cliente _cliente;
        public PersistirReceita(Cliente cliente)
        {
            _cliente = cliente; 
            InitializeComponent();
        }

        ServicosReceita servicosReceita = new ServicosReceita(new CrudReceita(new ConexaoDatabase()));
        ServicosPrescricao servicosPrescricao = new ServicosPrescricao(new CrudPrescricao(new ConexaoDatabase()));
        private TiposPrescricao _tipo;
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Receita receita = new Receita();

            receita.DataExame = DateTime.Parse(txt_d_realizado.Text);
            receita.DataValExame = DateTime.Parse(txt_d_validade.Text);
            receita.NomeExaminador = txt_nome_dr.Text;
            receita.Cliente = _cliente;

            var retorno = servicosReceita.Cadastrar(receita);
            if (retorno != "Receita cadastrado com sucesso!") {
                MessageBox.Show(retorno);
            }

            Receita receitaRecuperada = servicosReceita.ConsultarTodos().Last();

            List<Prescricao> prescricoes = new List<Prescricao>();
           

            if (_tipo == TiposPrescricao.Longe)
            {
                Prescricao prescricao = new Prescricao();

                prescricao.Receita = receitaRecuperada;
                prescricao.EsfericoDireito = decimal.Parse(txt_esf_direito_longe.Text);
                prescricao.EixoDireito = decimal.Parse(txt_eixo_direito_longe.Text);
                prescricao.CilindricoDireito = decimal.Parse(txt_cil_direito_longe.Text);
                prescricao.DPDireito = decimal.Parse(txt_dp_direito_longe.Text);

                prescricao.EsfericoEsquerdo = decimal.Parse(txt_esf_esquerdo_longe.Text);
                prescricao.EixoEsquerdo = decimal.Parse(txt_eixo_esquerdo_longe.Text);
                prescricao.CilindricoEsquerdo = decimal.Parse(txt_cil_esquerdo_longe.Text);
                prescricao.DPEsquerdo = decimal.Parse(txt_dp_esquerdo_longe.Text);


                prescricoes.Add(prescricao);
            }
            else if(_tipo == TiposPrescricao.Perto)
            {
                Prescricao prescricao = new Prescricao();

                prescricao.Receita = receitaRecuperada;
                prescricao.EsfericoDireito = decimal.Parse(txt_esf_direito_perto.Text);
                prescricao.EixoDireito = decimal.Parse(txt_eixo_direito_perto.Text);
                prescricao.CilindricoDireito = decimal.Parse(txt_cil_direito_perto.Text);
                prescricao.DPDireito = decimal.Parse(txt_dp_direito_perto.Text);

                prescricao.EsfericoEsquerdo = decimal.Parse(txt_esf_esquerdo_perto.Text);
                prescricao.EixoEsquerdo = decimal.Parse(txt_eixo_esquerdo_perto.Text);
                prescricao.CilindricoEsquerdo = decimal.Parse(txt_cil_esquerdo_perto.Text);
                prescricao.DPEsquerdo = decimal.Parse(txt_dp_esquerdo_perto.Text);

                prescricoes.Add(prescricao);
            }
            else if (_tipo == TiposPrescricao.Ambos)
            {
                for (int i = 0; i < 2; i++)
                {
                    Prescricao prescricao = new Prescricao();

                    switch (prescricoes.Count)
                    {
                        case 0:
                            prescricao.Tipo = TiposPrescricao.Longe;
                            prescricao.Receita = receitaRecuperada;
                            prescricao.EsfericoDireito = decimal.Parse(txt_esf_direito_longe.Text);
                            prescricao.EixoDireito = decimal.Parse(txt_eixo_direito_longe.Text);
                            prescricao.CilindricoDireito = decimal.Parse(txt_cil_direito_longe.Text);
                            prescricao.DPDireito = decimal.Parse(txt_dp_direito_longe.Text);

                            prescricao.EsfericoEsquerdo = decimal.Parse(txt_esf_esquerdo_longe.Text);
                            prescricao.EixoEsquerdo = decimal.Parse(txt_eixo_esquerdo_longe.Text);
                            prescricao.CilindricoEsquerdo = decimal.Parse(txt_cil_esquerdo_longe.Text);
                            prescricao.DPEsquerdo = decimal.Parse(txt_dp_esquerdo_longe.Text);
                            break;
                        case 1:
                            prescricao.Tipo = TiposPrescricao.Perto;
                            prescricao.Receita = receitaRecuperada;
                            prescricao.EsfericoDireito = decimal.Parse(txt_esf_direito_perto.Text);
                            prescricao.EixoDireito = decimal.Parse(txt_eixo_direito_perto.Text);
                            prescricao.CilindricoDireito = decimal.Parse(txt_cil_direito_perto.Text);
                            prescricao.DPDireito = decimal.Parse(txt_dp_direito_perto.Text);

                            prescricao.EsfericoEsquerdo = decimal.Parse(txt_esf_esquerdo_perto.Text);
                            prescricao.EixoEsquerdo = decimal.Parse(txt_eixo_esquerdo_perto.Text);
                            prescricao.CilindricoEsquerdo = decimal.Parse(txt_cil_esquerdo_perto.Text);
                            prescricao.DPEsquerdo = decimal.Parse(txt_dp_esquerdo_perto.Text);
                            break;
                        default:
                            return;
                    }
                  
                    prescricoes.Add(prescricao);
                }
            }

            string res = "";
            foreach (Prescricao presc in prescricoes)
            {
                res = servicosPrescricao.Cadastrar(presc);
            }
            MessageBox.Show(res);
        }

        private void rd_longe_CheckedChanged(object sender, EventArgs e)
        {
            lbl_longe.Visible = true;
            panel_longe.Visible = true;

            lbl_perto.Visible = false;
            panel_perto.Visible = false;

            _tipo = TiposPrescricao.Longe;
        }

        private void rd_perto_CheckedChanged(object sender, EventArgs e)
        {
            lbl_perto.Visible = true;
            panel_perto.Visible = true;

            lbl_longe.Visible = false;
            panel_longe.Visible = false;

            _tipo = TiposPrescricao.Perto;
        }

        private void rd_ambos_CheckedChanged(object sender, EventArgs e)
        {
            lbl_perto.Visible = true;
            panel_perto.Visible = true;

            lbl_longe.Visible = true;
            panel_longe.Visible = true;

            _tipo = TiposPrescricao.Ambos;
        }

        private void PersistirReceita_Load(object sender, EventArgs e)
        {

        }
    }
}
