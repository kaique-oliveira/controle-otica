namespace Kvision.Frame.Paginas.PgProduto
{
    partial class PersistirProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersistirProduto));
            label1 = new Label();
            txt_nome = new TextBox();
            txt_valor = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            txt_quantidade = new MaskedTextBox();
            btn_salvar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_fechar = new Button();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(11, 37);
            txt_nome.Name = "txt_nome";
            txt_nome.PlaceholderText = "Nome do produto ou coleção";
            txt_nome.Size = new Size(260, 27);
            txt_nome.TabIndex = 1;
            // 
            // txt_valor
            // 
            txt_valor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valor.Location = new Point(12, 161);
            txt_valor.Mask = "000,00";
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(259, 27);
            txt_valor.TabIndex = 3;
            txt_valor.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(8, 78);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantidade em estoque:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(9, 138);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 5;
            label3.Text = "Valor por unidade:";
            // 
            // txt_quantidade
            // 
            txt_quantidade.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantidade.Location = new Point(10, 101);
            txt_quantidade.Mask = "00000 ";
            txt_quantidade.Name = "txt_quantidade";
            txt_quantidade.Size = new Size(261, 27);
            txt_quantidade.TabIndex = 2;
            txt_quantidade.ValidatingType = typeof(int);
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = SystemColors.ButtonFace;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salvar.Location = new Point(184, 9);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(85, 33);
            btn_salvar.TabIndex = 4;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(txt_nome);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_quantidade);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_valor);
            panel1.Location = new Point(10, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 205);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btn_fechar);
            panel2.Controls.Add(btn_salvar);
            panel2.Location = new Point(10, 260);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 50);
            panel2.TabIndex = 16;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = SystemColors.ButtonFace;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_fechar.Image = (Image)resources.GetObject("btn_fechar.Image");
            btn_fechar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fechar.Location = new Point(16, 9);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(101, 33);
            btn_fechar.TabIndex = 14;
            btn_fechar.Text = "Cancelar";
            btn_fechar.TextAlign = ContentAlignment.MiddleRight;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(27, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(65, 20);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Produto";
            // 
            // PersistirProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(305, 319);
            Controls.Add(pictureBox3);
            Controls.Add(lblTitulo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersistirProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrando Produto";
            Load += PersistirProduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nome;
        private MaskedTextBox txt_valor;
        private Label label2;
        private Label label3;
        private MaskedTextBox txt_quantidade;
        private Button btn_salvar;
        private Panel panel1;
        private Panel panel2;
        private Button btn_fechar;
        private PictureBox pictureBox3;
        private Label lblTitulo;
    }
}