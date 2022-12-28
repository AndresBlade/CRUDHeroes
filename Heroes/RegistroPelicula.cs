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
            textBoxNombrePelicula.DataBindings.Add("Text", pelicula, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownAnnoPelicula.DataBindings.Add("Value", pelicula, "Anno", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownMontoRecaudado.DataBindings.Add("Value", pelicula, "MontoRecaudado", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxUniversoPelicula.DataBindings.Add("SelectedItem", pelicula, "Universo", true, DataSourceUpdateMode.OnPropertyChanged);
            //Falta combobox de personajes

        }

        private void buttonBuscarPelicula_Click(object sender, EventArgs e)
        {
            numericUpDownAnnoPelicula.Value = pelicula.MontoRecaudado;
        }

        private void buttonAnnadirDirector_Click(object sender, EventArgs e)
        {


            AgregarDirector formDirector = new AgregarDirector();

            DialogResult result = formDirector.ShowDialog();

            if (result != DialogResult.OK) return;

            if (pelicula.Directores.Contains(formDirector.NombreDirector))
            {
                MessageBox.Show("El director ya fue agregado anteriormente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Label labelDirectorNuevo = new Label();
            labelDirectorNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDirectorNuevo.ForeColor = System.Drawing.Color.White;
            labelDirectorNuevo.Location = new System.Drawing.Point(0, 0);
            labelDirectorNuevo.Name = "labelTitulo";
            labelDirectorNuevo.TabIndex = 1;
            labelDirectorNuevo.Dock = DockStyle.Left;
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

            panelDirectorNuevo.Controls.Add(labelDirectorNuevo);
            panelDirectorNuevo.Controls.Add(eliminarDirector);
            panelDirectorNuevo.Padding = new Padding(10, 0, 10, 0);

            panelModuloDirector.Controls.Add(panelDirectorNuevo);
            pelicula.Directores.Add(formDirector.NombreDirector);
        }

        private void buttonEliminarDirector_Click(object sender, EventArgs e)
        {
            Button botonEliminar = (Button)sender;
            Panel panelModulo = (Panel)botonEliminar.Parent.Parent;
            panelModulo.Controls.Remove(botonEliminar.Parent); //elimina al panel contenedor del label y boton de eliminar del director
            pelicula.Directores.Remove(botonEliminar.Parent.Controls[0].Text);
            botonEliminar.Parent.Dispose();

        }
    }
}
