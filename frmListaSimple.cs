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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objLista.Agregar(x);
            objLista.Recorrer(dgvListaSimple);
            objLista.Recorrer(lstListaSimple);
            objLista.Recorrer(cmbListaSimple);
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

            if (objLista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbListaSimple.Text);
                objLista.Eliminar(x);
                objLista.Recorrer(dgvListaSimp);
                objLista.Recorrer(lstListaSimple);
                objLista.Recorrer(cmbListaSimple);

            }
            else
            {
                MessageBox.Show("La lista esta vacia");

            }
            btnEliminar.Enabled = false;
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaSimple.Text == "")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void dgvListaSimple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
