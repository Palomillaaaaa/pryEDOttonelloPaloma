using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
