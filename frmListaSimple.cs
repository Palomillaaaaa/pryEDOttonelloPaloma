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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
            
        }

        clsPila objPila = new clsPila();
        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x  = new clsNodo();
            x.Codigo = Convert.ToInt32(txtNombre.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(dvgPila);
            objPila.Recorrer("clsPila.csv");
            objPila.Recorrer(lstPila);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
