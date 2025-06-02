using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp20_classe_bliblio
{
    class Grade
    {
        private string code;
        private string libelle;
        private double taux;


        //Constructeurs
        public Grade()
        {

        }
        public Grade (string cd,string lib,double tx)
        {
            this.code = cd;
            this.libelle = lib;
            this.taux = tx;
        }

        //Accesseurs
        public string getcode()
        {
            return this.code;
        }
        public string getlibelle()
        {
            return this.libelle;
        }
        public double gettaux()
        {
            return this.taux;
        }
        public string toString()
        {
            String contenueObjet;
            contenueObjet = this.code;
            contenueObjet += this.libelle;
            contenueObjet += this.taux;
            return contenueObjet;
        }



        //Modificateur
        public void setcode(string cd)
        {
            this.code = cd;
        }
        public void setlibelle(string lib)
        {
            this.libelle = lib;
        }
        public void settaux(int tx)
        {
            this.taux = tx;
        }
    }
}
