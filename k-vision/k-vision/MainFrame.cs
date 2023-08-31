using Kvision.Database.Conexao;
using Kvision.Database.Servicos;
using Kvision.Dominio.Entidades;
using Kvision.Dominio.Enums;
using Kvision.Dominio.ViewModel;
using Kvision.Frame.Paginas;
using Kvision.Frame.Paginas.PgVendas;
using Kvision.Frame.Paginas.PgVendaServico;
using Kvision.Frame.Servicos;
using System.Text.Json;


namespace k_vision
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        //ServicosServico servicosServico = new ServicosServico(new CrudServico(new ConexaoDatabase()));
        //ServicosCliente servicosCliente = new ServicosCliente(new CrudCliente(new ConexaoDatabase()));
        ServicosProduto servicosProduto = new ServicosProduto(new CrudProduto(new ConexaoDatabase()));
        ServicosVendaProduto servicosVendaProduto = new ServicosVendaProduto(new CrudVendaProduto(new ConexaoDatabase()));

        private decimal valorTotal = 0;
        Receita _receita_selecionada;

        Servico _servico = new Servico();

        List<ItemProduto> produtosSelecionados = new List<ItemProduto>();
        List<Adicional> listaAdicional = new List<Adicional>();
        List<Servico> listaServico = new List<Servico>();
        private TiposPagamento tipoPagamento_produto, tipoPagamento_servico;


        public void confirmarSelecaoReceita(Receita receita)
        {
            _receita_selecionada = new Receita();
            _receita_selecionada = receita;

            lblClienteVenda.Text = receita.Cliente.Nome;
            lblReceitaVenda.Text = $"{receita.NomeExaminador} -  data: {receita.DataCadastro.ToShortDateString()} | val: {receita.DataValExame.ToShortDateString()}";

            painel_pagamentos.Visible = true;
        }
        public void confirmarSelecaoProduto(Produto _produto)
        {
            if (produtosSelecionados.Count != 0 && produtosSelecionados.Where(p => p.Id == _produto.Id).Count() != 0)
            {
                produtosSelecionados.Find(p => p.Id == _produto.Id).Quantidade += 1;
                produtosSelecionados.Find(p => p.Id == _produto.Id).Valor += _produto.Valor;
            }
            else
            {
                ItemProduto _itemProduto = new ItemProduto();
                _itemProduto.Id = _produto.Id;
                _itemProduto.Nome = _produto.Nome;
                _itemProduto.Valor = _produto.Valor;
                _itemProduto.Quantidade = 1;

                produtosSelecionados.Add(_itemProduto);
            }

            listViewProdutos.Items.Clear();

            foreach (var item in produtosSelecionados)
            {
                ListViewItem itemList = new ListViewItem($"{item.Quantidade} - {item.Nome}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewProdutos.Items.Add(itemList);
            }

            bnt_finalizar_venda.Visible = true;
            painel_observacao.Visible = true;
            valorTotal += _produto.Valor;
            txt_total_produto.Text = $"R$ {valorTotal}";

        }
        public void confirmarAdicional(Adicional adicional)
        {
            listaAdicional.Add(adicional);
            valorTotal += adicional.Valor;
            txt_total_produto.Text = $"R$ {valorTotal}";

            listViewAdicionais.Items.Clear();
            foreach (var item in listaAdicional)
            {
                ListViewItem itemList = new ListViewItem($"1 - {item.Descricao}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewAdicionais.Items.Add(itemList);
            }
        }
        public void limparVendaProduto()
        {
            valorTotal = 0;
            produtosSelecionados.Clear();
            listaAdicional.Clear();

            listViewProdutos.Items.Clear();
            listViewAdicionais.Items.Clear();
            txt_observacao_produto.Text = "";

            rb_dinheiro_produto.Checked = false;
            rb_pix_produto.Checked = false;
            rb_debito_produto.Checked = false;
            rb_credito_produto.Checked = false;

            lblClienteVenda.Text = "Nome do cliente";
            lblReceitaVenda.Text = "Receita do cliente";
            txt_total_produto.Text = $"R$ 0,00";

            painel_pagamentos.Visible = false;
            painel_produtos.Visible = false;
            painel_observacao.Visible = false;
        }





        private void btn_show_select_cliente_Click(object sender, EventArgs e)
        {
            TelaBlur t = new TelaBlur(this, "selecionar-cliente");
            t.ShowDialog();
        }

        private void rb_dinheiro_produto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_produto = TiposPagamento.Dinheiro;
                painel_produtos.Visible = true;
            }
        }

        private void rb_pix_produto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_produto = TiposPagamento.Pix;
                painel_produtos.Visible = true;
            }
        }

        private void rb_debito_produto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_produto = TiposPagamento.Debito;
                painel_produtos.Visible = true;
            }
        }

        private void rb_credito_produto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_produto = TiposPagamento.Credito;
                painel_produtos.Visible = true;
            }
        }



        private void btn_show_select_produto_Click(object sender, EventArgs e)
        {
            TelaBlur t = new TelaBlur(this, "selecionar-produto");
            t.ShowDialog();
        }

        private void btn_show_add_adicional_Click(object sender, EventArgs e)
        {
            TelaBlur t = new TelaBlur(this, "selecionar-adicional");
            t.ShowDialog();
        }

        private void bnt_finalizar_venda_Click(object sender, EventArgs e)
        {
            var newVenda = new VendaProduto()
            {
                Receita = _receita_selecionada,
                Cliente = _receita_selecionada.Cliente,
                Produtos = JsonSerializer.Serialize<List<ItemProduto>>(produtosSelecionados),
                Adicionais = JsonSerializer.Serialize<List<Adicional>>(listaAdicional),
                TipoPagamento = tipoPagamento_produto,
                Observacao = txt_observacao_produto.Text,
                Total = valorTotal
            };


            string response = servicosVendaProduto.AjustarSaldo(newVenda, servicosProduto);

            if (response == "Venda finalizada!")
            {
                var result = MessageBox.Show($"Venda do produto finaliza!", "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    limparVendaProduto();
                }
            }
            else
            {
                MessageBox.Show($"Algo deu errado", "Ops", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }


        private void bnt_show_clientes_Click(object sender, EventArgs e)
        {
            TelaBlur t = new TelaBlur(this, "cliente");
            t.ShowDialog();
        }

        private void btn_show_prods_Click(object sender, EventArgs e)
        {
            TelaBlur t = new TelaBlur(this, "produto");
            t.ShowDialog();
        }

        private void btn_show_caixa_Click(object sender, EventArgs e)
        {
            TelaBlur t = new TelaBlur(this, "caixa");
            t.ShowDialog();
        }

        private void btn_show_servicos_Click(object sender, EventArgs e)
        {
            TelaBlur t = new TelaBlur(this, "servico");
            t.ShowDialog();
        }



        ServicosVendaServico servicosVendaServico = new ServicosVendaServico(new CrudVendaServico(new ConexaoDatabase()));
        public decimal valor_total_servico = 0;

        public void confirmarServico(Servico servico, string quant)
        {
            listaServico.Add(servico);

            listViewServicos.Items.Clear();
            foreach (var item in listaServico)
            {
                ListViewItem itemList = new ListViewItem($"{quant} - {item.Nome}");
                itemList.SubItems.Add($"R$ {item.Valor}");

                listViewServicos.Items.Add(itemList);
            }

            painel_pagamento_servico.Visible = true;
            txt_total_servico.Text = $"R$ {valor_total_servico}";
        }

        public void limparVendaServico()
        {
            txt_observacao_servico.Text = "";
            txt_total_servico.Text = $"R$ 0,00";
            listaServico.Clear();
            listViewServicos.Items.Clear();

            rb_dinheiro_servico.Checked = false;
            rb_pix_servico.Checked = false;
            rb_debito_servico.Checked = false;
            rb_credito_servico.Checked = false;

            painel_observacao_servico.Visible = false;
            btn_finalizar_servico.Visible = false;
            painel_pagamento_servico.Visible = false;
        }

        private void rb_dinheiro_servico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_servico = TiposPagamento.Dinheiro;
                painel_observacao_servico.Visible = true;
                btn_finalizar_servico.Visible = true;
            }
        }

        private void rb_pix_servico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_servico = TiposPagamento.Pix;
                painel_observacao_servico.Visible = true;
                btn_finalizar_servico.Visible = true; ;
            }
        }

        private void rb_debito_servico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_servico = TiposPagamento.Debito;
                painel_observacao_servico.Visible = true;
                btn_finalizar_servico.Visible = true;
            }
        }

        private void rb_credito_servico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                tipoPagamento_servico = TiposPagamento.Credito;
                painel_observacao_servico.Visible = true;
                btn_finalizar_servico.Visible = true;
            }
        }

        private void btn_finalizar_servico_Click(object sender, EventArgs e)
        {
            var newVendaServico = new VendaServico()
            {
                TipoPagamento = tipoPagamento_servico,
                Observacao = txt_observacao_servico.Text,
                Servicos = JsonSerializer.Serialize<List<Servico>>(listaServico),
                Total = decimal.Parse(string.Format("{0:#,##0.00}", valor_total_servico))
            };

            var response = servicosVendaServico.Cadastrar(newVendaServico);

            if (response == "Venda finalizada!")
            {
                var result = MessageBox.Show($"Venda do serviço finaliza!", "Tudo certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    limparVendaServico();
                }
            }
            else
            {
                MessageBox.Show($"Algo deu errado", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_show_add_servico_Click(object sender, EventArgs e)
        {
            TelaBlur t = new TelaBlur(this, "selecionar-servico");
            t.ShowDialog();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            var pg_splash = new Splash(this);
            pg_splash.ShowDialog();
        }


    }
}