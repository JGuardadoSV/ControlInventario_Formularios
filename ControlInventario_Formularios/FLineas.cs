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
    public partial class FLineas : Form
    {
        // Referencia a los controladores
        CLinea cLinea = new CLinea();

        public FLineas()
        {
            InitializeComponent();
        }

        private void FLineas_Load(object sender, EventArgs e)
        {
            lineaBindingSource.DataSource = cLinea.Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRegistroLineas formulario = new FRegistroLineas();
            formulario.ShowDialog();
            //Cargar nuevamente los datos
            lineaBindingSource.DataSource = cLinea.Consultar();
        }

        private void lineaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Linea linea = new Linea();
            linea = (Linea)lineaBindingSource.Current;

            FRegistroLineas formulario = new FRegistroLineas(linea);
            formulario.ShowDialog();
            //Cargar nuevamente los datos
            lineaBindingSource.DataSource = cLinea.Consultar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Linea linea = new Linea();
            linea = (Linea)lineaBindingSource.Current;

            cLinea.Eliminar(linea);
            //Cargar nuevamente los datos
            lineaBindingSource.DataSource = cLinea.Consultar();
        }
    }
}
