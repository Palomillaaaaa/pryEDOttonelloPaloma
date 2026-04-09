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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.Grabar(txtNombre.Text);

            clsArchivoTexto objCarreras = new clsArchivoTexto();
            objCarreras.NomArchi = "Carreras.cvs";
            objCarreras.Grabar(txtNombre.Text);
            objCarreras.Recorrer(lstCarrera);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                btnGrabar.Enabled = false;

            }
            else
            {

                btnGrabar.Enabled = true;
            }
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objCarreras = new clsArchivoTexto();
            objCarreras.NomArchi = "Carreras.cvs";
            objCarreras.Grabar(txtNombre.Text);
            objCarreras.Recorrer(lstCarrera);

        }

        private void lstCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
