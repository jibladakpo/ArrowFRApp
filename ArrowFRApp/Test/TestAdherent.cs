using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrowFRApp;

namespace Test
{
    [TestClass]
    public class TestAdherent
    {
    
        [TestMethod]
        public void TestAjouterAdherent()
        {
            AdherentDB adhDB = new AdherentDB();
            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            TypeAdhesion t = typeDB.GetTypeAdhesion(1);
            DateTime dt = new DateTime(1994, 6, 23);
            string date = dt.ToString("dd-MMM-yyyy");
            ArrowFRApp.Adherent a = new ArrowFRApp.Adherent("DucherA", "PierreA", Convert.ToDateTime(date), "Alençon", "61000", t);
            adhDB.Save(a);

        }

        [TestMethod]
        public void TestModifierAdherent()
        {

            AdherentDB adhDB = new AdherentDB();
            AdherentDB adhesionDB = new AdherentDB();
            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            Adherent a1 = adhDB.GetAdherent(31);
            TypeAdhesion t = typeDB.GetTypeAdhesion(2);
            DateTime dt = new DateTime(1993, 5, 22);
            string date = dt.ToString("dd-MMM-yyyy");
            a1.SetNom("DuchéM");
            a1.SetPrenom("PierresM");
            a1.SetDateNaissance(Convert.ToDateTime(date));
            a1.SetVille("TestVille");
            a1.SetCodePostal("61000");
            a1.SetTypeAdherent(t);
            adhDB.Save(a1);
        }

        [TestMethod]

        public void TestSupprimerAdherent()
        {
            AdherentDB adhDB = new AdherentDB();

            adhDB.Delete(28);
        }
    }
}
