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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_vendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_pagamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblReceita_selecionada = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblClienteVenda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_limpar_filtro = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_data_fim = new System.Windows.Forms.DateTimePicker();
            this.dtp_data_inicio = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_show_editar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_total_todas_as_vendas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_vendas)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dg_vendas);
            this.panel1.Location = new System.Drawing.Point(9, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 331);
            this.panel1.TabIndex = 0;
            // 
            // dg_vendas
            // 
            this.dg_vendas.AllowUserToAddRows = false;
            this.dg_vendas.AllowUserToDeleteRows = false;
            this.dg_vendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dg_vendas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_vendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_vendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_vendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nome,
            this.TipoPagamento,
            this.Valor});
            this.dg_vendas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_vendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_vendas.EnableHeadersVisualStyles = false;
            this.dg_vendas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dg_vendas.Location = new System.Drawing.Point(5, 7);
            this.dg_vendas.MultiSelect = false;
            this.dg_vendas.Name = "dg_vendas";
            this.dg_vendas.ReadOnly = true;
            this.dg_vendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_vendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_vendas.RowHeadersVisible = false;
            this.dg_vendas.RowTemplate.Height = 25;
            this.dg_vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_vendas.Size = new System.Drawing.Size(441, 318);
            this.dg_vendas.TabIndex = 1;
            this.dg_vendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_vendas_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DataCadastro";
            this.dataGridViewTextBoxColumn1.HeaderText = "DATA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "CLIENTE";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.DataPropertyName = "TipoPagamento";
            this.TipoPagamento.HeaderText = "PAGAMENTO";
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "VALOR";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 90;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(477, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 495);
            this.panel5.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lbl_pagamento);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 33);
            this.panel2.TabIndex = 19;
            // 
            // lbl_pagamento
            // 
            this.lbl_pagamento.AutoSize = true;
            this.lbl_pagamento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_pagamento.Location = new System.Drawing.Point(84, 6);
            this.lbl_pagamento.Name = "lbl_pagamento";
            this.lbl_pagamento.Size = new System.Drawing.Size(0, 21);
            this.lbl_pagamento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pagamento:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Controls.Add(this.lbl_valor_total);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(10, 453);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(329, 33);
            this.panel10.TabIndex = 20;
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_valor_total.Location = new System.Drawing.Point(45, 6);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(0, 21);
            this.lbl_valor_total.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(5, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.lblReceita_selecionada);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(10, 78);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(329, 33);
            this.panel8.TabIndex = 18;
            // 
            // lblReceita_selecionada
            // 
            this.lblReceita_selecionada.AutoSize = true;
            this.lblReceita_selecionada.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReceita_selecionada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReceita_selecionada.Location = new System.Drawing.Point(57, 6);
            this.lblReceita_selecionada.Name = "lblReceita_selecionada";
            this.lblReceita_selecionada.Size = new System.Drawing.Size(0, 21);
            this.lblReceita_selecionada.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(5, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Receita:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Controls.Add(this.listViewProdutos);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(10, 179);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(329, 265);
            this.panel7.TabIndex = 17;
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.BackColor = System.Drawing.Color.LightGray;
            this.listViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewProdutos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewProdutos.Location = new System.Drawing.Point(5, 37);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(319, 223);
            this.listViewProdutos.TabIndex = 18;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Itens:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.lblClienteVenda);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(10, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(329, 33);
            this.panel6.TabIndex = 16;
            // 
            // lblClienteVenda
            // 
            this.lblClienteVenda.AutoSize = true;
            this.lblClienteVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClienteVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClienteVenda.Location = new System.Drawing.Point(52, 6);
            this.lblClienteVenda.Name = "lblClienteVenda";
            this.lblClienteVenda.Size = new System.Drawing.Size(0, 21);
            this.lblClienteVenda.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cliente:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(4, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Detalhes";
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "DATA";
            this.DataCadastro.MinimumWidth = 100;
            this.DataCadastro.Name = "DataCadastro";
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fechar.BackgroundImage")));
            this.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_fechar.Location = new System.Drawing.Point(803, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(28, 28);
            this.btn_fechar.TabIndex = 15;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(29, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vendas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btn_limpar_filtro);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtp_data_fim);
            this.panel3.Controls.Add(this.dtp_data_inicio);
            this.panel3.Location = new System.Drawing.Point(9, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 57);
            this.panel3.TabIndex = 23;
            // 
            // btn_limpar_filtro
            // 
            this.btn_limpar_filtro.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpar_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpar_filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar_filtro.FlatAppearance.BorderSize = 0;
            this.btn_limpar_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar_filtro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_limpar_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_limpar_filtro.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar_filtro.Image")));
            this.btn_limpar_filtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar_filtro.Location = new System.Drawing.Point(341, 20);
            this.btn_limpar_filtro.Name = "btn_limpar_filtro";
            this.btn_limpar_filtro.Size = new System.Drawing.Size(90, 27);
            this.btn_limpar_filtro.TabIndex = 23;
            this.btn_limpar_filtro.Text = "Limpar";
            this.btn_limpar_filtro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpar_filtro.UseVisualStyleBackColor = false;
            this.btn_limpar_filtro.Click += new System.EventHandler(this.btn_limpar_filtro_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(193, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "fim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(13, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(154, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "até";
            // 
            // dtp_data_fim
            // 
            this.dtp_data_fim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_data_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_fim.Location = new System.Drawing.Point(193, 24);
            this.dtp_data_fim.Name = "dtp_data_fim";
            this.dtp_data_fim.Size = new System.Drawing.Size(130, 25);
            this.dtp_data_fim.TabIndex = 19;
            this.dtp_data_fim.ValueChanged += new System.EventHandler(this.dtp_data_fim_ValueChanged);
            // 
            // dtp_data_inicio
            // 
            this.dtp_data_inicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_inicio.Location = new System.Drawing.Point(13, 24);
            this.dtp_data_inicio.Name = "dtp_data_inicio";
            this.dtp_data_inicio.Size = new System.Drawing.Size(130, 25);
            this.dtp_data_inicio.TabIndex = 18;
            this.dtp_data_inicio.ValueChanged += new System.EventHandler(this.dtp_data_inicio_ValueChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.Controls.Add(this.btn_deletar);
            this.panel9.Controls.Add(this.btn_show_editar);
            this.panel9.Location = new System.Drawing.Point(9, 486);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(449, 47);
            this.panel9.TabIndex = 25;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_deletar.FlatAppearance.BorderSize = 0;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_deletar.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletar.Image")));
            this.btn_deletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deletar.Location = new System.Drawing.Point(262, 7);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(120, 33);
            this.btn_deletar.TabIndex = 6;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_show_editar
            // 
            this.btn_show_editar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_show_editar.FlatAppearance.BorderSize = 0;
            this.btn_show_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_editar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_show_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_show_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_show_editar.Image")));
            this.btn_show_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show_editar.Location = new System.Drawing.Point(74, 7);
            this.btn_show_editar.Name = "btn_show_editar";
            this.btn_show_editar.Size = new System.Drawing.Size(120, 33);
            this.btn_show_editar.TabIndex = 5;
            this.btn_show_editar.Text = "Editar";
            this.btn_show_editar.UseVisualStyleBackColor = false;
            this.btn_show_editar.Click += new System.EventHandler(this.btn_show_editar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.lbl_total_todas_as_vendas);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(9, 436);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 33);
            this.panel4.TabIndex = 24;
            // 
            // lbl_total_todas_as_vendas
            // 
            this.lbl_total_todas_as_vendas.AutoSize = true;
            this.lbl_total_todas_as_vendas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total_todas_as_vendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_total_todas_as_vendas.Location = new System.Drawing.Point(45, 6);
            this.lbl_total_todas_as_vendas.Name = "lbl_total_todas_as_vendas";
            this.lbl_total_todas_as_vendas.Size = new System.Drawing.Size(0, 21);
            this.lbl_total_todas_as_vendas.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(5, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Total:";
            // 
            // MainVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Shown += new System.EventHandler(this.MainVenda_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_vendas)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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