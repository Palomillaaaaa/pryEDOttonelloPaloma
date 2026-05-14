using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;
        private clsNodo Nvo;
        
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else 
            {
                if (Nvo.Codigo < Primero.Codigo)
                {
                    Ultimo.Siguiente = Nvo;
                    Nvo.Anterior = Ultimo;
                    Ultimo = Nvo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (aux.Codigo < Nvo.Codigo) 
                    {
                    ant = aux;
                        aux = aux.Siguiente ;
                    }
                }  
            }
       
        
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(String NombreArchivo)
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de espera/n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.Write(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
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
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }

        }
        public void Eliminar(Int32 Cod)
        {
            if (Primero.Codigo == Cod && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Cod)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Cod)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < Cod)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.Anterior = ant;
                    }
                }
            }
        }
    }
}
