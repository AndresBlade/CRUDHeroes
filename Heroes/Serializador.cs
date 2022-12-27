using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    internal class Serializador
    {
        private static string separador = ";";
        public static string SerializarPersonaje(Personaje personaje)
        {
            string linea = string.Empty;

            linea += personaje.Nombre + separador;
            linea += personaje.Sexo.ToString() + separador;
            linea += personaje.Actitud.ToString() + separador;
            linea += personaje.IdentidadSecreta + separador;
            linea += personaje.Universo.ToString() + separador;
            linea += personaje.Edad.ToString() + separador;
            linea += personaje.Activo.ToString() + separador;

            return linea;

        }

        //public static Personaje DeserializarPersonaje(string nombre)
        //{
        //    string directorio = Application.StartupPath;
        //    FileStream fileStream = new FileStream(@$"{Application.StartupPath}/{nombre}.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader streamReader = new StreamReader(fileStream);

        //    string linea = streamReader.ReadLine();
        //    string[] propiedadesPersonaje = linea.Split(separador);
        //    Personaje personaje = new Personaje();
        //    personaje.Nombre = propiedadesPersonaje[0];
        //    personaje.Sexo= (Sexo)Enum.Parse(typeof(Sexo), propiedadesPersonaje[1]);
        //    personaje.Actitud = (Actitud)Enum.Parse(typeof(Actitud), propiedadesPersonaje[2]);
        //    personaje.IdentidadSecreta = propiedadesPersonaje[3];
        //    personaje.Universo = (Universo)Enum.Parse(typeof(Universo), propiedadesPersonaje[4]);
        //    personaje.Edad= int.Parse(propiedadesPersonaje[5]);
        //    personaje.Activo = bool.Parse(propiedadesPersonaje[6]);
        //    personaje.Imagen = Image.FromFile($@"{Application.StartupPath}/img/{personaje.Nombre}.jpg");

        //    streamReader.Close();
        //    fileStream.Close();

        //    return personaje;

        //}

        public static string SerializarPersonajes(List<Personaje> personajes)
        {
            string linea = string.Empty;

            foreach (Personaje personaje in personajes)
            {
                linea += SerializarPersonaje(personaje) + "\n";
            }

            return linea;
        }

        public static List<Personaje> DeserializarPersonajes()
        {

            List<Personaje> personajes = new List<Personaje>();
            string directorio = Application.StartupPath;
            string linea;

            FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            linea = streamReader.ReadLine();

            while (linea != null)
            {

                if (string.IsNullOrWhiteSpace(linea))
                {
                    linea = streamReader.ReadLine();
                    continue;
                }
                string[] propiedadesPersonaje = linea.Split(separador);
                Personaje personaje = new Personaje();
                personaje.Nombre = propiedadesPersonaje[0];
                personaje.Sexo = (Sexo)Enum.Parse(typeof(Sexo), propiedadesPersonaje[1]);
                personaje.Actitud = (Actitud)Enum.Parse(typeof(Actitud), propiedadesPersonaje[2]);
                personaje.IdentidadSecreta = propiedadesPersonaje[3];
                personaje.Universo = (Universo)Enum.Parse(typeof(Universo), propiedadesPersonaje[4]);
                personaje.Edad = int.Parse(propiedadesPersonaje[5]);
                personaje.Activo = bool.Parse(propiedadesPersonaje[6]);
                personaje.Imagen = Image.FromFile($@"{Application.StartupPath}/img/{personaje.Nombre}.jpg");
                personajes.Add(personaje);
                linea = streamReader.ReadLine();
            }
            streamReader.Close();
            fileStream.Close();

            return personajes;
        }
    }
}
