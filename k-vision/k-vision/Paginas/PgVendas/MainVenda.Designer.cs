namespace Kvision.Frame.Paginas.PgVendas
{
    partial class MainVenda
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainVenda));
            panel1 = new Panel();
            dg_vendas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TipoVenda = new DataGridViewTextBoxColumn();
            TipoPagamento = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            panel14 = new Panel();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            lbl_pagamento = new Label();
            label2 = new Label();
            panel10 = new Panel();
            lbl_valor_total = new Label();
            label11 = new Label();
            panel8 = new Panel();
            lblReceita_selecionada = new Label();
            label7 = new Label();
            panel7 = new Panel();
            panel15 = new Panel();
            label6 = new Label();
            listViewProdutos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel6 = new Panel();
            lblClienteVenda = new Label();
            label5 = new Label();
            DataCadastro = new DataGridViewTextBoxColumn();
            btn_fechar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            panel11 = new Panel();
            label3 = new Label();
            btn_limpar_filtro = new Button();
            label9 = new Label();
            label8 = new Label();
            dtp_data_fim = new DateTimePicker();
            dtp_data_inicio = new DateTimePicker();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            panel4 = new Panel();
            lbl_total_todas_as_vendas = new Label();
            label12 = new Label();
            panel12 = new Panel();
            panel13 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_vendas).BeginInit();
            panel5.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel15.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dg_vendas);
            panel1.Location = new Point(16, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 325);
            panel1.TabIndex = 0;
            // 
            // dg_vendas
            // 
            dg_vendas.AllowUserToAddRows = false;
            dg_vendas.AllowUserToDeleteRows = false;
            dg_vendas.AllowUserToResizeColumns = false;
            dg_vendas.AllowUserToResizeRows = false;
            dg_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dg_vendas.BackgroundColor = Color.LightGray;
            dg_vendas.BorderStyle = BorderStyle.None;
            dg_vendas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_vendas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_vendas.Columns.AddRange(new DataGridViewColumn[] { Id, dataGridViewTextBoxColumn1, TipoVenda, TipoPagamento, Valor });
            dg_vendas.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_vendas.DefaultCellStyle = dataGridViewCellStyle2;
            dg_vendas.EnableHeadersVisualStyles = false;
            dg_vendas.GridColor = Color.WhiteSmoke;
            dg_vendas.Location = new Point(9, 9);
            dg_vendas.MultiSelect = false;
            dg_vendas.Name = "dg_vendas";
            dg_vendas.ReadOnly = true;
            dg_vendas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dg_vendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dg_vendas.RowHeadersVisible = false;
            dg_vendas.RowTemplate.Height = 25;
            dg_vendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_vendas.Size = new Size(440, 304);
            dg_vendas.TabIndex = 1;
            dg_vendas.CellClick += dg_vendas_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "DataCadastro";
            dataGridViewTextBoxColumn1.HeaderText = "DATA";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TipoVenda
            // 
            TipoVenda.DataPropertyName = "TipoVenda";
            TipoVenda.HeaderText = "TIPO";
            TipoVenda.Name = "TipoVenda";
            TipoVenda.ReadOnly = true;
            TipoVenda.Width = 110;
            // 
            // TipoPagamento
            // 
            TipoPagamento.DataPropertyName = "TipoPagamento";
            TipoPagamento.HeaderText = "PAGAMENTO";
            TipoPagamento.Name = "TipoPagamento";
            TipoPagamento.ReadOnly = true;
            TipoPagamento.Width = 120;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "VALOR";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 110;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel14);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(509, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(348, 426);
            panel5.TabIndex = 14;
            // 
            // panel14
            // 
            panel14.BackColor = Color.RoyalBlue;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(label4);
            panel14.Controls.Add(pictureBox6);
            panel14.Location = new Point(-1, -1);
            panel14.Name = "panel14";
            panel14.Size = new Size(348, 30);
            panel14.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 4);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 14;
            label4.Text = "Detalhes";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(5, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 22);
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 229, 229);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_pagamento);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(10, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 33);
            panel2.TabIndex = 19;
            // 
            // lbl_pagamento
            // 
            lbl_pagamento.AutoSize = true;
            lbl_pagamento.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pagamento.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_pagamento.Location = new Point(89, 6);
            lbl_pagamento.Name = "lbl_pagamento";
            lbl_pagamento.Size = new Size(139, 19);
            lbl_pagamento.TabIndex = 2;
            lbl_pagamento.Text = "Tipo pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(5, 8);
            label2.Name = "label2";
            label2.Size = new Size(85, 16);
            label2.TabIndex = 2;
            label2.Text = "Pagamento:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightGray;
            panel10.Controls.Add(lbl_valor_total);
            panel10.Controls.Add(label11);
            panel10.Location = new Point(10, 453);
            panel10.Name = "panel10";
            panel10.Size = new Size(329, 33);
            panel10.TabIndex = 20;
            // 
            // lbl_valor_total
            // 
            lbl_valor_total.AutoSize = true;
            lbl_valor_total.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valor_total.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_valor_total.Location = new Point(45, 6);
            lbl_valor_total.Name = "lbl_valor_total";
            lbl_valor_total.Size = new Size(0, 21);
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
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(229, 229, 229);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblReceita_selecionada);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(10, 78);
            panel8.Name = "panel8";
            panel8.Size = new Size(329, 33);
            panel8.TabIndex = 18;
            // 
            // lblReceita_selecionada
            // 
            lblReceita_selecionada.AutoSize = true;
            lblReceita_selecionada.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblReceita_selecionada.ForeColor = Color.FromArgb(64, 64, 64);
            lblReceita_selecionada.Location = new Point(62, 6);
            lblReceita_selecionada.Name = "lblReceita_selecionada";
            lblReceita_selecionada.Size = new Size(185, 19);
            lblReceita_selecionada.TabIndex = 2;
            lblReceita_selecionada.Text = "Receita do comprador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(5, 8);
            label7.Name = "label7";
            label7.Size = new Size(60, 16);
            label7.TabIndex = 2;
            label7.Text = "Receita:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(229, 229, 229);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel15);
            panel7.Controls.Add(listViewProdutos);
            panel7.Location = new Point(10, 179);
            panel7.Name = "panel7";
            panel7.Size = new Size(329, 235);
            panel7.TabIndex = 17;
            // 
            // panel15
            // 
            panel15.BackColor = Color.RoyalBlue;
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(label6);
            panel15.Location = new Point(-1, -1);
            panel15.Name = "panel15";
            panel15.Size = new Size(329, 30);
            panel15.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(142, 5);
            label6.Name = "label6";
            label6.Size = new Size(45, 18);
            label6.TabIndex = 2;
            label6.Text = "Itens:";
            // 
            // listViewProdutos
            // 
            listViewProdutos.BackColor = Color.FromArgb(229, 229, 229);
            listViewProdutos.BorderStyle = BorderStyle.None;
            listViewProdutos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewProdutos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listViewProdutos.ForeColor = Color.FromArgb(64, 64, 64);
            listViewProdutos.FullRowSelect = true;
            listViewProdutos.HeaderStyle = ColumnHeaderStyle.None;
            listViewProdutos.Location = new Point(4, 38);
            listViewProdutos.Name = "listViewProdutos";
            listViewProdutos.Size = new Size(319, 192);
            listViewProdutos.TabIndex = 18;
            listViewProdutos.UseCompatibleStateImageBehavior = false;
            listViewProdutos.View = View.Details;
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
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(229, 229, 229);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblClienteVenda);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(10, 38);
            panel6.Name = "panel6";
            panel6.Size = new Size(329, 33);
            panel6.TabIndex = 16;
            // 
            // lblClienteVenda
            // 
            lblClienteVenda.AutoSize = true;
            lblClienteVenda.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClienteVenda.ForeColor = Color.FromArgb(64, 64, 64);
            lblClienteVenda.Location = new Point(59, 6);
            lblClienteVenda.Name = "lblClienteVenda";
            lblClienteVenda.Size = new Size(138, 19);
            lblClienteVenda.TabIndex = 1;
            lblClienteVenda.Text = "Nome do cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(4, 7);
            label5.Name = "label5";
            label5.Size = new Size(57, 16);
            label5.TabIndex = 0;
            label5.Text = "Cliente:";
            // 
            // DataCadastro
            // 
            DataCadastro.DataPropertyName = "DataCadastro";
            DataCadastro.HeaderText = "DATA";
            DataCadastro.MinimumWidth = 100;
            DataCadastro.Name = "DataCadastro";
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.Transparent;
            btn_fechar.BackgroundImage = (Image)resources.GetObject("btn_fechar.BackgroundImage");
            btn_fechar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = SystemColors.ActiveCaptionText;
            btn_fechar.Location = new Point(848, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 15;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(9, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(35, 4);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 21;
            label1.Text = "Vendas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dtp_data_fim);
            panel3.Controls.Add(dtp_data_inicio);
            panel3.Location = new Point(17, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 82);
            panel3.TabIndex = 23;
            // 
            // panel11
            // 
            panel11.BackColor = Color.RoyalBlue;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(label3);
            panel11.Controls.Add(btn_limpar_filtro);
            panel11.Location = new Point(-1, -1);
            panel11.Name = "panel11";
            panel11.Size = new Size(459, 30);
            panel11.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(163, 5);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 21;
            label3.Text = "Filtro de data";
            // 
            // btn_limpar_filtro
            // 
            btn_limpar_filtro.BackColor = Color.Transparent;
            btn_limpar_filtro.BackgroundImage = (Image)resources.GetObject("btn_limpar_filtro.BackgroundImage");
            btn_limpar_filtro.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpar_filtro.Cursor = Cursors.Hand;
            btn_limpar_filtro.FlatAppearance.BorderColor = Color.Gray;
            btn_limpar_filtro.FlatAppearance.BorderSize = 0;
            btn_limpar_filtro.FlatStyle = FlatStyle.Flat;
            btn_limpar_filtro.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpar_filtro.ForeColor = Color.FromArgb(64, 64, 64);
            btn_limpar_filtro.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtro.Location = new Point(430, 2);
            btn_limpar_filtro.Name = "btn_limpar_filtro";
            btn_limpar_filtro.Size = new Size(24, 24);
            btn_limpar_filtro.TabIndex = 23;
            btn_limpar_filtro.TextAlign = ContentAlignment.MiddleRight;
            btn_limpar_filtro.UseVisualStyleBackColor = false;
            btn_limpar_filtro.Click += btn_limpar_filtro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(224, 43);
            label9.Name = "label9";
            label9.Size = new Size(28, 16);
            label9.TabIndex = 22;
            label9.Text = "até";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(18, 42);
            label8.Name = "label8";
            label8.Size = new Size(24, 16);
            label8.TabIndex = 21;
            label8.Text = "De";
            // 
            // dtp_data_fim
            // 
            dtp_data_fim.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_data_fim.Format = DateTimePickerFormat.Short;
            dtp_data_fim.Location = new Point(261, 40);
            dtp_data_fim.Name = "dtp_data_fim";
            dtp_data_fim.Size = new Size(169, 23);
            dtp_data_fim.TabIndex = 19;
            dtp_data_fim.ValueChanged += dtp_data_fim_ValueChanged;
            // 
            // dtp_data_inicio
            // 
            dtp_data_inicio.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_data_inicio.Format = DateTimePickerFormat.Short;
            dtp_data_inicio.Location = new Point(45, 39);
            dtp_data_inicio.Name = "dtp_data_inicio";
            dtp_data_inicio.Size = new Size(169, 23);
            dtp_data_inicio.TabIndex = 18;
            dtp_data_inicio.ValueChanged += dtp_data_inicio_ValueChanged;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.LightGray;
            btn_deletar.Enabled = false;
            btn_deletar.FlatAppearance.BorderColor = Color.Gray;
            btn_deletar.FlatStyle = FlatStyle.Flat;
            btn_deletar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_deletar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_deletar.Image = (Image)resources.GetObject("btn_deletar.Image");
            btn_deletar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_deletar.Location = new Point(449, 540);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(120, 33);
            btn_deletar.TabIndex = 6;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // btn_show_editar
            // 
            btn_show_editar.BackColor = Color.LightGray;
            btn_show_editar.Enabled = false;
            btn_show_editar.FlatAppearance.BorderColor = Color.Gray;
            btn_show_editar.FlatStyle = FlatStyle.Flat;
            btn_show_editar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_editar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_editar.Image = (Image)resources.GetObject("btn_show_editar.Image");
            btn_show_editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_editar.Location = new Point(280, 540);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(120, 33);
            btn_show_editar.TabIndex = 5;
            btn_show_editar.Text = "Editar";
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lbl_total_todas_as_vendas);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(16, 480);
            panel4.Name = "panel4";
            panel4.Size = new Size(841, 33);
            panel4.TabIndex = 24;
            // 
            // lbl_total_todas_as_vendas
            // 
            lbl_total_todas_as_vendas.AutoSize = true;
            lbl_total_todas_as_vendas.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_total_todas_as_vendas.ForeColor = Color.White;
            lbl_total_todas_as_vendas.Location = new Point(54, 6);
            lbl_total_todas_as_vendas.Name = "lbl_total_todas_as_vendas";
            lbl_total_todas_as_vendas.Size = new Size(62, 19);
            lbl_total_todas_as_vendas.TabIndex = 2;
            lbl_total_todas_as_vendas.Text = "R$ 0,00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(5, 7);
            label12.Name = "label12";
            label12.Size = new Size(43, 17);
            label12.TabIndex = 23;
            label12.Text = "Total:";
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(btn_fechar);
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(876, 29);
            panel12.TabIndex = 27;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(224, 224, 224);
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(btn_deletar);
            panel13.Controls.Add(panel4);
            panel13.Controls.Add(btn_show_editar);
            panel13.Controls.Add(panel1);
            panel13.Controls.Add(panel5);
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(876, 596);
            panel13.TabIndex = 28;
            // 
            // MainVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(876, 596);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel12);
            Controls.Add(panel13);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            Shown += MainVenda_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_vendas).EndInit();
            panel5.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dg_vendas;
        private Panel panel5;
        private Panel panel10;
        private Label lbl_valor_total;
        private Label label11;
        private Panel panel8;
        private Label lblReceita_selecionada;
        private Label label7;
        private Panel panel7;
        private ListView listViewProdutos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label6;
        private Panel panel6;
        private Label lblClienteVenda;
        private Label label5;
        private PictureBox pictureBox6;
        private Label label4;
        private DataGridViewTextBoxColumn DataCadastro;
        private Panel panel2;
        private Label lbl_pagamento;
        private Label label2;
        private Button btn_fechar;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private DateTimePicker dtp_data_fim;
        private DateTimePicker dtp_data_inicio;
        private Label label9;
        private Label label8;
        private Button btn_limpar_filtro;
        private Panel panel4;
        private Label lbl_total_todas_as_vendas;
        private Label label12;
        private Button btn_deletar;
        private Button btn_show_editar;
        private Panel panel11;
        private Label label3;
        private Panel panel12;
        private Panel panel14;
        private Panel panel13;
        private Panel panel15;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TipoVenda;
        private DataGridViewTextBoxColumn TipoPagamento;
        private DataGridViewTextBoxColumn Valor;
    }
}