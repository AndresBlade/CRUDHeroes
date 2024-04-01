using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{

	//TODO: Al buscar, como se están modificando los datos del mismo objeto de película, se modifica la pelicula de la lista, haciendo que siempre la encuentra
	//Hay que usar o una binding list o eliminar el atributo pelicula global y usarlo de forma local en cada una de las funciones que lo requieren
	public partial class RegistroPelicula : Form
	{
		//Para poder manejar la instancia del formulario desde fuera
		public static RegistroPelicula instance;

		public BindingList<Pelicula> peliculas;
		//Función y datos para agregar placeholder a los textbox
		private const int EM_SETCUEBANNER = 0x1501;

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

		private string nombreBuscado = string.Empty;

		private Pelicula pelicula = new Pelicula();
		public RegistroPelicula()
		{
			InitializeComponent();
			instance = this;
			SendMessage(textBoxNombrePelicula.Handle, EM_SETCUEBANNER, 0, "Ingrese el nombre de la película");

			checkedListBoxPersonajes.CheckOnClick = true; // Para checkear con click en vez de double click

			#region Enlaces de datos
			textBoxNombrePelicula.DataBindings.Add("Text", pelicula, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
			numericUpDownAnnoPelicula.DataBindings.Add("Value", pelicula, "Anno", true, DataSourceUpdateMode.OnPropertyChanged);
			numericUpDownMontoRecaudado.DataBindings.Add("Value", pelicula, "MontoRecaudado", true, DataSourceUpdateMode.OnPropertyChanged);
			comboBoxUniversoPelicula.DataBindings.Add("SelectedItem", pelicula, "Universo", true, DataSourceUpdateMode.OnPropertyChanged);
			pictureBoxImagenPelicula.DataBindings.Add("Image", pelicula, "Imagen", true, DataSourceUpdateMode.OnPropertyChanged);
			//TODO: Hacer combobox de personajes
			#endregion

			agregarOpcionesUniversoPelicula();

			ColocarBotonesDefecto();

			inicializarListaPeliculas();
		}

		private void inicializarListaPeliculas()
		{
            //peliculas = Serializador.DeserializarPeliculas();
            peliculas = new BindingList<Pelicula>();
            peliculas.AllowNew = true;
			peliculas.AllowEdit = false;
			peliculas.AllowRemove = true;
			peliculas.RaiseListChangedEvents = true;

			peliculas.AddingNew += peliculas_AddingNew;
		}

		private void peliculas_AddingNew(object sender, AddingNewEventArgs e)
		{
			e.NewObject = new Pelicula {
				Nombre = pelicula.Nombre,
				Anno = pelicula.Anno,
				MontoRecaudado = pelicula.MontoRecaudado,
				Imagen = pelicula.Imagen,
				Universo = pelicula.Universo,
				Directores = clonDirectores(pelicula.Directores),
				Personajes = clonClientes(pelicula.Personajes)

			};
		}

		private List<string> clonDirectores(List<string> directores) {
			List<string> clon = new List<string>();

			foreach (string director in directores)
			{
				clon.Add(director);
			}

			return clon;
		}

		private List<Cliente> clonClientes(List<Cliente>clientes)
		{
			List<Cliente> clon = new List<Cliente>();

			foreach(Cliente cliente in clientes)
			{
				clon.Add(cliente);
			}

			return clon;
		}

		public void ColocarBotonesDefecto()
		{
			buttonCrearPelicula.Enabled = false;
			buttonActualizarPelicula.Enabled = false;
			buttonEliminarPelicula.Enabled = false;
		}

		public void ColocarControlesDefecto()
		{
			pelicula.Nombre = string.Empty;
			pelicula.Anno = 1800;
			pelicula.Directores.Clear();
			pelicula.MontoRecaudado = 0;
			pelicula.Universo = 0;
			pelicula.Personajes.Clear();
			pelicula.Imagen = null;
			checkedListBoxPersonajes.ClearSelected();


			while (checkedListBoxPersonajes.CheckedIndices.Count > 0)
			{
				checkedListBoxPersonajes.SetItemChecked(checkedListBoxPersonajes.CheckedIndices[0], false);
			}


			panelModuloDirector.Controls.Clear();



		}

		public void ColocarBotonesActivo()
		{
			if (nombreBuscado == pelicula.Nombre)
			{
                buttonCrearPelicula.Enabled = false;
				buttonActualizarPelicula.Enabled = true;
                buttonEliminarPelicula.Enabled = true;
				return;
            }

			buttonCrearPelicula.Enabled = true;
			buttonActualizarPelicula.Enabled = false;
			buttonEliminarPelicula.Enabled = false;
		}
		public void chequearCamposVacios()
		{
			if (pelicula.Nombre == null || pelicula.Directores.Count == 0 || pelicula.Personajes.Count == 0 || pelicula.Imagen == null)
			{
				ColocarBotonesDefecto();
				return;
			}
			ColocarBotonesActivo();
		}


		public void agregarOpcionesListBoxPersonajes(Universo universo)
		{
			checkedListBoxPersonajes.Items.Clear();
			pelicula.Personajes.Clear();
			List<Cliente> personajes = new List<Cliente>();

		   
			foreach (Cliente personaje in personajes)
			{
				checkedListBoxPersonajes.Items.Add(personaje);
			}

			this.ActiveControl = null;
			numericUpDownMontoRecaudado.Focus();
		}

		private void agregarOpcionesUniversoPelicula()
		{
			comboBoxUniversoPelicula.Items.AddRange(new object[] { Universo.Marvel, Universo.DC });
			comboBoxUniversoPelicula.SelectedIndex = 0;

			agregarOpcionesListBoxPersonajes(pelicula.Universo);
		}
		private void buttonBuscarPelicula_Click(object sender, EventArgs e)
		{
			//TODO: Completar el relleno de campos al buscar un personaje exitosamente
			if (pelicula.Nombre == null)
			{
				MessageBox.Show("No se puede buscar un nombre vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (peliculas.Count == 0)
			{
				MessageBox.Show("No hay pélículas registradas, por lo que no se podría encontrar alguna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Pelicula peliculaBuscada = peliculas.SingleOrDefault(peliculaABuscar => peliculaABuscar.Nombre == pelicula.Nombre);


			if (peliculaBuscada == null )
			{
				MessageBox.Show("No se encontró la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ColocarControlesDefecto();

			pelicula.Nombre = peliculaBuscada.Nombre;

			pelicula.Anno = peliculaBuscada.Anno;


			foreach (string director in peliculaBuscada.Directores)
			{
				agregarDirector(director);
			}

			pelicula.MontoRecaudado = peliculaBuscada.MontoRecaudado;

			pelicula.Universo = peliculaBuscada.Universo;

			agregarOpcionesListBoxPersonajes(pelicula.Universo);


			List<int> indices = new List<int>();
			List<Cliente> personajesListBox = new List<Cliente>();

			foreach (Cliente item in checkedListBoxPersonajes.Items)
			{
				personajesListBox.Add(item);
			}

			foreach (Cliente personaje in peliculaBuscada.Personajes)
			{
				int indexPersonajeEncontrado = personajesListBox.FindIndex(personajeLista => personajeLista.Nombre == personaje.Nombre);

				

				if (indexPersonajeEncontrado != -1)
				{
					indices.Add(indexPersonajeEncontrado);
				}
			}

			foreach (int indice in indices)
			{
				checkedListBoxPersonajes.SetItemChecked(indice, true);
			}

			pelicula.Directores = clonDirectores(peliculaBuscada.Directores);
			pelicula.Personajes = clonClientes(peliculaBuscada.Personajes);
			pelicula.Imagen = Image.FromFile(@$"{Application.StartupPath}\imgPeliculas\{peliculaBuscada.Nombre}.jpg");

			nombreBuscado = pelicula.Nombre;

			ColocarBotonesActivo();
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

			agregarDirector(formDirector.NombreDirector);
			

			pelicula.Directores.Add(formDirector.NombreDirector);

			chequearCamposVacios();
		}

		private void agregarDirector(string nombreDirector)
		{
            Label labelDirectorNuevo = new Label(); //Label que contiene el nombre del director
            labelDirectorNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDirectorNuevo.ForeColor = System.Drawing.Color.White;
            labelDirectorNuevo.Location = new System.Drawing.Point(0, 0);
            labelDirectorNuevo.Name = "labelTitulo";
            labelDirectorNuevo.TabIndex = 1;
            labelDirectorNuevo.Dock = DockStyle.Left; //Anclarlo a la izquierda de su contenedor
            labelDirectorNuevo.Text = nombreDirector;
            labelDirectorNuevo.Name = $"labelDirectorNuevo{nombreDirector}";
            labelDirectorNuevo.SetBounds(0, 0, 200, 25);

            Button eliminarDirector = new Button();
            eliminarDirector.Name = $"buttonDirectorNuevo{nombreDirector}";
            eliminarDirector.Dock = DockStyle.Right;
            eliminarDirector.Dock = System.Windows.Forms.DockStyle.Right;
            eliminarDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            eliminarDirector.UseVisualStyleBackColor = true;
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\botonEliminar.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\..\")));
            //eliminarDirector.Image = Image.FromFile(@$"{Application.StartupPath}botonEliminar.png");
            eliminarDirector.Image = Image.FromFile(FileName);
            eliminarDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            eliminarDirector.Size = new Size(25, 25);
            eliminarDirector.Click += new EventHandler(buttonEliminarDirector_Click);

            Panel panelDirectorNuevo = new Panel();
            panelDirectorNuevo.Dock = DockStyle.Top;
            panelDirectorNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            panelDirectorNuevo.Name = $"PanelDirector{nombreDirector}";
            panelDirectorNuevo.SetBounds(0, 100, 100, 25);

            //Agregar boton de eliminar y label de director a panel contenedor 

            panelDirectorNuevo.Controls.Add(labelDirectorNuevo);
            panelDirectorNuevo.Controls.Add(eliminarDirector);
            panelDirectorNuevo.Padding = new Padding(10, 0, 10, 0);

            //agregar panel contenedor a módulo de contenedores

            panelModuloDirector.Controls.Add(panelDirectorNuevo);
        }

		private void buttonEliminarDirector_Click(object sender, EventArgs e)
		{
			//Obtiene el botón de eliminar que fue clickeado, para eliminar su contenedor
			Button botonEliminar = (Button)sender;
			Panel panelModulo = (Panel)botonEliminar.Parent.Parent;
			panelModulo.Controls.Remove(botonEliminar.Parent); //elimina al panel contenedor del label y boton de eliminar del director
			pelicula.Directores.Remove(botonEliminar.Parent.Controls[0].Text); //elimina el director de la pelicula
			botonEliminar.Parent.Dispose();
			chequearCamposVacios();
		}

		private void comboBoxUniversoPelicula_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (checkedListBoxPersonajes.CheckedItems.Count == 0) {
			//	agregarOpcionesListBoxPersonajes((Universo)comboBoxUniversoPelicula.SelectedItem);
			//	return;
			//}

			agregarOpcionesListBoxPersonajes((Universo)comboBoxUniversoPelicula.SelectedItem);
		}

		private void checkedListBoxPersonajes_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			Cliente cliente = (Cliente)checkedListBoxPersonajes.Items[e.Index];


			if (e.NewValue == CheckState.Unchecked)
			{
				pelicula.Personajes.Remove(cliente);
				chequearCamposVacios();
				return;
			}


			pelicula.Personajes.Add(cliente);

			this.ActiveControl = null;
			numericUpDownMontoRecaudado.Focus();

			chequearCamposVacios();
		}

		private void RegistroPelicula_FormClosing(object sender, FormClosingEventArgs e)
		{
			Respaldo.GuardarPeliculas(peliculas);
		}

		//public void guardarPeliculas()
		//{
		//	if (peliculas == null) return;
		//	string directorio = Application.StartupPath;
		//	FileStream fileStream = new FileStream(@$"{directorio}/listaPeliculas.txt", FileMode.Create, FileAccess.Write);
		//	StreamWriter streamWriter = new StreamWriter(fileStream);

		//	streamWriter.WriteLine(Serializador.SerializarPeliculas(peliculas));

		//	streamWriter.Close();
		//	fileStream.Close();
		//}

		//public void GuardarPeliculas(BindingList<Pelicula> peliculasAGuardar = null)
		//{
		//	if (peliculasAGuardar == null) peliculasAGuardar = peliculas;
		//	if (peliculasAGuardar == null) return;
		//	string directorio = Application.StartupPath;
		//	FileStream fileStream = new FileStream(@$"{directorio}/listaPeliculas.txt", FileMode.Create, FileAccess.Write);
		//	StreamWriter streamWriter = new StreamWriter(fileStream);

		//	streamWriter.WriteLine(Serializador.SerializarPeliculas(peliculasAGuardar));

		//	streamWriter.Close();
		//	fileStream.Close();
		//}

		private void buttonEliminarPelicula_Click(object sender, EventArgs e)
		{
			IReadOnlyList<Pelicula> peliculasAEliminar = peliculas.Where(peliculaABuscar => peliculaABuscar.Nombre == pelicula.Nombre).ToList();

            foreach (Pelicula peliculaAEliminar in peliculasAEliminar)
			{
				peliculas.Remove(peliculaAEliminar);
			}

			peliculasAEliminar = null;


			MessageBox.Show("Película eliminada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			string nombrePelicula = pelicula.Nombre;
			ColocarControlesDefecto();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            File.Delete(@$"{Application.StartupPath}\imgPeliculas\{nombrePelicula}.jpg");

			Respaldo.GuardarPeliculas(peliculas);

			nombreBuscado = string.Empty;
        }

		private void buttonCrearPelicula_Click(object sender, EventArgs e)
		{

			Pelicula nuevaPelicula = peliculas.AddNew();

			int numRepeticiones = 0;

			foreach (Pelicula peliculaColeccion in peliculas)
			{
				if (peliculaColeccion.Nombre == nuevaPelicula.Nombre)
				{
					numRepeticiones++;
				}
			}

			if (numRepeticiones > 1)
			{
				MessageBox.Show("El nombre de esta película ya existe. Si desea modificarla o eliminarla, Dele al botón de buscar, y luego pulse los respectivos botones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				peliculas.CancelNew(peliculas.IndexOf(nuevaPelicula));
				return;
			}

				
			peliculas.EndNew(peliculas.IndexOf(nuevaPelicula));

			guardarImagenPelicula(nuevaPelicula.Nombre);
			MessageBox.Show("Película creada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			Respaldo.GuardarPeliculas(peliculas); //Cambio de ultimo momento
			ColocarControlesDefecto();

		}

		private void guardarImagenPelicula(string nombre)
		{
            string directorio = Application.StartupPath;
            string directorioImagen = Path.Combine(directorio, "imgPeliculas");

			//Creamos auxiliar para evitar lock por parte de windows
			Image auxiliarDeMemoria = new Bitmap(pelicula.Imagen);
			Directory.CreateDirectory(directorioImagen);
			pelicula.Imagen.Dispose(); //Si utilizamos close() o le asignamos null, todavía mantiene el lock
			pelicula.Imagen = null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

			File.Delete($@"{directorioImagen}\{nombre}.jpg");
            auxiliarDeMemoria.Save($@"{directorioImagen}\{nombre}.jpg", ImageFormat.Jpeg);
			pelicula.Imagen = auxiliarDeMemoria;
		}

        private void buttonActualizarPelicula_Click(object sender, EventArgs e)
        {
			Pelicula peliculaAActualizar = peliculas.ToList().Find(peliculaABuscar => peliculaABuscar.Nombre == pelicula.Nombre);

			peliculaAActualizar.Nombre = pelicula.Nombre;
			peliculaAActualizar.Anno = pelicula.Anno;
			peliculaAActualizar.MontoRecaudado = pelicula.MontoRecaudado;
			peliculaAActualizar.Universo = pelicula.Universo;

			peliculaAActualizar.Directores = clonDirectores(pelicula.Directores);
			peliculaAActualizar.Personajes = clonClientes(pelicula.Personajes);
			peliculaAActualizar.Imagen = pelicula.Imagen;


			guardarImagenPelicula(pelicula.Nombre);

			MessageBox.Show("Película actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			ColocarControlesDefecto();

			Respaldo.GuardarPeliculas(peliculas);

        }

        private void buttonannadirImagen_Click(object sender, EventArgs e)
        {
			openFileDialogImagenPelicula.Filter = "Imagenes|*.jpg; *.png";
			openFileDialogImagenPelicula.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			openFileDialogImagenPelicula.Title = "Seleccionar Imagen";

            if (openFileDialogImagenPelicula.ShowDialog() == DialogResult.OK)
            {
                pelicula.Imagen = Image.FromFile(openFileDialogImagenPelicula.FileName);
            }
        }
    }
}
