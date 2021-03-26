using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Entidades
{
    public class Linea
    {
        private int idLinea;
        private string nombre;

        public int IdLinea  
        { 
            get { return idLinea; } 
            set { idLinea = value; }    
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //*************

        public Linea() { }

    }
}
