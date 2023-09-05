namespace Kvision.Frame.Paginas.pgServico
{
    partial class MainServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainServico));
            panel1 = new Panel();
            panel3 = new Panel();
            dg_servicos = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            bnt_show_cadastrar = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txt_filtro = new TextBox();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            btn_fechar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_servicos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btn_deletar);
            panel1.Controls.Add(btn_show_editar);
            panel1.Controls.Add(bnt_show_cadastrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 543);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dg_servicos);
            panel3.Location = new Point(21, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(406, 383);
            panel3.TabIndex = 41;
            // 
            // dg_servicos
            // 
            dg_servicos.AllowUserToAddRows = false;
            dg_servicos.AllowUserToDeleteRows = false;
            dg_servicos.AllowUserToResizeColumns = false;
            dg_servicos.AllowUserToResizeRows = false;
            dg_servicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dg_servicos.BackgroundColor = Color.LightGray;
            dg_servicos.BorderStyle = BorderStyle.None;
            dg_servicos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_servicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_servicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_servicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_servicos.Columns.AddRange(new DataGridViewColumn[] { nome, valor });
            dg_servicos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_servicos.DefaultCellStyle = dataGridViewCellStyle2;
            dg_servicos.EnableHeadersVisualStyles = false;
            dg_servicos.GridColor = Color.WhiteSmoke;
            dg_servicos.Location = new Point(7, 8);
            dg_servicos.MultiSelect = false;
            dg_servicos.Name = "dg_servicos";
            dg_servicos.ReadOnly = true;
            dg_servicos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dg_servicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dg_servicos.RowHeadersVisible = false;
            dg_servicos.RowTemplate.Height = 25;
            dg_servicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_servicos.Size = new Size(390, 365);
            dg_servicos.TabIndex = 0;
            dg_servicos.CellClick += dg_servicos_CellContentClick;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "NOME";
            nome.MinimumWidth = 100;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 260;
            // 
            // valor
            // 
            valor.DataPropertyName = "valor";
            valor.HeaderText = "VALOR";
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Width = 130;
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
            btn_deletar.Location = new Point(312, 495);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(114, 33);
            btn_deletar.TabIndex = 40;
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
            btn_show_editar.Location = new Point(165, 495);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(114, 33);
            btn_show_editar.TabIndex = 39;
            btn_show_editar.Text = "Editar";
            btn_show_editar.TextAlign = ContentAlignment.MiddleRight;
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // bnt_show_cadastrar
            // 
            bnt_show_cadastrar.BackColor = Color.LightGray;
            bnt_show_cadastrar.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_show_cadastrar.FlatAppearance.BorderColor = Color.Gray;
            bnt_show_cadastrar.FlatStyle = FlatStyle.Flat;
            bnt_show_cadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_show_cadastrar.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_show_cadastrar.Image = (Image)resources.GetObject("bnt_show_cadastrar.Image");
            bnt_show_cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_show_cadastrar.Location = new Point(21, 495);
            bnt_show_cadastrar.Name = "bnt_show_cadastrar";
            bnt_show_cadastrar.Size = new Size(114, 33);
            bnt_show_cadastrar.TabIndex = 38;
            bnt_show_cadastrar.Text = "Cadastrar";
            bnt_show_cadastrar.TextAlign = ContentAlignment.MiddleRight;
            bnt_show_cadastrar.UseVisualStyleBackColor = false;
            bnt_show_cadastrar.Click += bnt_show_cadastrar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txt_filtro);
            panel2.Location = new Point(21, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 40);
            panel2.TabIndex = 36;
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
            txt_filtro.PlaceholderText = "ex: \"Impressão de documento\"";
            txt_filtro.Size = new Size(362, 27);
            txt_filtro.TabIndex = 0;
            txt_filtro.Tag = "";
            txt_filtro.TextChanged += txt_filtro_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(lblTitulo);
            panel6.Controls.Add(btn_fechar);
            panel6.Location = new Point(-1, -2);
            panel6.Name = "panel6";
            panel6.Size = new Size(450, 29);
            panel6.TabIndex = 35;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.LightGray;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(29, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(60, 20);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Serviço";
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
            btn_fechar.Location = new Point(420, 2);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 10;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // MainServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(450, 545);
            Controls.Add(panel1);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainServico";
            Shown += MainServico_Shown;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_servicos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_fechar;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txt_filtro;
        private Button btn_deletar;
        private Button btn_show_editar;
        private Button bnt_show_cadastrar;
        private Panel panel3;
        private DataGridView dg_servicos;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn valor;
    }
}