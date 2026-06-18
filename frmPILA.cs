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
    public partial class frmPILA : Form
    {
        public frmPILA()
        {
            InitializeComponent();
        }
      
        clsPila pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            pila.Agregar(x);
            pila.Recorrer(dgvPila);
            pila.Recorrer(lstPila);
            pila.Recorrer("Pila.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";


        }

        private void lstPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Primero != null)
            {
                lblCodigo.Text = pila.Primero.Codigo.ToString();
                lblNombre.Text = pila.Primero.Nombre;
                lblTramite.Text = pila.Primero.Tramite;
                pila.Eliminar();
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
                pila.Recorrer("Pila.csv");
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }

        private void frmPILA_Load(object sender, EventArgs e)
        {

        }
    }
}

