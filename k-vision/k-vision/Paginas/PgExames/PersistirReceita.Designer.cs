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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersistirReceita));
            btn_fechar = new Button();
            btn_salvar = new Button();
            panel1 = new Panel();
            dtp_data_realizado = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            txt_nome_dr = new TextBox();
            panel7 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label19 = new Label();
            label20 = new Label();
            panel8 = new Panel();
            label21 = new Label();
            label22 = new Label();
            txt_altura_esquerdo = new MaskedTextBox();
            txt_adicao_esquerdo = new MaskedTextBox();
            txt_adicao_direito = new MaskedTextBox();
            txt_altura_direito = new MaskedTextBox();
            lbl_perto = new Label();
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
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel_longe.SuspendLayout();
            panel3.SuspendLayout();
            panel_perto.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.LightGray;
            btn_fechar.BackgroundImage = (Image)resources.GetObject("btn_fechar.BackgroundImage");
            btn_fechar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_fechar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fechar.Location = new Point(668, 3);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(24, 24);
            btn_fechar.TabIndex = 14;
            btn_fechar.TextAlign = ContentAlignment.MiddleRight;
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.LightGray;
            btn_salvar.FlatAppearance.BorderColor = Color.Gray;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.ForeColor = Color.FromArgb(64, 64, 64);
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salvar.Location = new Point(287, 517);
            btn_salvar.Margin = new Padding(3, 4, 3, 4);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(85, 33);
            btn_salvar.TabIndex = 42;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtp_data_realizado);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_nome_dr);
            panel1.Location = new Point(6, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 167);
            panel1.TabIndex = 47;
            // 
            // dtp_data_realizado
            // 
            dtp_data_realizado.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dtp_data_realizado.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dtp_data_realizado.Format = DateTimePickerFormat.Short;
            dtp_data_realizado.Location = new Point(13, 44);
            dtp_data_realizado.Name = "dtp_data_realizado";
            dtp_data_realizado.Size = new Size(278, 27);
            dtp_data_realizado.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(10, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 16;
            label2.Text = "Realizado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(10, 88);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 15;
            label1.Text = "Nome do doutor:";
            // 
            // txt_nome_dr
            // 
            txt_nome_dr.BorderStyle = BorderStyle.FixedSingle;
            txt_nome_dr.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome_dr.ForeColor = Color.FromArgb(64, 64, 64);
            txt_nome_dr.Location = new Point(13, 114);
            txt_nome_dr.Margin = new Padding(3, 4, 3, 4);
            txt_nome_dr.Name = "txt_nome_dr";
            txt_nome_dr.Size = new Size(278, 27);
            txt_nome_dr.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.LightGray;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(lbl_perto);
            panel7.Controls.Add(panel_longe);
            panel7.Controls.Add(panel_perto);
            panel7.Controls.Add(lbl_longe);
            panel7.Location = new Point(320, 45);
            panel7.Name = "panel7";
            panel7.Size = new Size(364, 459);
            panel7.TabIndex = 46;
            // 
            // panel9
            // 
            panel9.BackColor = Color.RoyalBlue;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label3);
            panel9.Location = new Point(-1, -1);
            panel9.Name = "panel9";
            panel9.Size = new Size(364, 25);
            panel9.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(145, 2);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 33;
            label3.Text = "Prescrição";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.PowderBlue;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label19);
            panel6.Controls.Add(label20);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(80, 340);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 109);
            panel6.TabIndex = 25;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(123, 7);
            label19.Name = "label19";
            label19.Size = new Size(51, 20);
            label19.TabIndex = 9;
            label19.Text = "Altura";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(64, 64, 64);
            label20.Location = new Point(42, 7);
            label20.Name = "label20";
            label20.Size = new Size(56, 20);
            label20.TabIndex = 8;
            label20.Text = "Adição";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.WhiteSmoke;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label21);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(txt_altura_esquerdo);
            panel8.Controls.Add(txt_adicao_esquerdo);
            panel8.Controls.Add(txt_adicao_direito);
            panel8.Controls.Add(txt_altura_direito);
            panel8.Location = new Point(-1, 33);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 75);
            panel8.TabIndex = 8;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(7, 47);
            label21.Name = "label21";
            label21.Size = new Size(24, 15);
            label21.TabIndex = 13;
            label21.Text = "O.E";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(64, 64, 64);
            label22.Location = new Point(7, 13);
            label22.Name = "label22";
            label22.Size = new Size(27, 15);
            label22.TabIndex = 12;
            label22.Text = "O.D";
            // 
            // txt_altura_esquerdo
            // 
            txt_altura_esquerdo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_altura_esquerdo.Location = new Point(116, 39);
            txt_altura_esquerdo.Mask = "0,00";
            txt_altura_esquerdo.Name = "txt_altura_esquerdo";
            txt_altura_esquerdo.Size = new Size(69, 27);
            txt_altura_esquerdo.TabIndex = 39;
            txt_altura_esquerdo.ValidatingType = typeof(DateTime);
            // 
            // txt_adicao_esquerdo
            // 
            txt_adicao_esquerdo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_adicao_esquerdo.Location = new Point(41, 39);
            txt_adicao_esquerdo.Mask = "0,00";
            txt_adicao_esquerdo.Name = "txt_adicao_esquerdo";
            txt_adicao_esquerdo.Size = new Size(69, 27);
            txt_adicao_esquerdo.TabIndex = 38;
            txt_adicao_esquerdo.ValidatingType = typeof(DateTime);
            // 
            // txt_adicao_direito
            // 
            txt_adicao_direito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_adicao_direito.Location = new Point(41, 8);
            txt_adicao_direito.Mask = "0,00";
            txt_adicao_direito.Name = "txt_adicao_direito";
            txt_adicao_direito.Size = new Size(69, 27);
            txt_adicao_direito.TabIndex = 34;
            txt_adicao_direito.ValidatingType = typeof(DateTime);
            // 
            // txt_altura_direito
            // 
            txt_altura_direito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_altura_direito.Location = new Point(116, 7);
            txt_altura_direito.Mask = "0,00";
            txt_altura_direito.Name = "txt_altura_direito";
            txt_altura_direito.Size = new Size(69, 27);
            txt_altura_direito.TabIndex = 35;
            txt_altura_direito.ValidatingType = typeof(DateTime);
            // 
            // lbl_perto
            // 
            lbl_perto.AutoSize = true;
            lbl_perto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_perto.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_perto.Location = new Point(158, 188);
            lbl_perto.Name = "lbl_perto";
            lbl_perto.Size = new Size(51, 21);
            lbl_perto.TabIndex = 24;
            lbl_perto.Text = "Perto";
            lbl_perto.Visible = false;
            // 
            // panel_longe
            // 
            panel_longe.Anchor = AnchorStyles.None;
            panel_longe.BackColor = Color.Bisque;
            panel_longe.BorderStyle = BorderStyle.FixedSingle;
            panel_longe.Controls.Add(label4);
            panel_longe.Controls.Add(label5);
            panel_longe.Controls.Add(label6);
            panel_longe.Controls.Add(label15);
            panel_longe.Controls.Add(panel3);
            panel_longe.Location = new Point(7, 66);
            panel_longe.Margin = new Padding(3, 4, 3, 4);
            panel_longe.Name = "panel_longe";
            panel_longe.Size = new Size(344, 107);
            panel_longe.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
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
            label5.ForeColor = Color.FromArgb(64, 64, 64);
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
            label6.ForeColor = Color.FromArgb(64, 64, 64);
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
            label15.ForeColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(63, 7);
            label15.Name = "label15";
            label15.Size = new Size(31, 20);
            label15.TabIndex = 8;
            label15.Text = "Esf.";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
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
            panel3.Location = new Point(-1, 32);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 74);
            panel3.TabIndex = 8;
            // 
            // txt_dp_esquerdo_longe
            // 
            txt_dp_esquerdo_longe.BorderStyle = BorderStyle.FixedSingle;
            txt_dp_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_esquerdo_longe.ForeColor = Color.FromArgb(64, 64, 64);
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
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(7, 47);
            label16.Name = "label16";
            label16.Size = new Size(24, 15);
            label16.TabIndex = 13;
            label16.Text = "O.E";
            // 
            // txt_eixo_esquerdo_longe
            // 
            txt_eixo_esquerdo_longe.BorderStyle = BorderStyle.FixedSingle;
            txt_eixo_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_esquerdo_longe.ForeColor = Color.FromArgb(64, 64, 64);
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
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(64, 64, 64);
            label17.Location = new Point(7, 13);
            label17.Name = "label17";
            label17.Size = new Size(27, 15);
            label17.TabIndex = 12;
            label17.Text = "O.D";
            // 
            // txt_cil_esquerdo_longe
            // 
            txt_cil_esquerdo_longe.BorderStyle = BorderStyle.FixedSingle;
            txt_cil_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_esquerdo_longe.ForeColor = Color.FromArgb(64, 64, 64);
            txt_cil_esquerdo_longe.Location = new Point(115, 38);
            txt_cil_esquerdo_longe.Mask = "0,00";
            txt_cil_esquerdo_longe.Name = "txt_cil_esquerdo_longe";
            txt_cil_esquerdo_longe.Size = new Size(69, 27);
            txt_cil_esquerdo_longe.TabIndex = 31;
            txt_cil_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_direito_longe
            // 
            txt_esf_direito_longe.BorderStyle = BorderStyle.FixedSingle;
            txt_esf_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_direito_longe.ForeColor = Color.FromArgb(64, 64, 64);
            txt_esf_direito_longe.Location = new Point(40, 7);
            txt_esf_direito_longe.Mask = "0,00";
            txt_esf_direito_longe.Name = "txt_esf_direito_longe";
            txt_esf_direito_longe.Size = new Size(69, 27);
            txt_esf_direito_longe.TabIndex = 26;
            txt_esf_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_eixo_direito_longe
            // 
            txt_eixo_direito_longe.BorderStyle = BorderStyle.FixedSingle;
            txt_eixo_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_direito_longe.ForeColor = Color.FromArgb(64, 64, 64);
            txt_eixo_direito_longe.Location = new Point(190, 6);
            txt_eixo_direito_longe.Mask = "0,00";
            txt_eixo_direito_longe.Name = "txt_eixo_direito_longe";
            txt_eixo_direito_longe.Size = new Size(69, 27);
            txt_eixo_direito_longe.TabIndex = 28;
            txt_eixo_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_dp_direito_longe
            // 
            txt_dp_direito_longe.BorderStyle = BorderStyle.FixedSingle;
            txt_dp_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_direito_longe.ForeColor = Color.FromArgb(64, 64, 64);
            txt_dp_direito_longe.Location = new Point(265, 7);
            txt_dp_direito_longe.Mask = "0,00";
            txt_dp_direito_longe.Name = "txt_dp_direito_longe";
            txt_dp_direito_longe.Size = new Size(69, 27);
            txt_dp_direito_longe.TabIndex = 29;
            txt_dp_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_cil_direito_longe
            // 
            txt_cil_direito_longe.BorderStyle = BorderStyle.FixedSingle;
            txt_cil_direito_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_direito_longe.ForeColor = Color.FromArgb(64, 64, 64);
            txt_cil_direito_longe.Location = new Point(115, 6);
            txt_cil_direito_longe.Mask = "0,00";
            txt_cil_direito_longe.Name = "txt_cil_direito_longe";
            txt_cil_direito_longe.Size = new Size(69, 27);
            txt_cil_direito_longe.TabIndex = 27;
            txt_cil_direito_longe.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_esquerdo_longe
            // 
            txt_esf_esquerdo_longe.BorderStyle = BorderStyle.FixedSingle;
            txt_esf_esquerdo_longe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_esquerdo_longe.ForeColor = Color.FromArgb(64, 64, 64);
            txt_esf_esquerdo_longe.Location = new Point(40, 38);
            txt_esf_esquerdo_longe.Mask = "0,00";
            txt_esf_esquerdo_longe.Name = "txt_esf_esquerdo_longe";
            txt_esf_esquerdo_longe.Size = new Size(69, 27);
            txt_esf_esquerdo_longe.TabIndex = 30;
            txt_esf_esquerdo_longe.ValidatingType = typeof(DateTime);
            // 
            // panel_perto
            // 
            panel_perto.Anchor = AnchorStyles.None;
            panel_perto.BackColor = Color.Thistle;
            panel_perto.BorderStyle = BorderStyle.FixedSingle;
            panel_perto.Controls.Add(label9);
            panel_perto.Controls.Add(label10);
            panel_perto.Controls.Add(label11);
            panel_perto.Controls.Add(label12);
            panel_perto.Controls.Add(panel5);
            panel_perto.Location = new Point(7, 211);
            panel_perto.Margin = new Padding(3, 4, 3, 4);
            panel_perto.Name = "panel_perto";
            panel_perto.Size = new Size(347, 109);
            panel_perto.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
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
            label10.ForeColor = Color.FromArgb(64, 64, 64);
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
            label11.ForeColor = Color.FromArgb(64, 64, 64);
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
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(56, 7);
            label12.Name = "label12";
            label12.Size = new Size(31, 20);
            label12.TabIndex = 8;
            label12.Text = "Esf.";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
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
            panel5.Location = new Point(-1, 33);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(347, 75);
            panel5.TabIndex = 8;
            // 
            // txt_dp_esquerdo_perto
            // 
            txt_dp_esquerdo_perto.BorderStyle = BorderStyle.FixedSingle;
            txt_dp_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_esquerdo_perto.ForeColor = Color.FromArgb(64, 64, 64);
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
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(7, 47);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 13;
            label13.Text = "O.E";
            // 
            // txt_eixo_esquerdo_perto
            // 
            txt_eixo_esquerdo_perto.BorderStyle = BorderStyle.FixedSingle;
            txt_eixo_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_esquerdo_perto.ForeColor = Color.FromArgb(64, 64, 64);
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
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(7, 13);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 12;
            label14.Text = "O.D";
            // 
            // txt_cil_esquerdo_perto
            // 
            txt_cil_esquerdo_perto.BorderStyle = BorderStyle.FixedSingle;
            txt_cil_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_esquerdo_perto.ForeColor = Color.FromArgb(64, 64, 64);
            txt_cil_esquerdo_perto.Location = new Point(116, 39);
            txt_cil_esquerdo_perto.Mask = "0,00";
            txt_cil_esquerdo_perto.Name = "txt_cil_esquerdo_perto";
            txt_cil_esquerdo_perto.Size = new Size(69, 27);
            txt_cil_esquerdo_perto.TabIndex = 39;
            txt_cil_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_eixo_direito_perto
            // 
            txt_eixo_direito_perto.BorderStyle = BorderStyle.FixedSingle;
            txt_eixo_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eixo_direito_perto.ForeColor = Color.FromArgb(64, 64, 64);
            txt_eixo_direito_perto.Location = new Point(191, 7);
            txt_eixo_direito_perto.Mask = "0,00";
            txt_eixo_direito_perto.Name = "txt_eixo_direito_perto";
            txt_eixo_direito_perto.Size = new Size(69, 27);
            txt_eixo_direito_perto.TabIndex = 36;
            txt_eixo_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_esquerdo_perto
            // 
            txt_esf_esquerdo_perto.BorderStyle = BorderStyle.FixedSingle;
            txt_esf_esquerdo_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_esquerdo_perto.ForeColor = Color.FromArgb(64, 64, 64);
            txt_esf_esquerdo_perto.Location = new Point(41, 39);
            txt_esf_esquerdo_perto.Mask = "0,00";
            txt_esf_esquerdo_perto.Name = "txt_esf_esquerdo_perto";
            txt_esf_esquerdo_perto.Size = new Size(69, 27);
            txt_esf_esquerdo_perto.TabIndex = 38;
            txt_esf_esquerdo_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_dp_direito_perto
            // 
            txt_dp_direito_perto.BorderStyle = BorderStyle.FixedSingle;
            txt_dp_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dp_direito_perto.ForeColor = Color.FromArgb(64, 64, 64);
            txt_dp_direito_perto.Location = new Point(266, 8);
            txt_dp_direito_perto.Mask = "0,00";
            txt_dp_direito_perto.Name = "txt_dp_direito_perto";
            txt_dp_direito_perto.Size = new Size(69, 27);
            txt_dp_direito_perto.TabIndex = 37;
            txt_dp_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_esf_direito_perto
            // 
            txt_esf_direito_perto.BorderStyle = BorderStyle.FixedSingle;
            txt_esf_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_esf_direito_perto.ForeColor = Color.FromArgb(64, 64, 64);
            txt_esf_direito_perto.Location = new Point(41, 8);
            txt_esf_direito_perto.Mask = "0,00";
            txt_esf_direito_perto.Name = "txt_esf_direito_perto";
            txt_esf_direito_perto.Size = new Size(69, 27);
            txt_esf_direito_perto.TabIndex = 34;
            txt_esf_direito_perto.ValidatingType = typeof(DateTime);
            // 
            // txt_cil_direito_perto
            // 
            txt_cil_direito_perto.BorderStyle = BorderStyle.FixedSingle;
            txt_cil_direito_perto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cil_direito_perto.ForeColor = Color.FromArgb(64, 64, 64);
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
            lbl_longe.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_longe.Location = new Point(152, 43);
            lbl_longe.Name = "lbl_longe";
            lbl_longe.Size = new Size(57, 21);
            lbl_longe.TabIndex = 22;
            lbl_longe.Text = "Longe";
            lbl_longe.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(8, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.LightGray;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(33, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(58, 20);
            lblTitulo.TabIndex = 49;
            lblTitulo.Text = "Receita";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btn_fechar);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(btn_salvar);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel7);
            panel4.Location = new Point(0, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(696, 564);
            panel4.TabIndex = 51;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 29);
            panel2.TabIndex = 48;
            // 
            // PersistirReceita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(696, 564);
            Controls.Add(pictureBox3);
            Controls.Add(lblTitulo);
            Controls.Add(panel4);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PersistirReceita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastrar receita";
            Load += PersistirReceita_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel_longe.ResumeLayout(false);
            panel_longe.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel_perto.ResumeLayout(false);
            panel_perto.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox txt_d_realizado;
        private MaskedTextBox txt_d_validade;
        private Button btn_fechar;
        private Button btn_salvar;
        private Panel panel1;
        private DateTimePicker dtp_data_realizado;
        private Label label2;
        private Label label1;
        private TextBox txt_nome_dr;
        private Panel panel7;
        private Label lbl_perto;
        private Panel panel_longe;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label15;
        private Panel panel3;
        private MaskedTextBox txt_dp_esquerdo_longe;
        private Label label16;
        private MaskedTextBox txt_eixo_esquerdo_longe;
        private Label label17;
        private MaskedTextBox txt_cil_esquerdo_longe;
        private MaskedTextBox txt_esf_direito_longe;
        private MaskedTextBox txt_eixo_direito_longe;
        private MaskedTextBox txt_dp_direito_longe;
        private MaskedTextBox txt_cil_direito_longe;
        private MaskedTextBox txt_esf_esquerdo_longe;
        private Panel panel_perto;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel5;
        private MaskedTextBox txt_dp_esquerdo_perto;
        private Label label13;
        private MaskedTextBox txt_eixo_esquerdo_perto;
        private Label label14;
        private MaskedTextBox txt_cil_esquerdo_perto;
        private MaskedTextBox txt_eixo_direito_perto;
        private MaskedTextBox txt_esf_esquerdo_perto;
        private MaskedTextBox txt_dp_direito_perto;
        private MaskedTextBox txt_esf_direito_perto;
        private MaskedTextBox txt_cil_direito_perto;
        private Label lbl_longe;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Panel panel4;
        private Panel panel6;
        private Label label19;
        private Label label20;
        private Panel panel8;
        private Label label21;
        private Label label22;
        private MaskedTextBox txt_altura_esquerdo;
        private MaskedTextBox txt_adicao_esquerdo;
        private MaskedTextBox txt_adicao_direito;
        private MaskedTextBox txt_altura_direito;
        private Panel panel2;
        private Panel panel9;
        private Label label3;
    }
}