using ControlInventario.Controladores;
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
    }
}
