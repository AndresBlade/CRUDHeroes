namespace Heroes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            panelPrestamosSubmenu = new Panel();
            buttonConsultaPrestamos = new Button();
            buttonRegistroPrestamos = new Button();
            buttonSubmenuPrestamos = new Button();
            panelClientesSubmenu = new Panel();
            buttonConsultaClientes = new Button();
            buttonRegistroClientes = new Button();
            buttonSubmenuClientes = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            panelContenedor = new Panel();
            pictureBox1 = new PictureBox();
            buttonSubmenuPagos = new Button();
            panelPagosSubmenu = new Panel();
            buttonConsultaPagos = new Button();
            buttonRegistroPagos = new Button();
            panelSideMenu.SuspendLayout();
            panelPrestamosSubmenu.SuspendLayout();
            panelClientesSubmenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPagosSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(51, 51, 51);
            panelSideMenu.Controls.Add(panelPagosSubmenu);
            panelSideMenu.Controls.Add(buttonSubmenuPagos);
            panelSideMenu.Controls.Add(panelPrestamosSubmenu);
            panelSideMenu.Controls.Add(buttonSubmenuPrestamos);
            panelSideMenu.Controls.Add(panelClientesSubmenu);
            panelSideMenu.Controls.Add(buttonSubmenuClientes);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(325, 712);
            panelSideMenu.TabIndex = 0;
            // 
            // panelPrestamosSubmenu
            // 
            panelPrestamosSubmenu.Controls.Add(buttonConsultaPrestamos);
            panelPrestamosSubmenu.Controls.Add(buttonRegistroPrestamos);
            panelPrestamosSubmenu.Dock = DockStyle.Top;
            panelPrestamosSubmenu.Location = new Point(0, 390);
            panelPrestamosSubmenu.Name = "panelPrestamosSubmenu";
            panelPrestamosSubmenu.Size = new Size(325, 121);
            panelPrestamosSubmenu.TabIndex = 4;
            // 
            // buttonConsultaPrestamos
            // 
            buttonConsultaPrestamos.BackColor = Color.FromArgb(85, 85, 85);
            buttonConsultaPrestamos.Dock = DockStyle.Top;
            buttonConsultaPrestamos.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            buttonConsultaPrestamos.FlatAppearance.BorderSize = 0;
            buttonConsultaPrestamos.FlatStyle = FlatStyle.Flat;
            buttonConsultaPrestamos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsultaPrestamos.ForeColor = Color.White;
            buttonConsultaPrestamos.Location = new Point(0, 60);
            buttonConsultaPrestamos.Name = "buttonConsultaPrestamos";
            buttonConsultaPrestamos.Padding = new Padding(35, 0, 0, 0);
            buttonConsultaPrestamos.Size = new Size(325, 60);
            buttonConsultaPrestamos.TabIndex = 1;
            buttonConsultaPrestamos.Text = "Consulta de Préstamos";
            buttonConsultaPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsultaPrestamos.UseVisualStyleBackColor = false;
            buttonConsultaPrestamos.Click += buttonConsultaPrestamos_Click;
            // 
            // buttonRegistroPrestamos
            // 
            buttonRegistroPrestamos.BackColor = Color.FromArgb(85, 85, 85);
            buttonRegistroPrestamos.Dock = DockStyle.Top;
            buttonRegistroPrestamos.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            buttonRegistroPrestamos.FlatAppearance.BorderSize = 0;
            buttonRegistroPrestamos.FlatStyle = FlatStyle.Flat;
            buttonRegistroPrestamos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistroPrestamos.ForeColor = Color.White;
            buttonRegistroPrestamos.Location = new Point(0, 0);
            buttonRegistroPrestamos.Name = "buttonRegistroPrestamos";
            buttonRegistroPrestamos.Padding = new Padding(35, 0, 0, 0);
            buttonRegistroPrestamos.Size = new Size(325, 60);
            buttonRegistroPrestamos.TabIndex = 0;
            buttonRegistroPrestamos.Text = "Registro de Préstamos";
            buttonRegistroPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistroPrestamos.UseVisualStyleBackColor = false;
            buttonRegistroPrestamos.Click += buttonRegistroPrestamos_Click;
            // 
            // buttonSubmenuPrestamos
            // 
            buttonSubmenuPrestamos.BackColor = Color.FromArgb(51, 51, 51);
            buttonSubmenuPrestamos.Dock = DockStyle.Top;
            buttonSubmenuPrestamos.FlatAppearance.BorderColor = Color.FromArgb(68, 68, 68);
            buttonSubmenuPrestamos.FlatAppearance.BorderSize = 0;
            buttonSubmenuPrestamos.FlatStyle = FlatStyle.Flat;
            buttonSubmenuPrestamos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmenuPrestamos.ForeColor = Color.White;
            buttonSubmenuPrestamos.Location = new Point(0, 330);
            buttonSubmenuPrestamos.Name = "buttonSubmenuPrestamos";
            buttonSubmenuPrestamos.Padding = new Padding(10, 0, 0, 0);
            buttonSubmenuPrestamos.Size = new Size(325, 60);
            buttonSubmenuPrestamos.TabIndex = 3;
            buttonSubmenuPrestamos.Text = "Préstamos";
            buttonSubmenuPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            buttonSubmenuPrestamos.UseVisualStyleBackColor = false;
            buttonSubmenuPrestamos.Click += buttonSubmenuPrestamos_Click;
            // 
            // panelClientesSubmenu
            // 
            panelClientesSubmenu.BackColor = Color.FromArgb(35, 32, 29);
            panelClientesSubmenu.Controls.Add(buttonConsultaClientes);
            panelClientesSubmenu.Controls.Add(buttonRegistroClientes);
            panelClientesSubmenu.Dock = DockStyle.Top;
            panelClientesSubmenu.Location = new Point(0, 210);
            panelClientesSubmenu.Name = "panelClientesSubmenu";
            panelClientesSubmenu.Size = new Size(325, 120);
            panelClientesSubmenu.TabIndex = 2;
            // 
            // buttonConsultaClientes
            // 
            buttonConsultaClientes.BackColor = Color.FromArgb(85, 85, 85);
            buttonConsultaClientes.Dock = DockStyle.Top;
            buttonConsultaClientes.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            buttonConsultaClientes.FlatAppearance.BorderSize = 0;
            buttonConsultaClientes.FlatStyle = FlatStyle.Flat;
            buttonConsultaClientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsultaClientes.ForeColor = Color.White;
            buttonConsultaClientes.Location = new Point(0, 60);
            buttonConsultaClientes.Name = "buttonConsultaClientes";
            buttonConsultaClientes.Padding = new Padding(35, 0, 0, 0);
            buttonConsultaClientes.Size = new Size(325, 60);
            buttonConsultaClientes.TabIndex = 1;
            buttonConsultaClientes.Text = "Consulta de Cliente";
            buttonConsultaClientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsultaClientes.UseVisualStyleBackColor = false;
            buttonConsultaClientes.Click += buttonConsultaClientes_Click;
            // 
            // buttonRegistroClientes
            // 
            buttonRegistroClientes.BackColor = Color.FromArgb(85, 85, 85);
            buttonRegistroClientes.Dock = DockStyle.Top;
            buttonRegistroClientes.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            buttonRegistroClientes.FlatAppearance.BorderSize = 0;
            buttonRegistroClientes.FlatStyle = FlatStyle.Flat;
            buttonRegistroClientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistroClientes.ForeColor = Color.White;
            buttonRegistroClientes.Location = new Point(0, 0);
            buttonRegistroClientes.Name = "buttonRegistroClientes";
            buttonRegistroClientes.Padding = new Padding(35, 0, 0, 0);
            buttonRegistroClientes.Size = new Size(325, 60);
            buttonRegistroClientes.TabIndex = 0;
            buttonRegistroClientes.Text = "Registro de Cliente";
            buttonRegistroClientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistroClientes.UseVisualStyleBackColor = false;
            buttonRegistroClientes.Click += buttonRegistroClientes_Click;
            // 
            // buttonSubmenuClientes
            // 
            buttonSubmenuClientes.BackColor = Color.FromArgb(51, 51, 51);
            buttonSubmenuClientes.Dock = DockStyle.Top;
            buttonSubmenuClientes.FlatAppearance.BorderColor = Color.FromArgb(68, 68, 68);
            buttonSubmenuClientes.FlatAppearance.BorderSize = 0;
            buttonSubmenuClientes.FlatStyle = FlatStyle.Flat;
            buttonSubmenuClientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmenuClientes.ForeColor = Color.White;
            buttonSubmenuClientes.Location = new Point(0, 150);
            buttonSubmenuClientes.Name = "buttonSubmenuClientes";
            buttonSubmenuClientes.Padding = new Padding(10, 0, 0, 0);
            buttonSubmenuClientes.Size = new Size(325, 60);
            buttonSubmenuClientes.TabIndex = 1;
            buttonSubmenuClientes.Text = "Clientes";
            buttonSubmenuClientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonSubmenuClientes.UseVisualStyleBackColor = false;
            buttonSubmenuClientes.Click += buttonSubmenuClientes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(325, 150);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.enterprise;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(325, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(325, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(933, 712);
            panelContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.enterprise;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(933, 712);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonSubmenuPagos
            // 
            buttonSubmenuPagos.BackColor = Color.FromArgb(51, 51, 51);
            buttonSubmenuPagos.Dock = DockStyle.Top;
            buttonSubmenuPagos.FlatAppearance.BorderColor = Color.FromArgb(68, 68, 68);
            buttonSubmenuPagos.FlatAppearance.BorderSize = 0;
            buttonSubmenuPagos.FlatStyle = FlatStyle.Flat;
            buttonSubmenuPagos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmenuPagos.ForeColor = Color.White;
            buttonSubmenuPagos.Location = new Point(0, 511);
            buttonSubmenuPagos.Name = "buttonSubmenuPagos";
            buttonSubmenuPagos.Padding = new Padding(10, 0, 0, 0);
            buttonSubmenuPagos.Size = new Size(325, 60);
            buttonSubmenuPagos.TabIndex = 5;
            buttonSubmenuPagos.Text = "Pagos";
            buttonSubmenuPagos.TextAlign = ContentAlignment.MiddleLeft;
            buttonSubmenuPagos.UseVisualStyleBackColor = false;
            buttonSubmenuPagos.Click += buttonSubmenuPagos_Click;
            // 
            // panelPagosSubmenu
            // 
            panelPagosSubmenu.Controls.Add(buttonConsultaPagos);
            panelPagosSubmenu.Controls.Add(buttonRegistroPagos);
            panelPagosSubmenu.Dock = DockStyle.Top;
            panelPagosSubmenu.Location = new Point(0, 571);
            panelPagosSubmenu.Name = "panelPagosSubmenu";
            panelPagosSubmenu.Size = new Size(325, 121);
            panelPagosSubmenu.TabIndex = 6;
            // 
            // buttonConsultaPagos
            // 
            buttonConsultaPagos.BackColor = Color.FromArgb(85, 85, 85);
            buttonConsultaPagos.Dock = DockStyle.Top;
            buttonConsultaPagos.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            buttonConsultaPagos.FlatAppearance.BorderSize = 0;
            buttonConsultaPagos.FlatStyle = FlatStyle.Flat;
            buttonConsultaPagos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsultaPagos.ForeColor = Color.White;
            buttonConsultaPagos.Location = new Point(0, 60);
            buttonConsultaPagos.Name = "buttonConsultaPagos";
            buttonConsultaPagos.Padding = new Padding(35, 0, 0, 0);
            buttonConsultaPagos.Size = new Size(325, 60);
            buttonConsultaPagos.TabIndex = 1;
            buttonConsultaPagos.Text = "Consulta de Préstamos";
            buttonConsultaPagos.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsultaPagos.UseVisualStyleBackColor = false;
            // 
            // buttonRegistroPagos
            // 
            buttonRegistroPagos.BackColor = Color.FromArgb(85, 85, 85);
            buttonRegistroPagos.Dock = DockStyle.Top;
            buttonRegistroPagos.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            buttonRegistroPagos.FlatAppearance.BorderSize = 0;
            buttonRegistroPagos.FlatStyle = FlatStyle.Flat;
            buttonRegistroPagos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistroPagos.ForeColor = Color.White;
            buttonRegistroPagos.Location = new Point(0, 0);
            buttonRegistroPagos.Name = "buttonRegistroPagos";
            buttonRegistroPagos.Padding = new Padding(35, 0, 0, 0);
            buttonRegistroPagos.Size = new Size(325, 60);
            buttonRegistroPagos.TabIndex = 0;
            buttonRegistroPagos.Text = "Registro de Préstamos";
            buttonRegistroPagos.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistroPagos.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1258, 712);
            Controls.Add(panelContenedor);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 718);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Empresa";
            panelSideMenu.ResumeLayout(false);
            panelPrestamosSubmenu.ResumeLayout(false);
            panelClientesSubmenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPagosSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelClientesSubmenu;
        private Button buttonSubmenuClientes;
        private Button buttonRegistroClientes;
        private Button buttonConsultaClientes;
        private Panel panelPrestamosSubmenu;
        private Button buttonConsultaPrestamos;
        private Button buttonRegistroPrestamos;
        private Button buttonSubmenuPrestamos;
        private Panel panelContenedor;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonSubmenuPagos;
        private Panel panelPagosSubmenu;
        private Button buttonConsultaPagos;
        private Button buttonRegistroPagos;
    }
}