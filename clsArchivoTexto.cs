using System;
using System.IO;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    internal class clsArchivoTexto
    {
        public String NomArchi = "";


    


        public void Borrar()
        {
            StreamWriter AD = new StreamWriter(NomArchi, false);
            AD.Close();
        }
        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();

        }

        public void Recorrer(ListBox lstdatos)
        {
            lstdatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstdatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();

            }
            AD.Close();
        }
    }
}

