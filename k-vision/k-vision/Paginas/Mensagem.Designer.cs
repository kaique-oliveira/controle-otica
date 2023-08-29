namespace Kvision.Frame.Paginas
{
    partial class Mensagem
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
            lbl_texto = new Label();
            lbl_titulo = new Label();
            btn_ok = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lbl_texto
            // 
            lbl_texto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_texto.AutoSize = true;
            lbl_texto.BackColor = Color.WhiteSmoke;
            lbl_texto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_texto.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_texto.Location = new Point(12, 39);
            lbl_texto.Name = "lbl_texto";
            lbl_texto.Size = new Size(98, 20);
            lbl_texto.TabIndex = 26;
            lbl_texto.Text = "Nome cliente";
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.WhiteSmoke;
            lbl_titulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_titulo.Location = new Point(262, 5);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(62, 25);
            lbl_titulo.TabIndex = 27;
            lbl_titulo.Text = "Titulo";
            // 
            // btn_ok
            // 
            btn_ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_ok.BackColor = Color.FromArgb(224, 224, 224);
            btn_ok.BackgroundImageLayout = ImageLayout.Stretch;
            btn_ok.Cursor = Cursors.Hand;
            btn_ok.FlatAppearance.BorderSize = 0;
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(64, 64, 64);
            btn_ok.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ok.Location = new Point(262, 69);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(38, 31);
            btn_ok.TabIndex = 28;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 103);
            panel1.TabIndex = 29;
            // 
            // Mensagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(569, 107);
            Controls.Add(btn_ok);
            Controls.Add(lbl_texto);
            Controls.Add(lbl_titulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mensagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mensagem";
            Load += Mensagem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_texto;
        private Label lbl_titulo;
        private Button btn_ok;
        private Panel panel1;
    }
}