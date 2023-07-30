namespace Kvision.Frame.Paginas.PgExames
{
    partial class PersistirReceita
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
            txt_d_realizado = new MaskedTextBox();
            txt_nome_dr = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_d_validade = new MaskedTextBox();
            label3 = new Label();
            lbl_perto = new Label();
            panel_perto = new Panel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel5 = new Panel();
            txt_dp_esquerdo_perto = new MaskedTextBox();
            label13 = new Label();
            txt_eixo_esquerdo_perto = new MaskedTextBox();
            label14 = new Label();
            txt_cil_esquerdo_perto = new MaskedTextBox();
            txt_eixo_direito_perto = new MaskedTextBox();
            txt_esf_esquerdo_perto = new MaskedTextBox();
            txt_dp_direito_perto = new MaskedTextBox();
            txt_esf_direito_perto = new MaskedTextBox();
            txt_cil_direito_perto = new MaskedTextBox();
            lbl_longe = new Label();
            panel_longe = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label15 = new Label();
            panel3 = new Panel();
            txt_dp_esquerdo_longe = new MaskedTextBox();
            label16 = new Label();
            txt_eixo_esquerdo_longe = new MaskedTextBox();
            label17 = new Label();
            txt_cil_esquerdo_longe = new MaskedTextBox();
            txt_esf_direito_longe = new MaskedTextBox();
            txt_eixo_direito_longe = new MaskedTextBox();
            txt_dp_direito_longe = new MaskedTextBox();
            txt_cil_direito_longe = new MaskedTextBox();
            txt_esf_esquerdo_longe = new MaskedTextBox();
            panel_perto.SuspendLayout();
            panel5.SuspendLayout();
            panel_longe.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.YellowGreen;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salvar.ForeColor = SystemColors.Control;
            btn_salvar.Location = new Point(357, 312);
            btn_salvar.Margin = new Padding(3, 4, 3, 4);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(86, 49);
            btn_salvar.TabIndex = 42;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_d_realizado
            // 
            txt_d_realizado.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_d_realizado.Location = new Point(15, 40);
            txt_d_realizado.Margin = new Padding(3, 4, 3, 4);
            txt_d_realizado.Mask = "00/00/0000";
            txt_d_realizado.Name = "txt_d_realizado";
            txt_d_realizado.Size = new Size(94, 27);
            txt_d_realizado.TabIndex = 1;
            txt_d_realizado.ValidatingType = typeof(DateTime);
            // 
            // txt_nome_dr
            // 
            txt_nome_dr.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_dr.Location = new Point(325, 40);
            txt_nome_dr.Margin = new Padding(3, 4, 3, 4);
            txt_nome_dr.Name = "txt_nome_dr";
            txt_nome_dr.Size = new Size(287, 27);
            txt_nome_dr.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 16;
            label2.Text = "Realizado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 15;
            label1.Text = "Nome do doutor:";
            // 
            // txt_d_validade
            // 
            txt_d_validade.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_d_validade.Location = new Point(169, 40);
            txt_d_validade.Margin = new Padding(3, 4, 3, 4);
            txt_d_validade.Mask = "00/00/0000";
            txt_d_validade.Name = "txt_d_validade";
            txt_d_validade.Size = new Size(94, 27);
            txt_d_validade.TabIndex = 2;
            txt_d_validade.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(168, 12);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 19;
            label3.Text = "Validade:";
            // 
            // lbl_perto
            // 
            lbl_perto.AutoSize = true;
            lbl_perto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_perto.ForeColor = Color.BlueViolet;
            lbl_perto.Location = new Point(589, 113);
            lbl_perto.Name = "lbl_perto";
            lbl_perto.Size = new Size(51, 21);
            lbl_perto.TabIndex = 24;
            lbl_perto.Text = "Perto";
            lbl_perto.Visible = false;
            // 
            // panel_perto
            // 
            panel_perto.BackColor = Color.Thistle;
            panel_perto.Controls.Add(label9);
            panel_perto.Controls.Add(label10);
            panel_perto.Controls.Add(label11);
            panel_perto.Controls.Add(label12);
            panel_perto.Controls.Add(panel5);
            panel_perto.Location = new Point(423, 137);
            panel_perto.Margin = new Padding(3, 4, 3, 4);
            panel_perto.Name = "panel_perto";
            panel_perto.Size = new Size(347, 109);
            panel_perto.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(286, 7);
            label9.Name = "label9";
            label9.Size = new Size(29, 20);
            label9.TabIndex = 11;
            label9.Text = "DP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(205, 7);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 10;
            label10.Text = "Eixo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(135, 7);
            label11.Name = "label11";
            label11.Size = new Size(30, 20);
            label11.TabIndex = 9;
            label11.Text = "Cil.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(56, 7);
            label12.Name = "label12";
            label12.Size = new Size(31, 20);
            label12.TabIndex = 8;
            label12.Text = "Esf.";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(txt_dp_esquerdo_perto);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(txt_eixo_esquerdo_perto);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(txt_cil_esquerdo_perto);
            panel5.Controls.Add(txt_eixo_direito_perto);
            panel5.Controls.Add(txt_esf_esquerdo_perto);
            panel5.Controls.Add(txt_dp_direito_perto);
            panel5.Controls.Add(txt_esf_direito_perto);
            panel5.Controls.Add(txt_cil_direito_perto);
            panel5.Location = new Point(0, 33);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(347, 75);
            panel5.TabIndex = 8;
            // 
            // txt_dp_esquerdo_perto
            // 
            txt_dp_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_esquerdo_perto.Location = new Point(266, 38);
            txt_dp_esquerdo_perto.Mask = "0,00";
            txt_dp_esquerdo_perto.Name = "txt_dp_esquerdo_perto";
            txt_dp_esquerdo_perto.Size = new Size(69, 27);
            txt_dp_esquerdo_perto.TabIndex = 41;
            txt_dp_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(7, 49);
            label13.Name = "label13";
            label13.Size = new Size(25, 15);
            label13.TabIndex = 13;
            label13.Text = "O.E";
            // 
            // txt_eixo_esquerdo_perto
            // 
            txt_eixo_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_esquerdo_perto.Location = new Point(191, 39);
            txt_eixo_esquerdo_perto.Mask = "0,00";
            txt_eixo_esquerdo_perto.Name = "txt_eixo_esquerdo_perto";
            txt_eixo_esquerdo_perto.Size = new Size(69, 27);
            txt_eixo_esquerdo_perto.TabIndex = 40;
            txt_eixo_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(7, 13);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 12;
            label14.Text = "O.D";
            // 
            // txt_cil_esquerdo_perto
            // 
            txt_cil_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_esquerdo_perto.Location = new Point(116, 39);
            txt_cil_esquerdo_perto.Mask = "0,00";
            txt_cil_esquerdo_perto.Name = "txt_cil_esquerdo_perto";
            txt_cil_esquerdo_perto.Size = new Size(69, 27);
            txt_cil_esquerdo_perto.TabIndex = 39;
            txt_cil_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_eixo_direito_perto
            // 
            txt_eixo_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_direito_perto.Location = new Point(191, 7);
            txt_eixo_direito_perto.Mask = "0,00";
            txt_eixo_direito_perto.Name = "txt_eixo_direito_perto";
            txt_eixo_direito_perto.Size = new Size(69, 27);
            txt_eixo_direito_perto.TabIndex = 36;
            txt_eixo_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_esquerdo_perto
            // 
            txt_esf_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_esquerdo_perto.Location = new Point(41, 39);
            txt_esf_esquerdo_perto.Mask = "0,00";
            txt_esf_esquerdo_perto.Name = "txt_esf_esquerdo_perto";
            txt_esf_esquerdo_perto.Size = new Size(69, 27);
            txt_esf_esquerdo_perto.TabIndex = 38;
            txt_esf_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_dp_direito_perto
            // 
            txt_dp_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_direito_perto.Location = new Point(266, 8);
            txt_dp_direito_perto.Mask = "0,00";
            txt_dp_direito_perto.Name = "txt_dp_direito_perto";
            txt_dp_direito_perto.Size = new Size(69, 27);
            txt_dp_direito_perto.TabIndex = 37;
            txt_dp_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_direito_perto
            // 
            txt_esf_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_direito_perto.Location = new Point(41, 8);
            txt_esf_direito_perto.Mask = "0,00";
            txt_esf_direito_perto.Name = "txt_esf_direito_perto";
            txt_esf_direito_perto.Size = new Size(69, 27);
            txt_esf_direito_perto.TabIndex = 34;
            txt_esf_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_cil_direito_perto
            // 
            txt_cil_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_direito_perto.Location = new Point(116, 7);
            txt_cil_direito_perto.Mask = "0,00";
            txt_cil_direito_perto.Name = "txt_cil_direito_perto";
            txt_cil_direito_perto.Size = new Size(69, 27);
            txt_cil_direito_perto.TabIndex = 35;
            txt_cil_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // lbl_longe
            // 
            lbl_longe.AutoSize = true;
            lbl_longe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_longe.ForeColor = Color.Firebrick;
            lbl_longe.Location = new Point(178, 113);
            lbl_longe.Name = "lbl_longe";
            lbl_longe.Size = new Size(57, 21);
            lbl_longe.TabIndex = 22;
            lbl_longe.Text = "Longe";
            lbl_longe.Visible = false;
            // 
            // panel_longe
            // 
            panel_longe.BackColor = Color.Bisque;
            panel_longe.Controls.Add(label4);
            panel_longe.Controls.Add(label5);
            panel_longe.Controls.Add(label6);
            panel_longe.Controls.Add(label15);
            panel_longe.Controls.Add(panel3);
            panel_longe.Location = new Point(12, 137);
            panel_longe.Margin = new Padding(3, 4, 3, 4);
            panel_longe.Name = "panel_longe";
            panel_longe.Size = new Size(344, 107);
            panel_longe.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 7);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 11;
            label4.Text = "DP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(208, 7);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 10;
            label5.Text = "Eixo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(138, 7);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 9;
            label6.Text = "Cil.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(63, 7);
            label15.Name = "label15";
            label15.Size = new Size(31, 20);
            label15.TabIndex = 8;
            label15.Text = "Esf.";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(txt_dp_esquerdo_longe);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(txt_eixo_esquerdo_longe);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(txt_cil_esquerdo_longe);
            panel3.Controls.Add(txt_esf_direito_longe);
            panel3.Controls.Add(txt_eixo_direito_longe);
            panel3.Controls.Add(txt_dp_direito_longe);
            panel3.Controls.Add(txt_cil_direito_longe);
            panel3.Controls.Add(txt_esf_esquerdo_longe);
            panel3.Location = new Point(0, 33);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 74);
            panel3.TabIndex = 8;
            // 
            // txt_dp_esquerdo_longe
            // 
            txt_dp_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_esquerdo_longe.Location = new Point(265, 37);
            txt_dp_esquerdo_longe.Mask = "0,00";
            txt_dp_esquerdo_longe.Name = "txt_dp_esquerdo_longe";
            txt_dp_esquerdo_longe.Size = new Size(69, 27);
            txt_dp_esquerdo_longe.TabIndex = 33;
            txt_dp_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(7, 49);
            label16.Name = "label16";
            label16.Size = new Size(25, 15);
            label16.TabIndex = 13;
            label16.Text = "O.E";
            // 
            // txt_eixo_esquerdo_longe
            // 
            txt_eixo_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_esquerdo_longe.Location = new Point(190, 38);
            txt_eixo_esquerdo_longe.Mask = "0,00";
            txt_eixo_esquerdo_longe.Name = "txt_eixo_esquerdo_longe";
            txt_eixo_esquerdo_longe.Size = new Size(69, 27);
            txt_eixo_esquerdo_longe.TabIndex = 32;
            txt_eixo_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(7, 13);
            label17.Name = "label17";
            label17.Size = new Size(27, 15);
            label17.TabIndex = 12;
            label17.Text = "O.D";
            // 
            // txt_cil_esquerdo_longe
            // 
            txt_cil_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_esquerdo_longe.Location = new Point(115, 38);
            txt_cil_esquerdo_longe.Mask = "0,00";
            txt_cil_esquerdo_longe.Name = "txt_cil_esquerdo_longe";
            txt_cil_esquerdo_longe.Size = new Size(69, 27);
            txt_cil_esquerdo_longe.TabIndex = 31;
            txt_cil_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_direito_longe
            // 
            txt_esf_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_direito_longe.Location = new Point(40, 7);
            txt_esf_direito_longe.Mask = "0,00";
            txt_esf_direito_longe.Name = "txt_esf_direito_longe";
            txt_esf_direito_longe.Size = new Size(69, 27);
            txt_esf_direito_longe.TabIndex = 26;
            txt_esf_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_eixo_direito_longe
            // 
            txt_eixo_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_direito_longe.Location = new Point(190, 6);
            txt_eixo_direito_longe.Mask = "0,00";
            txt_eixo_direito_longe.Name = "txt_eixo_direito_longe";
            txt_eixo_direito_longe.Size = new Size(69, 27);
            txt_eixo_direito_longe.TabIndex = 28;
            txt_eixo_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_dp_direito_longe
            // 
            txt_dp_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_direito_longe.Location = new Point(265, 7);
            txt_dp_direito_longe.Mask = "0,00";
            txt_dp_direito_longe.Name = "txt_dp_direito_longe";
            txt_dp_direito_longe.Size = new Size(69, 27);
            txt_dp_direito_longe.TabIndex = 29;
            txt_dp_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_cil_direito_longe
            // 
            txt_cil_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_direito_longe.Location = new Point(115, 6);
            txt_cil_direito_longe.Mask = "0,00";
            txt_cil_direito_longe.Name = "txt_cil_direito_longe";
            txt_cil_direito_longe.Size = new Size(69, 27);
            txt_cil_direito_longe.TabIndex = 27;
            txt_cil_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_esquerdo_longe
            // 
            txt_esf_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_esquerdo_longe.Location = new Point(40, 38);
            txt_esf_esquerdo_longe.Mask = "0,00";
            txt_esf_esquerdo_longe.Name = "txt_esf_esquerdo_longe";
            txt_esf_esquerdo_longe.Size = new Size(69, 27);
            txt_esf_esquerdo_longe.TabIndex = 30;
            txt_esf_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // PersistirReceita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(780, 372);
            Controls.Add(lbl_perto);
            Controls.Add(panel_perto);
            Controls.Add(lbl_longe);
            Controls.Add(panel_longe);
            Controls.Add(txt_d_validade);
            Controls.Add(label3);
            Controls.Add(btn_salvar);
            Controls.Add(txt_d_realizado);
            Controls.Add(txt_nome_dr);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PersistirReceita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastrar receita";
            Load += PersistirReceita_Load;
            panel_perto.ResumeLayout(false);
            panel_perto.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel_longe.ResumeLayout(false);
            panel_longe.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private MaskedTextBox txt_d_realizado;
        private TextBox txt_nome_dr;
        private Label label2;
        private Label label1;
        private MaskedTextBox txt_d_validade;
        private Label label3;
        private Label lbl_perto;
        private Panel panel_perto;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel5;
        private Label label13;
        private Label label14;
        private Label lbl_longe;
        private Panel panel_longe;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label15;
        private Panel panel3;
        private Label label16;
        private Label label17;
        private Label label18;
        private MaskedTextBox txt_dp_esquerdo_longe;
        private MaskedTextBox txt_eixo_esquerdo_longe;
        private MaskedTextBox txt_cil_esquerdo_longe;
        private MaskedTextBox txt_esf_direito_longe;
        private MaskedTextBox txt_eixo_direito_longe;
        private MaskedTextBox txt_dp_direito_longe;
        private MaskedTextBox txt_cil_direito_longe;
        private MaskedTextBox txt_esf_esquerdo_longe;
        private MaskedTextBox txt_dp_esquerdo_perto;
        private MaskedTextBox txt_eixo_esquerdo_perto;
        private MaskedTextBox txt_cil_esquerdo_perto;
        private MaskedTextBox txt_eixo_direito_perto;
        private MaskedTextBox txt_esf_esquerdo_perto;
        private MaskedTextBox txt_dp_direito_perto;
        private MaskedTextBox txt_esf_direito_perto;
        private MaskedTextBox txt_cil_direito_perto;
    }
}