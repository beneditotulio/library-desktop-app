namespace SistemaDeGestaoBibliotecaria.Listagens
{
    partial class FrmAutor
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegisto = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarRegistoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarCredenciaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactoAlternativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImprimir = new System.Windows.Forms.DataGridView();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(652, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Número de registos:";
            // 
            // lblRegisto
            // 
            this.lblRegisto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisto.AutoSize = true;
            this.lblRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegisto.Location = new System.Drawing.Point(800, 73);
            this.lblRegisto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisto.Name = "lblRegisto";
            this.lblRegisto.Size = new System.Drawing.Size(18, 20);
            this.lblRegisto.TabIndex = 29;
            this.lblRegisto.Text = "0";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(841, 5);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(160, 49);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Selecione o campo: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.alterarRegistoToolStripMenuItem,
            this.adicionarCredenciaisToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 70);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // alterarRegistoToolStripMenuItem
            // 
            this.alterarRegistoToolStripMenuItem.Name = "alterarRegistoToolStripMenuItem";
            this.alterarRegistoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.alterarRegistoToolStripMenuItem.Text = "Alterar Registo";
            // 
            // adicionarCredenciaisToolStripMenuItem
            // 
            this.adicionarCredenciaisToolStripMenuItem.Name = "adicionarCredenciaisToolStripMenuItem";
            this.adicionarCredenciaisToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.adicionarCredenciaisToolStripMenuItem.Text = "Atribuir ao Livro";
            this.adicionarCredenciaisToolStripMenuItem.Click += new System.EventHandler(this.adicionarCredenciaisToolStripMenuItem_Click);
            // 
            // cboCampo
            // 
            this.cboCampo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Items.AddRange(new object[] {
            "Nome",
            "Sexo",
            "Contacto",
            "Email"});
            this.cboCampo.Location = new System.Drawing.Point(8, 71);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(2);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(144, 28);
            this.cboCampo.TabIndex = 26;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPesquisa.Location = new System.Drawing.Point(188, 73);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(415, 26);
            this.txtPesquisa.TabIndex = 25;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Email";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // ContactoAlternativo
            // 
            this.ContactoAlternativo.HeaderText = "ContactoAlternativo";
            this.ContactoAlternativo.Name = "ContactoAlternativo";
            this.ContactoAlternativo.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Contacto";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Morada";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Estado Civil";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Sexo";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Profissao";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "NumeroDoc";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "TipoDoc";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Nome";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // dgvAutor
            // 
            this.dgvAutor.AllowUserToAddRows = false;
            this.dgvAutor.AllowUserToDeleteRows = false;
            this.dgvAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column18,
            this.Column20});
            this.dgvAutor.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAutor.Location = new System.Drawing.Point(0, 106);
            this.dgvAutor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.ReadOnly = true;
            this.dgvAutor.RowHeadersVisible = false;
            this.dgvAutor.RowTemplate.Height = 24;
            this.dgvAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutor.Size = new System.Drawing.Size(1011, 476);
            this.dgvAutor.TabIndex = 24;
            this.dgvAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutor_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sexo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Contacto";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Email";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 200;
            // 
            // dgvImprimir
            // 
            this.dgvImprimir.AllowUserToAddRows = false;
            this.dgvImprimir.AllowUserToDeleteRows = false;
            this.dgvImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImprimir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column7,
            this.Column13,
            this.Column8,
            this.Column14,
            this.Column15,
            this.ContactoAlternativo,
            this.Column16});
            this.dgvImprimir.Location = new System.Drawing.Point(0, 106);
            this.dgvImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.dgvImprimir.Name = "dgvImprimir";
            this.dgvImprimir.ReadOnly = true;
            this.dgvImprimir.RowHeadersVisible = false;
            this.dgvImprimir.Size = new System.Drawing.Size(1011, 370);
            this.dgvImprimir.TabIndex = 31;
            this.dgvImprimir.Visible = false;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(787, 127);
            this.txtAutor.Multiline = true;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(214, 63);
            this.txtAutor.TabIndex = 32;
            // 
            // FrmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 586);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegisto);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvAutor);
            this.Controls.Add(this.dgvImprimir);
            this.Name = "FrmAutor";
            this.Text = "Listagem de Autores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAutor_FormClosed);
            this.Load += new System.EventHandler(this.FrmAutor_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImprimir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegisto;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarRegistoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarCredenciaisToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactoAlternativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView dgvAutor;
        private System.Windows.Forms.DataGridView dgvImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.TextBox txtAutor;
    }
}