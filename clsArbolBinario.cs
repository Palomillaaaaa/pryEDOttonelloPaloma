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
                clsNodo p = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    p = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
               
                if (Nvo.Codigo < p.Codigo) p.Izquierdo = Nvo;
                else p.Derecho = Nvo;
            }
        }

        public void Eliminar(Int32 codigo)
        {
            Raiz = EliminarNodo(Raiz, codigo);
        }

        private clsNodo EliminarNodo(clsNodo R, Int32 codigo)
        {
            if (R == null)
            {
                MessageBox.Show("El código no existe en el árbol.");
                return null;
            }
            if (codigo < R.Codigo) R.Izquierdo = EliminarNodo(R.Izquierdo, codigo);
            else if (codigo > R.Codigo) R.Derecho = EliminarNodo(R.Derecho, codigo);
            else
            {
                if (R.Izquierdo == null && R.Derecho == null) return null;
                else if (R.Izquierdo == null) return R.Derecho;
                else if (R.Derecho == null) return R.Izquierdo;
                else
                {
                    clsNodo sucesor = BuscarMinimo(R.Derecho);
                    R.Codigo = sucesor.Codigo;
                    R.Nombre = sucesor.Nombre;
                    R.Tramite = sucesor.Tramite;
                    R.Derecho = EliminarNodo(R.Derecho, sucesor.Codigo);
                }
            }
            return R;
        }

        private clsNodo BuscarMinimo(clsNodo R)
        {
            while (R.Izquierdo != null)
                R = R.Izquierdo;
            return R;
        }

        
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }

        
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        private void PreOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null)
            {
                grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
                PreOrden(grilla, R.Izquierdo);
                PreOrden(grilla, R.Derecho);
            }
        }

       
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        private void PostOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null)
            {
                PostOrden(grilla, R.Izquierdo);
                PostOrden(grilla, R.Derecho);
                grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            }
        }

        
        public void Recorrer(clsNodo[] vector)
        {
            int ind = 0;
            if (Raiz != null)
                InOrdenAsc(vector, ref ind, Raiz);
        }

        private void InOrdenAsc(clsNodo[] vec, ref int ind, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(vec, ref ind, R.Izquierdo);
            vec[ind] = R;
            ind++;
            if (R.Derecho != null) InOrdenAsc(vec, ref ind, R.Derecho);
        }

       
        public void Recorrer(ComboBox Lista)
        {
            
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }

        
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(nodoPadre);
            PreOrden(Raiz, nodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode nodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(nodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, nodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, nodoPadre);
        }

       
        public void Equilibrar()
        {
            int cantidad = ContarNodos(Raiz);
            if (cantidad <= 1) return;
            clsNodo[] vector = new clsNodo[cantidad];
            Recorrer(vector);
            Raiz = null;
            InsertarBalanceado(vector, 0, cantidad - 1);
        }

        private int ContarNodos(clsNodo R)
        {
            if (R == null) return 0;
            return 1 + ContarNodos(R.Izquierdo) + ContarNodos(R.Derecho);
        }

        private void InsertarBalanceado(clsNodo[] vector, int inicio, int fin)
        {
            if (inicio > fin) return;
            int medio = (inicio + fin) / 2;
            vector[medio].Izquierdo = null;
            vector[medio].Derecho = null;
            Agregar(vector[medio]);
            InsertarBalanceado(vector, inicio, medio - 1);
            InsertarBalanceado(vector, medio + 1, fin);
        }
    }
}