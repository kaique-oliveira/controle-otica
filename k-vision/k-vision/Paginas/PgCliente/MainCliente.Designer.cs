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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_clientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_cadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_show_exames = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_show_editar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_clientes
            // 
            this.dg_clientes.AllowUserToAddRows = false;
            this.dg_clientes.AllowUserToDeleteRows = false;
            this.dg_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_clientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dg_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.telefone,
            this.dataCadastro});
            this.dg_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_clientes.EnableHeadersVisualStyles = false;
            this.dg_clientes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dg_clientes.Location = new System.Drawing.Point(183, 59);
            this.dg_clientes.MultiSelect = false;
            this.dg_clientes.Name = "dg_clientes";
            this.dg_clientes.ReadOnly = true;
            this.dg_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_clientes.RowHeadersVisible = false;
            this.dg_clientes.RowTemplate.Height = 25;
            this.dg_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_clientes.Size = new System.Drawing.Size(461, 390);
            this.dg_clientes.TabIndex = 0;
            this.dg_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_clientes_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
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
            // 
            // dataCadastro
            // 
            this.dataCadastro.DataPropertyName = "dataCadastro";
            this.dataCadastro.HeaderText = "Cadastrado";
            this.dataCadastro.Name = "dataCadastro";
            this.dataCadastro.ReadOnly = true;
            // 
            // bnt_cadastrar
            // 
            this.bnt_cadastrar.Location = new System.Drawing.Point(7, 79);
            this.bnt_cadastrar.Name = "bnt_cadastrar";
            this.bnt_cadastrar.Size = new System.Drawing.Size(135, 48);
            this.bnt_cadastrar.TabIndex = 2;
            this.bnt_cadastrar.Text = "Cadastrar";
            this.bnt_cadastrar.UseVisualStyleBackColor = true;
            this.bnt_cadastrar.Click += new System.EventHandler(this.bnt_show_cadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_show_exames);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.btn_show_editar);
            this.panel1.Controls.Add(this.bnt_cadastrar);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 464);
            this.panel1.TabIndex = 3;
            // 
            // btn_show_exames
            // 
            this.btn_show_exames.Location = new System.Drawing.Point(8, 290);
            this.btn_show_exames.Name = "btn_show_exames";
            this.btn_show_exames.Size = new System.Drawing.Size(135, 48);
            this.btn_show_exames.TabIndex = 5;
            this.btn_show_exames.Text = "Ver exames";
            this.btn_show_exames.UseVisualStyleBackColor = true;
            this.btn_show_exames.Click += new System.EventHandler(this.btn_show_exames_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(8, 219);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(135, 48);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_show_editar
            // 
            this.btn_show_editar.Location = new System.Drawing.Point(7, 150);
            this.btn_show_editar.Name = "btn_show_editar";
            this.btn_show_editar.Size = new System.Drawing.Size(135, 48);
            this.btn_show_editar.TabIndex = 3;
            this.btn_show_editar.Text = "Editar";
            this.btn_show_editar.UseVisualStyleBackColor = true;
            this.btn_show_editar.Click += new System.EventHandler(this.btn_show_editar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.txt_filtro);
            this.panel2.Location = new System.Drawing.Point(183, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 40);
            this.panel2.TabIndex = 4;
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(10, 9);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.PlaceholderText = "Buscar cliente por nome ou final do telefone";
            this.txt_filtro.Size = new System.Drawing.Size(439, 23);
            this.txt_filtro.TabIndex = 0;
            this.txt_filtro.Tag = "";
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
            // 
            // MainCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.MainCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn dataCadastro;
        private Panel panel1;
        private Button btn_show_exames;
        private Button btn_deletar;
        private Button btn_show_editar;
        private Panel panel2;
        private TextBox txt_filtro;
    }
}