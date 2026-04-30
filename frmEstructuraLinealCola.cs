using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    public partial class frmEstructuraLinealCola : Form
    {
        public frmEstructuraLinealCola()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void grbNuevoElemento_Enter(object sender, EventArgs e)
        {

        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {

        }

        clsCola ColaEspera = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtNombre.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ColaEspera.Agregar(Persona);
            ColaEspera.Recorrer(dvgCola);
            ColaEspera.Recorrer("Cola.csv");
            ColaEspera.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null) 
            {
                lblCodigo.Text = ColaEspera.Primero.Codigo.ToString();
                lblNombre.Text = ColaEspera.Primero.Nombre;
                lblTramite.Text = ColaEspera.Primero.Tramite;

                ColaEspera.Eliminar();
                ColaEspera.Recorrer(dvgCola);
                ColaEspera.Recorrer("Cola.csv");
                ColaEspera.Recorrer(lstCola);
            }
            else 
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";

            }
        }

        private void frmEstructuraLinealCola_Load(object sender, EventArgs e)
        {

        }


      

        private void grbListaYGrilla_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
