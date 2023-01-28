namespace SistemaDeGestaoBibliotecaria.Telas
{
    partial class FrmEmprestimo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmprestimo));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPreohora = new System.Windows.Forms.Label();
            this.GPBdadosFuncionario = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsusario = new System.Windows.Forms.Label();
            this.dtpDataActual = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHoraFim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataActual = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.cboDevolucao = new System.Windows.Forms.ComboBox();
            this.btnLeitor = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.GPBdadosFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(964, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(32, 32);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.AllowUserToAddRows = false;
            this.dgvEmprestimo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvEmprestimo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmprestimo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column5,
            this.DataFim,
            this.Column4});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmprestimo.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmprestimo.GridColor = System.Drawing.Color.Black;
            this.dgvEmprestimo.Location = new System.Drawing.Point(48, 299);
            this.dgvEmprestimo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEmprestimo.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEmprestimo.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEmprestimo.RowTemplate.Height = 24;
            this.dgvEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimo.Size = new System.Drawing.Size(887, 198);
            this.dgvEmprestimo.TabIndex = 74;
            this.dgvEmprestimo.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmprestimo_CellMouseMove);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Leitor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column6
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column6.HeaderText = "Livro";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data Retirada";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data Entrega";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // DataFim
            // 
            this.DataFim.HeaderText = "Data Devolução";
            this.DataFim.Name = "DataFim";
            this.DataFim.ReadOnly = true;
            this.DataFim.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Devolução";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(943, 299);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(32, 32);
            this.btnAdicionar.TabIndex = 81;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPreco.Location = new System.Drawing.Point(135, 224);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(170, 26);
            this.txtPreco.TabIndex = 80;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigo.Location = new System.Drawing.Point(135, 90);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(58, 26);
            this.txtCodigo.TabIndex = 79;
            // 
            // lblPreohora
            // 
            this.lblPreohora.AutoSize = true;
            this.lblPreohora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreohora.Location = new System.Drawing.Point(39, 224);
            this.lblPreohora.Name = "lblPreohora";
            this.lblPreohora.Size = new System.Drawing.Size(96, 20);
            this.lblPreohora.TabIndex = 76;
            this.lblPreohora.Text = "Devolução:";
            // 
            // GPBdadosFuncionario
            // 
            this.GPBdadosFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GPBdadosFuncionario.Controls.Add(this.groupBox1);
            this.GPBdadosFuncionario.Controls.Add(this.txtUsuario);
            this.GPBdadosFuncionario.Controls.Add(this.lblUsusario);
            this.GPBdadosFuncionario.Controls.Add(this.dtpDataActual);
            this.GPBdadosFuncionario.Controls.Add(this.dtpDataFim);
            this.GPBdadosFuncionario.Controls.Add(this.label5);
            this.GPBdadosFuncionario.Controls.Add(this.dtpHoraFim);
            this.GPBdadosFuncionario.Controls.Add(this.label4);
            this.GPBdadosFuncionario.Controls.Add(this.dtpDataInicio);
            this.GPBdadosFuncionario.Controls.Add(this.dtpHoraInicio);
            this.GPBdadosFuncionario.Controls.Add(this.lblDataActual);
            this.GPBdadosFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBdadosFuncionario.Location = new System.Drawing.Point(493, 12);
            this.GPBdadosFuncionario.Name = "GPBdadosFuncionario";
            this.GPBdadosFuncionario.Size = new System.Drawing.Size(438, 245);
            this.GPBdadosFuncionario.TabIndex = 75;
            this.GPBdadosFuncionario.TabStop = false;
            this.GPBdadosFuncionario.Text = "Funcionario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Location = new System.Drawing.Point(8, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(180, 154);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(8, 206);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 26);
            this.txtUsuario.TabIndex = 52;
            // 
            // lblUsusario
            // 
            this.lblUsusario.AutoSize = true;
            this.lblUsusario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsusario.Location = new System.Drawing.Point(10, 26);
            this.lblUsusario.Name = "lblUsusario";
            this.lblUsusario.Size = new System.Drawing.Size(98, 20);
            this.lblUsusario.TabIndex = 43;
            this.lblUsusario.Text = "Funcionario:";
            // 
            // dtpDataActual
            // 
            this.dtpDataActual.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtpDataActual.Enabled = false;
            this.dtpDataActual.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataActual.Location = new System.Drawing.Point(210, 73);
            this.dtpDataActual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataActual.Name = "dtpDataActual";
            this.dtpDataActual.Size = new System.Drawing.Size(223, 21);
            this.dtpDataActual.TabIndex = 54;
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpDataFim.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFim.Location = new System.Drawing.Point(210, 177);
            this.dtpDataFim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(223, 21);
            this.dtpDataFim.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Data Entrega:";
            // 
            // dtpHoraFim
            // 
            this.dtpHoraFim.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFim.Location = new System.Drawing.Point(342, 151);
            this.dtpHoraFim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHoraFim.Name = "dtpHoraFim";
            this.dtpHoraFim.ShowUpDown = true;
            this.dtpHoraFim.Size = new System.Drawing.Size(91, 21);
            this.dtpHoraFim.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Data Devolução:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicio.Location = new System.Drawing.Point(210, 125);
            this.dtpDataInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(223, 21);
            this.dtpDataInicio.TabIndex = 56;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(342, 99);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(91, 21);
            this.dtpHoraInicio.TabIndex = 70;
            // 
            // lblDataActual
            // 
            this.lblDataActual.AutoSize = true;
            this.lblDataActual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataActual.Location = new System.Drawing.Point(212, 53);
            this.lblDataActual.Name = "lblDataActual";
            this.lblDataActual.Size = new System.Drawing.Size(104, 17);
            this.lblDataActual.TabIndex = 63;
            this.lblDataActual.Text = "Data Retirada:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(87, 170);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(48, 20);
            this.lblMatricula.TabIndex = 77;
            this.lblMatricula.Text = "Livro:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(82, 119);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 20);
            this.lblCliente.TabIndex = 78;
            this.lblCliente.Text = "Leitor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Codigo:";
            // 
            // btnApaga
            // 
            this.btnApaga.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApaga.Location = new System.Drawing.Point(634, 509);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(135, 36);
            this.btnApaga.TabIndex = 87;
            this.btnApaga.Text = "Apagar";
            this.btnApaga.UseVisualStyleBackColor = true;
            // 
            // btnEdita
            // 
            this.btnEdita.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdita.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEdita.Image = ((System.Drawing.Image)(resources.GetObject("btnEdita.Image")));
            this.btnEdita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdita.Location = new System.Drawing.Point(493, 509);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(135, 36);
            this.btnEdita.TabIndex = 86;
            this.btnEdita.Text = "Editar";
            this.btnEdita.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(352, 509);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(135, 36);
            this.btnSalva.TabIndex = 85;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(211, 509);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(135, 36);
            this.btnNovo.TabIndex = 84;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtLeitor
            // 
            this.txtLeitor.Enabled = false;
            this.txtLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLeitor.Location = new System.Drawing.Point(135, 120);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(290, 26);
            this.txtLeitor.TabIndex = 88;
            // 
            // txtLivro
            // 
            this.txtLivro.Enabled = false;
            this.txtLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLivro.Location = new System.Drawing.Point(135, 150);
            this.txtLivro.Multiline = true;
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(290, 63);
            this.txtLivro.TabIndex = 89;
            // 
            // cboDevolucao
            // 
            this.cboDevolucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDevolucao.FormattingEnabled = true;
            this.cboDevolucao.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cboDevolucao.Location = new System.Drawing.Point(135, 220);
            this.cboDevolucao.Name = "cboDevolucao";
            this.cboDevolucao.Size = new System.Drawing.Size(121, 28);
            this.cboDevolucao.TabIndex = 90;
            // 
            // btnLeitor
            // 
            this.btnLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeitor.Location = new System.Drawing.Point(431, 120);
            this.btnLeitor.Name = "btnLeitor";
            this.btnLeitor.Size = new System.Drawing.Size(32, 25);
            this.btnLeitor.TabIndex = 91;
            this.btnLeitor.Text = "...";
            this.btnLeitor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLeitor.UseVisualStyleBackColor = true;
            this.btnLeitor.Click += new System.EventHandler(this.btnLeitor_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.ForeColor = System.Drawing.Color.Red;
            this.btnLivro.Location = new System.Drawing.Point(431, 152);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(32, 24);
            this.btnLivro.TabIndex = 92;
            this.btnLivro.Text = "...";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1011, 561);
            this.Controls.Add(this.btnLivro);
            this.Controls.Add(this.btnLeitor);
            this.Controls.Add(this.cboDevolucao);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvEmprestimo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPreohora);
            this.Controls.Add(this.GPBdadosFuncionario);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCliente);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "FrmEmprestimo";
            this.Text = "Emprestimo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEmprestimo_Load);
            this.MouseHover += new System.EventHandler(this.FrmEmprestimo_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmEmprestimo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.GPBdadosFuncionario.ResumeLayout(false);
            this.GPBdadosFuncionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPreohora;
        private System.Windows.Forms.GroupBox GPBdadosFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsusario;
        private System.Windows.Forms.DateTimePicker dtpDataActual;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHoraFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblDataActual;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.ComboBox cboDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnLeitor;
        private System.Windows.Forms.Button btnLivro;
    }
}