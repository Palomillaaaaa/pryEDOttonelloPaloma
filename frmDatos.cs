using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void pcbPaloma_Click(object sender, EventArgs e)
        {

        }

        private void pcbPaloma_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPagina_Click(object sender, EventArgs e)
        {
            EstructuraDeDatos estructuraDeDatos = new EstructuraDeDatos();
            estructuraDeDatos.ShowDialog();
        }
    }
}
