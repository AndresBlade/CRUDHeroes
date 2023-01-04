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
    public partial class ConsultaPersonaje : Form
    {
        private List<Personaje> personajes;
        public ConsultaPersonaje()
        {
            InitializeComponent();
            personajes = Serializador.DeserializarPersonajes().ToList();

            inicializarGridPersonajes(personajes);
            configurarFiltros();
        }

        private void inicializarGridPersonajes(List<Personaje> personajes)
        {
            dataGridViewPersonajes.Rows.Clear();
            dataGridViewPersonajes.RowTemplate.Height = 200;
            dataGridViewPersonajes.AllowUserToAddRows = false;
            dataGridViewPersonajes.RowHeadersVisible = false;

            foreach(Personaje personaje in personajes)
            {
                personaje.Imagen = Image.FromFile(@$"{Application.StartupPath}\img\{personaje.Nombre}.jpg");
                dataGridViewPersonajes.Rows.Add(personaje.Nombre, personaje.Actitud, personaje.Sexo, personaje.IdentidadSecreta, personaje.Universo, personaje.Edad, personaje.Activo, personaje.Imagen);
            }
        }

        private void configurarFiltros()
        {
            numericUpDownDesdeEdad.DataBindings.Add("Maximum", numericUpDownHastaEdad, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownHastaEdad.DataBindings.Add("Minimum", numericUpDownDesdeEdad, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxSexo.Items.AddRange(new object[] { Sexo.Masculino, Sexo.Femenino, Sexo.Desconocido });
            comboBoxSexo.SelectedIndex = 0;
            comboBoxActitud.Items.AddRange(new object[] { Actitud.Heroe, Actitud.Villano, Actitud.Antiheroe });
            comboBoxActitud.SelectedIndex = 0;


        }

        private void filtrarPersonajes(object sender, EventArgs e)
        {
            List<Personaje> personajesFiltrados = personajes.FindAll(personaje =>
            personaje.Edad >= numericUpDownDesdeEdad.Value
            && personaje.Edad <= numericUpDownHastaEdad.Value
            && personaje.Actitud == (Actitud)comboBoxActitud.SelectedItem
            && personaje.Sexo == (Sexo)comboBoxSexo.SelectedItem);

            inicializarGridPersonajes(personajesFiltrados);
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            inicializarGridPersonajes(personajes);

            numericUpDownHastaEdad.Value = 120;
            numericUpDownDesdeEdad.Value = 12;
            comboBoxActitud.SelectedIndex = 0;
            comboBoxSexo.SelectedIndex = 0;
        }
    }
}
