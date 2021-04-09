using ControlInventario.Controladores;
using ControlInventario.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventario_Formularios
{
    public partial class FCompras : Form
    {
        CProducto cProducto = new CProducto();
        Compra compra = new Compra();

        List<DetalleCompra> listado = new List<DetalleCompra>();

        public FCompras()
        {
            InitializeComponent();
        }

        private void FCompras_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = cProducto.Consultar();
            compra.Fecha = DateTime.Now;
            compra.Estado = 1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto = (Producto)productoBindingSource.Current;
            int cantidad = int.Parse(txtCantidad.Text);

            DetalleCompra detalle = new DetalleCompra();

            detalle.Cantidad = cantidad;
            detalle.Precio = producto.Precio;
            detalle.Producto = producto;
            detalle.Compra = compra;
            detalle.IdProducto = producto.IdProducto;

            detalleCompraBindingSource.Add(detalle);

            listado.Add(detalle);


            double total = Math.Round(double.Parse(textBox3.Text) + cantidad * detalle.Precio,2);
            textBox3.Text = total.ToString("N2");

            txtCantidad.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CCompra cCompra = new CCompra();
            cCompra.GuardarCompra(listado);
            this.Close();
        }
    }
}
