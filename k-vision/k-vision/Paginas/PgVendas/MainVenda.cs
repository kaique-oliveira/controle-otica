using k_vision;
using Kvision.Database.Conexao;
using Kvision.Database.Interfaces;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Paginas.PgCaixa;
using Kvision.Frame.Servicos;
using System.Text.Json;

namespace Kvision.Frame.Paginas.PgVendas
{
    public partial class MainVenda : Form
    {

        private MainCaixa _mianCaixa;
        private TelaBlur _telaBlur;
        public MainVenda(MainCaixa mainCaixa, TelaBlur telaBlur)
        {
            _mianCaixa = mainCaixa;
            InitializeComponent();

            this.ShowInTaskbar = false;
            _telaBlur = telaBlur;
        }


        ServicosVendaProduto _servicosVendaProduto = new ServicosVendaProduto(new CrudVendaProduto(new ConexaoDatabase()));
        ServicosVendaServico _servicosVendaServico = new ServicosVendaServico(new CrudVendaServico(new ConexaoDatabase()));
        List<VendaProduto> listaVendasProdutos = new List<VendaProduto>();
        List<VendaServico> listaVendasServicos = new List<VendaServico>();

        Cliente _cliente = new Cliente();
        Receita _receita = new Receita();
        VendaProduto _vendaProduto = new VendaProduto();
        VendaServico _vendaServico = new VendaServico();

        List<VendaView> listaViewVendas = new List<VendaView>();
        VendaView vendaView = new VendaView();
        int indexlistaVenda = -1;
        string tipoVenda = "";

        public void atualizarGridVendas()
        {
            dg_vendas.AutoGenerateColumns = false;
            listaVendasProdutos = _servicosVendaProduto.ConsultarTodos();
            listaVendasServicos = _servicosVendaServico.ConsultarTodos();

            if (listaVendasProdutos.Count > 0)
            {
                VendaView v;
                foreach (var item in listaVendasProdutos)
                {
                    v = new VendaView()
                    {
                        Id = item.Id,
                        DataCadastro = item.DataCadastro,
                        TipoPagamento = item.TipoPagamento,
                        TipoVenda = "Podutos",
                        Valor = item.Total,
                    };

                    listaViewVendas.Add(v);
                }
                foreach (var item in listaVendasServicos)
                {
                    v = new VendaView()
                    {
                        Id = item.Id,
                        DataCadastro = item.DataCadastro,
                        TipoPagamento = item.TipoPagamento,
                        TipoVenda = "Serviços",
                        Valor = item.Total,
                    };

                    listaViewVendas.Add(v);
                }

                listaViewVendas = listaViewVendas.OrderByDescending(c => c.DataCadastro).ToList();

                dg_vendas.DataSource = listaViewVendas;
                indexlistaVenda = -1;
                dg_vendas.ClearSelection();

                decimal total = 0;

                foreach (var item in listaViewVendas)
                {
                    total += item.Valor;
                }

                lbl_total_todas_as_vendas.Text = total.ToString();
            }
            else
            {
                dg_vendas.DataSource = null;
            }
        }

        private void MainVenda_Shown(object sender, EventArgs e)
        {
            atualizarGridVendas();
            dtp_data_inicio.MaxDate = DateTime.Now;
            dtp_data_fim.MaxDate = DateTime.Now;
        }

        private void dg_vendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idVenda = int.Parse(dg_vendas.CurrentRow.Cells[0].Value.ToString());
            tipoVenda = dg_vendas.CurrentRow.Cells[2].Value.ToString();

            listViewProdutos.Items.Clear();
            btn_deletar.Enabled = true;
            btn_show_editar.Enabled = true;

            if (tipoVenda == "Podutos")
            {
                _vendaProduto = listaVendasProdutos.Find(p => p.Id == idVenda);

                lblClienteVenda.Text = _vendaProduto.Cliente.Nome;
                lblReceita_selecionada.Text = $"{_vendaProduto.Receita.DataExame.ToShortDateString()} - {_vendaProduto.Receita.NomeExaminador}";
                lbl_valor_total.Text = $"R$ {_vendaProduto.Total}";
                lbl_pagamento.Text = _vendaProduto.TipoPagamento.ToString();

                List<ItemProduto> itensProdutos = JsonSerializer.Deserialize<List<ItemProduto>>(_vendaProduto.Produtos);

                foreach (var item in itensProdutos)
                {
                    ListViewItem itemList = new ListViewItem($"{item.Quantidade} - {item.Nome}");
                    itemList.SubItems.Add($"R$ {item.Valor}");

                    listViewProdutos.Items.Add(itemList);
                }

                List<Adicional> adicionais = !string.IsNullOrEmpty(_vendaProduto.Adicionais) ?
                    JsonSerializer.Deserialize<List<Adicional>>(_vendaProduto.Adicionais) : new List<Adicional>();

                if (adicionais.Count > 0)
                {
                    foreach (var item in adicionais)
                    {
                        ListViewItem itemList = new ListViewItem($"1 - {item.Descricao}");
                        itemList.SubItems.Add($"R$ {item.Valor}");

                        listViewProdutos.Items.Add(itemList);
                    }
                }
            }
            else
            {
                _vendaServico = listaVendasServicos.Find(s => s.Id == idVenda);

                lblClienteVenda.Text = "Não possui";
                lblReceita_selecionada.Text = "Não possui";
                lbl_valor_total.Text = $"R$ {_vendaServico.Total}";
                lbl_pagamento.Text = _vendaServico.TipoPagamento.ToString();

                List<Servico> itensServicos = JsonSerializer.Deserialize<List<Servico>>(_vendaServico.Servicos);

                foreach (var item in itensServicos)
                {
                    ListViewItem itemList = new ListViewItem($"{item.Nome}");
                    itemList.SubItems.Add($"R$ {item.Valor}");

                    listViewProdutos.Items.Add(itemList);
                }
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mianCaixa.Opacity = 100;
            this.Close();
        }





        private void dtp_data_inicio_ValueChanged(object sender, EventArgs e)
        {
            dtp_data_fim.MinDate = dtp_data_inicio.Value;

            var listaViewVendasFiltrada = listaViewVendas.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
            && v.DataCadastro.Date <= dtp_data_fim.Value.Date);


            dg_vendas.DataSource = listaViewVendasFiltrada;


            decimal total = 0;

            foreach (var item in listaViewVendas)
            {
                total += item.Valor;
            }

            lbl_total_todas_as_vendas.Text = total.ToString();

        }

        private void dtp_data_fim_ValueChanged(object sender, EventArgs e)
        {
            var listaViewVendasFiltrada = listaViewVendas.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
            && v.DataCadastro.Date <= dtp_data_fim.Value.Date);

            dg_vendas.DataSource = listaViewVendasFiltrada;

            decimal total = 0;
            foreach (var item in listaViewVendas)
            {
                total += item.Valor;
            }

            lbl_total_todas_as_vendas.Text = total.ToString();

        }

        private void btn_limpar_filtro_Click(object sender, EventArgs e)
        {
            dtp_data_inicio.Value = DateTime.Now.Date;
            dtp_data_fim.Value = DateTime.Now.Date;
            dg_vendas.DataSource = listaViewVendas;
        }




        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            if (tipoVenda == "Podutos")
            {
                var f_editarVenda = new EditarVendaProduto(this,_telaBlur, _vendaProduto);
                this.Opacity = 0;
                f_editarVenda.ShowDialog();
            }
          
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (indexlistaVenda > -1)
            {
                var result = MessageBox.Show($"Deseja realmente deletar esta venda?", "Antenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    MessageBox.Show($"{_servicosVendaProduto.Deletar(_vendaProduto)}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarGridVendas();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente da lista!", "Atenção");
            }
        }
    }
}
