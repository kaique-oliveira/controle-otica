namespace Kvision.Frame.Paginas.PgVendaServico
{
    partial class AddServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServico));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            btn_fechar = new Button();
            bnt_confirmar = new Button();
            panel2 = new Panel();
            dg_servicos = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            txt_valor = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            txt_quantidade = new TextBox();
            label2 = new Label();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_servicos).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(lblTitulo);
            panel6.Controls.Add(btn_fechar);
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(416, 29);
            panel6.TabIndex = 41;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(5, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.LightGray;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(30, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(139, 20);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "Selecionar serviços";
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
            btn_fechar.Location = new Point(387, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 28;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // bnt_confirmar
            // 
            bnt_confirmar.Anchor = AnchorStyles.Bottom;
            bnt_confirmar.BackColor = Color.LightGray;
            bnt_confirmar.BackgroundImageLayout = ImageLayout.Stretch;
            bnt_confirmar.Cursor = Cursors.Hand;
            bnt_confirmar.Enabled = false;
            bnt_confirmar.FlatAppearance.BorderColor = Color.Gray;
            bnt_confirmar.FlatStyle = FlatStyle.Flat;
            bnt_confirmar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_confirmar.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_confirmar.Image = (Image)resources.GetObject("bnt_confirmar.Image");
            bnt_confirmar.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_confirmar.Location = new Point(145, 376);
            bnt_confirmar.Name = "bnt_confirmar";
            bnt_confirmar.Size = new Size(114, 29);
            bnt_confirmar.TabIndex = 39;
            bnt_confirmar.Text = "Confirmar";
            bnt_confirmar.TextAlign = ContentAlignment.MiddleRight;
            bnt_confirmar.UseVisualStyleBackColor = false;
            bnt_confirmar.Click += bnt_confirmar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dg_servicos);
            panel2.Location = new Point(11, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 260);
            panel2.TabIndex = 40;
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
            dg_servicos.ColumnHeadersVisible = false;
            dg_servicos.Columns.AddRange(new DataGridViewColumn[] { nome });
            dg_servicos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_servicos.DefaultCellStyle = dataGridViewCellStyle2;
            dg_servicos.EnableHeadersVisualStyles = false;
            dg_servicos.GridColor = Color.WhiteSmoke;
            dg_servicos.Location = new Point(12, 14);
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
            dg_servicos.Size = new Size(362, 232);
            dg_servicos.TabIndex = 31;
            dg_servicos.CellClick += dg_servicos_CellClick;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "NOME";
            nome.MinimumWidth = 100;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 355;
            // 
            // txt_valor
            // 
            txt_valor.BackColor = Color.WhiteSmoke;
            txt_valor.BorderStyle = BorderStyle.FixedSingle;
            txt_valor.Enabled = false;
            txt_valor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valor.ForeColor = Color.FromArgb(64, 64, 64);
            txt_valor.Location = new Point(51, 9);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(116, 27);
            txt_valor.TabIndex = 32;
            txt_valor.TextAlign = HorizontalAlignment.Center;
            txt_valor.KeyPress += TextKeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 30;
            label1.Text = "Valor:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(bnt_confirmar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 421);
            panel1.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_quantidade);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txt_valor);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(11, 311);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 48);
            panel3.TabIndex = 42;
            // 
            // txt_quantidade
            // 
            txt_quantidade.BackColor = Color.WhiteSmoke;
            txt_quantidade.BorderStyle = BorderStyle.FixedSingle;
            txt_quantidade.Enabled = false;
            txt_quantidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantidade.ForeColor = Color.FromArgb(64, 64, 64);
            txt_quantidade.Location = new Point(284, 10);
            txt_quantidade.Name = "txt_quantidade";
            txt_quantidade.Size = new Size(93, 27);
            txt_quantidade.TabIndex = 34;
            txt_quantidade.TextAlign = HorizontalAlignment.Center;
            txt_quantidade.KeyPress += TextNumero;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(193, 12);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 33;
            label2.Text = "Quantidade:";
            // 
            // AddServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(416, 421);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddServico";
            Shown += AddServico_Shown;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_servicos).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Button btn_fechar;
        private Button bnt_confirmar;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private DataGridView dg_servicos;
        private DataGridViewTextBoxColumn nome;
        private TextBox txt_valor;
        private Panel panel3;
        private TextBox txt_quantidade;
        private Label label2;
    }
}