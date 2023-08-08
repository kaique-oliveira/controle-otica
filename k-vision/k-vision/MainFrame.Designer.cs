namespace k_vision
{
    partial class MainFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dg_clientes = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            btn_show_cliente = new ToolStripMenuItem();
            btn_show_prod = new ToolStripMenuItem();
            btn_show_produtos = new ToolStripMenuItem();
            label1 = new Label();
            dg_receitas = new DataGridView();
            DataExame = new DataGridViewTextBoxColumn();
            DataValExame = new DataGridViewTextBoxColumn();
            nomeExaminador = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_clientes).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_receitas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dg_clientes
            // 
            dg_clientes.AllowUserToAddRows = false;
            dg_clientes.AllowUserToDeleteRows = false;
            dg_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            dg_clientes.Columns.AddRange(new DataGridViewColumn[] { nome, telefone });
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
            dg_clientes.Location = new Point(12, 38);
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
            dg_clientes.Size = new Size(320, 119);
            dg_clientes.TabIndex = 5;
            dg_clientes.CellClick += dg_clientes_CellClick;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Cliente";
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
            telefone.Width = 120;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { btn_show_cliente, btn_show_prod });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1033, 25);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // btn_show_cliente
            // 
            btn_show_cliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_cliente.ForeColor = SystemColors.ButtonHighlight;
            btn_show_cliente.Name = "btn_show_cliente";
            btn_show_cliente.Size = new Size(67, 21);
            btn_show_cliente.Text = "Clientes";
            btn_show_cliente.Click += btn_show_cliente_Click;
            // 
            // btn_show_prod
            // 
            btn_show_prod.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_prod.ForeColor = SystemColors.ButtonHighlight;
            btn_show_prod.Name = "btn_show_prod";
            btn_show_prod.Size = new Size(76, 21);
            btn_show_prod.Text = "Produtos";
            btn_show_prod.Click += btn_show_prod_Click;
            // 
            // btn_show_produtos
            // 
            btn_show_produtos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_produtos.ForeColor = SystemColors.ButtonHighlight;
            btn_show_produtos.Name = "btn_show_produtos";
            btn_show_produtos.Size = new Size(80, 24);
            btn_show_produtos.Text = "Produtos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 68);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 7;
            label1.Text = "Selecione um cliente";
            // 
            // dg_receitas
            // 
            dg_receitas.AllowUserToAddRows = false;
            dg_receitas.AllowUserToDeleteRows = false;
            dg_receitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dg_receitas.BackgroundColor = Color.WhiteSmoke;
            dg_receitas.BorderStyle = BorderStyle.None;
            dg_receitas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_receitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Silver;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dg_receitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg_receitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_receitas.Columns.AddRange(new DataGridViewColumn[] { DataExame, DataValExame, nomeExaminador });
            dg_receitas.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dg_receitas.DefaultCellStyle = dataGridViewCellStyle5;
            dg_receitas.Enabled = false;
            dg_receitas.EnableHeadersVisualStyles = false;
            dg_receitas.GridColor = Color.WhiteSmoke;
            dg_receitas.Location = new Point(12, 40);
            dg_receitas.MultiSelect = false;
            dg_receitas.Name = "dg_receitas";
            dg_receitas.ReadOnly = true;
            dg_receitas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dg_receitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dg_receitas.RowHeadersVisible = false;
            dg_receitas.RowTemplate.Height = 25;
            dg_receitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_receitas.Size = new Size(320, 117);
            dg_receitas.TabIndex = 8;
            // 
            // DataExame
            // 
            DataExame.DataPropertyName = "DataExame";
            DataExame.HeaderText = "Data";
            DataExame.Name = "DataExame";
            DataExame.ReadOnly = true;
            // 
            // DataValExame
            // 
            DataValExame.DataPropertyName = "DataValExame";
            DataValExame.HeaderText = "Validade";
            DataValExame.MinimumWidth = 60;
            DataValExame.Name = "DataValExame";
            DataValExame.ReadOnly = true;
            // 
            // nomeExaminador
            // 
            nomeExaminador.DataPropertyName = "nomeExaminador";
            nomeExaminador.HeaderText = "Doutor";
            nomeExaminador.Name = "nomeExaminador";
            nomeExaminador.ReadOnly = true;
            nomeExaminador.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 6);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 9;
            label2.Text = "Selecione uma receita";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dg_clientes);
            panel1.Location = new Point(26, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 201);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 168);
            button1.Name = "button1";
            button1.Size = new Size(320, 28);
            button1.TabIndex = 6;
            button1.Text = "visualizar";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dg_receitas);
            panel2.Location = new Point(26, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 201);
            panel2.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(12, 168);
            button2.Name = "button2";
            button2.Size = new Size(320, 28);
            button2.TabIndex = 7;
            button2.Text = "visualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // MainFrame
            // 
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1033, 522);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.Off;
            MainMenuStrip = menuStrip1;
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += MainFrame_Shown;
            ((System.ComponentModel.ISupportInitialize)dg_clientes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_receitas).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem clienteToolStripMenuItem;
        private Button btn_show_clientes;
        private Button btn_show_produto;
        private DataGridView dg_clientes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_show_produtos;
        private Label label1;
        private ToolStripMenuItem btn_show_cliente;
        private ToolStripMenuItem btn_show_prod;
        private DataGridView dg_receitas;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn DataExame;
        private DataGridViewTextBoxColumn DataValExame;
        private DataGridViewTextBoxColumn nomeExaminador;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
    }
}