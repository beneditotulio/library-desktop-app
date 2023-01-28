namespace SistemaDeGestaoBibliotecaria.Telas
{
    partial class frmMenuAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAjuda));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenuCadastro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSai = new System.Windows.Forms.Button();
            this.btnFotoTerminarSessao = new System.Windows.Forms.Button();
            this.btnTerminaSessao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 1);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMenuCadastro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 30);
            this.panel1.TabIndex = 21;
            // 
            // lblMenuCadastro
            // 
            this.lblMenuCadastro.AutoSize = true;
            this.lblMenuCadastro.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCadastro.Location = new System.Drawing.Point(62, 4);
            this.lblMenuCadastro.Name = "lblMenuCadastro";
            this.lblMenuCadastro.Size = new System.Drawing.Size(107, 22);
            this.lblMenuCadastro.TabIndex = 21;
            this.lblMenuCadastro.Text = "Menu Ajuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 39);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnSai
            // 
            this.btnSai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.btnSai.FlatAppearance.BorderSize = 0;
            this.btnSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSai.Image = ((System.Drawing.Image)(resources.GetObject("btnSai.Image")));
            this.btnSai.Location = new System.Drawing.Point(1074, 0);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(33, 30);
            this.btnSai.TabIndex = 1;
            this.btnSai.UseVisualStyleBackColor = false;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click_1);
            // 
            // btnFotoTerminarSessao
            // 
            this.btnFotoTerminarSessao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFotoTerminarSessao.BackgroundImage")));
            this.btnFotoTerminarSessao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFotoTerminarSessao.FlatAppearance.BorderSize = 0;
            this.btnFotoTerminarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoTerminarSessao.Location = new System.Drawing.Point(47, 41);
            this.btnFotoTerminarSessao.Name = "btnFotoTerminarSessao";
            this.btnFotoTerminarSessao.Size = new System.Drawing.Size(184, 171);
            this.btnFotoTerminarSessao.TabIndex = 23;
            this.btnFotoTerminarSessao.UseVisualStyleBackColor = true;
            // 
            // btnTerminaSessao
            // 
            this.btnTerminaSessao.FlatAppearance.BorderSize = 0;
            this.btnTerminaSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminaSessao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminaSessao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminaSessao.Location = new System.Drawing.Point(57, 218);
            this.btnTerminaSessao.Name = "btnTerminaSessao";
            this.btnTerminaSessao.Size = new System.Drawing.Size(155, 47);
            this.btnTerminaSessao.TabIndex = 24;
            this.btnTerminaSessao.Text = "        &Terminar Sessao";
            this.btnTerminaSessao.UseVisualStyleBackColor = true;
            // 
            // frmMenuAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 602);
            this.Controls.Add(this.btnFotoTerminarSessao);
            this.Controls.Add(this.btnTerminaSessao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuAjuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmMenuAjuda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenuCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.Button btnFotoTerminarSessao;
        private System.Windows.Forms.Button btnTerminaSessao;
    }
}