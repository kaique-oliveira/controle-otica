namespace Kvision.Frame.Paginas.PgVendas
{
    partial class EditarVendaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarVendaServico));
            panel4 = new Panel();
            panel11 = new Panel();
            txt_total_servico = new Label();
            label14 = new Label();
            btn_finalizar_servico = new Button();
            painel_observacao_servico = new Panel();
            panel13 = new Panel();
            label12 = new Label();
            txt_observacao_servico = new TextBox();
            painel_pagamento_servico = new Panel();
            panel12 = new Panel();
            label10 = new Label();
            rb_credito_servico = new RadioButton();
            rb_debito_servico = new RadioButton();
            rb_pix_servico = new RadioButton();
            rb_dinheiro_servico = new RadioButton();
            panel7 = new Panel();
            btn_apagar_produto = new Button();
            btn_show_add_servico = new Button();
            listViewServicos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel10 = new Panel();
            label11 = new Label();
            label9 = new Label();
            btn_salvar = new Button();
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_fechar = new Button();
            panel1 = new Panel();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            painel_observacao_servico.SuspendLayout();
            panel13.SuspendLayout();
            painel_pagamento_servico.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.LightGray;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(btn_finalizar_servico);
            panel4.Controls.Add(painel_observacao_servico);
            panel4.Controls.Add(painel_pagamento_servico);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(26, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 502);
            panel4.TabIndex = 16;
            // 
            // panel11
            // 
            panel11.BackColor = Color.DarkOrange;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(txt_total_servico);
            panel11.Controls.Add(label14);
            panel11.Location = new Point(11, 459);
            panel11.Name = "panel11";
            panel11.Size = new Size(326, 27);
            panel11.TabIndex = 32;
            // 
            // txt_total_servico
            // 
            txt_total_servico.AutoSize = true;
            txt_total_servico.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_total_servico.ForeColor = Color.WhiteSmoke;
            txt_total_servico.Location = new Point(149, 2);
            txt_total_servico.Name = "txt_total_servico";
            txt_total_servico.Size = new Size(61, 18);
            txt_total_servico.TabIndex = 30;
            txt_total_servico.Text = "R$  0,00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(46, 18);
            label14.TabIndex = 29;
            label14.Text = "Total:";
            // 
            // btn_finalizar_servico
            // 
            btn_finalizar_servico.Anchor = AnchorStyles.Bottom;
            btn_finalizar_servico.BackColor = Color.LightGray;
            btn_finalizar_servico.BackgroundImageLayout = ImageLayout.Stretch;
            btn_finalizar_servico.Cursor = Cursors.Hand;
            btn_finalizar_servico.FlatAppearance.BorderColor = Color.Gray;
            btn_finalizar_servico.FlatStyle = FlatStyle.Flat;
            btn_finalizar_servico.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_finalizar_servico.ForeColor = Color.FromArgb(64, 64, 64);
            btn_finalizar_servico.Image = (Image)resources.GetObject("btn_finalizar_servico.Image");
            btn_finalizar_servico.ImageAlign = ContentAlignment.MiddleLeft;
            btn_finalizar_servico.Location = new Point(206, 916);
            btn_finalizar_servico.Name = "btn_finalizar_servico";
            btn_finalizar_servico.Size = new Size(108, 29);
            btn_finalizar_servico.TabIndex = 27;
            btn_finalizar_servico.Text = "Finalizar";
            btn_finalizar_servico.TextAlign = ContentAlignment.MiddleRight;
            btn_finalizar_servico.UseVisualStyleBackColor = false;
            btn_finalizar_servico.Visible = false;
            // 
            // painel_observacao_servico
            // 
            painel_observacao_servico.BackColor = Color.FromArgb(229, 229, 229);
            painel_observacao_servico.BorderStyle = BorderStyle.FixedSingle;
            painel_observacao_servico.Controls.Add(panel13);
            painel_observacao_servico.Controls.Add(txt_observacao_servico);
            painel_observacao_servico.Location = new Point(11, 362);
            painel_observacao_servico.Name = "painel_observacao_servico";
            painel_observacao_servico.Size = new Size(326, 88);
            painel_observacao_servico.TabIndex = 31;
            // 
            // panel13
            // 
            panel13.BackColor = Color.DarkOrange;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(label12);
            panel13.Location = new Point(-1, -1);
            panel13.Name = "panel13";
            panel13.Size = new Size(343, 27);
            panel13.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(128, 1);
            label12.Name = "label12";
            label12.Size = new Size(100, 18);
            label12.TabIndex = 29;
            label12.Text = "Observação";
            // 
            // txt_observacao_servico
            // 
            txt_observacao_servico.BorderStyle = BorderStyle.FixedSingle;
            txt_observacao_servico.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_observacao_servico.ForeColor = Color.FromArgb(64, 64, 64);
            txt_observacao_servico.Location = new Point(3, 30);
            txt_observacao_servico.Multiline = true;
            txt_observacao_servico.Name = "txt_observacao_servico";
            txt_observacao_servico.Size = new Size(317, 52);
            txt_observacao_servico.TabIndex = 26;
            // 
            // painel_pagamento_servico
            // 
            painel_pagamento_servico.BackColor = Color.FromArgb(229, 229, 229);
            painel_pagamento_servico.BorderStyle = BorderStyle.FixedSingle;
            painel_pagamento_servico.Controls.Add(panel12);
            painel_pagamento_servico.Controls.Add(rb_credito_servico);
            painel_pagamento_servico.Controls.Add(rb_debito_servico);
            painel_pagamento_servico.Controls.Add(rb_pix_servico);
            painel_pagamento_servico.Controls.Add(rb_dinheiro_servico);
            painel_pagamento_servico.Location = new Point(11, 282);
            painel_pagamento_servico.Name = "painel_pagamento_servico";
            painel_pagamento_servico.Size = new Size(326, 67);
            painel_pagamento_servico.TabIndex = 29;
            // 
            // panel12
            // 
            panel12.BackColor = Color.DarkOrange;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(label10);
            panel12.Location = new Point(-1, -1);
            panel12.Name = "panel12";
            panel12.Size = new Size(331, 27);
            panel12.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(93, 3);
            label10.Name = "label10";
            label10.Size = new Size(169, 18);
            label10.TabIndex = 27;
            label10.Text = "Forma de pagamento";
            // 
            // rb_credito_servico
            // 
            rb_credito_servico.AutoSize = true;
            rb_credito_servico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_credito_servico.ForeColor = Color.FromArgb(64, 64, 64);
            rb_credito_servico.Location = new Point(250, 37);
            rb_credito_servico.Name = "rb_credito_servico";
            rb_credito_servico.Size = new Size(75, 21);
            rb_credito_servico.TabIndex = 6;
            rb_credito_servico.Text = "Crédito";
            rb_credito_servico.UseVisualStyleBackColor = true;
            rb_credito_servico.CheckedChanged += rb_credito_servico_CheckedChanged;
            // 
            // rb_debito_servico
            // 
            rb_debito_servico.AutoSize = true;
            rb_debito_servico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_debito_servico.ForeColor = Color.FromArgb(64, 64, 64);
            rb_debito_servico.Location = new Point(165, 38);
            rb_debito_servico.Name = "rb_debito_servico";
            rb_debito_servico.Size = new Size(70, 21);
            rb_debito_servico.TabIndex = 5;
            rb_debito_servico.Text = "Débito";
            rb_debito_servico.UseVisualStyleBackColor = true;
            rb_debito_servico.CheckedChanged += rb_debito_servico_CheckedChanged;
            // 
            // rb_pix_servico
            // 
            rb_pix_servico.AutoSize = true;
            rb_pix_servico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_pix_servico.ForeColor = Color.FromArgb(64, 64, 64);
            rb_pix_servico.Location = new Point(102, 38);
            rb_pix_servico.Name = "rb_pix_servico";
            rb_pix_servico.Size = new Size(43, 21);
            rb_pix_servico.TabIndex = 4;
            rb_pix_servico.Text = "Pix";
            rb_pix_servico.UseVisualStyleBackColor = true;
            rb_pix_servico.CheckedChanged += rb_pix_servico_CheckedChanged;
            // 
            // rb_dinheiro_servico
            // 
            rb_dinheiro_servico.AutoSize = true;
            rb_dinheiro_servico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rb_dinheiro_servico.ForeColor = Color.FromArgb(64, 64, 64);
            rb_dinheiro_servico.Location = new Point(7, 38);
            rb_dinheiro_servico.Name = "rb_dinheiro_servico";
            rb_dinheiro_servico.Size = new Size(79, 21);
            rb_dinheiro_servico.TabIndex = 3;
            rb_dinheiro_servico.Text = "Dinheiro";
            rb_dinheiro_servico.UseVisualStyleBackColor = true;
            rb_dinheiro_servico.CheckedChanged += rb_dinheiro_servico_CheckedChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(229, 229, 229);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btn_apagar_produto);
            panel7.Controls.Add(btn_show_add_servico);
            panel7.Controls.Add(listViewServicos);
            panel7.Controls.Add(panel10);
            panel7.Location = new Point(8, 45);
            panel7.Name = "panel7";
            panel7.Size = new Size(333, 221);
            panel7.TabIndex = 28;
            // 
            // btn_apagar_produto
            // 
            btn_apagar_produto.BackColor = Color.LightGray;
            btn_apagar_produto.BackgroundImageLayout = ImageLayout.Stretch;
            btn_apagar_produto.Cursor = Cursors.Hand;
            btn_apagar_produto.FlatAppearance.BorderColor = Color.Gray;
            btn_apagar_produto.FlatStyle = FlatStyle.Flat;
            btn_apagar_produto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_apagar_produto.ForeColor = Color.FromArgb(64, 64, 64);
            btn_apagar_produto.Image = (Image)resources.GetObject("btn_apagar_produto.Image");
            btn_apagar_produto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_apagar_produto.Location = new Point(6, 185);
            btn_apagar_produto.Name = "btn_apagar_produto";
            btn_apagar_produto.Size = new Size(128, 28);
            btn_apagar_produto.TabIndex = 31;
            btn_apagar_produto.Text = "Limpar lista";
            btn_apagar_produto.TextAlign = ContentAlignment.MiddleRight;
            btn_apagar_produto.UseVisualStyleBackColor = false;
            btn_apagar_produto.Click += btn_apagar_produto_Click;
            // 
            // btn_show_add_servico
            // 
            btn_show_add_servico.BackColor = Color.LightGray;
            btn_show_add_servico.BackgroundImageLayout = ImageLayout.Stretch;
            btn_show_add_servico.Cursor = Cursors.Hand;
            btn_show_add_servico.FlatAppearance.BorderColor = Color.Gray;
            btn_show_add_servico.FlatStyle = FlatStyle.Flat;
            btn_show_add_servico.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_add_servico.ForeColor = Color.FromArgb(64, 64, 64);
            btn_show_add_servico.Image = (Image)resources.GetObject("btn_show_add_servico.Image");
            btn_show_add_servico.ImageAlign = ContentAlignment.MiddleLeft;
            btn_show_add_servico.Location = new Point(207, 185);
            btn_show_add_servico.Name = "btn_show_add_servico";
            btn_show_add_servico.Size = new Size(118, 28);
            btn_show_add_servico.TabIndex = 30;
            btn_show_add_servico.Text = "Adicionar";
            btn_show_add_servico.TextAlign = ContentAlignment.MiddleRight;
            btn_show_add_servico.UseVisualStyleBackColor = false;
            btn_show_add_servico.Click += btn_show_add_servico_Click;
            // 
            // listViewServicos
            // 
            listViewServicos.BackColor = Color.FromArgb(229, 229, 229);
            listViewServicos.BorderStyle = BorderStyle.None;
            listViewServicos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewServicos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listViewServicos.ForeColor = Color.FromArgb(64, 64, 64);
            listViewServicos.FullRowSelect = true;
            listViewServicos.HeaderStyle = ColumnHeaderStyle.None;
            listViewServicos.Location = new Point(6, 32);
            listViewServicos.Name = "listViewServicos";
            listViewServicos.Size = new Size(319, 141);
            listViewServicos.TabIndex = 30;
            listViewServicos.UseCompatibleStateImageBehavior = false;
            listViewServicos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Valor";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 98;
            // 
            // panel10
            // 
            panel10.BackColor = Color.DarkOrange;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label11);
            panel10.Location = new Point(-1, -1);
            panel10.Name = "panel10";
            panel10.Size = new Size(333, 27);
            panel10.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(132, 3);
            label11.Name = "label11";
            label11.Size = new Size(69, 18);
            label11.TabIndex = 26;
            label11.Text = "Serviços";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(103, 5);
            label9.Name = "label9";
            label9.Size = new Size(138, 25);
            label9.TabIndex = 27;
            label9.Text = "Vender serviço";
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Bottom;
            btn_salvar.BackColor = Color.LightGray;
            btn_salvar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salvar.Cursor = Cursors.Hand;
            btn_salvar.FlatAppearance.BorderColor = Color.Gray;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salvar.Location = new Point(126, 562);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(151, 29);
            btn_salvar.TabIndex = 28;
            btn_salvar.Text = "Salvar Edição";
            btn_salvar.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(btn_fechar);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(401, 29);
            panel9.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(9, 3);
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
            label1.Location = new Point(35, 4);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 23;
            label1.Text = "Vendas";
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
            btn_fechar.Location = new Point(375, 1);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 15;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 603);
            panel1.TabIndex = 30;
            // 
            // EditarVendaServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(401, 603);
            Controls.Add(panel9);
            Controls.Add(btn_salvar);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarVendaServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarVendaServico";
            Load += EditarVendaServico_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            painel_observacao_servico.ResumeLayout(false);
            painel_observacao_servico.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            painel_pagamento_servico.ResumeLayout(false);
            painel_pagamento_servico.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel11;
        private Label txt_total_servico;
        private Label label14;
        private Button btn_finalizar_servico;
        private Panel painel_observacao_servico;
        private Panel panel13;
        private Label label12;
        private TextBox txt_observacao_servico;
        private Panel painel_pagamento_servico;
        private Panel panel12;
        private Label label10;
        private RadioButton rb_credito_servico;
        private RadioButton rb_debito_servico;
        private RadioButton rb_pix_servico;
        private RadioButton rb_dinheiro_servico;
        private Panel panel7;
        private Button btn_show_add_servico;
        private ListView listViewServicos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel10;
        private Label label11;
        private Label label9;
        private Button btn_salvar;
        private Panel panel9;
        private Button btn_fechar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_apagar_produto;
        private Panel panel1;
    }
}