using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonctionPartie2
{
    public class Class1
    {
        public string Fonction(int mois)
        {
            string[] listeMois = ["Janvier", "Fevrier", "Mars", "Avril", "Mais", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Decembre"];
            if (mois < 12)
            {
                if (mois >= 0)
                {
                    mois = mois - 1;
                    return listeMois[mois];
                }
            }

        }

    }
}
