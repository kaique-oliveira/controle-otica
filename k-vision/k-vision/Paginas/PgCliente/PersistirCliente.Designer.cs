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
            btn_salvar = new Button();
            txt_telefone = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            txt_nome = new TextBox();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.YellowGreen;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salvar.ForeColor = SystemColors.Control;
            btn_salvar.Location = new Point(110, 207);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 37);
            btn_salvar.TabIndex = 13;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone.Location = new Point(19, 132);
            txt_telefone.Mask = "(99) 00000-0000";
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(116, 27);
            txt_telefone.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 111);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(19, 63);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(252, 27);
            txt_nome.TabIndex = 6;
            // 
            // PersistirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(282, 256);
            Controls.Add(btn_salvar);
            Controls.Add(txt_telefone);
            Controls.Add(txt_nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersistirCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Cliente";
            Load += PersistirCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_salvar;
        private MaskedTextBox txt_telefone;
        private Label label2;
        private Label label1;
        private TextBox txt_nome;
    }
}