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



namespace Empresa
{


    public partial class RegistroCliente : Form
    {
        //Función que permite agregar Placeholder a los textbox
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private Cliente cliente = new Cliente();
        public BindingList<Cliente> clientes;
        //public bool PersonajeFueBuscado { get; set; }
        private string nombreBuscado = string.Empty;

        //Para poder manejar al form desde fuera
        public static RegistroCliente instance;

        public RegistroCliente()
        {
            InitializeComponent();
            ////Agrega opciones a los combobox
            //agregarOpcionesActitudPersonaje();
            //agregarOpcionesUniversoPersonaje();
            colocarBotonesDefecto();

            //Para poder acceder al formulario creado desde fuera
            instance = this;

            //PersonajeFueBuscado = false;

            #region Enlaces de datos
            //Establece una conexión entre la propiedad de un control y la propiedad de otro objeto o control.
            //se puede formatear el dato enlazado (parametro bool) y se puede disparar el evento de enlace cuando cambia la propiedad o cuando se valida

            textBoxNombreCliente.DataBindings.Add("Text", cliente, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            //comboBoxActitudPersonaje.DataBindings.Add("SelectedItem", cliente, "Actitud", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxApellidoCliente.DataBindings.Add("Text", cliente, "Apellido", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxDireccionCliente.DataBindings.Add("Text", cliente, "Direccion", false, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePickerFechaNacimientoCliente.DataBindings.Add("Value", cliente, "FechaNacimiento", true, DataSourceUpdateMode.OnPropertyChanged);
            //comboBoxUniversoPersonaje.DataBindings.Add("SelectedItem", cliente, "Universo", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownCedulaCliente.DataBindings.Add("Value", cliente, "Cedula", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxImagenCliente.DataBindings.Add("Image", cliente, "Imagen", true, DataSourceUpdateMode.OnPropertyChanged);
            //cliente.Edad = 12;

            #endregion

            //Crear placeholder para los textbox
            SendMessage(textBoxNombreCliente.Handle, EM_SETCUEBANNER, 0, "Ingrese el nombre");
            SendMessage(textBoxApellidoCliente.Handle, EM_SETCUEBANNER, 0, "Ingrese el apellido");
            SendMessage(textBoxDireccionCliente.Handle, EM_SETCUEBANNER, 0, "Ingrese la dirección");

            inicializarListaClientes();
        }

        private void inicializarListaClientes()
        {
            //clientes = Serializador.DeserializarPersonajes();
            clientes = new BindingList<Cliente>();
            clientes.AllowEdit = true;
            clientes.AllowNew = true;
            clientes.AllowRemove = true;

            clientes.AddingNew += clientes_AddingNew;
        }

        private void clientes_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Cliente
            {
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Cedula = cliente.Cedula,
                FechaNacimiento = cliente.FechaNacimiento,
                //FechaRegistro = cliente.FechaRegistro,
                FechaRegistro = DateTime.Now,
                Imagen = cliente.Imagen,
                NumeroRegistro = clientes.ToArray<Cliente>().Length,
                Direccion = cliente.Direccion
            };
        }





        public void colocarBotonesDefecto()
        {

            buttonCrearCliente.Enabled = false;
            buttonEliminarCliente.Enabled = false;
            buttonActualizarCliente.Enabled = false;
        }
        //Coloca los controles a sus valores iniciales
        public void colocarControlesDefecto()
        {
            colocarBotonesDefecto();

            cliente.Nombre = string.Empty;
            cliente.Apellido = string.Empty;
            cliente.Cedula = 0;
            cliente.FechaNacimiento = DateTime.Now;
            cliente.FechaRegistro = DateTime.Now;
            cliente.NumeroRegistro = 0;
            cliente.Direccion = string.Empty;
            cliente.Imagen = null;
        }

        public void colocarBotonesActivos()
        {
            if (nombreBuscado == cliente.Nombre)
            {
                //Si busco un cliente y modifico el nombre y luego deshago la modificacion, mantén el botón de crear deshabilitado

                buttonCrearCliente.Enabled = false;
                buttonActualizarCliente.Enabled = true;
                buttonEliminarCliente.Enabled = true;
                return;
            }
            buttonCrearCliente.Enabled = true;
            buttonActualizarCliente.Enabled = false;
            buttonEliminarCliente.Enabled = false;
        }

        //#region Opciones Combobox
        //private void agregarOpcionesActitudPersonaje()
        //{
        //    comboBoxActitudPersonaje.Items.AddRange(new object[] { Actitud.Heroe, Actitud.Villano, Actitud.Antiheroe });
        //    comboBoxActitudPersonaje.SelectedIndex = 0;
        //}

        //private void agregarOpcionesUniversoPersonaje()
        //{
        //    comboBoxUniversoPersonaje.Items.AddRange(new object[] { Universo.Marvel, Universo.DC });
        //    comboBoxUniversoPersonaje.SelectedIndex = 0;
        //}

        //#endregion
        private void buttonCrearCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = clientes.AddNew();

            int numRepeticiones = 0;

            foreach (Cliente clienteColeccion in clientes)
            {
                if (clienteColeccion.Nombre == nuevoCliente.Nombre)
                {
                    numRepeticiones++;
                }
            }

            if (numRepeticiones > 1)
            {
                MessageBox.Show("El nombre de este personaje ya existe. Si desea modificarlo o eliminarlo, Dele al botón de buscar, y luego pulse los respectivos botones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientes.CancelNew(clientes.IndexOf(nuevoCliente));
                return;
            }

            clientes.EndNew(clientes.IndexOf(nuevoCliente));

            guardarImagenCliente(nuevoCliente.Nombre);
            MessageBox.Show("Cliente creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Respaldo.GuardarClientes(clientes); //Cambio de ultimo momento
            colocarControlesDefecto();
        }

        private void guardarImagenCliente(string nombre)
        {
            string directorio = Application.StartupPath;
            string directorioImagen = Path.Combine(directorio, "img");

            //Creamos auxiliar para evitar lock por parte de windows
            Image auxiliarDeMemoria = new Bitmap(cliente.Imagen);
            Directory.CreateDirectory(directorioImagen);
            //SetPBoxImage(pictureBoxImagenPersonaje, (Bitmap)personaje.Imagen);
            cliente.Imagen.Dispose(); //Si utilizamos close() o le asignamos null, todavía mantiene el lock
            cliente.Imagen = null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            File.Delete($@"{directorioImagen}\{nombre}.jpg");
            auxiliarDeMemoria.Save($@"{directorioImagen}\{nombre}.jpg", ImageFormat.Jpeg);
            cliente.Imagen = auxiliarDeMemoria;

        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{personaje.Nombre} {personaje.Edad} {personaje.IdentidadSecreta} {personaje.Universo}");

            //Si buscas un nombre vacío
            if (cliente.Nombre == null)
            {
                MessageBox.Show("No se puede buscar un nombre vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si buscas un personaje, pero no hay ningún personaje creado
            if (clientes.Count == 0)
            {
                MessageBox.Show("No hay personajes registrados, por lo que no se podría encontrar alguno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cliente clienteBuscado = clientes.SingleOrDefault(clienteBuscado => clienteBuscado.Nombre == cliente.Nombre);


            //Si no consigues al personaje
            if (clienteBuscado == null)
            {
                MessageBox.Show("No se pudo encontrar al personaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //PersonajeFueBuscado = false;
                colocarControlesDefecto();
                return;
            }

            //PersonajeFueBuscado = true;

            nombreBuscado = clienteBuscado.Nombre;

            //Coloca los datos del personaje encontrado en la interfaz
            cliente.Nombre = clienteBuscado.Nombre;
            cliente.Apellido = clienteBuscado.Apellido;
            cliente.NumeroRegistro = clienteBuscado.NumeroRegistro;
            cliente.Cedula = clienteBuscado.Cedula;
            cliente.FechaNacimiento = clienteBuscado.FechaNacimiento;
            cliente.FechaRegistro = clienteBuscado.FechaRegistro;
            cliente.Direccion = clienteBuscado.Direccion;
            cliente.Imagen = Image.FromFile(@$"{Application.StartupPath}/img/{cliente.Nombre}.jpg");
        }

        private void buttonannadirImagen_Click(object sender, EventArgs e)
        {
            //Solo acepta imagenes
            openFileDialogImagenCliente.Filter = "Imagenes|*.jpg; *.png";
            //Ruta donde comienza el dialogo
            openFileDialogImagenCliente.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialogImagenCliente.Title = "Seleccionar Imagen";

            if (openFileDialogImagenCliente.ShowDialog() == DialogResult.OK)
            {
                cliente.Imagen = GetClone(openFileDialogImagenCliente.FileName);

            }
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {

            IReadOnlyList<Cliente> clientesAEliminar = clientes.Where(clienteABuscar => clienteABuscar.Nombre == cliente.Nombre).ToList();

            DialogResult dialogResult = MessageBox.Show("Esta acción eliminará al cliente del sistema y de los préstamos en los que aparece. Si este es el único cliente de algún préstamo, este será eliminado. ¿Estás seguro de querer eliminarlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Pelicula peliculaAEliminar = null;

            if (dialogResult == DialogResult.No) return;

            foreach (Cliente clienteAEliminar in clientesAEliminar)
            {
                clientes.Remove(clienteAEliminar);
            }

            BindingList<Pelicula> peliculas = new BindingList<Pelicula>();

            foreach (Pelicula pelicula in peliculas)
            {

                foreach (Cliente clienteAEliminar in clientesAEliminar)
                {
                    int indiceAEliminar = pelicula.Personajes.FindIndex(personajePelicula => personajePelicula.Nombre == cliente.Nombre);
                    if (indiceAEliminar < 0) continue;

                    pelicula.Personajes.RemoveAt(indiceAEliminar);

                    if (pelicula.Personajes.Count == 0)
                    {
                        peliculaAEliminar = pelicula;
                    }
                }
            }

            if (peliculaAEliminar != null)
            {
                //peliculas.RemoveAt(peliculas.ToList().FindIndex(pelicula => pelicula.Nombre == peliculaAEliminar.Nombre));
            }

            MessageBox.Show("Personaje eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string nombrePersonaje = cliente.Nombre;

            colocarControlesDefecto();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            File.Delete(@$"{Application.StartupPath}\img\{nombrePersonaje}.jpg");

            //Respaldo.GuardarPersonajes(clientes);


            //Respaldo.GuardarPeliculas(peliculas);

            nombreBuscado = string.Empty;
        }

        private void buttonActualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteAActualizar = clientes.ToList().Find(clienteABuscar => clienteABuscar.Nombre == cliente.Nombre);

            clienteAActualizar.Nombre = cliente.Nombre;
            clienteAActualizar.Apellido = cliente.Apellido;
            clienteAActualizar.Cedula = cliente.Cedula;
            clienteAActualizar.NumeroRegistro = cliente.NumeroRegistro;
            clienteAActualizar.FechaNacimiento = cliente.FechaNacimiento;

            clienteAActualizar.FechaRegistro = cliente.FechaRegistro;
            clienteAActualizar.Direccion = cliente.Direccion;


            guardarImagenCliente(cliente.Nombre);

            MessageBox.Show("Cliente actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            colocarControlesDefecto();

            //Respaldo.GuardarPersonajes(clientes);
        }

        //public void guardarPersonajes()
        //{
        //    if (personajes == null) return;
        //    string directorio = Application.StartupPath;
        //    FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.Create, FileAccess.Write);
        //    StreamWriter streamWriter = new StreamWriter(fileStream);

        //    streamWriter.WriteLine(Serializador.SerializarPersonajes(personajes));

        //    streamWriter.Close();
        //    fileStream.Close();
        //}

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
            //Respaldo.GuardarPersonajes(clientes);
        }

        void SetPBoxImage(PictureBox pbox, Bitmap bmp)
        {
            Bitmap dummy = (Bitmap)pbox.Image;
            pbox.Image = null;
            if (dummy != null) dummy.Dispose();
            pbox.Image = bmp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
