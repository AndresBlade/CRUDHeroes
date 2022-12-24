using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Heroes
{


    public partial class RegistroPersonaje : Form
    {

        private const int EM_SETCUEBANNER = 0x1501;
        private Personaje personaje = new Personaje();
        public static RegistroPersonaje instance;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public RegistroPersonaje()
        {
            InitializeComponent();
            agregarOpcionesSexoPersonaje();
            agregarOpcionesActitudPersonaje();
            agregarOpcionesUniversoPersonaje();
            colocarBotonesDefecto();
            instance = this;

            textBoxNombrePersonaje.DataBindings.Add("Text", personaje, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxSexoPersonaje.DataBindings.Add("SelectedItem", personaje, "Sexo", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxActitudPersonaje.DataBindings.Add("SelectedItem", personaje, "Actitud", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxIdentidadSecretaPersonaje.DataBindings.Add("Text", personaje, "IdentidadSecreta", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxUniversoPersonaje.DataBindings.Add("SelectedItem", personaje, "Universo", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownEdadPersonaje.DataBindings.Add("Value", personaje, "Edad", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxActivoPersonaje.DataBindings.Add("Checked", personaje, "Activo", false, DataSourceUpdateMode.OnPropertyChanged);

             



            SendMessage(textBoxNombrePersonaje.Handle, EM_SETCUEBANNER, 0, "Ingrese un nombre");
            SendMessage(textBoxIdentidadSecretaPersonaje.Handle, EM_SETCUEBANNER, 0, "Ingrese un nombre secreto");
        }

        

        public void colocarBotonesDefecto()
        {
            
            buttonCrearPersonaje.Enabled = false;
            buttonEliminarPersonaje.Enabled = false;
            buttonActualizarPersonaje.Enabled = false;
        }

        public void colocarBotonesActivos()
        {
            buttonCrearPersonaje.Enabled = true;
            buttonEliminarPersonaje.Enabled = true;
            buttonActualizarPersonaje.Enabled = true;
        }

        public void activo()
        {
            checkBoxActivoPersonaje.Checked = true;
        }

        

        private void agregarOpcionesSexoPersonaje()
        {
            comboBoxSexoPersonaje.Items.AddRange(new object[] {Sexo.Masculino, Sexo.Femenino, Sexo.Desconocido});
            comboBoxSexoPersonaje.SelectedIndex = 0;
        }

        private void agregarOpcionesActitudPersonaje()
        {
            comboBoxActitudPersonaje.Items.AddRange(new object[] { Actitud.Heroe, Actitud.Villano, Actitud.Antivillano });
            comboBoxActitudPersonaje.SelectedIndex = 0;
        }

        private void agregarOpcionesUniversoPersonaje()
        {
            comboBoxUniversoPersonaje.Items.AddRange(new object[] { Universo.Marvel, Universo.DC });
            comboBoxUniversoPersonaje.SelectedIndex = 0;
        }

        private void comboBoxSexoPersonaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sexo sexo = (Sexo)comboBoxSexoPersonaje.SelectedItem; 
        }

        private void buttonCrearPersonaje_Click(object sender, EventArgs e)
        {
            string directorio = Path.Combine(Application.StartupPath, "img");
            Directory.CreateDirectory(directorio);
            FileStream fileStream = new FileStream(@$"{Path.Combine(Application.StartupPath, "img")}/personaje1.jpg", FileMode.Create, FileAccess.Write);
            pictureBoxImagenPersonaje.Image.Save(fileStream, ImageFormat.Jpeg);
        }

        private void buttonBuscarPersonaje_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonannadirImagen_Click(object sender, EventArgs e)
        {
            openFileDialogImagenPersonaje.Filter = "Imagenes|*.jpg; *.png";
            openFileDialogImagenPersonaje.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialogImagenPersonaje.Title = "Seleccionar Imagen";

            if (openFileDialogImagenPersonaje.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagenPersonaje.Image = Image.FromFile(openFileDialogImagenPersonaje.FileName);
            }
        }
    }
}
