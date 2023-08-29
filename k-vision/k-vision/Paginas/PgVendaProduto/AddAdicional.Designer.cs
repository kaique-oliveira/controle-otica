namespace Kvision.Frame.Paginas.PgVendaProduto
{
    partial class AddAdicional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdicional));
            panel1 = new Panel();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            btn_fechar = new Button();
            bnt_confirmar = new Button();
            panel2 = new Panel();
            txt_valor = new TextBox();
            label1 = new Label();
            txt_descricao = new TextBox();
            label19 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(bnt_confirmar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 246);
            panel1.TabIndex = 0;
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
            panel6.Size = new Size(388, 29);
            panel6.TabIndex = 38;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(3, 3);
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
            lblTitulo.Location = new Point(28, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(73, 20);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "Adicional";
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
            btn_fechar.Location = new Point(360, 1);
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
            bnt_confirmar.FlatAppearance.BorderColor = Color.Gray;
            bnt_confirmar.FlatStyle = FlatStyle.Flat;
            bnt_confirmar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_confirmar.ForeColor = Color.FromArgb(64, 64, 64);
            bnt_confirmar.Image = (Image)resources.GetObject("bnt_confirmar.Image");
            bnt_confirmar.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_confirmar.Location = new Point(138, 202);
            bnt_confirmar.Name = "bnt_confirmar";
            bnt_confirmar.Size = new Size(114, 29);
            bnt_confirmar.TabIndex = 31;
            bnt_confirmar.Text = "Confirmar";
            bnt_confirmar.TextAlign = ContentAlignment.MiddleRight;
            bnt_confirmar.UseVisualStyleBackColor = false;
            bnt_confirmar.Click += bnt_confirmar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_valor);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_descricao);
            panel2.Controls.Add(label19);
            panel2.Location = new Point(9, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 142);
            panel2.TabIndex = 31;
            // 
            // txt_valor
            // 
            txt_valor.BackColor = Color.WhiteSmoke;
            txt_valor.BorderStyle = BorderStyle.FixedSingle;
            txt_valor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valor.ForeColor = Color.FromArgb(64, 64, 64);
            txt_valor.Location = new Point(5, 91);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(354, 27);
            txt_valor.TabIndex = 33;
            txt_valor.TextAlign = HorizontalAlignment.Center;
            txt_valor.KeyPress += TextKeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(5, 68);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 30;
            label1.Text = "Valor:";
            // 
            // txt_descricao
            // 
            txt_descricao.BackColor = Color.FromArgb(250, 250, 250);
            txt_descricao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_descricao.ForeColor = Color.FromArgb(64, 64, 64);
            txt_descricao.Location = new Point(4, 33);
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(355, 27);
            txt_descricao.TabIndex = 28;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(4, 10);
            label19.Name = "label19";
            label19.Size = new Size(77, 20);
            label19.TabIndex = 27;
            label19.Text = "Descrição:";
            // 
            // AddAdicional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(388, 246);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAdicional";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAdicional";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btn_fechar;
        private Label lblTitulo;
        private Label label1;
        private TextBox txt_descricao;
        private Label label19;
        private Button bnt_confirmar;
        private Panel panel6;
        private TextBox txt_valor;
    }
}