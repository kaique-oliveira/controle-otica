namespace Kvision.Frame.Paginas.PgCliente
{
    partial class PersistirCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersistirCliente));
            btn_salvar = new Button();
            txt_telefone = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            txt_nome = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            txt_complemento = new TextBox();
            label6 = new Label();
            txt_localidade = new TextBox();
            label5 = new Label();
            txt_bairro = new TextBox();
            label4 = new Label();
            txt_logradouro = new TextBox();
            txt_cep = new MaskedTextBox();
            label3 = new Label();
            btn_fechar = new Button();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            btn_salvar.Location = new Point(103, 503);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(85, 33);
            btn_salvar.TabIndex = 13;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone.ForeColor = Color.FromArgb(64, 64, 64);
            txt_telefone.Location = new Point(10, 96);
            txt_telefone.Mask = "(99) 00000-0000";
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(265, 27);
            txt_telefone.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(9, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 8;
            label2.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.ForeColor = Color.FromArgb(64, 64, 64);
            txt_nome.Location = new Point(10, 37);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(265, 27);
            txt_nome.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_complemento);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_localidade);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_bairro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_logradouro);
            panel1.Controls.Add(txt_cep);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_telefone);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nome);
            panel1.Location = new Point(10, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 442);
            panel1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(10, 381);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 19;
            label7.Text = "Complemento:";
            // 
            // txt_complemento
            // 
            txt_complemento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_complemento.ForeColor = Color.FromArgb(64, 64, 64);
            txt_complemento.Location = new Point(12, 402);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(263, 27);
            txt_complemento.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(10, 324);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 17;
            label6.Text = "Cidade:";
            // 
            // txt_localidade
            // 
            txt_localidade.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_localidade.ForeColor = Color.FromArgb(64, 64, 64);
            txt_localidade.Location = new Point(12, 345);
            txt_localidade.Name = "txt_localidade";
            txt_localidade.Size = new Size(263, 27);
            txt_localidade.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(9, 266);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 15;
            label5.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            txt_bairro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_bairro.ForeColor = Color.FromArgb(64, 64, 64);
            txt_bairro.Location = new Point(11, 287);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(265, 27);
            txt_bairro.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(9, 210);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 13;
            label4.Text = "Rua:";
            // 
            // txt_logradouro
            // 
            txt_logradouro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_logradouro.ForeColor = Color.FromArgb(64, 64, 64);
            txt_logradouro.Location = new Point(11, 231);
            txt_logradouro.Name = "txt_logradouro";
            txt_logradouro.Size = new Size(265, 27);
            txt_logradouro.TabIndex = 12;
            // 
            // txt_cep
            // 
            txt_cep.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cep.ForeColor = Color.FromArgb(64, 64, 64);
            txt_cep.Location = new Point(10, 176);
            txt_cep.Mask = "00000-000";
            txt_cep.Name = "txt_cep";
            txt_cep.Size = new Size(265, 27);
            txt_cep.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(9, 155);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 10;
            label3.Text = "CEP:";
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.Silver;
            btn_fechar.BackgroundImage = (Image)resources.GetObject("btn_fechar.BackgroundImage");
            btn_fechar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_fechar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fechar.Location = new Point(279, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(28, 28);
            btn_fechar.TabIndex = 14;
            btn_fechar.TextAlign = ContentAlignment.MiddleRight;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Silver;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(30, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(62, 20);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Clientes";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(btn_salvar);
            panel3.Controls.Add(btn_fechar);
            panel3.Location = new Point(2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 555);
            panel3.TabIndex = 18;
            // 
            // PersistirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(314, 559);
            Controls.Add(pictureBox3);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersistirCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrando cliente";
            Shown += PersistirCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_salvar;
        private MaskedTextBox txt_telefone;
        private Label label2;
        private Label label1;
        private TextBox txt_nome;
        private Panel panel1;
        private Button btn_fechar;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Label label6;
        private TextBox txt_localidade;
        private Label label5;
        private TextBox txt_bairro;
        private Label label4;
        private TextBox txt_logradouro;
        private MaskedTextBox txt_cep;
        private Label label3;
        private Label label7;
        private TextBox txt_complemento;
        private Panel panel3;
    }
}