using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace Heroes
{


    public partial class RegistroPersonaje : Form
    {
        //Función que permite agregar Placeholder a los textbox
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);



        private Personaje personaje = new Personaje();
        private BindingList<Personaje> personajes;
        //public bool PersonajeFueBuscado { get; set; }
        private string nombreBuscado = string.Empty;

        //Para poder manejar al form desde fuera
        public static RegistroPersonaje instance;

        public RegistroPersonaje()
        {
            InitializeComponent();
            //Agrega opciones a los combobox
            agregarOpcionesSexoPersonaje();
            agregarOpcionesActitudPersonaje();
            agregarOpcionesUniversoPersonaje();
            colocarBotonesDefecto();

            //Para poder acceder al formulario creado desde fuera
            instance = this;

            //PersonajeFueBuscado = false;

            #region Enlaces de datos
            //Establece una conexión entre la propiedad de un control y la propiedad de otro objeto o control.
            //se puede formatear el dato enlazado (parametro bool) y se puede disparar el evento de enlace cuando cambia la propiedad o cuando se valida

            textBoxNombrePersonaje.DataBindings.Add("Text", personaje, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxSexoPersonaje.DataBindings.Add("SelectedItem", personaje, "Sexo", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxActitudPersonaje.DataBindings.Add("SelectedItem", personaje, "Actitud", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxIdentidadSecretaPersonaje.DataBindings.Add("Text", personaje, "IdentidadSecreta", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxUniversoPersonaje.DataBindings.Add("SelectedItem", personaje, "Universo", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownEdadPersonaje.DataBindings.Add("Value", personaje, "Edad", true, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxActivoPersonaje.DataBindings.Add("Checked", personaje, "Activo", false, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxImagenPersonaje.DataBindings.Add("Image", personaje, "Imagen", true, DataSourceUpdateMode.OnPropertyChanged);

            #endregion

            //Crear placeholder para los textbox
            SendMessage(textBoxNombrePersonaje.Handle, EM_SETCUEBANNER, 0, "Ingrese un nombre");
            SendMessage(textBoxIdentidadSecretaPersonaje.Handle, EM_SETCUEBANNER, 0, "Ingrese un nombre secreto");

            inicializarListaPersonajes();
        }

        private void inicializarListaPersonajes()
        {
            personajes = Serializador.DeserializarPersonajes();
            personajes.AllowEdit = true;
            personajes.AllowNew = true;
            personajes.AllowRemove = true;

            personajes.AddingNew += personajes_AddingNew;
        }

        private void personajes_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Personaje
            {
                Nombre = personaje.Nombre,
                Actitud = personaje.Actitud,
                Activo = personaje.Activo,
                Edad = personaje.Edad,
                IdentidadSecreta = personaje.IdentidadSecreta,
                Imagen = personaje.Imagen,
                Sexo = personaje.Sexo,
                Universo = personaje.Universo
            };
        }

        

        

        public void colocarBotonesDefecto()
        {
            
            buttonCrearPersonaje.Enabled = false;
            buttonEliminarPersonaje.Enabled = false;
            buttonActualizarPersonaje.Enabled = false;
        }
        //Coloca los controles a sus valores iniciales
        public void colocarControlesDefecto()
        {
            colocarBotonesDefecto();

            personaje.Nombre = string.Empty;
            personaje.Actitud = 0;
            personaje.Sexo = 0;
            personaje.Universo = 0;
            personaje.Edad = 12;
            personaje.IdentidadSecreta = string.Empty;
            personaje.Activo = false;
            personaje.Imagen = null;
        }

        public void colocarBotonesActivos()
        {
            if (nombreBuscado == personaje.Nombre)
            {
            //Si busco un personaje y modifico el nombre y luego deshago la modificacion, mantén el botón de crear deshabilitado

                buttonCrearPersonaje.Enabled = false;
                buttonActualizarPersonaje.Enabled = true;
                buttonEliminarPersonaje.Enabled = true;
                return;
            }
            buttonCrearPersonaje.Enabled = true;
            buttonActualizarPersonaje.Enabled = false;
            buttonEliminarPersonaje.Enabled = false;
        }

        #region Opciones Combobox

        private void agregarOpcionesSexoPersonaje()
        {
            comboBoxSexoPersonaje.Items.AddRange(new object[] {Sexo.Masculino, Sexo.Femenino, Sexo.Desconocido});
            comboBoxSexoPersonaje.SelectedIndex = 0;
        }

        private void agregarOpcionesActitudPersonaje()
        {
            comboBoxActitudPersonaje.Items.AddRange(new object[] { Actitud.Heroe, Actitud.Villano, Actitud.Antiheroe });
            comboBoxActitudPersonaje.SelectedIndex = 0;
        }

        private void agregarOpcionesUniversoPersonaje()
        {
            comboBoxUniversoPersonaje.Items.AddRange(new object[] { Universo.Marvel, Universo.DC });
            comboBoxUniversoPersonaje.SelectedIndex = 0;
        }

        #endregion
        private void buttonCrearPersonaje_Click(object sender, EventArgs e)
        {
            Personaje nuevoPersonaje = personajes.AddNew();

            int numRepeticiones = 0;

            foreach (Personaje personajeColeccion in personajes)
            {
                if (personajeColeccion.Nombre == nuevoPersonaje.Nombre)
                {
                    numRepeticiones++;
                }
            }

            if (numRepeticiones > 1)
            {
                MessageBox.Show("El nombre de este personaje ya existe. Si desea modificarlo o eliminarlo, Dele al botón de buscar, y luego pulse los respectivos botones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personajes.CancelNew(personajes.IndexOf(nuevoPersonaje));
                return;
            }

            personajes.EndNew(personajes.IndexOf(nuevoPersonaje));

            guardarImagenPersonaje(nuevoPersonaje.Nombre);
            MessageBox.Show("Película creada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            guardarPersonajes(); //Cambio de ultimo momento
            colocarControlesDefecto();
        }

        private void guardarImagenPersonaje(string nombre)
        {
            string directorio = Application.StartupPath;
            string directorioImagen = Path.Combine(directorio, "img");

            //Creamos auxiliar para evitar lock por parte de windows
            Image auxiliarDeMemoria = new Bitmap(personaje.Imagen);
            Directory.CreateDirectory(directorioImagen);
            //SetPBoxImage(pictureBoxImagenPersonaje, (Bitmap)personaje.Imagen);
            personaje.Imagen.Dispose(); //Si utilizamos close() o le asignamos null, todavía mantiene el lock
            personaje.Imagen = null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            File.Delete($@"{directorioImagen}\{nombre}.jpg");
            auxiliarDeMemoria.Save($@"{directorioImagen}\{nombre}.jpg", ImageFormat.Jpeg);
            personaje.Imagen = auxiliarDeMemoria;

        }

        private void buttonBuscarPersonaje_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{personaje.Nombre} {personaje.Edad} {personaje.IdentidadSecreta} {personaje.Universo}");

            //Si buscas un nombre vacío
            if (personaje.Nombre == null) {
                MessageBox.Show("No se puede buscar un nombre vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si buscas un personaje, pero no hay ningún personaje creado
            if (personajes.Count == 0)
            {
                MessageBox.Show("No hay personajes registrados, por lo que no se podría encontrar alguno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Personaje personajeBuscado = personajes.SingleOrDefault(personajeBuscado => personajeBuscado.Nombre == personaje.Nombre);


            //Si no consigues al personaje
            if (personajeBuscado == null)
            {
                MessageBox.Show("No se pudo encontrar al personaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //PersonajeFueBuscado = false;
                colocarControlesDefecto();
                return;
            }

            //PersonajeFueBuscado = true;

            nombreBuscado = personajeBuscado.Nombre;
            
            //Coloca los datos del personaje encontrado en la interfaz
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
            //Solo acepta imagenes
            openFileDialogImagenPersonaje.Filter = "Imagenes|*.jpg; *.png";
            //Ruta donde comienza el dialogo
            openFileDialogImagenPersonaje.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialogImagenPersonaje.Title = "Seleccionar Imagen";

            if (openFileDialogImagenPersonaje.ShowDialog() == DialogResult.OK)
            {
                personaje.Imagen = GetClone(openFileDialogImagenPersonaje.FileName);
                
            }
        }

        private void buttonEliminarPersonaje_Click(object sender, EventArgs e)
        {

            IReadOnlyList<Personaje> personajesAEliminar = personajes.Where(personajeABuscar => personajeABuscar.Nombre == personaje.Nombre).ToList();

            foreach(Personaje personajeAEliminar in personajesAEliminar)
            {
                personajes.Remove(personajeAEliminar);
            }

            personajesAEliminar = null;

            MessageBox.Show("Personaje eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string nombrePersonaje = personaje.Nombre;

            colocarControlesDefecto();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            File.Delete(@$"{Application.StartupPath}\img\{nombrePersonaje}.jpg");

            guardarPersonajes();

            nombreBuscado = string.Empty;
        }

        private void buttonActualizarPersonaje_Click(object sender, EventArgs e)
        {
            Personaje personajeAActualizar = personajes.ToList().Find(personajeABuscar => personajeABuscar.Nombre == personaje.Nombre);

            personajeAActualizar.Nombre = personaje.Nombre;
            personajeAActualizar.Edad = personaje.Edad;
            personajeAActualizar.Sexo = personaje.Sexo;
            personajeAActualizar.Universo = personaje.Universo;
            personajeAActualizar.Actitud = personaje.Actitud;

            personajeAActualizar.IdentidadSecreta = personaje.IdentidadSecreta;
            personajeAActualizar.Activo = personaje.Activo;


            guardarImagenPersonaje(personaje.Nombre);

            MessageBox.Show("Personaje actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            colocarControlesDefecto();

            guardarPersonajes();
        }

        public void guardarPersonajes()
        {
            if (personajes == null) return;
            string directorio = Application.StartupPath;
            FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(Serializador.SerializarPersonajes(personajes));

            streamWriter.Close();
            fileStream.Close();
        }

        private Bitmap GetClone(string imageName)
        {
            if (!File.Exists(imageName)) return null;
            Bitmap bmp2 = null;
            using (Bitmap bmp = (Bitmap)Bitmap.FromFile(imageName))
            {
                bmp2 = new Bitmap(bmp.Width, bmp.Height, bmp.PixelFormat);
                bmp2.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
                using (Graphics g = Graphics.FromImage(bmp2))
                {
                    g.DrawImage(bmp, 0, 0);
                }
            }
            return bmp2;
        }

        private void RegistroPersonaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarPersonajes();
        }

        void SetPBoxImage(PictureBox pbox, Bitmap bmp)
        {
            Bitmap dummy = (Bitmap)pbox.Image;
            pbox.Image = null;
            if (dummy != null) dummy.Dispose();
            pbox.Image = bmp;
        }
    }
}
