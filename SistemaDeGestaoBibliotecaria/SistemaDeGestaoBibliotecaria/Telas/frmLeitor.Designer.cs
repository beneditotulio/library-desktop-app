namespace SistemaDeGestaoBibliotecaria.Telas
{
    partial class frmLeitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeitor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSai = new System.Windows.Forms.Button();
            this.gpbLeitor = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContacto2 = new System.Windows.Forms.TextBox();
            this.txtContacto1 = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigoLeitor = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContacto2 = new System.Windows.Forms.Label();
            this.lblContacto1 = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbLeitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.lblLeitor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 31);
            this.panel1.TabIndex = 3;
            // 
            // lblLeitor
            // 
            this.lblLeitor.AutoSize = true;
            this.lblLeitor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeitor.ForeColor = System.Drawing.Color.White;
            this.lblLeitor.Location = new System.Drawing.Point(48, 6);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(49, 20);
            this.lblLeitor.TabIndex = 1;
            this.lblLeitor.Text = "Leitor";
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
            this.btnSai.Location = new System.Drawing.Point(701, 0);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(33, 31);
            this.btnSai.TabIndex = 2;
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // gpbLeitor
            // 
            this.gpbLeitor.Controls.Add(this.button1);
            this.gpbLeitor.Controls.Add(this.txtEmail);
            this.gpbLeitor.Controls.Add(this.txtContacto2);
            this.gpbLeitor.Controls.Add(this.txtContacto1);
            this.gpbLeitor.Controls.Add(this.txtMorada);
            this.gpbLeitor.Controls.Add(this.cboSexo);
            this.gpbLeitor.Controls.Add(this.txtNumeroDoc);
            this.gpbLeitor.Controls.Add(this.cboTipoDoc);
            this.gpbLeitor.Controls.Add(this.txtNome);
            this.gpbLeitor.Controls.Add(this.txtCodigoLeitor);
            this.gpbLeitor.Controls.Add(this.textBox1);
            this.gpbLeitor.Controls.Add(this.lblEmail);
            this.gpbLeitor.Controls.Add(this.lblContacto2);
            this.gpbLeitor.Controls.Add(this.lblContacto1);
            this.gpbLeitor.Controls.Add(this.lblMorada);
            this.gpbLeitor.Controls.Add(this.lblSexo);
            this.gpbLeitor.Controls.Add(this.lblNumeroDoc);
            this.gpbLeitor.Controls.Add(this.lblTipoDoc);
            this.gpbLeitor.Controls.Add(this.lblNome);
            this.gpbLeitor.Controls.Add(this.label2);
            this.gpbLeitor.Controls.Add(this.lblCodigo);
            this.gpbLeitor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLeitor.Location = new System.Drawing.Point(12, 49);
            this.gpbLeitor.Name = "gpbLeitor";
            this.gpbLeitor.Size = new System.Drawing.Size(709, 288);
            this.gpbLeitor.TabIndex = 4;
            this.gpbLeitor.TabStop = false;
            this.gpbLeitor.Text = "Leitor:";
            this.gpbLeitor.Enter += new System.EventHandler(this.gpbLeitor_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(327, 23);
            this.txtEmail.TabIndex = 19;
            // 
            // txtContacto2
            // 
            this.txtContacto2.Location = new System.Drawing.Point(131, 220);
            this.txtContacto2.Name = "txtContacto2";
            this.txtContacto2.Size = new System.Drawing.Size(208, 23);
            this.txtContacto2.TabIndex = 18;
            // 
            // txtContacto1
            // 
            this.txtContacto1.Location = new System.Drawing.Point(131, 194);
            this.txtContacto1.Name = "txtContacto1";
            this.txtContacto1.Size = new System.Drawing.Size(208, 23);
            this.txtContacto1.TabIndex = 17;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(131, 168);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(327, 23);
            this.txtMorada.TabIndex = 16;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.cboSexo.Location = new System.Drawing.Point(131, 139);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(208, 25);
            this.cboSexo.TabIndex = 15;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(464, 111);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(182, 23);
            this.txtNumeroDoc.TabIndex = 14;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "BI",
            "NUIT",
            "DIR",
            "PASSAPORTE"});
            this.cboTipoDoc.Location = new System.Drawing.Point(131, 110);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(229, 25);
            this.cboTipoDoc.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 23);
            this.txtNome.TabIndex = 12;
            // 
            // txtCodigoLeitor
            // 
            this.txtCodigoLeitor.Enabled = false;
            this.txtCodigoLeitor.Location = new System.Drawing.Point(131, 58);
            this.txtCodigoLeitor.Name = "txtCodigoLeitor";
            this.txtCodigoLeitor.Size = new System.Drawing.Size(89, 23);
            this.txtCodigoLeitor.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(131, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(81, 249);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblContacto2
            // 
            this.lblContacto2.AutoSize = true;
            this.lblContacto2.Location = new System.Drawing.Point(41, 223);
            this.lblContacto2.Name = "lblContacto2";
            this.lblContacto2.Size = new System.Drawing.Size(87, 17);
            this.lblContacto2.TabIndex = 8;
            this.lblContacto2.Text = "Contacto 2:";
            // 
            // lblContacto1
            // 
            this.lblContacto1.AutoSize = true;
            this.lblContacto1.Location = new System.Drawing.Point(41, 196);
            this.lblContacto1.Name = "lblContacto1";
            this.lblContacto1.Size = new System.Drawing.Size(87, 17);
            this.lblContacto1.TabIndex = 7;
            this.lblContacto1.Text = "Contacto 1:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(65, 170);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(63, 17);
            this.lblMorada.TabIndex = 6;
            this.lblMorada.Text = "Morada:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(87, 142);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 17);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Location = new System.Drawing.Point(363, 114);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(95, 17);
            this.lblNumeroDoc.TabIndex = 4;
            this.lblNumeroDoc.Text = "Numero Doc:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(59, 114);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(69, 17);
            this.lblTipoDoc.TabIndex = 3;
            this.lblTipoDoc.Text = "Tipo Doc:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(76, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Leitor:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(66, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            this.lblCodigo.Visible = false;
            // 
            // btnApaga
            // 
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApaga.Location = new System.Drawing.Point(498, 352);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(135, 36);
            this.btnApaga.TabIndex = 17;
            this.btnApaga.Text = "Apagar";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // btnEdita
            // 
            this.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdita.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEdita.Image = ((System.Drawing.Image)(resources.GetObject("btnEdita.Image")));
            this.btnEdita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdita.Location = new System.Drawing.Point(357, 352);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(135, 36);
            this.btnEdita.TabIndex = 16;
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
            this.btnSalva.Location = new System.Drawing.Point(216, 352);
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
            this.btnNovo.Location = new System.Drawing.Point(75, 352);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(135, 36);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbLeitor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLeitor";
            this.Load += new System.EventHandler(this.frmLeitor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbLeitor.ResumeLayout(false);
            this.gpbLeitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.GroupBox gpbLeitor;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContacto2;
        private System.Windows.Forms.TextBox txtContacto1;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigoLeitor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContacto2;
        private System.Windows.Forms.Label lblContacto1;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button button1;
    }
}