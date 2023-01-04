namespace Heroes
{
    partial class ConsultaPelicula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownHastaAnno = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDesdeAnno = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelUniverso = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUniverso = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelMonto = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownHastaMonto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownDesdeMonto = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanelPersonajes = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxPersonajes = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.dataGridViewPeliculas = new System.Windows.Forms.DataGridView();
            this.NombrePelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoresPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnnoPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoRecaudadoPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniversoPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonajesPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenPelicula = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.tableLayoutPanelFiltros.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHastaAnno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesdeAnno)).BeginInit();
            this.tableLayoutPanelUniverso.SuspendLayout();
            this.tableLayoutPanelMonto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHastaMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesdeMonto)).BeginInit();
            this.tableLayoutPanelPersonajes.SuspendLayout();
            this.tableLayoutPanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeliculas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.Font = new System.Drawing.Font("Stencil", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(65, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(784, 76);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Consulta de Películas";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.AutoSize = true;
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.MaximumSize = new System.Drawing.Size(0, 200);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(911, 76);
            this.panelTitulo.TabIndex = 1;
            // 
            // tableLayoutPanelFiltros
            // 
            this.tableLayoutPanelFiltros.ColumnCount = 4;
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelFiltros.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelFiltros.Controls.Add(this.tableLayoutPanelUniverso, 1, 0);
            this.tableLayoutPanelFiltros.Controls.Add(this.tableLayoutPanelMonto, 2, 0);
            this.tableLayoutPanelFiltros.Controls.Add(this.tableLayoutPanelPersonajes, 3, 0);
            this.tableLayoutPanelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFiltros.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanelFiltros.Name = "tableLayoutPanelFiltros";
            this.tableLayoutPanelFiltros.RowCount = 1;
            this.tableLayoutPanelFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFiltros.Size = new System.Drawing.Size(911, 150);
            this.tableLayoutPanelFiltros.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHastaAnno, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownDesdeAnno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numericUpDownHastaAnno
            // 
            this.numericUpDownHastaAnno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.numericUpDownHastaAnno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownHastaAnno.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHastaAnno.Location = new System.Drawing.Point(3, 111);
            this.numericUpDownHastaAnno.Maximum = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            this.numericUpDownHastaAnno.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDownHastaAnno.Name = "numericUpDownHastaAnno";
            this.numericUpDownHastaAnno.Size = new System.Drawing.Size(215, 31);
            this.numericUpDownHastaAnno.TabIndex = 3;
            this.numericUpDownHastaAnno.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde el Año:";
            // 
            // numericUpDownDesdeAnno
            // 
            this.numericUpDownDesdeAnno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.numericUpDownDesdeAnno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownDesdeAnno.ForeColor = System.Drawing.Color.White;
            this.numericUpDownDesdeAnno.Location = new System.Drawing.Point(3, 39);
            this.numericUpDownDesdeAnno.Maximum = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            this.numericUpDownDesdeAnno.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDownDesdeAnno.Name = "numericUpDownDesdeAnno";
            this.numericUpDownDesdeAnno.Size = new System.Drawing.Size(215, 31);
            this.numericUpDownDesdeAnno.TabIndex = 1;
            this.numericUpDownDesdeAnno.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta el Año";
            // 
            // tableLayoutPanelUniverso
            // 
            this.tableLayoutPanelUniverso.ColumnCount = 1;
            this.tableLayoutPanelUniverso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUniverso.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanelUniverso.Controls.Add(this.comboBoxUniverso, 0, 1);
            this.tableLayoutPanelUniverso.Location = new System.Drawing.Point(230, 3);
            this.tableLayoutPanelUniverso.Name = "tableLayoutPanelUniverso";
            this.tableLayoutPanelUniverso.RowCount = 2;
            this.tableLayoutPanelUniverso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanelUniverso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanelUniverso.Size = new System.Drawing.Size(221, 144);
            this.tableLayoutPanelUniverso.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Universo";
            // 
            // comboBoxUniverso
            // 
            this.comboBoxUniverso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comboBoxUniverso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUniverso.ForeColor = System.Drawing.Color.White;
            this.comboBoxUniverso.FormattingEnabled = true;
            this.comboBoxUniverso.Location = new System.Drawing.Point(3, 44);
            this.comboBoxUniverso.Name = "comboBoxUniverso";
            this.comboBoxUniverso.Size = new System.Drawing.Size(215, 33);
            this.comboBoxUniverso.TabIndex = 1;
            this.comboBoxUniverso.SelectedIndexChanged += new System.EventHandler(this.cambiarUniversoFiltro);
            // 
            // tableLayoutPanelMonto
            // 
            this.tableLayoutPanelMonto.ColumnCount = 1;
            this.tableLayoutPanelMonto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMonto.Controls.Add(this.numericUpDownHastaMonto, 0, 3);
            this.tableLayoutPanelMonto.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanelMonto.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanelMonto.Controls.Add(this.numericUpDownDesdeMonto, 0, 1);
            this.tableLayoutPanelMonto.Location = new System.Drawing.Point(457, 3);
            this.tableLayoutPanelMonto.Name = "tableLayoutPanelMonto";
            this.tableLayoutPanelMonto.RowCount = 4;
            this.tableLayoutPanelMonto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMonto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMonto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMonto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMonto.Size = new System.Drawing.Size(221, 144);
            this.tableLayoutPanelMonto.TabIndex = 2;
            // 
            // numericUpDownHastaMonto
            // 
            this.numericUpDownHastaMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.numericUpDownHastaMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownHastaMonto.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHastaMonto.Location = new System.Drawing.Point(3, 111);
            this.numericUpDownHastaMonto.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.numericUpDownHastaMonto.Name = "numericUpDownHastaMonto";
            this.numericUpDownHastaMonto.Size = new System.Drawing.Size(215, 31);
            this.numericUpDownHastaMonto.TabIndex = 4;
            this.numericUpDownHastaMonto.Value = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hasta Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Desde Monto:";
            // 
            // numericUpDownDesdeMonto
            // 
            this.numericUpDownDesdeMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.numericUpDownDesdeMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownDesdeMonto.ForeColor = System.Drawing.Color.White;
            this.numericUpDownDesdeMonto.Location = new System.Drawing.Point(3, 39);
            this.numericUpDownDesdeMonto.Name = "numericUpDownDesdeMonto";
            this.numericUpDownDesdeMonto.Size = new System.Drawing.Size(215, 31);
            this.numericUpDownDesdeMonto.TabIndex = 2;
            // 
            // tableLayoutPanelPersonajes
            // 
            this.tableLayoutPanelPersonajes.ColumnCount = 1;
            this.tableLayoutPanelPersonajes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPersonajes.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanelPersonajes.Controls.Add(this.checkedListBoxPersonajes, 0, 1);
            this.tableLayoutPanelPersonajes.Location = new System.Drawing.Point(684, 3);
            this.tableLayoutPanelPersonajes.Name = "tableLayoutPanelPersonajes";
            this.tableLayoutPanelPersonajes.RowCount = 2;
            this.tableLayoutPanelPersonajes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanelPersonajes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanelPersonajes.Size = new System.Drawing.Size(224, 144);
            this.tableLayoutPanelPersonajes.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Personajes";
            // 
            // checkedListBoxPersonajes
            // 
            this.checkedListBoxPersonajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkedListBoxPersonajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxPersonajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxPersonajes.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxPersonajes.FormattingEnabled = true;
            this.checkedListBoxPersonajes.Location = new System.Drawing.Point(3, 44);
            this.checkedListBoxPersonajes.Name = "checkedListBoxPersonajes";
            this.checkedListBoxPersonajes.Size = new System.Drawing.Size(218, 97);
            this.checkedListBoxPersonajes.TabIndex = 1;
            // 
            // tableLayoutPanelBotones
            // 
            this.tableLayoutPanelBotones.ColumnCount = 2;
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotones.Controls.Add(this.buttonReiniciar, 1, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.buttonFiltrar, 0, 0);
            this.tableLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelBotones.Location = new System.Drawing.Point(0, 226);
            this.tableLayoutPanelBotones.Name = "tableLayoutPanelBotones";
            this.tableLayoutPanelBotones.RowCount = 1;
            this.tableLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotones.Size = new System.Drawing.Size(911, 48);
            this.tableLayoutPanelBotones.TabIndex = 4;
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonReiniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReiniciar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReiniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonReiniciar.Location = new System.Drawing.Point(458, 3);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(450, 42);
            this.buttonReiniciar.TabIndex = 1;
            this.buttonReiniciar.Text = "Reiniciar Filtros";
            this.buttonReiniciar.UseVisualStyleBackColor = false;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonFiltrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFiltrar.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrar.Location = new System.Drawing.Point(3, 3);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(449, 42);
            this.buttonFiltrar.TabIndex = 0;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.filtrarPeliculas);
            // 
            // dataGridViewPeliculas
            // 
            this.dataGridViewPeliculas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dataGridViewPeliculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePelicula,
            this.DirectoresPelicula,
            this.AnnoPelicula,
            this.MontoRecaudadoPelicula,
            this.UniversoPelicula,
            this.PersonajesPelicula,
            this.ImagenPelicula});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPeliculas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeliculas.EnableHeadersVisualStyles = false;
            this.dataGridViewPeliculas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridViewPeliculas.Location = new System.Drawing.Point(0, 274);
            this.dataGridViewPeliculas.Name = "dataGridViewPeliculas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeliculas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPeliculas.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPeliculas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPeliculas.RowTemplate.Height = 33;
            this.dataGridViewPeliculas.Size = new System.Drawing.Size(911, 342);
            this.dataGridViewPeliculas.TabIndex = 5;
            // 
            // NombrePelicula
            // 
            this.NombrePelicula.HeaderText = "Nombre";
            this.NombrePelicula.MinimumWidth = 8;
            this.NombrePelicula.Name = "NombrePelicula";
            this.NombrePelicula.ReadOnly = true;
            this.NombrePelicula.Width = 250;
            // 
            // DirectoresPelicula
            // 
            this.DirectoresPelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DirectoresPelicula.HeaderText = "Directores";
            this.DirectoresPelicula.MinimumWidth = 8;
            this.DirectoresPelicula.Name = "DirectoresPelicula";
            this.DirectoresPelicula.ReadOnly = true;
            this.DirectoresPelicula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DirectoresPelicula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DirectoresPelicula.Width = 110;
            // 
            // AnnoPelicula
            // 
            this.AnnoPelicula.HeaderText = "Año";
            this.AnnoPelicula.MinimumWidth = 8;
            this.AnnoPelicula.Name = "AnnoPelicula";
            this.AnnoPelicula.ReadOnly = true;
            this.AnnoPelicula.Width = 250;
            // 
            // MontoRecaudadoPelicula
            // 
            this.MontoRecaudadoPelicula.HeaderText = "Monto Recaudado";
            this.MontoRecaudadoPelicula.MinimumWidth = 8;
            this.MontoRecaudadoPelicula.Name = "MontoRecaudadoPelicula";
            this.MontoRecaudadoPelicula.ReadOnly = true;
            this.MontoRecaudadoPelicula.Width = 250;
            // 
            // UniversoPelicula
            // 
            this.UniversoPelicula.HeaderText = "Universo";
            this.UniversoPelicula.MinimumWidth = 8;
            this.UniversoPelicula.Name = "UniversoPelicula";
            this.UniversoPelicula.ReadOnly = true;
            this.UniversoPelicula.Width = 250;
            // 
            // PersonajesPelicula
            // 
            this.PersonajesPelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PersonajesPelicula.HeaderText = "Personajes";
            this.PersonajesPelicula.MinimumWidth = 8;
            this.PersonajesPelicula.Name = "PersonajesPelicula";
            this.PersonajesPelicula.ReadOnly = true;
            this.PersonajesPelicula.Width = 143;
            // 
            // ImagenPelicula
            // 
            this.ImagenPelicula.HeaderText = "Imagen";
            this.ImagenPelicula.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImagenPelicula.MinimumWidth = 8;
            this.ImagenPelicula.Name = "ImagenPelicula";
            this.ImagenPelicula.ReadOnly = true;
            this.ImagenPelicula.Width = 250;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown1, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(3, 63);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(194, 31);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desde el Año:";
            // 
            // ConsultaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(911, 616);
            this.Controls.Add(this.dataGridViewPeliculas);
            this.Controls.Add(this.tableLayoutPanelBotones);
            this.Controls.Add(this.tableLayoutPanelFiltros);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaPelicula";
            this.Text = "ConsultaPelicula";
            this.panelTitulo.ResumeLayout(false);
            this.tableLayoutPanelFiltros.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHastaAnno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesdeAnno)).EndInit();
            this.tableLayoutPanelUniverso.ResumeLayout(false);
            this.tableLayoutPanelUniverso.PerformLayout();
            this.tableLayoutPanelMonto.ResumeLayout(false);
            this.tableLayoutPanelMonto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHastaMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesdeMonto)).EndInit();
            this.tableLayoutPanelPersonajes.ResumeLayout(false);
            this.tableLayoutPanelPersonajes.PerformLayout();
            this.tableLayoutPanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeliculas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private Panel panelTitulo;
        private TableLayoutPanel tableLayoutPanelFiltros;
        private TableLayoutPanel tableLayoutPanelBotones;
        private DataGridView dataGridViewPeliculas;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown numericUpDownHastaAnno;
        private Label label1;
        private NumericUpDown numericUpDownDesdeAnno;
        private Label label2;
        private TableLayoutPanel tableLayoutPanelUniverso;
        private Label label3;
        private ComboBox comboBoxUniverso;
        private TableLayoutPanel tableLayoutPanelMonto;
        private NumericUpDown numericUpDownHastaMonto;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDownDesdeMonto;
        private TableLayoutPanel tableLayoutPanelPersonajes;
        private Label label7;
        private CheckedListBox checkedListBoxPersonajes;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Button buttonReiniciar;
        private Button buttonFiltrar;
        private DataGridViewTextBoxColumn NombrePelicula;
        private DataGridViewTextBoxColumn DirectoresPelicula;
        private DataGridViewTextBoxColumn AnnoPelicula;
        private DataGridViewTextBoxColumn MontoRecaudadoPelicula;
        private DataGridViewTextBoxColumn UniversoPelicula;
        private DataGridViewTextBoxColumn PersonajesPelicula;
        private DataGridViewImageColumn ImagenPelicula;
    }
}