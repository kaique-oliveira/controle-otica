namespace Kvision.Frame.Paginas.PgCaixa
{
    partial class MainCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCaixa));
            btn_show_vendas = new Button();
            panel12 = new Panel();
            btn_fechar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_show_vendas
            // 
            btn_show_vendas.Location = new Point(8, 55);
            btn_show_vendas.Name = "btn_show_vendas";
            btn_show_vendas.Size = new Size(100, 36);
            btn_show_vendas.TabIndex = 0;
            btn_show_vendas.Text = "Vendas";
            btn_show_vendas.UseVisualStyleBackColor = true;
            btn_show_vendas.Click += btn_show_vendas_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(pictureBox1);
            panel12.Controls.Add(label1);
            panel12.Controls.Add(btn_fechar);
            panel12.Location = new Point(-1, -1);
            panel12.Name = "panel12";
            panel12.Size = new Size(802, 29);
            panel12.TabIndex = 28;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.Transparent;
            btn_fechar.BackgroundImage = (Image)resources.GetObject("btn_fechar.BackgroundImage");
            btn_fechar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = SystemColors.ActiveCaptionText;
            btn_fechar.Location = new Point(774, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 15;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(34, 4);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 23;
            label1.Text = "Caixa";
            // 
            // MainCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(panel12);
            Controls.Add(btn_show_vendas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainCaixa";
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_show_vendas;
        private Panel panel12;
        private Button btn_fechar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}