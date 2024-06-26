﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    //INotifyPropertyChanged permite que el enlace de datos sea bidireccional, el objeto destino notifica al objeto origen
    public class Personaje : INotifyPropertyChanged
    {
        private string _nombre;
        private Sexo _sexo;
        private Actitud _actitud;
        private string _identidadSecreta;
        private Universo _universo;
        private int _edad;
        private bool _activo;
        private Image _imagen;


        public string Nombre { get => _nombre; set
            {
                _nombre = string.IsNullOrWhiteSpace(value) ? null : value;
                onPropertyChanged("Nombre"); //función que notifica al objeto origen
            }
        }
        public Sexo Sexo { get => _sexo; set
            {
                _sexo = value;
                onPropertyChanged("Sexo");
            }
        }
        public Actitud Actitud { get => _actitud; set
            {
                _actitud = value;
                onPropertyChanged("Actitud");
            }
        }
        public string IdentidadSecreta { get => _identidadSecreta; set
            {
                _identidadSecreta = string.IsNullOrWhiteSpace(value) ? null : value;
                onPropertyChanged("IdentidadSecreta");
            }
        }
        public Universo Universo { get => _universo; set
            {
                _universo = value;
                onPropertyChanged("Universo");
            }
        }
        public int Edad { get => _edad; set
            {
                _edad = value;
                onPropertyChanged("Edad");

            }
        }
        public bool Activo { get => _activo; set
            {
                _activo = value;
                onPropertyChanged("Activo");
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
                        RegistroPersonaje.instance.colocarBotonesDefecto();
                        return;
                    }
                }

                 if (RegistroPersonaje.instance != null) RegistroPersonaje.instance.colocarBotonesActivos();
            }
        }
    }
}
