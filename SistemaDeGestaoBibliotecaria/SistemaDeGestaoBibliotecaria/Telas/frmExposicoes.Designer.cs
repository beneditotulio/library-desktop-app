namespace SistemaDeGestaoBibliotecaria.Telas
{
    partial class frmExposicoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExposicoes));
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregaFoto = new System.Windows.Forms.Button();
            this.gpbImagem = new System.Windows.Forms.GroupBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.cboMuseu = new System.Windows.Forms.ComboBox();
            this.txtProveniencia = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblcontacto2 = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObjecto = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSai = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Location = new System.Drawing.Point(56, 6);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(100, 20);
            this.lblFuncionario.TabIndex = 1;
            this.lblFuncionario.Text = "EXPOSIÇÕES";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(679, 28);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(101, 23);
            this.txtTotal.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total:";
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
            this.btnCarregaFoto.Click += new System.EventHandler(this.btnCarregaFoto_Click);
            // 
            // gpbImagem
            // 
            this.gpbImagem.Controls.Add(this.pbImagem);
            this.gpbImagem.Location = new System.Drawing.Point(629, 54);
            this.gpbImagem.Name = "gpbImagem";
            this.gpbImagem.Size = new System.Drawing.Size(151, 158);
            this.gpbImagem.TabIndex = 30;
            this.gpbImagem.TabStop = false;
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(0, 7);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(151, 158);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 34;
            this.pbImagem.TabStop = false;
            // 
            // cboMuseu
            // 
            this.cboMuseu.FormattingEnabled = true;
            this.cboMuseu.Items.AddRange(new object[] {
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
            this.cboMuseu.Location = new System.Drawing.Point(113, 170);
            this.cboMuseu.Name = "cboMuseu";
            this.cboMuseu.Size = new System.Drawing.Size(201, 25);
            this.cboMuseu.TabIndex = 25;
            // 
            // txtProveniencia
            // 
            this.txtProveniencia.Location = new System.Drawing.Point(113, 279);
            this.txtProveniencia.Name = "txtProveniencia";
            this.txtProveniencia.Size = new System.Drawing.Size(201, 23);
            this.txtProveniencia.TabIndex = 22;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(113, 112);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(201, 55);
            this.txtDescricao.TabIndex = 20;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtMorada_TextChanged);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(113, 252);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(201, 23);
            this.txtData.TabIndex = 14;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 23);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(34, 127);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(76, 17);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(113, 198);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(201, 51);
            this.txtObservacao.TabIndex = 13;
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(58, 173);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(52, 17);
            this.lblProfissao.TabIndex = 8;
            this.lblProfissao.Text = "Museu:";
            // 
            // lblcontacto2
            // 
            this.lblcontacto2.AutoSize = true;
            this.lblcontacto2.Location = new System.Drawing.Point(63, 282);
            this.lblcontacto2.Name = "lblcontacto2";
            this.lblcontacto2.Size = new System.Drawing.Size(47, 17);
            this.lblcontacto2.TabIndex = 7;
            this.lblcontacto2.Text = "Tema:";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(64, 255);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(45, 17);
            this.lblAssunto.TabIndex = 3;
            this.lblAssunto.Text = "Data:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(44, 71);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(65, 17);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Objecto:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtObjecto);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCarregaFoto);
            this.groupBox1.Controls.Add(this.gpbImagem);
            this.groupBox1.Controls.Add(this.cboMuseu);
            this.groupBox1.Controls.Add(this.txtProveniencia);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.lblProfissao);
            this.groupBox1.Controls.Add(this.lblcontacto2);
            this.groupBox1.Controls.Add(this.lblAssunto);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 313);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txtObjecto
            // 
            this.txtObjecto.Location = new System.Drawing.Point(113, 55);
            this.txtObjecto.Multiline = true;
            this.txtObjecto.Name = "txtObjecto";
            this.txtObjecto.Size = new System.Drawing.Size(134, 55);
            this.txtObjecto.TabIndex = 34;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 213);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(92, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Observação:";
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
            this.panel1.Size = new System.Drawing.Size(848, 31);
            this.panel1.TabIndex = 12;
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
            this.btnSai.Location = new System.Drawing.Point(815, 0);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(33, 31);
            this.btnSai.TabIndex = 2;
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApaga.Location = new System.Drawing.Point(531, 384);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(135, 36);
            this.btnApaga.TabIndex = 17;
            this.btnApaga.Text = "Apagar";
            this.btnApaga.UseVisualStyleBackColor = true;
            // 
            // btnEdita
            // 
            this.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdita.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEdita.Image = ((System.Drawing.Image)(resources.GetObject("btnEdita.Image")));
            this.btnEdita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdita.Location = new System.Drawing.Point(390, 384);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(135, 36);
            this.btnEdita.TabIndex = 16;
            this.btnEdita.Text = "Editar";
            this.btnEdita.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(249, 384);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(135, 36);
            this.btnSalva.TabIndex = 15;
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
            this.btnNovo.Location = new System.Drawing.Point(108, 384);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(135, 36);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // txtNr
            // 
            this.txtNr.Location = new System.Drawing.Point(275, 55);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(39, 23);
            this.txtNr.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nr:";
            // 
            // frmExposicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 429);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExposicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExposicoes";
            this.gpbImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregaFoto;
        private System.Windows.Forms.GroupBox gpbImagem;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.ComboBox cboMuseu;
        private System.Windows.Forms.TextBox txtProveniencia;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblcontacto2;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObjecto;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.Label label2;
    }
}