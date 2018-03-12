using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrowFRApp;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Test
{
    [TestClass]
    public class TestRecapitulatif
    {
        [TestMethod]
        public void TestNbAdherent()
        {
            AdherentDB adhDB = new AdherentDB();
            adhDB.NbAdherent();
        }

        [TestMethod]
        public void TestMontantAdhesion()
        {
            AdherentDB adhDB = new AdherentDB();
            adhDB.MontantAdhesion();
        }

        [TestMethod]
        public void TestNbAdhesionParType()
        {
            TypeAdhesionDB adhesionDB = new TypeAdhesionDB();
            List<ArrowFRApp.TypeAdhesion> lesTypesAdhesions = adhesionDB.GetAllTypeAdhesion();
            foreach (var item in lesTypesAdhesions)
            {
                ListViewItem listItem = new ListViewItem(item.Libelle);             
                listItem.SubItems.Add(Convert.ToString(adhesionDB.MontantAdhesionParType(item.Libelle)));


            }
        }

        [TestMethod]
        public void TestMtAdhesionParType()
        {
            TypeAdhesionDB adhesionDB = new TypeAdhesionDB();
            List<ArrowFRApp.TypeAdhesion> lesTypesAdhesions = adhesionDB.GetAllTypeAdhesion();
            foreach (var item in lesTypesAdhesions)
            {
                ListViewItem listItem = new ListViewItem(item.Libelle);
                listItem.SubItems.Add(Convert.ToString(adhesionDB.NbAdhesionParType(item.Libelle)));

            }
        }
    }
}
