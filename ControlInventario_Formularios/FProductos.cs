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
    public partial class FProductos : Form
    {
        // 1 Invocar el controlador de la entidad
        CProducto cProducto = new CProducto();
        CLinea cLinea = new CLinea();

        public FProductos()
        {
            InitializeComponent();
        }

        private void FProductos_Load(object sender, EventArgs e)
        {
            //2 llenar el datasource del bindingsource secundario
            lineaBindingSource.DataSource = cLinea.Consultar();

            

            //3 llenar el datasource del bindingsource primario
            productoBindingSource.DataSource = cProducto.Consultar();
        }

        private void productoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto producto = new Producto();
            producto = (Producto)productoBindingSource.Current;

            FRegistroProductos formulario = new FRegistroProductos(producto);
            formulario.ShowDialog();
            //Cargar nuevamente los datos
            productoBindingSource.DataSource = cProducto.Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRegistroProductos formulario = new FRegistroProductos();
            formulario.ShowDialog();
            //Cargar nuevamente los datos
            productoBindingSource.DataSource = cProducto.Consultar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto = (Producto)productoBindingSource.Current;

            cProducto.Eliminar(producto);
            //Cargar nuevamente los datos
            productoBindingSource.DataSource = cProducto.Consultar();
        }
    }
}
