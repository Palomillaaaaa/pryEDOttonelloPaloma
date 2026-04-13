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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objAlumnos= new clsArchivoTexto();
            objAlumnos.NomArchi = "Clientes.csv";
            objAlumnos.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objAlumnos.Recorrer(dgvAlumnos);

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivoTexto objAlumnos = new clsArchivoTexto();
            objAlumnos.NomArchi = "Clientes.csv";
            objAlumnos.Recorrer(dgvAlumnos);

            clsArchivoTexto X = new clsArchivoTexto();
            X.NomArchi = "CARRERA.CSV";
            if (File.Exists(X.NomArchi)) X.Recorrer(dgvAlumnos);
        }
    }
}
