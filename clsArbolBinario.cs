using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    internal class clsArbolBinario
    {

        private clsNodo Pri;

        public clsNodo Raiz
        {
            get { return Pri; }
            set { Pri = value; }
        }
        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo p = Raiz;//ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    p = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }

                if (Nvo.Codigo < p.Codigo) p.Izquierdo = Nvo.Izquierdo;
                else p.Derecho = Nvo;
            }
        }

        public void Recorrer (DataGridView Grilla) 
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        private void InOrdenAsc (DataGridView Dgv, clsNodo R) 
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if(R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Rows.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst,R.Izquierdo);
            Lst.Items.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }
    }
}
