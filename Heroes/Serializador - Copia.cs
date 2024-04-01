using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Empresa
{
    internal class Serializador
    {
        private static string separador = ";";
        //public static string SerializarPersonaje(Cliente personaje)
        //{
        //    //Devuelve una línea string con los datos del personaje separados por el separador
        //    string linea = string.Empty;

        //    linea += personaje.Nombre + separador;
        //    linea += personaje.Sexo.ToString() + separador;
        //    linea += personaje.Actitud.ToString() + separador;
        //    linea += personaje.IdentidadSecreta + separador;
        //    linea += personaje.Universo.ToString() + separador;
        //    linea += personaje.Edad.ToString() + separador;
        //    linea += personaje.Activo.ToString() + separador;

        //    return linea;

        //}

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

        //public static string SerializarPersonajes(BindingList<Cliente> personajes)
        //{
        //    //Devuelve un string de un conjunto de lineas, cada linea es un personaje serializado
        //    string linea = string.Empty;

        //    foreach (Cliente personaje in personajes)
        //    {
        //        linea += SerializarPersonaje(personaje) + "\n";
        //    }

        //    return linea;
        //}

        //public static BindingList<Cliente> DeserializarPersonajes()
        //{
        //    //Devuelve la lista de personajes que se encuentra en listaPersonajes.txt
        //    BindingList<Cliente> personajes = new BindingList<Cliente>();
        //    string directorio = Application.StartupPath;
        //    string linea;

        //    FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.OpenOrCreate, FileAccess.Read);
        //    StreamReader streamReader = new StreamReader(fileStream);

        //    linea = streamReader.ReadLine();

            
        //    while (linea != null)
        //    {

        //        if (string.IsNullOrWhiteSpace(linea)) //Si la línea está vacía. Cuando se elimina un personaje, la línea queda vacía
        //        {
        //            linea = streamReader.ReadLine();
        //            continue;
        //        }
        //        string[] propiedadesPersonaje = linea.Split(separador); //devuele un arreglo. cada elemento del arreglo es una propiedad del personaje en string
        //        Cliente personaje = new Cliente();
        //        personaje.Nombre = propiedadesPersonaje[0];
        //        personaje.Sexo = (Sexo)Enum.Parse(typeof(Sexo), propiedadesPersonaje[1]);
        //        personaje.Actitud = (Actitud)Enum.Parse(typeof(Actitud), propiedadesPersonaje[2]);
        //        personaje.IdentidadSecreta = propiedadesPersonaje[3];
        //        personaje.Universo = (Universo)Enum.Parse(typeof(Universo), propiedadesPersonaje[4]);
        //        personaje.Edad = int.Parse(propiedadesPersonaje[5]);
        //        personaje.Activo = bool.Parse(propiedadesPersonaje[6]);
        //        personajes.Add(personaje);

        //        linea = streamReader.ReadLine();
        //    }
        //    streamReader.Close();
        //    fileStream.Close();

        //    return personajes;
        //}

        public static string SerializarPelicula(Pelicula pelicula)
        {
            string linea = string.Empty;

            linea += pelicula.Nombre + separador;
            linea += pelicula.Anno.ToString() + separador;

            for (int i = 0; i < pelicula.Directores.Count; i++)
            {

                string director = pelicula.Directores[i];

                director = Regex.Replace(director, @"\s", "*");

                //if (Regex.IsMatch(director, @"\s"))
                //{
                //    MessageBox.Show(director);
                //}
                if (i == pelicula.Directores.Count - 1)
                {
                    linea += director;
                    continue;
                }
                linea += director + " ";
            }



            linea += separador;
            linea += pelicula.MontoRecaudado + separador;
            linea += pelicula.Universo + separador;

            for (int i = 0; i < pelicula.Personajes.Count; i++)
            {

                string personaje = Regex.Replace(pelicula.Personajes[i].Nombre, @"\s", "*");
                if (i == pelicula.Personajes.Count - 1)
                {
                    linea += personaje;
                    continue;
                }
                linea += personaje + " ";
            }
            linea += separador;

            return linea;
        }

        public static string SerializarPeliculas(BindingList<Pelicula> peliculas)
        {
            string linea = string.Empty;

            foreach (Pelicula pelicula in peliculas)
            {
                linea += SerializarPelicula(pelicula) + "\n";
            }

            return linea;
        }

        //public static BindingList<Pelicula> DeserializarPeliculas()
        //{
        //    BindingList<Pelicula> peliculas = new BindingList<Pelicula>();
        //    BindingList<Cliente> personajesGuardados = DeserializarPersonajes();

        //    string directorio = Application.StartupPath;

        //    string linea = string.Empty;

        //    FileStream fileStream = new FileStream(@$"{directorio}/listaPeliculas.txt", FileMode.OpenOrCreate, FileAccess.Read);
        //    StreamReader streamReader = new StreamReader(fileStream);

        //    linea = streamReader.ReadLine();

        //    while (linea != null)
        //    {
        //        if (string.IsNullOrWhiteSpace(linea))
        //        {
        //            linea = streamReader.ReadLine();
        //            continue;
        //        }

        //        string[] propiedadesPelicula = linea.Split(separador);
        //        Pelicula pelicula = new Pelicula();
        //        pelicula.Nombre = propiedadesPelicula[0];
        //        pelicula.Anno = int.Parse(propiedadesPelicula[1]);
        //        string[] directores = propiedadesPelicula[2].Split(" ");

        //        foreach(string director in directores)
        //        {
                    
        //            pelicula.Directores.Add(Regex.Replace(director, @"\*", " "));
        //        }
        //        pelicula.MontoRecaudado = int.Parse(propiedadesPelicula[3]);
        //        pelicula.Universo = (Universo)Enum.Parse(typeof(Universo), propiedadesPelicula[4]);
        //        string[] nombrePersonajes = propiedadesPelicula[5].Split(" ");

        //        foreach (string nombrePersonaje in nombrePersonajes)
        //        {

        //            string nombrePersonajeFiltrada = Regex.Replace(nombrePersonaje, @"\*", " ");
        //            Cliente personaje = personajesGuardados.ToList().Find(personajeBuscado => personajeBuscado.Nombre == nombrePersonajeFiltrada);
        //            pelicula.Personajes.Add(personaje);
        //        }

        //        peliculas.Add(pelicula);
        //        linea = streamReader.ReadLine();

        //    }

        //    streamReader.Close();
        //    fileStream.Close();
        //    return peliculas;
        //}
    }
}
