using ControlInventario.Controladores;
using ControlInventario.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventario_Formularios
{
    public partial class FRegistroProductos : Form
    {
        CProducto cProducto = new CProducto();
        CLinea cLinea = new CLinea();
        Producto producto = new Producto();


        public FRegistroProductos(Producto p = null)
        {
            InitializeComponent();
            producto = p;
        }

        private void FRegistroProductos_Load(object sender, EventArgs e)
        {
            lineaBindingSource.DataSource = cLinea.Consultar();

            if (producto == null)
                productoBindingSource.AddNew(); // para registrar uno nuevo
            else
                productoBindingSource.DataSource = producto; // para editar uno existente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto = (Producto)productoBindingSource.Current;

            if (producto.IdProducto == 0)
                cProducto.Insertar(producto);
            else
                cProducto.Actualizar(producto);

            this.Close();
        }
    }
}
