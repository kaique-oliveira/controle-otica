namespace Kvision.Frame.Paginas.PgVendaProduto
{
    partial class SelecionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarCliente));
            panel1 = new Panel();
            dg_clientes = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            bnt_confirma_escolha = new Button();
            btn_fechar = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_clientes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dg_clientes);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 458);
            panel1.TabIndex = 0;
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
            dg_clientes.ColumnHeadersVisible = false;
            dg_clientes.Columns.AddRange(new DataGridViewColumn[] { nome, telefone });
            dg_clientes.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dg_clientes.EnableHeadersVisualStyles = false;
            dg_clientes.GridColor = Color.WhiteSmoke;
            dg_clientes.Location = new Point(10, 14);
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
            dg_clientes.Size = new Size(381, 430);
            dg_clientes.TabIndex = 1;
            dg_clientes.CellClick += dg_clientes_CellClick;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "NOME";
            nome.MinimumWidth = 100;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 250;
            // 
            // telefone
            // 
            telefone.DataPropertyName = "telefone";
            telefone.HeaderText = "TELEFONE";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 130;
            // 
            // bnt_confirma_escolha
            // 
            bnt_confirma_escolha.Anchor = AnchorStyles.Bottom;
            bnt_confirma_escolha.BackColor = Color.LightGray;
            bnt_confirma_escolha.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_confirma_escolha.Cursor = Cursors.Hand;
            bnt_confirma_escolha.FlatAppearance.BorderColor = Color.Gray;
            bnt_confirma_escolha.FlatStyle = FlatStyle.Flat;
            bnt_confirma_escolha.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_confirma_escolha.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_confirma_escolha.Image = (Image)resources.GetObject("bnt_confirma_escolha.Image");
            bnt_confirma_escolha.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_confirma_escolha.Location = new Point(149, 511);
            bnt_confirma_escolha.Name = "bnt_confirma_escolha";
            bnt_confirma_escolha.Size = new Size(114, 29);
            bnt_confirma_escolha.TabIndex = 25;
            bnt_confirma_escolha.Text = "Confirmar";
            bnt_confirma_escolha.TextAlign = ContentAlignment.MiddleRight;
            bnt_confirma_escolha.UseVisualStyleBackColor = false;
            bnt_confirma_escolha.Click += bnt_confirma_escolha_Click;
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
            btn_fechar.Location = new Point(400, 2);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 10;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(bnt_confirma_escolha);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 553);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.LightGray;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(28, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(62, 20);
            lblTitulo.TabIndex = 26;
            lblTitulo.Text = "Clientes";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btn_fechar);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(lblTitulo);
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(428, 29);
            panel6.TabIndex = 37;
            // 
            // SelecionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(428, 553);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelecionarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pgSelecionarCliente";
            Shown += pgSelecionarCliente_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_clientes).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dg_clientes;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private Button btn_fechar;
        private Panel panel2;
        private Button bnt_confirma_escolha;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Panel panel6;
    }
}