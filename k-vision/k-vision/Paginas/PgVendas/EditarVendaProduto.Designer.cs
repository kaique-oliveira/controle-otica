namespace Kvision.Frame.Paginas.PgVendas
{
    partial class EditarVendaProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarVendaProduto));
            panel2 = new Panel();
            panel14 = new Panel();
            txt_total_produto = new Label();
            label13 = new Label();
            bnt_finalizar_venda = new Button();
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
            btn_show_add_adicional = new Button();
            label19 = new Label();
            label18 = new Label();
            listViewAdicionais = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listViewProdutos = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btn_show_select_produto = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            lblReceitaVenda = new Label();
            lblClienteVenda = new Label();
            label3 = new Label();
            btn_show_select_cliente = new Button();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_fechar = new Button();
            label1 = new Label();
            btn_salvar_edicao = new Button();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel14);
            panel2.Controls.Add(bnt_finalizar_venda);
            panel2.Controls.Add(painel_observacao);
            panel2.Controls.Add(painel_pagamentos);
            panel2.Controls.Add(painel_produtos);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(13, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 613);
            panel2.TabIndex = 15;
            // 
            // panel14
            // 
            panel14.BackColor = Color.RoyalBlue;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(txt_total_produto);
            panel14.Controls.Add(label13);
            panel14.Location = new Point(21, 570);
            panel14.Name = "panel14";
            panel14.Size = new Size(668, 27);
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
            // bnt_finalizar_venda
            // 
            bnt_finalizar_venda.Anchor = AnchorStyles.Bottom;
            bnt_finalizar_venda.BackColor = Color.LightGray;
            bnt_finalizar_venda.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_finalizar_venda.Cursor = Cursors.Hand;
            bnt_finalizar_venda.FlatAppearance.BorderColor = Color.Gray;
            bnt_finalizar_venda.FlatStyle = FlatStyle.Flat;
            bnt_finalizar_venda.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_finalizar_venda.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_finalizar_venda.Image = (Image)resources.GetObject("bnt_finalizar_venda.Image");
            bnt_finalizar_venda.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_finalizar_venda.Location = new Point(554, 1399);
            bnt_finalizar_venda.Name = "bnt_finalizar_venda";
            bnt_finalizar_venda.Size = new Size(108, 29);
            bnt_finalizar_venda.TabIndex = 24;
            bnt_finalizar_venda.Text = "Finalizar";
            bnt_finalizar_venda.TextAlign = ContentAlignment.MiddleRight;
            bnt_finalizar_venda.UseVisualStyleBackColor = false;
            // 
            // painel_observacao
            // 
            painel_observacao.BackColor = Color.FromArgb(229, 229, 229);
            painel_observacao.BorderStyle = BorderStyle.FixedSingle;
            painel_observacao.Controls.Add(panel9);
            painel_observacao.Controls.Add(txt_observacao_produto);
            painel_observacao.Location = new Point(21, 498);
            painel_observacao.Name = "painel_observacao";
            painel_observacao.Size = new Size(669, 63);
            painel_observacao.TabIndex = 26;
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
            txt_observacao_produto.Location = new Point(11, 31);
            txt_observacao_produto.Name = "txt_observacao_produto";
            txt_observacao_produto.Size = new Size(648, 27);
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
            painel_pagamentos.Location = new Point(20, 139);
            painel_pagamentos.Name = "painel_pagamentos";
            painel_pagamentos.Size = new Size(669, 61);
            painel_pagamentos.TabIndex = 26;
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
            painel_produtos.Location = new Point(20, 210);
            painel_produtos.Name = "painel_produtos";
            painel_produtos.Size = new Size(669, 276);
            painel_produtos.TabIndex = 26;
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
            btn_apagar_adicionais.Location = new Point(365, 239);
            btn_apagar_adicionais.Name = "btn_apagar_adicionais";
            btn_apagar_adicionais.Size = new Size(121, 28);
            btn_apagar_adicionais.TabIndex = 31;
            btn_apagar_adicionais.Text = "Remover";
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
            btn_apagar_produto.Location = new Point(32, 239);
            btn_apagar_produto.Name = "btn_apagar_produto";
            btn_apagar_produto.Size = new Size(121, 28);
            btn_apagar_produto.TabIndex = 30;
            btn_apagar_produto.Text = "Remover";
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
            btn_show_add_adicional.Location = new Point(517, 239);
            btn_show_add_adicional.Name = "btn_show_add_adicional";
            btn_show_add_adicional.Size = new Size(122, 28);
            btn_show_add_adicional.TabIndex = 29;
            btn_show_add_adicional.Text = "Adicionar";
            btn_show_add_adicional.TextAlign = ContentAlignment.MiddleRight;
            btn_show_add_adicional.UseVisualStyleBackColor = false;
            btn_show_add_adicional.Click += btn_show_add_adicional_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(457, 31);
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
            listViewAdicionais.Location = new Point(340, 54);
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
            listViewProdutos.Location = new Point(11, 54);
            listViewProdutos.MultiSelect = false;
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
            btn_show_select_produto.Location = new Point(189, 239);
            btn_show_select_produto.Name = "btn_show_select_produto";
            btn_show_select_produto.Size = new Size(121, 28);
            btn_show_select_produto.TabIndex = 23;
            btn_show_select_produto.Text = "Adicionar";
            btn_show_select_produto.TextAlign = ContentAlignment.MiddleRight;
            btn_show_select_produto.UseVisualStyleBackColor = false;
            btn_show_select_produto.Click += btn_show_select_produto_Click;
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
            panel3.Location = new Point(20, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 116);
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
            lblReceitaVenda.Location = new Point(72, 58);
            lblReceitaVenda.Name = "lblReceitaVenda";
            lblReceitaVenda.Size = new Size(66, 20);
            lblReceitaVenda.TabIndex = 24;
            lblReceitaVenda.Text = "Receita";
            // 
            // lblClienteVenda
            // 
            lblClienteVenda.AutoSize = true;
            lblClienteVenda.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteVenda.ForeColor = Color.FromArgb(64, 64, 64);
            lblClienteVenda.Location = new Point(67, 30);
            lblClienteVenda.Name = "lblClienteVenda";
            lblClienteVenda.Size = new Size(107, 20);
            lblClienteVenda.TabIndex = 1;
            lblClienteVenda.Text = "Nome cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(5, 58);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 3;
            label3.Text = "Receita:";
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
            btn_show_select_cliente.UseVisualStyleBackColor = false;
            btn_show_select_cliente.Click += btn_show_select_cliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(5, 30);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 29);
            panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.LightGray;
            btn_fechar.BackgroundImage = (Image)resources.GetObject("btn_fechar.BackgroundImage");
            btn_fechar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = SystemColors.ActiveCaptionText;
            btn_fechar.Location = new Point(703, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 31;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(35, 3);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 32;
            label1.Text = "Editando Produto";
            // 
            // btn_salvar_edicao
            // 
            btn_salvar_edicao.Anchor = AnchorStyles.Bottom;
            btn_salvar_edicao.BackColor = Color.LightGray;
            btn_salvar_edicao.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salvar_edicao.Cursor = Cursors.Hand;
            btn_salvar_edicao.FlatAppearance.BorderColor = Color.Gray;
            btn_salvar_edicao.FlatStyle = FlatStyle.Flat;
            btn_salvar_edicao.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar_edicao.ForeColor = Color.FromArgb(64, 64, 64);
            btn_salvar_edicao.Image = (Image)resources.GetObject("btn_salvar_edicao.Image");
            btn_salvar_edicao.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salvar_edicao.Location = new Point(286, 674);
            btn_salvar_edicao.Name = "btn_salvar_edicao";
            btn_salvar_edicao.Size = new Size(155, 29);
            btn_salvar_edicao.TabIndex = 38;
            btn_salvar_edicao.Text = "Salvar edição";
            btn_salvar_edicao.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar_edicao.UseVisualStyleBackColor = false;
            btn_salvar_edicao.Click += btn_salvar_edicao_Click;
            // 
            // EditarVendaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(730, 715);
            Controls.Add(btn_salvar_edicao);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarVendaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarVendaProduto";
            Shown += EditarVendaProduto_Shown;
            panel2.ResumeLayout(false);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel14;
        private Label txt_total_produto;
        private Label label13;
        private Button bnt_finalizar_venda;
        private Panel painel_observacao;
        private Panel panel9;
        private Label label4;
        private TextBox txt_observacao_produto;
        private Panel painel_pagamentos;
        private Panel panel6;
        private Label label7;
        private RadioButton rb_credito_produto;
        private RadioButton rb_debito_produto;
        private RadioButton rb_pix_produto;
        private RadioButton rb_dinheiro_produto;
        private Panel painel_produtos;
        private Panel panel8;
        private Label label8;
        private Button btn_show_add_adicional;
        private Label label19;
        private Label label18;
        private ListView listViewAdicionais;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listViewProdutos;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btn_show_select_produto;
        private Panel panel3;
        private Panel panel5;
        private Label label6;
        private Label lblReceitaVenda;
        private Label lblClienteVenda;
        private Label label3;
        private Button btn_show_select_cliente;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_fechar;
        private Label label1;
        private Button btn_salvar_edicao;
        private Button btn_apagar_produto;
        private Button btn_apagar_adicionais;
    }
}