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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FLineas formulario = new FLineas();
            formulario.ShowDialog();
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProductos formulario = new FProductos();
            formulario.ShowDialog();
            
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompras formulario = new FCompras();
            formulario.ShowDialog();
        }
    }
}
