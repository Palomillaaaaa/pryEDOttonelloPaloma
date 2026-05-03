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

        clsListaSimple objLista = new clsListaSimple();
        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x  = new clsNodo();
            x.Codigo = Convert.ToInt32(txtNombre.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objLista.Agregar(x);
            objLista.Recorrer(dvgLista);
            // objLista.Recorrer(cmbLista);
            // objLista.Recorrer(lstLista);
            objLista.Recorrer("clsListaSimple.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else 
            {
            btnAgregar.Enabled = false;
            }
            
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void lstPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDatoTramite_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
