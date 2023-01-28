namespace SistemaDeGestaoBibliotecaria.Telas
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCarregaFoto = new System.Windows.Forms.Button();
            this.gpbImagem = new System.Windows.Forms.GroupBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProfissao = new System.Windows.Forms.ComboBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtContacto2 = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContacto1 = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblcontacto2 = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(829, 31);
            this.panel1.TabIndex = 0;
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
            this.btnSai.Location = new System.Drawing.Point(796, 0);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(33, 31);
            this.btnSai.TabIndex = 2;
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCarregaFoto);
            this.groupBox1.Controls.Add(this.gpbImagem);
            this.groupBox1.Controls.Add(this.cboTipoDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboProfissao);
            this.groupBox1.Controls.Add(this.cboEstadoCivil);
            this.groupBox1.Controls.Add(this.cboSexo);
            this.groupBox1.Controls.Add(this.txtContacto2);
            this.groupBox1.Controls.Add(this.txtMorada);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtContacto1);
            this.groupBox1.Controls.Add(this.txtApelido);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtNumeroDoc);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblMorada);
            this.groupBox1.Controls.Add(this.lblProfissao);
            this.groupBox1.Controls.Add(this.lblcontacto2);
            this.groupBox1.Controls.Add(this.lblContacto);
            this.groupBox1.Controls.Add(this.lblEstadoCivil);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.lblApelido);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 336);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do funcionario";
            // 
            // btnCarregaFoto
            // 
            this.btnCarregaFoto.FlatAppearance.BorderSize = 0;
            this.btnCarregaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregaFoto.Location = new System.Drawing.Point(629, 213);
            this.btnCarregaFoto.Name = "btnCarregaFoto";
            this.btnCarregaFoto.Size = new System.Drawing.Size(151, 36);
            this.btnCarregaFoto.TabIndex = 31;
            this.btnCarregaFoto.Text = "Carregar Foto";
            this.btnCarregaFoto.UseVisualStyleBackColor = true;
            // 
            // gpbImagem
            // 
            this.gpbImagem.Location = new System.Drawing.Point(629, 54);
            this.gpbImagem.Name = "gpbImagem";
            this.gpbImagem.Size = new System.Drawing.Size(151, 158);
            this.gpbImagem.TabIndex = 30;
            this.gpbImagem.TabStop = false;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "BI",
            "NUIT",
            "DIR",
            "PASSAPORTE"});
            this.cboTipoDoc.Location = new System.Drawing.Point(113, 54);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(201, 25);
            this.cboTipoDoc.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Numero Doc:";
            // 
            // cboProfissao
            // 
            this.cboProfissao.Enabled = false;
            this.cboProfissao.FormattingEnabled = true;
            this.cboProfissao.Location = new System.Drawing.Point(113, 247);
            this.cboProfissao.Name = "cboProfissao";
            this.cboProfissao.Size = new System.Drawing.Size(201, 25);
            this.cboProfissao.TabIndex = 25;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.Enabled = false;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(113, 164);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(201, 25);
            this.cboEstadoCivil.TabIndex = 24;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.cboSexo.Location = new System.Drawing.Point(113, 136);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(201, 25);
            this.cboSexo.TabIndex = 23;
            // 
            // txtContacto2
            // 
            this.txtContacto2.Location = new System.Drawing.Point(113, 220);
            this.txtContacto2.Name = "txtContacto2";
            this.txtContacto2.Size = new System.Drawing.Size(186, 23);
            this.txtContacto2.TabIndex = 22;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(113, 275);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(307, 23);
            this.txtMorada.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 23);
            this.txtEmail.TabIndex = 19;
            // 
            // txtContacto1
            // 
            this.txtContacto1.Location = new System.Drawing.Point(113, 193);
            this.txtContacto1.Name = "txtContacto1";
            this.txtContacto1.Size = new System.Drawing.Size(186, 23);
            this.txtContacto1.TabIndex = 16;
            // 
            // txtApelido
            // 
            this.txtApelido.Enabled = false;
            this.txtApelido.Location = new System.Drawing.Point(113, 109);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(201, 23);
            this.txtApelido.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 23);
            this.txtNome.TabIndex = 13;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(419, 55);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(166, 23);
            this.txtNumeroDoc.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 23);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(63, 305);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(47, 278);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(63, 17);
            this.lblMorada.TabIndex = 9;
            this.lblMorada.Text = "Morada:";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(42, 251);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(68, 17);
            this.lblProfissao.TabIndex = 8;
            this.lblProfissao.Text = "Profissão:";
            // 
            // lblcontacto2
            // 
            this.lblcontacto2.AutoSize = true;
            this.lblcontacto2.Location = new System.Drawing.Point(23, 223);
            this.lblcontacto2.Name = "lblcontacto2";
            this.lblcontacto2.Size = new System.Drawing.Size(87, 17);
            this.lblcontacto2.TabIndex = 7;
            this.lblcontacto2.Text = "Contacto 2:";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(23, 196);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(87, 17);
            this.lblContacto.TabIndex = 6;
            this.lblContacto.Text = "Contacto 1:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(22, 168);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(88, 17);
            this.lblEstadoCivil.TabIndex = 5;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(69, 140);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 17);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(48, 112);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(62, 17);
            this.lblApelido.TabIndex = 3;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(58, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(41, 57);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(69, 17);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Tipo Doc:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(48, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(108, 407);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(135, 36);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(249, 407);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(135, 36);
            this.btnSalva.TabIndex = 3;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnEdita
            // 
            this.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdita.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEdita.Image = ((System.Drawing.Image)(resources.GetObject("btnEdita.Image")));
            this.btnEdita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdita.Location = new System.Drawing.Point(390, 407);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(135, 36);
            this.btnEdita.TabIndex = 4;
            this.btnEdita.Text = "Editar";
            this.btnEdita.UseVisualStyleBackColor = true;
            // 
            // btnApaga
            // 
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApaga.Location = new System.Drawing.Point(531, 407);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(135, 36);
            this.btnApaga.TabIndex = 5;
            this.btnApaga.Text = "Apagar";
            this.btnApaga.UseVisualStyleBackColor = true;
            // 
            // frmFotografiasOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 462);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFotografiasOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblcontacto2;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProfissao;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtContacto2;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContacto1;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnCarregaFoto;
        private System.Windows.Forms.GroupBox gpbImagem;
    }
}