using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Frame.Paginas.PgVendaServico;
using Kvision.Frame.Servicos;
using System.Text.Json;

namespace Kvision.Frame.Paginas.PgVendas
{
    public partial class EditarVendaServico : Form
    {

        private TelaBlur _telaBlur;
        private VendaServico _vendaServico;
        private MainVenda _mainVenda;

        public EditarVendaServico(MainVenda mainVenda, TelaBlur telaBlur, VendaServico vendaServico)
        {
            _telaBlur = telaBlur;
            _vendaServico = vendaServico;
            _mainVenda = mainVenda;
            InitializeComponent();
            this.ShowInTaskbar = false;
        }


        ServicosVendaServico servicosVendaServico = new ServicosVendaServico(new CrudVendaServico(new ConexaoDatabase()));
        VendaServico vendaServico = new VendaServico();
        List<Servico> listaServico = new List<Servico>();
        public decimal valor_total_servico = 0;
        private TiposPagamento tipoPagamento_servico;

        public void confirmarServico(Servico servico)
        {
            listViewServicos.Items.Clear();

            if (listaServico.Find(e => e.Id == servico.Id) != null)
            {
                listaServico.Find(e => e.Id == servico.Id).Valor += servico.Valor;
            }
            else
            {
                listaServico.Add(servico);
            }

            foreach (var item in listaServico)
            {
                ListViewItem itemList = new ListViewItem($"{item.Nome}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewServicos.Items.Add(itemList);
            }

            painel_pagamento_servico.Visible = true;
            txt_total_servico.Text = $"R$ {valor_total_servico}";
        }

        private void EditarVendaServico_Load(object sender, EventArgs e)
        {
            listaServico = JsonSerializer.Deserialize<List<Servico>>(_vendaServico.Servicos);
            txt_observacao_servico.Text = _vendaServico.Observacao;
            tipoPagamento_servico = _vendaServico.TipoPagamento;

            switch (_vendaServico.TipoPagamento)
            {
                case TiposPagamento.Dinheiro:
                    rb_dinheiro_servico.Checked = true;
                    break;
                case TiposPagamento.Pix:
                    rb_pix_servico.Checked = true;
                    break;
                case TiposPagamento.Debito:
                    rb_debito_servico.Checked = true;
                    break;
                case TiposPagamento.Credito:
                    rb_credito_servico.Checked = true;
                    break;
            }

            if (listaServico != null)
            {
                foreach (var item in listaServico)
                {
                    ListViewItem itemList = new ListViewItem($"{item.Nome}");
                    itemList.SubItems.Add($"R$ {item.Valor}");

                    listViewServicos.Items.Add(itemList);

                }

                valor_total_servico = _vendaServico.Total;
                txt_total_servico.Text = $"R$ {_vendaServico.Total}";
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainVenda.Opacity = 100;
            this.Close();
        }

        private void btn_show_add_servico_Click(object sender, EventArgs e)
        {
            var sv = new AddServico(null, this, _telaBlur);
            this.Opacity = 0;
            sv.ShowDialog();
        }

        private void rb_dinheiro_servico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_servico = TiposPagamento.Dinheiro;
            }
        }

        private void rb_pix_servico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_servico = TiposPagamento.Pix;
            }
        }

        private void rb_debito_servico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_servico = TiposPagamento.Debito;
            }
        }

        private void rb_credito_servico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_servico = TiposPagamento.Credito;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var newVendaServico = new VendaServico()
            {
                Id = _vendaServico.Id,
                DataCadastro = _vendaServico.DataCadastro,
                TipoPagamento = tipoPagamento_servico,
                Observacao = txt_observacao_servico.Text,
                Servicos = JsonSerializer.Serialize<List<Servico>>(listaServico),
                Total = decimal.Parse(string.Format("{0:#,##0.00}", valor_total_servico))
            };

            var response = servicosVendaServico.Editar(newVendaServico);

            if (response == "Venda editada com sucesso!")
            {
                var result = MessageBox.Show($"Venda editada com sucesso!", "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    _mainVenda.atualizarGridVendas();
                    _mainVenda.Opacity = 100;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Algo deu errado!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_apagar_produto_Click(object sender, EventArgs e)
        {
            listViewServicos.Items.Clear();
            valor_total_servico = 0;

            listaServico.Clear();
            txt_total_servico.Text = $"R$ {valor_total_servico}";
        }
    }
}
