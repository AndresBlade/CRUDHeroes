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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelPeliculasSubmenu = new System.Windows.Forms.Panel();
            this.buttonConsultaPeliculas = new System.Windows.Forms.Button();
            this.buttonRegistroPeliculas = new System.Windows.Forms.Button();
            this.buttonSubmenuPeliculas = new System.Windows.Forms.Button();
            this.panelPersonajesSubmenu = new System.Windows.Forms.Panel();
            this.buttonConsultaPersonajes = new System.Windows.Forms.Button();
            this.buttonRegistroPersonajes = new System.Windows.Forms.Button();
            this.buttonSubmenuPersonajes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelPeliculasSubmenu.SuspendLayout();
            this.panelPersonajesSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelSideMenu.Controls.Add(this.panelPeliculasSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonSubmenuPeliculas);
            this.panelSideMenu.Controls.Add(this.panelPersonajesSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonSubmenuPersonajes);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(325, 712);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelPeliculasSubmenu
            // 
            this.panelPeliculasSubmenu.Controls.Add(this.buttonConsultaPeliculas);
            this.panelPeliculasSubmenu.Controls.Add(this.buttonRegistroPeliculas);
            this.panelPeliculasSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPeliculasSubmenu.Location = new System.Drawing.Point(0, 390);
            this.panelPeliculasSubmenu.Name = "panelPeliculasSubmenu";
            this.panelPeliculasSubmenu.Size = new System.Drawing.Size(325, 150);
            this.panelPeliculasSubmenu.TabIndex = 4;
            // 
            // buttonConsultaPeliculas
            // 
            this.buttonConsultaPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonConsultaPeliculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConsultaPeliculas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonConsultaPeliculas.FlatAppearance.BorderSize = 0;
            this.buttonConsultaPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultaPeliculas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConsultaPeliculas.ForeColor = System.Drawing.Color.White;
            this.buttonConsultaPeliculas.Location = new System.Drawing.Point(0, 60);
            this.buttonConsultaPeliculas.Name = "buttonConsultaPeliculas";
            this.buttonConsultaPeliculas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonConsultaPeliculas.Size = new System.Drawing.Size(325, 60);
            this.buttonConsultaPeliculas.TabIndex = 1;
            this.buttonConsultaPeliculas.Text = "Consulta de Película";
            this.buttonConsultaPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultaPeliculas.UseVisualStyleBackColor = false;
            this.buttonConsultaPeliculas.Click += new System.EventHandler(this.buttonConsultaPeliculas_Click);
            // 
            // buttonRegistroPeliculas
            // 
            this.buttonRegistroPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonRegistroPeliculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegistroPeliculas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonRegistroPeliculas.FlatAppearance.BorderSize = 0;
            this.buttonRegistroPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroPeliculas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistroPeliculas.ForeColor = System.Drawing.Color.White;
            this.buttonRegistroPeliculas.Location = new System.Drawing.Point(0, 0);
            this.buttonRegistroPeliculas.Name = "buttonRegistroPeliculas";
            this.buttonRegistroPeliculas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRegistroPeliculas.Size = new System.Drawing.Size(325, 60);
            this.buttonRegistroPeliculas.TabIndex = 0;
            this.buttonRegistroPeliculas.Text = "Registro de Película";
            this.buttonRegistroPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistroPeliculas.UseVisualStyleBackColor = false;
            this.buttonRegistroPeliculas.Click += new System.EventHandler(this.buttonRegistroPeliculas_Click);
            // 
            // buttonSubmenuPeliculas
            // 
            this.buttonSubmenuPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonSubmenuPeliculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubmenuPeliculas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonSubmenuPeliculas.FlatAppearance.BorderSize = 0;
            this.buttonSubmenuPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmenuPeliculas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmenuPeliculas.ForeColor = System.Drawing.Color.White;
            this.buttonSubmenuPeliculas.Location = new System.Drawing.Point(0, 330);
            this.buttonSubmenuPeliculas.Name = "buttonSubmenuPeliculas";
            this.buttonSubmenuPeliculas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSubmenuPeliculas.Size = new System.Drawing.Size(325, 60);
            this.buttonSubmenuPeliculas.TabIndex = 3;
            this.buttonSubmenuPeliculas.Text = "Películas";
            this.buttonSubmenuPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmenuPeliculas.UseVisualStyleBackColor = false;
            this.buttonSubmenuPeliculas.Click += new System.EventHandler(this.buttonSubmenuPeliculas_Click);
            // 
            // panelPersonajesSubmenu
            // 
            this.panelPersonajesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.panelPersonajesSubmenu.Controls.Add(this.buttonConsultaPersonajes);
            this.panelPersonajesSubmenu.Controls.Add(this.buttonRegistroPersonajes);
            this.panelPersonajesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPersonajesSubmenu.Location = new System.Drawing.Point(0, 210);
            this.panelPersonajesSubmenu.Name = "panelPersonajesSubmenu";
            this.panelPersonajesSubmenu.Size = new System.Drawing.Size(325, 120);
            this.panelPersonajesSubmenu.TabIndex = 2;
            // 
            // buttonConsultaPersonajes
            // 
            this.buttonConsultaPersonajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonConsultaPersonajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConsultaPersonajes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonConsultaPersonajes.FlatAppearance.BorderSize = 0;
            this.buttonConsultaPersonajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultaPersonajes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConsultaPersonajes.ForeColor = System.Drawing.Color.White;
            this.buttonConsultaPersonajes.Location = new System.Drawing.Point(0, 60);
            this.buttonConsultaPersonajes.Name = "buttonConsultaPersonajes";
            this.buttonConsultaPersonajes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonConsultaPersonajes.Size = new System.Drawing.Size(325, 60);
            this.buttonConsultaPersonajes.TabIndex = 1;
            this.buttonConsultaPersonajes.Text = "Consulta de Personaje";
            this.buttonConsultaPersonajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultaPersonajes.UseVisualStyleBackColor = false;
            this.buttonConsultaPersonajes.Click += new System.EventHandler(this.buttonConsultaPersonajes_Click);
            // 
            // buttonRegistroPersonajes
            // 
            this.buttonRegistroPersonajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonRegistroPersonajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegistroPersonajes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonRegistroPersonajes.FlatAppearance.BorderSize = 0;
            this.buttonRegistroPersonajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroPersonajes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistroPersonajes.ForeColor = System.Drawing.Color.White;
            this.buttonRegistroPersonajes.Location = new System.Drawing.Point(0, 0);
            this.buttonRegistroPersonajes.Name = "buttonRegistroPersonajes";
            this.buttonRegistroPersonajes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRegistroPersonajes.Size = new System.Drawing.Size(325, 60);
            this.buttonRegistroPersonajes.TabIndex = 0;
            this.buttonRegistroPersonajes.Text = "Registro de Personaje";
            this.buttonRegistroPersonajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistroPersonajes.UseVisualStyleBackColor = false;
            this.buttonRegistroPersonajes.Click += new System.EventHandler(this.buttonRegistroPersonajes_Click);
            // 
            // buttonSubmenuPersonajes
            // 
            this.buttonSubmenuPersonajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonSubmenuPersonajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubmenuPersonajes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonSubmenuPersonajes.FlatAppearance.BorderSize = 0;
            this.buttonSubmenuPersonajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmenuPersonajes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmenuPersonajes.ForeColor = System.Drawing.Color.White;
            this.buttonSubmenuPersonajes.Location = new System.Drawing.Point(0, 150);
            this.buttonSubmenuPersonajes.Name = "buttonSubmenuPersonajes";
            this.buttonSubmenuPersonajes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSubmenuPersonajes.Size = new System.Drawing.Size(325, 60);
            this.buttonSubmenuPersonajes.TabIndex = 1;
            this.buttonSubmenuPersonajes.Text = "Personajes";
            this.buttonSubmenuPersonajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmenuPersonajes.UseVisualStyleBackColor = false;
            this.buttonSubmenuPersonajes.Click += new System.EventHandler(this.buttonSubmenuPersonajes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(325, 150);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Heroes.Properties.Resources.dc;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(325, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(933, 712);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Heroes.Properties.Resources.dc;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 712);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1258, 712);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociación de Superhéroes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelSideMenu.ResumeLayout(false);
            this.panelPeliculasSubmenu.ResumeLayout(false);
            this.panelPersonajesSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelPersonajesSubmenu;
        private Button buttonSubmenuPersonajes;
        private Button buttonRegistroPersonajes;
        private Button buttonConsultaPersonajes;
        private Panel panelPeliculasSubmenu;
        private Button buttonConsultaPeliculas;
        private Button buttonRegistroPeliculas;
        private Button buttonSubmenuPeliculas;
        private Panel panelContenedor;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}