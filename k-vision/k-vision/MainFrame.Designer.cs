namespace k_vision
{
    partial class MainFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            btn_show_produtos = new ToolStripMenuItem();
            bnt_finalizar_venda = new Button();
            lblClienteVenda = new Label();
            tipBotao = new ToolTip(components);
            btn_show_select_cliente = new Button();
            btn_show_select_produto = new Button();
            btn_show_add_adicional = new Button();
            btn_finalizar_servico = new Button();
            btn_show_add_servico = new Button();
            tipCampo = new ToolTip(components);
            panel1 = new Panel();
            btn_show_prods = new Button();
            btn_show_servicos = new Button();
            btn_show_caixa = new Button();
            bnt_show_clientes = new Button();
            panel2 = new Panel();
            btn_cancelar_produto = new Button();
            panel14 = new Panel();
            txt_total_produto = new Label();
            label13 = new Label();
            label5 = new Label();
            painel_observacao = new Panel();
            panel9 = new Panel();
            label4 = new Label();
            txt_observacao_produto = new TextBox();
            painel_pagamentos = new Panel();
            panel6 = new Panel();
            label7 = new Label();
            rb_credito_produto = new RadioButton();
            rb_debito_produto = new RadioButton();
            rb_pix_produto = new RadioButton();
            rb_dinheiro_produto = new RadioButton();
            painel_produtos = new Panel();
            btn_apagar_adicionais = new Button();
            btn_apagar_produto = new Button();
            panel8 = new Panel();
            label8 = new Label();
            label19 = new Label();
            label18 = new Label();
            listViewAdicionais = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listViewProdutos = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            lblReceitaVenda = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            btn_cancelar_servico = new Button();
            panel11 = new Panel();
            txt_total_servico = new Label();
            label14 = new Label();
            painel_observacao_servico = new Panel();
            panel13 = new Panel();
            label12 = new Label();
            txt_observacao_servico = new TextBox();
            painel_pagamento_servico = new Panel();
            panel12 = new Panel();
            label10 = new Label();
            rb_credito_servico = new RadioButton();
            rb_debito_servico = new RadioButton();
            rb_pix_servico = new RadioButton();
            rb_dinheiro_servico = new RadioButton();
            panel7 = new Panel();
            btn_limpar_servicos = new Button();
            listViewServicos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel10 = new Panel();
            label11 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel14.SuspendLayout();
            painel_observacao.SuspendLayout();
            panel9.SuspendLayout();
            painel_pagamentos.SuspendLayout();
            panel6.SuspendLayout();
            painel_produtos.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            painel_observacao_servico.SuspendLayout();
            panel13.SuspendLayout();
            painel_pagamento_servico.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // btn_show_produtos
            // 
            btn_show_produtos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_produtos.ForeColor = SystemColors.ButtonHighlight;
            btn_show_produtos.Name = "btn_show_produtos";
            btn_show_produtos.Size = new Size(80, 24);
            btn_show_produtos.Text = "Produtos";
            // 
            // bnt_finalizar_venda
            // 
            bnt_finalizar_venda.Anchor = AnchorStyles.Bottom;
            bnt_finalizar_venda.BackColor = Color.LightGray;
            bnt_finalizar_venda.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_finalizar_venda.Cursor = Cursors.Hand;
            bnt_finalizar_venda.Enabled = false;
            bnt_finalizar_venda.FlatAppearance.BorderColor = Color.Gray;
            bnt_finalizar_venda.FlatStyle = FlatStyle.Flat;
            bnt_finalizar_venda.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_finalizar_venda.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_finalizar_venda.Image = (Image)resources.GetObject("bnt_finalizar_venda.Image");
            bnt_finalizar_venda.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_finalizar_venda.Location = new Point(396, 595);
            bnt_finalizar_venda.Name = "bnt_finalizar_venda";
            bnt_finalizar_venda.Size = new Size(108, 29);
            bnt_finalizar_venda.TabIndex = 24;
            bnt_finalizar_venda.Text = "Finalizar";
            bnt_finalizar_venda.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(bnt_finalizar_venda, "Finalizar venda");
            bnt_finalizar_venda.UseVisualStyleBackColor = false;
            bnt_finalizar_venda.Click += bnt_finalizar_venda_Click;
            // 
            // lblClienteVenda
            // 
            lblClienteVenda.AutoSize = true;
            lblClienteVenda.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteVenda.ForeColor = Color.FromArgb(64, 64, 64);
            lblClienteVenda.Location = new Point(67, 31);
            lblClienteVenda.Name = "lblClienteVenda";
            lblClienteVenda.Size = new Size(107, 20);
            lblClienteVenda.TabIndex = 1;
            lblClienteVenda.Text = "Nome cliente";
            // 
            // tipBotao
            // 
            tipBotao.AutomaticDelay = 200;
            tipBotao.Tag = "";
            tipBotao.ToolTipTitle = "Botão";
            // 
            // btn_show_select_cliente
            // 
            btn_show_select_cliente.BackColor = Color.LightGray;
            btn_show_select_cliente.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_select_cliente.Cursor = Cursors.Hand;
            btn_show_select_cliente.FlatAppearance.BorderColor = Color.Gray;
            btn_show_select_cliente.FlatStyle = FlatStyle.Flat;
            btn_show_select_cliente.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_select_cliente.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_select_cliente.Image = (Image)resources.GetObject("btn_show_select_cliente.Image");
            btn_show_select_cliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_select_cliente.Location = new Point(280, 82);
            btn_show_select_cliente.Name = "btn_show_select_cliente";
            btn_show_select_cliente.Size = new Size(114, 28);
            btn_show_select_cliente.TabIndex = 23;
            btn_show_select_cliente.Text = "Adicionar";
            btn_show_select_cliente.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(btn_show_select_cliente, "Incluir adicional na lista de itens");
            btn_show_select_cliente.UseVisualStyleBackColor = false;
            btn_show_select_cliente.Click += btn_show_select_cliente_Click;
            // 
            // btn_show_select_produto
            // 
            btn_show_select_produto.BackColor = Color.LightGray;
            btn_show_select_produto.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_select_produto.Cursor = Cursors.Hand;
            btn_show_select_produto.FlatAppearance.BorderColor = Color.Gray;
            btn_show_select_produto.FlatStyle = FlatStyle.Flat;
            btn_show_select_produto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_select_produto.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_select_produto.Image = (Image)resources.GetObject("btn_show_select_produto.Image");
            btn_show_select_produto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_select_produto.Location = new Point(203, 239);
            btn_show_select_produto.Name = "btn_show_select_produto";
            btn_show_select_produto.Size = new Size(121, 28);
            btn_show_select_produto.TabIndex = 23;
            btn_show_select_produto.Text = "Adicionar";
            btn_show_select_produto.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(btn_show_select_produto, "Incluir adicional na lista de itens");
            btn_show_select_produto.UseVisualStyleBackColor = false;
            btn_show_select_produto.Click += btn_show_select_produto_Click;
            // 
            // btn_show_add_adicional
            // 
            btn_show_add_adicional.BackColor = Color.LightGray;
            btn_show_add_adicional.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_add_adicional.Cursor = Cursors.Hand;
            btn_show_add_adicional.FlatAppearance.BorderColor = Color.Gray;
            btn_show_add_adicional.FlatStyle = FlatStyle.Flat;
            btn_show_add_adicional.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_add_adicional.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_add_adicional.Image = (Image)resources.GetObject("btn_show_add_adicional.Image");
            btn_show_add_adicional.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_add_adicional.Location = new Point(525, 238);
            btn_show_add_adicional.Name = "btn_show_add_adicional";
            btn_show_add_adicional.Size = new Size(122, 28);
            btn_show_add_adicional.TabIndex = 29;
            btn_show_add_adicional.Text = "Adicionar";
            btn_show_add_adicional.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(btn_show_add_adicional, "Incluir adicional na lista de itens");
            btn_show_add_adicional.UseVisualStyleBackColor = false;
            btn_show_add_adicional.Click += btn_show_add_adicional_Click;
            // 
            // btn_finalizar_servico
            // 
            btn_finalizar_servico.Anchor = AnchorStyles.Bottom;
            btn_finalizar_servico.BackColor = Color.LightGray;
            btn_finalizar_servico.BackgroundImageLayout = ImageLayout.Stretch;
            btn_finalizar_servico.Cursor = Cursors.Hand;
            btn_finalizar_servico.Enabled = false;
            btn_finalizar_servico.FlatAppearance.BorderColor = Color.Gray;
            btn_finalizar_servico.FlatStyle = FlatStyle.Flat;
            btn_finalizar_servico.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_finalizar_servico.ForeColor = Color.FromArgb(64, 64, 64);
            btn_finalizar_servico.Image = (Image)resources.GetObject("btn_finalizar_servico.Image");
            btn_finalizar_servico.ImageAlign = ContentAlignment.MiddleLeft;
            btn_finalizar_servico.Location = new Point(224, 592);
            btn_finalizar_servico.Name = "btn_finalizar_servico";
            btn_finalizar_servico.Size = new Size(108, 29);
            btn_finalizar_servico.TabIndex = 27;
            btn_finalizar_servico.Text = "Finalizar venda serviço";
            btn_finalizar_servico.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(btn_finalizar_servico, "Finalizar venda");
            btn_finalizar_servico.UseVisualStyleBackColor = false;
            btn_finalizar_servico.Click += btn_finalizar_servico_Click;
            // 
            // btn_show_add_servico
            // 
            btn_show_add_servico.BackColor = Color.LightGray;
            btn_show_add_servico.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_add_servico.Cursor = Cursors.Hand;
            btn_show_add_servico.FlatAppearance.BorderColor = Color.Gray;
            btn_show_add_servico.FlatStyle = FlatStyle.Flat;
            btn_show_add_servico.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_add_servico.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_add_servico.Image = (Image)resources.GetObject("btn_show_add_servico.Image");
            btn_show_add_servico.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_add_servico.Location = new Point(207, 185);
            btn_show_add_servico.Name = "btn_show_add_servico";
            btn_show_add_servico.Size = new Size(118, 28);
            btn_show_add_servico.TabIndex = 30;
            btn_show_add_servico.Text = "Adicionar";
            btn_show_add_servico.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(btn_show_add_servico, "Incluir adicional na lista de itens");
            btn_show_add_servico.UseVisualStyleBackColor = false;
            btn_show_add_servico.Click += btn_show_add_servico_Click;
            // 
            // tipCampo
            // 
            tipCampo.AutomaticDelay = 200;
            tipCampo.ToolTipTitle = "Campo";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btn_show_prods);
            panel1.Controls.Add(btn_show_servicos);
            panel1.Controls.Add(btn_show_caixa);
            panel1.Controls.Add(bnt_show_clientes);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 45);
            panel1.TabIndex = 10;
            // 
            // btn_show_prods
            // 
            btn_show_prods.BackColor = SystemColors.ControlLight;
            btn_show_prods.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_prods.Cursor = Cursors.Hand;
            btn_show_prods.FlatAppearance.BorderColor = Color.Gray;
            btn_show_prods.FlatStyle = FlatStyle.Flat;
            btn_show_prods.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_prods.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_prods.Image = (Image)resources.GetObject("btn_show_prods.Image");
            btn_show_prods.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_prods.Location = new Point(121, 6);
            btn_show_prods.Name = "btn_show_prods";
            btn_show_prods.Size = new Size(112, 33);
            btn_show_prods.TabIndex = 17;
            btn_show_prods.Text = "Produtos";
            btn_show_prods.TextAlign = ContentAlignment.MiddleRight;
            btn_show_prods.UseVisualStyleBackColor = false;
            btn_show_prods.Click += btn_show_prods_Click;
            // 
            // btn_show_servicos
            // 
            btn_show_servicos.BackColor = SystemColors.ControlLight;
            btn_show_servicos.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_servicos.Cursor = Cursors.Hand;
            btn_show_servicos.FlatAppearance.BorderColor = Color.Gray;
            btn_show_servicos.FlatStyle = FlatStyle.Flat;
            btn_show_servicos.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_servicos.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_servicos.Image = (Image)resources.GetObject("btn_show_servicos.Image");
            btn_show_servicos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_servicos.Location = new Point(240, 6);
            btn_show_servicos.Name = "btn_show_servicos";
            btn_show_servicos.Size = new Size(112, 33);
            btn_show_servicos.TabIndex = 16;
            btn_show_servicos.Text = "Serviços";
            btn_show_servicos.TextAlign = ContentAlignment.MiddleRight;
            btn_show_servicos.UseVisualStyleBackColor = false;
            btn_show_servicos.Click += btn_show_servicos_Click;
            // 
            // btn_show_caixa
            // 
            btn_show_caixa.BackColor = SystemColors.ControlLight;
            btn_show_caixa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_caixa.Cursor = Cursors.Hand;
            btn_show_caixa.FlatAppearance.BorderColor = Color.Gray;
            btn_show_caixa.FlatStyle = FlatStyle.Flat;
            btn_show_caixa.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_caixa.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_caixa.Image = (Image)resources.GetObject("btn_show_caixa.Image");
            btn_show_caixa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_caixa.Location = new Point(360, 6);
            btn_show_caixa.Name = "btn_show_caixa";
            btn_show_caixa.Size = new Size(112, 33);
            btn_show_caixa.TabIndex = 15;
            btn_show_caixa.Text = "Caixa";
            btn_show_caixa.TextAlign = ContentAlignment.MiddleRight;
            btn_show_caixa.UseVisualStyleBackColor = false;
            btn_show_caixa.Click += btn_show_caixa_Click;
            // 
            // bnt_show_clientes
            // 
            bnt_show_clientes.BackColor = SystemColors.ControlLight;
            bnt_show_clientes.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_show_clientes.Cursor = Cursors.Hand;
            bnt_show_clientes.FlatAppearance.BorderColor = Color.Gray;
            bnt_show_clientes.FlatStyle = FlatStyle.Flat;
            bnt_show_clientes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_show_clientes.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_show_clientes.Image = (Image)resources.GetObject("bnt_show_clientes.Image");
            bnt_show_clientes.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_show_clientes.Location = new Point(3, 6);
            bnt_show_clientes.Name = "bnt_show_clientes";
            bnt_show_clientes.Size = new Size(112, 33);
            bnt_show_clientes.TabIndex = 0;
            bnt_show_clientes.Text = "Clientes";
            bnt_show_clientes.TextAlign = ContentAlignment.MiddleRight;
            bnt_show_clientes.UseVisualStyleBackColor = false;
            bnt_show_clientes.Click += bnt_show_clientes_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_cancelar_produto);
            panel2.Controls.Add(panel14);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(bnt_finalizar_venda);
            panel2.Controls.Add(painel_observacao);
            panel2.Controls.Add(painel_pagamentos);
            panel2.Controls.Add(painel_produtos);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(4, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 629);
            panel2.TabIndex = 14;
            // 
            // btn_cancelar_produto
            // 
            btn_cancelar_produto.Anchor = AnchorStyles.Bottom;
            btn_cancelar_produto.BackColor = Color.LightGray;
            btn_cancelar_produto.BackgroundImageLayout = ImageLayout.Stretch;
            btn_cancelar_produto.Cursor = Cursors.Hand;
            btn_cancelar_produto.FlatAppearance.BorderColor = Color.Gray;
            btn_cancelar_produto.FlatStyle = FlatStyle.Flat;
            btn_cancelar_produto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar_produto.ForeColor = Color.FromArgb(64, 64, 64);
            btn_cancelar_produto.Image = (Image)resources.GetObject("btn_cancelar_produto.Image");
            btn_cancelar_produto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancelar_produto.Location = new Point(148, 596);
            btn_cancelar_produto.Name = "btn_cancelar_produto";
            btn_cancelar_produto.Size = new Size(128, 28);
            btn_cancelar_produto.TabIndex = 35;
            btn_cancelar_produto.Text = "Cancelar";
            btn_cancelar_produto.TextAlign = ContentAlignment.MiddleRight;
            btn_cancelar_produto.UseVisualStyleBackColor = false;
            btn_cancelar_produto.Click += btn_cancelar_produto_Click;
            // 
            // panel14
            // 
            panel14.BackColor = Color.RoyalBlue;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(txt_total_produto);
            panel14.Controls.Add(label13);
            panel14.Location = new Point(5, 563);
            panel14.Name = "panel14";
            panel14.Size = new Size(652, 27);
            panel14.TabIndex = 30;
            // 
            // txt_total_produto
            // 
            txt_total_produto.AutoSize = true;
            txt_total_produto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_total_produto.ForeColor = Color.WhiteSmoke;
            txt_total_produto.Location = new Point(303, 3);
            txt_total_produto.Name = "txt_total_produto";
            txt_total_produto.Size = new Size(61, 18);
            txt_total_produto.TabIndex = 31;
            txt_total_produto.Text = "R$  0,00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(2, 3);
            label13.Name = "label13";
            label13.Size = new Size(46, 18);
            label13.TabIndex = 29;
            label13.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(295, 2);
            label5.Name = "label5";
            label5.Size = new Size(145, 19);
            label5.TabIndex = 25;
            label5.Text = "Vender produtos";
            // 
            // painel_observacao
            // 
            painel_observacao.BackColor = Color.FromArgb(229, 229, 229);
            painel_observacao.BorderStyle = BorderStyle.FixedSingle;
            painel_observacao.Controls.Add(panel9);
            painel_observacao.Controls.Add(txt_observacao_produto);
            painel_observacao.Location = new Point(5, 496);
            painel_observacao.Name = "painel_observacao";
            painel_observacao.Size = new Size(653, 63);
            painel_observacao.TabIndex = 26;
            painel_observacao.Visible = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.RoyalBlue;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label4);
            panel9.Location = new Point(-1, -1);
            panel9.Name = "panel9";
            panel9.Size = new Size(668, 27);
            panel9.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(297, 3);
            label4.Name = "label4";
            label4.Size = new Size(100, 18);
            label4.TabIndex = 29;
            label4.Text = "Observação";
            // 
            // txt_observacao_produto
            // 
            txt_observacao_produto.BorderStyle = BorderStyle.FixedSingle;
            txt_observacao_produto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacao_produto.ForeColor = Color.FromArgb(64, 64, 64);
            txt_observacao_produto.Location = new Point(7, 31);
            txt_observacao_produto.Name = "txt_observacao_produto";
            txt_observacao_produto.Size = new Size(639, 27);
            txt_observacao_produto.TabIndex = 26;
            // 
            // painel_pagamentos
            // 
            painel_pagamentos.BackColor = Color.FromArgb(229, 229, 229);
            painel_pagamentos.BorderStyle = BorderStyle.FixedSingle;
            painel_pagamentos.Controls.Add(panel6);
            painel_pagamentos.Controls.Add(rb_credito_produto);
            painel_pagamentos.Controls.Add(rb_debito_produto);
            painel_pagamentos.Controls.Add(rb_pix_produto);
            painel_pagamentos.Controls.Add(rb_dinheiro_produto);
            painel_pagamentos.Location = new Point(4, 148);
            painel_pagamentos.Name = "painel_pagamentos";
            painel_pagamentos.Size = new Size(653, 61);
            painel_pagamentos.TabIndex = 26;
            painel_pagamentos.Visible = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.RoyalBlue;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label7);
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(670, 27);
            panel6.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(255, 3);
            label7.Name = "label7";
            label7.Size = new Size(169, 18);
            label7.TabIndex = 27;
            label7.Text = "Forma de pagamento";
            // 
            // rb_credito_produto
            // 
            rb_credito_produto.AutoSize = true;
            rb_credito_produto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_credito_produto.ForeColor = Color.FromArgb(64, 64, 64);
            rb_credito_produto.Location = new Point(443, 31);
            rb_credito_produto.Name = "rb_credito_produto";
            rb_credito_produto.Size = new Size(75, 21);
            rb_credito_produto.TabIndex = 6;
            rb_credito_produto.Text = "Crédito";
            rb_credito_produto.UseVisualStyleBackColor = true;
            rb_credito_produto.CheckedChanged += rb_credito_produto_CheckedChanged;
            // 
            // rb_debito_produto
            // 
            rb_debito_produto.AutoSize = true;
            rb_debito_produto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_debito_produto.ForeColor = Color.FromArgb(64, 64, 64);
            rb_debito_produto.Location = new Point(337, 31);
            rb_debito_produto.Name = "rb_debito_produto";
            rb_debito_produto.Size = new Size(70, 21);
            rb_debito_produto.TabIndex = 5;
            rb_debito_produto.Text = "Débito";
            rb_debito_produto.UseVisualStyleBackColor = true;
            rb_debito_produto.CheckedChanged += rb_debito_produto_CheckedChanged;
            // 
            // rb_pix_produto
            // 
            rb_pix_produto.AutoSize = true;
            rb_pix_produto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_pix_produto.ForeColor = Color.FromArgb(64, 64, 64);
            rb_pix_produto.Location = new Point(256, 31);
            rb_pix_produto.Name = "rb_pix_produto";
            rb_pix_produto.Size = new Size(43, 21);
            rb_pix_produto.TabIndex = 4;
            rb_pix_produto.Text = "Pix";
            rb_pix_produto.UseVisualStyleBackColor = true;
            rb_pix_produto.CheckedChanged += rb_pix_produto_CheckedChanged;
            // 
            // rb_dinheiro_produto
            // 
            rb_dinheiro_produto.AutoSize = true;
            rb_dinheiro_produto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_dinheiro_produto.ForeColor = Color.FromArgb(64, 64, 64);
            rb_dinheiro_produto.Location = new Point(144, 31);
            rb_dinheiro_produto.Name = "rb_dinheiro_produto";
            rb_dinheiro_produto.Size = new Size(79, 21);
            rb_dinheiro_produto.TabIndex = 3;
            rb_dinheiro_produto.Text = "Dinheiro";
            rb_dinheiro_produto.UseVisualStyleBackColor = true;
            rb_dinheiro_produto.CheckedChanged += rb_dinheiro_produto_CheckedChanged;
            // 
            // painel_produtos
            // 
            painel_produtos.BackColor = Color.FromArgb(229, 229, 229);
            painel_produtos.BorderStyle = BorderStyle.FixedSingle;
            painel_produtos.Controls.Add(btn_apagar_adicionais);
            painel_produtos.Controls.Add(btn_apagar_produto);
            painel_produtos.Controls.Add(panel8);
            painel_produtos.Controls.Add(btn_show_add_adicional);
            painel_produtos.Controls.Add(label19);
            painel_produtos.Controls.Add(label18);
            painel_produtos.Controls.Add(listViewAdicionais);
            painel_produtos.Controls.Add(listViewProdutos);
            painel_produtos.Controls.Add(btn_show_select_produto);
            painel_produtos.Location = new Point(4, 214);
            painel_produtos.Name = "painel_produtos";
            painel_produtos.Size = new Size(653, 276);
            painel_produtos.TabIndex = 26;
            painel_produtos.Visible = false;
            // 
            // btn_apagar_adicionais
            // 
            btn_apagar_adicionais.BackColor = Color.LightGray;
            btn_apagar_adicionais.BackgroundImageLayout = ImageLayout.Stretch;
            btn_apagar_adicionais.Cursor = Cursors.Hand;
            btn_apagar_adicionais.FlatAppearance.BorderColor = Color.Gray;
            btn_apagar_adicionais.FlatStyle = FlatStyle.Flat;
            btn_apagar_adicionais.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_apagar_adicionais.ForeColor = Color.FromArgb(64, 64, 64);
            btn_apagar_adicionais.Image = (Image)resources.GetObject("btn_apagar_adicionais.Image");
            btn_apagar_adicionais.ImageAlign = ContentAlignment.MiddleLeft;
            btn_apagar_adicionais.Location = new Point(328, 238);
            btn_apagar_adicionais.Name = "btn_apagar_adicionais";
            btn_apagar_adicionais.Size = new Size(125, 28);
            btn_apagar_adicionais.TabIndex = 32;
            btn_apagar_adicionais.Text = "Limpar lista";
            btn_apagar_adicionais.TextAlign = ContentAlignment.MiddleRight;
            btn_apagar_adicionais.UseVisualStyleBackColor = false;
            btn_apagar_adicionais.Click += btn_apagar_adicionais_Click;
            // 
            // btn_apagar_produto
            // 
            btn_apagar_produto.BackColor = Color.LightGray;
            btn_apagar_produto.BackgroundImageLayout = ImageLayout.Stretch;
            btn_apagar_produto.Cursor = Cursors.Hand;
            btn_apagar_produto.FlatAppearance.BorderColor = Color.Gray;
            btn_apagar_produto.FlatStyle = FlatStyle.Flat;
            btn_apagar_produto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_apagar_produto.ForeColor = Color.FromArgb(64, 64, 64);
            btn_apagar_produto.Image = (Image)resources.GetObject("btn_apagar_produto.Image");
            btn_apagar_produto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_apagar_produto.Location = new Point(5, 239);
            btn_apagar_produto.Name = "btn_apagar_produto";
            btn_apagar_produto.Size = new Size(126, 28);
            btn_apagar_produto.TabIndex = 31;
            btn_apagar_produto.Text = "Limpar lista";
            btn_apagar_produto.TextAlign = ContentAlignment.MiddleRight;
            btn_apagar_produto.UseVisualStyleBackColor = false;
            btn_apagar_produto.Click += btn_apagar_produto_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.RoyalBlue;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label8);
            panel8.Location = new Point(-1, -1);
            panel8.Name = "panel8";
            panel8.Size = new Size(668, 27);
            panel8.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(255, 4);
            label8.Name = "label8";
            label8.Size = new Size(165, 18);
            label8.TabIndex = 28;
            label8.Text = "Produtos e adicionais";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(442, 31);
            label19.Name = "label19";
            label19.Size = new Size(78, 20);
            label19.TabIndex = 26;
            label19.Text = "Adicionais";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(64, 64, 64);
            label18.Location = new Point(115, 31);
            label18.Name = "label18";
            label18.Size = new Size(68, 20);
            label18.TabIndex = 25;
            label18.Text = "Produtos";
            // 
            // listViewAdicionais
            // 
            listViewAdicionais.BackColor = Color.FromArgb(229, 229, 229);
            listViewAdicionais.BorderStyle = BorderStyle.FixedSingle;
            listViewAdicionais.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            listViewAdicionais.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listViewAdicionais.ForeColor = Color.FromArgb(64, 64, 64);
            listViewAdicionais.FullRowSelect = true;
            listViewAdicionais.HeaderStyle = ColumnHeaderStyle.None;
            listViewAdicionais.Location = new Point(328, 54);
            listViewAdicionais.Name = "listViewAdicionais";
            listViewAdicionais.Size = new Size(319, 178);
            listViewAdicionais.TabIndex = 24;
            listViewAdicionais.UseCompatibleStateImageBehavior = false;
            listViewAdicionais.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nome";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Valor";
            columnHeader6.TextAlign = HorizontalAlignment.Right;
            columnHeader6.Width = 98;
            // 
            // listViewProdutos
            // 
            listViewProdutos.BackColor = Color.FromArgb(229, 229, 229);
            listViewProdutos.BorderStyle = BorderStyle.FixedSingle;
            listViewProdutos.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listViewProdutos.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listViewProdutos.ForeColor = Color.FromArgb(64, 64, 64);
            listViewProdutos.FullRowSelect = true;
            listViewProdutos.HeaderStyle = ColumnHeaderStyle.None;
            listViewProdutos.Location = new Point(4, 54);
            listViewProdutos.Name = "listViewProdutos";
            listViewProdutos.Size = new Size(319, 178);
            listViewProdutos.TabIndex = 19;
            listViewProdutos.UseCompatibleStateImageBehavior = false;
            listViewProdutos.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nome";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Valor";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 98;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(229, 229, 229);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lblReceitaVenda);
            panel3.Controls.Add(lblClienteVenda);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btn_show_select_cliente);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(4, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(653, 116);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label6);
            panel5.Location = new Point(-1, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(668, 27);
            panel5.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(274, 3);
            label6.Name = "label6";
            label6.Size = new Size(132, 18);
            label6.TabIndex = 26;
            label6.Text = "Cliente e receita";
            // 
            // lblReceitaVenda
            // 
            lblReceitaVenda.AutoSize = true;
            lblReceitaVenda.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblReceitaVenda.ForeColor = Color.FromArgb(64, 64, 64);
            lblReceitaVenda.Location = new Point(72, 57);
            lblReceitaVenda.Name = "lblReceitaVenda";
            lblReceitaVenda.Size = new Size(66, 20);
            lblReceitaVenda.TabIndex = 24;
            lblReceitaVenda.Text = "Receita";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(5, 57);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 3;
            label3.Text = "Receita:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(5, 31);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.LightGray;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btn_cancelar_servico);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(btn_finalizar_servico);
            panel4.Controls.Add(painel_observacao_servico);
            panel4.Controls.Add(painel_pagamento_servico);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(880, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(340, 629);
            panel4.TabIndex = 15;
            // 
            // btn_cancelar_servico
            // 
            btn_cancelar_servico.Anchor = AnchorStyles.Bottom;
            btn_cancelar_servico.BackColor = Color.LightGray;
            btn_cancelar_servico.BackgroundImageLayout = ImageLayout.Stretch;
            btn_cancelar_servico.Cursor = Cursors.Hand;
            btn_cancelar_servico.FlatAppearance.BorderColor = Color.Gray;
            btn_cancelar_servico.FlatStyle = FlatStyle.Flat;
            btn_cancelar_servico.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar_servico.ForeColor = Color.FromArgb(64, 64, 64);
            btn_cancelar_servico.Image = (Image)resources.GetObject("btn_cancelar_servico.Image");
            btn_cancelar_servico.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancelar_servico.Location = new Point(8, 594);
            btn_cancelar_servico.Name = "btn_cancelar_servico";
            btn_cancelar_servico.Size = new Size(128, 28);
            btn_cancelar_servico.TabIndex = 34;
            btn_cancelar_servico.Text = "Cancelar";
            btn_cancelar_servico.TextAlign = ContentAlignment.MiddleRight;
            btn_cancelar_servico.UseVisualStyleBackColor = false;
            btn_cancelar_servico.Click += btn_cancelar_servico_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.OrangeRed;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(txt_total_servico);
            panel11.Controls.Add(label14);
            panel11.Location = new Point(5, 459);
            panel11.Name = "panel11";
            panel11.Size = new Size(330, 27);
            panel11.TabIndex = 32;
            // 
            // txt_total_servico
            // 
            txt_total_servico.AutoSize = true;
            txt_total_servico.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_total_servico.ForeColor = Color.WhiteSmoke;
            txt_total_servico.Location = new Point(149, 2);
            txt_total_servico.Name = "txt_total_servico";
            txt_total_servico.Size = new Size(61, 18);
            txt_total_servico.TabIndex = 30;
            txt_total_servico.Text = "R$  0,00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(46, 18);
            label14.TabIndex = 29;
            label14.Text = "Total:";
            // 
            // painel_observacao_servico
            // 
            painel_observacao_servico.BackColor = Color.FromArgb(229, 229, 229);
            painel_observacao_servico.BorderStyle = BorderStyle.FixedSingle;
            painel_observacao_servico.Controls.Add(panel13);
            painel_observacao_servico.Controls.Add(txt_observacao_servico);
            painel_observacao_servico.Location = new Point(4, 362);
            painel_observacao_servico.Name = "painel_observacao_servico";
            painel_observacao_servico.Size = new Size(331, 88);
            painel_observacao_servico.TabIndex = 31;
            painel_observacao_servico.Visible = false;
            // 
            // panel13
            // 
            panel13.BackColor = Color.OrangeRed;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(label12);
            panel13.Location = new Point(-1, -1);
            panel13.Name = "panel13";
            panel13.Size = new Size(343, 27);
            panel13.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(128, 1);
            label12.Name = "label12";
            label12.Size = new Size(100, 18);
            label12.TabIndex = 29;
            label12.Text = "Observação";
            // 
            // txt_observacao_servico
            // 
            txt_observacao_servico.BorderStyle = BorderStyle.FixedSingle;
            txt_observacao_servico.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacao_servico.ForeColor = Color.FromArgb(64, 64, 64);
            txt_observacao_servico.Location = new Point(6, 30);
            txt_observacao_servico.Multiline = true;
            txt_observacao_servico.Name = "txt_observacao_servico";
            txt_observacao_servico.Size = new Size(317, 52);
            txt_observacao_servico.TabIndex = 26;
            // 
            // painel_pagamento_servico
            // 
            painel_pagamento_servico.BackColor = Color.FromArgb(229, 229, 229);
            painel_pagamento_servico.BorderStyle = BorderStyle.FixedSingle;
            painel_pagamento_servico.Controls.Add(panel12);
            painel_pagamento_servico.Controls.Add(rb_credito_servico);
            painel_pagamento_servico.Controls.Add(rb_debito_servico);
            painel_pagamento_servico.Controls.Add(rb_pix_servico);
            painel_pagamento_servico.Controls.Add(rb_dinheiro_servico);
            painel_pagamento_servico.Location = new Point(3, 282);
            painel_pagamento_servico.Name = "painel_pagamento_servico";
            painel_pagamento_servico.Size = new Size(332, 67);
            painel_pagamento_servico.TabIndex = 29;
            painel_pagamento_servico.Visible = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.OrangeRed;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(label10);
            panel12.Location = new Point(-1, -1);
            panel12.Name = "panel12";
            panel12.Size = new Size(331, 27);
            panel12.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(93, 3);
            label10.Name = "label10";
            label10.Size = new Size(169, 18);
            label10.TabIndex = 27;
            label10.Text = "Forma de pagamento";
            // 
            // rb_credito_servico
            // 
            rb_credito_servico.AutoSize = true;
            rb_credito_servico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_credito_servico.ForeColor = Color.FromArgb(64, 64, 64);
            rb_credito_servico.Location = new Point(250, 37);
            rb_credito_servico.Name = "rb_credito_servico";
            rb_credito_servico.Size = new Size(75, 21);
            rb_credito_servico.TabIndex = 6;
            rb_credito_servico.Text = "Crédito";
            rb_credito_servico.UseVisualStyleBackColor = true;
            rb_credito_servico.CheckedChanged += rb_credito_servico_CheckedChanged;
            // 
            // rb_debito_servico
            // 
            rb_debito_servico.AutoSize = true;
            rb_debito_servico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_debito_servico.ForeColor = Color.FromArgb(64, 64, 64);
            rb_debito_servico.Location = new Point(165, 38);
            rb_debito_servico.Name = "rb_debito_servico";
            rb_debito_servico.Size = new Size(70, 21);
            rb_debito_servico.TabIndex = 5;
            rb_debito_servico.Text = "Débito";
            rb_debito_servico.UseVisualStyleBackColor = true;
            rb_debito_servico.CheckedChanged += rb_debito_servico_CheckedChanged;
            // 
            // rb_pix_servico
            // 
            rb_pix_servico.AutoSize = true;
            rb_pix_servico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_pix_servico.ForeColor = Color.FromArgb(64, 64, 64);
            rb_pix_servico.Location = new Point(102, 38);
            rb_pix_servico.Name = "rb_pix_servico";
            rb_pix_servico.Size = new Size(43, 21);
            rb_pix_servico.TabIndex = 4;
            rb_pix_servico.Text = "Pix";
            rb_pix_servico.UseVisualStyleBackColor = true;
            rb_pix_servico.CheckedChanged += rb_pix_servico_CheckedChanged;
            // 
            // rb_dinheiro_servico
            // 
            rb_dinheiro_servico.AutoSize = true;
            rb_dinheiro_servico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_dinheiro_servico.ForeColor = Color.FromArgb(64, 64, 64);
            rb_dinheiro_servico.Location = new Point(7, 38);
            rb_dinheiro_servico.Name = "rb_dinheiro_servico";
            rb_dinheiro_servico.Size = new Size(79, 21);
            rb_dinheiro_servico.TabIndex = 3;
            rb_dinheiro_servico.Text = "Dinheiro";
            rb_dinheiro_servico.UseVisualStyleBackColor = true;
            rb_dinheiro_servico.CheckedChanged += rb_dinheiro_servico_CheckedChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(229, 229, 229);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btn_limpar_servicos);
            panel7.Controls.Add(btn_show_add_servico);
            panel7.Controls.Add(listViewServicos);
            panel7.Controls.Add(panel10);
            panel7.Location = new Point(3, 45);
            panel7.Name = "panel7";
            panel7.Size = new Size(333, 221);
            panel7.TabIndex = 28;
            // 
            // btn_limpar_servicos
            // 
            btn_limpar_servicos.BackColor = Color.LightGray;
            btn_limpar_servicos.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpar_servicos.Cursor = Cursors.Hand;
            btn_limpar_servicos.Enabled = false;
            btn_limpar_servicos.FlatAppearance.BorderColor = Color.Gray;
            btn_limpar_servicos.FlatStyle = FlatStyle.Flat;
            btn_limpar_servicos.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpar_servicos.ForeColor = Color.FromArgb(64, 64, 64);
            btn_limpar_servicos.Image = (Image)resources.GetObject("btn_limpar_servicos.Image");
            btn_limpar_servicos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar_servicos.Location = new Point(6, 185);
            btn_limpar_servicos.Name = "btn_limpar_servicos";
            btn_limpar_servicos.Size = new Size(128, 28);
            btn_limpar_servicos.TabIndex = 33;
            btn_limpar_servicos.Text = "Limpar lista";
            btn_limpar_servicos.TextAlign = ContentAlignment.MiddleRight;
            btn_limpar_servicos.UseVisualStyleBackColor = false;
            btn_limpar_servicos.Click += btn_limpar_servicos_Click;
            // 
            // listViewServicos
            // 
            listViewServicos.BackColor = Color.FromArgb(229, 229, 229);
            listViewServicos.BorderStyle = BorderStyle.None;
            listViewServicos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewServicos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listViewServicos.ForeColor = Color.FromArgb(64, 64, 64);
            listViewServicos.FullRowSelect = true;
            listViewServicos.HeaderStyle = ColumnHeaderStyle.None;
            listViewServicos.Location = new Point(6, 32);
            listViewServicos.Name = "listViewServicos";
            listViewServicos.Size = new Size(319, 141);
            listViewServicos.TabIndex = 30;
            listViewServicos.UseCompatibleStateImageBehavior = false;
            listViewServicos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Valor";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 98;
            // 
            // panel10
            // 
            panel10.BackColor = Color.OrangeRed;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label11);
            panel10.Location = new Point(-1, -1);
            panel10.Name = "panel10";
            panel10.Size = new Size(333, 27);
            panel10.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(132, 3);
            label11.Name = "label11";
            label11.Size = new Size(69, 18);
            label11.TabIndex = 26;
            label11.Text = "Serviços";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(103, -1);
            label9.Name = "label9";
            label9.Size = new Size(138, 25);
            label9.TabIndex = 27;
            label9.Text = "Vender serviço";
            // 
            // MainFrame
            // 
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1224, 687);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Name = "MainFrame";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "k-vision";
            WindowState = FormWindowState.Maximized;
            Load += MainFrame_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            painel_observacao.ResumeLayout(false);
            painel_observacao.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            painel_pagamentos.ResumeLayout(false);
            painel_pagamentos.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            painel_produtos.ResumeLayout(false);
            painel_produtos.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            painel_observacao_servico.ResumeLayout(false);
            painel_observacao_servico.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            painel_pagamento_servico.ResumeLayout(false);
            painel_pagamento_servico.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem clienteToolStripMenuItem;
        private Button btn_show_clientes;
        private Button btn_show_produto;
        private ToolTip tipBotao;
        private ToolTip tipCampo;
        private Label lblClienteVenda;
        private ColumnHeader NomeProduto;
        private Button bnt_finalizar_venda;
        private Panel panel1;
        private Button btn_show_servicos;
        private Button bnt_show_clientes;
        private Button btn_show_caixa;
        private Panel panel2;
        private Panel panel3;
        private Label lblReceitaVenda;
        private Label label3;
        private Button btn_show_select_cliente;
        private Label label2;
        private Panel painel_produtos;
        private Label label19;
        private Label label18;
        private ListView listViewAdicionais;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listViewProdutos;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btn_show_select_produto;
        private Panel painel_observacao;
        private TextBox txt_observacao_produto;
        private Panel painel_pagamentos;
        private RadioButton rb_credito_produto;
        private RadioButton rb_debito_produto;
        private RadioButton rb_pix_produto;
        private RadioButton rb_dinheiro_produto;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label6;
        private Panel panel4;
        private Label label4;
        private Panel panel7;
        private Label label9;
        private Button btn_show_add_adicional;
        private ToolStripMenuItem btn_show_produtos;
        private Button btn_show_prods;
        private Panel panel9;
        private Panel panel6;
        private Panel panel8;
        private Panel panel5;
        private Panel panel10;
        private Label label11;
        private Panel painel_pagamento_servico;
        private Panel panel12;
        private Label label10;
        private RadioButton rb_credito_servico;
        private RadioButton rb_debito_servico;
        private RadioButton rb_pix_servico;
        private RadioButton rb_dinheiro_servico;
        private Panel painel_observacao_servico;
        private Panel panel13;
        private Label label12;
        private TextBox txt_observacao_servico;
        private Button btn_finalizar_servico;
        private Button btn_show_add_servico;
        private ListView listViewServicos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel14;
        private Label label13;
        private Panel panel11;
        private Label label14;
        private Label txt_total_produto;
        private Label txt_total_servico;
        private Button btn_apagar_produto;
        private Button btn_apagar_adicionais;
        private Button btn_limpar_servicos;
        private Button btn_cancelar_servico;
        private Button btn_cancelar_produto;
    }
}