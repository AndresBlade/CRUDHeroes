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
            personaje.Edad = 0;
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
            List<Personaje> personajes = Serializador.DeserializarPersonajes();
            //Busca el personaje que tenga el mismo nombre. Devuelve ese personaje o null si no lo consigue
            Personaje personajeBuscado = personajes.Find(personajeBuscado => personajeBuscado.Nombre == personaje.Nombre);

            //Directorio donde se encuentra el .exe
            string directorio = Application.StartupPath;
            //crea un directorio de imagenes donde se encuentra el .exe
            string directorioImagen = Path.Combine(Application.StartupPath, "img");
            Directory.CreateDirectory(directorioImagen);

            //Si el personaje ya existe
            if (personajeBuscado != null)
            {
                MessageBox.Show($"Ya existe un personaje con el nombre \"{personaje.Nombre}\". Si desea actualizar los datos del personaje, pulse \"Actualizar Personaje\". Si desea eliminarlos, pulse \"Eliminar Personaje\"", "No se puede crear Personaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            personajes.Add(personaje);
            //Guardar Imagen
            personaje.Imagen.Save(@$"{directorioImagen}/{personaje.Nombre}.jpg", ImageFormat.Jpeg);

            //Guardar personajes
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
            //MessageBox.Show($"{personaje.Nombre} {personaje.Edad} {personaje.IdentidadSecreta} {personaje.Universo}");

            //Si buscas un nombre vacío
            if (personaje.Nombre == null) {
                MessageBox.Show("No se puede buscar un nombre vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Personaje> personajes = Serializador.DeserializarPersonajes();

            //Si buscas un personaje, pero no hay ningún personaje creado
            if (personajes.Count == 0)
            {
                MessageBox.Show("No hay personajes registrados, por lo que no se podría encontrar alguno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Personaje personajeBuscado = personajes.Find(personajeBuscado => personajeBuscado.Nombre == personaje.Nombre);


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

            //Guardar nueva lista de personajes
            FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(Serializador.SerializarPersonajes(personajes));
            streamWriter.Close();
            fileStream.Close();

            string nombrePersonaje = personaje.Nombre;
            //Se elimina la imagen después de quitar la imagen del picture box. De otra forma, da error porque la imagen se está usando
            colocarControlesDefecto();
            //Limpiar recolector de basura, para evitar posibles errores
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            //Eliminar imagen
            File.Delete(@$"{Application.StartupPath}\img\{nombrePersonaje}.jpg");

            nombreBuscado = string.Empty;
        }

        private void buttonActualizarPersonaje_Click(object sender, EventArgs e)
        {
            List<Personaje> personajes = Serializador.DeserializarPersonajes();

            Personaje personajeAActualizar = personajes.Find(personajeABuscar => personajeABuscar.Nombre == personaje.Nombre);
            string directorio = Application.StartupPath;
            string directorioImagen = Path.Combine(directorio, "img");

            personajeAActualizar.Nombre = personaje.Nombre;
            personajeAActualizar.Edad = personaje.Edad;
            personajeAActualizar.Activo = personaje.Activo;
            personajeAActualizar.IdentidadSecreta = personaje.IdentidadSecreta;
            personajeAActualizar.Universo = personaje.Universo;
            personajeAActualizar.Sexo = personaje.Sexo;

            FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(Serializador.SerializarPersonajes(personajes));
            streamWriter.Dispose();
            fileStream.Dispose();


            //using (Bitmap bmp = (Bitmap)personaje.Imagen.Clone())
            //{
            //    bmp.Save(@$"{directorioImagen}\{personajeAActualizar.Nombre}.jpg", bmp.RawFormat);
            //}
            Bitmap auxiliar = new Bitmap(personaje.Imagen);

            personaje.Imagen.Dispose();
            colocarControlesDefecto();
            personajeAActualizar.Imagen.Dispose();

            Thread.Sleep(2000);

            MessageBox.Show("Personaje Actualizado Exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(@$"{directorioImagen}\{personajeAActualizar.Nombre}.jpg");
            File.Delete(@$"{directorioImagen}\{personajeAActualizar.Nombre}.jpg");
            
            auxiliar.Save(@$"{directorioImagen}\{personajeAActualizar.Nombre}.jpg", ImageFormat.Jpeg);

            auxiliar.Dispose();
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

        //private void guardarImagenPersonaje(string nombre)
        //{
        //    string directorio = Application.StartupPath;


        //    //Creamos auxiliar para evitar lock por parte de windows

        //     //Si utilizamos close() o le asignamos null, todavía mantiene el lock


        //}
    }
}
