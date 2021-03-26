using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Entidades
{
    public class DetalleVenta
    {
        private int idDetalleVenta;
        private Producto producto;
        private int cantidad;
        private double precio;
        private Venta venta;

        public int IdDetalleVenta
        {
            get { return idDetalleVenta; }
            set { idDetalleVenta = value; }
        }
        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Venta Venta
        {
            get { return venta; }
            set { venta = value; }
        }
    }
}
