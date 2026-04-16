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
    public partial class EstructuraDeDatos : Form
    {
        public EstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmDatosDelDesarrollador v = new frmDatosDelDesarrollador();
            //v.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses vMeses = new frmMeses();
            vMeses.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores vColores = new frmColores();
            vColores.ShowDialog();
        }

        private void EstructuraDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void programacionOrientadaAObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras vcarreras = new frmCarreras();
            vcarreras.ShowDialog();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes vclientes = new frmClientes();
            vclientes.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos vAlumnos = new frmAlumnos();
            vAlumnos.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraLinealCola VCola = new frmEstructuraLinealCola();
            VCola.ShowDialog();
        }
    }
}
