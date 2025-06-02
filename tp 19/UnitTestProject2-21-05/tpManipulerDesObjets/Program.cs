using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FournisseurEtArticle;

namespace tpManipulerDesObjets
{
    class Program
    {
        static void Main(string[] args)
        {
            Fournisseur f1 = new Fournisseur();
            Fournisseur f2 = new Fournisseur("EF184","Oui","Lapointe","59113","Seclin","3630");
            Fournisseur f3 = new Fournisseur("EF185", "Oui");
            Console.WriteLine(f2.getId());
            Console.WriteLine(f2.getRaisonSociale());
            Console.WriteLine(f2.getRue());
            Console.WriteLine(f2.getCp());
            Console.WriteLine(f2.getVille());
            Console.WriteLine(f2.getTelephone());
            f1.setId("EF186");
            f1.setAdresse("Cheztoi", "59000" , "Lille");
            f1.setRaisonSociale("Non");
            f3.setCp("59753");
            f3.setRue("EnBas");
            f3.setVille("Là");
            f3.setTelephone(f2.getTelephone());
            Console.WriteLine(f3.toString());

            Article a1 = new Article("blue", f2);
            Console.WriteLine(a1.getId());
            Console.WriteLine(a1.getLibelle());
            Console.WriteLine(a1.getPrixVente());
            Console.WriteLine(a1.getQteStock());
            Console.WriteLine(a1.getTeteGondole());
            Console.WriteLine(a1.getLeFournisseur());
            a1.setLibelle("red");
            a1.setPrixVente(3630);
            a1.setTeteGondole(false);
            a1.setLeFournisseur(f3);
            a1.setQteStockPlus(13);
            a1.toString();
            Console.WriteLine(a1.getLeFournisseur().toString());
        }
    }
}
