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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            TipoPagamento = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
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
            listViewProdutos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label6 = new Label();
            panel6 = new Panel();
            lblClienteVenda = new Label();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            DataCadastro = new DataGridViewTextBoxColumn();
            btn_fechar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            btn_limpar_filtro = new Button();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            dtp_data_fim = new DateTimePicker();
            dtp_data_inicio = new DateTimePicker();
            panel9 = new Panel();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            panel4 = new Panel();
            lbl_total_todas_as_vendas = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_vendas).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(dg_vendas);
            panel1.Location = new Point(9, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 331);
            panel1.TabIndex = 0;
            // 
            // dg_vendas
            // 
            dg_vendas.AllowUserToAddRows = false;
            dg_vendas.AllowUserToDeleteRows = false;
            dg_vendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dg_vendas.BackgroundColor = SystemColors.ButtonFace;
            dg_vendas.BorderStyle = BorderStyle.None;
            dg_vendas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_vendas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_vendas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Nome, TipoPagamento, Valor });
            dg_vendas.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_vendas.DefaultCellStyle = dataGridViewCellStyle2;
            dg_vendas.EnableHeadersVisualStyles = false;
            dg_vendas.GridColor = Color.WhiteSmoke;
            dg_vendas.Location = new Point(5, 7);
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
            dg_vendas.Size = new Size(441, 318);
            dg_vendas.TabIndex = 1;
            dg_vendas.CellClick += dg_vendas_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "DataCadastro";
            dataGridViewTextBoxColumn1.HeaderText = "DATA";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "CLIENTE";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // TipoPagamento
            // 
            TipoPagamento.DataPropertyName = "TipoPagamento";
            TipoPagamento.HeaderText = "PAGAMENTO";
            TipoPagamento.Name = "TipoPagamento";
            TipoPagamento.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "VALOR";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 90;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(477, 38);
            panel5.Name = "panel5";
            panel5.Size = new Size(348, 495);
            panel5.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
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
            lbl_pagamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pagamento.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_pagamento.Location = new Point(84, 6);
            lbl_pagamento.Name = "lbl_pagamento";
            lbl_pagamento.Size = new Size(0, 21);
            lbl_pagamento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(5, 8);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
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
            panel8.BackColor = Color.LightGray;
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
            lblReceita_selecionada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblReceita_selecionada.ForeColor = Color.FromArgb(64, 64, 64);
            lblReceita_selecionada.Location = new Point(57, 6);
            lblReceita_selecionada.Name = "lblReceita_selecionada";
            lblReceita_selecionada.Size = new Size(0, 21);
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
            panel7.Controls.Add(listViewProdutos);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(10, 179);
            panel7.Name = "panel7";
            panel7.Size = new Size(329, 265);
            panel7.TabIndex = 17;
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
            listViewProdutos.Size = new Size(319, 223);
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
            panel6.Location = new Point(10, 38);
            panel6.Name = "panel6";
            panel6.Size = new Size(329, 33);
            panel6.TabIndex = 16;
            // 
            // lblClienteVenda
            // 
            lblClienteVenda.AutoSize = true;
            lblClienteVenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClienteVenda.ForeColor = Color.FromArgb(64, 64, 64);
            lblClienteVenda.Location = new Point(52, 6);
            lblClienteVenda.Name = "lblClienteVenda";
            lblClienteVenda.Size = new Size(0, 21);
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 5);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 14;
            label4.Text = "Detalhes";
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
            btn_fechar.Location = new Point(803, 2);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(28, 28);
            btn_fechar.TabIndex = 15;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(29, 3);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 21;
            label1.Text = "Vendas";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(btn_limpar_filtro);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dtp_data_fim);
            panel3.Controls.Add(dtp_data_inicio);
            panel3.Location = new Point(9, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 57);
            panel3.TabIndex = 23;
            // 
            // btn_limpar_filtro
            // 
            btn_limpar_filtro.BackColor = Color.Transparent;
            btn_limpar_filtro.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpar_filtro.Cursor = Cursors.Hand;
            btn_limpar_filtro.FlatAppearance.BorderSize = 0;
            btn_limpar_filtro.FlatStyle = FlatStyle.Flat;
            btn_limpar_filtro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpar_filtro.ForeColor = Color.FromArgb(64, 64, 64);
            btn_limpar_filtro.Image = (Image)resources.GetObject("btn_limpar_filtro.Image");
            btn_limpar_filtro.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtro.Location = new Point(341, 20);
            btn_limpar_filtro.Name = "btn_limpar_filtro";
            btn_limpar_filtro.Size = new Size(90, 27);
            btn_limpar_filtro.TabIndex = 23;
            btn_limpar_filtro.Text = "Limpar";
            btn_limpar_filtro.TextAlign = ContentAlignment.MiddleRight;
            btn_limpar_filtro.UseVisualStyleBackColor = false;
            btn_limpar_filtro.Click += btn_limpar_filtro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(193, 4);
            label9.Name = "label9";
            label9.Size = new Size(33, 17);
            label9.TabIndex = 22;
            label9.Text = "fim:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(13, 4);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 21;
            label8.Text = "Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(154, 29);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 20;
            label3.Text = "até";
            // 
            // dtp_data_fim
            // 
            dtp_data_fim.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_data_fim.Format = DateTimePickerFormat.Short;
            dtp_data_fim.Location = new Point(193, 24);
            dtp_data_fim.Name = "dtp_data_fim";
            dtp_data_fim.Size = new Size(130, 25);
            dtp_data_fim.TabIndex = 19;
            dtp_data_fim.ValueChanged += dtp_data_fim_ValueChanged;
            // 
            // dtp_data_inicio
            // 
            dtp_data_inicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_data_inicio.Format = DateTimePickerFormat.Short;
            dtp_data_inicio.Location = new Point(13, 24);
            dtp_data_inicio.Name = "dtp_data_inicio";
            dtp_data_inicio.Size = new Size(130, 25);
            dtp_data_inicio.TabIndex = 18;
            dtp_data_inicio.ValueChanged += dtp_data_inicio_ValueChanged;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ControlLight;
            panel9.Controls.Add(btn_deletar);
            panel9.Controls.Add(btn_show_editar);
            panel9.Location = new Point(9, 486);
            panel9.Name = "panel9";
            panel9.Size = new Size(449, 47);
            panel9.TabIndex = 25;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = SystemColors.ButtonFace;
            btn_deletar.FlatAppearance.BorderSize = 0;
            btn_deletar.FlatStyle = FlatStyle.Flat;
            btn_deletar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_deletar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_deletar.Image = (Image)resources.GetObject("btn_deletar.Image");
            btn_deletar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_deletar.Location = new Point(262, 7);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(120, 33);
            btn_deletar.TabIndex = 6;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_show_editar
            // 
            btn_show_editar.BackColor = SystemColors.ButtonFace;
            btn_show_editar.FlatAppearance.BorderSize = 0;
            btn_show_editar.FlatStyle = FlatStyle.Flat;
            btn_show_editar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_editar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_editar.Image = (Image)resources.GetObject("btn_show_editar.Image");
            btn_show_editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_editar.Location = new Point(74, 7);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(120, 33);
            btn_show_editar.TabIndex = 5;
            btn_show_editar.Text = "Editar";
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(lbl_total_todas_as_vendas);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(9, 436);
            panel4.Name = "panel4";
            panel4.Size = new Size(449, 33);
            panel4.TabIndex = 24;
            // 
            // lbl_total_todas_as_vendas
            // 
            lbl_total_todas_as_vendas.AutoSize = true;
            lbl_total_todas_as_vendas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_total_todas_as_vendas.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_total_todas_as_vendas.Location = new Point(45, 6);
            lbl_total_todas_as_vendas.Name = "lbl_total_todas_as_vendas";
            lbl_total_todas_as_vendas.Size = new Size(0, 21);
            lbl_total_todas_as_vendas.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(5, 7);
            label12.Name = "label12";
            label12.Size = new Size(43, 17);
            label12.TabIndex = 23;
            label12.Text = "Total:";
            // 
            // MainVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 542);
            Controls.Add(panel4);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_fechar);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            Shown += MainVenda_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_vendas).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label3;
        private Button btn_limpar_filtro;
        private Panel panel9;
        private Panel panel4;
        private Label lbl_total_todas_as_vendas;
        private Label label12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn TipoPagamento;
        private DataGridViewTextBoxColumn Valor;
        private Button btn_deletar;
        private Button btn_show_editar;
    }
}