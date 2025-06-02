using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eval01B2
{
    public class MesFPmetier
    {
        /// <summary>
        /// calcule le montant de l'indemnité kilométrique
        /// en fonction du nombre de kilomètres reçu en paramètre
        /// </summary>
        /// <param name="distance">nombre de kilomètres parcourus</param>
        /// <returns>le montant de l'indemnité</returns>
        public static Double calculIndemKilo(Int32 distance)
        {
            Double[] tarifs = new double[] { 0.2, 0.25, 0.3 };
            Int16 trancheMax = 20000;
            Int32 tranchInter = 50000;
            Double montant;
            if (distance >= trancheMax)
                montant = distance * tarifs[0];
            else
            {
                if (distance > tranchInter)
                    montant = distance * tarifs[1];
                else
                    montant = distance * tarifs[2];
            }
            return montant;
        }

        /// <summary>
        /// calcule le montant de l'indemnité des repas
        /// </summary>
        /// <param name="nbrepas">nombre de repas pris par le salarié</param>
        /// <returns>le montant de l'indemnité</returns>
        public static int calculIndemRepas(int nbrepas)
        {
            int tarifRepas = 15;
            int montant;
            montant = tarifRepas * nbrepas;
            return montant;
        }

    }
}
