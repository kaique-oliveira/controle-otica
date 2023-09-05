namespace Kvision.Frame.Paginas.PgVendaProduto
{
    partial class SelecionarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarProduto));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_confirmar = new Button();
            panel2 = new Panel();
            dg_produtos = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            bnt_confirma_escolha = new Button();
            pictureBox1 = new PictureBox();
            btn_fechar = new Button();
            label1 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_produtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_confirmar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 553);
            panel1.TabIndex = 0;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Anchor = AnchorStyles.Bottom;
            btn_confirmar.BackColor = Color.LightGray;
            btn_confirmar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_confirmar.Cursor = Cursors.Hand;
            btn_confirmar.FlatAppearance.BorderColor = Color.Gray;
            btn_confirmar.FlatStyle = FlatStyle.Flat;
            btn_confirmar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirmar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_confirmar.Image = (Image)resources.GetObject("btn_confirmar.Image");
            btn_confirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_confirmar.Location = new Point(159, 512);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(114, 29);
            btn_confirmar.TabIndex = 27;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.TextAlign = ContentAlignment.MiddleRight;
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dg_produtos);
            panel2.Controls.Add(bnt_confirma_escolha);
            panel2.Location = new Point(9, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 457);
            panel2.TabIndex = 31;
            // 
            // dg_produtos
            // 
            dg_produtos.AllowUserToAddRows = false;
            dg_produtos.AllowUserToDeleteRows = false;
            dg_produtos.AllowUserToResizeColumns = false;
            dg_produtos.AllowUserToResizeRows = false;
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
            dg_produtos.ColumnHeadersVisible = false;
            dg_produtos.Columns.AddRange(new DataGridViewColumn[] { nome, quantidade, valor });
            dg_produtos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            dg_produtos.EnableHeadersVisualStyles = false;
            dg_produtos.GridColor = Color.WhiteSmoke;
            dg_produtos.Location = new Point(9, 12);
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
            dg_produtos.Size = new Size(385, 434);
            dg_produtos.TabIndex = 26;
            dg_produtos.CellClick += dg_produtos_CellClick;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 100;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 180;
            // 
            // quantidade
            // 
            quantidade.DataPropertyName = "quantidade";
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // valor
            // 
            valor.DataPropertyName = "valor";
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Width = 95;
            // 
            // bnt_confirma_escolha
            // 
            bnt_confirma_escolha.Anchor = AnchorStyles.Bottom;
            bnt_confirma_escolha.BackColor = Color.WhiteSmoke;
            bnt_confirma_escolha.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_confirma_escolha.Cursor = Cursors.Hand;
            bnt_confirma_escolha.FlatAppearance.BorderSize = 0;
            bnt_confirma_escolha.FlatStyle = FlatStyle.Flat;
            bnt_confirma_escolha.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_confirma_escolha.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_confirma_escolha.Image = (Image)resources.GetObject("bnt_confirma_escolha.Image");
            bnt_confirma_escolha.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_confirma_escolha.Location = new Point(249, 818);
            bnt_confirma_escolha.Name = "bnt_confirma_escolha";
            bnt_confirma_escolha.Size = new Size(114, 29);
            bnt_confirma_escolha.TabIndex = 25;
            bnt_confirma_escolha.Text = "Confirmar";
            bnt_confirma_escolha.TextAlign = ContentAlignment.MiddleRight;
            bnt_confirma_escolha.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(7, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
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
            btn_fechar.Location = new Point(400, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 28;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(32, 3);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 29;
            label1.Text = "Produtos";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(428, 29);
            panel6.TabIndex = 36;
            // 
            // SelecionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(428, 553);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelecionarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelecionarProduto";
            Shown += SelecionarProduto_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_produtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_fechar;
        private Label label1;
        private Panel panel2;
        private Button bnt_confirma_escolha;
        private DataGridView dg_produtos;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn valor;
        private Button btn_confirmar;
        private Panel panel6;
    }
}