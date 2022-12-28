using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    internal class Pelicula : INotifyPropertyChanged
    {
        private string _nombre;
        private int _anno;
        private string _nombreDirector;
        private int _montoRecaudado;
        private Universo _universo;
        private Image _imagen;
        private List<Personaje> _personajes;
        private List<string> _directores;

        public Pelicula()
        {
            Personajes = new List<Personaje>();
            Directores = new List<string>();
        }


        public string Nombre
        {
            get => _nombre; set
            {
                _nombre = string.IsNullOrWhiteSpace(value) ? null : value;

                onPropertyChanged("Nombre");
            }
        }
        public int Anno { get => _anno; set { 
                _anno = value;
                onPropertyChanged("Anno");
            } 
        }
        public string NombreDirector { get => _nombreDirector; set
            {
                _nombreDirector = string.IsNullOrWhiteSpace(value) ? null : value;
                onPropertyChanged("NombreDirector");
            }
        }

        public int MontoRecaudado { get => _montoRecaudado; set { 
                _montoRecaudado = value;
                onPropertyChanged("MontoRecaudado");
            } 
        }
        public Universo Universo
        {
            get => _universo; set
            {
                _universo = value;
                onPropertyChanged("Universo");
            }
        }

        public Image Imagen
        {
            get => _imagen; set
            {
                _imagen = value;
                onPropertyChanged("Imagen");
            }
        }

        internal List<Personaje> Personajes { get => _personajes; set => _personajes = value; }
        public List<string> Directores { get => _directores; set => _directores = value; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

                //foreach (var propiedad in this.GetType().GetProperties())
                //{
                //    if (propiedad.GetValue(this, null) == null)
                //    {
                //        RegistroPersonaje.instance.colocarBotonesDefecto();
                //        return;
                //    }
                //}

                //RegistroPersonaje.instance.colocarBotonesActivos();
            }
        }
    }
}
