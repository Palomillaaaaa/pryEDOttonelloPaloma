using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    internal class clsListaSimple
    {
        private clsNodo pri;


        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Nuevo == null)

            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (aux.Codigo < Nuevo.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null) break;
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
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

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else 
            {
            clsNodo aux1 = Primero;
            clsNodo aux2 = Primero;
                while (aux1.Codigo != Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                }
                aux2.Siguiente = aux1.Siguiente;
            }
        }
    }
}
