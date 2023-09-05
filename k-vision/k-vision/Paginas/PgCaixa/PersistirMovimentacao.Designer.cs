namespace Kvision.Frame.Paginas.PgCaixa
{
    partial class PersistirMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersistirMovimentacao));
            panel1 = new Panel();
            label4 = new Label();
            txt_valor = new TextBox();
            cb_tipo_mov = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txt_descricao = new TextBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btn_fechar = new Button();
            btn_salvar_edicao = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_valor);
            panel1.Controls.Add(cb_tipo_mov);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_descricao);
            panel1.Location = new Point(12, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 200);
            panel1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(10, 135);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 36;
            label4.Text = "Valor:";
            // 
            // txt_valor
            // 
            txt_valor.BackColor = Color.WhiteSmoke;
            txt_valor.BorderStyle = BorderStyle.FixedSingle;
            txt_valor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valor.ForeColor = Color.FromArgb(64, 64, 64);
            txt_valor.Location = new Point(10, 158);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(282, 27);
            txt_valor.TabIndex = 35;
            txt_valor.TextAlign = HorizontalAlignment.Center;
            txt_valor.KeyPress += TextKeyPress;
            // 
            // cb_tipo_mov
            // 
            cb_tipo_mov.Font = new Font("Century Gothic", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cb_tipo_mov.ForeColor = Color.FromArgb(64, 64, 64);
            cb_tipo_mov.FormattingEnabled = true;
            cb_tipo_mov.Items.AddRange(new object[] { "Entrada", "Saída" });
            cb_tipo_mov.Location = new Point(10, 93);
            cb_tipo_mov.Name = "cb_tipo_mov";
            cb_tipo_mov.Size = new Size(282, 27);
            cb_tipo_mov.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 7;
            label1.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(9, 70);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 8;
            label2.Text = "Tipo";
            // 
            // txt_descricao
            // 
            txt_descricao.BorderStyle = BorderStyle.FixedSingle;
            txt_descricao.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_descricao.ForeColor = Color.FromArgb(64, 64, 64);
            txt_descricao.Location = new Point(10, 34);
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(282, 26);
            txt_descricao.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btn_fechar);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 29);
            panel3.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(28, 4);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 29;
            label3.Text = "Movimentação";
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
            btn_fechar.Location = new Point(297, 2);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 28;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_salvar_edicao
            // 
            btn_salvar_edicao.Anchor = AnchorStyles.Bottom;
            btn_salvar_edicao.BackColor = Color.LightGray;
            btn_salvar_edicao.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salvar_edicao.Cursor = Cursors.Hand;
            btn_salvar_edicao.FlatAppearance.BorderColor = Color.Gray;
            btn_salvar_edicao.FlatStyle = FlatStyle.Flat;
            btn_salvar_edicao.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar_edicao.ForeColor = Color.FromArgb(64, 64, 64);
            btn_salvar_edicao.Image = (Image)resources.GetObject("btn_salvar_edicao.Image");
            btn_salvar_edicao.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salvar_edicao.Location = new Point(106, 265);
            btn_salvar_edicao.Name = "btn_salvar_edicao";
            btn_salvar_edicao.Size = new Size(102, 29);
            btn_salvar_edicao.TabIndex = 39;
            btn_salvar_edicao.Text = "Salvar";
            btn_salvar_edicao.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar_edicao.UseVisualStyleBackColor = false;
            btn_salvar_edicao.Click += btn_salvar_edicao_Click;
            // 
            // PersistirMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 306);
            Controls.Add(btn_salvar_edicao);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersistirMovimentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersistirMovimentacao";
            Load += PersistirMovimentacao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txt_descricao;
        private ComboBox cb_tipo_mov;
        private Label label4;
        private TextBox txt_valor;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btn_fechar;
        private Button btn_salvar_edicao;
    }
}