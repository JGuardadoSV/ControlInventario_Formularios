using ControlInventario.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Modelos
{
    public class MCompra
    {
        IDbConnection cn = Conexion.conectar();

        public void GuardarCompra(List<DetalleCompra> listado)
        {
            //GUARDAR LA COMPRA
            //****************************
            string consulta = "Insert into compras values(@fecha,@estado)";
            //****************************
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@fecha", DateTime.Now, DbType.DateTime);
            parametros.Add("@estado", 1, DbType.Int32);
            //****************************
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

            //Recuperar el ID de la compra registrada
            consulta = "Select max(idcompra) id from Compras";
            cn.Open();
            int idcompra= cn.QuerySingle<int>(consulta);
            cn.Close();


            foreach (DetalleCompra detalle in listado)
            {
                //****************************
                consulta = "Insert into DetallesCompra values(@cantidad,@precio,@idproducto,@idcompra)";
                //****************************
                parametros = new DynamicParameters();
                parametros.Add("@cantidad", detalle.Cantidad, DbType.Int32);
                parametros.Add("@precio", detalle.Precio, DbType.Decimal);
                parametros.Add("@idproducto", detalle.IdProducto, DbType.Int32);
                parametros.Add("@idcompra", idcompra, DbType.Int32);
                //****************************
                cn.Open();
                cn.Execute(consulta, parametros, commandType: CommandType.Text);
                cn.Close();
            }




        }
    }
}
