using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FournisseurEtArticle;

namespace UnitTestProject2_21_05
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testGetId()
        {
            Fournisseur f2 = new Fournisseur("EF184", "Oui", "Lapointe", "59113", "Seclin", "3630");
            string resultatAttendu = "EF184";
            string resultatRenvoye = f2.getId();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas getID");
        }
        [TestMethod]
        public void testGetRue()
        {
            Fournisseur f2 = new Fournisseur("EF184", "Oui", "Lapointe", "59113", "Seclin", "3630");
            string resultatAttendu = "Lapointe";
            string resultatRenvoye = f2.getRue();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas getRue");
        }
        [TestMethod]
        public void testGetTelephone()
        {
            Fournisseur f2 = new Fournisseur("EF184", "Oui", "Lapointe", "59113", "Seclin", "3630");
            string resultatAttendu = "3630";
            string resultatRenvoye = f2.getTelephone();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas getTelephone");
        }
        public void testSetId()
        {
            Fournisseur f1 = new Fournisseur();
            f1.setId("EF184");
            string resultatAttendu = "EF184";
            string resultatRenvoye = f1.getId();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setID  → EF184");
            f1.setId("");
            resultatAttendu = "";
            resultatRenvoye = f1.getId();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setID EF184 → ");
        }
        [TestMethod]
        public void testSetRue()
        {
            Fournisseur f1 = new Fournisseur();
            f1.setRue("Lapointe");
            string resultatAttendu = "Lapointe";
            string resultatRenvoye = f1.getRue();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setRue  → Lapointe");
            f1.setRue("");
            resultatAttendu = "";
            resultatRenvoye = f1.getRue();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setRue Lapointe → ");
        }
        [TestMethod]
        public void testSetTelephone()
        {
            Fournisseur f1 = new Fournisseur();
            f1.setTelephone("3630");
            string resultatAttendu = "3630";
            string resultatRenvoye = f1.getTelephone();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setTelephone → 3630");
            f1.setTelephone("");
            resultatAttendu = "";
            resultatRenvoye = f1.getTelephone();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setTelephone 3630 → ");
        }

        [TestMethod]
        public void testGetArticle()
        {
            Fournisseur f2 = new Fournisseur("EF184", "Oui", "Lapointe", "59113", "Seclin", "3630");
            Article a1 = new Article("blue", f2);
            Fournisseur resultatAttendu = f2;
            Fournisseur resultatRenvoye = a1.getLeFournisseur();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas getLeFournisseur");
        }

        [TestMethod]
        public void testSetArticle()
        {
            Fournisseur f2 = new Fournisseur("EF184", "Oui", "Lapointe", "59113", "Seclin", "3630");
            Fournisseur f1 = new Fournisseur();
            Article a1 = new Article("blue", f1);
            a1.setLeFournisseur(f2);
            Fournisseur resultatAttendu = f2;
            Fournisseur resultatRenvoye = a1.getLeFournisseur();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setLeFournisseur f1 → f2");
            a1.setLeFournisseur(f1);
            resultatAttendu = f1;
            resultatRenvoye = a1.getLeFournisseur();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setLeFournisseur f2 → f1");
        }

        [TestMethod]
        public void testaugmenterstock()
        {
            Fournisseur f2 = new Fournisseur("EF184", "Oui", "Lapointe", "59113", "Seclin", "3630");
            Article a1 = new Article("blue", f2);
            a1.setQteStockPlus(13);
            int resultatAttendu = 13;
            int resultatRenvoye = a1.getQteStock();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setQteStockPlus augmentation (0+13)");
            a1.setQteStockPlus(13);
            resultatAttendu = 26;
            resultatRenvoye = a1.getQteStock();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setQteStockPlus augmentation (13+13)");
        }

        [TestMethod]
        public void testdiminuestock()
        {
            Fournisseur f2 = new Fournisseur("EF184", "Oui", "Lapointe", "59113", "Seclin", "3630");
            Article a1 = new Article("blue", f2);
            a1.setQteStockPlus(-13);
            int resultatAttendu = -13;
            int resultatRenvoye = a1.getQteStock();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setQteStockPlus diminution (0-13)");
            a1.setQteStockPlus(-13);
            resultatAttendu = -26;
            resultatRenvoye = a1.getQteStock();
            Assert.AreEqual(resultatAttendu, resultatRenvoye, "cas setQteStockPlus diminution (-13-13)");
        }
    }
}
