using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEdBarberoB
{
    internal class clsListaDoble
    {
        public void Agregar(clsNodo) 
        {
            if (Priero == null)
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
                    Ultio = Nvo;
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
