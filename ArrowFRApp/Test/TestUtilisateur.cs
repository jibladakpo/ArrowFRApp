using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrowFRApp;
using ArrowFRApp.DataAccessLayer;

namespace Test
{
    [TestClass]
    public class TestUtilisateur
    {
        [TestMethod]
        public void TestConnexion()
        {
            UtilisateurDB utilDB = new UtilisateurDB();
            utilDB.login = "User";
            utilDB.mdp = "123456";

            Assert.AreEqual(utilDB.login,"User");
            Assert.AreEqual(utilDB.mdp, "123456");

        }

        public void TestDeconexion()
        {

        }
    }
}
