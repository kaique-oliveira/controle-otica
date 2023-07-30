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
            label1 = new Label();
            txt_nome = new TextBox();
            txt_valor = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            txt_quantidade = new MaskedTextBox();
            btn_salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 45);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(27, 68);
            txt_nome.Name = "txt_nome";
            txt_nome.PlaceholderText = "Nome do produto ou coleção";
            txt_nome.Size = new Size(344, 27);
            txt_nome.TabIndex = 1;
            // 
            // txt_valor
            // 
            txt_valor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_valor.Location = new Point(27, 228);
            txt_valor.Mask = "000,00";
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(100, 27);
            txt_valor.TabIndex = 4;
            txt_valor.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 123);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantidade em estoque:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 205);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 5;
            label3.Text = "Valor por unidade:";
            // 
            // txt_quantidade
            // 
            txt_quantidade.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantidade.Location = new Point(27, 146);
            txt_quantidade.Mask = "00000";
            txt_quantidade.Name = "txt_quantidade";
            txt_quantidade.Size = new Size(344, 27);
            txt_quantidade.TabIndex = 6;
            txt_quantidade.ValidatingType = typeof(int);
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.YellowGreen;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salvar.ForeColor = SystemColors.Control;
            btn_salvar.Location = new Point(158, 321);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 37);
            btn_salvar.TabIndex = 14;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // PersistirProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 370);
            Controls.Add(btn_salvar);
            Controls.Add(txt_quantidade);
            Controls.Add(label3);
            Controls.Add(txt_valor);
            Controls.Add(label2);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            Name = "PersistirProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrando Produto";
            Load += PersistirProduto_Load;
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
    }
}