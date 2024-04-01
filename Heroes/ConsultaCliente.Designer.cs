namespace Empresa
{
    partial class ConsultaCliente
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            labelTitulo = new Label();
            panelTitulo = new Panel();
            tableLayoutPanelFiltros = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            numericUpDownHastaCedula = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            numericUpDownDesdeCedula = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            comboBoxActitud = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            comboBoxSexo = new ComboBox();
            label4 = new Label();
            buttonReiniciar = new Button();
            buttonFiltrar = new Button();
            tableLayoutPanelBotones = new TableLayoutPanel();
            dataGridViewClientes = new DataGridView();
            numeroRegistroCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            ApellidoCliente = new DataGridViewTextBoxColumn();
            CedulaCliente = new DataGridViewTextBoxColumn();
            FechaNacimientoCliente = new DataGridViewTextBoxColumn();
            FechRegistroCliente = new DataGridViewTextBoxColumn();
            direccionCliente = new DataGridViewTextBoxColumn();
            ImagenCliente = new DataGridViewImageColumn();
            panelTitulo.SuspendLayout();
            tableLayoutPanelFiltros.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHastaCedula).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesdeCedula).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTitulo.Font = new Font("Stencil", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(18, 0);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(1232, 46);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Consulta de Clientes";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            panelTitulo.AutoSize = true;
            panelTitulo.BackColor = Color.FromArgb(51, 51, 51);
            panelTitulo.Controls.Add(labelTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(2);
            panelTitulo.MaximumSize = new Size(0, 120);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(638, 46);
            panelTitulo.TabIndex = 2;
            // 
            // tableLayoutPanelFiltros
            // 
            tableLayoutPanelFiltros.ColumnCount = 3;
            tableLayoutPanelFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelFiltros.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanelFiltros.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanelFiltros.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanelFiltros.Dock = DockStyle.Top;
            tableLayoutPanelFiltros.Location = new Point(0, 46);
            tableLayoutPanelFiltros.Margin = new Padding(2);
            tableLayoutPanelFiltros.Name = "tableLayoutPanelFiltros";
            tableLayoutPanelFiltros.RowCount = 1;
            tableLayoutPanelFiltros.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFiltros.Size = new Size(638, 90);
            tableLayoutPanelFiltros.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(numericUpDownHastaCedula, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(numericUpDownDesdeCedula, 0, 1);
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(208, 86);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // numericUpDownHastaCedula
            // 
            numericUpDownHastaCedula.Dock = DockStyle.Fill;
            numericUpDownHastaCedula.Location = new Point(2, 65);
            numericUpDownHastaCedula.Margin = new Padding(2);
            numericUpDownHastaCedula.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numericUpDownHastaCedula.Name = "numericUpDownHastaCedula";
            numericUpDownHastaCedula.Size = new Size(204, 23);
            numericUpDownHastaCedula.TabIndex = 3;
            numericUpDownHastaCedula.Value = new decimal(new int[] { 50000000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 21);
            label2.TabIndex = 2;
            label2.Text = "Hasta la cédula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 0;
            label1.Text = "Desde la cédula";
            // 
            // numericUpDownDesdeCedula
            // 
            numericUpDownDesdeCedula.Dock = DockStyle.Fill;
            numericUpDownDesdeCedula.Location = new Point(2, 23);
            numericUpDownDesdeCedula.Margin = new Padding(2);
            numericUpDownDesdeCedula.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numericUpDownDesdeCedula.Name = "numericUpDownDesdeCedula";
            numericUpDownDesdeCedula.Size = new Size(204, 23);
            numericUpDownDesdeCedula.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBoxActitud, 0, 1);
            tableLayoutPanel2.Location = new Point(214, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel2.Size = new Size(208, 86);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(204, 24);
            label3.TabIndex = 1;
            label3.Text = "Actitud";
            // 
            // comboBoxActitud
            // 
            comboBoxActitud.Dock = DockStyle.Fill;
            comboBoxActitud.FormattingEnabled = true;
            comboBoxActitud.Location = new Point(2, 26);
            comboBoxActitud.Margin = new Padding(2);
            comboBoxActitud.Name = "comboBoxActitud";
            comboBoxActitud.Size = new Size(204, 23);
            comboBoxActitud.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(comboBoxSexo, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Location = new Point(426, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel3.Size = new Size(209, 86);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.Dock = DockStyle.Fill;
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Location = new Point(2, 26);
            comboBoxSexo.Margin = new Padding(2);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(205, 23);
            comboBoxSexo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(205, 24);
            label4.TabIndex = 2;
            label4.Text = "Sexo";
            // 
            // buttonReiniciar
            // 
            buttonReiniciar.BackColor = Color.FromArgb(51, 51, 51);
            buttonReiniciar.Dock = DockStyle.Fill;
            buttonReiniciar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            buttonReiniciar.FlatStyle = FlatStyle.Flat;
            buttonReiniciar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReiniciar.ForeColor = Color.FromArgb(210, 70, 70);
            buttonReiniciar.Location = new Point(321, 2);
            buttonReiniciar.Margin = new Padding(2);
            buttonReiniciar.Name = "buttonReiniciar";
            buttonReiniciar.Size = new Size(315, 25);
            buttonReiniciar.TabIndex = 1;
            buttonReiniciar.Text = "Reiniciar Filtros";
            buttonReiniciar.UseVisualStyleBackColor = false;
            buttonReiniciar.Click += buttonReiniciar_Click;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.BackColor = Color.FromArgb(51, 51, 51);
            buttonFiltrar.Dock = DockStyle.Fill;
            buttonFiltrar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            buttonFiltrar.FlatStyle = FlatStyle.Flat;
            buttonFiltrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFiltrar.ForeColor = Color.White;
            buttonFiltrar.Location = new Point(2, 2);
            buttonFiltrar.Margin = new Padding(2);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(315, 25);
            buttonFiltrar.TabIndex = 0;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = false;
            buttonFiltrar.Click += filtrarClientes;
            // 
            // tableLayoutPanelBotones
            // 
            tableLayoutPanelBotones.ColumnCount = 2;
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.Controls.Add(buttonReiniciar, 1, 0);
            tableLayoutPanelBotones.Controls.Add(buttonFiltrar, 0, 0);
            tableLayoutPanelBotones.Dock = DockStyle.Top;
            tableLayoutPanelBotones.Location = new Point(0, 136);
            tableLayoutPanelBotones.Margin = new Padding(2);
            tableLayoutPanelBotones.Name = "tableLayoutPanelBotones";
            tableLayoutPanelBotones.RowCount = 1;
            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.Size = new Size(638, 29);
            tableLayoutPanelBotones.TabIndex = 5;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridViewClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { numeroRegistroCliente, NombreCliente, ApellidoCliente, CedulaCliente, FechaNacimientoCliente, FechRegistroCliente, direccionCliente, ImagenCliente });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewClientes.Dock = DockStyle.Fill;
            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.GridColor = Color.FromArgb(51, 51, 51);
            dataGridViewClientes.Location = new Point(0, 165);
            dataGridViewClientes.Margin = new Padding(2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle12.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewClientes.RowTemplate.Height = 33;
            dataGridViewClientes.Size = new Size(638, 205);
            dataGridViewClientes.TabIndex = 6;
            // 
            // numeroRegistroCliente
            // 
            numeroRegistroCliente.HeaderText = "Número de Registro";
            numeroRegistroCliente.MinimumWidth = 8;
            numeroRegistroCliente.Name = "numeroRegistroCliente";
            numeroRegistroCliente.ReadOnly = true;
            numeroRegistroCliente.Width = 150;
            // 
            // NombreCliente
            // 
            NombreCliente.HeaderText = "Nombre";
            NombreCliente.MinimumWidth = 8;
            NombreCliente.Name = "NombreCliente";
            NombreCliente.ReadOnly = true;
            NombreCliente.Width = 250;
            // 
            // ApellidoCliente
            // 
            ApellidoCliente.HeaderText = "Apellido";
            ApellidoCliente.MinimumWidth = 8;
            ApellidoCliente.Name = "ApellidoCliente";
            ApellidoCliente.ReadOnly = true;
            ApellidoCliente.Width = 150;
            // 
            // CedulaCliente
            // 
            CedulaCliente.HeaderText = "Cédula";
            CedulaCliente.MinimumWidth = 8;
            CedulaCliente.Name = "CedulaCliente";
            CedulaCliente.ReadOnly = true;
            CedulaCliente.Width = 150;
            // 
            // FechaNacimientoCliente
            // 
            FechaNacimientoCliente.HeaderText = "Fecha de Nacimiento";
            FechaNacimientoCliente.MinimumWidth = 8;
            FechaNacimientoCliente.Name = "FechaNacimientoCliente";
            FechaNacimientoCliente.ReadOnly = true;
            FechaNacimientoCliente.Width = 150;
            // 
            // FechRegistroCliente
            // 
            FechRegistroCliente.HeaderText = "Fecha de Registro";
            FechRegistroCliente.MinimumWidth = 8;
            FechRegistroCliente.Name = "FechRegistroCliente";
            FechRegistroCliente.ReadOnly = true;
            FechRegistroCliente.Width = 150;
            // 
            // direccionCliente
            // 
            direccionCliente.HeaderText = "Dirección";
            direccionCliente.MinimumWidth = 8;
            direccionCliente.Name = "direccionCliente";
            direccionCliente.ReadOnly = true;
            direccionCliente.Resizable = DataGridViewTriState.True;
            direccionCliente.Width = 150;
            // 
            // ImagenCliente
            // 
            ImagenCliente.HeaderText = "Imagen";
            ImagenCliente.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ImagenCliente.MinimumWidth = 8;
            ImagenCliente.Name = "ImagenCliente";
            ImagenCliente.ReadOnly = true;
            ImagenCliente.Width = 150;
            // 
            // ConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(638, 370);
            Controls.Add(dataGridViewClientes);
            Controls.Add(tableLayoutPanelBotones);
            Controls.Add(tableLayoutPanelFiltros);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ConsultaCliente";
            Text = "ConsultaPersonaje";
            panelTitulo.ResumeLayout(false);
            tableLayoutPanelFiltros.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHastaCedula).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesdeCedula).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Panel panelTitulo;
        private TableLayoutPanel tableLayoutPanelFiltros;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private NumericUpDown numericUpDownDesdeCedula;
        private NumericUpDown numericUpDownHastaCedula;
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
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn numeroRegistroCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn ApellidoCliente;
        private DataGridViewTextBoxColumn CedulaCliente;
        private DataGridViewTextBoxColumn FechaNacimientoCliente;
        private DataGridViewTextBoxColumn FechRegistroCliente;
        private DataGridViewTextBoxColumn direccionCliente;
        private DataGridViewImageColumn ImagenCliente;
    }
}