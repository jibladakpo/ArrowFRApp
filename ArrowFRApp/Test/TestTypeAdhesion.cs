using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrowFRApp;

namespace Test
{
    [TestClass]
    public class TestTypeAdhesion
    {
        
       
        [TestMethod]
        public void TestAjouterTypeAdhesion()
        {
            TypeAdhesionDB typeadhDB = new TypeAdhesionDB();
            TypeAdhesion ta = new TypeAdhesion("Test", 10);
            
            typeadhDB.Save(ta);
        }

        [TestMethod]
        public void TestModifierTypeAdhesion()
        {
            TypeAdhesionDB typeadhDB = new TypeAdhesionDB();
            
            TypeAdhesion a1 = typeadhDB.GetTypeAdhesion(7);
            a1.Libelle = "TestModif2";
            a1.Tarif = 20;

            typeadhDB.Save(a1);
        }

        [TestMethod]
        public void TestSupprimerTypeAdhesion()
        {
            TypeAdhesionDB adhesionDB = new TypeAdhesionDB();


            adhesionDB.Delete(6);
        }

    }
}
