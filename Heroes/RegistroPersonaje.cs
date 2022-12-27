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
        public bool PersonajeFueBuscado { get; set; }
        private string nombreBuscado = string.Empty;
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

            PersonajeFueBuscado = false;

            textBoxNombrePersonaje.DataBindings.Add("Text", personaje, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxSexoPersonaje.DataBindings.Add("SelectedItem", personaje, "Sexo", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxActitudPersonaje.DataBindings.Add("SelectedItem", personaje, "Actitud", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxIdentidadSecretaPersonaje.DataBindings.Add("Text", personaje, "IdentidadSecreta", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxUniversoPersonaje.DataBindings.Add("SelectedItem", personaje, "Universo", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownEdadPersonaje.DataBindings.Add("Value", personaje, "Edad", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxActivoPersonaje.DataBindings.Add("Checked", personaje, "Activo", false, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxImagenPersonaje.DataBindings.Add("Image", personaje, "Imagen", true, DataSourceUpdateMode.OnPropertyChanged);





            SendMessage(textBoxNombrePersonaje.Handle, EM_SETCUEBANNER, 0, "Ingrese un nombre");
            SendMessage(textBoxIdentidadSecretaPersonaje.Handle, EM_SETCUEBANNER, 0, "Ingrese un nombre secreto");
        }

        

        

        public void colocarBotonesDefecto()
        {
            
            buttonCrearPersonaje.Enabled = false;
            buttonEliminarPersonaje.Enabled = false;
            buttonActualizarPersonaje.Enabled = false;
        }

        public void colocarControlesDefecto()
        {
            buttonCrearPersonaje.Enabled = false;
            buttonEliminarPersonaje.Enabled = false;
            buttonActualizarPersonaje.Enabled = false;

            personaje.Nombre = string.Empty;
            personaje.Actitud = 0;
            personaje.Sexo = 0;
            personaje.Universo = 0;
            personaje.Edad = 0;
            personaje.IdentidadSecreta = string.Empty;
            personaje.Activo = false;
            personaje.Imagen = null;
        }

        public void colocarBotonesActivos()
        {

            if (nombreBuscado == personaje.Nombre)
            {

                buttonActualizarPersonaje.Enabled = true;
                buttonEliminarPersonaje.Enabled = true;
                buttonCrearPersonaje.Enabled = false;
                return;
            }
            buttonCrearPersonaje.Enabled = true;
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

        private void buttonCrearPersonaje_Click(object sender, EventArgs e)
        {
            List<Personaje> personajes = Serializador.DeserializarPersonajes();
            Personaje personajeBuscado = personajes.Find(personajeBuscado => personajeBuscado.Nombre == personaje.Nombre);

            string directorio = Application.StartupPath;
            string directorioImagen = Path.Combine(Application.StartupPath, "img");
            Directory.CreateDirectory(directorioImagen);

            if (personajeBuscado != null)
            {
                MessageBox.Show($"Ya existe un personaje con el nombre \"{personaje.Nombre}\". Si desea actualizar los datos del personaje, pulse \"Actualizar Personaje\". Si desea eliminarlos, pulse \"Eliminar Personaje\"", "No se puede crear Personaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            personajes.Add(personaje);
            //Guardar Imagen
            //FileStream fileStream = new FileStream(@$"{directorioImagen}/{personaje.Nombre}.jpg", FileMode.Create, FileAccess.Write);
            personaje.Imagen.Save(@$"{directorioImagen}/{personaje.Nombre}.jpg", ImageFormat.Jpeg);
            //fileStream.Close();
            FileStream fileStream2 = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream2);
            streamWriter.WriteLine(Serializador.SerializarPersonajes(personajes));
            streamWriter.Close();
            fileStream2.Close();

            MessageBox.Show("Personaje creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            colocarControlesDefecto();
            
        }

        private void buttonBuscarPersonaje_Click(object sender, EventArgs e)
        {

            if (personaje.Nombre == null) {
                MessageBox.Show("No se puede buscar un nombre vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Personaje> personajes = Serializador.DeserializarPersonajes();

            if (personajes.Count == 0)
            {
                MessageBox.Show("No hay personajes registrados, por lo que no se podría encontrar alguno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Personaje personajeBuscado = personajes.Find(personajeBuscado => personajeBuscado.Nombre == personaje.Nombre);



            if (personajeBuscado == null)
            {
                MessageBox.Show("No se pudo encontrar al personaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PersonajeFueBuscado = false;
                return;
            }

            PersonajeFueBuscado = true;
            nombreBuscado = personajeBuscado.Nombre;
            personaje.Nombre = personajeBuscado.Nombre;
            personaje.Sexo = personajeBuscado.Sexo;
            personaje.Actitud = personajeBuscado.Actitud;
            personaje.IdentidadSecreta = personajeBuscado.IdentidadSecreta;
            personaje.Universo = personajeBuscado.Universo;
            personaje.Edad = personajeBuscado.Edad;
            personaje.Activo = personajeBuscado.Activo;
            personaje.Imagen = Image.FromFile(@$"{Application.StartupPath}/img/{personaje.Nombre}.jpg");
        }

        private void buttonannadirImagen_Click(object sender, EventArgs e)
        {
            openFileDialogImagenPersonaje.Filter = "Imagenes|*.jpg; *.png";
            openFileDialogImagenPersonaje.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialogImagenPersonaje.Title = "Seleccionar Imagen";

            if (openFileDialogImagenPersonaje.ShowDialog() == DialogResult.OK)
            {
                personaje.Imagen = Image.FromFile(openFileDialogImagenPersonaje.FileName);
            }
        }

        private void buttonEliminarPersonaje_Click(object sender, EventArgs e)
        {

            List<Personaje> personajes = Serializador.DeserializarPersonajes();

            int indicePersonajeAEliminar = personajes.FindIndex(personajeBuscado => personajeBuscado.Nombre == personaje.Nombre);
            if (indicePersonajeAEliminar < 0)
            {
                MessageBox.Show("No se puede eliminar un personaje que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            personajes.RemoveAt(indicePersonajeAEliminar);

            MessageBox.Show("Personaje eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string directorio = Application.StartupPath;
            FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(Serializador.SerializarPersonajes(personajes));
            streamWriter.Close();
            fileStream.Close();
            string nombrePersonaje = personaje.Nombre;
            colocarControlesDefecto();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(@$"{Application.StartupPath}\img\{nombrePersonaje}.jpg");
            nombreBuscado = string.Empty;
        }

        private void buttonActualizarPersonaje_Click(object sender, EventArgs e)
        {

        }
    }
}
