namespace Heroes
{
    public partial class Form1 : Form
    {
        List<Panel> panelesSubmenu = new List<Panel>();
        //Código de video. Básicamente crear submenus (paneles) y mostrarlos o no (Visible) dependiendo de si se toca el botón correspondiente o no
        //https://www.youtube.com/watch?v=3ni0V-l3Auw
        public Form1()
        {
            InitializeComponent();
            personalizarDisenno();
            panelesSubmenu.Add(panelClientesSubmenu);
            panelesSubmenu.Add(panelPrestamosSubmenu);
            panelesSubmenu.Add(panelPagosSubmenu);
        }

        private void personalizarDisenno()
        {
            panelClientesSubmenu.Visible = false;
            panelPrestamosSubmenu.Visible = false;
            panelPagosSubmenu.Visible = false;
        }

        private void esconderSubmenu()
        {
            foreach (Panel submenu in panelesSubmenu)
            {
                if (submenu.Visible) submenu.Visible = false;
            }
        }

        private void mostrarSubmenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                esconderSubmenu();
                submenu.Visible = true;
                return;
            }
            submenu.Visible = false;
        }

        #region submenu de personajes

        private void buttonSubmenuClientes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelClientesSubmenu);
        }

        private void buttonRegistroClientes_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
            abrirFormHijo(new RegistroPersonaje());
        }

        private void buttonConsultaClientes_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
            abrirFormHijo(new ConsultaPersonaje());
        }

        #endregion

        #region submenu de peliculas

        private void buttonSubmenuPrestamos_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelPrestamosSubmenu);
        }

        private void buttonRegistroPrestamos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new RegistroPelicula());
            esconderSubmenu();
        }

        private void buttonConsultaPrestamos_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
            abrirFormHijo(new ConsultaPelicula());
        }

        private void buttonSubmenuPagos_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelPagosSubmenu);
        }

        private void buttonRegistroPagos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new RegistroPelicula());
            esconderSubmenu();
        }

        private void buttonConsultaPagos_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
            abrirFormHijo(new ConsultaPelicula());
        }

        private Form? formActivo = null;

        private void abrirFormHijo(Form formHijo)
        {

            foreach (Form form in Application.OpenForms)
            {
                //Si el formulario es el mismo, no cerrar el formulario
                if (form.GetType() == formHijo.GetType()) return;
            }

            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        #endregion

    }
}