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
    public partial class FRegistroLineas : Form
    {
        CLinea cLinea = new CLinea();
        Linea linea = new Linea();
        public FRegistroLineas(Linea linea=null)
        {
            InitializeComponent();
            this.linea = linea;
        }

        private void FRegistroLineas_Load(object sender, EventArgs e)
        {
            if (linea==null) // se creara uno nuevo
                lineaBindingSource.AddNew();
            else // se va a actualizar uno existente
                lineaBindingSource.DataSource = linea;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            linea = new Linea();
            linea = (Linea)lineaBindingSource.Current;

            if (linea.IdLinea==0)
                cLinea.Insertar(linea);
            else
                cLinea.Actualizar(linea);
            
            this.Close();
        }
    }
}
