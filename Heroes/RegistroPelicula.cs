using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heroes
{
    public partial class RegistroPelicula : Form
    {
        //Para poder manejar la instancia del formulario desde fuera
        public static RegistroPelicula instance;
        //Función y datos para agregar placeholder a los textbox
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private Pelicula pelicula = new Pelicula();
        public RegistroPelicula()
        {
            InitializeComponent();
            instance = this;
            SendMessage(textBoxNombrePelicula.Handle, EM_SETCUEBANNER, 0, "Ingrese el nombre de la película");

            #region Enlaces de datos
            textBoxNombrePelicula.DataBindings.Add("Text", pelicula, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownAnnoPelicula.DataBindings.Add("Value", pelicula, "Anno", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownMontoRecaudado.DataBindings.Add("Value", pelicula, "MontoRecaudado", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxUniversoPelicula.DataBindings.Add("SelectedItem", pelicula, "Universo", true, DataSourceUpdateMode.OnPropertyChanged);
            //TODO: Hacer combobox de personajes
            #endregion

        }

        private void buttonBuscarPelicula_Click(object sender, EventArgs e)
        {
        }

        private void buttonAnnadirDirector_Click(object sender, EventArgs e)
        {
            //Función que annade director al panel de directores
            AgregarDirector formDirector = new AgregarDirector(); //Form para recibir el nombre del director

            DialogResult result = formDirector.ShowDialog();

            if (result != DialogResult.OK) return; //Si le dieron a cancelar o cerraron la ventana, no hacer nada

            if (pelicula.Directores.Contains(formDirector.NombreDirector))
            {
                MessageBox.Show("El director ya fue agregado anteriormente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Label labelDirectorNuevo = new Label(); //Label que contiene el nombre del director
            labelDirectorNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDirectorNuevo.ForeColor = System.Drawing.Color.White;
            labelDirectorNuevo.Location = new System.Drawing.Point(0, 0);
            labelDirectorNuevo.Name = "labelTitulo";
            labelDirectorNuevo.TabIndex = 1;
            labelDirectorNuevo.Dock = DockStyle.Left; //Anclarlo a la izquierda de su contenedor
            labelDirectorNuevo.Text = formDirector.NombreDirector;
            labelDirectorNuevo.Name = $"labelDirectorNuevo{formDirector.NombreDirector}";
            labelDirectorNuevo.SetBounds(0, 0, 100, 25);

            Button eliminarDirector = new Button();
            eliminarDirector.Name = $"buttonDirectorNuevo{formDirector.NombreDirector}";
            eliminarDirector.Dock = DockStyle.Right;
            eliminarDirector.Dock = System.Windows.Forms.DockStyle.Right;
            eliminarDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            eliminarDirector.UseVisualStyleBackColor = true;
            eliminarDirector.Image = Image.FromFile(@$"{Application.StartupPath}botonEliminar.png");
            eliminarDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            eliminarDirector.Size = new Size(25, 25);
            eliminarDirector.Click += new EventHandler(buttonEliminarDirector_Click);

            Panel panelDirectorNuevo = new Panel();
            panelDirectorNuevo.Dock = DockStyle.Top;
            panelDirectorNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            panelDirectorNuevo.Name = $"PanelDirector{formDirector.NombreDirector}";
            panelDirectorNuevo.SetBounds(0, 100, 100, 25);

            //Agregar boton de eliminar y label de director a panel contenedor 

            panelDirectorNuevo.Controls.Add(labelDirectorNuevo);
            panelDirectorNuevo.Controls.Add(eliminarDirector);
            panelDirectorNuevo.Padding = new Padding(10, 0, 10, 0);

            //agregar panel contenedor a módulo de contenedores

            panelModuloDirector.Controls.Add(panelDirectorNuevo);

            pelicula.Directores.Add(formDirector.NombreDirector);
        }

        private void buttonEliminarDirector_Click(object sender, EventArgs e)
        {
            //Obtiene el botón de eliminar que fue clickeado, para eliminar su contenedor
            Button botonEliminar = (Button)sender;
            Panel panelModulo = (Panel)botonEliminar.Parent.Parent;
            panelModulo.Controls.Remove(botonEliminar.Parent); //elimina al panel contenedor del label y boton de eliminar del director
            pelicula.Directores.Remove(botonEliminar.Parent.Controls[0].Text); //elimina el director de la pelicula
            botonEliminar.Parent.Dispose();

        }
    }
}
