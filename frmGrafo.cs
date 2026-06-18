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

        clsGrafo objGrafo = new clsGrafo();

        
        private void frmGrafo_Load(object sender, EventArgs e)
        {
            objGrafo.MostrarCiudades(cmbOrigen);
            objGrafo.MostrarCiudades(cmbDestino);
            objGrafo.MostrarCiudades(cmbListaSimple);  
            objGrafo.MostrarCiudades(cmbHasta);
            objGrafo.MostrarCiudades(cmbOrigen2);
            objGrafo.MostrarCiudades(cmbDestino2);

            btnCargar.Enabled = false;
            btnBorrar.Enabled = false;
            btnConsulta.Enabled = false;       
            btnListarDestinos.Enabled = false;
            btnListar.Enabled = false;         
            btnTodoViajes.Enabled = false;     
        }

        
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
                btnConsulta.Enabled = true;    
                btnBorrar.Enabled = true;
            }
            else
            {
                btnConsulta.Enabled = false;   
                btnBorrar.Enabled = false;
            }
        }

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

        private void cmbOrigen2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarElementoEliminado();
        }

        private void cmbDestino2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarElementoEliminado();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
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

       
        private void cmbListaSimple_SelectedIndexChanged(object sender, EventArgs e)  
        {
            btnListarDestinos.Enabled = cmbListaSimple.SelectedIndex != -1;
        }

        private void cmbHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHasta.SelectedIndex != -1)
            {
                btnListar.Enabled = true;          
                btnTodoViajes.Enabled = true;      
            }
            else
            {
                btnListar.Enabled = false;
                btnTodoViajes.Enabled = false;
            }
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            Int32 f = cmbListaSimple.SelectedIndex;  
            objGrafo.MostrarDestinos(f, dgvGrafo);
        }

        private void btnListar_Click(object sender, EventArgs e)     
        {
            Int32 c = cmbHasta.SelectedIndex;
            objGrafo.MostrarOrigenes(c, dgvGrafo);
        }

        private void btnTodoViajes_Click(object sender, EventArgs e) 
        {
            objGrafo.MostrarTodo(dgvGrafo);
        }
    }
