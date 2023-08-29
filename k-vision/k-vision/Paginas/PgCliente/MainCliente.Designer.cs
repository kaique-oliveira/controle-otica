namespace Kvision.Frame.Paginas.PgCliente
{
    partial class MainCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCliente));
            panel3 = new Panel();
            dg_clientes = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            dataCadastro = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txt_filtro = new TextBox();
            btn_show_receitas = new Button();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            bnt_cadastrar = new Button();
            btn_fechar = new Button();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            label9 = new Label();
            txt_numero = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            txt_complemento = new TextBox();
            label6 = new Label();
            txt_localidade = new TextBox();
            label5 = new Label();
            txt_bairro = new TextBox();
            label4 = new Label();
            txt_logradouro = new TextBox();
            txt_cep = new MaskedTextBox();
            label3 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_clientes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dg_clientes);
            panel3.Location = new Point(7, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 357);
            panel3.TabIndex = 8;
            // 
            // dg_clientes
            // 
            dg_clientes.AllowUserToAddRows = false;
            dg_clientes.AllowUserToDeleteRows = false;
            dg_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dg_clientes.BackgroundColor = Color.LightGray;
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
            dg_clientes.Columns.AddRange(new DataGridViewColumn[] { nome, telefone, dataCadastro });
            dg_clientes.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dg_clientes.EnableHeadersVisualStyles = false;
            dg_clientes.GridColor = Color.WhiteSmoke;
            dg_clientes.Location = new Point(4, 7);
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
            dg_clientes.Size = new Size(463, 340);
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
            telefone.Width = 130;
            // 
            // dataCadastro
            // 
            dataCadastro.DataPropertyName = "dataCadastro";
            dataCadastro.HeaderText = "CADASTRADO";
            dataCadastro.Name = "dataCadastro";
            dataCadastro.ReadOnly = true;
            dataCadastro.Width = 130;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txt_filtro);
            panel2.Location = new Point(7, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 40);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(6, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // txt_filtro
            // 
            txt_filtro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtro.Location = new Point(34, 6);
            txt_filtro.Name = "txt_filtro";
            txt_filtro.PlaceholderText = "ex: \"João\" ou \"9622\"";
            txt_filtro.Size = new Size(431, 27);
            txt_filtro.TabIndex = 0;
            txt_filtro.Tag = "";
            txt_filtro.TextChanged += txt_filtro_TextChanged;
            // 
            // btn_show_receitas
            // 
            btn_show_receitas.BackColor = Color.LightGray;
            btn_show_receitas.Enabled = false;
            btn_show_receitas.FlatAppearance.BorderColor = Color.Gray;
            btn_show_receitas.FlatStyle = FlatStyle.Flat;
            btn_show_receitas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_receitas.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_receitas.Image = (Image)resources.GetObject("btn_show_receitas.Image");
            btn_show_receitas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_receitas.Location = new Point(283, 465);
            btn_show_receitas.Name = "btn_show_receitas";
            btn_show_receitas.Size = new Size(109, 33);
            btn_show_receitas.TabIndex = 5;
            btn_show_receitas.Text = "Receitas";
            btn_show_receitas.TextAlign = ContentAlignment.MiddleRight;
            btn_show_receitas.UseVisualStyleBackColor = false;
            btn_show_receitas.Click += btn_show_receitas_Click;
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
            btn_deletar.Location = new Point(587, 465);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(114, 33);
            btn_deletar.TabIndex = 4;
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
            btn_show_editar.Location = new Point(432, 465);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(114, 33);
            btn_show_editar.TabIndex = 3;
            btn_show_editar.Text = "Editar";
            btn_show_editar.TextAlign = ContentAlignment.MiddleRight;
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // bnt_cadastrar
            // 
            bnt_cadastrar.BackColor = Color.LightGray;
            bnt_cadastrar.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_cadastrar.FlatAppearance.BorderColor = Color.Gray;
            bnt_cadastrar.FlatStyle = FlatStyle.Flat;
            bnt_cadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_cadastrar.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_cadastrar.Image = (Image)resources.GetObject("bnt_cadastrar.Image");
            bnt_cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_cadastrar.Location = new Point(126, 465);
            bnt_cadastrar.Name = "bnt_cadastrar";
            bnt_cadastrar.Size = new Size(114, 33);
            bnt_cadastrar.TabIndex = 2;
            bnt_cadastrar.Text = "Cadastrar";
            bnt_cadastrar.TextAlign = ContentAlignment.MiddleRight;
            bnt_cadastrar.UseVisualStyleBackColor = false;
            bnt_cadastrar.Click += bnt_show_cadastrar_Click;
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
            btn_fechar.Location = new Point(840, 2);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 9;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(8, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.LightGray;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(34, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(62, 20);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Clientes";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btn_fechar);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(btn_show_receitas);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btn_deletar);
            panel4.Controls.Add(btn_show_editar);
            panel4.Controls.Add(bnt_cadastrar);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(868, 513);
            panel4.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(868, 29);
            panel6.TabIndex = 34;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(txt_numero);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txt_complemento);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txt_localidade);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txt_bairro);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txt_logradouro);
            panel5.Controls.Add(txt_cep);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(485, 88);
            panel5.Name = "panel5";
            panel5.Size = new Size(375, 357);
            panel5.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 25);
            panel1.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(142, 2);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 33;
            label9.Text = "Endereço";
            // 
            // txt_numero
            // 
            txt_numero.BackColor = Color.WhiteSmoke;
            txt_numero.BorderStyle = BorderStyle.FixedSingle;
            txt_numero.Enabled = false;
            txt_numero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_numero.ForeColor = Color.FromArgb(64, 64, 64);
            txt_numero.Location = new Point(304, 122);
            txt_numero.Mask = "00000";
            txt_numero.Name = "txt_numero";
            txt_numero.PromptChar = '.';
            txt_numero.Size = new Size(60, 27);
            txt_numero.TabIndex = 24;
            txt_numero.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(302, 101);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 32;
            label8.Text = "Nº:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(7, 292);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 31;
            label7.Text = "Complemento:";
            // 
            // txt_complemento
            // 
            txt_complemento.BackColor = Color.WhiteSmoke;
            txt_complemento.BorderStyle = BorderStyle.FixedSingle;
            txt_complemento.Enabled = false;
            txt_complemento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_complemento.ForeColor = Color.FromArgb(64, 64, 64);
            txt_complemento.Location = new Point(10, 315);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(354, 27);
            txt_complemento.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(5, 227);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 30;
            label6.Text = "Cidade:";
            // 
            // txt_localidade
            // 
            txt_localidade.BackColor = Color.WhiteSmoke;
            txt_localidade.BorderStyle = BorderStyle.FixedSingle;
            txt_localidade.Enabled = false;
            txt_localidade.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_localidade.ForeColor = Color.FromArgb(64, 64, 64);
            txt_localidade.Location = new Point(10, 248);
            txt_localidade.Name = "txt_localidade";
            txt_localidade.Size = new Size(354, 27);
            txt_localidade.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(7, 160);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 28;
            label5.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            txt_bairro.BackColor = Color.WhiteSmoke;
            txt_bairro.BorderStyle = BorderStyle.FixedSingle;
            txt_bairro.Enabled = false;
            txt_bairro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_bairro.ForeColor = Color.FromArgb(64, 64, 64);
            txt_bairro.Location = new Point(10, 183);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(354, 27);
            txt_bairro.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(5, 101);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 25;
            label4.Text = "Rua:";
            // 
            // txt_logradouro
            // 
            txt_logradouro.BackColor = Color.WhiteSmoke;
            txt_logradouro.BorderStyle = BorderStyle.FixedSingle;
            txt_logradouro.Enabled = false;
            txt_logradouro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_logradouro.ForeColor = Color.FromArgb(64, 64, 64);
            txt_logradouro.Location = new Point(9, 122);
            txt_logradouro.Name = "txt_logradouro";
            txt_logradouro.Size = new Size(289, 27);
            txt_logradouro.TabIndex = 23;
            // 
            // txt_cep
            // 
            txt_cep.BackColor = Color.WhiteSmoke;
            txt_cep.BorderStyle = BorderStyle.FixedSingle;
            txt_cep.Enabled = false;
            txt_cep.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cep.ForeColor = Color.FromArgb(64, 64, 64);
            txt_cep.Location = new Point(7, 58);
            txt_cep.Mask = "00000-000";
            txt_cep.Name = "txt_cep";
            txt_cep.Size = new Size(87, 27);
            txt_cep.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(3, 37);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 21;
            label3.Text = "CEP:";
            // 
            // MainCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(868, 513);
            Controls.Add(pictureBox3);
            Controls.Add(lblTitulo);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Shown += MainCliente_Shown;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_clientes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel container_formulario;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private TextBox txt_nome;
        private Label lbl_titulo_form;
        private Panel panel3;
        private DataGridView dg_clientes;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txt_filtro;
        private Button btn_deletar;
        private Button btn_show_editar;
        private Button bnt_cadastrar;
        private Button btn_fechar;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Panel panel4;
        private Button btn_show_receitas;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn dataCadastro;
        private Panel panel5;
        private MaskedTextBox txt_numero;
        private Label label8;
        private Label label7;
        private TextBox txt_complemento;
        private Label label6;
        private TextBox txt_localidade;
        private Label label5;
        private TextBox txt_bairro;
        private Label label4;
        private TextBox txt_logradouro;
        private MaskedTextBox txt_cep;
        private Label label3;
        private Panel panel6;
        private Panel panel1;
        private Label label9;
    }
}