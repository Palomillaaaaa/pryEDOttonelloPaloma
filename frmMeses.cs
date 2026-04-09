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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objMeses = new clsArchivoTexto();
            objMeses.NomArchi = "Meses.cvs";
            objMeses.Grabar(txtNombre.Text);
            objMeses.Recorrer(lstMeses);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") 
            {
                btnGrabar.Enabled = false;
            
            }
            else
            {
            
            btnGrabar.Enabled =true;
            }
        }
    }
}
