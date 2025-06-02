using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMdp()
        {
            string mdp = "GtuhY012#";
            Boolean resultatAttendu = true;
            Boolean resultatRenvoye = ClasseDeFonctions.MesFonctions.verifMDP(mdp);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas mdp est correcte");
            mdp = "Unmdp";
            resultatAttendu = false;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.verifMDP(mdp);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas mdp est incorrect aléatoire");
            mdp = "GtUhY012";
            resultatAttendu = false;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.verifMDP(mdp);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas mdp est incorrect avec majuscule");
            mdp = " GtUhY012";
            resultatAttendu = true;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.verifMDP(mdp);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas mdp est correcte avec espace");
        }

        [TestMethod]
        public void TestMin()
        {
            int nb1 = 5,nb2 = 10;
            int resultatAttendu = 5;
            int resultatRenvoye = ClasseDeFonctions.MesFonctions.min(nb1,nb2);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas nb1 plus petit");
            nb1 = 18;
            resultatAttendu = 10;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.min(nb1,nb2);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas nb2 plus petit");
            nb1 = 10;
            resultatAttendu = 10;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.min(nb1, nb2);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas nb1 = nb2");
            nb1 = -18;
            resultatAttendu = -18;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.min(nb1, nb2);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas nb1 est négatif");
            nb2 = -5;
            resultatAttendu = -18;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.min(nb1, nb2);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas nb2 est négatif");
        }
        [TestMethod]
        public void TestASCI()
        {
            string laLettre = "a";
            int resultatAttendu = 97;
            int resultatRenvoye = ClasseDeFonctions.MesFonctions.codeAscii(laLettre);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas a = 97");
            laLettre = "A";
            resultatAttendu = 65;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.codeAscii(laLettre);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas A = 65");
            //laLettre = "É";
            //resultatAttendu = 144;
            //resultatRenvoye = ClasseDeFonctions.MesFonctions.codeAscii(laLettre);
            //Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas É ");
            laLettre = "!";
            resultatAttendu = 33;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.codeAscii(laLettre);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas symbole");
            laLettre = "5";
            resultatAttendu = 53;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.codeAscii(laLettre);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas chiffre");
        }
        [TestMethod]
        public void TestfaitCalcul()
        {
            int nb1 = 1, nb2 = 1;
            string codeOpe = "a";
            double resultatAttendu = 2;
            double resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2,codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 1+1");
            nb1 = -2;
            resultatAttendu = -1;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas -2+1");
            nb1 = 0;
            resultatAttendu = 1;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 0+1");
            codeOpe = "s";
            resultatAttendu = -1;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 0-1");
            nb1 = 1;
            resultatAttendu = 0;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 1-1");
            nb1 = -1;
            resultatAttendu = -2;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas -1-1");
            codeOpe = "d";
            resultatAttendu = -1;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas -1/1");
            nb1 = 1;
            nb2 = 2;
            resultatAttendu = 0.5;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 1/2");
            nb1 = 2;
            nb2 = 4;
            resultatAttendu = 2;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 2/4");
            nb1 = 0;
            resultatAttendu = 0;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 0/4");
            nb1 = 4;
            nb2 = 0;
            resultatAttendu = 0;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            //Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 4/0");
            codeOpe = "m";
            resultatAttendu = 0;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 4*0");
            nb2 = 2;
            resultatAttendu = 8;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 4*2");
            nb1 = -2;
            resultatAttendu = -4;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas -2*2");
            nb2 = -2;
            resultatAttendu = 4;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.faitCalcul(nb1, nb2, codeOpe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas -2*-2");
        }
        [TestMethod]
        public void TestdonneImpot()
        {
            int age = 1;
            string sexe = "homme";
            Boolean resultatAttendu = false;
            Boolean resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age,sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas homme > 20");
            age = 20;
            resultatAttendu = true;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas homme = 20");
            age = 40;
            resultatAttendu = true;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas homme < 20");
            sexe = "Homme";
            resultatAttendu = true;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas H majuscule");
            sexe = " homme";
            resultatAttendu = true;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas espace dans le sexe");
            sexe = "femme";
            resultatAttendu = false;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas femmme > 35");
            age = 35;
            resultatAttendu = false;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas femmme = 35");
            age = 20;
            resultatAttendu = true;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas 18 < femmme < 35");
            age = 18;
            resultatAttendu = false;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas femmme = 18");
            age = 12;
            resultatAttendu = false;
            resultatRenvoye = ClasseDeFonctions.MesFonctions.donneImpot(age, sexe);
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas femmme < 18");
        }
    }
}
