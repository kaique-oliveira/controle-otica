namespace Kvision.Frame.Paginas.PgExames
{
    partial class MainReceita
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_deletar = new Button();
            btn_show_editar = new Button();
            bnt_cadastrar = new Button();
            dg_receitas = new DataGridView();
            DataExame = new DataGridViewTextBoxColumn();
            DataValExame = new DataGridViewTextBoxColumn();
            nomeExaminador = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            txt_dp_esquerdo_longe = new MaskedTextBox();
            txt_eixo_esquerdo_longe = new MaskedTextBox();
            txt_cil_esquerdo_longe = new MaskedTextBox();
            txt_eixo_direito_longe = new MaskedTextBox();
            txt_cil_direito_longe = new MaskedTextBox();
            txt_esf_esquerdo_longe = new MaskedTextBox();
            txt_esf_direito_longe = new MaskedTextBox();
            label6 = new Label();
            txt_dp_direito_longe = new MaskedTextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
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
            txt_dp_direito_perto = new MaskedTextBox();
            txt_cil_direito_perto = new MaskedTextBox();
            txt_esf_direito_perto = new MaskedTextBox();
            txt_esf_esquerdo_perto = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_receitas).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btn_deletar);
            panel1.Controls.Add(btn_show_editar);
            panel1.Controls.Add(bnt_cadastrar);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 368);
            panel1.TabIndex = 6;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.Crimson;
            btn_deletar.FlatAppearance.BorderSize = 0;
            btn_deletar.FlatStyle = FlatStyle.Flat;
            btn_deletar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deletar.ForeColor = Color.White;
            btn_deletar.Location = new Point(8, 209);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(135, 48);
            btn_deletar.TabIndex = 4;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_show_editar
            // 
            btn_show_editar.BackColor = Color.Orange;
            btn_show_editar.FlatAppearance.BorderSize = 0;
            btn_show_editar.FlatStyle = FlatStyle.Flat;
            btn_show_editar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_editar.ForeColor = Color.White;
            btn_show_editar.Location = new Point(7, 140);
            btn_show_editar.Name = "btn_show_editar";
            btn_show_editar.Size = new Size(135, 48);
            btn_show_editar.TabIndex = 3;
            btn_show_editar.Text = "Editar";
            btn_show_editar.UseVisualStyleBackColor = false;
            // 
            // bnt_cadastrar
            // 
            bnt_cadastrar.BackColor = Color.YellowGreen;
            bnt_cadastrar.FlatAppearance.BorderSize = 0;
            bnt_cadastrar.FlatStyle = FlatStyle.Flat;
            bnt_cadastrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bnt_cadastrar.ForeColor = Color.White;
            bnt_cadastrar.Location = new Point(7, 69);
            bnt_cadastrar.Name = "bnt_cadastrar";
            bnt_cadastrar.Size = new Size(135, 48);
            bnt_cadastrar.TabIndex = 2;
            bnt_cadastrar.Text = "Cadastrar";
            bnt_cadastrar.UseVisualStyleBackColor = false;
            bnt_cadastrar.Click += bnt_cadastrar_Click;
            // 
            // dg_receitas
            // 
            dg_receitas.AllowUserToAddRows = false;
            dg_receitas.AllowUserToDeleteRows = false;
            dg_receitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dg_receitas.BackgroundColor = Color.WhiteSmoke;
            dg_receitas.BorderStyle = BorderStyle.None;
            dg_receitas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg_receitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_receitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_receitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_receitas.Columns.AddRange(new DataGridViewColumn[] { DataExame, DataValExame, nomeExaminador });
            dg_receitas.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_receitas.DefaultCellStyle = dataGridViewCellStyle2;
            dg_receitas.EnableHeadersVisualStyles = false;
            dg_receitas.GridColor = Color.WhiteSmoke;
            dg_receitas.Location = new Point(170, 12);
            dg_receitas.MultiSelect = false;
            dg_receitas.Name = "dg_receitas";
            dg_receitas.ReadOnly = true;
            dg_receitas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dg_receitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dg_receitas.RowHeadersVisible = false;
            dg_receitas.RowTemplate.Height = 25;
            dg_receitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_receitas.Size = new Size(380, 340);
            dg_receitas.TabIndex = 5;
            dg_receitas.CellClick += dg_receitas_CellClick;
            // 
            // DataExame
            // 
            DataExame.DataPropertyName = "DataExame";
            DataExame.HeaderText = "Data";
            DataExame.Name = "DataExame";
            DataExame.ReadOnly = true;
            DataExame.Width = 80;
            // 
            // DataValExame
            // 
            DataValExame.DataPropertyName = "DataValExame";
            DataValExame.HeaderText = "Validade";
            DataValExame.MinimumWidth = 60;
            DataValExame.Name = "DataValExame";
            DataValExame.ReadOnly = true;
            // 
            // nomeExaminador
            // 
            nomeExaminador.DataPropertyName = "nomeExaminador";
            nomeExaminador.HeaderText = "Doutor";
            nomeExaminador.Name = "nomeExaminador";
            nomeExaminador.ReadOnly = true;
            nomeExaminador.Width = 200;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(578, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 90);
            panel2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(276, 4);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 11;
            label4.Text = "DP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(195, 4);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 10;
            label3.Text = "Eixo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 4);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 9;
            label2.Text = "Cil.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 4);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 8;
            label1.Text = "Esf.";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(txt_dp_esquerdo_longe);
            panel3.Controls.Add(txt_eixo_esquerdo_longe);
            panel3.Controls.Add(txt_cil_esquerdo_longe);
            panel3.Controls.Add(txt_eixo_direito_longe);
            panel3.Controls.Add(txt_cil_direito_longe);
            panel3.Controls.Add(txt_esf_esquerdo_longe);
            panel3.Controls.Add(txt_esf_direito_longe);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txt_dp_direito_longe);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 65);
            panel3.TabIndex = 8;
            // 
            // txt_dp_esquerdo_longe
            // 
            txt_dp_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_esquerdo_longe.Location = new Point(260, 34);
            txt_dp_esquerdo_longe.Mask = "0,00";
            txt_dp_esquerdo_longe.Name = "txt_dp_esquerdo_longe";
            txt_dp_esquerdo_longe.Size = new Size(69, 27);
            txt_dp_esquerdo_longe.TabIndex = 19;
            txt_dp_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_eixo_esquerdo_longe
            // 
            txt_eixo_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_esquerdo_longe.Location = new Point(185, 35);
            txt_eixo_esquerdo_longe.Mask = "0,00";
            txt_eixo_esquerdo_longe.Name = "txt_eixo_esquerdo_longe";
            txt_eixo_esquerdo_longe.Size = new Size(69, 27);
            txt_eixo_esquerdo_longe.TabIndex = 20;
            txt_eixo_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_cil_esquerdo_longe
            // 
            txt_cil_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_esquerdo_longe.Location = new Point(110, 35);
            txt_cil_esquerdo_longe.Mask = "0,00";
            txt_cil_esquerdo_longe.Name = "txt_cil_esquerdo_longe";
            txt_cil_esquerdo_longe.Size = new Size(69, 27);
            txt_cil_esquerdo_longe.TabIndex = 21;
            txt_cil_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_eixo_direito_longe
            // 
            txt_eixo_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_direito_longe.Location = new Point(185, 3);
            txt_eixo_direito_longe.Mask = "0,00";
            txt_eixo_direito_longe.Name = "txt_eixo_direito_longe";
            txt_eixo_direito_longe.Size = new Size(69, 27);
            txt_eixo_direito_longe.TabIndex = 17;
            txt_eixo_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_cil_direito_longe
            // 
            txt_cil_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_direito_longe.Location = new Point(110, 3);
            txt_cil_direito_longe.Mask = "0,00";
            txt_cil_direito_longe.Name = "txt_cil_direito_longe";
            txt_cil_direito_longe.Size = new Size(69, 27);
            txt_cil_direito_longe.TabIndex = 16;
            txt_cil_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_esquerdo_longe
            // 
            txt_esf_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_esquerdo_longe.Location = new Point(35, 35);
            txt_esf_esquerdo_longe.Mask = "0,00";
            txt_esf_esquerdo_longe.Name = "txt_esf_esquerdo_longe";
            txt_esf_esquerdo_longe.Size = new Size(69, 27);
            txt_esf_esquerdo_longe.TabIndex = 19;
            txt_esf_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_direito_longe
            // 
            txt_esf_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_direito_longe.Location = new Point(35, 4);
            txt_esf_direito_longe.Mask = "0,00";
            txt_esf_direito_longe.Name = "txt_esf_direito_longe";
            txt_esf_direito_longe.Size = new Size(69, 27);
            txt_esf_direito_longe.TabIndex = 15;
            txt_esf_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 42);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 13;
            label6.Text = "O.E";
            // 
            // txt_dp_direito_longe
            // 
            txt_dp_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_direito_longe.Location = new Point(260, 4);
            txt_dp_direito_longe.Mask = "0,00";
            txt_dp_direito_longe.Name = "txt_dp_direito_longe";
            txt_dp_direito_longe.Size = new Size(69, 27);
            txt_dp_direito_longe.TabIndex = 18;
            txt_dp_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(4, 9);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 12;
            label5.Text = "O.D";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(723, 37);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 12;
            label7.Text = "Longe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.BlueViolet;
            label8.Location = new Point(723, 191);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 14;
            label8.Text = "Perto";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(578, 214);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 91);
            panel4.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(276, 4);
            label9.Name = "label9";
            label9.Size = new Size(29, 20);
            label9.TabIndex = 11;
            label9.Text = "DP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(195, 4);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 10;
            label10.Text = "Eixo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(121, 4);
            label11.Name = "label11";
            label11.Size = new Size(30, 20);
            label11.TabIndex = 9;
            label11.Text = "Cil.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(49, 4);
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
            panel5.Controls.Add(txt_dp_direito_perto);
            panel5.Controls.Add(txt_cil_direito_perto);
            panel5.Controls.Add(txt_esf_direito_perto);
            panel5.Controls.Add(txt_esf_esquerdo_perto);
            panel5.Location = new Point(0, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(333, 66);
            panel5.TabIndex = 8;
            // 
            // txt_dp_esquerdo_perto
            // 
            txt_dp_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_esquerdo_perto.Location = new Point(260, 34);
            txt_dp_esquerdo_perto.Mask = "0,00";
            txt_dp_esquerdo_perto.Name = "txt_dp_esquerdo_perto";
            txt_dp_esquerdo_perto.Size = new Size(69, 27);
            txt_dp_esquerdo_perto.TabIndex = 26;
            txt_dp_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 40);
            label13.Name = "label13";
            label13.Size = new Size(25, 15);
            label13.TabIndex = 13;
            label13.Text = "O.E";
            // 
            // txt_eixo_esquerdo_perto
            // 
            txt_eixo_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_esquerdo_perto.Location = new Point(185, 35);
            txt_eixo_esquerdo_perto.Mask = "0,00";
            txt_eixo_esquerdo_perto.Name = "txt_eixo_esquerdo_perto";
            txt_eixo_esquerdo_perto.Size = new Size(69, 27);
            txt_eixo_esquerdo_perto.TabIndex = 28;
            txt_eixo_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(4, 9);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 12;
            label14.Text = "O.D";
            // 
            // txt_cil_esquerdo_perto
            // 
            txt_cil_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_esquerdo_perto.Location = new Point(110, 35);
            txt_cil_esquerdo_perto.Mask = "0,00";
            txt_cil_esquerdo_perto.Name = "txt_cil_esquerdo_perto";
            txt_cil_esquerdo_perto.Size = new Size(69, 27);
            txt_cil_esquerdo_perto.TabIndex = 29;
            txt_cil_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_eixo_direito_perto
            // 
            txt_eixo_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_direito_perto.Location = new Point(185, 3);
            txt_eixo_direito_perto.Mask = "0,00";
            txt_eixo_direito_perto.Name = "txt_eixo_direito_perto";
            txt_eixo_direito_perto.Size = new Size(69, 27);
            txt_eixo_direito_perto.TabIndex = 24;
            txt_eixo_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_dp_direito_perto
            // 
            txt_dp_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_direito_perto.Location = new Point(260, 4);
            txt_dp_direito_perto.Mask = "0,00";
            txt_dp_direito_perto.Name = "txt_dp_direito_perto";
            txt_dp_direito_perto.Size = new Size(69, 27);
            txt_dp_direito_perto.TabIndex = 25;
            txt_dp_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_cil_direito_perto
            // 
            txt_cil_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_direito_perto.Location = new Point(110, 3);
            txt_cil_direito_perto.Mask = "0,00";
            txt_cil_direito_perto.Name = "txt_cil_direito_perto";
            txt_cil_direito_perto.Size = new Size(69, 27);
            txt_cil_direito_perto.TabIndex = 23;
            txt_cil_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_direito_perto
            // 
            txt_esf_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_direito_perto.Location = new Point(35, 4);
            txt_esf_direito_perto.Mask = "0,00";
            txt_esf_direito_perto.Name = "txt_esf_direito_perto";
            txt_esf_direito_perto.Size = new Size(69, 27);
            txt_esf_direito_perto.TabIndex = 22;
            txt_esf_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_esquerdo_perto
            // 
            txt_esf_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_esquerdo_perto.Location = new Point(35, 35);
            txt_esf_esquerdo_perto.Mask = "0,00";
            txt_esf_esquerdo_perto.Name = "txt_esf_esquerdo_perto";
            txt_esf_esquerdo_perto.Size = new Size(69, 27);
            txt_esf_esquerdo_perto.TabIndex = 27;
            txt_esf_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // MainReceita
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(935, 364);
            Controls.Add(label8);
            Controls.Add(panel4);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dg_receitas);
            Name = "MainReceita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exames";
            Load += MainExames_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_receitas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btn_deletar;
        private Button btn_show_editar;
        private Button bnt_cadastrar;
        private DataGridView dg_receitas;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel5;
        private Label label13;
        private Label label14;
        private MaskedTextBox txt_esf_direito_longe;
        private MaskedTextBox txt_dp_esquerdo_longe;
        private MaskedTextBox txt_eixo_esquerdo_longe;
        private MaskedTextBox txt_cil_esquerdo_longe;
        private MaskedTextBox txt_eixo_direito_longe;
        private MaskedTextBox txt_cil_direito_longe;
        private MaskedTextBox txt_esf_esquerdo_longe;
        private MaskedTextBox txt_dp_direito_longe;
        private MaskedTextBox txt_dp_esquerdo_perto;
        private MaskedTextBox txt_eixo_esquerdo_perto;
        private MaskedTextBox txt_cil_esquerdo_perto;
        private MaskedTextBox txt_eixo_direito_perto;
        private MaskedTextBox txt_dp_direito_perto;
        private MaskedTextBox txt_cil_direito_perto;
        private MaskedTextBox txt_esf_direito_perto;
        private MaskedTextBox txt_esf_esquerdo_perto;
        private DataGridViewTextBoxColumn DataExame;
        private DataGridViewTextBoxColumn DataValExame;
        private DataGridViewTextBoxColumn nomeExaminador;
    }
}