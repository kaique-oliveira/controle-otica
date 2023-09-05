namespace Kvision.Frame.Paginas.PgCaixa
{
    partial class MainCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCaixa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btn_show_vendas = new Button();
            panel12 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_fechar = new Button();
            btn_show_movimentacao = new Button();
            panel3 = new Panel();
            cb_tipo_mov = new ComboBox();
            panel11 = new Panel();
            label3 = new Label();
            btn_limpar_filtro = new Button();
            label9 = new Label();
            label8 = new Label();
            dtp_data_fim = new DateTimePicker();
            dtp_data_inicio = new DateTimePicker();
            panel1 = new Panel();
            label2 = new Label();
            txt_total_caixa = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            Valor = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            dg_movimentacoes = new DataGridView();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_movimentacoes).BeginInit();
            SuspendLayout();
            // 
            // btn_show_vendas
            // 
            btn_show_vendas.BackColor = Color.LightGray;
            btn_show_vendas.Cursor = Cursors.Hand;
            btn_show_vendas.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_show_vendas.FlatStyle = FlatStyle.Flat;
            btn_show_vendas.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_vendas.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_vendas.Image = (Image)resources.GetObject("btn_show_vendas.Image");
            btn_show_vendas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_vendas.Location = new Point(14, 511);
            btn_show_vendas.Name = "btn_show_vendas";
            btn_show_vendas.Size = new Size(128, 28);
            btn_show_vendas.TabIndex = 0;
            btn_show_vendas.Text = "Ver vendas";
            btn_show_vendas.TextAlign = ContentAlignment.MiddleRight;
            btn_show_vendas.UseVisualStyleBackColor = false;
            btn_show_vendas.Click += btn_show_vendas_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(pictureBox1);
            panel12.Controls.Add(label1);
            panel12.Controls.Add(btn_fechar);
            panel12.Location = new Point(-1, -1);
            panel12.Name = "panel12";
            panel12.Size = new Size(667, 29);
            panel12.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(34, 4);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 23;
            label1.Text = "Caixa";
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
            btn_fechar.Location = new Point(639, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 15;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_show_movimentacao
            // 
            btn_show_movimentacao.BackColor = Color.LightGray;
            btn_show_movimentacao.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_movimentacao.Cursor = Cursors.Hand;
            btn_show_movimentacao.FlatAppearance.BorderColor = Color.Gray;
            btn_show_movimentacao.FlatStyle = FlatStyle.Flat;
            btn_show_movimentacao.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_movimentacao.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_movimentacao.Image = (Image)resources.GetObject("btn_show_movimentacao.Image");
            btn_show_movimentacao.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_movimentacao.Location = new Point(186, 510);
            btn_show_movimentacao.Name = "btn_show_movimentacao";
            btn_show_movimentacao.Size = new Size(121, 28);
            btn_show_movimentacao.TabIndex = 31;
            btn_show_movimentacao.Text = "Adicionar";
            btn_show_movimentacao.TextAlign = ContentAlignment.MiddleRight;
            btn_show_movimentacao.UseVisualStyleBackColor = false;
            btn_show_movimentacao.Click += btn_show_movimentacao_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cb_tipo_mov);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dtp_data_fim);
            panel3.Controls.Add(dtp_data_inicio);
            panel3.Location = new Point(14, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 71);
            panel3.TabIndex = 32;
            // 
            // cb_tipo_mov
            // 
            cb_tipo_mov.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipo_mov.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cb_tipo_mov.ForeColor = Color.FromArgb(64, 64, 64);
            cb_tipo_mov.Items.AddRange(new object[] { "Todos", "Entrada", "Saída" });
            cb_tipo_mov.Location = new Point(458, 34);
            cb_tipo_mov.Name = "cb_tipo_mov";
            cb_tipo_mov.Size = new Size(158, 25);
            cb_tipo_mov.TabIndex = 27;
            cb_tipo_mov.SelectedIndexChanged += cb_tipo_mov_SelectedIndexChanged;
            // 
            // panel11
            // 
            panel11.BackColor = Color.RoyalBlue;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(label3);
            panel11.Controls.Add(btn_limpar_filtro);
            panel11.Location = new Point(-1, -1);
            panel11.Name = "panel11";
            panel11.Size = new Size(636, 24);
            panel11.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(191, 2);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 21;
            label3.Text = "Filtro de data";
            // 
            // btn_limpar_filtro
            // 
            btn_limpar_filtro.BackColor = Color.RoyalBlue;
            btn_limpar_filtro.BackgroundImage = (Image)resources.GetObject("btn_limpar_filtro.BackgroundImage");
            btn_limpar_filtro.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpar_filtro.Cursor = Cursors.Hand;
            btn_limpar_filtro.FlatAppearance.BorderColor = Color.Gray;
            btn_limpar_filtro.FlatAppearance.BorderSize = 0;
            btn_limpar_filtro.FlatStyle = FlatStyle.Flat;
            btn_limpar_filtro.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpar_filtro.ForeColor = Color.FromArgb(64, 64, 64);
            btn_limpar_filtro.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpar_filtro.Location = new Point(610, -1);
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
            label9.Location = new Point(213, 39);
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
            label8.Location = new Point(7, 38);
            label8.Name = "label8";
            label8.Size = new Size(24, 16);
            label8.TabIndex = 21;
            label8.Text = "De";
            // 
            // dtp_data_fim
            // 
            dtp_data_fim.Cursor = Cursors.Hand;
            dtp_data_fim.Enabled = false;
            dtp_data_fim.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_data_fim.Format = DateTimePickerFormat.Short;
            dtp_data_fim.Location = new Point(250, 36);
            dtp_data_fim.Name = "dtp_data_fim";
            dtp_data_fim.Size = new Size(169, 23);
            dtp_data_fim.TabIndex = 19;
            dtp_data_fim.ValueChanged += dtp_data_fim_ValueChanged;
            // 
            // dtp_data_inicio
            // 
            dtp_data_inicio.Cursor = Cursors.Hand;
            dtp_data_inicio.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_data_inicio.Format = DateTimePickerFormat.Short;
            dtp_data_inicio.Location = new Point(34, 35);
            dtp_data_inicio.Name = "dtp_data_inicio";
            dtp_data_inicio.Size = new Size(169, 23);
            dtp_data_inicio.TabIndex = 18;
            dtp_data_inicio.ValueChanged += dtp_data_inicio_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 27);
            panel1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(252, 3);
            label2.Name = "label2";
            label2.Size = new Size(127, 18);
            label2.TabIndex = 21;
            label2.Text = "Movimentações";
            // 
            // txt_total_caixa
            // 
            txt_total_caixa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_total_caixa.AutoSize = true;
            txt_total_caixa.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_total_caixa.ForeColor = Color.White;
            txt_total_caixa.Location = new Point(50, 2);
            txt_total_caixa.Name = "txt_total_caixa";
            txt_total_caixa.Size = new Size(62, 19);
            txt_total_caixa.TabIndex = 33;
            txt_total_caixa.Text = "R$ 0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 2);
            label4.Name = "label4";
            label4.Size = new Size(42, 18);
            label4.TabIndex = 22;
            label4.Text = "Total";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_total_caixa);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(14, 466);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 26);
            panel2.TabIndex = 28;
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
            btn_deletar.Location = new Point(530, 508);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(120, 28);
            btn_deletar.TabIndex = 34;
            btn_deletar.Text = "Deletar";
            btn_deletar.TextAlign = ContentAlignment.MiddleRight;
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
            btn_show_editar.Location = new Point(360, 509);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(120, 28);
            btn_show_editar.TabIndex = 33;
            btn_show_editar.Text = "Editar";
            btn_show_editar.TextAlign = ContentAlignment.MiddleRight;
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "VALOR";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 110;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "TIPO";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 120;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "DESCRICÃO";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "DataCadastro";
            dataGridViewTextBoxColumn1.HeaderText = "DATA";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // dg_movimentacoes
            // 
            dg_movimentacoes.AllowUserToAddRows = false;
            dg_movimentacoes.AllowUserToDeleteRows = false;
            dg_movimentacoes.AllowUserToResizeColumns = false;
            dg_movimentacoes.AllowUserToResizeRows = false;
            dg_movimentacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dg_movimentacoes.BackgroundColor = Color.FromArgb(224, 224, 224);
            dg_movimentacoes.BorderStyle = BorderStyle.None;
            dg_movimentacoes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_movimentacoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_movimentacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_movimentacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_movimentacoes.ColumnHeadersVisible = false;
            dg_movimentacoes.Columns.AddRange(new DataGridViewColumn[] { Id, dataGridViewTextBoxColumn1, Descricao, Tipo, Valor });
            dg_movimentacoes.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_movimentacoes.DefaultCellStyle = dataGridViewCellStyle2;
            dg_movimentacoes.EnableHeadersVisualStyles = false;
            dg_movimentacoes.GridColor = Color.WhiteSmoke;
            dg_movimentacoes.Location = new Point(14, 166);
            dg_movimentacoes.MultiSelect = false;
            dg_movimentacoes.Name = "dg_movimentacoes";
            dg_movimentacoes.ReadOnly = true;
            dg_movimentacoes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dg_movimentacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dg_movimentacoes.RowHeadersVisible = false;
            dg_movimentacoes.RowTemplate.Height = 25;
            dg_movimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_movimentacoes.Size = new Size(636, 299);
            dg_movimentacoes.TabIndex = 1;
            dg_movimentacoes.CellClick += dg_movimentacoes_CellClick;
            // 
            // MainCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(665, 550);
            Controls.Add(btn_deletar);
            Controls.Add(btn_show_editar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(btn_show_movimentacao);
            Controls.Add(dg_movimentacoes);
            Controls.Add(panel12);
            Controls.Add(btn_show_vendas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainCaixa";
            Shown += MainCaixa_Shown;
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_movimentacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_show_vendas;
        private Panel panel12;
        private Button btn_fechar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_show_movimentacao;
        private Panel panel3;
        private Panel panel11;
        private Label label3;
        private Button btn_limpar_filtro;
        private Label label9;
        private Label label8;
        private DateTimePicker dtp_data_fim;
        private DateTimePicker dtp_data_inicio;
        private Panel panel1;
        private Label label2;
        private Label txt_total_caixa;
        private Label label4;
        private Panel panel2;
        private ComboBox cb_tipo_mov;
        private Button btn_deletar;
        private Button btn_show_editar;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Id;
        private DataGridView dg_movimentacoes;
    }
}