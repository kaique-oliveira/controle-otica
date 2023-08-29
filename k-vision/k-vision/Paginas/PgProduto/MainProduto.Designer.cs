namespace Kvision.Frame.Paginas.PgProduto
{
    partial class MainProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProduto));
            panel3 = new Panel();
            dg_produtos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            bnt_show_cadastrar = new Button();
            btn_show_editar = new Button();
            btn_deletar = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txt_filtro = new TextBox();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            btn_fechar = new Button();
            panel6 = new Panel();
            panel4 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_produtos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dg_produtos);
            panel3.Location = new Point(16, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 458);
            panel3.TabIndex = 12;
            // 
            // dg_produtos
            // 
            dg_produtos.AllowUserToAddRows = false;
            dg_produtos.AllowUserToDeleteRows = false;
            dg_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dg_produtos.BackgroundColor = Color.LightGray;
            dg_produtos.BorderStyle = BorderStyle.None;
            dg_produtos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_produtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_produtos.Columns.AddRange(new DataGridViewColumn[] { id, nome, quantidade, valor });
            dg_produtos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            dg_produtos.EnableHeadersVisualStyles = false;
            dg_produtos.GridColor = Color.WhiteSmoke;
            dg_produtos.Location = new Point(6, 6);
            dg_produtos.MultiSelect = false;
            dg_produtos.Name = "dg_produtos";
            dg_produtos.ReadOnly = true;
            dg_produtos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dg_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dg_produtos.RowHeadersVisible = false;
            dg_produtos.RowTemplate.Height = 25;
            dg_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_produtos.Size = new Size(430, 443);
            dg_produtos.TabIndex = 5;
            dg_produtos.CellClick += dg_produtos_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Código";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 60;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 100;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 200;
            // 
            // quantidade
            // 
            quantidade.DataPropertyName = "quantidade";
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            quantidade.Width = 90;
            // 
            // valor
            // 
            valor.DataPropertyName = "valor";
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Width = 80;
            // 
            // bnt_show_cadastrar
            // 
            bnt_show_cadastrar.BackColor = Color.LightGray;
            bnt_show_cadastrar.FlatAppearance.BorderColor = Color.Gray;
            bnt_show_cadastrar.FlatStyle = FlatStyle.Flat;
            bnt_show_cadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_show_cadastrar.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_show_cadastrar.Image = (Image)resources.GetObject("bnt_show_cadastrar.Image");
            bnt_show_cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_show_cadastrar.Location = new Point(13, 561);
            bnt_show_cadastrar.Name = "bnt_show_cadastrar";
            bnt_show_cadastrar.Size = new Size(120, 33);
            bnt_show_cadastrar.TabIndex = 2;
            bnt_show_cadastrar.Text = "Cadastrar";
            bnt_show_cadastrar.TextAlign = ContentAlignment.MiddleRight;
            bnt_show_cadastrar.UseVisualStyleBackColor = false;
            bnt_show_cadastrar.Click += bnt_show_cadastrar_Click;
            // 
            // btn_show_editar
            // 
            btn_show_editar.BackColor = Color.LightGray;
            btn_show_editar.FlatAppearance.BorderColor = Color.Gray;
            btn_show_editar.FlatStyle = FlatStyle.Flat;
            btn_show_editar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_editar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_editar.Image = (Image)resources.GetObject("btn_show_editar.Image");
            btn_show_editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_editar.Location = new Point(174, 561);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(120, 33);
            btn_show_editar.TabIndex = 3;
            btn_show_editar.Text = "Editar";
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.LightGray;
            btn_deletar.FlatAppearance.BorderColor = Color.Gray;
            btn_deletar.FlatStyle = FlatStyle.Flat;
            btn_deletar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_deletar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_deletar.Image = (Image)resources.GetObject("btn_deletar.Image");
            btn_deletar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_deletar.Location = new Point(339, 561);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(120, 33);
            btn_deletar.TabIndex = 4;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txt_filtro);
            panel2.Location = new Point(17, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 40);
            panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(6, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // txt_filtro
            // 
            txt_filtro.BackColor = Color.WhiteSmoke;
            txt_filtro.BorderStyle = BorderStyle.FixedSingle;
            txt_filtro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtro.ForeColor = Color.FromArgb(64, 64, 64);
            txt_filtro.Location = new Point(33, 6);
            txt_filtro.Name = "txt_filtro";
            txt_filtro.PlaceholderText = "ex: \"Coleção cassino\"";
            txt_filtro.Size = new Size(402, 27);
            txt_filtro.TabIndex = 1;
            txt_filtro.Tag = "";
            txt_filtro.TextChanged += txt_filtro_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(7, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.LightGray;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(34, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(71, 20);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Produtos";
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
            btn_fechar.Location = new Point(447, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 18;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(btn_fechar);
            panel6.Controls.Add(lblTitulo);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(475, 29);
            panel6.TabIndex = 35;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(bnt_show_cadastrar);
            panel4.Controls.Add(btn_show_editar);
            panel4.Controls.Add(btn_deletar);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(475, 614);
            panel4.TabIndex = 36;
            // 
            // MainProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(475, 614);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Shown += MainProduto_Shown;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_produtos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private DataGridView dg_produtos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn valor;
        private Button bnt_show_cadastrar;
        private Button btn_show_editar;
        private Button btn_deletar;
        private Panel panel2;
        private TextBox txt_filtro;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Button btn_fechar;
        private Panel panel6;
        private Panel panel4;
    }
}