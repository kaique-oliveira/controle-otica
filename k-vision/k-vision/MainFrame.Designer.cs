namespace k_vision
{
    partial class MainFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_show_clientes = new Button();
            btn_show_produtos = new Button();
            SuspendLayout();
            // 
            // btn_show_clientes
            // 
            btn_show_clientes.BackColor = Color.LimeGreen;
            btn_show_clientes.FlatAppearance.BorderSize = 0;
            btn_show_clientes.FlatStyle = FlatStyle.Flat;
            btn_show_clientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_clientes.ForeColor = SystemColors.ButtonHighlight;
            btn_show_clientes.Location = new Point(12, 60);
            btn_show_clientes.Name = "btn_show_clientes";
            btn_show_clientes.Size = new Size(139, 61);
            btn_show_clientes.TabIndex = 3;
            btn_show_clientes.Text = "Clientes";
            btn_show_clientes.UseVisualStyleBackColor = false;
            btn_show_clientes.Click += btn_show_clientes_Click;
            // 
            // btn_show_produtos
            // 
            btn_show_produtos.BackColor = Color.Gold;
            btn_show_produtos.FlatAppearance.BorderSize = 0;
            btn_show_produtos.FlatStyle = FlatStyle.Flat;
            btn_show_produtos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_produtos.ForeColor = SystemColors.ButtonHighlight;
            btn_show_produtos.Location = new Point(181, 60);
            btn_show_produtos.Name = "btn_show_produtos";
            btn_show_produtos.Size = new Size(139, 61);
            btn_show_produtos.TabIndex = 4;
            btn_show_produtos.Text = "Produtos";
            btn_show_produtos.UseVisualStyleBackColor = false;
            btn_show_produtos.Click += btn_show_produtos_Click;
            // 
            // MainFrame
            // 
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(578, 182);
            Controls.Add(btn_show_produtos);
            Controls.Add(btn_show_clientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.Off;
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem clienteToolStripMenuItem;
        private Button btn_show_clientes;
        private Button btn_show_produtos;
    }
}