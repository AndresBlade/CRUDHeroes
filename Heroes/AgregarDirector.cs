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
    public partial class AgregarDirector : Form
    {
        public AgregarDirector()
        {
            InitializeComponent();
        }

        public string NombreDirector { get; set; } //Para poder acceder a la propiedad desde fuera del formulario, incluso luego de cerrarlo

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreDirector.Text))
            {
                MessageBox.Show("No se pueden agregar nombres vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NombreDirector = textBoxNombreDirector.Text;

            this.DialogResult = DialogResult.OK;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
