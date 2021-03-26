using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Entidades
{
    public class Compra
    {
        // Propiedades de la clase compra  (maestro)
        private int idCompra;
        private DateTime fecha;
        private int estado;
        private List<DetalleCompra> detallesCompra;


        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }    
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //Coleccion de Detalles  compra    (detalles)

        public List<DetalleCompra> DetallesCompra
        {
            get { return detallesCompra; }
            set { detallesCompra = value; }
        }


        public Compra()
        {
            this.detallesCompra = new List<DetalleCompra>();
        }



    }
    
}
