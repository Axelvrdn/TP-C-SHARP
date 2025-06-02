using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //String prenom; //déclaration de la variable prénom
            //Console.WriteLine("Comment t\'appelle tu ?");
            //Console.Write("Comment t\'appelle tu ?");
            //prenom = Console.ReadLine();
            //Console.WriteLine("Bonjour ,"+ prenom);
            int poids; //déclaration de la variable poids avec int (n'accepte que les chiffre entiers)
            float taille, imc; //déclaration de la variable taille et imc avec float (il accepte les virgule)
            Console.WriteLine("Combien pèse tu ?????");
            poids = int.Parse(Console.ReadLine());
            Console.WriteLine("Combien mesure tu ?????");
            taille = float.Parse(Console.ReadLine());
            imc = (poids / (taille * taille));
            Console.WriteLine(imc);
            //imc = Math.Round((poids / (taille * taille)),1);
            //Console.WriteLine(imc);
            if (imc < 10)
            {
                Console.WriteLine("Woauuuuuuuuuuuuh skinny");
            }
            else
            {
                Console.WriteLine("imc ok");
            }                    
        }
    }
}
