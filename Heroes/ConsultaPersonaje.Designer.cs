namespace Heroes
{
    partial class ConsultaPersonaje
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
            this.numericUpDownHastaEdad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDesdeEdad = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxActitud = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.tableLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.NombrePelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActitudPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentidadSecretaPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniversoPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivoPersonaje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ImagenPersonaje = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTitulo.SuspendLayout();
            this.tableLayoutPanelFiltros.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHastaEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesdeEdad)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.Font = new System.Drawing.Font("Stencil", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(26, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(849, 76);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Consulta de Personajes";
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
            this.panelTitulo.TabIndex = 2;
            // 
            // tableLayoutPanelFiltros
            // 
            this.tableLayoutPanelFiltros.ColumnCount = 3;
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFiltros.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelFiltros.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanelFiltros.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFiltros.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanelFiltros.Name = "tableLayoutPanelFiltros";
            this.tableLayoutPanelFiltros.RowCount = 1;
            this.tableLayoutPanelFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFiltros.Size = new System.Drawing.Size(911, 150);
            this.tableLayoutPanelFiltros.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHastaEdad, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownDesdeEdad, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numericUpDownHastaEdad
            // 
            this.numericUpDownHastaEdad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownHastaEdad.Location = new System.Drawing.Point(3, 111);
            this.numericUpDownHastaEdad.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownHastaEdad.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownHastaEdad.Name = "numericUpDownHastaEdad";
            this.numericUpDownHastaEdad.Size = new System.Drawing.Size(291, 31);
            this.numericUpDownHastaEdad.TabIndex = 3;
            this.numericUpDownHastaEdad.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta la edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde la edad";
            // 
            // numericUpDownDesdeEdad
            // 
            this.numericUpDownDesdeEdad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownDesdeEdad.Location = new System.Drawing.Point(3, 39);
            this.numericUpDownDesdeEdad.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownDesdeEdad.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDesdeEdad.Name = "numericUpDownDesdeEdad";
            this.numericUpDownDesdeEdad.Size = new System.Drawing.Size(291, 31);
            this.numericUpDownDesdeEdad.TabIndex = 1;
            this.numericUpDownDesdeEdad.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxActitud, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(306, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 144);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Actitud";
            // 
            // comboBoxActitud
            // 
            this.comboBoxActitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxActitud.FormattingEnabled = true;
            this.comboBoxActitud.Location = new System.Drawing.Point(3, 44);
            this.comboBoxActitud.Name = "comboBoxActitud";
            this.comboBoxActitud.Size = new System.Drawing.Size(291, 33);
            this.comboBoxActitud.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSexo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(609, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(299, 144);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(3, 44);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(293, 33);
            this.comboBoxSexo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sexo";
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
            this.buttonFiltrar.Click += new System.EventHandler(this.filtrarPersonajes);
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
            this.tableLayoutPanelBotones.TabIndex = 5;
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dataGridViewPersonajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPersonajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePelicula,
            this.ActitudPersonaje,
            this.SexoPersonaje,
            this.IdentidadSecretaPersonaje,
            this.UniversoPersonaje,
            this.EdadPersonaje,
            this.ActivoPersonaje,
            this.ImagenPersonaje});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPersonajes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPersonajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPersonajes.EnableHeadersVisualStyles = false;
            this.dataGridViewPersonajes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(0, 274);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPersonajes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPersonajes.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPersonajes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPersonajes.RowTemplate.Height = 33;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(911, 342);
            this.dataGridViewPersonajes.TabIndex = 6;
            // 
            // NombrePelicula
            // 
            this.NombrePelicula.HeaderText = "Nombre";
            this.NombrePelicula.MinimumWidth = 8;
            this.NombrePelicula.Name = "NombrePelicula";
            this.NombrePelicula.ReadOnly = true;
            this.NombrePelicula.Width = 250;
            // 
            // ActitudPersonaje
            // 
            this.ActitudPersonaje.HeaderText = "Actitud";
            this.ActitudPersonaje.MinimumWidth = 8;
            this.ActitudPersonaje.Name = "ActitudPersonaje";
            this.ActitudPersonaje.ReadOnly = true;
            this.ActitudPersonaje.Width = 150;
            // 
            // SexoPersonaje
            // 
            this.SexoPersonaje.HeaderText = "Sexo";
            this.SexoPersonaje.MinimumWidth = 8;
            this.SexoPersonaje.Name = "SexoPersonaje";
            this.SexoPersonaje.ReadOnly = true;
            this.SexoPersonaje.Width = 150;
            // 
            // IdentidadSecretaPersonaje
            // 
            this.IdentidadSecretaPersonaje.HeaderText = "Identidad Secreta";
            this.IdentidadSecretaPersonaje.MinimumWidth = 8;
            this.IdentidadSecretaPersonaje.Name = "IdentidadSecretaPersonaje";
            this.IdentidadSecretaPersonaje.ReadOnly = true;
            this.IdentidadSecretaPersonaje.Width = 150;
            // 
            // UniversoPersonaje
            // 
            this.UniversoPersonaje.HeaderText = "Universo";
            this.UniversoPersonaje.MinimumWidth = 8;
            this.UniversoPersonaje.Name = "UniversoPersonaje";
            this.UniversoPersonaje.ReadOnly = true;
            this.UniversoPersonaje.Width = 150;
            // 
            // EdadPersonaje
            // 
            this.EdadPersonaje.HeaderText = "Edad";
            this.EdadPersonaje.MinimumWidth = 8;
            this.EdadPersonaje.Name = "EdadPersonaje";
            this.EdadPersonaje.ReadOnly = true;
            this.EdadPersonaje.Width = 150;
            // 
            // ActivoPersonaje
            // 
            this.ActivoPersonaje.HeaderText = "Activo";
            this.ActivoPersonaje.MinimumWidth = 8;
            this.ActivoPersonaje.Name = "ActivoPersonaje";
            this.ActivoPersonaje.ReadOnly = true;
            this.ActivoPersonaje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivoPersonaje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ActivoPersonaje.Width = 150;
            // 
            // ImagenPersonaje
            // 
            this.ImagenPersonaje.HeaderText = "Imagen";
            this.ImagenPersonaje.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImagenPersonaje.MinimumWidth = 8;
            this.ImagenPersonaje.Name = "ImagenPersonaje";
            this.ImagenPersonaje.ReadOnly = true;
            this.ImagenPersonaje.Width = 150;
            // 
            // ConsultaPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(911, 616);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.tableLayoutPanelBotones);
            this.Controls.Add(this.tableLayoutPanelFiltros);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaPersonaje";
            this.Text = "ConsultaPersonaje";
            this.panelTitulo.ResumeLayout(false);
            this.tableLayoutPanelFiltros.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHastaEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesdeEdad)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private Panel panelTitulo;
        private TableLayoutPanel tableLayoutPanelFiltros;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private NumericUpDown numericUpDownDesdeEdad;
        private NumericUpDown numericUpDownHastaEdad;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private ComboBox comboBoxActitud;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox comboBoxSexo;
        private Label label4;
        private Button buttonReiniciar;
        private Button buttonFiltrar;
        private TableLayoutPanel tableLayoutPanelBotones;
        private DataGridView dataGridViewPersonajes;
        private DataGridViewTextBoxColumn NombrePelicula;
        private DataGridViewTextBoxColumn ActitudPersonaje;
        private DataGridViewTextBoxColumn SexoPersonaje;
        private DataGridViewTextBoxColumn IdentidadSecretaPersonaje;
        private DataGridViewTextBoxColumn UniversoPersonaje;
        private DataGridViewTextBoxColumn EdadPersonaje;
        private DataGridViewCheckBoxColumn ActivoPersonaje;
        private DataGridViewImageColumn ImagenPersonaje;
    }
}