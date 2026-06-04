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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }
        public partial class frmGrafo : Form
        {
            clsGrafos objGrafo = new clsGrafos();

            public frmGrafo()
            {
                InitializeComponent();
            }

            private void frmGrafo_Load(object sender, EventArgs e)
            {
                // Cargar ciudades en todos los ComboBox
                objGrafo.MostrarCiudades(cmbOrigen);
                objGrafo.MostrarCiudades(cmbDestino);
                objGrafo.MostrarCiudades(cmbDesde);
                objGrafo.MostrarCiudades(cmbHasta);
                objGrafo.MostrarCiudades(cmbOrigen2);
                objGrafo.MostrarCiudades(cmbDestino2);

                // Botones deshabilitados al inicio
                btnCargar.Enabled = false;
                btnBorrar.Enabled = false;
                btnConsultar.Enabled = false;
                btnListarDestinos.Enabled = false;
                btnListarOrigenes.Enabled = false;
                btnVerTodoLosViajes.Enabled = false;
            }

            // ──────────────────────────────────────────
            // MÉTODOS AUXILIARES
            // ──────────────────────────────────────────

            private void LimpiarNuevoElemento()
            {
                cmbOrigen.SelectedIndex = -1;
                cmbDestino.SelectedIndex = -1;
                txtPrecio.Text = "";
            }

            private void ValidarNuevoElemento()
            {
                if (cmbOrigen.SelectedIndex != -1 &&
                    cmbDestino.SelectedIndex != -1 &&
                    txtPrecio.Text != "")
                {
                    btnCargar.Enabled = true;
                    btnBorrarTodo.Enabled = true;
                }
                else
                {
                    btnCargar.Enabled = false;
                    btnBorrarTodo.Enabled = false;
                }
            }

            private void ValidarElementoEliminado()
            {
                if (cmbOrigen2.SelectedIndex != -1 && cmbDestino2.SelectedIndex != -1)
                {
                    btnConsultar.Enabled = true;
                    btnBorrar.Enabled = true;
                }
                else
                {
                    btnConsultar.Enabled = false;
                    btnBorrar.Enabled = false;
                }
            }

            // ──────────────────────────────────────────
            // SECCIÓN: NUEVO ELEMENTO
            // ──────────────────────────────────────────

            private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
            {
                ValidarNuevoElemento();
            }

            private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
            {
                ValidarNuevoElemento();
            }

            private void txtPrecio_TextChanged(object sender, EventArgs e)
            {
                ValidarNuevoElemento();
            }

            private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
            {
                // Solo permite números y la tecla de borrar
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            private void btnCargar_Click(object sender, EventArgs e)
            {
                Int32 f = cmbOrigen.SelectedIndex;
                Int32 c = cmbDestino.SelectedIndex;
                Decimal p = Convert.ToDecimal(txtPrecio.Text);
                objGrafo.Agregar(f, c, p);
                objGrafo.MostrarTodo(dgvGrafo);
                LimpiarNuevoElemento();
            }

            private void btnBorrarTodo_Click(object sender, EventArgs e)
            {
                objGrafo.BorrarTodo();
                objGrafo.MostrarTodo(dgvGrafo);
            }

            // ──────────────────────────────────────────
            // SECCIÓN: ELEMENTO ELIMINADO (Consultar/Borrar)
            // ──────────────────────────────────────────

            private void cmbOrigen2_SelectedIndexChanged(object sender, EventArgs e)
            {
                ValidarElementoEliminado();
            }

            private void cmbDestino2_SelectedIndexChanged(object sender, EventArgs e)
            {
                ValidarElementoEliminado();
            }

            private void btnConsultar_Click(object sender, EventArgs e)
            {
                Int32 f = cmbOrigen2.SelectedIndex;
                Int32 c = cmbDestino2.SelectedIndex;
                txtPrecio2.Text = Convert.ToString(objGrafo.Consultar(f, c));
            }

            private void btnBorrar_Click(object sender, EventArgs e)
            {
                Int32 f = cmbOrigen2.SelectedIndex;
                Int32 c = cmbDestino2.SelectedIndex;
                objGrafo.Eliminar(f, c);
                objGrafo.MostrarTodo(dgvGrafo);
                cmbOrigen2.SelectedIndex = -1;
                cmbDestino2.SelectedIndex = -1;
                txtPrecio2.Text = "";
            }

            // ──────────────────────────────────────────
            // SECCIÓN: LISTAR VIAJE
            // ──────────────────────────────────────────

            private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
            {
                btnListarDestinos.Enabled = cmbDesde.SelectedIndex != -1;
            }

            private void cmbHasta_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmbHasta.SelectedIndex != -1)
                {
                    btnListarOrigenes.Enabled = true;
                    btnVerTodoLosViajes.Enabled = true;
                }
                else
                {
                    btnListarOrigenes.Enabled = false;
                    btnVerTodoLosViajes.Enabled = false;
                }
            }

            private void btnListarDestinos_Click(object sender, EventArgs e)
            {
                Int32 f = cmbDesde.SelectedIndex;
                objGrafo.MostrarDestinos(f, dgvGrafo);
            }

            private void btnListarOrigenes_Click(object sender, EventArgs e)
            {
                Int32 c = cmbHasta.SelectedIndex;
                objGrafo.MostrarOrigenes(c, dgvGrafo);
            }

            private void btnVerTodoLosViajes_Click(object sender, EventArgs e)
            {
                objGrafo.MostrarTodo(dgvGrafo);
            }
        }
        private void grbListaYGrilla_Enter(object sender, EventArgs e)
        {

        }

        private void grbNuevoElemento_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
