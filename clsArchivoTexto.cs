using System;
using System.IO;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    internal class clsArchivoTexto
    {
        public String NomArchi = "";


        public void Grabar(String cod, String nom, String deu) 
        {
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.WriteLine(deu);
            AD.Close();
        }


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
            if (!File.Exists(NomArchi)) return;
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

        public void Recorrer(ComboBox cmb)
        {

            String DatoLeido = "";
            if (!File.Exists(NomArchi)) return;
            cmb.Items.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                cmb.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();

            }
            cmb.SelectedIndex = 0;
            AD.Close();
        }


        public void Recorrer(DataGridView Grilla)
        {

            
            String DatoLeido = "";
            if (!File.Exists(NomArchi)) return;
            Grilla.Rows.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                Grilla.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();

            }
            AD.Close();

           
        }
    }
}

