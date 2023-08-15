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
            panel2 = new Panel();
            btn_fechar = new Button();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            btn_salvar.Location = new Point(181, 8);
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
            panel1.Controls.Add(txt_telefone);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nome);
            panel1.Location = new Point(10, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 140);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btn_fechar);
            panel2.Controls.Add(btn_salvar);
            panel2.Location = new Point(10, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 50);
            panel2.TabIndex = 15;
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
            pictureBox3.Location = new Point(4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(29, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(62, 20);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Clientes";
            // 
            // PersistirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(304, 254);
            Controls.Add(pictureBox3);
            Controls.Add(lblTitulo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersistirCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrando cliente";
            Load += PersistirCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Panel panel2;
        private Button btn_fechar;
        private PictureBox pictureBox3;
        private Label lblTitulo;
    }
}