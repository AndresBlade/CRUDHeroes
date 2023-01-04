using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heroes
{
    public partial class ConsultaPelicula : Form
    {

        public ConsultaPelicula instance;

        private List<Pelicula> peliculas;
        private List<Personaje> personajes;
        public ConsultaPelicula()
        {

            instance = this;
            InitializeComponent();
            peliculas = Serializador.DeserializarPeliculas().ToList();
            personajes = Serializador.DeserializarPersonajes();


            inicializarGridPeliculas(peliculas);
            configurarFiltros();
        }

        private void inicializarGridPeliculas(List<Pelicula> peliculas)
        {
            dataGridViewPeliculas.Rows.Clear();
            dataGridViewPeliculas.RowTemplate.Height = 200;
            dataGridViewPeliculas.AllowUserToAddRows= false;
            dataGridViewPeliculas.RowHeadersVisible = false;

            

            for (int i = 0; i < peliculas.Count; i++)
            {
                peliculas[i].Imagen = Image.FromFile(@$"{Application.StartupPath}\imgPeliculas\{peliculas[i].Nombre}.jpg");
                string directoresLinea = string.Empty;
                string personajesLinea = string.Empty;
                for (int j = 0; j < peliculas[i].Directores.Count; j++)
                {
                    if (j == peliculas[i].Directores.Count - 1)
                    {
                        directoresLinea += peliculas[i].Directores[j];
                        continue;
                    }

                    directoresLinea += peliculas[i].Directores[j] + ", ";
                }

                for (int j = 0; j < peliculas[i].Personajes.Count; j++)
                {
                    if (j == peliculas[i].Personajes.Count - 1)
                    {
                        personajesLinea += peliculas[i].Personajes[j].Nombre;
                        continue;
                    }

                    personajesLinea += peliculas[i].Personajes[j].Nombre + ", ";



                }
                dataGridViewPeliculas.Rows.Add(peliculas[i].Nombre, directoresLinea, peliculas[i].Anno, peliculas[i].MontoRecaudado, peliculas[i].Universo, personajesLinea, peliculas[i].Imagen);
            }
        }

        private void configurarFiltros()
        {
            numericUpDownDesdeAnno.DataBindings.Add("Maximum", numericUpDownHastaAnno, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownHastaAnno.DataBindings.Add("Minimum", numericUpDownDesdeAnno, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxUniverso.Items.AddRange(new object[] { Universo.Marvel, Universo.DC });
            comboBoxUniverso.SelectedIndex = 0;
            numericUpDownDesdeMonto.DataBindings.Add("Maximum", numericUpDownHastaMonto, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownHastaMonto.DataBindings.Add("Minimum", numericUpDownDesdeMonto, "Value", false, DataSourceUpdateMode.OnPropertyChanged);

            checkedListBoxPersonajes.CheckOnClick = true;
        }

        private void cambiarUniversoFiltro(object sender, EventArgs e)
        {
            checkedListBoxPersonajes.Items.Clear();

            List<Personaje> personajesUniverso = personajes.FindAll(personaje => personaje.Universo == (Universo)comboBoxUniverso.SelectedItem);
            checkedListBoxPersonajes.Items.AddRange(personajesUniverso.ToArray());
        }

        private void filtrarPeliculas(object sender, EventArgs e)
        {
            List<Pelicula> peliculasFiltradas = peliculas.FindAll(pelicula =>
            {

                List<Personaje> personajesListBox = checkedListBoxPersonajes.CheckedItems.Cast<Personaje>().ToList();

                bool contienePersonajes = personajesListBox.All(personajeListBox => pelicula.Personajes.Any(personaje => personaje.Nombre == personajeListBox.Nombre));

                return pelicula.Anno >= numericUpDownDesdeAnno.Value
                && pelicula.Anno <= numericUpDownHastaAnno.Value
                && pelicula.MontoRecaudado >= numericUpDownDesdeMonto.Value
                && pelicula.MontoRecaudado <= numericUpDownHastaMonto.Value
                && pelicula.Universo == (Universo)comboBoxUniverso.SelectedItem && contienePersonajes;
            });

            inicializarGridPeliculas(peliculasFiltradas);
            
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            inicializarGridPeliculas(peliculas);

            numericUpDownHastaAnno.Value = 2022;
            numericUpDownDesdeAnno.Value = 1800;
            comboBoxUniverso.SelectedIndex = 0;
            cambiarUniversoFiltro(new object(), new EventArgs());
            numericUpDownDesdeMonto.Value = 0;
            numericUpDownHastaMonto.Value = 1000000000;
        }
    }
}
