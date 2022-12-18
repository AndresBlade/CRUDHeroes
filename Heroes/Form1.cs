namespace Heroes
{
    public partial class Form1 : Form
    {
        List<Panel> panelesSubmenu = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            personalizarDisenno();
            panelesSubmenu.Add(panelPersonajesSubmenu);
            panelesSubmenu.Add(panelPeliculasSubmenu);
        }

        private void personalizarDisenno()
        {
            panelPersonajesSubmenu.Visible= false;
            panelPeliculasSubmenu.Visible= false;
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

        private void buttonSubmenuPersonajes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelPersonajesSubmenu);
        }

        private void buttonRegistroPersonajes_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
            abrirFormHijo(new RegistroPersonaje());
        }

        private void buttonConsultaPersonajes_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
        }

        #endregion

        #region submenu de peliculas

        private void buttonSubmenuPeliculas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelPeliculasSubmenu);
        }

        private void buttonRegistroPeliculas_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
        }

        private void buttonConsultaPeliculas_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
        }

        private Form? formActivo = null;

        private void abrirFormHijo(Form formHijo)
        {
            if(formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock= DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

            //OPCIONAL: Cuando se abra la misma instancia, no cerrar la instancia
        }

        #endregion
    }
}