using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Entidades
{
    public class Venta
    {
        private int idventa;
        private DateTime dateTime;
        private string cliente;

        public int IdVenta
        {
            get { return idventa; }
            set { idventa = value; }
        }
        public DateTime Fecha
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }




    }
}
