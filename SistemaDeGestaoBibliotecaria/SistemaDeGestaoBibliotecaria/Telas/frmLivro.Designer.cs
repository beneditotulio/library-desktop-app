namespace SistemaDeGestaoBibliotecaria.Telas
{
    partial class frmLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLivro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboNomeSala = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoCapa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoPag = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrPag = new System.Windows.Forms.TextBox();
            this.lablNrPaginas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataActual = new System.Windows.Forms.DateTimePicker();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.txtLingua = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.cboEdicao = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblResenha = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.lblLingua = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblEdicao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigoEditora = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.lblLivro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 31);
            this.panel1.TabIndex = 1;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.ForeColor = System.Drawing.Color.White;
            this.lblLivro.Location = new System.Drawing.Point(48, 6);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(44, 20);
            this.lblLivro.TabIndex = 1;
            this.lblLivro.Text = "Livro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSai
            // 
            this.btnSai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.btnSai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSai.FlatAppearance.BorderSize = 0;
            this.btnSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSai.Image = ((System.Drawing.Image)(resources.GetObject("btnSai.Image")));
            this.btnSai.Location = new System.Drawing.Point(768, 0);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(33, 31);
            this.btnSai.TabIndex = 2;
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGenero);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboNomeSala);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboLocal);
            this.groupBox1.Controls.Add(this.txtCopy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTipoCapa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTipoPag);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNrPag);
            this.groupBox1.Controls.Add(this.lablNrPaginas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDataActual);
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtAutores);
            this.groupBox1.Controls.Add(this.txtLingua);
            this.groupBox1.Controls.Add(this.txtAssunto);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.cboAno);
            this.groupBox1.Controls.Add(this.cboEdicao);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.txtEditora);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblResenha);
            this.groupBox1.Controls.Add(this.lblAutores);
            this.groupBox1.Controls.Add(this.lblLingua);
            this.groupBox1.Controls.Add(this.lblAssunto);
            this.groupBox1.Controls.Add(this.lblLocalizacao);
            this.groupBox1.Controls.Add(this.lblISBN);
            this.groupBox1.Controls.Add(this.lblAno);
            this.groupBox1.Controls.Add(this.lblEdicao);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.lblCodigoEditora);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "a";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            this.groupBox1.Move += new System.EventHandler(this.groupBox1_Move);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Em Exposição",
            "Reserva Técnica"});
            this.cboEstado.Location = new System.Drawing.Point(578, 243);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(184, 26);
            this.cboEstado.TabIndex = 71;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 70;
            this.label7.Text = "Estado:";
            // 
            // cboNomeSala
            // 
            this.cboNomeSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomeSala.FormattingEnabled = true;
            this.cboNomeSala.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Obras de Referência"});
            this.cboNomeSala.Location = new System.Drawing.Point(578, 211);
            this.cboNomeSala.Name = "cboNomeSala";
            this.cboNomeSala.Size = new System.Drawing.Size(184, 26);
            this.cboNomeSala.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 68;
            this.label6.Text = "Localização:";
            // 
            // cboLocal
            // 
            this.cboLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Location = new System.Drawing.Point(121, 227);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(184, 26);
            this.cboLocal.TabIndex = 67;
            this.cboLocal.SelectedIndexChanged += new System.EventHandler(this.cboLocal_SelectedIndexChanged);
            // 
            // txtCopy
            // 
            this.txtCopy.Location = new System.Drawing.Point(578, 181);
            this.txtCopy.Multiline = true;
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(184, 26);
            this.txtCopy.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "Copyright:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Obras de Referência"});
            this.cboTipo.Location = new System.Drawing.Point(578, 151);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(184, 26);
            this.cboTipo.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "Tipo :";
            // 
            // cboTipoCapa
            // 
            this.cboTipoCapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCapa.FormattingEnabled = true;
            this.cboTipoCapa.Items.AddRange(new object[] {
            "Brochado",
            "Encadernado"});
            this.cboTipoCapa.Location = new System.Drawing.Point(578, 121);
            this.cboTipoCapa.Name = "cboTipoCapa";
            this.cboTipoCapa.Size = new System.Drawing.Size(184, 26);
            this.cboTipoCapa.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tipo Capa:";
            // 
            // cboTipoPag
            // 
            this.cboTipoPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPag.FormattingEnabled = true;
            this.cboTipoPag.Items.AddRange(new object[] {
            "Normal",
            "Múltipla"});
            this.cboTipoPag.Location = new System.Drawing.Point(578, 91);
            this.cboTipoPag.Name = "cboTipoPag";
            this.cboTipoPag.Size = new System.Drawing.Size(184, 26);
            this.cboTipoPag.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Tipo Páginação:";
            // 
            // txtNrPag
            // 
            this.txtNrPag.Location = new System.Drawing.Point(578, 62);
            this.txtNrPag.Name = "txtNrPag";
            this.txtNrPag.Size = new System.Drawing.Size(82, 25);
            this.txtNrPag.TabIndex = 58;
            // 
            // lablNrPaginas
            // 
            this.lablNrPaginas.AutoSize = true;
            this.lablNrPaginas.Location = new System.Drawing.Point(492, 66);
            this.lablNrPaginas.Name = "lablNrPaginas";
            this.lablNrPaginas.Size = new System.Drawing.Size(86, 18);
            this.lablNrPaginas.TabIndex = 57;
            this.lablNrPaginas.Text = "Nr Paginas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Data Edição:";
            // 
            // dtpDataActual
            // 
            this.dtpDataActual.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtpDataActual.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataActual.Location = new System.Drawing.Point(463, 32);
            this.dtpDataActual.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataActual.Name = "dtpDataActual";
            this.dtpDataActual.Size = new System.Drawing.Size(299, 25);
            this.dtpDataActual.TabIndex = 55;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackgroundImage = global::SistemaDeGestaoBibliotecaria.Properties.Resources.Search_104px;
            this.btnSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelecionar.Location = new System.Drawing.Point(487, 314);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(34, 26);
            this.btnSelecionar.TabIndex = 23;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(121, 167);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(82, 25);
            this.txtAno.TabIndex = 22;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(121, 344);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(360, 25);
            this.txtDescricao.TabIndex = 21;
            // 
            // txtAutores
            // 
            this.txtAutores.Location = new System.Drawing.Point(121, 315);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(360, 25);
            this.txtAutores.TabIndex = 20;
            // 
            // txtLingua
            // 
            this.txtLingua.Location = new System.Drawing.Point(121, 286);
            this.txtLingua.Name = "txtLingua";
            this.txtLingua.Size = new System.Drawing.Size(360, 25);
            this.txtLingua.TabIndex = 19;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(121, 257);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(360, 25);
            this.txtAssunto.TabIndex = 18;
            this.txtAssunto.Visible = false;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(121, 198);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(82, 25);
            this.txtISBN.TabIndex = 16;
            // 
            // cboAno
            // 
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(121, 163);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(82, 26);
            this.cboAno.TabIndex = 15;
            this.cboAno.Visible = false;
            // 
            // cboEdicao
            // 
            this.cboEdicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicao.FormattingEnabled = true;
            this.cboEdicao.Items.AddRange(new object[] {
            "1 edicao",
            "2 edicao",
            "3 edicao",
            "4 edicao",
            "5 edicao",
            "6 edicao"});
            this.cboEdicao.Location = new System.Drawing.Point(121, 139);
            this.cboEdicao.Name = "cboEdicao";
            this.cboEdicao.Size = new System.Drawing.Size(184, 26);
            this.cboEdicao.TabIndex = 14;
            this.cboEdicao.SelectedIndexChanged += new System.EventHandler(this.cboEdicao_SelectedIndexChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(121, 80);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(184, 55);
            this.txtTitulo.TabIndex = 13;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(121, 51);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(184, 25);
            this.txtEditora.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(121, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(57, 25);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblResenha
            // 
            this.lblResenha.AutoSize = true;
            this.lblResenha.Location = new System.Drawing.Point(40, 348);
            this.lblResenha.Name = "lblResenha";
            this.lblResenha.Size = new System.Drawing.Size(76, 18);
            this.lblResenha.TabIndex = 10;
            this.lblResenha.Text = "Descrição:";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Location = new System.Drawing.Point(51, 319);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(64, 18);
            this.lblAutores.TabIndex = 9;
            this.lblAutores.Text = "Autores:";
            // 
            // lblLingua
            // 
            this.lblLingua.AutoSize = true;
            this.lblLingua.Location = new System.Drawing.Point(57, 289);
            this.lblLingua.Name = "lblLingua";
            this.lblLingua.Size = new System.Drawing.Size(59, 18);
            this.lblLingua.TabIndex = 8;
            this.lblLingua.Text = "Lingua:";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(54, 261);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(61, 18);
            this.lblAssunto.TabIndex = 7;
            this.lblAssunto.Text = "Gênero:";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(19, 230);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(97, 18);
            this.lblLocalizacao.TabIndex = 6;
            this.lblLocalizacao.Text = "Local Edição:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(-15, 204);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(131, 18);
            this.lblISBN.TabIndex = 5;
            this.lblISBN.Text = "Class: ISBN/ISSN:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(76, 173);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(40, 18);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano:";
            // 
            // lblEdicao
            // 
            this.lblEdicao.AutoSize = true;
            this.lblEdicao.Location = new System.Drawing.Point(59, 144);
            this.lblEdicao.Name = "lblEdicao";
            this.lblEdicao.Size = new System.Drawing.Size(57, 18);
            this.lblEdicao.TabIndex = 3;
            this.lblEdicao.Text = "Edição:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(63, 98);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(53, 18);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblCodigoEditora
            // 
            this.lblCodigoEditora.AutoSize = true;
            this.lblCodigoEditora.Location = new System.Drawing.Point(54, 55);
            this.lblCodigoEditora.Name = "lblCodigoEditora";
            this.lblCodigoEditora.Size = new System.Drawing.Size(62, 18);
            this.lblCodigoEditora.TabIndex = 1;
            this.lblCodigoEditora.Text = "Editora:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(57, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // btnApaga
            // 
            this.btnApaga.Enabled = false;
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApaga.Location = new System.Drawing.Point(450, 453);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(135, 36);
            this.btnApaga.TabIndex = 9;
            this.btnApaga.Text = "Apagar";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // btnEdita
            // 
            this.btnEdita.Enabled = false;
            this.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdita.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEdita.Image = ((System.Drawing.Image)(resources.GetObject("btnEdita.Image")));
            this.btnEdita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdita.Location = new System.Drawing.Point(309, 453);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(135, 36);
            this.btnEdita.TabIndex = 8;
            this.btnEdita.Text = "Editar";
            this.btnEdita.UseVisualStyleBackColor = true;
            this.btnEdita.Click += new System.EventHandler(this.btnEdita_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(168, 453);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(135, 36);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(27, 453);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(135, 36);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Romance",
            "Fábula",
            "Novela",
            "Conto",
            "Crônica",
            "Ensaio",
            "Poesia Épica",
            "Biografia",
            "Fantasia",
            "Ficção científica",
            "Horror",
            "Literatura Infanto-Juvenil",
            "Literatura Adulta",
            "Paródia",
            "Suspense",
            "Literatura Gótica",
            "Literatura Esotérica",
            "Literatura de Auto Ajuda",
            "Literatura de Aventura",
            "Literatura Espírita",
            "Literatura de Guerra",
            "Literatura de Negócios",
            "Literatura de Espiritualidade",
            "Literatura de Guerra;",
            "Literatura de Negócios",
            "Literatura de Nutrição;",
            "Livros de Receita."});
            this.cboGenero.Location = new System.Drawing.Point(121, 259);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(184, 26);
            this.cboGenero.TabIndex = 72;
            // 
            // frmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 502);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLivro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLivro_FormClosed);
            this.Load += new System.EventHandler(this.frmLivro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtAutores;
        private System.Windows.Forms.TextBox txtLingua;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ComboBox cboEdicao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblResenha;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Label lblLingua;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblEdicao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoEditora;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoCapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoPag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNrPag;
        private System.Windows.Forms.Label lablNrPaginas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataActual;
        private System.Windows.Forms.ComboBox cboLocal;
        private System.Windows.Forms.ComboBox cboNomeSala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGenero;
    }
}