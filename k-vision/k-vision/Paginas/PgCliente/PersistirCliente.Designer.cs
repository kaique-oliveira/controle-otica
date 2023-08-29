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
            btn_fechar = new Button();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            txt_numero = new MaskedTextBox();
            label8 = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.LightGray;
            btn_salvar.FlatAppearance.BorderColor = Color.Gray;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salvar.Location = new Point(106, 519);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(85, 33);
            btn_salvar.TabIndex = 17;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_telefone
            // 
            txt_telefone.BorderStyle = BorderStyle.FixedSingle;
            txt_telefone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone.ForeColor = Color.FromArgb(64, 64, 64);
            txt_telefone.Location = new Point(10, 91);
            txt_telefone.Mask = "(99) 00000-0000";
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(282, 27);
            txt_telefone.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(9, 70);
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
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.ForeColor = Color.FromArgb(64, 64, 64);
            txt_nome.Location = new Point(10, 34);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(282, 27);
            txt_nome.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_telefone);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nome);
            panel1.Location = new Point(10, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 130);
            panel1.TabIndex = 14;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.LightGray;
            btn_fechar.BackgroundImage = (Image)resources.GetObject("btn_fechar.BackgroundImage");
            btn_fechar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_fechar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fechar.Location = new Point(297, 2);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 14;
            btn_fechar.TextAlign = ContentAlignment.MiddleRight;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(5, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.LightGray;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(30, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(62, 20);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Clientes";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btn_fechar);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btn_salvar);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 565);
            panel3.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(325, 29);
            panel6.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(txt_numero);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_complemento);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_localidade);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_bairro);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_logradouro);
            panel2.Controls.Add(txt_cep);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(8, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 331);
            panel2.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label9);
            panel4.Location = new Point(-1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 25);
            panel4.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(107, 2);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 33;
            label9.Text = "Endereço";
            // 
            // txt_numero
            // 
            txt_numero.BorderStyle = BorderStyle.FixedSingle;
            txt_numero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_numero.ForeColor = Color.FromArgb(64, 64, 64);
            txt_numero.Location = new Point(244, 118);
            txt_numero.Mask = "00000";
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(50, 27);
            txt_numero.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(243, 97);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 32;
            label8.Text = "Nº:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(11, 268);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 31;
            label7.Text = "Complemento:";
            // 
            // txt_complemento
            // 
            txt_complemento.BorderStyle = BorderStyle.FixedSingle;
            txt_complemento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_complemento.ForeColor = Color.FromArgb(64, 64, 64);
            txt_complemento.Location = new Point(13, 289);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(280, 27);
            txt_complemento.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(11, 211);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 30;
            label6.Text = "Cidade:";
            // 
            // txt_localidade
            // 
            txt_localidade.BorderStyle = BorderStyle.FixedSingle;
            txt_localidade.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_localidade.ForeColor = Color.FromArgb(64, 64, 64);
            txt_localidade.Location = new Point(13, 232);
            txt_localidade.Name = "txt_localidade";
            txt_localidade.Size = new Size(280, 27);
            txt_localidade.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(10, 153);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 28;
            label5.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            txt_bairro.BorderStyle = BorderStyle.FixedSingle;
            txt_bairro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_bairro.ForeColor = Color.FromArgb(64, 64, 64);
            txt_bairro.Location = new Point(12, 174);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(282, 27);
            txt_bairro.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(10, 97);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 25;
            label4.Text = "Rua:";
            // 
            // txt_logradouro
            // 
            txt_logradouro.BorderStyle = BorderStyle.FixedSingle;
            txt_logradouro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_logradouro.ForeColor = Color.FromArgb(64, 64, 64);
            txt_logradouro.Location = new Point(12, 118);
            txt_logradouro.Name = "txt_logradouro";
            txt_logradouro.Size = new Size(230, 27);
            txt_logradouro.TabIndex = 23;
            // 
            // txt_cep
            // 
            txt_cep.BorderStyle = BorderStyle.FixedSingle;
            txt_cep.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cep.ForeColor = Color.FromArgb(64, 64, 64);
            txt_cep.Location = new Point(11, 63);
            txt_cep.Mask = "00000-000";
            txt_cep.Name = "txt_cep";
            txt_cep.Size = new Size(282, 27);
            txt_cep.TabIndex = 22;
            txt_cep.Validated += txt_cep_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(10, 42);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 21;
            label3.Text = "CEP:";
            // 
            // PersistirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(325, 565);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel3;
        private Panel panel2;
        private MaskedTextBox txt_numero;
        private Label label8;
        private Label label7;
        private TextBox txt_complemento;
        private Label label6;
        private TextBox txt_localidade;
        private Label label5;
        private TextBox txt_bairro;
        private Label label4;
        private TextBox txt_logradouro;
        private MaskedTextBox txt_cep;
        private Label label3;
        private Label label9;
        private Panel panel4;
        private Panel panel6;
    }
}