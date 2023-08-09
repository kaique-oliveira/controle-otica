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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_clientes = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_show_prod = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_show_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_receitas = new System.Windows.Forms.DataGridView();
            this.DataExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataValExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeExaminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_gerenciar_clientes = new System.Windows.Forms.Button();
            this.painel_receitas = new System.Windows.Forms.Panel();
            this.btn_gerenciar_receitas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_receitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.painel_receitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_clientes
            // 
            this.dg_clientes.AllowUserToAddRows = false;
            this.dg_clientes.AllowUserToDeleteRows = false;
            this.dg_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dg_clientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dg_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.telefone});
            this.dg_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_clientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dg_clientes.EnableHeadersVisualStyles = false;
            this.dg_clientes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dg_clientes.Location = new System.Drawing.Point(12, 38);
            this.dg_clientes.MultiSelect = false;
            this.dg_clientes.Name = "dg_clientes";
            this.dg_clientes.ReadOnly = true;
            this.dg_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dg_clientes.RowHeadersVisible = false;
            this.dg_clientes.RowTemplate.Height = 25;
            this.dg_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_clientes.Size = new System.Drawing.Size(320, 176);
            this.dg_clientes.TabIndex = 5;
            this.dg_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_clientes_CellClick);
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Cliente";
            this.nome.MinimumWidth = 100;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_show_prod});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_show_prod
            // 
            this.btn_show_prod.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_show_prod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show_prod.Name = "btn_show_prod";
            this.btn_show_prod.Size = new System.Drawing.Size(76, 21);
            this.btn_show_prod.Text = "Produtos";
            // 
            // btn_show_produtos
            // 
            this.btn_show_produtos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_show_produtos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show_produtos.Name = "btn_show_produtos";
            this.btn_show_produtos.Size = new System.Drawing.Size(80, 24);
            this.btn_show_produtos.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(165, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clientes";
            // 
            // dg_receitas
            // 
            this.dg_receitas.AllowUserToAddRows = false;
            this.dg_receitas.AllowUserToDeleteRows = false;
            this.dg_receitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dg_receitas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dg_receitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_receitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_receitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_receitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dg_receitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_receitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataExame,
            this.DataValExame,
            this.nomeExaminador});
            this.dg_receitas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_receitas.DefaultCellStyle = dataGridViewCellStyle11;
            this.dg_receitas.Enabled = false;
            this.dg_receitas.EnableHeadersVisualStyles = false;
            this.dg_receitas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dg_receitas.Location = new System.Drawing.Point(12, 40);
            this.dg_receitas.MultiSelect = false;
            this.dg_receitas.Name = "dg_receitas";
            this.dg_receitas.ReadOnly = true;
            this.dg_receitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_receitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dg_receitas.RowHeadersVisible = false;
            this.dg_receitas.RowTemplate.Height = 25;
            this.dg_receitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_receitas.Size = new System.Drawing.Size(320, 174);
            this.dg_receitas.TabIndex = 8;
            // 
            // DataExame
            // 
            this.DataExame.DataPropertyName = "DataExame";
            this.DataExame.HeaderText = "Data";
            this.DataExame.Name = "DataExame";
            this.DataExame.ReadOnly = true;
            // 
            // DataValExame
            // 
            this.DataValExame.DataPropertyName = "DataValExame";
            this.DataValExame.HeaderText = "Validade";
            this.DataValExame.MinimumWidth = 60;
            this.DataValExame.Name = "DataValExame";
            this.DataValExame.ReadOnly = true;
            // 
            // nomeExaminador
            // 
            this.nomeExaminador.DataPropertyName = "nomeExaminador";
            this.nomeExaminador.HeaderText = "Doutor";
            this.nomeExaminador.Name = "nomeExaminador";
            this.nomeExaminador.ReadOnly = true;
            this.nomeExaminador.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Receitas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btn_gerenciar_clientes);
            this.panel1.Controls.Add(this.dg_clientes);
            this.panel1.Location = new System.Drawing.Point(26, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 258);
            this.panel1.TabIndex = 10;
            // 
            // btn_gerenciar_clientes
            // 
            this.btn_gerenciar_clientes.BackColor = System.Drawing.Color.Khaki;
            this.btn_gerenciar_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerenciar_clientes.FlatAppearance.BorderSize = 0;
            this.btn_gerenciar_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerenciar_clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_gerenciar_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_gerenciar_clientes.Location = new System.Drawing.Point(12, 223);
            this.btn_gerenciar_clientes.Name = "btn_gerenciar_clientes";
            this.btn_gerenciar_clientes.Size = new System.Drawing.Size(320, 28);
            this.btn_gerenciar_clientes.TabIndex = 10;
            this.btn_gerenciar_clientes.Text = "gerenciar clientes";
            this.btn_gerenciar_clientes.UseVisualStyleBackColor = false;
            this.btn_gerenciar_clientes.Click += new System.EventHandler(this.btn_gerenciar_clientes_Click);
            // 
            // painel_receitas
            // 
            this.painel_receitas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.painel_receitas.Controls.Add(this.btn_gerenciar_receitas);
            this.painel_receitas.Controls.Add(this.label2);
            this.painel_receitas.Controls.Add(this.dg_receitas);
            this.painel_receitas.Location = new System.Drawing.Point(26, 366);
            this.painel_receitas.Name = "painel_receitas";
            this.painel_receitas.Size = new System.Drawing.Size(343, 258);
            this.painel_receitas.TabIndex = 11;
            // 
            // btn_gerenciar_receitas
            // 
            this.btn_gerenciar_receitas.BackColor = System.Drawing.Color.Khaki;
            this.btn_gerenciar_receitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerenciar_receitas.Enabled = false;
            this.btn_gerenciar_receitas.FlatAppearance.BorderSize = 0;
            this.btn_gerenciar_receitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerenciar_receitas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_gerenciar_receitas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_gerenciar_receitas.Location = new System.Drawing.Point(12, 223);
            this.btn_gerenciar_receitas.Name = "btn_gerenciar_receitas";
            this.btn_gerenciar_receitas.Size = new System.Drawing.Size(320, 28);
            this.btn_gerenciar_receitas.TabIndex = 7;
            this.btn_gerenciar_receitas.Text = "gerenciar receitas";
            this.btn_gerenciar_receitas.UseVisualStyleBackColor = false;
            this.btn_gerenciar_receitas.Click += new System.EventHandler(this.btn_gerenciar_receitas_Click);
            // 
            // MainFrame
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1033, 654);
            this.Controls.Add(this.painel_receitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainFrame_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_receitas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.painel_receitas.ResumeLayout(false);
            this.painel_receitas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem clienteToolStripMenuItem;
        private Button btn_show_clientes;
        private Button btn_show_produto;
        private DataGridView dg_clientes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_show_produtos;
        private Label label1;
        private ToolStripMenuItem btn_show_prod;
        private DataGridView dg_receitas;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn DataExame;
        private DataGridViewTextBoxColumn DataValExame;
        private DataGridViewTextBoxColumn nomeExaminador;
        private Label label2;
        private Panel panel1;
        private Panel painel_receitas;
        private Button btn_gerenciar_receitas;
        private Button btn_gerenciar_clientes;
    }
}