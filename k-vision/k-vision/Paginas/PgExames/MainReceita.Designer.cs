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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_show_editar = new System.Windows.Forms.Button();
            this.bnt_cadastrar = new System.Windows.Forms.Button();
            this.dg_receitas = new System.Windows.Forms.DataGridView();
            this.DataExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataValExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeExaminador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_dp_esquerdo_longe = new System.Windows.Forms.MaskedTextBox();
            this.txt_eixo_esquerdo_longe = new System.Windows.Forms.MaskedTextBox();
            this.txt_cil_esquerdo_longe = new System.Windows.Forms.MaskedTextBox();
            this.txt_eixo_direito_longe = new System.Windows.Forms.MaskedTextBox();
            this.txt_cil_direito_longe = new System.Windows.Forms.MaskedTextBox();
            this.txt_esf_esquerdo_longe = new System.Windows.Forms.MaskedTextBox();
            this.txt_esf_direito_longe = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dp_direito_longe = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_dp_esquerdo_perto = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_eixo_esquerdo_perto = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cil_esquerdo_perto = new System.Windows.Forms.MaskedTextBox();
            this.txt_eixo_direito_perto = new System.Windows.Forms.MaskedTextBox();
            this.txt_dp_direito_perto = new System.Windows.Forms.MaskedTextBox();
            this.txt_cil_direito_perto = new System.Windows.Forms.MaskedTextBox();
            this.txt_esf_direito_perto = new System.Windows.Forms.MaskedTextBox();
            this.txt_esf_esquerdo_perto = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_receitas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.btn_show_editar);
            this.panel1.Controls.Add(this.bnt_cadastrar);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 368);
            this.panel1.TabIndex = 6;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletar.FlatAppearance.BorderSize = 0;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Location = new System.Drawing.Point(8, 209);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(135, 48);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_show_editar
            // 
            this.btn_show_editar.BackColor = System.Drawing.Color.Orange;
            this.btn_show_editar.FlatAppearance.BorderSize = 0;
            this.btn_show_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_editar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_show_editar.ForeColor = System.Drawing.Color.White;
            this.btn_show_editar.Location = new System.Drawing.Point(7, 140);
            this.btn_show_editar.Name = "btn_show_editar";
            this.btn_show_editar.Size = new System.Drawing.Size(135, 48);
            this.btn_show_editar.TabIndex = 3;
            this.btn_show_editar.Text = "Editar";
            this.btn_show_editar.UseVisualStyleBackColor = false;
            this.btn_show_editar.Click += new System.EventHandler(this.btn_show_editar_Click);
            // 
            // bnt_cadastrar
            // 
            this.bnt_cadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.bnt_cadastrar.FlatAppearance.BorderSize = 0;
            this.bnt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_cadastrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnt_cadastrar.ForeColor = System.Drawing.Color.White;
            this.bnt_cadastrar.Location = new System.Drawing.Point(7, 69);
            this.bnt_cadastrar.Name = "bnt_cadastrar";
            this.bnt_cadastrar.Size = new System.Drawing.Size(135, 48);
            this.bnt_cadastrar.TabIndex = 2;
            this.bnt_cadastrar.Text = "Cadastrar";
            this.bnt_cadastrar.UseVisualStyleBackColor = false;
            this.bnt_cadastrar.Click += new System.EventHandler(this.bnt_cadastrar_Click);
            // 
            // dg_receitas
            // 
            this.dg_receitas.AllowUserToAddRows = false;
            this.dg_receitas.AllowUserToDeleteRows = false;
            this.dg_receitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_receitas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dg_receitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_receitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_receitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_receitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_receitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_receitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataExame,
            this.DataValExame,
            this.nomeExaminador});
            this.dg_receitas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_receitas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_receitas.EnableHeadersVisualStyles = false;
            this.dg_receitas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dg_receitas.Location = new System.Drawing.Point(176, 12);
            this.dg_receitas.MultiSelect = false;
            this.dg_receitas.Name = "dg_receitas";
            this.dg_receitas.ReadOnly = true;
            this.dg_receitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_receitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_receitas.RowHeadersVisible = false;
            this.dg_receitas.RowTemplate.Height = 25;
            this.dg_receitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_receitas.Size = new System.Drawing.Size(380, 340);
            this.dg_receitas.TabIndex = 5;
            this.dg_receitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_receitas_CellClick);
            // 
            // DataExame
            // 
            this.DataExame.DataPropertyName = "DataExame";
            this.DataExame.HeaderText = "Data";
            this.DataExame.Name = "DataExame";
            this.DataExame.ReadOnly = true;
            this.DataExame.Width = 80;
            // 
            // DataValExame
            // 
            this.DataValExame.DataPropertyName = "DataValExame";
            this.DataValExame.HeaderText = "Validade";
            this.DataValExame.MinimumWidth = 60;
            this.DataValExame.Name = "DataValExame";
            this.DataValExame.ReadOnly = true;
            // 
            // nomeExaminador
            // 
            this.nomeExaminador.DataPropertyName = "nomeExaminador";
            this.nomeExaminador.HeaderText = "Doutor";
            this.nomeExaminador.Name = "nomeExaminador";
            this.nomeExaminador.ReadOnly = true;
            this.nomeExaminador.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(578, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 90);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(276, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "DP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Eixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cil.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Esf.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.txt_dp_esquerdo_longe);
            this.panel3.Controls.Add(this.txt_eixo_esquerdo_longe);
            this.panel3.Controls.Add(this.txt_cil_esquerdo_longe);
            this.panel3.Controls.Add(this.txt_eixo_direito_longe);
            this.panel3.Controls.Add(this.txt_cil_direito_longe);
            this.panel3.Controls.Add(this.txt_esf_esquerdo_longe);
            this.panel3.Controls.Add(this.txt_esf_direito_longe);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_dp_direito_longe);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 65);
            this.panel3.TabIndex = 8;
            // 
            // txt_dp_esquerdo_longe
            // 
            this.txt_dp_esquerdo_longe.Enabled = false;
            this.txt_dp_esquerdo_longe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dp_esquerdo_longe.Location = new System.Drawing.Point(260, 34);
            this.txt_dp_esquerdo_longe.Mask = "0,00";
            this.txt_dp_esquerdo_longe.Name = "txt_dp_esquerdo_longe";
            this.txt_dp_esquerdo_longe.Size = new System.Drawing.Size(69, 27);
            this.txt_dp_esquerdo_longe.TabIndex = 19;
            this.txt_dp_esquerdo_longe.ValidatingType = typeof(System.DateTime);
            // 
            // txt_eixo_esquerdo_longe
            // 
            this.txt_eixo_esquerdo_longe.Enabled = false;
            this.txt_eixo_esquerdo_longe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_eixo_esquerdo_longe.Location = new System.Drawing.Point(185, 35);
            this.txt_eixo_esquerdo_longe.Mask = "0,00";
            this.txt_eixo_esquerdo_longe.Name = "txt_eixo_esquerdo_longe";
            this.txt_eixo_esquerdo_longe.Size = new System.Drawing.Size(69, 27);
            this.txt_eixo_esquerdo_longe.TabIndex = 20;
            this.txt_eixo_esquerdo_longe.ValidatingType = typeof(System.DateTime);
            // 
            // txt_cil_esquerdo_longe
            // 
            this.txt_cil_esquerdo_longe.Enabled = false;
            this.txt_cil_esquerdo_longe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cil_esquerdo_longe.Location = new System.Drawing.Point(110, 35);
            this.txt_cil_esquerdo_longe.Mask = "0,00";
            this.txt_cil_esquerdo_longe.Name = "txt_cil_esquerdo_longe";
            this.txt_cil_esquerdo_longe.Size = new System.Drawing.Size(69, 27);
            this.txt_cil_esquerdo_longe.TabIndex = 21;
            this.txt_cil_esquerdo_longe.ValidatingType = typeof(System.DateTime);
            // 
            // txt_eixo_direito_longe
            // 
            this.txt_eixo_direito_longe.Enabled = false;
            this.txt_eixo_direito_longe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_eixo_direito_longe.Location = new System.Drawing.Point(185, 3);
            this.txt_eixo_direito_longe.Mask = "0,00";
            this.txt_eixo_direito_longe.Name = "txt_eixo_direito_longe";
            this.txt_eixo_direito_longe.Size = new System.Drawing.Size(69, 27);
            this.txt_eixo_direito_longe.TabIndex = 17;
            this.txt_eixo_direito_longe.ValidatingType = typeof(System.DateTime);
            // 
            // txt_cil_direito_longe
            // 
            this.txt_cil_direito_longe.Enabled = false;
            this.txt_cil_direito_longe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cil_direito_longe.Location = new System.Drawing.Point(110, 3);
            this.txt_cil_direito_longe.Mask = "0,00";
            this.txt_cil_direito_longe.Name = "txt_cil_direito_longe";
            this.txt_cil_direito_longe.Size = new System.Drawing.Size(69, 27);
            this.txt_cil_direito_longe.TabIndex = 16;
            this.txt_cil_direito_longe.ValidatingType = typeof(System.DateTime);
            // 
            // txt_esf_esquerdo_longe
            // 
            this.txt_esf_esquerdo_longe.Enabled = false;
            this.txt_esf_esquerdo_longe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_esf_esquerdo_longe.Location = new System.Drawing.Point(35, 35);
            this.txt_esf_esquerdo_longe.Mask = "0,00";
            this.txt_esf_esquerdo_longe.Name = "txt_esf_esquerdo_longe";
            this.txt_esf_esquerdo_longe.Size = new System.Drawing.Size(69, 27);
            this.txt_esf_esquerdo_longe.TabIndex = 19;
            this.txt_esf_esquerdo_longe.ValidatingType = typeof(System.DateTime);
            // 
            // txt_esf_direito_longe
            // 
            this.txt_esf_direito_longe.Enabled = false;
            this.txt_esf_direito_longe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_esf_direito_longe.Location = new System.Drawing.Point(35, 4);
            this.txt_esf_direito_longe.Mask = "0,00";
            this.txt_esf_direito_longe.Name = "txt_esf_direito_longe";
            this.txt_esf_direito_longe.Size = new System.Drawing.Size(69, 27);
            this.txt_esf_direito_longe.TabIndex = 15;
            this.txt_esf_direito_longe.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "O.E";
            // 
            // txt_dp_direito_longe
            // 
            this.txt_dp_direito_longe.Enabled = false;
            this.txt_dp_direito_longe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dp_direito_longe.Location = new System.Drawing.Point(260, 4);
            this.txt_dp_direito_longe.Mask = "0,00";
            this.txt_dp_direito_longe.Name = "txt_dp_direito_longe";
            this.txt_dp_direito_longe.Size = new System.Drawing.Size(69, 27);
            this.txt_dp_direito_longe.TabIndex = 18;
            this.txt_dp_direito_longe.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "O.D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(723, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Longe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(723, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Perto";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(578, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 91);
            this.panel4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(276, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "DP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(195, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Eixo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(121, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Cil.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(49, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Esf.";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.txt_dp_esquerdo_perto);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txt_eixo_esquerdo_perto);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txt_cil_esquerdo_perto);
            this.panel5.Controls.Add(this.txt_eixo_direito_perto);
            this.panel5.Controls.Add(this.txt_dp_direito_perto);
            this.panel5.Controls.Add(this.txt_cil_direito_perto);
            this.panel5.Controls.Add(this.txt_esf_direito_perto);
            this.panel5.Controls.Add(this.txt_esf_esquerdo_perto);
            this.panel5.Location = new System.Drawing.Point(0, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 66);
            this.panel5.TabIndex = 8;
            // 
            // txt_dp_esquerdo_perto
            // 
            this.txt_dp_esquerdo_perto.Enabled = false;
            this.txt_dp_esquerdo_perto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dp_esquerdo_perto.Location = new System.Drawing.Point(260, 34);
            this.txt_dp_esquerdo_perto.Mask = "0,00";
            this.txt_dp_esquerdo_perto.Name = "txt_dp_esquerdo_perto";
            this.txt_dp_esquerdo_perto.Size = new System.Drawing.Size(69, 27);
            this.txt_dp_esquerdo_perto.TabIndex = 26;
            this.txt_dp_esquerdo_perto.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "O.E";
            // 
            // txt_eixo_esquerdo_perto
            // 
            this.txt_eixo_esquerdo_perto.Enabled = false;
            this.txt_eixo_esquerdo_perto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_eixo_esquerdo_perto.Location = new System.Drawing.Point(185, 35);
            this.txt_eixo_esquerdo_perto.Mask = "0,00";
            this.txt_eixo_esquerdo_perto.Name = "txt_eixo_esquerdo_perto";
            this.txt_eixo_esquerdo_perto.Size = new System.Drawing.Size(69, 27);
            this.txt_eixo_esquerdo_perto.TabIndex = 28;
            this.txt_eixo_esquerdo_perto.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(4, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "O.D";
            // 
            // txt_cil_esquerdo_perto
            // 
            this.txt_cil_esquerdo_perto.Enabled = false;
            this.txt_cil_esquerdo_perto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cil_esquerdo_perto.Location = new System.Drawing.Point(110, 35);
            this.txt_cil_esquerdo_perto.Mask = "0,00";
            this.txt_cil_esquerdo_perto.Name = "txt_cil_esquerdo_perto";
            this.txt_cil_esquerdo_perto.Size = new System.Drawing.Size(69, 27);
            this.txt_cil_esquerdo_perto.TabIndex = 29;
            this.txt_cil_esquerdo_perto.ValidatingType = typeof(System.DateTime);
            // 
            // txt_eixo_direito_perto
            // 
            this.txt_eixo_direito_perto.Enabled = false;
            this.txt_eixo_direito_perto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_eixo_direito_perto.Location = new System.Drawing.Point(185, 3);
            this.txt_eixo_direito_perto.Mask = "0,00";
            this.txt_eixo_direito_perto.Name = "txt_eixo_direito_perto";
            this.txt_eixo_direito_perto.Size = new System.Drawing.Size(69, 27);
            this.txt_eixo_direito_perto.TabIndex = 24;
            this.txt_eixo_direito_perto.ValidatingType = typeof(System.DateTime);
            // 
            // txt_dp_direito_perto
            // 
            this.txt_dp_direito_perto.Enabled = false;
            this.txt_dp_direito_perto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dp_direito_perto.Location = new System.Drawing.Point(260, 4);
            this.txt_dp_direito_perto.Mask = "0,00";
            this.txt_dp_direito_perto.Name = "txt_dp_direito_perto";
            this.txt_dp_direito_perto.Size = new System.Drawing.Size(69, 27);
            this.txt_dp_direito_perto.TabIndex = 25;
            this.txt_dp_direito_perto.ValidatingType = typeof(System.DateTime);
            // 
            // txt_cil_direito_perto
            // 
            this.txt_cil_direito_perto.Enabled = false;
            this.txt_cil_direito_perto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cil_direito_perto.Location = new System.Drawing.Point(110, 3);
            this.txt_cil_direito_perto.Mask = "0,00";
            this.txt_cil_direito_perto.Name = "txt_cil_direito_perto";
            this.txt_cil_direito_perto.Size = new System.Drawing.Size(69, 27);
            this.txt_cil_direito_perto.TabIndex = 23;
            this.txt_cil_direito_perto.ValidatingType = typeof(System.DateTime);
            // 
            // txt_esf_direito_perto
            // 
            this.txt_esf_direito_perto.Enabled = false;
            this.txt_esf_direito_perto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_esf_direito_perto.Location = new System.Drawing.Point(35, 4);
            this.txt_esf_direito_perto.Mask = "0,00";
            this.txt_esf_direito_perto.Name = "txt_esf_direito_perto";
            this.txt_esf_direito_perto.Size = new System.Drawing.Size(69, 27);
            this.txt_esf_direito_perto.TabIndex = 22;
            this.txt_esf_direito_perto.ValidatingType = typeof(System.DateTime);
            // 
            // txt_esf_esquerdo_perto
            // 
            this.txt_esf_esquerdo_perto.Enabled = false;
            this.txt_esf_esquerdo_perto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_esf_esquerdo_perto.Location = new System.Drawing.Point(35, 35);
            this.txt_esf_esquerdo_perto.Mask = "0,00";
            this.txt_esf_esquerdo_perto.Name = "txt_esf_esquerdo_perto";
            this.txt_esf_esquerdo_perto.Size = new System.Drawing.Size(69, 27);
            this.txt_esf_esquerdo_perto.TabIndex = 27;
            this.txt_esf_esquerdo_perto.ValidatingType = typeof(System.DateTime);
            // 
            // MainReceita
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(922, 364);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_receitas);
            this.Name = "MainReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exames";
            this.Shown += new System.EventHandler(this.MainReceita_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_receitas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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