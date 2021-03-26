using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Entidades
{
    public class Producto
    {
        private int idProducto; 
        private string nombre;
        private double precio;
        private int existencias;
        private int linea;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Existencias
        {
            get { return existencias; }
            set { existencias = value; }
        }
        public int IdLinea_FK
        {
            get { return linea; }
            set { linea = value; }
        }


    }
}
