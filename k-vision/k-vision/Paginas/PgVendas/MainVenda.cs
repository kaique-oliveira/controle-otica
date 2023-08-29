using k_vision;
using Kvision.Database.Interfaces;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Interfaces;
using Kvision.Frame.Servicos;
using System.Text.Json;

namespace Kvision.Frame.Paginas.PgVendas
{
    public partial class MainVenda : Form
    {
        private readonly ServicosVendaProduto _servicosVenda;
        private readonly ServicosCliente _servicoCliente;
        private readonly ServicosReceita _servicoReceita;
        private readonly MainFrame _mainFrame;
        public MainVenda(ServicosVendaProduto servicosVenda, MainFrame mainFrame)
        {
            _servicosVenda = servicosVenda;
            _mainFrame = mainFrame;
            //_servicoCliente = servicoCliente;
            //_servicoReceita = servicosReceita;
            //, ServicosCliente servicoCliente, ServicosReceita servicosReceita

            InitializeComponent();
        }

        List<VendaProduto> listaVendas = new List<VendaProduto>();

        Cliente _cliente = new Cliente();
        Receita _receita = new Receita();
        VendaProduto _venda = new VendaProduto();

        int indexlistaVenda = -1;

        public void atualizarGridVendas()
        {
            dg_vendas.AutoGenerateColumns = false;
            listaVendas = _servicosVenda.ConsultarTodos();

            if (listaVendas.Count > 0)
            {
                List<VendaView> listaView = new List<VendaView>();

                foreach (var item in listaVendas)
                {
                    VendaView v = new VendaView();

                    v.DataCadastro = item.DataCadastro;
                    v.Nome = item.Cliente.Nome;
                    v.TipoPagamento = item.TipoPagamento;

                    listaView.Add(v);
                }

                dg_vendas.DataSource = listaView;
                indexlistaVenda = -1;
                dg_vendas.ClearSelection();

                decimal total = 0;

                foreach (var item in listaVendas)
                {
                    total += item.Total;
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
            indexlistaVenda = dg_vendas.CurrentCell.RowIndex;
            _venda = listaVendas[indexlistaVenda];

            lblClienteVenda.Text = _venda.Cliente.Nome;
            lblReceita_selecionada.Text = $"{_venda.Receita.DataExame.ToShortDateString()} - {_venda.Receita.NomeExaminador}";
            lbl_valor_total.Text = $"R$ {_venda.Total}";
            lbl_pagamento.Text = _venda.TipoPagamento.ToString();

            List<ItemProduto> itensProdutos = JsonSerializer.Deserialize<List<ItemProduto>>(_venda.Produtos);

            listViewProdutos.Items.Clear();

            foreach (var item in itensProdutos)
            {
                ListViewItem itemList = new ListViewItem($"{item.Quantidade} - {item.Nome}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewProdutos.Items.Add(itemList);
            }

            List<Adicional> adicionais = !string.IsNullOrEmpty(_venda.Adicionais) ?
                JsonSerializer.Deserialize<List<Adicional>>(_venda.Adicionais) : new List<Adicional>();

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

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainFrame.Show();
            this.Close();
        }

        private void dtp_data_inicio_ValueChanged(object sender, EventArgs e)
        {
            dtp_data_fim.MinDate = dtp_data_inicio.Value;

            var listaFiltrada = listaVendas.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
            && v.DataCadastro.Date <= dtp_data_fim.Value.Date);

            List<VendaView> listaView = new List<VendaView>();

            foreach (var item in listaFiltrada)
            {
                VendaView v = new VendaView();

                v.DataCadastro = item.DataCadastro;
                v.Nome = item.Cliente.Nome;
                v.TipoPagamento = item.TipoPagamento;

                listaView.Add(v);
            }
            dg_vendas.DataSource = listaFiltrada;


            decimal total = 0;

            foreach (var item in listaFiltrada)
            {
                total += item.Total;
            }

            lbl_total_todas_as_vendas.Text = total.ToString();

        }

        private void dtp_data_fim_ValueChanged(object sender, EventArgs e)
        {
            var listaFiltrada = listaVendas.FindAll(v => v.DataCadastro.Date >= dtp_data_inicio.Value.Date
            && v.DataCadastro.Date <= dtp_data_fim.Value.Date);

            List<VendaView> listaView = new List<VendaView>();

            foreach (var item in listaFiltrada)
            {
                VendaView v = new VendaView();

                v.DataCadastro = item.DataCadastro;
                v.Nome = item.Cliente.Nome;
                v.TipoPagamento = item.TipoPagamento;

                listaView.Add(v);
            }
            dg_vendas.DataSource = listaView;

            decimal total = 0;
            foreach (var item in listaFiltrada)
            {
                total += item.Total;
            }

            lbl_total_todas_as_vendas.Text = total.ToString();

        }

        private void btn_limpar_filtro_Click(object sender, EventArgs e)
        {
            dtp_data_inicio.Value = DateTime.Now.Date;
            dtp_data_fim.Value = DateTime.Now.Date;
        }

        private void btn_show_editar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f_editarVenda = new EditarVenda(this, _venda);
            f_editarVenda.ShowDialog();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (indexlistaVenda > -1)
            {
                var result = MessageBox.Show($"Deseja realmente deletar esta venda?", "Antenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    MessageBox.Show($"{_servicosVenda.Deletar(_venda)}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
