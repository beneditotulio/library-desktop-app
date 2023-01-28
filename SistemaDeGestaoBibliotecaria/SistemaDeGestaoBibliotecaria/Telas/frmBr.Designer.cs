namespace SistemaDeGestaoBibliotecaria.Telas
{
    partial class frmBr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSai = new System.Windows.Forms.Button();
            this.txtNrBR = new System.Windows.Forms.TextBox();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblcontacto2 = new System.Windows.Forms.Label();
            this.btnCarregaFoto = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAssunto = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(679, 31);
            this.panel1.TabIndex = 18;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Location = new System.Drawing.Point(56, 6);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(182, 20);
            this.lblFuncionario.TabIndex = 1;
            this.lblFuncionario.Text = "BOLETIM DA REPÚBLICA";
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
            this.btnSai.Location = new System.Drawing.Point(646, 0);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(33, 31);
            this.btnSai.TabIndex = 2;
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // txtNrBR
            // 
            this.txtNrBR.Location = new System.Drawing.Point(113, 55);
            this.txtNrBR.Multiline = true;
            this.txtNrBR.Name = "txtNrBR";
            this.txtNrBR.Size = new System.Drawing.Size(134, 23);
            this.txtNrBR.TabIndex = 34;
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(72, 142);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(38, 17);
            this.lblProfissao.TabIndex = 8;
            this.lblProfissao.Text = "Tipo:";
            // 
            // lblcontacto2
            // 
            this.lblcontacto2.AutoSize = true;
            this.lblcontacto2.Location = new System.Drawing.Point(34, 216);
            this.lblcontacto2.Name = "lblcontacto2";
            this.lblcontacto2.Size = new System.Drawing.Size(76, 17);
            this.lblcontacto2.TabIndex = 7;
            this.lblcontacto2.Text = "Descricao:";
            // 
            // btnCarregaFoto
            // 
            this.btnCarregaFoto.FlatAppearance.BorderSize = 0;
            this.btnCarregaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregaFoto.Location = new System.Drawing.Point(497, 22);
            this.btnCarregaFoto.Name = "btnCarregaFoto";
            this.btnCarregaFoto.Size = new System.Drawing.Size(151, 36);
            this.btnCarregaFoto.TabIndex = 31;
            this.btnCarregaFoto.Text = "Carregar";
            this.btnCarregaFoto.UseVisualStyleBackColor = true;
            this.btnCarregaFoto.Click += new System.EventHandler(this.btnCarregaFoto_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Lei",
            "Decreto Presidencial",
            "Decreto",
            "Diploma Ministerial"});
            this.cboTipo.Location = new System.Drawing.Point(113, 138);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(201, 25);
            this.cboTipo.TabIndex = 25;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(113, 200);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(201, 50);
            this.txtDescricao.TabIndex = 22;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(113, 82);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(201, 23);
            this.txtSerie.TabIndex = 20;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(113, 110);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(201, 23);
            this.txtData.TabIndex = 14;
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
            this.lblDescricao.Location = new System.Drawing.Point(69, 85);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(41, 17);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Serie:";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(65, 113);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(45, 17);
            this.lblAssunto.TabIndex = 3;
            this.lblAssunto.Text = "Data:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboAssunto);
            this.groupBox1.Controls.Add(this.txtNrBR);
            this.groupBox1.Controls.Add(this.btnCarregaFoto);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.lblProfissao);
            this.groupBox1.Controls.Add(this.lblcontacto2);
            this.groupBox1.Controls.Add(this.lblAssunto);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 260);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboAssunto
            // 
            this.cboAssunto.FormattingEnabled = true;
            this.cboAssunto.Items.AddRange(new object[] {
            "Exoneração",
            "Nomeação",
            "Estatuto Orgânico",
            "Regulamento",
            "Revisão",
            "Sociedades",
            "Outros"});
            this.cboAssunto.Location = new System.Drawing.Point(113, 169);
            this.cboAssunto.Name = "cboAssunto";
            this.cboAssunto.Size = new System.Drawing.Size(201, 25);
            this.cboAssunto.TabIndex = 37;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(49, 173);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Assunto:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(65, 58);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(45, 17);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Nr BR:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(48, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
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
            this.btnApaga.Location = new System.Drawing.Point(486, 331);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(135, 36);
            this.btnApaga.TabIndex = 23;
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
            this.btnEdita.Location = new System.Drawing.Point(345, 331);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(135, 36);
            this.btnEdita.TabIndex = 22;
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
            this.btnSalva.Location = new System.Drawing.Point(204, 331);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(135, 36);
            this.btnSalva.TabIndex = 21;
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
            this.btnNovo.Location = new System.Drawing.Point(63, 331);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(135, 36);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmBr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBr";
            this.Load += new System.EventHandler(this.frmBr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtNrBR;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblcontacto2;
        private System.Windows.Forms.Button btnCarregaFoto;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cboAssunto;
    }
}