namespace SistemaDeGestaoBibliotecaria.Telas
{
    partial class frmFotografiasOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFotografiasOA));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.txtCodigoObra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregaFoto = new System.Windows.Forms.Button();
            this.cboTipoObra = new System.Windows.Forms.ComboBox();
            this.cboNomeSala = new System.Windows.Forms.ComboBox();
            this.cboPosicao = new System.Windows.Forms.ComboBox();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.txtProveniencia = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtDimensões = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblcontacto2 = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSai = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pbImagem);
            this.groupBox1.Controls.Add(this.txtCodigoObra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCarregaFoto);
            this.groupBox1.Controls.Add(this.cboTipoObra);
            this.groupBox1.Controls.Add(this.cboNomeSala);
            this.groupBox1.Controls.Add(this.cboPosicao);
            this.groupBox1.Controls.Add(this.cboMaterial);
            this.groupBox1.Controls.Add(this.txtProveniencia);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtDimensões);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.lblProfissao);
            this.groupBox1.Controls.Add(this.lblcontacto2);
            this.groupBox1.Controls.Add(this.lblContacto);
            this.groupBox1.Controls.Add(this.lblEstadoCivil);
            this.groupBox1.Controls.Add(this.lblMaterial);
            this.groupBox1.Controls.Add(this.lblAssunto);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 336);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Em Exposição",
            "Reserva Técnica",
            "Outros"});
            this.cboEstado.Location = new System.Drawing.Point(550, 275);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(184, 25);
            this.cboEstado.TabIndex = 77;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 76;
            this.label8.Text = "Locação:";
            // 
            // pbImagem
            // 
            this.pbImagem.Image = global::SistemaDeGestaoBibliotecaria.Properties.Resources.Create_96px;
            this.pbImagem.Location = new System.Drawing.Point(583, 76);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(151, 158);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 34;
            this.pbImagem.TabStop = false;
            // 
            // txtCodigoObra
            // 
            this.txtCodigoObra.Enabled = false;
            this.txtCodigoObra.Location = new System.Drawing.Point(583, 51);
            this.txtCodigoObra.Name = "txtCodigoObra";
            this.txtCodigoObra.Size = new System.Drawing.Size(127, 23);
            this.txtCodigoObra.TabIndex = 33;
            this.txtCodigoObra.Text = "FOA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Codigo da Obra:";
            // 
            // btnCarregaFoto
            // 
            this.btnCarregaFoto.FlatAppearance.BorderSize = 0;
            this.btnCarregaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregaFoto.Location = new System.Drawing.Point(583, 228);
            this.btnCarregaFoto.Name = "btnCarregaFoto";
            this.btnCarregaFoto.Size = new System.Drawing.Size(151, 36);
            this.btnCarregaFoto.TabIndex = 31;
            this.btnCarregaFoto.Text = "Carregar Foto";
            this.btnCarregaFoto.UseVisualStyleBackColor = true;
            this.btnCarregaFoto.Click += new System.EventHandler(this.btnCarregaFoto_Click);
            // 
            // cboTipoObra
            // 
            this.cboTipoObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoObra.FormattingEnabled = true;
            this.cboTipoObra.Items.AddRange(new object[] {
            "Escultura",
            "Fotografia",
            "Pintura"});
            this.cboTipoObra.Location = new System.Drawing.Point(113, 54);
            this.cboTipoObra.Name = "cboTipoObra";
            this.cboTipoObra.Size = new System.Drawing.Size(201, 25);
            this.cboTipoObra.TabIndex = 29;
            // 
            // cboNomeSala
            // 
            this.cboNomeSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomeSala.FormattingEnabled = true;
            this.cboNomeSala.Items.AddRange(new object[] {
            "Sala Preta",
            "Sala Castanha",
            "AnteCamera",
            "Sala das Cartas Credenciais",
            "Sala Oval",
            "Sala de Lanche",
            "Sala de Audiências",
            "Corredor do PR",
            "Galeria",
            "Escadas de Acesso ao Palacio"});
            this.cboNomeSala.Location = new System.Drawing.Point(113, 247);
            this.cboNomeSala.Name = "cboNomeSala";
            this.cboNomeSala.Size = new System.Drawing.Size(201, 25);
            this.cboNomeSala.TabIndex = 25;
            // 
            // cboPosicao
            // 
            this.cboPosicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicao.FormattingEnabled = true;
            this.cboPosicao.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal",
            "Deitada",
            "De pé",
            "Ajoelhada",
            "Inclinada"});
            this.cboPosicao.Location = new System.Drawing.Point(113, 164);
            this.cboPosicao.Name = "cboPosicao";
            this.cboPosicao.Size = new System.Drawing.Size(201, 25);
            this.cboPosicao.TabIndex = 24;
            this.cboPosicao.SelectedIndexChanged += new System.EventHandler(this.cboPosicao_SelectedIndexChanged);
            // 
            // cboMaterial
            // 
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Items.AddRange(new object[] {
            "Madeira",
            "Pau Preto",
            "Barro",
            "Terra Cota",
            "Metal",
            "Tela Sobre Óleo",
            "Tinta da China",
            "Bustos",
            "Máscaras",
            "Cerâmica"});
            this.cboMaterial.Location = new System.Drawing.Point(113, 136);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(201, 25);
            this.cboMaterial.TabIndex = 23;
            // 
            // txtProveniencia
            // 
            this.txtProveniencia.Location = new System.Drawing.Point(113, 220);
            this.txtProveniencia.Name = "txtProveniencia";
            this.txtProveniencia.Size = new System.Drawing.Size(186, 23);
            this.txtProveniencia.TabIndex = 22;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(113, 275);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(201, 55);
            this.txtDescricao.TabIndex = 20;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtDimensões
            // 
            this.txtDimensões.Location = new System.Drawing.Point(113, 193);
            this.txtDimensões.Name = "txtDimensões";
            this.txtDimensões.Size = new System.Drawing.Size(186, 23);
            this.txtDimensões.TabIndex = 16;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(113, 109);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(201, 23);
            this.txtTitulo.TabIndex = 14;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(113, 82);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(201, 23);
            this.txtAutor.TabIndex = 13;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(113, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 23);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(34, 296);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(76, 17);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(19, 250);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(91, 17);
            this.lblProfissao.TabIndex = 8;
            this.lblProfissao.Text = "Localização:";
            // 
            // lblcontacto2
            // 
            this.lblcontacto2.AutoSize = true;
            this.lblcontacto2.Location = new System.Drawing.Point(22, 223);
            this.lblcontacto2.Name = "lblcontacto2";
            this.lblcontacto2.Size = new System.Drawing.Size(88, 17);
            this.lblcontacto2.TabIndex = 7;
            this.lblcontacto2.Text = "Proveniêcia:";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(29, 196);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(81, 17);
            this.lblContacto.TabIndex = 6;
            this.lblContacto.Text = "Dimensões:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(47, 172);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(63, 17);
            this.lblEstadoCivil.TabIndex = 5;
            this.lblEstadoCivil.Text = "Posição:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(46, 139);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(64, 17);
            this.lblMaterial.TabIndex = 4;
            this.lblMaterial.Text = "Material:";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(65, 112);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(45, 17);
            this.lblAssunto.TabIndex = 3;
            this.lblAssunto.Text = "Titulo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(63, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Autor:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(14, 61);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(96, 17);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Tipo de Obra:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(48, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.lblFuncionario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 31);
            this.panel1.TabIndex = 6;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Location = new System.Drawing.Point(56, 6);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(234, 20);
            this.lblFuncionario.TabIndex = 1;
            this.lblFuncionario.Text = "Fotografias e Objectos de Arte";
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
            this.btnSai.Location = new System.Drawing.Point(756, 0);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(33, 31);
            this.btnSai.TabIndex = 2;
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnApaga
            // 
            this.btnApaga.Enabled = false;
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApaga.Location = new System.Drawing.Point(531, 411);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(135, 36);
            this.btnApaga.TabIndex = 11;
            this.btnApaga.Text = "Apagar";
            this.btnApaga.UseVisualStyleBackColor = true;
            // 
            // btnEdita
            // 
            this.btnEdita.Enabled = false;
            this.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdita.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEdita.Image = ((System.Drawing.Image)(resources.GetObject("btnEdita.Image")));
            this.btnEdita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdita.Location = new System.Drawing.Point(390, 411);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(135, 36);
            this.btnEdita.TabIndex = 10;
            this.btnEdita.Text = "Editar";
            this.btnEdita.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(249, 411);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(135, 36);
            this.btnSalva.TabIndex = 9;
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
            this.btnNovo.Location = new System.Drawing.Point(108, 411);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(135, 36);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmFotografiasOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFotografiasOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFotografiasOA";
            this.Load += new System.EventHandler(this.frmFotografiasOA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCarregaFoto;
        private System.Windows.Forms.ComboBox cboTipoObra;
        private System.Windows.Forms.ComboBox cboNomeSala;
        private System.Windows.Forms.ComboBox cboPosicao;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.TextBox txtProveniencia;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtDimensões;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblcontacto2;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.TextBox txtCodigoObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label8;

    }
}