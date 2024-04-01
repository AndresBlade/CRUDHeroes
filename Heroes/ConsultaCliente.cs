using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class ConsultaCliente : Form
    {
        private List<Cliente> clientes;
        public ConsultaCliente()
        {
            InitializeComponent();
            clientes = new List<Cliente>();

            inicializarGridClientes(clientes);
            configurarFiltros();
        }

        private void inicializarGridClientes(List<Cliente> clientes)
        {
            dataGridViewClientes.Rows.Clear();
            dataGridViewClientes.RowTemplate.Height = 200;
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.RowHeadersVisible = false;

            foreach(Cliente cliente in clientes)
            {
                cliente.Imagen = Image.FromFile(@$"{Application.StartupPath}\img\{cliente.Nombre}.jpg");
                dataGridViewClientes.Rows.Add(cliente.NumeroRegistro, cliente.Nombre, cliente.Apellido, cliente.Cedula, cliente.FechaNacimiento.ToString(), cliente.FechaRegistro.ToString(), cliente.Direccion, cliente.Imagen);
            }
        }

        private void configurarFiltros()
        {
            numericUpDownDesdeCedula.DataBindings.Add("Maximum", numericUpDownHastaCedula, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownHastaCedula.DataBindings.Add("Minimum", numericUpDownDesdeCedula, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxSexo.Items.AddRange(new object[] { Sexo.Masculino, Sexo.Femenino, Sexo.Desconocido });
            comboBoxSexo.SelectedIndex = 0;
            comboBoxActitud.Items.AddRange(new object[] { Actitud.Heroe, Actitud.Villano, Actitud.Antiheroe });
            comboBoxActitud.SelectedIndex = 0;


        }

        private void filtrarClientes(object sender, EventArgs e)
        {
            List<Cliente> clientesFiltrados = clientes.FindAll(cliente =>
            cliente.Cedula >= numericUpDownDesdeCedula.Value
            && cliente.Cedula <= numericUpDownHastaCedula.Value
            //&& cliente.Actitud == (Actitud)comboBoxActitud.SelectedItem
            //&& cliente.Sexo == (Sexo)comboBoxSexo.SelectedItem
            );

            inicializarGridClientes(clientesFiltrados);
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            inicializarGridClientes(clientes);

            numericUpDownHastaCedula.Value = 50000000;
            numericUpDownDesdeCedula.Value = 0;
            comboBoxActitud.SelectedIndex = 0;
            comboBoxSexo.SelectedIndex = 0;
        }
    }
}
