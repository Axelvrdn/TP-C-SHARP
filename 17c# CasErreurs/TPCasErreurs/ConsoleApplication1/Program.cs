using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryLaPoste;


namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARATION DES VARIABLES UTILISABLES PARTOUT DANS LE MAIN
            String prenom;
            String poidsCourrierSaisi;
            ushort poidsCourrier;
            double leResultat;
            // FIN DECLARATION DES VARIABLES UTILISABLES PARTOUT DANS LE MAIN
          

            Console.Write("Veuillez entrer votre prénom :");
            prenom = Console.ReadLine();
            Console.WriteLine("la prénom saisi est " + prenom + " ! ");
            Console.WriteLine("Veuillez saisir le poids du courrier :");
            poidsCourrierSaisi = Console.ReadLine();
            poidsCourrier = ushort.Parse(poidsCourrierSaisi);
            leResultat = MesFonctions.calculTarifLettre(poidsCourrier);
            Console.Write(leResultat);
        
 
        }

       



      

       


        
    }
}
