using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdBarberoB  // ← mantené tu namespace original
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario objArbol = new clsArbolBinario();

        private void frmArbol_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Cod = Convert.ToInt32(txtCodigo.Text);
            x.Nom = txtNombre.Text;
            x.Tra = txtTramite.Text;

            objArbol.Agregar(x);
            objArbol.Recorrer(dgvArbol);
            objArbol.Recorrer(cmbCodigo);
            objArbol.Recorrer(trvArbolBinario);

            int cantidadNodos = dgvArbol.Rows.Count;
            clsNodo[] vectorDeNodos = new clsNodo[cantidadNodos];
            objArbol.Recorrer(vectorDeNodos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.Text != "")
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
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

        private void rbInOrden_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbInOrden.Checked) objArbol.Recorrer(dgvArbol);
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbPreOrden.Checked) objArbol.RecorrerPreOrden(dgvArbol);
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbPostOrden.Checked) objArbol.RecorrerPostOrden(dgvArbol);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            if (objArbol.Raiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            objArbol.Equilibrar();
            objArbol.Recorrer(dgvArbol);
            objArbol.Recorrer(cmbCodigo);
            objArbol.Recorrer(trvArbolBinario);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cmbCodigo.SelectedItem);

            objArbol.Eliminar(codigo);
            objArbol.Recorrer(dgvArbol);
            objArbol.Recorrer(cmbCodigo);
            objArbol.Recorrer(trvArbolBinario);

            btnEliminar.Enabled = false;
        }

      
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }
    }
}