using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_productos_2
{
    internal class Producto
    {
        private string Codigo;
        private string Nombre;
        private float Precio;
        private int Cantidad;

        public  Producto (){ } //constructor

        public string codigo {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public string nombre {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public float precio {
            get { return Precio; }
            set{ Precio = value; }
        }

        public int cantidad {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
    }
}
