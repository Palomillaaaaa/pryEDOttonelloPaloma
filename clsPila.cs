using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    internal class clsPila
    {
        private clsNodo pri;
        public clsNodo Primero
        {

            get { return pri; }
            set { pri = value; }
        }

        clsPila objPila = new clsPila();
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == null)
            {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
       


    }
}
