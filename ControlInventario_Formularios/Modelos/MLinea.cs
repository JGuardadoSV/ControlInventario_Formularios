using ControlInventario.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Modelos
{
    public class MLinea
    {

        IDbConnection cn = Conexion.conectar();
 

        public void Insertar(Linea linea) { //4- Se recibe del controlador
            //****************************
            string consulta = "Insert into lineas values(@nombre)";  
            //****************************
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", linea.Nombre, DbType.String);
            //****************************
            cn.Open();
            cn.Execute(consulta,parametros,commandType:CommandType.Text);
            cn.Close();
        }
        public void Actualizar(Linea linea) {
            string consulta = "Update lineas set nombre='" + linea.Nombre +"' where IdLinea="+linea.IdLinea;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }
        public void Eliminar(Linea linea) {
            string consulta = "Delete from lineas where idLinea="+linea.IdLinea;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }

        public List<Linea> Consultar() {
            // Select * from lineas
            List<Linea> lineas = new List<Linea>();
            string consulta = "Select * from lineas";
            cn.Open();
            lineas = cn.Query<Linea>(consulta).ToList();
            cn.Close();
            return lineas;
        }

        public Linea ConsultarUno(int id)
        {
            string consulta = "Select * from lineas where IdLinea="+id;
            cn.Open();
            // retornando un solo objeto
            Linea linea = cn.QuerySingle<Linea>(consulta);
            cn.Close();
            return linea;
        }

    }
}
