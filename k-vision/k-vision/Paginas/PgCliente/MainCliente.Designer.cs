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
            cep = new DataGridViewTextBoxColumn();
            logradouro = new DataGridViewTextBoxColumn();
            bairro = new DataGridViewTextBoxColumn();
            localidade = new DataGridViewTextBoxColumn();
            complemento = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txt_filtro = new TextBox();
            panel1 = new Panel();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            bnt_cadastrar = new Button();
            btn_fechar = new Button();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            panel4 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_clientes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(dg_clientes);
            panel3.Location = new Point(7, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 357);
            panel3.TabIndex = 8;
            // 
            // dg_clientes
            // 
            dg_clientes.AllowUserToAddRows = false;
            dg_clientes.AllowUserToDeleteRows = false;
            dg_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dg_clientes.BackgroundColor = Color.WhiteSmoke;
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
            dg_clientes.Columns.AddRange(new DataGridViewColumn[] { nome, telefone, dataCadastro, cep, logradouro, bairro, localidade, complemento });
            dg_clientes.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dg_clientes.EnableHeadersVisualStyles = false;
            dg_clientes.GridColor = Color.WhiteSmoke;
            dg_clientes.Location = new Point(5, 5);
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
            dg_clientes.Size = new Size(1171, 348);
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
            // cep
            // 
            cep.DataPropertyName = "cep";
            cep.HeaderText = "CEP";
            cep.Name = "cep";
            cep.ReadOnly = true;
            // 
            // logradouro
            // 
            logradouro.DataPropertyName = "logradouro";
            logradouro.HeaderText = "RUA";
            logradouro.Name = "logradouro";
            logradouro.ReadOnly = true;
            logradouro.Width = 200;
            // 
            // bairro
            // 
            bairro.DataPropertyName = "bairro";
            bairro.HeaderText = "BAIRRO";
            bairro.Name = "bairro";
            bairro.ReadOnly = true;
            bairro.Width = 160;
            // 
            // localidade
            // 
            localidade.DataPropertyName = "localidade";
            localidade.HeaderText = "CIDADE";
            localidade.Name = "localidade";
            localidade.ReadOnly = true;
            localidade.Width = 110;
            // 
            // complemento
            // 
            complemento.DataPropertyName = "complemento";
            complemento.HeaderText = "Complemento";
            complemento.Name = "complemento";
            complemento.ReadOnly = true;
            complemento.Width = 140;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txt_filtro);
            panel2.Location = new Point(7, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 40);
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
            txt_filtro.Size = new Size(436, 27);
            txt_filtro.TabIndex = 0;
            txt_filtro.Tag = "";
            txt_filtro.TextChanged += txt_filtro_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btn_deletar);
            panel1.Controls.Add(btn_show_editar);
            panel1.Controls.Add(bnt_cadastrar);
            panel1.Location = new Point(7, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 50);
            panel1.TabIndex = 6;
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
            btn_deletar.Location = new Point(651, 8);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(120, 33);
            btn_deletar.TabIndex = 4;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            btn_deletar.Click += btn_deletar_Click;
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
            btn_show_editar.Location = new Point(496, 8);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(120, 33);
            btn_show_editar.TabIndex = 3;
            btn_show_editar.Text = "Editar";
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // bnt_cadastrar
            // 
            bnt_cadastrar.BackColor = SystemColors.ButtonFace;
            bnt_cadastrar.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_cadastrar.FlatAppearance.BorderSize = 0;
            bnt_cadastrar.FlatStyle = FlatStyle.Flat;
            bnt_cadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_cadastrar.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_cadastrar.Image = (Image)resources.GetObject("bnt_cadastrar.Image");
            bnt_cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_cadastrar.Location = new Point(341, 8);
            bnt_cadastrar.Name = "bnt_cadastrar";
            bnt_cadastrar.Size = new Size(120, 33);
            bnt_cadastrar.TabIndex = 2;
            bnt_cadastrar.Text = "Cadastrar";
            bnt_cadastrar.TextAlign = ContentAlignment.MiddleRight;
            bnt_cadastrar.UseVisualStyleBackColor = false;
            bnt_cadastrar.Click += bnt_show_cadastrar_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.FromArgb(224, 224, 224);
            btn_fechar.BackgroundImage = (Image)resources.GetObject("btn_fechar.BackgroundImage");
            btn_fechar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = SystemColors.ActiveCaptionText;
            btn_fechar.Location = new Point(1165, 4);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(28, 28);
            btn_fechar.TabIndex = 9;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(10, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(224, 224, 224);
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(35, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(62, 20);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Clientes";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Location = new Point(2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1196, 501);
            panel4.TabIndex = 18;
            // 
            // MainCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1200, 505);
            Controls.Add(pictureBox3);
            Controls.Add(lblTitulo);
            Controls.Add(btn_fechar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel container_formulario;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label1;
        private TextBox txt_nome;
        private Label lbl_titulo_form;
        private Panel panel3;
        private DataGridView dg_clientes;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txt_filtro;
        private Panel panel1;
        private Button btn_deletar;
        private Button btn_show_editar;
        private Button bnt_cadastrar;
        private Button btn_fechar;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn dataCadastro;
        private DataGridViewTextBoxColumn cep;
        private DataGridViewTextBoxColumn logradouro;
        private DataGridViewTextBoxColumn bairro;
        private DataGridViewTextBoxColumn localidade;
        private DataGridViewTextBoxColumn complemento;
        private Panel panel4;
    }
}