using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    internal class Respaldo
    {

        public static void GuardarPeliculas(BindingList<Pelicula> peliculasAGuardar)
        {
            string directorio = Application.StartupPath;
            FileStream fileStream = new FileStream(@$"{directorio}/listaPeliculas.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(Serializador.SerializarPeliculas(peliculasAGuardar));

            streamWriter.Close();
            fileStream.Close();
        }

        public static void GuardarPersonajes(BindingList<Personaje> personajes)
        {
            string directorio = Application.StartupPath;
            FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(Serializador.SerializarPersonajes(personajes));

            streamWriter.Close();
            fileStream.Close();
        }
    }
}
