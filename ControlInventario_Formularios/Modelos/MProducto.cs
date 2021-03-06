using System;
using ControlInventario.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;


namespace ControlInventario.Modelos
{
    public class MProducto
    {
        IDbConnection cn = Conexion.conectar();

        //Listado de productos
        public void Insertar(Producto producto)
        {
            //****************************
            string consulta = "Insert into productos values(@nombre,@precio,@existencias,@idlinea)";
            //****************************
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", producto.Nombre, DbType.String);
            parametros.Add("@precio", producto.Precio, DbType.Decimal);
            parametros.Add("@existencias", producto.Existencias, DbType.Int32);
            parametros.Add("@idlinea", producto.IdLinea_FK, DbType.Int32);
            //****************************

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public void Actualizar(Producto producto)
        {
            //Agregar comentario cualquiera
            string consulta = "Update productos set nombre=@nombre,precio=@precio,existencias=@existencias,IdLinea_FK=@idlinea where IdProducto=@idproducto";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", producto.Nombre, DbType.String);
            parametros.Add("@precio", producto.Precio, DbType.Decimal);
            parametros.Add("@existencias", producto.Existencias, DbType.Int32);
            parametros.Add("@idlinea", producto.IdLinea_FK, DbType.Int32);
            parametros.Add("@idproducto", producto.IdProducto, DbType.Int32);
            cn.Open();
            cn.Execute(consulta,parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public void Eliminar(Producto producto)
        {
            string consulta = "Delete from productos where IdProducto=@idproducto";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idproducto", producto.IdProducto, DbType.Int32);
            cn.Open();
            cn.Execute(consulta,parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Producto> Consultar()
        {
            // Select * from productos
            List<Producto> productos = new List<Producto>();
            string consulta = "Select * from productos";
            cn.Open();
            productos = cn.Query<Producto>(consulta).ToList();
            cn.Close();
            return productos;
        }

       public Producto ConsultarUno(int id)
       {
            string consulta = "Select * from productos where IdProducto=@idproducto";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idproducto", id, DbType.Int32);
            cn.Open();
            // retornando un solo objeto
            Producto producto = cn.QuerySingle<Producto>(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
            return producto;
        }
    }
}
