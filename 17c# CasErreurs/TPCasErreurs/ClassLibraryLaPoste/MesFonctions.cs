using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLaPoste
{
    public static class MesFonctions
    {
        public static Double calculTarifLettre(ushort poidsRecu)
        {
            Double tarif;


            if (poidsRecu >= 2000)
                tarif = 6.04;
            else
            {
                if (poidsRecu >= 1000)
                    tarif = 5.16;
                else
                {
                    if (poidsRecu >= 500)
                        tarif = 3.92;
                    else
                    {
                        if (poidsRecu >= 250)
                            tarif = 3.02;
                        else
                        {
                            if (poidsRecu >= 100)
                                tarif = 2.22;
                            else
                            {
                                if (poidsRecu >= 50)
                                    tarif = 1.35;
                                else
                                {
                                    if (poidsRecu >= 20)
                                        tarif = 0.9;
                                    else
                                        tarif = 0.56;

                                }
                            }
                        }
                    }
                }
            }

            return tarif;
        }
    }
}
