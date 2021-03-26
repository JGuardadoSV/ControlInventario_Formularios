using ControlInventario.Entidades;
using ControlInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Controladores
{
    public class CLinea
    {
        // Referencia al modelo
        MLinea mLinea = new MLinea();


        public void Insertar(Linea linea) //2 - Se recibe de la vista
        {
            mLinea.Insertar(linea); // 3-  Se envía al modelo
        }

        public void Actualizar(Linea linea)
        {
            mLinea.Actualizar(linea);
        }

        public void Eliminar(Linea linea)
        {
            mLinea.Eliminar(linea);
        }

        public List<Linea> Consultar()
        {
            return mLinea.Consultar();
        }

        public Linea ConsultarUno(int id)
        {
            return mLinea.ConsultarUno(id);
        }


    }
}
