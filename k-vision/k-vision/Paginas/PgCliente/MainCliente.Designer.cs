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
            dg_clientes = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            dataCadastro = new DataGridViewTextBoxColumn();
            bnt_cadastrar = new Button();
            panel1 = new Panel();
            btn_show_exames = new Button();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            panel2 = new Panel();
            txt_filtro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dg_clientes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_clientes.Columns.AddRange(new DataGridViewColumn[] { nome, telefone, dataCadastro });
            dg_clientes.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dg_clientes.EnableHeadersVisualStyles = false;
            dg_clientes.GridColor = Color.WhiteSmoke;
            dg_clientes.Location = new Point(176, 59);
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
            dg_clientes.Size = new Size(430, 390);
            dg_clientes.TabIndex = 0;
            dg_clientes.CellClick += dg_clientes_CellClick;
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
            // telefone
            // 
            telefone.DataPropertyName = "telefone";
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 130;
            // 
            // dataCadastro
            // 
            dataCadastro.DataPropertyName = "dataCadastro";
            dataCadastro.HeaderText = "Cadastrado";
            dataCadastro.Name = "dataCadastro";
            dataCadastro.ReadOnly = true;
            // 
            // bnt_cadastrar
            // 
            bnt_cadastrar.BackColor = Color.YellowGreen;
            bnt_cadastrar.FlatAppearance.BorderSize = 0;
            bnt_cadastrar.FlatStyle = FlatStyle.Flat;
            bnt_cadastrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bnt_cadastrar.ForeColor = Color.White;
            bnt_cadastrar.Location = new Point(7, 79);
            bnt_cadastrar.Name = "bnt_cadastrar";
            bnt_cadastrar.Size = new Size(135, 48);
            bnt_cadastrar.TabIndex = 2;
            bnt_cadastrar.Text = "Cadastrar";
            bnt_cadastrar.UseVisualStyleBackColor = false;
            bnt_cadastrar.Click += bnt_show_cadastrar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btn_show_exames);
            panel1.Controls.Add(btn_deletar);
            panel1.Controls.Add(btn_show_editar);
            panel1.Controls.Add(bnt_cadastrar);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 464);
            panel1.TabIndex = 3;
            // 
            // btn_show_exames
            // 
            btn_show_exames.BackColor = Color.DodgerBlue;
            btn_show_exames.FlatAppearance.BorderSize = 0;
            btn_show_exames.FlatStyle = FlatStyle.Flat;
            btn_show_exames.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_exames.ForeColor = Color.White;
            btn_show_exames.Location = new Point(8, 290);
            btn_show_exames.Name = "btn_show_exames";
            btn_show_exames.Size = new Size(135, 48);
            btn_show_exames.TabIndex = 5;
            btn_show_exames.Text = "Ver receitas";
            btn_show_exames.UseVisualStyleBackColor = false;
            btn_show_exames.Click += btn_show_exames_Click;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.Crimson;
            btn_deletar.FlatAppearance.BorderSize = 0;
            btn_deletar.FlatStyle = FlatStyle.Flat;
            btn_deletar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deletar.ForeColor = Color.White;
            btn_deletar.Location = new Point(8, 219);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(135, 48);
            btn_deletar.TabIndex = 4;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // btn_show_editar
            // 
            btn_show_editar.BackColor = Color.Orange;
            btn_show_editar.FlatAppearance.BorderSize = 0;
            btn_show_editar.FlatStyle = FlatStyle.Flat;
            btn_show_editar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_editar.ForeColor = Color.White;
            btn_show_editar.Location = new Point(7, 150);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(135, 48);
            btn_show_editar.TabIndex = 3;
            btn_show_editar.Text = "Editar";
            btn_show_editar.UseVisualStyleBackColor = false;
            btn_show_editar.Click += btn_show_editar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(txt_filtro);
            panel2.Location = new Point(175, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 40);
            panel2.TabIndex = 4;
            // 
            // txt_filtro
            // 
            txt_filtro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtro.Location = new Point(11, 6);
            txt_filtro.Name = "txt_filtro";
            txt_filtro.PlaceholderText = "Buscar cliente por nome ou final do telefone";
            txt_filtro.Size = new Size(407, 27);
            txt_filtro.TabIndex = 0;
            txt_filtro.Tag = "";
            txt_filtro.TextChanged += txt_filtro_TextChanged;
            // 
            // MainCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(636, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dg_clientes);
            Name = "MainCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Shown += MainCliente_Shown;
            ((System.ComponentModel.ISupportInitialize)dg_clientes).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel container_formulario;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label1;
        private TextBox txt_nome;
        private Label lbl_titulo_form;
        private Button button1;
        private DataGridView dg_clientes;
        private Button bnt_cadastrar;
        private Panel panel1;
        private Button btn_show_exames;
        private Button btn_deletar;
        private Button btn_show_editar;
        private Panel panel2;
        private TextBox txt_filtro;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn dataCadastro;
    }
}