using Kvision.Dominio.Entidades;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvision.Frame.Paginas.PgVendas
{
    public partial class MainVenda : Form
    {
        private readonly ServicosVenda _servicosVenda;
        private readonly ServicosCliente _servicoCliente;
        private readonly ServicosReceita _servicoReceita;

        public MainVenda(ServicosVenda servicosVenda)
        {
            _servicosVenda = servicosVenda;
            //_servicoCliente = servicoCliente;
            //_servicoReceita = servicosReceita;
            //, ServicosCliente servicoCliente, ServicosReceita servicosReceita

            InitializeComponent();
        }

        List<Venda> listaVendas = new List<Venda>();
        Cliente _cliente = new Cliente();
        Receita _receita = new Receita();
        Venda _venda = new Venda();

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
            }
            else
            {
                dg_vendas.DataSource = null;
            }
        }

        private void MainVenda_Shown(object sender, EventArgs e)
        {
            atualizarGridVendas();
        }

        private void dg_vendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexlistaVenda = dg_vendas.CurrentCell.RowIndex;
            _venda = listaVendas[indexlistaVenda];

            lblClienteVenda.Text = _venda.Cliente.Nome;
            lblReceita_selecionada.Text = $"{_venda.Receita.DataExame.ToShortDateString()} - {_venda.Receita.NomeExaminador}";
            lbl_valor_total.Text = $"R$ {_venda.Total}";

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
    }
}
