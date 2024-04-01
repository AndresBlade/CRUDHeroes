using System;
using System.Buffers;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Empresa
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

        public static void GuardarClientes(BindingList<Cliente> clientes)
        {
            string directorio = Application.StartupPath;
            FileStream fileStream = new FileStream(@$"{directorio}/listaPersonajes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            //ArrayBufferWriter<StreamWriter> writer = new ArrayBufferWriter<StreamWriter>();
            


            //Utf8JsonWriter utfwriter = new Utf8JsonWriter(writer);

            streamWriter.Close();
            fileStream.Close();
        }
    }
}
