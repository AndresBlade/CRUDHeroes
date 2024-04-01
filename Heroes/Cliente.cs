using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    //INotifyPropertyChanged permite que el enlace de datos sea bidireccional, el objeto destino notifica al objeto origen
    public class Cliente : INotifyPropertyChanged
    {
        private int _numeroRegistro;
        private string _nombre;
        private string _apellido;
        private int _cedula;
        private DateTime _fechaNacimiento;
        private DateTime _fechaRegistro;
        private string _direccion;
        private Image _imagen;

        public int NumeroRegistro
        {
            get => _numeroRegistro; set
            {
                _numeroRegistro = value;
                onPropertyChanged("NumeroRegistro"); //función que notifica al objeto origen
            }
        }
        public string Nombre { get => _nombre; set
            {
                _nombre = string.IsNullOrWhiteSpace(value) ? null : value;
                onPropertyChanged("Nombre"); //función que notifica al objeto origen
            }
        }
        public string Apellido
        {
            get => _apellido; set
            {
                _apellido = string.IsNullOrWhiteSpace(value) ? null : value;
                onPropertyChanged("Apellido"); //función que notifica al objeto origen
            }
        }
        public int Cedula
        {
            get => _cedula; set
            {
                _cedula = value;
                onPropertyChanged("Cedula"); //función que notifica al objeto origen
            }
        }
        public DateTime FechaNacimiento
        {
            get => _fechaNacimiento; set
            {
                _fechaNacimiento = value;
                onPropertyChanged("FechaNacimiento"); //función que notifica al objeto origen
            }
        }
        public DateTime FechaRegistro
        {
            get => _fechaRegistro; set
            {
                _fechaRegistro = value;
                onPropertyChanged("FechaRegistro"); //función que notifica al objeto origen
            }
        }
        public string Direccion
        {
            get => _direccion; set
            {
                _direccion = string.IsNullOrWhiteSpace(value) ? null : value;
                onPropertyChanged("Direccion"); //función que notifica al objeto origen
            }
        }


        public Image Imagen { get => _imagen; set
            {
                _imagen = value;
                onPropertyChanged("Imagen");
            }
        }

        public override string ToString()
        {
            return this.Nombre;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void onPropertyChanged(string propertyName)
        {
            //Si el personaje tiene todos los campos completos, habilitar los botones correspondientes
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

                foreach (var propiedad in this.GetType().GetProperties())
                {
                    if (propiedad.GetValue(this, null) == null)
                    {
                        RegistroCliente.instance.colocarBotonesDefecto();
                        return;
                    }
                }

                 if (RegistroCliente.instance != null) RegistroCliente.instance.colocarBotonesActivos();
            }
        }
    }
}
