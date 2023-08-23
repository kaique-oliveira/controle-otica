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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            columnHeader1 = new ColumnHeader();
            dg_clientes = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            btn_show_produtos = new ToolStripMenuItem();
            label1 = new Label();
            dg_receitas = new DataGridView();
            DataExame = new DataGridViewTextBoxColumn();
            DataValExame = new DataGridViewTextBoxColumn();
            nomeExaminador = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            txt_filtro_cliente = new TextBox();
            btn_gerenciar_clientes = new Button();
            painel_receitas = new Panel();
            pictureBox5 = new PictureBox();
            btn_gerenciar_receitas = new Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            btn_gerenciar_produto = new Button();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            txt_filtro_produto = new TextBox();
            dg_produtos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            panel12 = new Panel();
            cbo_tipo_pagamento = new ComboBox();
            label12 = new Label();
            panel11 = new Panel();
            btn_cancelar_venda = new Button();
            bnt_finalizar_venda = new Button();
            panel10 = new Panel();
            lbl_valor_total = new Label();
            label11 = new Label();
            panel9 = new Panel();
            label9 = new Label();
            btn_add_adicional = new Button();
            label10 = new Label();
            txt_valor_adicional = new MaskedTextBox();
            label8 = new Label();
            txt_descricao_adiconal = new TextBox();
            panel8 = new Panel();
            lblReceita_selecionada = new Label();
            label7 = new Label();
            panel7 = new Panel();
            btn_limpar_produtos = new Button();
            listViewProdutos = new ListView();
            columnHeader2 = new ColumnHeader();
            label6 = new Label();
            panel6 = new Panel();
            lblClienteVenda = new Label();
            label5 = new Label();
            btn_gerenciar_vendas = new Button();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            tipBotao = new ToolTip(components);
            btn_add_produto_lista = new Button();
            tipCampo = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dg_clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_receitas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            painel_receitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_produtos).BeginInit();
            panel5.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 200;
            // 
            // dg_clientes
            // 
            dg_clientes.AllowUserToAddRows = false;
            dg_clientes.AllowUserToDeleteRows = false;
            dg_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dg_clientes.BackgroundColor = SystemColors.ButtonFace;
            dg_clientes.BorderStyle = BorderStyle.None;
            dg_clientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_clientes.Columns.AddRange(new DataGridViewColumn[] { nome, telefone });
            dg_clientes.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dg_clientes.EnableHeadersVisualStyles = false;
            dg_clientes.GridColor = Color.WhiteSmoke;
            dg_clientes.Location = new Point(12, 95);
            dg_clientes.MultiSelect = false;
            dg_clientes.Name = "dg_clientes";
            dg_clientes.ReadOnly = true;
            dg_clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dg_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dg_clientes.RowHeadersVisible = false;
            dg_clientes.RowTemplate.Height = 25;
            dg_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_clientes.Size = new Size(320, 241);
            dg_clientes.TabIndex = 0;
            dg_clientes.CellClick += dg_clientes_CellClick;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "NOME";
            nome.MinimumWidth = 100;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 200;
            // 
            // telefone
            // 
            telefone.DataPropertyName = "telefone";
            telefone.HeaderText = "TELEFONE";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 120;
            // 
            // btn_show_produtos
            // 
            btn_show_produtos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_produtos.ForeColor = SystemColors.ButtonHighlight;
            btn_show_produtos.Name = "btn_show_produtos";
            btn_show_produtos.Size = new Size(80, 24);
            btn_show_produtos.Text = "Produtos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(55, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 7;
            label1.Text = "Clientes";
            // 
            // dg_receitas
            // 
            dg_receitas.AllowUserToAddRows = false;
            dg_receitas.AllowUserToDeleteRows = false;
            dg_receitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dg_receitas.BackgroundColor = SystemColors.ButtonFace;
            dg_receitas.BorderStyle = BorderStyle.None;
            dg_receitas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_receitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dg_receitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg_receitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_receitas.Columns.AddRange(new DataGridViewColumn[] { DataExame, DataValExame, nomeExaminador });
            dg_receitas.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dg_receitas.DefaultCellStyle = dataGridViewCellStyle5;
            dg_receitas.Enabled = false;
            dg_receitas.EnableHeadersVisualStyles = false;
            dg_receitas.GridColor = Color.WhiteSmoke;
            dg_receitas.Location = new Point(12, 50);
            dg_receitas.MultiSelect = false;
            dg_receitas.Name = "dg_receitas";
            dg_receitas.ReadOnly = true;
            dg_receitas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dg_receitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dg_receitas.RowHeadersVisible = false;
            dg_receitas.RowTemplate.Height = 25;
            dg_receitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_receitas.Size = new Size(320, 215);
            dg_receitas.TabIndex = 0;
            dg_receitas.CellClick += dg_receitas_CellClick;
            // 
            // DataExame
            // 
            DataExame.DataPropertyName = "DataExame";
            DataExame.HeaderText = "REALIZADO";
            DataExame.Name = "DataExame";
            DataExame.ReadOnly = true;
            // 
            // DataValExame
            // 
            DataValExame.DataPropertyName = "DataValExame";
            DataValExame.HeaderText = "VENCE";
            DataValExame.MinimumWidth = 60;
            DataValExame.Name = "DataValExame";
            DataValExame.ReadOnly = true;
            // 
            // nomeExaminador
            // 
            nomeExaminador.DataPropertyName = "nomeExaminador";
            nomeExaminador.HeaderText = "EXAMINADOR";
            nomeExaminador.Name = "nomeExaminador";
            nomeExaminador.ReadOnly = true;
            nomeExaminador.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(29, 5);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 9;
            label2.Text = "Receitas";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btn_gerenciar_clientes);
            panel1.Controls.Add(dg_clientes);
            panel1.Location = new Point(26, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 345);
            panel1.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            tipCampo.SetToolTip(pictureBox3, "Filtrar clientes por nome ou final do telefone.");
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(txt_filtro_cliente);
            panel3.Location = new Point(12, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 40);
            panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            tipCampo.SetToolTip(pictureBox1, "Filtrar clientes por nome ou final do telefone.");
            // 
            // txt_filtro_cliente
            // 
            txt_filtro_cliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtro_cliente.Location = new Point(37, 6);
            txt_filtro_cliente.Name = "txt_filtro_cliente";
            txt_filtro_cliente.PlaceholderText = "ex: \"João\" ou \"9162\"";
            txt_filtro_cliente.Size = new Size(277, 27);
            txt_filtro_cliente.TabIndex = 2;
            txt_filtro_cliente.Tag = "";
            tipCampo.SetToolTip(txt_filtro_cliente, "Filtrar clientes por nome ou final do telefone.");
            // 
            // btn_gerenciar_clientes
            // 
            btn_gerenciar_clientes.AccessibleDescription = "";
            btn_gerenciar_clientes.BackColor = SystemColors.ControlLight;
            btn_gerenciar_clientes.BackgroundImage = (Image)resources.GetObject("btn_gerenciar_clientes.BackgroundImage");
            btn_gerenciar_clientes.BackgroundImageLayout = ImageLayout.Stretch;
            btn_gerenciar_clientes.Cursor = Cursors.Hand;
            btn_gerenciar_clientes.FlatAppearance.BorderSize = 0;
            btn_gerenciar_clientes.FlatStyle = FlatStyle.Flat;
            btn_gerenciar_clientes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gerenciar_clientes.ForeColor = SystemColors.ActiveCaptionText;
            btn_gerenciar_clientes.Location = new Point(312, 3);
            btn_gerenciar_clientes.Name = "btn_gerenciar_clientes";
            btn_gerenciar_clientes.Size = new Size(28, 28);
            btn_gerenciar_clientes.TabIndex = 1;
            btn_gerenciar_clientes.Tag = "";
            tipBotao.SetToolTip(btn_gerenciar_clientes, "Gerenciar todos os clientes.");
            btn_gerenciar_clientes.UseVisualStyleBackColor = false;
            btn_gerenciar_clientes.Click += btn_gerenciar_clientes_Click;
            // 
            // painel_receitas
            // 
            painel_receitas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            painel_receitas.BackColor = SystemColors.ControlLight;
            painel_receitas.Controls.Add(pictureBox5);
            painel_receitas.Controls.Add(btn_gerenciar_receitas);
            painel_receitas.Controls.Add(label2);
            painel_receitas.Controls.Add(dg_receitas);
            painel_receitas.Location = new Point(26, 371);
            painel_receitas.Name = "painel_receitas";
            painel_receitas.Size = new Size(343, 275);
            painel_receitas.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 22);
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            tipCampo.SetToolTip(pictureBox5, "Filtrar clientes por nome ou final do telefone.");
            // 
            // btn_gerenciar_receitas
            // 
            btn_gerenciar_receitas.BackColor = SystemColors.ControlLight;
            btn_gerenciar_receitas.BackgroundImage = (Image)resources.GetObject("btn_gerenciar_receitas.BackgroundImage");
            btn_gerenciar_receitas.BackgroundImageLayout = ImageLayout.Stretch;
            btn_gerenciar_receitas.Cursor = Cursors.Hand;
            btn_gerenciar_receitas.FlatAppearance.BorderSize = 0;
            btn_gerenciar_receitas.FlatStyle = FlatStyle.Flat;
            btn_gerenciar_receitas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gerenciar_receitas.ForeColor = SystemColors.ActiveCaptionText;
            btn_gerenciar_receitas.Location = new Point(312, 4);
            btn_gerenciar_receitas.Name = "btn_gerenciar_receitas";
            btn_gerenciar_receitas.Size = new Size(28, 28);
            btn_gerenciar_receitas.TabIndex = 3;
            tipBotao.SetToolTip(btn_gerenciar_receitas, "Gerenciar Todas receitas do cliente selecionado.");
            btn_gerenciar_receitas.UseVisualStyleBackColor = false;
            btn_gerenciar_receitas.Click += btn_gerenciar_receitas_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(btn_gerenciar_produto);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dg_produtos);
            panel2.Location = new Point(386, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 641);
            panel2.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 22);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            tipCampo.SetToolTip(pictureBox4, "Filtrar clientes por nome ou final do telefone.");
            // 
            // btn_gerenciar_produto
            // 
            btn_gerenciar_produto.BackColor = Color.Transparent;
            btn_gerenciar_produto.BackgroundImage = (Image)resources.GetObject("btn_gerenciar_produto.BackgroundImage");
            btn_gerenciar_produto.BackgroundImageLayout = ImageLayout.Stretch;
            btn_gerenciar_produto.Cursor = Cursors.Hand;
            btn_gerenciar_produto.FlatAppearance.BorderSize = 0;
            btn_gerenciar_produto.FlatStyle = FlatStyle.Flat;
            btn_gerenciar_produto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gerenciar_produto.ForeColor = SystemColors.ActiveCaptionText;
            btn_gerenciar_produto.Location = new Point(385, 3);
            btn_gerenciar_produto.Name = "btn_gerenciar_produto";
            btn_gerenciar_produto.Size = new Size(28, 28);
            btn_gerenciar_produto.TabIndex = 4;
            tipBotao.SetToolTip(btn_gerenciar_produto, "Gerenciar todos os produtos.");
            btn_gerenciar_produto.UseVisualStyleBackColor = false;
            btn_gerenciar_produto.Click += btn_gerenciar_produto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(31, 6);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 13;
            label3.Text = "Produtos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(txt_filtro_produto);
            panel4.Location = new Point(11, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(371, 40);
            panel4.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            tipCampo.SetToolTip(pictureBox2, "Filtrar produto por nome.");
            // 
            // txt_filtro_produto
            // 
            txt_filtro_produto.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtro_produto.Location = new Point(38, 7);
            txt_filtro_produto.Name = "txt_filtro_produto";
            txt_filtro_produto.PlaceholderText = "ex: \"Coleção cassino\"";
            txt_filtro_produto.Size = new Size(327, 27);
            txt_filtro_produto.TabIndex = 5;
            txt_filtro_produto.Tag = "";
            tipCampo.SetToolTip(txt_filtro_produto, "Filtrar produto por nome.");
            // 
            // dg_produtos
            // 
            dg_produtos.AllowUserToAddRows = false;
            dg_produtos.AllowUserToDeleteRows = false;
            dg_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dg_produtos.BackgroundColor = SystemColors.ButtonFace;
            dg_produtos.BorderStyle = BorderStyle.None;
            dg_produtos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_produtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dg_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dg_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_produtos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, quantidade, valor });
            dg_produtos.Cursor = Cursors.Hand;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dg_produtos.DefaultCellStyle = dataGridViewCellStyle8;
            dg_produtos.EnableHeadersVisualStyles = false;
            dg_produtos.GridColor = Color.WhiteSmoke;
            dg_produtos.Location = new Point(12, 95);
            dg_produtos.MultiSelect = false;
            dg_produtos.Name = "dg_produtos";
            dg_produtos.ReadOnly = true;
            dg_produtos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dg_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dg_produtos.RowHeadersVisible = false;
            dg_produtos.RowTemplate.Height = 25;
            dg_produtos.ScrollBars = ScrollBars.Vertical;
            dg_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_produtos.Size = new Size(371, 535);
            dg_produtos.TabIndex = 0;
            dg_produtos.CellClick += dg_produtos_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            dataGridViewTextBoxColumn1.HeaderText = "NOME";
            dataGridViewTextBoxColumn1.MinimumWidth = 100;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 180;
            // 
            // quantidade
            // 
            quantidade.DataPropertyName = "quantidade";
            quantidade.HeaderText = "QUANTIDADE";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            quantidade.Width = 110;
            // 
            // valor
            // 
            valor.DataPropertyName = "valor";
            valor.HeaderText = "VALOR";
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Width = 80;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(panel12);
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btn_gerenciar_vendas);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(818, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(348, 640);
            panel5.TabIndex = 13;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.Controls.Add(cbo_tipo_pagamento);
            panel12.Controls.Add(label12);
            panel12.Location = new Point(10, 144);
            panel12.Name = "panel12";
            panel12.Size = new Size(329, 33);
            panel12.TabIndex = 24;
            // 
            // cbo_tipo_pagamento
            // 
            cbo_tipo_pagamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_tipo_pagamento.ForeColor = Color.FromArgb(64, 64, 64);
            cbo_tipo_pagamento.FormattingEnabled = true;
            cbo_tipo_pagamento.Location = new Point(87, 2);
            cbo_tipo_pagamento.Name = "cbo_tipo_pagamento";
            cbo_tipo_pagamento.Size = new Size(235, 28);
            cbo_tipo_pagamento.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(5, 7);
            label12.Name = "label12";
            label12.Size = new Size(82, 17);
            label12.TabIndex = 23;
            label12.Text = "Pagamento:";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Bottom;
            panel11.BackColor = Color.LightGray;
            panel11.Controls.Add(btn_cancelar_venda);
            panel11.Controls.Add(bnt_finalizar_venda);
            panel11.Location = new Point(10, 587);
            panel11.Name = "panel11";
            panel11.Size = new Size(329, 45);
            panel11.TabIndex = 24;
            // 
            // btn_cancelar_venda
            // 
            btn_cancelar_venda.BackColor = SystemColors.ButtonFace;
            btn_cancelar_venda.BackgroundImageLayout = ImageLayout.Stretch;
            btn_cancelar_venda.Cursor = Cursors.Hand;
            btn_cancelar_venda.FlatAppearance.BorderSize = 0;
            btn_cancelar_venda.FlatStyle = FlatStyle.Flat;
            btn_cancelar_venda.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar_venda.ForeColor = Color.FromArgb(64, 64, 64);
            btn_cancelar_venda.Image = (Image)resources.GetObject("btn_cancelar_venda.Image");
            btn_cancelar_venda.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancelar_venda.Location = new Point(35, 6);
            btn_cancelar_venda.Name = "btn_cancelar_venda";
            btn_cancelar_venda.Size = new Size(105, 34);
            btn_cancelar_venda.TabIndex = 23;
            btn_cancelar_venda.Text = "Cancelar";
            btn_cancelar_venda.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(btn_cancelar_venda, "Cancelar venda");
            btn_cancelar_venda.UseVisualStyleBackColor = false;
            btn_cancelar_venda.Click += btn_cancelar_venda_Click;
            // 
            // bnt_finalizar_venda
            // 
            bnt_finalizar_venda.BackColor = SystemColors.ButtonFace;
            bnt_finalizar_venda.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_finalizar_venda.Cursor = Cursors.Hand;
            bnt_finalizar_venda.FlatAppearance.BorderSize = 0;
            bnt_finalizar_venda.FlatStyle = FlatStyle.Flat;
            bnt_finalizar_venda.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_finalizar_venda.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_finalizar_venda.Image = (Image)resources.GetObject("bnt_finalizar_venda.Image");
            bnt_finalizar_venda.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_finalizar_venda.Location = new Point(193, 6);
            bnt_finalizar_venda.Name = "bnt_finalizar_venda";
            bnt_finalizar_venda.Size = new Size(105, 34);
            bnt_finalizar_venda.TabIndex = 24;
            bnt_finalizar_venda.Text = "Vender";
            bnt_finalizar_venda.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(bnt_finalizar_venda, "Finalizar venda");
            bnt_finalizar_venda.UseVisualStyleBackColor = false;
            bnt_finalizar_venda.Click += bnt_finalizar_venda_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightGray;
            panel10.Controls.Add(lbl_valor_total);
            panel10.Controls.Add(label11);
            panel10.Location = new Point(10, 528);
            panel10.Name = "panel10";
            panel10.Size = new Size(329, 33);
            panel10.TabIndex = 20;
            // 
            // lbl_valor_total
            // 
            lbl_valor_total.AutoSize = true;
            lbl_valor_total.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valor_total.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_valor_total.Location = new Point(45, 6);
            lbl_valor_total.Name = "lbl_valor_total";
            lbl_valor_total.Size = new Size(0, 20);
            lbl_valor_total.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(5, 7);
            label11.Name = "label11";
            label11.Size = new Size(43, 17);
            label11.TabIndex = 23;
            label11.Text = "Total:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.Controls.Add(label9);
            panel9.Controls.Add(btn_add_adicional);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(txt_valor_adicional);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(txt_descricao_adiconal);
            panel9.Location = new Point(10, 192);
            panel9.Name = "panel9";
            panel9.Size = new Size(329, 133);
            panel9.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(5, 5);
            label9.Name = "label9";
            label9.Size = new Size(76, 17);
            label9.TabIndex = 2;
            label9.Text = "Adicionais:";
            // 
            // btn_add_adicional
            // 
            btn_add_adicional.BackColor = Color.Transparent;
            btn_add_adicional.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_adicional.Cursor = Cursors.Hand;
            btn_add_adicional.FlatAppearance.BorderSize = 0;
            btn_add_adicional.FlatStyle = FlatStyle.Flat;
            btn_add_adicional.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_adicional.ForeColor = Color.FromArgb(64, 64, 64);
            btn_add_adicional.Image = (Image)resources.GetObject("btn_add_adicional.Image");
            btn_add_adicional.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add_adicional.Location = new Point(110, 98);
            btn_add_adicional.Name = "btn_add_adicional";
            btn_add_adicional.Size = new Size(112, 28);
            btn_add_adicional.TabIndex = 11;
            btn_add_adicional.Text = "Adicionar";
            btn_add_adicional.TextAlign = ContentAlignment.MiddleRight;
            tipBotao.SetToolTip(btn_add_adicional, "Incluir adicional na lista de itens");
            btn_add_adicional.UseVisualStyleBackColor = false;
            btn_add_adicional.Click += btn_add_adicional_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(257, 34);
            label10.Name = "label10";
            label10.Size = new Size(42, 17);
            label10.TabIndex = 22;
            label10.Text = "valor:";
            // 
            // txt_valor_adicional
            // 
            txt_valor_adicional.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valor_adicional.Location = new Point(256, 54);
            txt_valor_adicional.Mask = "000,00";
            txt_valor_adicional.Name = "txt_valor_adicional";
            txt_valor_adicional.Size = new Size(66, 27);
            txt_valor_adicional.TabIndex = 10;
            tipCampo.SetToolTip(txt_valor_adicional, "Valor do serviço ou produto adicional");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(5, 34);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 19;
            label8.Text = "descrição";
            // 
            // txt_descricao_adiconal
            // 
            txt_descricao_adiconal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_descricao_adiconal.Location = new Point(6, 55);
            txt_descricao_adiconal.Name = "txt_descricao_adiconal";
            txt_descricao_adiconal.PlaceholderText = "ex: \"Lentes antirreflexo\"";
            txt_descricao_adiconal.Size = new Size(244, 27);
            txt_descricao_adiconal.TabIndex = 9;
            txt_descricao_adiconal.Tag = "";
            tipCampo.SetToolTip(txt_descricao_adiconal, "Descrição do serviço ou produto adicional");
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Controls.Add(lblReceita_selecionada);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(10, 94);
            panel8.Name = "panel8";
            panel8.Size = new Size(329, 33);
            panel8.TabIndex = 18;
            // 
            // lblReceita_selecionada
            // 
            lblReceita_selecionada.AutoSize = true;
            lblReceita_selecionada.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblReceita_selecionada.ForeColor = Color.FromArgb(64, 64, 64);
            lblReceita_selecionada.Location = new Point(57, 6);
            lblReceita_selecionada.Name = "lblReceita_selecionada";
            lblReceita_selecionada.Size = new Size(0, 20);
            lblReceita_selecionada.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(5, 8);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 2;
            label7.Text = "Receita:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Controls.Add(btn_limpar_produtos);
            panel7.Controls.Add(listViewProdutos);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(10, 340);
            panel7.Name = "panel7";
            panel7.Size = new Size(329, 186);
            panel7.TabIndex = 17;
            // 
            // btn_limpar_produtos
            // 
            btn_limpar_produtos.BackColor = Color.Transparent;
            btn_limpar_produtos.BackgroundImage = (Image)resources.GetObject("btn_limpar_produtos.BackgroundImage");
            btn_limpar_produtos.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpar_produtos.Cursor = Cursors.Hand;
            btn_limpar_produtos.FlatAppearance.BorderSize = 0;
            btn_limpar_produtos.FlatStyle = FlatStyle.Flat;
            btn_limpar_produtos.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpar_produtos.ForeColor = SystemColors.ActiveCaptionText;
            btn_limpar_produtos.Location = new Point(302, 3);
            btn_limpar_produtos.Name = "btn_limpar_produtos";
            btn_limpar_produtos.Size = new Size(24, 24);
            btn_limpar_produtos.TabIndex = 8;
            tipBotao.SetToolTip(btn_limpar_produtos, "Limpar lista de itens");
            btn_limpar_produtos.UseVisualStyleBackColor = false;
            btn_limpar_produtos.Click += btn_limpar_produtos_Click;
            // 
            // listViewProdutos
            // 
            listViewProdutos.BackColor = Color.LightGray;
            listViewProdutos.BorderStyle = BorderStyle.None;
            listViewProdutos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewProdutos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listViewProdutos.ForeColor = Color.FromArgb(64, 64, 64);
            listViewProdutos.FullRowSelect = true;
            listViewProdutos.HeaderStyle = ColumnHeaderStyle.None;
            listViewProdutos.Location = new Point(5, 37);
            listViewProdutos.Name = "listViewProdutos";
            listViewProdutos.Size = new Size(319, 143);
            listViewProdutos.TabIndex = 18;
            listViewProdutos.UseCompatibleStateImageBehavior = false;
            listViewProdutos.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Valor";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 98;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(4, 4);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 2;
            label6.Text = "Itens:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Controls.Add(lblClienteVenda);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(10, 46);
            panel6.Name = "panel6";
            panel6.Size = new Size(329, 33);
            panel6.TabIndex = 16;
            // 
            // lblClienteVenda
            // 
            lblClienteVenda.AutoSize = true;
            lblClienteVenda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteVenda.ForeColor = Color.FromArgb(64, 64, 64);
            lblClienteVenda.Location = new Point(52, 6);
            lblClienteVenda.Name = "lblClienteVenda";
            lblClienteVenda.Size = new Size(0, 20);
            lblClienteVenda.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(4, 7);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 0;
            label5.Text = "Cliente:";
            // 
            // btn_gerenciar_vendas
            // 
            btn_gerenciar_vendas.BackColor = Color.Transparent;
            btn_gerenciar_vendas.BackgroundImage = (Image)resources.GetObject("btn_gerenciar_vendas.BackgroundImage");
            btn_gerenciar_vendas.BackgroundImageLayout = ImageLayout.Stretch;
            btn_gerenciar_vendas.Cursor = Cursors.Hand;
            btn_gerenciar_vendas.FlatAppearance.BorderSize = 0;
            btn_gerenciar_vendas.FlatStyle = FlatStyle.Flat;
            btn_gerenciar_vendas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gerenciar_vendas.ForeColor = SystemColors.ActiveCaptionText;
            btn_gerenciar_vendas.Location = new Point(317, 2);
            btn_gerenciar_vendas.Name = "btn_gerenciar_vendas";
            btn_gerenciar_vendas.Size = new Size(28, 28);
            btn_gerenciar_vendas.TabIndex = 7;
            tipBotao.SetToolTip(btn_gerenciar_vendas, "Gerenciar todas as vendas.");
            btn_gerenciar_vendas.UseVisualStyleBackColor = false;
            btn_gerenciar_vendas.Click += btn_gerenciar_vendas_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(4, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 22);
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            tipCampo.SetToolTip(pictureBox6, "Filtrar clientes por nome ou final do telefone.");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(30, 5);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 14;
            label4.Text = "Venda";
            // 
            // tipBotao
            // 
            tipBotao.AutomaticDelay = 200;
            tipBotao.Tag = "";
            tipBotao.ToolTipTitle = "Botão";
            // 
            // btn_add_produto_lista
            // 
            btn_add_produto_lista.Anchor = AnchorStyles.None;
            btn_add_produto_lista.BackColor = SystemColors.ControlLight;
            btn_add_produto_lista.BackgroundImage = (Image)resources.GetObject("btn_add_produto_lista.BackgroundImage");
            btn_add_produto_lista.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_produto_lista.Cursor = Cursors.Hand;
            btn_add_produto_lista.FlatAppearance.BorderSize = 0;
            btn_add_produto_lista.FlatStyle = FlatStyle.Flat;
            btn_add_produto_lista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_produto_lista.ForeColor = SystemColors.ActiveCaptionText;
            btn_add_produto_lista.Location = new Point(770, 299);
            btn_add_produto_lista.Name = "btn_add_produto_lista";
            btn_add_produto_lista.Size = new Size(28, 28);
            btn_add_produto_lista.TabIndex = 6;
            tipBotao.SetToolTip(btn_add_produto_lista, "Adicionar produto a venda");
            btn_add_produto_lista.UseVisualStyleBackColor = false;
            btn_add_produto_lista.Click += btn_add_produto_lista_Click;
            // 
            // tipCampo
            // 
            tipCampo.AutomaticDelay = 200;
            tipCampo.ToolTipTitle = "Campo";
            // 
            // MainFrame
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1194, 654);
            Controls.Add(btn_add_produto_lista);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(painel_receitas);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "k-vision";
            WindowState = FormWindowState.Maximized;
            Shown += MainFrame_Shown;
            ((System.ComponentModel.ISupportInitialize)dg_clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_receitas).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            painel_receitas.ResumeLayout(false);
            painel_receitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_produtos).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem clienteToolStripMenuItem;
        private Button btn_show_clientes;
        private Button btn_show_produto;
        private DataGridView dg_clientes;
        private ToolStripMenuItem btn_show_produtos;
        private Label label1;
        private DataGridView dg_receitas;
        private Label label2;
        private Panel panel1;
        private Panel painel_receitas;
        private Button btn_gerenciar_receitas;
        private Button btn_gerenciar_clientes;
        private Panel panel2;
        private Panel panel3;
        private TextBox txt_filtro_cliente;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn DataExame;
        private DataGridViewTextBoxColumn DataValExame;
        private DataGridViewTextBoxColumn nomeExaminador;
        private Label label3;
        private Panel panel4;
        private TextBox txt_filtro_produto;
        private DataGridView dg_produtos;
        private Button btn_gerenciar_produto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn valor;
        private Panel panel5;
        private Label label4;
        private ToolTip tipBotao;
        private PictureBox pictureBox1;
        private ToolTip tipCampo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button btn_gerenciar_vendas;
        private PictureBox pictureBox6;
        private Panel panel6;
        private Label lblClienteVenda;
        private Label label5;
        private Panel panel7;
        private Label label6;
        private ColumnHeader NomeProduto;
        private ListView listViewProdutos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel8;
        private Label lblReceita_selecionada;
        private Label label7;
        private Panel panel9;
        private Button btn_add_adicional;
        private Label label10;
        private MaskedTextBox txt_valor_adicional;
        private Label label8;
        private TextBox txt_descricao_adiconal;
        private Button btn_limpar_produtos;
        private Button btn_add_produto_lista;
        private Panel panel10;
        private Label label11;
        private Label lbl_valor_total;
        private Button bnt_finalizar_venda;
        private Button btn_cancelar_venda;
        private Panel panel12;
        private Label label12;
        private Panel panel11;
        private ComboBox cbo_tipo_pagamento;
        private Label label9;
    }
}