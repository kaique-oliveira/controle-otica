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
            panel1 = new Panel();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            bnt_show_cadastrar = new Button();
            panel2 = new Panel();
            txt_filtro = new TextBox();
            dg_produtos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_produtos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btn_deletar);
            panel1.Controls.Add(btn_show_editar);
            panel1.Controls.Add(bnt_show_cadastrar);
            panel1.Location = new Point(0, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 458);
            panel1.TabIndex = 4;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.Crimson;
            btn_deletar.FlatAppearance.BorderSize = 0;
            btn_deletar.FlatStyle = FlatStyle.Flat;
            btn_deletar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deletar.ForeColor = Color.White;
            btn_deletar.Location = new Point(8, 251);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(135, 48);
            btn_deletar.TabIndex = 4;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_show_editar
            // 
            btn_show_editar.BackColor = Color.Orange;
            btn_show_editar.FlatAppearance.BorderSize = 0;
            btn_show_editar.FlatStyle = FlatStyle.Flat;
            btn_show_editar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_editar.ForeColor = Color.White;
            btn_show_editar.Location = new Point(7, 182);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(135, 48);
            btn_show_editar.TabIndex = 3;
            btn_show_editar.Text = "Editar";
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // bnt_show_cadastrar
            // 
            bnt_show_cadastrar.BackColor = Color.YellowGreen;
            bnt_show_cadastrar.FlatAppearance.BorderSize = 0;
            bnt_show_cadastrar.FlatStyle = FlatStyle.Flat;
            bnt_show_cadastrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bnt_show_cadastrar.ForeColor = Color.White;
            bnt_show_cadastrar.Location = new Point(7, 111);
            bnt_show_cadastrar.Name = "bnt_show_cadastrar";
            bnt_show_cadastrar.Size = new Size(135, 48);
            bnt_show_cadastrar.TabIndex = 2;
            bnt_show_cadastrar.Text = "Cadastrar";
            bnt_show_cadastrar.UseVisualStyleBackColor = false;
            bnt_show_cadastrar.Click += bnt_show_cadastrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(txt_filtro);
            panel2.Location = new Point(181, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 40);
            panel2.TabIndex = 6;
            // 
            // txt_filtro
            // 
            txt_filtro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtro.Location = new Point(10, 7);
            txt_filtro.Name = "txt_filtro";
            txt_filtro.PlaceholderText = "Buscar produto pelo nome";
            txt_filtro.Size = new Size(410, 27);
            txt_filtro.TabIndex = 0;
            txt_filtro.Tag = "";
            txt_filtro.TextChanged += txt_filtro_TextChanged;
            // 
            // dg_produtos
            // 
            dg_produtos.AllowUserToAddRows = false;
            dg_produtos.AllowUserToDeleteRows = false;
            dg_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dg_produtos.BackgroundColor = Color.WhiteSmoke;
            dg_produtos.BorderStyle = BorderStyle.None;
            dg_produtos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_produtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_produtos.Columns.AddRange(new DataGridViewColumn[] { id, nome, quantidade, valor });
            dg_produtos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            dg_produtos.EnableHeadersVisualStyles = false;
            dg_produtos.GridColor = Color.WhiteSmoke;
            dg_produtos.Location = new Point(181, 56);
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
            dg_produtos.Size = new Size(430, 376);
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
            // MainProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 444);
            Controls.Add(panel2);
            Controls.Add(dg_produtos);
            Controls.Add(panel1);
            Name = "MainProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Shown += MainProduto_Shown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_produtos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_deletar;
        private Button btn_show_editar;
        private Button bnt_show_cadastrar;
        private Panel panel2;
        private TextBox txt_filtro;
        private DataGridView dg_produtos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn valor;
    }
}