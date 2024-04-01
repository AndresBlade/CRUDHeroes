namespace Empresa
{
    partial class RegistroCliente
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
            panelTitulo = new Panel();
            labelTitulo = new Label();
            panelDatosCliente = new Panel();
            panelBotonesCliente = new Panel();
            buttonEliminarCliente = new Button();
            buttonActualizarCliente = new Button();
            buttonBuscarCliente = new Button();
            buttonCrearCliente = new Button();
            panelEdadPersonaje = new Panel();
            textBoxDireccionCliente = new TextBox();
            labelDireccionCliente = new Label();
            panelFechaNacimientoCliente = new Panel();
            dateTimePickerFechaNacimientoCliente = new DateTimePicker();
            labelFechaNacimientoCliente = new Label();
            panelCedulaCliente = new Panel();
            numericUpDownCedulaCliente = new NumericUpDown();
            labelCedulaCliente = new Label();
            panelApellidoCliente = new Panel();
            textBoxApellidoCliente = new TextBox();
            labelApellidoCliente = new Label();
            panelNombreCliente = new Panel();
            textBoxNombreCliente = new TextBox();
            labelNombreCliente = new Label();
            panelImagenCliente = new Panel();
            label1 = new Label();
            pictureBoxImagenCliente = new PictureBox();
            buttonannadirImagen = new Button();
            openFileDialogImagenCliente = new OpenFileDialog();
            panelTitulo.SuspendLayout();
            panelDatosCliente.SuspendLayout();
            panelBotonesCliente.SuspendLayout();
            panelEdadPersonaje.SuspendLayout();
            panelFechaNacimientoCliente.SuspendLayout();
            panelCedulaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCedulaCliente).BeginInit();
            panelApellidoCliente.SuspendLayout();
            panelNombreCliente.SuspendLayout();
            panelImagenCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenCliente).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(51, 51, 51);
            panelTitulo.Controls.Add(labelTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(2, 1, 2, 1);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(638, 46);
            panelTitulo.TabIndex = 1;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTitulo.Font = new Font("Trebuchet MS", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(20, 0);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(591, 46);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Registro de Cliente\n";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDatosCliente
            // 
            panelDatosCliente.Controls.Add(panelBotonesCliente);
            panelDatosCliente.Controls.Add(panelEdadPersonaje);
            panelDatosCliente.Controls.Add(panelFechaNacimientoCliente);
            panelDatosCliente.Controls.Add(panelCedulaCliente);
            panelDatosCliente.Controls.Add(panelApellidoCliente);
            panelDatosCliente.Controls.Add(panelNombreCliente);
            panelDatosCliente.Dock = DockStyle.Left;
            panelDatosCliente.Location = new Point(0, 46);
            panelDatosCliente.Margin = new Padding(2, 1, 2, 1);
            panelDatosCliente.Name = "panelDatosCliente";
            panelDatosCliente.Padding = new Padding(7, 0, 0, 0);
            panelDatosCliente.Size = new Size(200, 324);
            panelDatosCliente.TabIndex = 2;
            // 
            // panelBotonesCliente
            // 
            panelBotonesCliente.Controls.Add(buttonEliminarCliente);
            panelBotonesCliente.Controls.Add(buttonActualizarCliente);
            panelBotonesCliente.Controls.Add(buttonBuscarCliente);
            panelBotonesCliente.Controls.Add(buttonCrearCliente);
            panelBotonesCliente.Dock = DockStyle.Top;
            panelBotonesCliente.Location = new Point(7, 187);
            panelBotonesCliente.Margin = new Padding(2, 1, 2, 1);
            panelBotonesCliente.Name = "panelBotonesCliente";
            panelBotonesCliente.Size = new Size(193, 90);
            panelBotonesCliente.TabIndex = 7;
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.BackColor = Color.FromArgb(51, 51, 51);
            buttonEliminarCliente.Dock = DockStyle.Top;
            buttonEliminarCliente.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            buttonEliminarCliente.FlatStyle = FlatStyle.Flat;
            buttonEliminarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminarCliente.ForeColor = Color.FromArgb(210, 70, 70);
            buttonEliminarCliente.Location = new Point(0, 60);
            buttonEliminarCliente.Margin = new Padding(2, 1, 2, 1);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(193, 20);
            buttonEliminarCliente.TabIndex = 3;
            buttonEliminarCliente.Text = "Eliminar Cliente";
            buttonEliminarCliente.UseVisualStyleBackColor = false;
            buttonEliminarCliente.Click += buttonEliminarCliente_Click;
            // 
            // buttonActualizarCliente
            // 
            buttonActualizarCliente.BackColor = Color.FromArgb(51, 51, 51);
            buttonActualizarCliente.Dock = DockStyle.Top;
            buttonActualizarCliente.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            buttonActualizarCliente.FlatStyle = FlatStyle.Flat;
            buttonActualizarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonActualizarCliente.ForeColor = Color.White;
            buttonActualizarCliente.Location = new Point(0, 40);
            buttonActualizarCliente.Margin = new Padding(2, 1, 2, 1);
            buttonActualizarCliente.Name = "buttonActualizarCliente";
            buttonActualizarCliente.Size = new Size(193, 20);
            buttonActualizarCliente.TabIndex = 2;
            buttonActualizarCliente.Text = "Actualizar Cliente";
            buttonActualizarCliente.UseVisualStyleBackColor = false;
            buttonActualizarCliente.Click += buttonActualizarCliente_Click;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.BackColor = Color.FromArgb(51, 51, 51);
            buttonBuscarCliente.Dock = DockStyle.Top;
            buttonBuscarCliente.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            buttonBuscarCliente.FlatStyle = FlatStyle.Flat;
            buttonBuscarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBuscarCliente.ForeColor = Color.White;
            buttonBuscarCliente.Location = new Point(0, 20);
            buttonBuscarCliente.Margin = new Padding(2, 1, 2, 1);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(193, 20);
            buttonBuscarCliente.TabIndex = 1;
            buttonBuscarCliente.Text = "Buscar Cliente";
            buttonBuscarCliente.UseVisualStyleBackColor = false;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // buttonCrearCliente
            // 
            buttonCrearCliente.BackColor = Color.FromArgb(51, 51, 51);
            buttonCrearCliente.Dock = DockStyle.Top;
            buttonCrearCliente.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            buttonCrearCliente.FlatStyle = FlatStyle.Flat;
            buttonCrearCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCrearCliente.ForeColor = Color.White;
            buttonCrearCliente.Location = new Point(0, 0);
            buttonCrearCliente.Margin = new Padding(2, 1, 2, 1);
            buttonCrearCliente.Name = "buttonCrearCliente";
            buttonCrearCliente.Size = new Size(193, 20);
            buttonCrearCliente.TabIndex = 0;
            buttonCrearCliente.Text = "Crear Cliente";
            buttonCrearCliente.UseVisualStyleBackColor = false;
            buttonCrearCliente.Click += buttonCrearCliente_Click;
            // 
            // panelEdadPersonaje
            // 
            panelEdadPersonaje.Controls.Add(textBoxDireccionCliente);
            panelEdadPersonaje.Controls.Add(labelDireccionCliente);
            panelEdadPersonaje.Dock = DockStyle.Top;
            panelEdadPersonaje.Location = new Point(7, 138);
            panelEdadPersonaje.Margin = new Padding(2, 1, 2, 1);
            panelEdadPersonaje.Name = "panelEdadPersonaje";
            panelEdadPersonaje.Size = new Size(193, 49);
            panelEdadPersonaje.TabIndex = 5;
            // 
            // textBoxDireccionCliente
            // 
            textBoxDireccionCliente.BackColor = Color.FromArgb(34, 34, 34);
            textBoxDireccionCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxDireccionCliente.Dock = DockStyle.Top;
            textBoxDireccionCliente.ForeColor = Color.White;
            textBoxDireccionCliente.Location = new Point(0, 15);
            textBoxDireccionCliente.Margin = new Padding(2, 1, 2, 1);
            textBoxDireccionCliente.Name = "textBoxDireccionCliente";
            textBoxDireccionCliente.Size = new Size(193, 23);
            textBoxDireccionCliente.TabIndex = 3;
            textBoxDireccionCliente.TextChanged += textBox1_TextChanged;
            // 
            // labelDireccionCliente
            // 
            labelDireccionCliente.AutoSize = true;
            labelDireccionCliente.Dock = DockStyle.Top;
            labelDireccionCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDireccionCliente.ForeColor = Color.White;
            labelDireccionCliente.Location = new Point(0, 0);
            labelDireccionCliente.Margin = new Padding(2, 0, 2, 0);
            labelDireccionCliente.Name = "labelDireccionCliente";
            labelDireccionCliente.Size = new Size(60, 15);
            labelDireccionCliente.TabIndex = 0;
            labelDireccionCliente.Text = "Dirección";
            // 
            // panelFechaNacimientoCliente
            // 
            panelFechaNacimientoCliente.Controls.Add(dateTimePickerFechaNacimientoCliente);
            panelFechaNacimientoCliente.Controls.Add(labelFechaNacimientoCliente);
            panelFechaNacimientoCliente.Dock = DockStyle.Top;
            panelFechaNacimientoCliente.Location = new Point(7, 104);
            panelFechaNacimientoCliente.Margin = new Padding(2, 1, 2, 1);
            panelFechaNacimientoCliente.Name = "panelFechaNacimientoCliente";
            panelFechaNacimientoCliente.Size = new Size(193, 34);
            panelFechaNacimientoCliente.TabIndex = 3;
            // 
            // dateTimePickerFechaNacimientoCliente
            // 
            dateTimePickerFechaNacimientoCliente.Dock = DockStyle.Top;
            dateTimePickerFechaNacimientoCliente.Location = new Point(0, 15);
            dateTimePickerFechaNacimientoCliente.Name = "dateTimePickerFechaNacimientoCliente";
            dateTimePickerFechaNacimientoCliente.Size = new Size(193, 23);
            dateTimePickerFechaNacimientoCliente.TabIndex = 1;
            // 
            // labelFechaNacimientoCliente
            // 
            labelFechaNacimientoCliente.AutoSize = true;
            labelFechaNacimientoCliente.Dock = DockStyle.Top;
            labelFechaNacimientoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFechaNacimientoCliente.ForeColor = Color.White;
            labelFechaNacimientoCliente.Location = new Point(0, 0);
            labelFechaNacimientoCliente.Margin = new Padding(2, 0, 2, 0);
            labelFechaNacimientoCliente.Name = "labelFechaNacimientoCliente";
            labelFechaNacimientoCliente.Size = new Size(123, 15);
            labelFechaNacimientoCliente.TabIndex = 0;
            labelFechaNacimientoCliente.Text = "Fecha de Nacimiento";
            // 
            // panelCedulaCliente
            // 
            panelCedulaCliente.Controls.Add(numericUpDownCedulaCliente);
            panelCedulaCliente.Controls.Add(labelCedulaCliente);
            panelCedulaCliente.Dock = DockStyle.Top;
            panelCedulaCliente.Location = new Point(7, 69);
            panelCedulaCliente.Margin = new Padding(2, 1, 2, 1);
            panelCedulaCliente.Name = "panelCedulaCliente";
            panelCedulaCliente.Size = new Size(193, 35);
            panelCedulaCliente.TabIndex = 2;
            // 
            // numericUpDownCedulaCliente
            // 
            numericUpDownCedulaCliente.BackColor = Color.FromArgb(34, 34, 34);
            numericUpDownCedulaCliente.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownCedulaCliente.Dock = DockStyle.Top;
            numericUpDownCedulaCliente.ForeColor = Color.White;
            numericUpDownCedulaCliente.Location = new Point(0, 15);
            numericUpDownCedulaCliente.Margin = new Padding(2, 1, 2, 1);
            numericUpDownCedulaCliente.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            numericUpDownCedulaCliente.Name = "numericUpDownCedulaCliente";
            numericUpDownCedulaCliente.Size = new Size(193, 23);
            numericUpDownCedulaCliente.TabIndex = 2;
            // 
            // labelCedulaCliente
            // 
            labelCedulaCliente.AutoSize = true;
            labelCedulaCliente.Dock = DockStyle.Top;
            labelCedulaCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCedulaCliente.ForeColor = Color.White;
            labelCedulaCliente.Location = new Point(0, 0);
            labelCedulaCliente.Margin = new Padding(2, 0, 2, 0);
            labelCedulaCliente.Name = "labelCedulaCliente";
            labelCedulaCliente.Size = new Size(44, 15);
            labelCedulaCliente.TabIndex = 0;
            labelCedulaCliente.Text = "Cédula";
            // 
            // panelApellidoCliente
            // 
            panelApellidoCliente.Controls.Add(textBoxApellidoCliente);
            panelApellidoCliente.Controls.Add(labelApellidoCliente);
            panelApellidoCliente.Dock = DockStyle.Top;
            panelApellidoCliente.Location = new Point(7, 34);
            panelApellidoCliente.Margin = new Padding(2, 1, 2, 1);
            panelApellidoCliente.Name = "panelApellidoCliente";
            panelApellidoCliente.Size = new Size(193, 35);
            panelApellidoCliente.TabIndex = 1;
            // 
            // textBoxApellidoCliente
            // 
            textBoxApellidoCliente.BackColor = Color.FromArgb(34, 34, 34);
            textBoxApellidoCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellidoCliente.Dock = DockStyle.Top;
            textBoxApellidoCliente.ForeColor = Color.White;
            textBoxApellidoCliente.Location = new Point(0, 15);
            textBoxApellidoCliente.Margin = new Padding(2, 1, 2, 1);
            textBoxApellidoCliente.Name = "textBoxApellidoCliente";
            textBoxApellidoCliente.Size = new Size(193, 23);
            textBoxApellidoCliente.TabIndex = 2;
            // 
            // labelApellidoCliente
            // 
            labelApellidoCliente.AutoSize = true;
            labelApellidoCliente.Dock = DockStyle.Top;
            labelApellidoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelApellidoCliente.ForeColor = Color.White;
            labelApellidoCliente.Location = new Point(0, 0);
            labelApellidoCliente.Margin = new Padding(2, 0, 2, 0);
            labelApellidoCliente.Name = "labelApellidoCliente";
            labelApellidoCliente.Size = new Size(52, 15);
            labelApellidoCliente.TabIndex = 0;
            labelApellidoCliente.Text = "Apellido";
            // 
            // panelNombreCliente
            // 
            panelNombreCliente.Controls.Add(textBoxNombreCliente);
            panelNombreCliente.Controls.Add(labelNombreCliente);
            panelNombreCliente.Dock = DockStyle.Top;
            panelNombreCliente.Location = new Point(7, 0);
            panelNombreCliente.Margin = new Padding(2, 1, 2, 1);
            panelNombreCliente.Name = "panelNombreCliente";
            panelNombreCliente.Size = new Size(193, 34);
            panelNombreCliente.TabIndex = 0;
            // 
            // textBoxNombreCliente
            // 
            textBoxNombreCliente.BackColor = Color.FromArgb(34, 34, 34);
            textBoxNombreCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombreCliente.Dock = DockStyle.Top;
            textBoxNombreCliente.ForeColor = Color.White;
            textBoxNombreCliente.Location = new Point(0, 15);
            textBoxNombreCliente.Margin = new Padding(2, 1, 2, 1);
            textBoxNombreCliente.Name = "textBoxNombreCliente";
            textBoxNombreCliente.Size = new Size(193, 23);
            textBoxNombreCliente.TabIndex = 1;
            // 
            // labelNombreCliente
            // 
            labelNombreCliente.AutoSize = true;
            labelNombreCliente.Dock = DockStyle.Top;
            labelNombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombreCliente.ForeColor = Color.White;
            labelNombreCliente.Location = new Point(0, 0);
            labelNombreCliente.Margin = new Padding(2, 0, 2, 0);
            labelNombreCliente.Name = "labelNombreCliente";
            labelNombreCliente.Size = new Size(53, 15);
            labelNombreCliente.TabIndex = 0;
            labelNombreCliente.Text = "Nombre";
            // 
            // panelImagenCliente
            // 
            panelImagenCliente.Controls.Add(label1);
            panelImagenCliente.Controls.Add(pictureBoxImagenCliente);
            panelImagenCliente.Controls.Add(buttonannadirImagen);
            panelImagenCliente.Dock = DockStyle.Fill;
            panelImagenCliente.Location = new Point(200, 46);
            panelImagenCliente.Margin = new Padding(2);
            panelImagenCliente.Name = "panelImagenCliente";
            panelImagenCliente.Padding = new Padding(56, 48, 56, 48);
            panelImagenCliente.Size = new Size(438, 324);
            panelImagenCliente.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(34, 34, 34);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 15);
            label1.TabIndex = 3;
            label1.Text = "*Nota: La búsqueda de cliente se hace por su nombre";
            // 
            // pictureBoxImagenCliente
            // 
            pictureBoxImagenCliente.Dock = DockStyle.Fill;
            pictureBoxImagenCliente.Location = new Point(56, 48);
            pictureBoxImagenCliente.Margin = new Padding(2);
            pictureBoxImagenCliente.Name = "pictureBoxImagenCliente";
            pictureBoxImagenCliente.Size = new Size(326, 208);
            pictureBoxImagenCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagenCliente.TabIndex = 2;
            pictureBoxImagenCliente.TabStop = false;
            // 
            // buttonannadirImagen
            // 
            buttonannadirImagen.BackColor = Color.FromArgb(51, 51, 51);
            buttonannadirImagen.Dock = DockStyle.Bottom;
            buttonannadirImagen.FlatStyle = FlatStyle.Flat;
            buttonannadirImagen.ForeColor = Color.White;
            buttonannadirImagen.Location = new Point(56, 256);
            buttonannadirImagen.Margin = new Padding(2);
            buttonannadirImagen.Name = "buttonannadirImagen";
            buttonannadirImagen.Size = new Size(326, 20);
            buttonannadirImagen.TabIndex = 1;
            buttonannadirImagen.Text = "Añadir Imagen";
            buttonannadirImagen.UseVisualStyleBackColor = false;
            buttonannadirImagen.Click += buttonannadirImagen_Click;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(638, 370);
            Controls.Add(panelImagenCliente);
            Controls.Add(panelDatosCliente);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "RegistroCliente";
            Text = "RegistroCliente";
            FormClosing += RegistroPersonaje_FormClosing;
            panelTitulo.ResumeLayout(false);
            panelDatosCliente.ResumeLayout(false);
            panelBotonesCliente.ResumeLayout(false);
            panelEdadPersonaje.ResumeLayout(false);
            panelEdadPersonaje.PerformLayout();
            panelFechaNacimientoCliente.ResumeLayout(false);
            panelFechaNacimientoCliente.PerformLayout();
            panelCedulaCliente.ResumeLayout(false);
            panelCedulaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCedulaCliente).EndInit();
            panelApellidoCliente.ResumeLayout(false);
            panelApellidoCliente.PerformLayout();
            panelNombreCliente.ResumeLayout(false);
            panelNombreCliente.PerformLayout();
            panelImagenCliente.ResumeLayout(false);
            panelImagenCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFechaNacimientoCliente;
        private Panel panelTitulo;
        private Label labelTitulo;
        private Panel panelDatosCliente;
        private Panel panelNombreCliente;
        private TextBox textBoxNombreCliente;
        private Label labelNombreCliente;
        private Panel panelApellidoCliente;
        private Label labelApellidoCliente;
        private Panel panelCedulaCliente;
        private ComboBox comboBoxActitudPersonaje;
        private Label labelCedulaCliente;
        private Panel panelIdentidadSecreta;
        private TextBox textBoxIdentidadSecretaPersonaje;
        private Label labelFechaNacimientoCliente;
        private Panel panelUniversoPersonaje;
        private ComboBox comboBoxUniversoPersonaje;
        private Label labelUniversoPersonaje;
        private Panel panelEdadPersonaje;
        private NumericUpDown numericUpDownEdadPersonaje;
        private Label labelDireccionCliente;
        private Panel panelBotonesCliente;
        private Button buttonBuscarCliente;
        private Button buttonEliminarCliente;
        private Button buttonActualizarCliente;
        private Panel panelImagenCliente;
        private OpenFileDialog openFileDialogImagenCliente;
        private Button buttonannadirImagen;
        private PictureBox pictureBoxImagenCliente;
        private Button buttonCrearCliente;
        private Label label1;
        private TextBox textBoxApellidoCliente;
        private NumericUpDown numericUpDownCedulaCliente;
        private DateTimePicker dateTimePickerFechaNacimientoCliente;
        private TextBox textBoxDireccionCliente;
    }
}